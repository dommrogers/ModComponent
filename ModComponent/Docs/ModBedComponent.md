#### [ModComponent](index.md 'index')
### [ModComponent.API.Components](index.md#ModComponent.API.Components 'ModComponent.API.Components')

## ModBedComponent Class

Component to define a Bed Item (inherits ModBaseComponent)

### See Also
- [ModBaseComponent](ModBaseComponent.md 'ModComponent.API.Components.ModBaseComponent')

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase](https://docs.microsoft.com/en-us/dotnet/api/Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase 'Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase') &#129106; [Il2CppSystem.Object](https://docs.microsoft.com/en-us/dotnet/api/Il2CppSystem.Object 'Il2CppSystem.Object') &#129106; [UnityEngine.Object](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Object 'UnityEngine.Object') &#129106; [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') &#129106; [UnityEngine.Behaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Behaviour 'UnityEngine.Behaviour') &#129106; [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; [ModBaseComponent](ModBaseComponent.md 'ModComponent.API.Components.ModBaseComponent') &#129106; ModBedComponent

```csharp
public class ModBedComponent : ModComponent.API.Components.ModBaseComponent
```

| Fields | |
| :--- | :--- |
| [AdditionalConditionGainPerHour](ModBedComponent.AdditionalConditionGainPerHour.md 'ModComponent.API.Components.ModBedComponent.AdditionalConditionGainPerHour') | Additionally restored condition points restored per hour.<br/><br/>The n-th hour of sleeping gives (n - 1) * AdditionalConditionGainPerHour additional health points. |
| [BearAttackModifier](ModBedComponent.BearAttackModifier.md 'ModComponent.API.Components.ModBedComponent.BearAttackModifier') | Modifier for the chance of bear encounters during sleep. <br/><br/>Positive values decrease the chance; negative values increase the chance. |
| [CloseAudio](ModBedComponent.CloseAudio.md 'ModComponent.API.Components.ModBedComponent.CloseAudio') | Sound to be played when ending to sleep in this bed. <br/><br/>Leave empty for a sensible default. |
| [ConditionGainPerHour](ModBedComponent.ConditionGainPerHour.md 'ModComponent.API.Components.ModBedComponent.ConditionGainPerHour') | How many condition points are restored per hour by sleeping in this bed?<br/><br/>This is the base rate and applied for the first hour.<br/><br/>The second and following hours will benefit from 'AdditionalConditionGainPerHour'. |
| [DegradePerHour](ModBedComponent.DegradePerHour.md 'ModComponent.API.Components.ModBedComponent.DegradePerHour') | How much condition does this bed item lose per hour of use? |
| [OpenAudio](ModBedComponent.OpenAudio.md 'ModComponent.API.Components.ModBedComponent.OpenAudio') | Sound to be played when beginning to sleep in this bed. <br/><br/>Leave empty for a sensible default. |
| [PackedMesh](ModBedComponent.PackedMesh.md 'ModComponent.API.Components.ModBedComponent.PackedMesh') | Optional game object to be used for representing the bed in a 'packed' state. |
| [UsableMesh](ModBedComponent.UsableMesh.md 'ModComponent.API.Components.ModBedComponent.UsableMesh') | Optional game object to be used for representing the bed in a 'usable' state. |
| [WarmthBonusCelsius](ModBedComponent.WarmthBonusCelsius.md 'ModComponent.API.Components.ModBedComponent.WarmthBonusCelsius') | Warmth bonus of the bed in °C. |
| [WolfAttackModifier](ModBedComponent.WolfAttackModifier.md 'ModComponent.API.Components.ModBedComponent.WolfAttackModifier') | Modifier for the chance of wolf encounters during sleep. <br/><br/>Positive values decrease the chance; negative values increase the chance. |
