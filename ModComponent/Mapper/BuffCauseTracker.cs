using HarmonyLib;
using Il2Cpp;

namespace ModComponent.Mapper;

internal static class BuffCauseTracker
{
	private static Dictionary<AfflictionType, string> causes = new Dictionary<AfflictionType, string>();

	public static void SetCause(AfflictionType buff, string cause)
	{
		if (causes.ContainsKey(buff))
		{
			causes[buff] = cause;
		}
		else
		{
			causes.Add(buff, cause);
		}
	}

	public static string GetCause(AfflictionType buff)
	{
		causes.TryGetValue(buff, out string result);
		return result;
	}
}

[HarmonyPatch(typeof(FatigueBuff), nameof(FatigueBuff.Apply))]//Exists
internal static class FagtigueBuffApplyPatch
{
	public static void Postfix(FatigueBuff __instance)
	{
		GearItem gearItem = Utils.ComponentUtils.GetComponentSafe<GearItem>(__instance);
		if (gearItem == null)
		{
			return;
		}
		else
		{
			BuffCauseTracker.SetCause(AfflictionType.ReducedFatigue, gearItem.DisplayName);
		}
	}
}

[HarmonyPatch(typeof(EnergyBoost), nameof(EnergyBoost.ApplyEnergyBoost))] // Changes EnergyBoost affliction to name of the GEAR_Item consumed.
internal static class EnergyBoostApplyPatch
{
    public static void Postfix(EnergyBoost __instance, EnergyBoostItem energyBoostItem)
    {
        if (energyBoostItem == null)
        {
            return;
        }

        GearItem gearItem = energyBoostItem.m_GearItem;

        if (gearItem == null)
        {
            return;
        }
        else
        {
            BuffCauseTracker.SetCause(AfflictionType.EnergyBoost, gearItem.DisplayName);
        }
    }
}

[HarmonyPatch(typeof(AfflictionButton), nameof(AfflictionButton.SetCauseAndEffect))]//positive caller count
internal static class AfflictionButtonSetCauseAndEffectPatch
{
	public static void Prefix(ref string causeStr, AfflictionType affType)
	{
		string trackedCause = BuffCauseTracker.GetCause(affType);
		if (!string.IsNullOrEmpty(trackedCause))
		{
			causeStr = trackedCause;
		}
	}
}
