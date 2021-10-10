﻿using ModComponentAPI;
using ModComponent.Utils;

namespace ModComponentMapper.ComponentMapper
{
	internal static class PowderMapper
	{
		internal static void Configure(ModComponent modComponent)
		{
			ModPowderComponent modPowderComponent = modComponent.TryCast<ModPowderComponent>();
			if (modPowderComponent == null) return;

			PowderItem powderItem = ComponentUtils.GetOrCreateComponent<PowderItem>(modComponent);
			powderItem.m_Type = ModPowderComponent.GetPowderType(modPowderComponent.PowderType);
			powderItem.m_WeightLimitKG = modPowderComponent.CapacityKG;
			powderItem.m_WeightKG = modPowderComponent.CapacityKG;
		}
	}
}