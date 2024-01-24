#### [ModComponent](index.md 'index')
### [ModComponent.API.Components](index.md#ModComponent.API.Components 'ModComponent.API.Components')

## ModBaseComponent Class

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase](https://docs.microsoft.com/en-us/dotnet/api/Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase 'Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase') &#129106; [Il2CppSystem.Object](https://docs.microsoft.com/en-us/dotnet/api/Il2CppSystem.Object 'Il2CppSystem.Object') &#129106; [UnityEngine.Object](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Object 'UnityEngine.Object') &#129106; [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') &#129106; [UnityEngine.Behaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Behaviour 'UnityEngine.Behaviour') &#129106; [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; ModBaseComponent

Derived  
&#8627; [ModAmmoComponent](ModAmmoComponent.md 'ModComponent.API.Components.ModAmmoComponent')  
&#8627; [ModBaseEquippableComponent](ModBaseEquippableComponent.md 'ModComponent.API.Components.ModBaseEquippableComponent')  
&#8627; [ModBedComponent](ModBedComponent.md 'ModComponent.API.Components.ModBedComponent')  
&#8627; [ModBodyHarvestComponent](ModBodyHarvestComponent.md 'ModComponent.API.Components.ModBodyHarvestComponent')  
&#8627; [ModClothingComponent](ModClothingComponent.md 'ModComponent.API.Components.ModClothingComponent')  
&#8627; [ModCollectibleComponent](ModCollectibleComponent.md 'ModComponent.API.Components.ModCollectibleComponent')  
&#8627; [ModCookableComponent](ModCookableComponent.md 'ModComponent.API.Components.ModCookableComponent')  
&#8627; [ModCookingPotComponent](ModCookingPotComponent.md 'ModComponent.API.Components.ModCookingPotComponent')  
&#8627; [ModFirstAidComponent](ModFirstAidComponent.md 'ModComponent.API.Components.ModFirstAidComponent')  
&#8627; [ModLiquidComponent](ModLiquidComponent.md 'ModComponent.API.Components.ModLiquidComponent')  
&#8627; [ModPowderComponent](ModPowderComponent.md 'ModComponent.API.Components.ModPowderComponent')  
&#8627; [ModRandomItemComponent](ModRandomItemComponent.md 'ModComponent.API.Components.ModRandomItemComponent')  
&#8627; [ModRandomWeightedItemComponent](ModRandomWeightedItemComponent.md 'ModComponent.API.Components.ModRandomWeightedItemComponent')

```csharp
public abstract class ModBaseComponent : UnityEngine.MonoBehaviour
```

| Fields | |
| :--- | :--- |
| [ConsoleName](ModBaseComponent.ConsoleName.md 'ModComponent.API.Components.ModBaseComponent.ConsoleName') | How this item will be called in the DeveloperConsole. <br/><br/>Leave empty for a sensible default. |
| [DaysToDecay](ModBaseComponent.DaysToDecay.md 'ModComponent.API.Components.ModBaseComponent.DaysToDecay') | The number of days it takes for this item to decay - without use - from 100% to 0%. <br/><br/>Leave at 0 if the item should not decay over time. |
| [DescriptionLocalizatonId](ModBaseComponent.DescriptionLocalizatonId.md 'ModComponent.API.Components.ModBaseComponent.DescriptionLocalizatonId') | Localization key to be used for the in-game description of the item. |
| [DisplayNameLocalizationId](ModBaseComponent.DisplayNameLocalizationId.md 'ModComponent.API.Components.ModBaseComponent.DisplayNameLocalizationId') | Localization key to be used for the in-game name of the item. |
| [InitialCondition](ModBaseComponent.InitialCondition.md 'ModComponent.API.Components.ModBaseComponent.InitialCondition') | The initial condition of the item when found or crafted. |
| [InspectAngles](ModBaseComponent.InspectAngles.md 'ModComponent.API.Components.ModBaseComponent.InspectAngles') | Each vector component stands for a rotation by the given degrees around the corresponding axis. |
| [InspectDistance](ModBaseComponent.InspectDistance.md 'ModComponent.API.Components.ModBaseComponent.InspectDistance') | Distance from the camera during inspect. |
| [InspectModel](ModBaseComponent.InspectModel.md 'ModComponent.API.Components.ModBaseComponent.InspectModel') | Model to show during inspect mode. <br/><br/>NOTE: You must either set BOTH models or NO models. |
| [InspectOffset](ModBaseComponent.InspectOffset.md 'ModComponent.API.Components.ModBaseComponent.InspectOffset') | Offset from the center during inspect. |
| [InspectOnPickup](ModBaseComponent.InspectOnPickup.md 'ModComponent.API.Components.ModBaseComponent.InspectOnPickup') | Will the item be inspected when picked up? <br/><br/>If not enabled, the item will go straight to the inventory. |
| [InspectScale](ModBaseComponent.InspectScale.md 'ModComponent.API.Components.ModBaseComponent.InspectScale') | Scales the item during inspect. |
| [InventoryActionLocalizationId](ModBaseComponent.InventoryActionLocalizationId.md 'ModComponent.API.Components.ModBaseComponent.InventoryActionLocalizationId') | Localization key to be used for the 'Action' (e.g. 'Equip', 'Eat', ...) button in the inventory.<br/><br/>The text is purely cosmetic and will not influcence the action the button triggers. <br/><br/>Leave empty for a sensible default. |
| [InventoryCategory](ModBaseComponent.InventoryCategory.md 'ModComponent.API.Components.ModBaseComponent.InventoryCategory') | The inventory category to be used for this item. <br/><br/>Leave at 'Auto' for a sensible default. |
| [MaxHP](ModBaseComponent.MaxHP.md 'ModComponent.API.Components.ModBaseComponent.MaxHP') | The maximum hit points of the item. |
| [NormalModel](ModBaseComponent.NormalModel.md 'ModComponent.API.Components.ModBaseComponent.NormalModel') | Model to show when not inspecting the item. <br/><br/>NOTE: You must either set BOTH models or NO models. |
| [PickUpAudio](ModBaseComponent.PickUpAudio.md 'ModComponent.API.Components.ModBaseComponent.PickUpAudio') | Sound to play when the item is picked up. |
| [PutBackAudio](ModBaseComponent.PutBackAudio.md 'ModComponent.API.Components.ModBaseComponent.PutBackAudio') | Sound to play when the item is dropped. |
| [StowAudio](ModBaseComponent.StowAudio.md 'ModComponent.API.Components.ModBaseComponent.StowAudio') | Sound to play when the item is holstered. |
| [WeightKG](ModBaseComponent.WeightKG.md 'ModComponent.API.Components.ModBaseComponent.WeightKG') | The weight of the item in kilograms. |
| [WornOutAudio](ModBaseComponent.WornOutAudio.md 'ModComponent.API.Components.ModBaseComponent.WornOutAudio') | Sound to play when the item wore out during an action. |
