using System.Runtime.CompilerServices;
using LipingShare.LCLib.Asn1Processor;

namespace UnityEngine.Purchasing.Security
{
	internal class SignerInfo
	{
		[CompilerGenerated]
		private string _003CIssuerSerialNumber_003Ek__BackingField;

		[CompilerGenerated]
		private byte[] _003CEncryptedDigest_003Ek__BackingField;

		public int Version { get; private set; }

		private string IssuerSerialNumber
		{
			[CompilerGenerated]
			set
			{
				_003CIssuerSerialNumber_003Ek__BackingField = value;
			}
		}

		private byte[] EncryptedDigest
		{
			[CompilerGenerated]
			set
			{
				_003CEncryptedDigest_003Ek__BackingField = value;
			}
		}

		public SignerInfo(Asn1Node n)
		{
		}
	}
}
