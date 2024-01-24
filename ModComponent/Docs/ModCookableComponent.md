#### [ModComponent](index.md 'index')
### [ModComponent.API.Components](index.md#ModComponent.API.Components 'ModComponent.API.Components')

## ModCookableComponent Class

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase](https://docs.microsoft.com/en-us/dotnet/api/Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase 'Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase') &#129106; [Il2CppSystem.Object](https://docs.microsoft.com/en-us/dotnet/api/Il2CppSystem.Object 'Il2CppSystem.Object') &#129106; [UnityEngine.Object](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Object 'UnityEngine.Object') &#129106; [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') &#129106; [UnityEngine.Behaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Behaviour 'UnityEngine.Behaviour') &#129106; [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; [ModBaseComponent](ModBaseComponent.md 'ModComponent.API.Components.ModBaseComponent') &#129106; ModCookableComponent

Derived  
&#8627; [ModFoodComponent](ModFoodComponent.md 'ModComponent.API.Components.ModFoodComponent')

```csharp
public class ModCookableComponent : ModComponent.API.Components.ModBaseComponent
```

| Fields | |
| :--- | :--- |
| [BurntMinutes](ModCookableComponent.BurntMinutes.md 'ModComponent.API.Components.ModCookableComponent.BurntMinutes') | How many in-game minutes until this items becomes burnt after being 'cooked'? |
| [Cooking](ModCookableComponent.Cooking.md 'ModComponent.API.Components.ModCookableComponent.Cooking') | Can this be cooked/heated?<br/><br/>If not enabled, the other settings in this section will be ignored. |
| [CookingAudio](ModCookableComponent.CookingAudio.md 'ModComponent.API.Components.ModCookableComponent.CookingAudio') | Sound to use when cooking/heating the item. <br/><br/>Leave empty for a sensible default. |
| [CookingMinutes](ModCookableComponent.CookingMinutes.md 'ModComponent.API.Components.ModCookableComponent.CookingMinutes') | How many in-game minutes does it take to cook/heat this item? |
| [CookingResult](ModCookableComponent.CookingResult.md 'ModComponent.API.Components.ModCookableComponent.CookingResult') | Convert the item into this item when cooking completes. <br/><br/>Leave empty to only heat the item without converting it. |
| [CookingUnitsRequired](ModCookableComponent.CookingUnitsRequired.md 'ModComponent.API.Components.ModCookableComponent.CookingUnitsRequired') | How many units of this item are required for cooking? |
| [CookingWaterRequired](ModCookableComponent.CookingWaterRequired.md 'ModComponent.API.Components.ModCookableComponent.CookingWaterRequired') | How many liters of water are required for cooking this item? Only potable water applies. |
| [StartCookingAudio](ModCookableComponent.StartCookingAudio.md 'ModComponent.API.Components.ModCookableComponent.StartCookingAudio') | Sound to use when putting the item into a pot or on a stove. <br/><br/>Leave empty for a sensible default. |
| [Type](ModCookableComponent.Type.md 'ModComponent.API.Components.ModCookableComponent.Type') | What type of cookable is this? <br/><br/>Affects where and how this item can be cooked. |
