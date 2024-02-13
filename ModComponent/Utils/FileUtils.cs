using System.Diagnostics;

namespace ModComponent.Utils;

internal static class FileUtils
{

	/*
[18:30:14.378] [ModComponent] MC File Bytes: 55|122|188|175|39 C:\Program Files (x86)\Steam\steamapps\common\TheLongDark\Mods\7z.modcomponent
[18:30:14.379] [ModComponent] Unsupported compression type '7z' for '7z.modcomponent'
[18:30:14.379] [ModComponent] MC File Bytes: 80|75|3|4|20 C:\Program Files (x86)\Steam\steamapps\common\TheLongDark\Mods\BonnieFoods.modcomponent
[18:30:14.380] [ModComponent] Unknown file compression BonnieFoods.modcomponent
[18:30:14.380] [ModComponent] MC File Bytes: 82|97|114|33|26 C:\Program Files (x86)\Steam\steamapps\common\TheLongDark\Mods\rar.modcomponent
[18:30:14.381] [ModComponent] Unsupported compression type 'rar' for 'rar.modcomponent'
[18:30:14.381] [ModComponent] MC File Bytes: 0|0|0|0|0 C:\Program Files (x86)\Steam\steamapps\common\TheLongDark\Mods\txt.modcomponent
[18:30:14.382] [ModComponent] Unknown file compression txt.modcomponent
[18:30:14.382] [ModComponent] MC File Bytes: 80|75|5|6|0 C:\Program Files (x86)\Steam\steamapps\common\TheLongDark\Mods\zip.modcomponent
	*/

	private static Dictionary<string, byte[]> headerTypes = new() {
		{ "zip-1", new byte[] { 0x50, 0x4b, 0x03, 0x04 } },
		{ "zip-2", new byte[] { 0x50, 0x4b, 0x05, 0x06 } },
		{ "zip-3", new byte[] { 0x50, 0x4b, 0x07, 0x08 } },
		{ "gzip-1", new byte[] { 0x1f, 0x8b }},
		{ "tar-1", new byte[] { 0x1f, 0x9d }},
		{ "lzh-1", new byte[] { 0x1f, 0xa0 }},
		{ "bzip-1", new byte[] { 0x42, 0x5a, 0x68 }},
		{ "lzip-1", new byte[] { 0x4c, 0x5a, 0x49, 0x50 }},
		{ "rar-1", new byte[] { 0x52, 0x61, 0x72, 0x21, 0x1a }},
		{ "7z-1", new byte[] { 0x37, 0x7a, 0xbc, 0xaf, 0x27 }},
	};


	private static byte[] GetFirstBytes(FileStream fs, int length)
	{
		fs.Seek(0, 0);
		var bytes = new byte[length];
		fs.Read(bytes, 0, length);
		return bytes;
	}

	internal static string? DetectZipFileType(FileStream fs)
	{
		var data = GetFirstBytes(fs, 5);

		Logger.LogDebug($"MC File Bytes: {data[0]}|{data[1]}|{data[2]}|{data[3]}|{data[4]} {fs.Name}");

		foreach (KeyValuePair<string, byte[]> headerType in headerTypes)
		{
			if (HeaderBytesMatch(headerType, data))
			{
				return headerType.Key.ToLowerInvariant().Split('-')[0];
			}
		}
		return null;
	}

	private static bool HeaderBytesMatch(KeyValuePair<string, byte[]> headerType, byte[] dataBytes)
	{
		if (dataBytes.Length < headerType.Value.Length)
		{
			return false;
		}

		for (var i = 0; i < headerType.Value.Length; i++)
		{
			if (headerType.Value[i] == dataBytes[i]) continue;

			return false;
		}
		return true;
	}

	internal static string GetRelativePath(string file, string directory)
	{
		if (file.StartsWith(directory))
		{
			return file.Substring(directory.Length + 1);
		}

		throw new ArgumentException("Could not determine relative path of '" + file + "' to '" + directory + "'.");
	}
}
