#### [ModComponent](index.md 'index')
### [ModComponent.API.Components](index.md#ModComponent.API.Components 'ModComponent.API.Components').[ModFoodComponent](ModFoodComponent.md 'ModComponent.API.Components.ModFoodComponent')

## ModFoodComponent.AlcoholUptakeMinutes Field

How many in-game minutes does it take for the alcohol to be fully absorbed?<br/>  
This is scaled by current hunger level (the hungrier the faster).<br/>  
The simulated blood alcohol level will slowly raise over this time.<br/>  
Real-life value is around 45 mins for liquids.

```csharp
public float AlcoholUptakeMinutes;
```

#### Field Value
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')