#### [ModComponent](index.md 'index')
### [ModComponent.API.Components](index.md#ModComponent.API.Components 'ModComponent.API.Components')

## ModBaseEquippableComponent Class

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase](https://docs.microsoft.com/en-us/dotnet/api/Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase 'Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase') &#129106; [Il2CppSystem.Object](https://docs.microsoft.com/en-us/dotnet/api/Il2CppSystem.Object 'Il2CppSystem.Object') &#129106; [UnityEngine.Object](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Object 'UnityEngine.Object') &#129106; [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') &#129106; [UnityEngine.Behaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Behaviour 'UnityEngine.Behaviour') &#129106; [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; [ModBaseComponent](ModBaseComponent.md 'ModComponent.API.Components.ModBaseComponent') &#129106; ModBaseEquippableComponent

Derived  
&#8627; [ModToolComponent](ModToolComponent.md 'ModComponent.API.Components.ModToolComponent')

```csharp
public abstract class ModBaseEquippableComponent : ModComponent.API.Components.ModBaseComponent
```

| Fields | |
| :--- | :--- |
| [EquippedModel](ModBaseEquippableComponent.EquippedModel.md 'ModComponent.API.Components.ModBaseEquippableComponent.EquippedModel') | The model shown while the item is equipped. |
| [Implementation](ModBaseEquippableComponent.Implementation.md 'ModComponent.API.Components.ModBaseEquippableComponent.Implementation') | The object containing any specific game logic for this item. |
| [OnAwake](ModBaseEquippableComponent.OnAwake.md 'ModComponent.API.Components.ModBaseEquippableComponent.OnAwake') | According to the Unity documentation, Awake is the first script to run. |
| [OnControlModeChangedWhileEquipped](ModBaseEquippableComponent.OnControlModeChangedWhileEquipped.md 'ModComponent.API.Components.ModBaseEquippableComponent.OnControlModeChangedWhileEquipped') | This runs when the player does certain things like enter/exit a car. |
| [OnDisabled](ModBaseEquippableComponent.OnDisabled.md 'ModComponent.API.Components.ModBaseEquippableComponent.OnDisabled') | Executes when the gameobject is disabled |
| [OnEnabled](ModBaseEquippableComponent.OnEnabled.md 'ModComponent.API.Components.ModBaseEquippableComponent.OnEnabled') | OnEnable is called whenever the game object is enabled. |
| [OnEquipped](ModBaseEquippableComponent.OnEquipped.md 'ModComponent.API.Components.ModBaseEquippableComponent.OnEquipped') | Ran when the item is equipped. |
| [OnLateUpdate](ModBaseEquippableComponent.OnLateUpdate.md 'ModComponent.API.Components.ModBaseEquippableComponent.OnLateUpdate') | Executes after all the Update calls |
| [OnPrimaryAction](ModBaseEquippableComponent.OnPrimaryAction.md 'ModComponent.API.Components.ModBaseEquippableComponent.OnPrimaryAction') | Ran when the left mouse button is pressed. |
| [OnSecondaryAction](ModBaseEquippableComponent.OnSecondaryAction.md 'ModComponent.API.Components.ModBaseEquippableComponent.OnSecondaryAction') | Ran when the right mouse button is pressed. |
| [OnStart](ModBaseEquippableComponent.OnStart.md 'ModComponent.API.Components.ModBaseEquippableComponent.OnStart') | Start is only ever called once. |
| [OnUnequipped](ModBaseEquippableComponent.OnUnequipped.md 'ModComponent.API.Components.ModBaseEquippableComponent.OnUnequipped') | Ran when the item is unequipped. |
| [OnUpdate](ModBaseEquippableComponent.OnUpdate.md 'ModComponent.API.Components.ModBaseEquippableComponent.OnUpdate') | Executes every frame. |
