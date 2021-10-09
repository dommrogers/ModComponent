﻿using MelonLoader;
using System;
using UnityEngine;

namespace ModComponentMain
{
	public class Implementation : MelonMod
	{
		public override void OnApplicationStart()
		{
			//ModComponentMapper.TestFunctions.TestFunction();

			InitialLogStatements();
			Settings.instance.AddToModSettings("ModComponent");

			//ModComponentMapper.TestFunctions.TestFunction();

			ModComponentMapper.MapperCore.InitializeAndMapAssets();
		}

		private void InitialLogStatements()
		{
			Debug.Log($"[{Info.Name}] Version {Info.Version} loaded!");
			Logger.LogDebug("Debug Compilation");
			Logger.LogNotDebug("Release Compilation");
		}

		[Obsolete("Use ModComponentUtils.FileUtils.GetModsFolderPath instead")]
		public static string GetModsFolderPath() => ModComponentUtils.FileUtils.GetModsFolderPath();

		public static byte[][] GetItemPackHashes() => ModComponentMapper.ZipFileLoader.hashes.ToArray();
	}
}