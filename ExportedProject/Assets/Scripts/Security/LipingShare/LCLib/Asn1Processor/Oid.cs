using System.Collections.Specialized;
using System.IO;

namespace LipingShare.LCLib.Asn1Processor
{
	internal class Oid
	{
		private static StringDictionary oidDictionary;

		public string GetOidName(string inOidStr)
		{
			return null;
		}

		public string Decode(byte[] data)
		{
			return null;
		}

		public virtual string Decode(Stream bt)
		{
			return null;
		}

		protected int DecodeValue(Stream bt, ref ulong v)
		{
			return 0;
		}
	}
}
