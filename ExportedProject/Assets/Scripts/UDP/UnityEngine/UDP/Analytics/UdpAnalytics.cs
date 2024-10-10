namespace UnityEngine.UDP.Analytics
{
	public class UdpAnalytics
	{
		public static AnalyticsResult Transaction(string productionId, string price, string currency, string receipt, string cpOrderId)
		{
			return default(AnalyticsResult);
		}

		public static AnalyticsResult TransactionFailed(string productionId, string cpOrderId, string reason)
		{
			return default(AnalyticsResult);
		}

		public static AnalyticsResult PurchaseAttempt(string productionId, string uuid)
		{
			return default(AnalyticsResult);
		}

		private static AnalyticsResult dispatchEvent(object e)
		{
			return default(AnalyticsResult);
		}

		private static bool isInitialized()
		{
			return false;
		}
	}
}
