using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UDP
{
	[Serializable]
	public class ProductInfo
	{
		[CompilerGenerated]
		private string _003CItemType_003Ek__BackingField;

		[CompilerGenerated]
		private bool? _003CConsumable_003Ek__BackingField;

		public string ItemType
		{
			[CompilerGenerated]
			set
			{
				_003CItemType_003Ek__BackingField = value;
			}
		}

		public string ProductId { get; set; }

		public bool? Consumable
		{
			[CompilerGenerated]
			set
			{
				_003CConsumable_003Ek__BackingField = value;
			}
		}

		public string Price { get; set; }

		public long PriceAmountMicros { get; set; }

		public string Currency { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }
	}
}
