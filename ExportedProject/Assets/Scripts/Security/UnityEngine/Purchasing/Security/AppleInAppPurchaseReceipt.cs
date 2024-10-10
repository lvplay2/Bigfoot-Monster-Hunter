using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing.Security
{
	public class AppleInAppPurchaseReceipt : IPurchaseReceipt
	{
		[CompilerGenerated]
		private int _003Cquantity_003Ek__BackingField;

		internal int quantity
		{
			[CompilerGenerated]
			set
			{
				_003Cquantity_003Ek__BackingField = value;
			}
		}

		public string productID { get; internal set; }

		public string transactionID { get; internal set; }

		public string originalTransactionIdentifier { get; internal set; }

		public DateTime purchaseDate { get; internal set; }

		public DateTime originalPurchaseDate { get; internal set; }

		public DateTime subscriptionExpirationDate { get; internal set; }

		public DateTime cancellationDate { get; internal set; }

		public int isFreeTrial { get; internal set; }

		public int productType { get; internal set; }

		public int isIntroductoryPricePeriod { get; internal set; }
	}
}
