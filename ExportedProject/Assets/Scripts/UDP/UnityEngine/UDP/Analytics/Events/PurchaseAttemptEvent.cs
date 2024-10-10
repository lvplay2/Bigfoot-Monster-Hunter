using System.Collections.Generic;

namespace UnityEngine.UDP.Analytics.Events
{
	internal class PurchaseAttemptEvent : AndroidJavaProxy
	{
		private const string EVENT_NAME = "appRuntimePurchaseAttempt";

		private readonly Dictionary<string, object> _params;

		public PurchaseAttemptEvent(string productId, string uuid)
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
