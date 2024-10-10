using System.Collections.Generic;

namespace UnityEngine.UDP
{
	public class StoreService
	{
		private static AndroidJavaClass serviceClass;

		public static string StoreName
		{
			get
			{
				return null;
			}
		}

		public static void Initialize(IInitListener listener, AppInfo appInfo = null)
		{
		}

		public static void Purchase(string productId, string developerPayload, IPurchaseListener listener)
		{
		}

		public static void QueryInventory(List<string> productIds, IPurchaseListener listener)
		{
		}

		public static void ConsumePurchase(PurchaseInfo purchaseInfo, IPurchaseListener listener)
		{
		}

		internal static AndroidJavaObject javaArrayFromCSList(List<string> values)
		{
			return null;
		}
	}
}
