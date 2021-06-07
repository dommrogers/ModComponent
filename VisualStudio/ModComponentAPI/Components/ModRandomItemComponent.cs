﻿using ModComponentUtils;
using UnityEngine;

namespace ModComponentAPI
{
	public class ModRandomItemComponent : ModComponent
	{
		/// <summary>
		/// The names of the gear items that this could spawn.
		/// </summary>
		public string[] ItemNames = new string[0];

		public ModRandomItemComponent(System.IntPtr intPtr) : base(intPtr) { }

		void Awake()
		{
			CopyFieldHandler.UpdateFieldValues<ModRandomItemComponent>(this);
		}
		void Update()
		{
			if (ModComponentMain.Settings.instance.disableRandomItemSpawns) return;
			if (this.ItemNames is null || this.ItemNames.Length == 0)
			{
				Logger.LogWarning("'{0}' had an invalid list of potential spawn items.", this.name);
				Destroy(this.gameObject);
				return;
			}

			int index = RandomUtils.Range(0, this.ItemNames.Length);
			GameObject prefab = Resources.Load(this.ItemNames[index])?.Cast<GameObject>();
			if (prefab is null)
			{
				Logger.LogWarning("Could not use '{0}' to spawn random item '{1}'", this.name, this.ItemNames[index]);
				Destroy(this.gameObject);
				return;
			}

			GameObject gear = Instantiate(prefab, this.transform.position, this.transform.rotation);
			gear.name = prefab.name;
			DisableObjectForXPMode xpmode = gear?.GetComponent<DisableObjectForXPMode>();
			if (xpmode != null) Destroy(xpmode);
			Destroy(this.gameObject);
		}
	}
}
