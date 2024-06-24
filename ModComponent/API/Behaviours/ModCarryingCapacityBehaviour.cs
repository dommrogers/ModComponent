using Il2Cpp;
using Il2CppInterop.Runtime.Attributes;
using Il2CppTLD.Gear;
using Il2CppTLD.IntBackedUnit;
using MelonLoader.TinyJSON;
using ModComponent.Utils;
using UnityEngine;

namespace ModComponent.API.Behaviours;

[MelonLoader.RegisterTypeInIl2Cpp(false)]
public class ModCarryingCapacityBehaviour : MonoBehaviour
{
	/// <summary>
	/// The maximum buff to the carrying capacity from this item.
	/// </summary>
	public float MaxCarryCapacityKGBuff;

	public ModCarryingCapacityBehaviour(System.IntPtr intPtr) : base(intPtr) { }

    
    [HideFromIl2Cpp]
	internal void InitializeBehaviour(ProxyObject dict, string className = "ModCarryingCapacityBehaviour")
	{
		this.MaxCarryCapacityKGBuff = dict.GetVariant(className, "MaxCarryCapacityKGBuff");
	}
}
