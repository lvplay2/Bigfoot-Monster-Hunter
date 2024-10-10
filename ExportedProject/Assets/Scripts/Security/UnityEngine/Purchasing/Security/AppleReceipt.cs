using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing.Security
{
	public class AppleReceipt
	{
		[CompilerGenerated]
		private string _003CbundleID_003Ek__BackingField;

		[CompilerGenerated]
		private string _003CappVersion_003Ek__BackingField;

		[CompilerGenerated]
		private byte[] _003Copaque_003Ek__BackingField;

		[CompilerGenerated]
		private byte[] _003Chash_003Ek__BackingField;

		[CompilerGenerated]
		private string _003CoriginalApplicationVersion_003Ek__BackingField;

		[CompilerGenerated]
		private DateTime _003CreceiptCreationDate_003Ek__BackingField;

		public AppleInAppPurchaseReceipt[] inAppPurchaseReceipts;

		internal string bundleID
		{
			[CompilerGenerated]
			set
			{
				_003CbundleID_003Ek__BackingField = value;
			}
		}

		internal string appVersion
		{
			[CompilerGenerated]
			set
			{
				_003CappVersion_003Ek__BackingField = value;
			}
		}

		internal byte[] opaque
		{
			[CompilerGenerated]
			set
			{
				_003Copaque_003Ek__BackingField = value;
			}
		}

		internal byte[] hash
		{
			[CompilerGenerated]
			set
			{
				_003Chash_003Ek__BackingField = value;
			}
		}

		internal string originalApplicationVersion
		{
			[CompilerGenerated]
			set
			{
				_003CoriginalApplicationVersion_003Ek__BackingField = value;
			}
		}

		internal DateTime receiptCreationDate
		{
			[CompilerGenerated]
			set
			{
				_003CreceiptCreationDate_003Ek__BackingField = value;
			}
		}
	}
}
