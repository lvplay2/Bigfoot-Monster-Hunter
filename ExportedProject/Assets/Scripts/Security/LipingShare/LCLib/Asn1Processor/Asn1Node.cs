using System.Collections;
using System.IO;

namespace LipingShare.LCLib.Asn1Processor
{
	internal class Asn1Node : IAsn1Node
	{
		private byte tag;

		private long dataOffset;

		private long dataLength;

		private long lengthFieldBytes;

		private byte[] data;

		private ArrayList childNodeList;

		private byte unusedBits;

		private long deepness;

		private string path;

		private Asn1Node parentNode;

		private bool requireRecalculatePar;

		private bool isIndefiniteLength;

		private bool parseEncapsulatedData;

		public byte Tag
		{
			get
			{
				return 0;
			}
		}

		public byte MaskedTag
		{
			get
			{
				return 0;
			}
		}

		public long ChildNodeCount
		{
			get
			{
				return 0L;
			}
		}

		public string TagName
		{
			get
			{
				return null;
			}
		}

		public Asn1Node ParentNode
		{
			get
			{
				return null;
			}
		}

		public long DataLength
		{
			get
			{
				return 0L;
			}
		}

		public byte[] Data
		{
			get
			{
				return null;
			}
		}

		public long Deepness
		{
			get
			{
				return 0L;
			}
		}

		protected bool RequireRecalculatePar
		{
			set
			{
			}
		}

		private Asn1Node(Asn1Node parentNode, long dataOffset)
		{
		}

		private void Init()
		{
		}

		private string GetHexPrintingStr(Asn1Node startNode, string baseLine, string lStr, int lineLen)
		{
			return null;
		}

		private string FormatLineString(string lStr, int indent, int lineLen, string msg)
		{
			return null;
		}

		private string FormatLineHexString(string lStr, int indent, int lineLen, string msg)
		{
			return null;
		}

		public Asn1Node()
		{
		}

		public bool LoadData(Stream xdata)
		{
			return false;
		}

		public bool SaveData(Stream xdata)
		{
			return false;
		}

		public void ClearAll()
		{
		}

		public void AddChild(Asn1Node xdata)
		{
		}

		public Asn1Node GetChildNode(int index)
		{
			return null;
		}

		public string GetText(Asn1Node startNode, int lineLen)
		{
			return null;
		}

		public string GetDataStr(bool pureHexMode)
		{
			return null;
		}

		protected void RecalculateTreePar()
		{
		}

		protected static long ResetBranchDataLength(Asn1Node node)
		{
			return 0L;
		}

		protected static void ResetDataLengthFieldWidth(Asn1Node node)
		{
		}

		protected void ResetChildNodePar(Asn1Node xNode, long subOffset)
		{
		}

		protected string GetListStr(Asn1Node startNode, int lineLen)
		{
			return null;
		}

		protected string GetIndentStr(Asn1Node startNode)
		{
			return null;
		}

		protected bool GeneralDecode(Stream xdata)
		{
			return false;
		}

		protected bool ListDecode(Stream xdata)
		{
			return false;
		}

		protected bool InternalLoadData(Stream xdata)
		{
			return false;
		}
	}
}
