using Il2Cpp;

namespace ModComponent
{
	public class Public
	{
		public static bool IsLoaded()
		{
			return Implementation.mapped;
		}

		public static bool IsGameScene()
		{
			return !(string.IsNullOrEmpty(GameManager.m_ActiveScene) || GameManager.m_ActiveScene.StartsWith("MainMenu") || GameManager.m_ActiveScene == "Boot" || GameManager.m_ActiveScene == "Empty");
		}
	}
}
