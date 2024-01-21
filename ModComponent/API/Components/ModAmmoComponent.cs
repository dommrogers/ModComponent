using Il2Cpp;
using Il2CppInterop.Runtime.Attributes;
using MelonLoader.TinyJSON;
using ModComponent.Utils;

namespace ModComponent.API.Components;

[MelonLoader.RegisterTypeInIl2Cpp(false)]
public class ModAmmoComponent : ModBaseComponent
{

	public ModAmmoComponent(IntPtr intPtr) : base(intPtr) { }

	/// <summary>
	/// The type of gun this bullet is compatible with.
	/// </summary>
	public GunType AmmoForGunType;

    void Awake()
    {
        CopyFieldHandler.UpdateFieldValues(this);
    }

    [HideFromIl2Cpp]
    internal override void InitializeComponent(ProxyObject dict, string className = "ModAmmoComponent")
    {
        base.InitializeComponent(dict, className);
        AmmoForGunType = dict.GetEnum<GunType>(className, "AmmoForGunType");
    }
}