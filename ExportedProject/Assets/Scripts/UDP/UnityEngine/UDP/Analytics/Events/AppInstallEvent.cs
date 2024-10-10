using System.Collections.Generic;

namespace UnityEngine.UDP.Analytics.Events
{
	internal class AppInstallEvent : AndroidJavaProxy
	{
		private const string EVENT_NAME = "appRuntimeAppInstall";

		private readonly Dictionary<string, object> _params;

		public AppInstallEvent(SessionInfo sessionInfo)
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
