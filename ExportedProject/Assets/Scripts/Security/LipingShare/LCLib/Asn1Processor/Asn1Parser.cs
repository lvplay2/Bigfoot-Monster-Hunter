using System.IO;

namespace LipingShare.LCLib.Asn1Processor
{
	internal class Asn1Parser
	{
		private byte[] rawData;

		private Asn1Node rootNode;

		public Asn1Node RootNode
		{
			get
			{
				return null;
			}
		}

		public void LoadData(Stream stream)
		{
		}

		public static string GetNodeTextHeader(int lineLen)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public static string GetNodeText(Asn1Node node, int lineLen)
		{
			return null;
		}
	}
}
