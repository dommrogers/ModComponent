using Il2Cpp;
using ModComponent.Utils;

namespace ModComponent
{
	public class Public
	{
		/// <summary>
		/// [Obsolete] Please use IsReady()<br/>(bool) Check if ModComponent is finished loading
		/// </summary>
		/// <returns>bool</returns>
		public static bool IsLoaded() => IsReady();

		/// <summary>
		/// (bool) Check if ModComponent is finished loading
		/// </summary>
		/// <returns>bool</returns>
		public static bool IsReady()
		{
			return Implementation.isReady;
		}

		/// <summary>
		/// (bool) Check if the current scene is a playable game scene
		/// </summary>
		/// <returns>bool</returns>
		public static bool IsGameScene()
		{
			return !(string.IsNullOrEmpty(GameManager.m_ActiveScene) || GameManager.m_ActiveScene.StartsWith("MainMenu") || GameManager.m_ActiveScene == "Boot" || GameManager.m_ActiveScene == "Empty");
		}

		/// <summary>
		/// Add a DependencyChecker entry, MC filenames should not include the extension
		/// (should be called OnInitializeMelon, does not require MC to be ready)
		/// </summary>
		/// <param name="MCFileName">The name of the ModComponent file the dependency is for</param>
		/// <param name="RequiresMCFileNames">Array of ModComponent filenames required</param>
		/// <param name="RequiresDlc">Does this ModComponent file require the DLC to be loaded</param>
		public static void AddDependencyEntry(string MCFileName, string[] RequiresMCFileNames, bool RequiresDlc = false)
		{
			DependencyChecker.AddEntry(MCFileName, RequiresMCFileNames, RequiresDlc);
		}

	}
}
