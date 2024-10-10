using System.IO;

namespace LipingShare.LCLib.Asn1Processor
{
	internal class Asn1Util
	{
		private static char[] hexDigits;

		public static string FormatString(string inStr, int lineLen, int groupLen)
		{
			return null;
		}

		public static string GenStr(int len, char xch)
		{
			return null;
		}

		public static long BytesToLong(byte[] bytes)
		{
			return 0L;
		}

		public static string BytesToString(byte[] bytes)
		{
			return null;
		}

		public static string ToHexString(byte[] bytes)
		{
			return null;
		}

		public static int BytePrecision(ulong value)
		{
			return 0;
		}

		public static int DERLengthEncode(Stream xdata, ulong length)
		{
			return 0;
		}

		public static long DerLengthDecode(Stream bt, ref bool isIndefiniteLength)
		{
			return 0L;
		}

		public static string GetTagName(byte tag)
		{
			return null;
		}
	}
}
