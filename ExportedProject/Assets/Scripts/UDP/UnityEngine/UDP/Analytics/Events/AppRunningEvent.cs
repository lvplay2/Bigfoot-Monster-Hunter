using System.Collections.Generic;

namespace UnityEngine.UDP.Analytics.Events
{
	internal class AppRunningEvent : AndroidJavaProxy
	{
		private const string EVENT_NAME = "appRuntimeAppRunning";

		private Dictionary<string, object> _params;

		public AppRunningEvent(SessionInfo sessionInfo, ulong duration)
			: base((string)null)
		{
		}

		public string GetEventName()
		{
			return null;
		}

		public string GetParams()
		{
			return null;
		}
	}
}
