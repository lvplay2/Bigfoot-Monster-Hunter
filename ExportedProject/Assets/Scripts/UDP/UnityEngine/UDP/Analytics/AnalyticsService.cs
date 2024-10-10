namespace UnityEngine.UDP.Analytics
{
	[HideInInspector]
	internal class AnalyticsService
	{
		public enum SessionState
		{
			kSessionStopped = 0,
			kSessionStarted = 1,
			kSessionPaused = 2,
			kSessionResumed = 3
		}

		private static SessionState m_PlayerSessionState;

		private static string m_PlayerSessionId;

		private static ulong m_PlayerSessionElapsedTime;

		private static ulong m_PlayerSessionForegroundTime;

		private static ulong m_PlayerSessionBackgroundTime;

		public static void Initialize()
		{
		}

		public static void OnPlayerQuit()
		{
		}

		public static void OnPlayerPaused(bool paused)
		{
		}

		public static void OnAppAwake()
		{
		}

		private static void onPlayerStateChanged(SessionState sessionState)
		{
		}

		public static ulong GetPlayerSessionElapsedTime()
		{
			return 0uL;
		}
	}
}
