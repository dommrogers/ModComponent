using Il2Cpp;
using ModComponent.API.Components;
using ModComponent.Utils;
using UnityEngine;
using UnityEngine.AddressableAssets;
using Il2CppTLD.IntBackedUnit;
using static Il2Cpp.BodyHarvest;

namespace ModComponent.Mapper.ComponentMappers;

internal static class BodyHarvestMapper
{
	internal static void Configure(ModBaseComponent modComponent)
	{
		ModBodyHarvestComponent modBodyHarvestComponent = modComponent.TryCast<ModBodyHarvestComponent>();
		if (modBodyHarvestComponent == null)
		{
			return;
		}

		BodyHarvest bodyHarvest = ModComponent.Utils.ComponentUtils.GetOrCreateComponent<BodyHarvest>(modBodyHarvestComponent);
		GearItem gearItem = ModComponent.Utils.ComponentUtils.GetComponentSafe<GearItem>(modBodyHarvestComponent);
		Inspect inspect = ModComponent.Utils.ComponentUtils.GetComponentSafe<Inspect>(modBodyHarvestComponent);

		gearItem.m_BodyHarvest = bodyHarvest;

		bodyHarvest.m_AllowDecay = false;
		//		bodyHarvest.m_CanCarry = modBodyHarvestComponent.CanCarry;
		//bodyHarvest.time m_DamageSide = BaseAi.DamageSide.DamageSideNone;
		//		bodyHarvest.m_IsBigCarry = false;
		
		// WIP with @Jods

		//if(!modBodyHarvestComponent.CanCarry)
		//{
		//	gearItem.enabled = false;
		//	inspect.enabled = false;

		//	BodyHarvestInteraction bhi = ModComponent.Utils.ComponentUtils.GetOrCreateComponent<BodyHarvestInteraction>(modBodyHarvestComponent);
		//	bhi.m_CanInteract = true;
		//	bhi.m_BodyHarvest = bodyHarvest;
		//	bhi.m_DefaultHoverText = ModComponent.Utils.NameUtils.CreateLocalizedString(modBodyHarvestComponent.DisplayNameLocalizationId);
		//	Carrion carrion = ModComponent.Utils.ComponentUtils.GetOrCreateComponent<Carrion>(modBodyHarvestComponent);
		//	carrion.m_MinFlockSize = 3;
		//	carrion.m_MaxFlockSize = 4;
		//	carrion.m_LodDistance = 200;
		//	carrion.m_FlyDistanceAboveTarget = 30;
		//	carrion.m_LoopAudio = "PLAY_CROWCAWSDISTANT";
		//	carrion.m_Prefab = Addressables.LoadAssetAsync<GameObject>("WILDLIFE_CrowFlockForCorpse").WaitForCompletion();
		//}

		bodyHarvest.m_HarvestAudio = modBodyHarvestComponent.HarvestAudio;
		bodyHarvest.m_LocalizedDisplayName = ModComponent.Utils.NameUtils.CreateLocalizedString(modBodyHarvestComponent.DisplayNameLocalizationId);

		bodyHarvest.m_GutAvailableUnits = modBodyHarvestComponent.GutQuantity;
		bodyHarvest.m_GutPrefab = AssetBundleUtils.LoadAsset<GameObject>(modBodyHarvestComponent.GutPrefab);
		bodyHarvest.m_GutWeightKgPerUnit = new ItemWeight((long)modBodyHarvestComponent.GutWeightKgPerUnit);

		bodyHarvest.m_HideAvailableUnits = modBodyHarvestComponent.HideQuantity;
		bodyHarvest.m_HidePrefab = AssetBundleUtils.LoadAsset<GameObject>(modBodyHarvestComponent.HidePrefab);
		bodyHarvest.m_HideWeightKgPerUnit = new ItemWeight((long)modBodyHarvestComponent.HideWeightKgPerUnit);
			
        bodyHarvest.m_MeatAvailableMax = new ItemWeight((long)modBodyHarvestComponent.MeatAvailableMaxKG);
        bodyHarvest.m_MeatAvailableMin = new ItemWeight((long)modBodyHarvestComponent.MeatAvailableMinKG);
		bodyHarvest.m_MeatAvailableKG = new ItemWeight((long)UnityEngine.Random.Range(modBodyHarvestComponent.MeatAvailableMinKG, modBodyHarvestComponent.MeatAvailableMaxKG));
		bodyHarvest.m_MeatPrefab = AssetBundleUtils.LoadAsset<GameObject>(modBodyHarvestComponent.MeatPrefab);

		bodyHarvest.m_CanQuarter = modBodyHarvestComponent.CanQuarter;
		bodyHarvest.m_QuarterAudio = modBodyHarvestComponent.QuarterAudio;
		bodyHarvest.m_QuarterBagMeatCapacity = new ItemWeight((long)modBodyHarvestComponent.QuarterBagMeatCapacityKG);
		bodyHarvest.m_QuarterBagWasteMultiplier = modBodyHarvestComponent.QuarterBagWasteMultiplier;
		bodyHarvest.m_QuarterDurationMinutes = modBodyHarvestComponent.QuarterDurationMinutes;
		bodyHarvest.m_QuarterObjectPrefab = AssetBundleUtils.LoadAsset<GameObject>(modBodyHarvestComponent.QuarterObjectPrefab);
//		bodyHarvest.m_QuarterPrefabSpawnAngle = modBodyHarvestComponent.QuarterPrefabSpawnAngle;
		bodyHarvest.m_QuarterPrefabSpawnRadius = modBodyHarvestComponent.QuarterPrefabSpawnRadius;

		bodyHarvest.m_StartRavaged = false;
		bodyHarvest.m_Ravaged = false;
		bodyHarvest.m_StartFrozen = false;
		bodyHarvest.m_PercentFrozen = 0f;
		bodyHarvest.m_StartConditionMax = 100f;
		bodyHarvest.m_StartConditionMin = 95f;

		bodyHarvest.m_GutLabelOverride = ModComponent.Utils.NameUtils.CreateLocalizedString(modBodyHarvestComponent.GutLabelOverride);
		bodyHarvest.m_HideLabelOverride = ModComponent.Utils.NameUtils.CreateLocalizedString(modBodyHarvestComponent.HideLabelOverride);
		bodyHarvest.m_MeatLabelOverride = ModComponent.Utils.NameUtils.CreateLocalizedString(modBodyHarvestComponent.MeatLabelOverride);
	}
}
