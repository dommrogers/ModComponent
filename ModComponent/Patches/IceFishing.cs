using HarmonyLib;
using Il2Cpp;
using ModComponent.AssetLoader;

namespace ModComponent.Patches;

[HarmonyPatch(typeof(Panel_IceFishingHoleClear), nameof(Panel_IceFishingHoleClear.Launch))]
internal static class Panel_IceFishingHoleClear_Launch
{
	static bool callOnce = true;
	internal static void Prefix(Panel_IceFishingHoleClear __instance)
	{
		if (callOnce) {
			__instance.AddAlternateTools();
			callOnce = false;
		}
	}
}

[HarmonyPatch(typeof(Panel_IceFishingHoleClear), nameof(Panel_IceFishingHoleClear.CanBuildFishingHole))]
internal static class Panel_IceFishingHoleClear_CanBuildFishingHole
{
	static bool callOnce = true;
	internal static void Prefix(Panel_IceFishingHoleClear __instance)
	{
		if (callOnce)
		{
			__instance.AddAlternateTools();
			callOnce = false;
		}
	}
}