using HarmonyLib;
using Il2Cpp;
using Il2CppTLD.Gear;

namespace ModComponent.Patches;

internal class LiquidItemPatch
{
	//make water containers able to have randomized initial quantities
	[HarmonyPatch(typeof(LiquidItem), nameof(LiquidItem.Awake))]
	internal static class LiquidItem_Awake
	{
		private static void Postfix(LiquidItem __instance)
		{
			if (!Settings.instance.randomPlasticWaterBottles && (__instance.name == "GEAR_Water500ml" || __instance.name == "GEAR_Water1000ml"))
			{
				return;
			}

			if (__instance.m_MinimumLiters == 0f && __instance.m_LiquidType == LiquidType.GetPotableWater())
			{
				__instance.m_LiquidLiters = ModComponent.Utils.RandomUtils.Range(__instance.m_LiquidCapacityLiters / 8f, __instance.m_LiquidCapacityLiters);
			}
		}
	}
}
