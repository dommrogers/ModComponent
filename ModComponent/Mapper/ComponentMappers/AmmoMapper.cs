using Il2Cpp;
using ModComponent.API.Components;
using ModComponent.Utils;

namespace ModComponent.Mapper.ComponentMappers;

internal static class AmmoMapper
{
    internal static void Configure(ModBaseComponent modComponent)
    {
        ModAmmoComponent? modAmmoComponent = modComponent.TryCast<ModAmmoComponent>();
        if (modAmmoComponent == null)
        {
            return;
        }

        AmmoItem ammoItem = ComponentUtils.GetOrCreateComponent<AmmoItem>(modAmmoComponent);
        ammoItem.m_AmmoForGunType = modAmmoComponent.AmmoForGunType;
    }
}