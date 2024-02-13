using HarmonyLib;
using Il2Cpp;
using Il2CppTLD.OptionalContent;
using MelonLoader;
using ModComponent.Utils;

namespace ModComponent;

internal class Implementation : MelonMod
{

	internal static bool runDeps = true;
	internal static bool isReady = false;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
	internal static Implementation instance;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

	public Implementation()
	{
		instance = this;
	}

	public override void OnInitializeMelon()
	{
		Logger.LogDebug("Debug Compilation");
		Logger.LogNotDebug("Release Compilation");

		Settings.instance.AddToModSettings("ModComponent");

		AssetBundleProcessor.Initialize();
	}

	[HarmonyPatch(typeof(GameManager), nameof(GameManager.Awake))]
	internal static class MC_Initialize
	{
		internal static void Prefix()
		{
			if (runDeps)
			{
				// run the dependency checks (once)
				DependencyChecker.RunChecks();
				runDeps = false;
			}
		}
	}

	// change to gamemanager awake or sceneload MainMenu ?
	[HarmonyPatch(typeof(Panel_Crafting), nameof(Panel_Crafting.Initialize))]
	internal static class MC_MapPrefabs
	{
		internal static void Prefix()
		{
			Logger.LogNotDebug("Panel_Crafting_Initialize");
			if (isReady == false)
			{
				AssetBundleProcessor.MapPrefabs();
				isReady = true;
			}
		}
	}

	public override void OnApplicationQuit()
	{
		AssetBundleProcessor.CleanupTempFolder();
	}

}
