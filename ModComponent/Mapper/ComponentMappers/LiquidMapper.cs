using Il2Cpp;
using Il2CppTLD.Gear;
using ModComponent.API.Components;
using UnityEngine.AddressableAssets;

namespace ModComponent.Mapper.ComponentMappers;

internal static class LiquidMapper
{
	internal static void Configure(ModBaseComponent modComponent)
	{
		ModLiquidComponent? modLiquidComponent = modComponent.TryCast<ModLiquidComponent>();
		if (modLiquidComponent == null)
		{
			return;
		}

		string liquidtype = "LIQUID_" + modLiquidComponent.LiquidType;
		LiquidType lt = Addressables.LoadAssetAsync<LiquidType>(liquidtype).WaitForCompletion();
		if (lt == null)
		{
			Logger.LogError($"Invalid LiquidType LIQUID_{modLiquidComponent.LiquidType} for {modComponent.name}");
			return;
		}

		LiquidItem liquidItem = ModComponent.Utils.ComponentUtils.GetOrCreateComponent<LiquidItem>(modComponent);
		liquidItem.m_LiquidCapacityLiters = modLiquidComponent.LiquidCapacityLiters;
		liquidItem.m_LiquidType = lt;
		liquidItem.m_LiquidLiters = modLiquidComponent.LiquidLiters;
		liquidItem.m_MaximumLiters = modLiquidComponent.LiquidLiters;
		liquidItem.m_MinimumLiters = modLiquidComponent.LiquidLiters;
		if (modLiquidComponent.RandomizeQuantity)
		{
			liquidItem.m_MinimumLiters = liquidItem.m_LiquidCapacityLiters / 8f;
		}
		//		liquidItem.m_DrinkingAudio = "Play_DrinkWater";
		//		liquidItem.m_TimeToDrinkSeconds = 4;
		//		liquidItem.m_LiquidQuality = LiquidQuality.Potable;
	}
}
