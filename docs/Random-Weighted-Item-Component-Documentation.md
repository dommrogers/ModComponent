# Template
```
{
    "ModRandomWeightedItemComponent": {
                                "DisplayNameLocalizationId" : "GAMEPLAY_SampleItem",
                                "DescriptionLocalizatonId" : "GAMEPLAY_SampleItemDescription",
                                "InventoryActionLocalizationId" : "",
                                "WeightKG": 0,
                                "DaysToDecay" : 0,
                                "MaxHP" : 100,
                                "InitialCondition" : "Perfect",
                                "InventoryCategory" : "Material",
                                "PickUpAudio" : "",
                                "PutBackAudio" : "",
                                "StowAudio" : "Play_InventoryStow",
                                "WornOutAudio" : "",
                                "InspectOnPickup" : true,
                                "InspectDistance" : 0.4,
                                "InspectAngles" : [0, 0, 0],
                                "InspectOffset" : [0, 0, 0],
                                "InspectScale" :  [1, 1, 1],
                                "NormalModel" : "",
                                
                                "ItemNames" : [],
                                "ItemWeights" : []
                            }
}
```

# Parameters

This component, like the others, uses all the parameters from the [[Generic Component Documentation]].

## ItemNames
*array of string text*<br/>
The names of the gear items that this could spawn. Must be the same length as `ItemWeights`

## ItemWeights
*array of int numbers*<br/>
The integer weights of the gear items that this could spawn. Must be the same length as `ItemNames`