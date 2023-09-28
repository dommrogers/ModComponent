using HarmonyLib;
using Il2Cpp;
using Il2CppTLD.OptionalContent;
using MelonLoader;
using ModComponent.Utils;

namespace ModComponent;

internal class Implementation : MelonMod
{

	internal static bool mapped = false;

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

	// change to gamemanager awake or sceneload MainMenu ?
	[HarmonyPatch(typeof(Panel_Crafting), nameof(Panel_Crafting.Initialize))]
	internal static class Panel_Crafting_Initialize
	{
		internal static void Prefix()
		{
			Logger.LogNotDebug("Panel_Crafting_Initialize");
			if (mapped == false)
			{
				AssetBundleProcessor.MapPrefabs();
				mapped = true;
			}
		}
	}

	public override void OnApplicationQuit()
	{
		AssetBundleProcessor.CleanupTempFolder();
	}

}
