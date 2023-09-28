using System.Runtime.CompilerServices;
using static ModComponent.API.Components.ModLiquidComponent;

namespace ModComponent.API.Components;

public partial class ModLiquidComponent
{
	public enum LiquidKind
	{
		Water,
		Kerosene
	}
}

internal static class ModLiquidComponentExtensions
{
	public static string GetLiquidTypeString(this LiquidKind lk)
	{
		switch (lk)
		{
			case LiquidKind.Water:
				return "LIQUID_WaterPotable";
				break;
			case LiquidKind.Kerosene:
				return "LIQUID_Kerosene";
				break;
			default:
				return lk.ToString();
				break;
		}
	}
}
