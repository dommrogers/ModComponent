# Template
```
{
    "ModAmmoComponent": {
                                "DisplayNameLocalizationId" : "GAMEPLAY_SampleItem",
                                "DescriptionLocalizatonId" : "GAMEPLAY_SampleItemDescription",
                                "InventoryActionLocalizationId" : "",
                                "WeightKG": 0.01,
                                "DaysToDecay" : 0,
                                "MaxHP" : 100,
                                "InitialCondition" : "Perfect",
                                "InventoryCategory" : "Auto",
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
                                "InspectModel" : "",
                                "HoverIconsToShow" : "",

                                "AmmoForGunType" : ""
                            }
}
```

# Parameters

This component, like the others, uses all the parameters from the [[Generic Component Documentation]].

## AmmoForGunType
*GunType* <br/>
The type of gun item which determines what the ammo is used for.<br/>
E.g. 'Rifle' for all rifles, 'Revolver' for all revolvers, etc.<br/>

### GunType
`Rifle`, `Revolver`, `FlareGun`