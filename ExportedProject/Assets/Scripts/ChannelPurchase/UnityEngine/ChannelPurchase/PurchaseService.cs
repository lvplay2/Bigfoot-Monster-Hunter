namespace UnityEngine.ChannelPurchase
{
	public class PurchaseService
	{
		private static AndroidJavaClass serviceClass;

		public static void Purchase(string productCode, string gameOrderId, IPurchaseListener listener, string developerPayload = null)
		{
		}

		public static void ValidateReceipt(string gameOrderId, IPurchaseListener listener)
		{
		}
	}
}
