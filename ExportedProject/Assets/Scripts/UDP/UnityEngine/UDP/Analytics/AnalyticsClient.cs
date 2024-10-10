namespace UnityEngine.UDP.Analytics
{
	[HideInInspector]
	internal static class AnalyticsClient
	{
		private enum State
		{
			kStateNotReady = 0,
			kStateReady = 1,
			kStatePrepared = 2,
			kStateStarted = 3,
			kStatePaused = 4,
			kStateStopped = 5
		}

		private static SessionInfo m_sessionInfo;

		private static bool m_IsNewSession;

		private static State m_State;

		private static bool m_InStateTransition;

		private static string m_AppId;

		private static string m_ClientId;

		private static string m_TargetStore;

		private static bool m_AppInstalled;

		public static void Initialize(string clientId, string appId, string targetStore)
		{
		}

		public static void OnPlayerSessionStateChanged(AnalyticsService.SessionState sessionState, string sessionId, ulong sessionElapsedTime)
		{
		}

		private static bool StartSession()
		{
			return false;
		}

		private static bool ResumeSession()
		{
			return false;
		}

		private static bool PauseSession()
		{
			return false;
		}

		private static bool StopSession()
		{
			return false;
		}

		private static bool CloseService()
		{
			return false;
		}

		private static bool RequestStateChange(State state)
		{
			return false;
		}

		private static bool DetermineNextState(State requestedState, ref State nextState)
		{
			return false;
		}

		private static bool ProcessState(State nextState)
		{
			return false;
		}

		private static void OnEnterStateReady()
		{
		}

		private static void OnEnterStatePrepared()
		{
		}

		private static void OnEnterStateStarted()
		{
		}

		private static void OnEnterStatePaused()
		{
		}

		private static void OnEnterStateStopped()
		{
		}

		private static void OnEnteringStatePausedOrStopped()
		{
		}

		private static void SendAppRunningEvent()
		{
		}

		private static void SavePersistentValue()
		{
		}

		private static ulong GetPlayerSessionElapsedTime()
		{
			return 0uL;
		}

		private static void SetSessionId(string sessionId)
		{
		}

		private static void SetState(State state)
		{
		}

		public static SessionInfo GetSessionInfo()
		{
			return null;
		}

		public static string GetSessionId()
		{
			return null;
		}
	}
}
