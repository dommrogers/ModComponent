#### [ModComponent](index.md 'index')
### [ModComponent.API.Components](index.md#ModComponent.API.Components 'ModComponent.API.Components').[ModBaseEquippableComponent](ModBaseEquippableComponent.md 'ModComponent.API.Components.ModBaseEquippableComponent')

## ModBaseEquippableComponent.ImplementationType Property

The name of the type implementing the specific game logic of this item.<br/>  
If this is an assembly-qualified name (Namespace.TypeName,Assembly) it will be loaded from the given assembly.<br/>  
If the assembly is omitted (Namespace.TypeName), the type will be loaded from the first assembly that contains a type with the given name.<br/>  
Leave empty if this item needs no special game logic.

```csharp
public string? ImplementationType { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')