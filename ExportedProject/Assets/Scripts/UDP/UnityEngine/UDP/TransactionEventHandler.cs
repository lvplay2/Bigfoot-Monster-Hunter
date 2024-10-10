namespace UnityEngine.UDP
{
	public class TransactionEventHandler : IPurchaseListener
	{
		private PurchaseInfo _purchaseInfo;

		private int retryTime;

		public TransactionEventHandler(PurchaseInfo purchaseInfo)
		{
		}

		public void OnPurchase(PurchaseInfo purchaseInfo)
		{
		}

		public void OnPurchaseFailed(string message, PurchaseInfo purchaseInfo)
		{
		}

		public void OnPurchaseConsume(PurchaseInfo purchaseInfo)
		{
		}

		public void OnPurchaseConsumeFailed(string message, PurchaseInfo purchaseInfo)
		{
		}

		public void OnQueryInventory(Inventory inventory)
		{
		}

		public void OnQueryInventoryFailed(string message)
		{
		}
	}
}
