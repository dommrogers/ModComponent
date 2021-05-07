﻿using UnityEngine;

namespace ModComponentAPI
{
	public class ModStackableComponent : MonoBehaviour
	{
		/// <summary>
		/// Localization key to be used for stacks with a singular item. E.g. '1 arrow'.
		/// </summary>
		public string SingleUnitTextID;

		/// <summary>
		/// Localization key to be used for stacks with multiple items. E.g. '2 arrows'.
		/// </summary>
		public string MultipleUnitTextID;

		/// <summary>
		/// An optional sprite name (from a UIAtlas) that will be add to the stack.
		/// </summary>
		public string StackSprite;

		/// <summary>
		/// The default number of item to make a full stack.
		/// </summary>
		public int UnitsPerItem = 1;

		/// <summary>
		/// Percent chance of the item having a full stack.
		/// </summary>
		public float ChanceFull = 100f;

		void Awake()
		{
			CopyFieldHandler.UpdateFieldValues<ModStackableComponent>(this);
			GearItem gearItem = this.GetComponent<GearItem>();
			StackableItem stackable = gearItem?.GetComponent<StackableItem>();
			if (stackable && gearItem && !gearItem.m_BeenInspected)
			{
				if (stackable.m_UnitsPerItem == 1 || ModComponentMapper.RandomUtils.RollChance(this.ChanceFull))
				{
					stackable.m_Units = stackable.m_UnitsPerItem;
				}
				else
				{
					stackable.m_Units = ModComponentMapper.RandomUtils.Range(1, stackable.m_UnitsPerItem);
				}
			}
		}

		public ModStackableComponent(System.IntPtr intPtr) : base(intPtr) { }
	}
}