#### [ModComponent](index.md 'index')
### [ModComponent.API.Components](index.md#ModComponent.API.Components 'ModComponent.API.Components')

## ModToolComponent Class

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase](https://docs.microsoft.com/en-us/dotnet/api/Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase 'Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase') &#129106; [Il2CppSystem.Object](https://docs.microsoft.com/en-us/dotnet/api/Il2CppSystem.Object 'Il2CppSystem.Object') &#129106; [UnityEngine.Object](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Object 'UnityEngine.Object') &#129106; [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') &#129106; [UnityEngine.Behaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Behaviour 'UnityEngine.Behaviour') &#129106; [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; [ModBaseComponent](ModBaseComponent.md 'ModComponent.API.Components.ModBaseComponent') &#129106; [ModBaseEquippableComponent](ModBaseEquippableComponent.md 'ModComponent.API.Components.ModBaseEquippableComponent') &#129106; ModToolComponent

```csharp
public class ModToolComponent : ModComponent.API.Components.ModBaseEquippableComponent
```

| Fields | |
| :--- | :--- |
| [BleedoutMultiplier](ModToolComponent.BleedoutMultiplier.md 'ModComponent.API.Components.ModToolComponent.BleedoutMultiplier') | Multiplier for the time it takes the animal to bleed out after receiving a puncture wound. |
| [BreakDown](ModToolComponent.BreakDown.md 'ModComponent.API.Components.ModToolComponent.BreakDown') | Can this tool be used to break down items? If not enabled, the other settings in this section will be ignored. |
| [BreakDownTimeMultiplier](ModToolComponent.BreakDownTimeMultiplier.md 'ModComponent.API.Components.ModToolComponent.BreakDownTimeMultiplier') | Multiplier for the time required to break down an item.<br/>Represents percent. 0% means 'finishes instantly'; 100% means 'same time as without tool'. |
| [CanPuncture](ModToolComponent.CanPuncture.md 'ModComponent.API.Components.ModToolComponent.CanPuncture') | Can this tool cause a puncture wound? If enabled, this will cause the animal to bleed out. |
| [CarcassHarvesting](ModToolComponent.CarcassHarvesting.md 'ModComponent.API.Components.ModToolComponent.CarcassHarvesting') | Can this tool item be used to harvest carcasses? If not enabled, the other settings in this section will be ignored. |
| [CraftingTimeMultiplier](ModToolComponent.CraftingTimeMultiplier.md 'ModComponent.API.Components.ModToolComponent.CraftingTimeMultiplier') | Multiplier for crafting and repair times. Represents percent. 0% means 'finishes instantly'; 100% means 'same time as without tool'. |
| [DamageMultiplier](ModToolComponent.DamageMultiplier.md 'ModComponent.API.Components.ModToolComponent.DamageMultiplier') | Multiplier for the damage dealt. |
| [DegradeOnUse](ModToolComponent.DegradeOnUse.md 'ModComponent.API.Components.ModToolComponent.DegradeOnUse') | How many condition points per use does this tool item lose?<br/>Certains actions have their own time driven degrade value, e.g. DegradePerHourCrafting, which applies only for those actions. |
| [DegradePerHourCrafting](ModToolComponent.DegradePerHourCrafting.md 'ModComponent.API.Components.ModToolComponent.DegradePerHourCrafting') | How many condition points does the tool degrade while being used for crafting? |
| [DegradePerHourHarvesting](ModToolComponent.DegradePerHourHarvesting.md 'ModComponent.API.Components.ModToolComponent.DegradePerHourHarvesting') | How many condition points does the tool degrade while being used for harvesting carcasses? |
| [FleeChanceMultiplier](ModToolComponent.FleeChanceMultiplier.md 'ModComponent.API.Components.ModToolComponent.FleeChanceMultiplier') | Multiplier for the chance the animal will flee (breaking the struggle before the 'struggle bar' is filled). |
| [ForceLockAudio](ModToolComponent.ForceLockAudio.md 'ModComponent.API.Components.ModToolComponent.ForceLockAudio') | Sound to play while forcing a lock. Leave empty for a sensible default. |
| [ForceLocks](ModToolComponent.ForceLocks.md 'ModComponent.API.Components.ModToolComponent.ForceLocks') | Can this tool item be used to open locked containers? If not enabled, the other settings in this section will be ignored. |
| [IceFishingHole](ModToolComponent.IceFishingHole.md 'ModComponent.API.Components.ModToolComponent.IceFishingHole') | Can this tool item be used to clear ice fishing holes? If not enabled, the other settings in this section will be ignored. |
| [IceFishingHoleAudio](ModToolComponent.IceFishingHoleAudio.md 'ModComponent.API.Components.ModToolComponent.IceFishingHoleAudio') | Sound to play while clearing an ice fishing hole. Leave empty for a sensible default. |
| [IceFishingHoleDegradeOnUse](ModToolComponent.IceFishingHoleDegradeOnUse.md 'ModComponent.API.Components.ModToolComponent.IceFishingHoleDegradeOnUse') | How many condition points does the tool lose when completely clearing an ice fishing hole? |
| [IceFishingHoleMinutes](ModToolComponent.IceFishingHoleMinutes.md 'ModComponent.API.Components.ModToolComponent.IceFishingHoleMinutes') | How many in-game minutes does it take to completely clear an ice fishing hole? |
| [MinutesPerGut](ModToolComponent.MinutesPerGut.md 'ModComponent.API.Components.ModToolComponent.MinutesPerGut') | How many in-game minutes does it take to harvest one gut? |
| [MinutesPerHide](ModToolComponent.MinutesPerHide.md 'ModComponent.API.Components.ModToolComponent.MinutesPerHide') | How many in-game minutes does it take to harvest one hide? |
| [MinutesPerKgFrozenMeat](ModToolComponent.MinutesPerKgFrozenMeat.md 'ModComponent.API.Components.ModToolComponent.MinutesPerKgFrozenMeat') | How many in-game minutes does it take to harvest one kg of frozen meat? |
| [MinutesPerKgMeat](ModToolComponent.MinutesPerKgMeat.md 'ModComponent.API.Components.ModToolComponent.MinutesPerKgMeat') | How many in-game minutes does it take to harvest one kg of unfrozen meat? |
| [SkillBonus](ModToolComponent.SkillBonus.md 'ModComponent.API.Components.ModToolComponent.SkillBonus') | Bonus to the relevant skill when using this item. E.g. the sewing kit gives a bonus of +20. |
| [StruggleBonus](ModToolComponent.StruggleBonus.md 'ModComponent.API.Components.ModToolComponent.StruggleBonus') | Can this tool item be used during a struggle with wildlife? If not enabled, the other settings in this section will be ignored. |
| [TapMultiplier](ModToolComponent.TapMultiplier.md 'ModComponent.API.Components.ModToolComponent.TapMultiplier') | Multiplier for the amount of the 'struggle bar' that is filled with each hit. |
| [ToolType](ModToolComponent.ToolType.md 'ModComponent.API.Components.ModToolComponent.ToolType') | The type of the tool item. This determines for which actions it can be used.<br/>E.g. 'Knife' for cutting, 'Hammer' for pounding, etc. |
| [Usage](ModToolComponent.Usage.md 'ModComponent.API.Components.ModToolComponent.Usage') | Can this item be used for crafting, repairing or both? |
