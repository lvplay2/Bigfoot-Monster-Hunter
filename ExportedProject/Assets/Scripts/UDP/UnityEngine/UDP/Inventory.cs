using System.Collections.Generic;

namespace UnityEngine.UDP
{
	public class Inventory
	{
		private readonly Dictionary<string, PurchaseInfo> _purchaseDictionary;

		private readonly Dictionary<string, ProductInfo> _productDictionary;

		public PurchaseInfo GetPurchaseInfo(string productId)
		{
			return null;
		}

		public ProductInfo GetProductInfo(string productId)
		{
			return null;
		}

		public bool HasPurchase(string productId)
		{
			return false;
		}

		public IDictionary<string, PurchaseInfo> GetPurchaseDictionary()
		{
			return null;
		}

		public IList<ProductInfo> GetProductList()
		{
			return null;
		}

		public List<PurchaseInfo> GetPurchaseList()
		{
			return null;
		}

		internal void AddProduct(ProductInfo productInfo)
		{
		}

		internal void AddPurchase(PurchaseInfo purchaseInfo)
		{
		}
	}
}
