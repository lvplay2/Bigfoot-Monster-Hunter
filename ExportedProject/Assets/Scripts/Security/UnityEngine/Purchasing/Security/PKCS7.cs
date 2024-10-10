using System.Collections.Generic;
using LipingShare.LCLib.Asn1Processor;

namespace UnityEngine.Purchasing.Security
{
	internal class PKCS7
	{
		private Asn1Node root;

		private bool validStructure;

		public Asn1Node data { get; private set; }

		public List<SignerInfo> sinfos { get; private set; }

		public List<X509Cert> certChain { get; private set; }

		public PKCS7(Asn1Node node)
		{
		}

		private void CheckStructure()
		{
		}
	}
}
