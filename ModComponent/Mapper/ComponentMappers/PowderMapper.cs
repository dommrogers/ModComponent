using Il2Cpp;
using Il2CppTLD.Gear;
using ModComponent.API.Components;
using ModComponent.Utils;
using UnityEngine.AddressableAssets;

namespace ModComponent.Mapper.ComponentMappers;

internal static class PowderMapper
{
	internal static void Configure(ModBaseComponent modComponent)
	{
		ModPowderComponent? modPowderComponent = modComponent.TryCast<ModPowderComponent>();
		if (modPowderComponent == null)
		{
			return;
		}

		PowderItem powderItem = ComponentUtils.GetOrCreateComponent<PowderItem>(modComponent);
		powderItem.m_Type = Addressables.LoadAssetAsync<PowderType>("POWDER_Gunpowder").WaitForCompletion();
		powderItem.m_WeightLimitKG = modPowderComponent.CapacityKG;
		powderItem.m_WeightKG = modPowderComponent.CapacityKG;
	}
}