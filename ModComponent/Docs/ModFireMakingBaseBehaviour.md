#### [ModComponent](index.md 'index')
### [ModComponent.API.Behaviours](index.md#ModComponent.API.Behaviours 'ModComponent.API.Behaviours')

## ModFireMakingBaseBehaviour Class

The base class for all modded components involved in making fires

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase](https://docs.microsoft.com/en-us/dotnet/api/Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase 'Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase') &#129106; [Il2CppSystem.Object](https://docs.microsoft.com/en-us/dotnet/api/Il2CppSystem.Object 'Il2CppSystem.Object') &#129106; [UnityEngine.Object](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Object 'UnityEngine.Object') &#129106; [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') &#129106; [UnityEngine.Behaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Behaviour 'UnityEngine.Behaviour') &#129106; [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; ModFireMakingBaseBehaviour

Derived  
&#8627; [ModAccelerantBehaviour](ModAccelerantBehaviour.md 'ModComponent.API.Behaviours.ModAccelerantBehaviour')  
&#8627; [ModBurnableBehaviour](ModBurnableBehaviour.md 'ModComponent.API.Behaviours.ModBurnableBehaviour')  
&#8627; [ModFireStarterBehaviour](ModFireStarterBehaviour.md 'ModComponent.API.Behaviours.ModFireStarterBehaviour')

```csharp
public abstract class ModFireMakingBaseBehaviour : UnityEngine.MonoBehaviour
```

| Fields | |
| :--- | :--- |
| [DurationOffset](ModFireMakingBaseBehaviour.DurationOffset.md 'ModComponent.API.Behaviours.ModFireMakingBaseBehaviour.DurationOffset') | In-game seconds offset for fire starting duration from this accelerant.<br/><br/>NOT scaled by fire starting skill. Positive values mean 'slower', negative values mean 'faster'. |
| [SuccessModifier](ModFireMakingBaseBehaviour.SuccessModifier.md 'ModComponent.API.Behaviours.ModFireMakingBaseBehaviour.SuccessModifier') | Does this item affect the chance for success? Represents percentage points.<br/><br/>Positive values increase the chance, negative values reduce it. |
