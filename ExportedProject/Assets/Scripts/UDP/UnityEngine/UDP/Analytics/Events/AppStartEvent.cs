using System.Collections.Generic;

namespace UnityEngine.UDP.Analytics.Events
{
	internal class AppStartEvent : AndroidJavaProxy
	{
		private const string EVENT_NAME = "appRuntimeAppStart";

		private readonly Dictionary<string, object> _params;

		public AppStartEvent(SessionInfo sessionInfo)
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
