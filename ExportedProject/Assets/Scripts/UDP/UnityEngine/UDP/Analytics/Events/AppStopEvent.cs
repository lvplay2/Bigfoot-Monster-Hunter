using System.Collections.Generic;

namespace UnityEngine.UDP.Analytics.Events
{
	internal class AppStopEvent : AndroidJavaProxy
	{
		private const string EVENT_NAME = "appRuntimeAppStop";

		private readonly Dictionary<string, object> _params;

		public AppStopEvent(SessionInfo sessionInfo)
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
