using Harmony;
using Il2Cpp;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppTLD.Gear;
using Il2CppTLD.IntBackedUnit;
using ModComponent.API.Components;
using ModComponent.Utils;
using UnityEngine;
using static Il2Cpp.Cookable;

namespace ModComponent.Mapper.ComponentMappers;

internal static class CookableMapper
{
	internal static void Configure(ModBaseComponent modComponent)
	{
		ModCookableComponent modCookableComponent = modComponent.TryCast<ModCookableComponent>();
		if (modCookableComponent == null || !modCookableComponent.Cooking)
		{
			return;
		}

		GearItem gearItem = ModComponent.Utils.ComponentUtils.GetOrCreateComponent<GearItem>(modCookableComponent);
		Cookable cookable = ModComponent.Utils.ComponentUtils.GetOrCreateComponent<Cookable>(modCookableComponent);



		cookable.m_CookableType = modCookableComponent.Type;
		cookable.m_CookTimeMinutes = modCookableComponent.CookingMinutes;
		cookable.m_ReadyTimeMinutes = modCookableComponent.BurntMinutes;
		cookable.m_NumUnitsRequired = modCookableComponent.CookingUnitsRequired;
		cookable.m_PotableWaterRequired = new ItemLiquidVolume((long)modCookableComponent.CookingWaterRequired);
		cookable.m_WarmUpNearFireRange = 1.5f;

		cookable.m_CookEvent = ModUtils.MakeAudioEvent(ModUtils.DefaultIfEmpty(modCookableComponent.CookingAudio, GetDefaultCookAudio(modCookableComponent)));
		cookable.m_PutInPotEvent = ModUtils.MakeAudioEvent(ModUtils.DefaultIfEmpty(modCookableComponent.StartCookingAudio, GetDefaultStartCookingAudio(modCookableComponent)));
		gearItem.GearItemData.m_CookingSlotPlacementAudio = cookable.m_PutInPotEvent;

		string templateSource = (cookable.m_CookableType == CookableType.Meat) ? "GEAR_RawMeatDeer" : "GEAR_PinnacleCanPeaches";
		Cookable template = AssetBundleUtils.LoadAsset<GameObject>(templateSource).GetComponent<Cookable>();
		cookable.m_MeshPotStyle = template?.m_MeshPotStyle;
		cookable.m_MeshCanStyle = template?.m_MeshCanStyle;
		cookable.m_MeshFryingPanStyle = template?.m_MeshFryingPanStyle;

		cookable.m_LiquidMeshRenderer = template?.m_LiquidMeshRenderer;

		// either just heat or convert, but not both
		if (modCookableComponent.CookingResult == null)
		{
			// no conversion, just heating
			FoodItem foodItem = ModComponent.Utils.ComponentUtils.GetComponentSafe<FoodItem>(modCookableComponent);
			if (foodItem != null)
			{
				foodItem.m_HeatedWhenCooked = true;
			}
		}
		else
		{
			// no heating, but instead convert the item when cooking completes
			GearItem cookedGearItem = modCookableComponent.CookingResult.GetComponent<GearItem>();
			if (cookedGearItem == null)
			{
				// not mapped yet, do it now
				AutoMapper.MapModComponent(modCookableComponent.CookingResult);
				cookedGearItem = modCookableComponent.CookingResult.GetComponent<GearItem>();
			}

			cookable.m_CookedPrefab = cookedGearItem ?? throw new ArgumentException("CookingResult does not map to GearItem for prefab " + modCookableComponent.name);
		}
	}

	private static string GetDefaultCookAudio(ModCookableComponent modCookableComponent)
	{
		return modCookableComponent.Type switch
		{
			CookableType.Grub => "Play_BoilingLiquidThickHeavy",
			CookableType.Meat => "Play_FryingHeavy",
			_ => "Play_BoilingLiquidLight",
		};
	}

	private static string GetDefaultStartCookingAudio(ModCookableComponent modCookableComponent)
	{
		return modCookableComponent.Type switch
		{
			CookableType.Grub => "PLAY_PUTINPOTSLOP",
			CookableType.Meat => "Play_AddMeatPan",
			_ => "PLAY_PUTINPOTWATER",
		};
	}
}