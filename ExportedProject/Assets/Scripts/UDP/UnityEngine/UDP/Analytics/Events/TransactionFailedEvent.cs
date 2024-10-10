using System.Collections.Generic;

namespace UnityEngine.UDP.Analytics.Events
{
	internal class TransactionFailedEvent : AndroidJavaProxy
	{
		private const string EVENT_NAME = "appRuntimeFailedTransaction";

		private readonly Dictionary<string, object> _params;

		public TransactionFailedEvent(string cpOrderId, string productId, string reason)
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
