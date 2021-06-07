﻿using ModComponentAPI;
using ModComponentUtils;
using UnityEngine;

namespace ModComponentMapper.ComponentMapper
{
	internal static class ScentMapper
	{
		internal static void Configure(ModComponent modComponent) => Configure(ComponentUtils.GetGameObject(modComponent));
		internal static void Configure(GameObject prefab)
		{
			ModScentComponent modScentComponent = ComponentUtils.GetComponent<ModScentComponent>(prefab);
			if (modScentComponent is null) return;

			Scent scent = ComponentUtils.GetOrCreateComponent<Scent>(modScentComponent);
			scent.m_ScentCategory = EnumUtils.TranslateEnumValue<ScentRangeCategory, ScentCategory>(modScentComponent.scentCategory);
		}

		internal static float GetScentIntensity(ModComponent modComponent) => GetScentIntensity(ComponentUtils.GetGameObject(modComponent));
		internal static float GetScentIntensity(GameObject prefab)
		{
			Scent scent = ComponentUtils.GetComponent<Scent>(prefab);
			if (scent is null) return 0f;

			switch (scent.m_ScentCategory)
			{
				case ScentRangeCategory.COOKED_MEAT:
					return 5f;
				case ScentRangeCategory.COOKED_FISH:
					return 5f;
				case ScentRangeCategory.GUTS:
					return 20f;
				case ScentRangeCategory.QUARTER:
					return 50f;
				case ScentRangeCategory.RAW_MEAT:
					return 15f;
				case ScentRangeCategory.RAW_FISH:
					return 15f;
				default:
					return 0f;
			}
		}
	}
}