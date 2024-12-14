using Il2Cpp;
using ModComponent.API.Behaviours;
using ModComponent.API.Components;
using ModComponent.Utils;
using UnityEngine;

namespace ModComponent.Mapper.BehaviourMappers;

internal static class StackableMapper
{
	public static void Configure(ModBaseComponent modComponent)
	{
		ModStackableBehaviour modStackableComponent = ModComponent.Utils.ComponentUtils.GetComponentSafe<ModStackableBehaviour>(modComponent);
		if (modStackableComponent == null)
		{
			return;
		}

		StackableItem stackableItem = ModComponent.Utils.ComponentUtils.GetOrCreateComponent<StackableItem>(modStackableComponent);

		stackableItem.m_LocalizedMultipleUnitText = new LocalizedString { m_LocalizationID = modStackableComponent.MultipleUnitTextID };

		stackableItem.m_LocalizedSingleUnitText = string.IsNullOrWhiteSpace(modStackableComponent.SingleUnitTextID)
			? NameUtils.CreateLocalizedString(modComponent.DisplayNameLocalizationId)
			: NameUtils.CreateLocalizedString(modStackableComponent.SingleUnitTextID);

		stackableItem.m_StackSpriteName = modStackableComponent.StackSprite;
		stackableItem.m_Units = modStackableComponent.UnitsPerItem;
		stackableItem.m_DefaultUnitsInItem = modStackableComponent.UnitsPerItem;

		if (modStackableComponent.ShareStackWithGear.Length > 0)
		{
			stackableItem.m_ShareStackWithGear = ModUtils.GetItems<StackableItem>(modStackableComponent.ShareStackWithGear, modStackableComponent.name);
		}
        else
        {
            stackableItem.m_ShareStackWithGear = new(0);
        }

		if (!string.IsNullOrEmpty(modStackableComponent.InstantiateStackItem)) {
			stackableItem.m_InstantiateStackItem = AssetBundleUtils.LoadAsset<GameObject>(modStackableComponent.InstantiateStackItem).GetComponent<GearItem>();
		}

		stackableItem.m_StackConditionDifferenceConstraint = modStackableComponent.StackConditionDifferenceConstraint;
	}
}
