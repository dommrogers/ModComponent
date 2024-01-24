#### [ModComponent](index.md 'index')
### [ModComponent.API.Components](index.md#ModComponent.API.Components 'ModComponent.API.Components')

## ModFoodComponent Class

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase](https://docs.microsoft.com/en-us/dotnet/api/Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase 'Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase') &#129106; [Il2CppSystem.Object](https://docs.microsoft.com/en-us/dotnet/api/Il2CppSystem.Object 'Il2CppSystem.Object') &#129106; [UnityEngine.Object](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Object 'UnityEngine.Object') &#129106; [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') &#129106; [UnityEngine.Behaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Behaviour 'UnityEngine.Behaviour') &#129106; [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; [ModBaseComponent](ModBaseComponent.md 'ModComponent.API.Components.ModBaseComponent') &#129106; [ModCookableComponent](ModCookableComponent.md 'ModComponent.API.Components.ModCookableComponent') &#129106; ModFoodComponent

```csharp
public class ModFoodComponent : ModComponent.API.Components.ModCookableComponent
```

| Fields | |
| :--- | :--- |
| [AffectCold](ModFoodComponent.AffectCold.md 'ModComponent.API.Components.ModFoodComponent.AffectCold') | Does this item affect 'Cold'?<br/><br/>If not enabled, the other settings in this section will be ignored. |
| [AffectCondition](ModFoodComponent.AffectCondition.md 'ModComponent.API.Components.ModFoodComponent.AffectCondition') | Does this item affect 'Condition' while sleeping?<br/><br/>If not enabled, the other settings in this section will be ignored. |
| [AffectRest](ModFoodComponent.AffectRest.md 'ModComponent.API.Components.ModFoodComponent.AffectRest') | Does this item affect 'Rest'?<br/><br/>If not enabled, the other settings in this section will be ignored. |
| [AlcoholPercentage](ModFoodComponent.AlcoholPercentage.md 'ModComponent.API.Components.ModFoodComponent.AlcoholPercentage') | How much of the item's weight is alcohol? |
| [AlcoholUptakeMinutes](ModFoodComponent.AlcoholUptakeMinutes.md 'ModComponent.API.Components.ModFoodComponent.AlcoholUptakeMinutes') | How many in-game minutes does it take for the alcohol to be fully absorbed?<br/><br/>This is scaled by current hunger level (the hungrier the faster).<br/><br/>The simulated blood alcohol level will slowly raise over this time.<br/><br/>Real-life value is around 45 mins for liquids. |
| [Calories](ModFoodComponent.Calories.md 'ModComponent.API.Components.ModFoodComponent.Calories') | For one complete item with all servings.<br/><br/>Calories remaining will scale with weight. |
| [Canned](ModFoodComponent.Canned.md 'ModComponent.API.Components.ModFoodComponent.Canned') | Is the food item canned?<br/><br/>Canned items will yield a 'Recycled Can' when opened properly. |
| [ColdFactorMinutes](ModFoodComponent.ColdFactorMinutes.md 'ModComponent.API.Components.ModFoodComponent.ColdFactorMinutes') | Amount of in-game minutes the 'ColdFactor' will be applied. |
| [ConditionRestBonus](ModFoodComponent.ConditionRestBonus.md 'ModComponent.API.Components.ModFoodComponent.ConditionRestBonus') | How much additional condition is restored per hour? |
| [ConditionRestMinutes](ModFoodComponent.ConditionRestMinutes.md 'ModComponent.API.Components.ModFoodComponent.ConditionRestMinutes') | Amount of in-game minutes the 'ConditionRestBonus' will be applied. |
| [ContainsAlcohol](ModFoodComponent.ContainsAlcohol.md 'ModComponent.API.Components.ModFoodComponent.ContainsAlcohol') | Does this item contain Alcohol?<br/><br/>If not enabled, the other settings in this section will be ignored. |
| [DaysToDecayIndoors](ModFoodComponent.DaysToDecayIndoors.md 'ModComponent.API.Components.ModFoodComponent.DaysToDecayIndoors') | 0 means 'Never'.<br/><br/>This overrides the Basic Property 'DaysToDecay'. |
| [DaysToDecayOutdoors](ModFoodComponent.DaysToDecayOutdoors.md 'ModComponent.API.Components.ModFoodComponent.DaysToDecayOutdoors') | 0 means 'Never'.<br/><br/>This overrides the Basic Property 'DaysToDecay'. |
| [Drink](ModFoodComponent.Drink.md 'ModComponent.API.Components.ModFoodComponent.Drink') | Is the food item something to drink?<br/><br/>(This mainly affects the names of actions and position in the radial menu) |
| [EatingAudio](ModFoodComponent.EatingAudio.md 'ModComponent.API.Components.ModFoodComponent.EatingAudio') | Sound to use when the item is either unpackaged or already open. |
| [EatingPackagedAudio](ModFoodComponent.EatingPackagedAudio.md 'ModComponent.API.Components.ModFoodComponent.EatingPackagedAudio') | Sound to use when the item is still packaged and unopened.<br/><br/>Leave empty for unpackaged food. |
| [EatingTime](ModFoodComponent.EatingTime.md 'ModComponent.API.Components.ModFoodComponent.EatingTime') | Realtime seconds it takes to eat one item. |
| [Fish](ModFoodComponent.Fish.md 'ModComponent.API.Components.ModFoodComponent.Fish') | Is the food item fish directly from an animal?<br/><br/>(E.g. salmon, but not canned sardines - mainly for statistics) |
| [FoodPoisoning](ModFoodComponent.FoodPoisoning.md 'ModComponent.API.Components.ModFoodComponent.FoodPoisoning') | Chance in percent to contract food poisoning from an item above 20% condition. |
| [FoodPoisoningLowCondition](ModFoodComponent.FoodPoisoningLowCondition.md 'ModComponent.API.Components.ModFoodComponent.FoodPoisoningLowCondition') | Chance in percent to contract food poisoning from an item below 20% condition. |
| [InstantColdChange](ModFoodComponent.InstantColdChange.md 'ModComponent.API.Components.ModFoodComponent.InstantColdChange') | How much 'Cold' is restored/drained immediately after consuming the item.<br/><br/>Represents change in percentage points.<br/><br/>Negative values make it feel colder; positive values make it feel warmer. |
| [InstantRestChange](ModFoodComponent.InstantRestChange.md 'ModComponent.API.Components.ModFoodComponent.InstantRestChange') | How much 'Rest' is restored/drained immediately after consuming the item.<br/><br/>Represents change in percentage points.<br/><br/>Negative values drain rest; positive values restore rest |
| [Meat](ModFoodComponent.Meat.md 'ModComponent.API.Components.ModFoodComponent.Meat') | Is the food item meat directly from an animal?<br/><br/>(E.g. wolf steak, but not beef jerky - mainly for statistics) |
| [Natural](ModFoodComponent.Natural.md 'ModComponent.API.Components.ModFoodComponent.Natural') | Is the food item naturally occurring meat or plant? |
| [Opening](ModFoodComponent.Opening.md 'ModComponent.API.Components.ModFoodComponent.Opening') | Does this item require a tool for opening it?<br/><br/>If not enabled, the other settings in this section will be ignored. |
| [OpeningWithCanOpener](ModFoodComponent.OpeningWithCanOpener.md 'ModComponent.API.Components.ModFoodComponent.OpeningWithCanOpener') | Can it be opened with a can opener? |
| [OpeningWithHatchet](ModFoodComponent.OpeningWithHatchet.md 'ModComponent.API.Components.ModFoodComponent.OpeningWithHatchet') | Can it be opened with a hatchet? |
| [OpeningWithKnife](ModFoodComponent.OpeningWithKnife.md 'ModComponent.API.Components.ModFoodComponent.OpeningWithKnife') | Can it be opened with a knife? |
| [OpeningWithSmashing](ModFoodComponent.OpeningWithSmashing.md 'ModComponent.API.Components.ModFoodComponent.OpeningWithSmashing') | Can it be opened by smashing? |
| [ParasiteRiskIncrements](ModFoodComponent.ParasiteRiskIncrements.md 'ModComponent.API.Components.ModFoodComponent.ParasiteRiskIncrements') | Parasite Risk increments in percent for each unit eaten.<br/><br/>Leave empty for no parasite risk. |
| [Raw](ModFoodComponent.Raw.md 'ModComponent.API.Components.ModFoodComponent.Raw') | Is the food item raw or cooked? |
| [RestFactorMinutes](ModFoodComponent.RestFactorMinutes.md 'ModComponent.API.Components.ModFoodComponent.RestFactorMinutes') | Amount of in-game minutes the 'RestFactor' will be applied. |
| [ThirstEffect](ModFoodComponent.ThirstEffect.md 'ModComponent.API.Components.ModFoodComponent.ThirstEffect') | How does this affect your thirst?<br/><br/>Represents change in percentage points.<br/><br/>Negative values increase thirst; positive values reduce thirst. |
| [VitaminC](ModFoodComponent.VitaminC.md 'ModComponent.API.Components.ModFoodComponent.VitaminC') | |
