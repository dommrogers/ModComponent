using Harmony;
using Il2CppTLD.OptionalContent;
using MelonLoader.ICSharpCode.SharpZipLib.Zip;
using MelonLoader.Utils;
using System.IO.Compression;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ModComponent.Utils
{
	internal static class DependencyChecker
	{
		private static string depFileUrl = @"https://raw.githubusercontent.com/TLD-Mods/ModLists/master/dependency_files/modcomponent.json";
		private static List<string> filePaths = new List<string>();
		private static List<string> fileNames = new List<string>();

		private static List<DepEntry> BuildDepEntries = new List<DepEntry>();
		private static List<DepEntry> GlobalDepEntries = new List<DepEntry>();
		private static List<DepEntry> UserDepEntries = new List<DepEntry>();

		private static List<ErrorEntry> DepErrors = new List<ErrorEntry>();


		internal static void RunChecks()
		{
			Logger.LogDebug($"----------------------------------");
			Logger.Log($"Running Dependency Checks..");
			ReadFiles();
			ReadGlobalDepEntries();
			ProcessDepEntries();
			ThrowErrors();
			Logger.LogDebug($"----------------------------------");
		}

		internal static void AddEntry(string MCFileName, string[] RequiresMCFileNames, bool RequiresDlc = false)
		{
			MCFileName = MCFileName.Replace(".modcomponent", null).ToLowerInvariant();
			RequiresMCFileNames = RequiresMCFileNames.Select(x => x.Replace(".modcomponent", null).ToLowerInvariant()).ToArray();
			DepEntry newDepEntry = new DepEntry() { Mod = MCFileName, RequiresDLC = RequiresDlc, Requires = RequiresMCFileNames };
			UserDepEntries.Add(newDepEntry);
		}



		private static void ProcessDepEntries()
		{

			Dictionary<string, DepEntry> uniqueDepEntries = new Dictionary<string, DepEntry>();

			foreach (var entry in BuildDepEntries)
			{
				if (!uniqueDepEntries.ContainsKey(entry.ToString()))
				{
					uniqueDepEntries.Add(entry.ToString(), entry);
				}
			}
			foreach (var entry in GlobalDepEntries)
			{
				if (!uniqueDepEntries.ContainsKey(entry.ToString()))
				{
					uniqueDepEntries.Add(entry.ToString(), entry);
				}
			}
			foreach (var entry in UserDepEntries)
			{
				if (!uniqueDepEntries.ContainsKey(entry.ToString()))
				{
					uniqueDepEntries.Add(entry.ToString(), entry);
				}
			}

			foreach (var depEntry in uniqueDepEntries)
			{
				ErrorEntry error = CheckDepEntry(depEntry.Value);
				if (!string.IsNullOrEmpty(error.Mod) && error.Missing.Count > 0)
				{
					DepErrors.Add(error);
				}
			}

			Logger.LogDebug($"ProcessDepEntries : {BuildDepEntries.Count} {GlobalDepEntries.Count} {UserDepEntries.Count} | {UserDepEntries.Count} => {DepErrors.Count}");

		}

		private static void ReadFiles()
		{
			string[] mcfiles = Directory.GetFiles(MelonEnvironment.ModsDirectory, "*.modcomponent");
			foreach (string mcfile in mcfiles)
			{
				string fileNameNoExt = Path.GetFileNameWithoutExtension(mcfile).ToLowerInvariant();
				filePaths.Add(mcfile);
				fileNames.Add(fileNameNoExt);
			}

			foreach (string filePath in filePaths)
			{
				using (var fileStream = new FileStream(filePath, FileMode.Open))
				{
					string fileName = Path.GetFileName(filePath);
					string? zipType = FileUtils.DetectZipFileType(fileStream);

					if (zipType != "zip")
					{
						fileStream.Dispose();
						return;
					}

					using (var zipArchive = new ZipArchive(fileStream, ZipArchiveMode.Read))
					{
						ZipArchiveEntry? buildEntry = null;
						foreach (var entry in zipArchive.Entries)
						{
							if(entry.Name.ToLowerInvariant() == "buildinfo.json")
							{
								buildEntry = entry;
							}
						}

						if (buildEntry != null)
						{
							using (StreamReader reader = new StreamReader(buildEntry.Open()))
							{
								string? data = reader.ReadToEnd();
								if (string.IsNullOrEmpty(data))
								{
									continue;
								}
								if (!data.Contains("Requires"))
								{
									continue;
								}

								BuildFileEntry buildFileEntry = JsonSerializer.Deserialize<BuildFileEntry>(data);
								if (buildFileEntry != null)
								{
									Logger.LogDebug($"buildinfo FOUND : {buildFileEntry.Name} {buildFileEntry.Requires.Length} {buildFileEntry.RequiresDLC}");
									if (buildFileEntry.Requires.Length > 0 || buildFileEntry.RequiresDLC)
									{
										buildFileEntry.Mod = Path.GetFileNameWithoutExtension(filePath);
										BuildDepEntries.Add(buildFileEntry.AsDepEntry());
									}
								}

							}
						}

					}
				}
			}

		}

		private static void ReadGlobalDepEntries()
		{
			string data = "";
			using (WebClient? client = new WebClient())
			{
				client.Headers["User-Agent"] = "ModComponent";
				data = client.DownloadString(depFileUrl);
			}

			if (!string.IsNullOrEmpty(data))
			{
				GlobalDepEntries = JsonSerializer.Deserialize<List<DepEntry>>(data);
			}

		}



		private static ErrorEntry? CheckDepEntry(DepEntry entry)
		{
			Logger.LogDebug($"Found DepEntry: {entry.ToString()}");

			ErrorEntry error = new ErrorEntry();
			error.Mod = entry.Mod;

			if (fileNames.Contains(entry.Mod.ToLowerInvariant()))
			{
				Logger.LogDebug($"Running DepEntry: {entry.ToString()}");
				List<string> missing = new List<string>();

				Logger.LogDebug($"Count: {entry.Requires.Length}");
				foreach (string required in entry.Requires)
				{
					Logger.LogDebug($"Checking for : {required}");

					if (!string.IsNullOrEmpty(required))
					{
						if (!fileNames.Contains(required.ToLowerInvariant()))
						{
							Logger.LogDebug($"Missing : {required}");
							missing.Add(required);
						}
					}
				}

				error.Missing = missing;

				if (entry.RequiresDLC)
				{
					Logger.LogDebug($"Checking for DLC");
					if (!OptionalContentManager.Instance.InstalledContent.ContainsKey("2091330"))
					{
						error.MissingDlc = true;
					}
				}

			}
			return error;
		}


		private static void ThrowErrors()
		{

			if (DepErrors.Count == 0)
			{
				return;
			}

			foreach (ErrorEntry error in DepErrors)
			{
				if (error.MissingDlc)
				{
					Logger.LogError($"MissingDLC: '{error.Mod}' requires DLC");
				}

				foreach (string missing in error.Missing)
				{
					Logger.LogError($"MissingDependency: '{error.Mod}' requires '{missing}'");
				}
			}
		}



		internal sealed class ErrorEntry
		{
			public string Mod { get; set; }
			public bool MissingDlc { get; set; } = false;
			public List<string> Missing { get; set; } = new List<string>();

			public override string ToString()
			{
				return string.Concat(Mod + "|" + MissingDlc + "|" + string.Join(",", Missing));
			}

		}

		internal sealed class DepEntry
		{
			public string Mod { get; set; }
			public bool RequiresDLC { get; set; } = false;
			public string[] Requires { get; set; } = Array.Empty<string>();

			public override string ToString()
			{
				return string.Concat(Mod + "|" + RequiresDLC + "|" + string.Join(",", Requires));
			}
		}

		internal sealed class BuildFileEntry
		{
			public string Mod { get; set; }
			public string Name { get; set; }
			public string Version { get; set; }
			public string Author { get; set; }
			public string[] Requires { get; set; }
			public bool RequiresDLC { get; set; }

			internal DepEntry AsDepEntry()
			{
				return new DepEntry() { Mod = this.Mod, RequiresDLC = this.RequiresDLC, Requires = this.Requires };
			}
		}

	}

}
