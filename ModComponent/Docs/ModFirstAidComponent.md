#### [ModComponent](index.md 'index')
### [ModComponent.API.Components](index.md#ModComponent.API.Components 'ModComponent.API.Components')

## ModFirstAidComponent Class

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase](https://docs.microsoft.com/en-us/dotnet/api/Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase 'Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase') &#129106; [Il2CppSystem.Object](https://docs.microsoft.com/en-us/dotnet/api/Il2CppSystem.Object 'Il2CppSystem.Object') &#129106; [UnityEngine.Object](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Object 'UnityEngine.Object') &#129106; [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') &#129106; [UnityEngine.Behaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Behaviour 'UnityEngine.Behaviour') &#129106; [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; [ModBaseComponent](ModBaseComponent.md 'ModComponent.API.Components.ModBaseComponent') &#129106; ModFirstAidComponent

```csharp
public class ModFirstAidComponent : ModComponent.API.Components.ModBaseComponent
```

| Fields | |
| :--- | :--- |
| [FirstAidType](ModFirstAidComponent.FirstAidType.md 'ModComponent.API.Components.ModFirstAidComponent.FirstAidType') | What type of treatment does this item provide? |
| [InstantHealing](ModFirstAidComponent.InstantHealing.md 'ModComponent.API.Components.ModFirstAidComponent.InstantHealing') | Amount of condition instantly restored after using this item. |
| [ProgressBarMessage](ModFirstAidComponent.ProgressBarMessage.md 'ModComponent.API.Components.ModFirstAidComponent.ProgressBarMessage') | Localization key to be used to show a description text while using the item. <br/><br/>Should be something like 'Taking Antibiotics', 'Applying Bandage', etc. |
| [RemedyText](ModFirstAidComponent.RemedyText.md 'ModComponent.API.Components.ModFirstAidComponent.RemedyText') | Localization key to be used to indicate what action is possible with this item. <br/><br/>E.g 'Take Antibiotics', 'Apply Bandage'. This is probably not used. |
| [TimeToUseSeconds](ModFirstAidComponent.TimeToUseSeconds.md 'ModComponent.API.Components.ModFirstAidComponent.TimeToUseSeconds') | Time in seconds to use this item. <br/><br/>Most vanilla items use 2 or 3 seconds. |
| [UnitsPerUse](ModFirstAidComponent.UnitsPerUse.md 'ModComponent.API.Components.ModFirstAidComponent.UnitsPerUse') | How many items are required for one dose or application? |
| [UseAudio](ModFirstAidComponent.UseAudio.md 'ModComponent.API.Components.ModFirstAidComponent.UseAudio') | Sound to play when using the item. |
