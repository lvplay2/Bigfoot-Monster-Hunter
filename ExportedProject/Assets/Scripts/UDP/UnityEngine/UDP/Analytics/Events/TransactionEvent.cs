using System.Collections.Generic;

namespace UnityEngine.UDP.Analytics.Events
{
	internal class TransactionEvent : AndroidJavaProxy
	{
		private const string EVENT_NAME = "appRuntimeTransaction";

		private readonly Dictionary<string, object> _params;

		public TransactionEvent(string cpOrderId, string productId, string currency, string price, string receipt)
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
