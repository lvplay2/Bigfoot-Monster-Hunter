using System.Collections.Generic;

namespace UnityEngine.UDP
{
	public class PurchaseForwardCallback : AndroidJavaProxy
	{
		private IPurchaseListener purchaseListener;

		public PurchaseForwardCallback(IPurchaseListener purchaseListener)
			: base((string)null)
		{
		}

		public void onPurchaseFinished(int resultCode, string message, string purchaseInfoString)
		{
		}

		public void onConsumeFinished(int resultCode, string message, string purchaseInfoString)
		{
		}

		public void onQueryInventory(int resultCode, string message, string inventoryString)
		{
		}

		private static PurchaseInfo ConvertPurchaseInfo(string purchaseInfoString)
		{
			return null;
		}

		private static PurchaseInfo ConvertPurchaseInfo(Dictionary<string, object> purchaseInfoMap)
		{
			return null;
		}

		private static ProductInfo ConvertProductInfo(string productInfoString)
		{
			return null;
		}

		private static ProductInfo ConvertProductInfo(Dictionary<string, object> productInfoMap)
		{
			return null;
		}

		private static Inventory ConvertInventory(string inventoryString)
		{
			return null;
		}

		private static T GetValueOfDictionary<T>(IDictionary<string, object> dictionary, string key, T defaultValue)
		{
			return default(T);
		}
	}
}
