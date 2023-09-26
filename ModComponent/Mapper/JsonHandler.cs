namespace ModComponent.Mapper;

internal static class JsonHandler
{
	private static readonly Dictionary<string, string> itemJsons = new();

	public static void RegisterJsonText(string itemName, string text)
	{
		if (string.IsNullOrEmpty(text))
		{
			Logger.Log($"JSON data empty for {itemName}");
			return;
		}

		if (itemJsons.ContainsKey(itemName))
		{
			Logger.Log($"Overwriting data for {itemName}");
			itemJsons[itemName] = text;
		}
		else
		{
			itemJsons.Add(itemName, text);
			Logger.LogDebug($"JSON added for {itemName}");
		}
	}

	public static string GetJsonText(string itemName)
	{
		Logger.LogDebug($"Get JSON data for {itemName} {itemName.ToLower()}");

		try
		{
			return itemJsons.TryGetValue(itemName.ToLowerInvariant(), out string jsonData)
				? jsonData
				: throw new System.Exception($"Could not find json file for {itemName}");
		} catch (Exception e)
		{
			Logger.Log($"Exception {itemName} {itemName.ToLowerInvariant()} :: {e.ToString()}");
			return null;
		}
	}
}
