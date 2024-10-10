namespace UnityEngine.ChannelPurchase
{
	public class PurchaseForwardCallback : AndroidJavaProxy
	{
		private IPurchaseListener purchaseListener;

		public PurchaseForwardCallback(IPurchaseListener purchaseListener)
			: base((string)null)
		{
		}

		public void onPurchaseFinished(int resultCode, AndroidJavaObject jo)
		{
		}

		public void onReceiptValidated(int resultCode, AndroidJavaObject jo)
		{
		}

		public void onPurchaseConfirmed(int resultCode, string gameOrderId)
		{
		}
	}
}
