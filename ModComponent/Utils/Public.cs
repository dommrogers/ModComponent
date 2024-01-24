using Il2Cpp;
using ModComponent.Utils;

namespace ModComponent
{
	public class Public
	{
		/// <summary>
		/// Returns True|False if MC is loaded and ready
		/// </summary>
		/// <returns>bool</returns>
		public static bool IsLoaded()
		{
			return Implementation.initialized && Implementation.mapped;
		}

		/// <summary>
		/// Returns True|False if the current scene is a valid "Game" scene
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
		/// <param name="MCFileName"></param>
		/// <param name="RequiresMCFileNames"></param>
		/// <param name="RequiresDlc"></param>
		internal static void AddDependencyEntry(string MCFileName, string[] RequiresMCFileNames, bool RequiresDlc = false)
		{
			DependencyChecker.AddEntry(MCFileName, RequiresMCFileNames, RequiresDlc);
		}

	}
}
