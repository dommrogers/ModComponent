﻿using Il2Cpp;
using ModComponent.API;
using ModComponent.API.Components;
using ModComponent.Utils;
using UnityEngine;

namespace ModComponent.Mapper.ComponentMappers;

internal static class FoodMapper
{
	internal static void Configure(ModBaseComponent modComponent)
	{
		ModFoodComponent? modFoodComponent = modComponent.TryCast<ModFoodComponent>();
		if (modFoodComponent == null)
		{
			return;
		}

		FoodItem foodItem = ComponentUtils.GetOrCreateComponent<FoodItem>(modFoodComponent);

		foodItem.m_CaloriesTotal = modFoodComponent.Calories;
		foodItem.m_CaloriesRemaining = modFoodComponent.Calories;
		foodItem.m_ReduceThirst = modFoodComponent.ThirstEffect;

		foodItem.m_ChanceFoodPoisoning = Mathf.Clamp01(modFoodComponent.FoodPoisoning / 100f);
		foodItem.m_ChanceFoodPoisoningLowCondition = Mathf.Clamp01(modFoodComponent.FoodPoisoningLowCondition / 100f);
		foodItem.m_ChanceFoodPoisoningRuined = Mathf.Clamp01(modFoodComponent.FoodPoisoningLowCondition / 100f);
		foodItem.m_DailyHPDecayInside = ItemMapper.GetDecayPerStep(modFoodComponent.DaysToDecayIndoors, modFoodComponent.MaxHP);
		foodItem.m_DailyHPDecayOutside = ItemMapper.GetDecayPerStep(modFoodComponent.DaysToDecayOutdoors, modFoodComponent.MaxHP);

		foodItem.m_TimeToEatSeconds = Mathf.Clamp(1, modFoodComponent.EatingTime, 10);
		foodItem.m_TimeToOpenAndEatSeconds = Mathf.Clamp(1, modFoodComponent.EatingTime, 10) + 5;
		foodItem.m_EatingAudio = modFoodComponent.EatingAudio;
		foodItem.m_OpenAndEatingAudio = modFoodComponent.EatingPackagedAudio;
		foodItem.m_Packaged = !string.IsNullOrEmpty(foodItem.m_OpenAndEatingAudio);

		foodItem.m_IsDrink = modFoodComponent.Drink;
		foodItem.m_IsFish = modFoodComponent.Fish;
		foodItem.m_IsMeat = modFoodComponent.Meat;
		foodItem.m_IsRawMeat = modFoodComponent.Raw;
		foodItem.m_IsNatural = modFoodComponent.Natural;
		foodItem.m_MustConsumeAll = modFoodComponent.MustConsumeAll;
        foodItem.m_ParasiteRiskPercentIncrease = ModUtils.NotNull(modFoodComponent.ParasiteRiskIncrements);

		foodItem.m_PercentHeatLossPerMinuteIndoors = 1;
		foodItem.m_PercentHeatLossPerMinuteOutdoors = 2;

		if (modFoodComponent.Opening)
		{
			foodItem.m_GearRequiredToOpen = true;
			foodItem.m_OpenedWithCanOpener = modFoodComponent.OpeningWithCanOpener;
			foodItem.m_OpenedWithHatchet = modFoodComponent.OpeningWithHatchet;
			foodItem.m_OpenedWithKnife = modFoodComponent.OpeningWithKnife;

			if (modFoodComponent.OpeningWithSmashing)
			{
				SmashableItem smashableItem = ComponentUtils.GetOrCreateComponent<SmashableItem>(modFoodComponent);
				smashableItem.m_MinPercentLoss = 10;
				smashableItem.m_MaxPercentLoss = 30;
				smashableItem.m_TimeToSmash = 6;
				smashableItem.m_SmashAudio = "Play_EatingSmashCan";
			}

			if (modFoodComponent.Canned)
			{
				foodItem.m_GearPrefabHarvestAfterFinishEatingNormal = AssetBundleUtils.LoadAsset<GameObject>("GEAR_RecycledCan");
			}
		}

		if (modFoodComponent.AffectRest)
		{
			FatigueBuff fatigueBuff = ComponentUtils.GetOrCreateComponent<FatigueBuff>(modFoodComponent);
			fatigueBuff.m_InitialPercentDecrease = modFoodComponent.InstantRestChange;
			fatigueBuff.m_RateOfIncreaseScale = 0.5f;
			fatigueBuff.m_DurationHours = modFoodComponent.RestFactorMinutes / 60f;
		}

		if (modFoodComponent.AffectCold)
		{
			FreezingBuff freezingBuff = ComponentUtils.GetOrCreateComponent<FreezingBuff>(modFoodComponent);
			freezingBuff.m_InitialPercentDecrease = modFoodComponent.InstantColdChange;
			freezingBuff.m_RateOfIncreaseScale = 0.5f;
			freezingBuff.m_DurationHours = modFoodComponent.ColdFactorMinutes / 60f;
		}

		if (modFoodComponent.AffectCondition)
		{
			ConditionRestBuff conditionRestBuff = ComponentUtils.GetOrCreateComponent<ConditionRestBuff>(modFoodComponent);
			conditionRestBuff.m_ConditionRestBonus = modFoodComponent.ConditionRestBonus;
			conditionRestBuff.m_NumHoursRestAffected = modFoodComponent.ConditionRestMinutes / 60f;
		}

		if (modFoodComponent.ContainsAlcohol)
		{
			AlcoholComponent alcohol = ComponentUtils.GetOrCreateComponent<AlcoholComponent>(modFoodComponent);
			alcohol.AmountTotal = modFoodComponent.WeightKG * modFoodComponent.AlcoholPercentage * 0.01f;
			alcohol.AmountRemaining = alcohol.AmountTotal;
			alcohol.UptakeSeconds = modFoodComponent.AlcoholUptakeMinutes * 60;
		}

        if (modFoodComponent.AffectEnergyBoost)
        {
            EnergyBoostItem energyBoost = ComponentUtils.GetOrCreateComponent<EnergyBoostItem>(modFoodComponent);
			energyBoost.m_BoostDurationHours = modFoodComponent.BoostDurationMinutes / 60f;
            energyBoost.m_FatigueEndingIncrease = modFoodComponent.FatigueEndingIncrease;
            energyBoost.m_FatigueInitialDecrease = modFoodComponent.FatigueInitialDecrease;
			energyBoost.m_PulseFrequencyEnd = 1.2f;
			energyBoost.m_PulseFrequencyStart = 0.8f;
            energyBoost.m_StaminaEndingDecrease = modFoodComponent.StaminaEndingDecrease;
            energyBoost.m_StaminaInitialIncrease = modFoodComponent.StaminaInitialIncrease;
        }

        HoverIconsToShow hoverIconsToShow = ComponentUtils.GetOrCreateComponent<HoverIconsToShow>(modFoodComponent);
		hoverIconsToShow.m_HoverIcons = new HoverIconsToShow.HoverIcons[] { HoverIconsToShow.HoverIcons.Food };
	}
}
