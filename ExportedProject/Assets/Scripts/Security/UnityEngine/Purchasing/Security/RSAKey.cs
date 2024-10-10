using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using LipingShare.LCLib.Asn1Processor;

namespace UnityEngine.Purchasing.Security
{
	internal class RSAKey
	{
		[CompilerGenerated]
		private RSACryptoServiceProvider _003Crsa_003Ek__BackingField;

		private RSACryptoServiceProvider rsa
		{
			[CompilerGenerated]
			set
			{
				_003Crsa_003Ek__BackingField = value;
			}
		}

		public RSAKey(Asn1Node n)
		{
		}

		private RSACryptoServiceProvider ParseNode(Asn1Node n)
		{
			return null;
		}

		private string ToXML(string modulus, string exponent)
		{
			return null;
		}
	}
}
