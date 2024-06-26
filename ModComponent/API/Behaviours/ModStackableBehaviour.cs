﻿using Il2Cpp;
using Il2CppInterop.Runtime.Attributes;
using MelonLoader.TinyJSON;
using ModComponent.Utils;
using UnityEngine;

namespace ModComponent.API.Behaviours;

[MelonLoader.RegisterTypeInIl2Cpp(false)]
public class ModStackableBehaviour : MonoBehaviour
{
	/// <summary>
	/// Localization key to be used for stacks with a singular item. E.g. '1 arrow'.
	/// </summary>
	public string SingleUnitTextID = "";

	/// <summary>
	/// Localization key to be used for stacks with multiple items. E.g. '2 arrows'.
	/// </summary>
	public string MultipleUnitTextID = "";

	/// <summary>
	/// An optional sprite name (from a UIAtlas) that will be add to the stack.
	/// </summary>
	public string StackSprite = "";

	/// <summary>
	/// The default number of units to make a full stack.
	/// </summary>
	public int UnitsPerItem = 1;

	/// <summary>
	/// Percent chance of the item having a full stack.
	/// </summary>
	public float ChanceFull = 100f;

	/// <summary>
	/// The items that can be stacked with this item.
	/// </summary>
	public string[] ShareStackWithGear = Array.Empty<string>();

	/// <summary>
	/// The item to instantiate when the stack is split.
	/// </summary>
	public string? InstantiateStackItem;

	/// <summary>
	/// The maximum difference in condition between items in a stack.
	/// </summary>
	public float StackConditionDifferenceConstraint = 0.01f;

	void Awake()
	{
		CopyFieldHandler.UpdateFieldValues(this);
		GearItem gearItem = this.GetComponent<GearItem>();
		StackableItem? stackable = gearItem?.GetComponent<StackableItem>();
		if (stackable != null && gearItem != null && !gearItem.m_BeenInspected)
		{
			stackable.m_Units = stackable.m_DefaultUnitsInItem == 1 || RandomUtils.RollChance(this.ChanceFull)
				? stackable.m_DefaultUnitsInItem
				: RandomUtils.Range(1, stackable.m_DefaultUnitsInItem);
		}
	}

	public ModStackableBehaviour(System.IntPtr intPtr) : base(intPtr) { }

	[HideFromIl2Cpp]
	internal void InitializeBehaviour(ProxyObject dict, string className = "ModStackableBehaviour")
	{
		this.MultipleUnitTextID = dict.GetVariant(className, "MultipleUnitTextId");
		this.StackSprite = dict.GetVariant(className, "StackSprite");
		this.SingleUnitTextID = dict.GetVariant(className, "SingleUnitTextId");
		this.UnitsPerItem = dict.GetVariant(className, "UnitsPerItem");
		this.ChanceFull = dict.GetVariant(className, "ChanceFull");
		this.ShareStackWithGear = dict.GetStringArrayOrEmpty(className, "ShareStackWithGear");
		this.InstantiateStackItem = dict.GetStringOrNull(className, "InstantiateStackItem");
		this.StackConditionDifferenceConstraint = dict.GetFloat(className, "StackConditionDifferenceConstraint",0.01f);
	}
}