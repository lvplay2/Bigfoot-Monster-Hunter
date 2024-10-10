using System;
using System.Runtime.CompilerServices;
using LipingShare.LCLib.Asn1Processor;

namespace UnityEngine.Purchasing.Security
{
	internal class X509Cert
	{
		[CompilerGenerated]
		private string _003CSerialNumber_003Ek__BackingField;

		[CompilerGenerated]
		private DateTime _003CValidAfter_003Ek__BackingField;

		[CompilerGenerated]
		private DateTime _003CValidBefore_003Ek__BackingField;

		[CompilerGenerated]
		private RSAKey _003CPubKey_003Ek__BackingField;

		[CompilerGenerated]
		private bool _003CSelfSigned_003Ek__BackingField;

		private Asn1Node TbsCertificate;

		[CompilerGenerated]
		private Asn1Node _003CSignature_003Ek__BackingField;

		public byte[] rawTBSCertificate;

		private string SerialNumber
		{
			[CompilerGenerated]
			set
			{
				_003CSerialNumber_003Ek__BackingField = value;
			}
		}

		private DateTime ValidAfter
		{
			[CompilerGenerated]
			set
			{
				_003CValidAfter_003Ek__BackingField = value;
			}
		}

		private DateTime ValidBefore
		{
			[CompilerGenerated]
			set
			{
				_003CValidBefore_003Ek__BackingField = value;
			}
		}

		private RSAKey PubKey
		{
			[CompilerGenerated]
			set
			{
				_003CPubKey_003Ek__BackingField = value;
			}
		}

		private bool SelfSigned
		{
			[CompilerGenerated]
			set
			{
				_003CSelfSigned_003Ek__BackingField = value;
			}
		}

		public DistinguishedName Subject { get; private set; }

		public DistinguishedName Issuer { get; private set; }

		private Asn1Node Signature
		{
			[CompilerGenerated]
			set
			{
				_003CSignature_003Ek__BackingField = value;
			}
		}

		public X509Cert(Asn1Node n)
		{
		}

		private void ParseNode(Asn1Node root)
		{
		}

		private DateTime ParseTime(Asn1Node n)
		{
			return default(DateTime);
		}
	}
}
