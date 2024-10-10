namespace UnityEngine.UDP.Analytics
{
	internal class PlatformWrapper
	{
		public static ulong GetCurrentMillisecondsInUTC()
		{
			return 0uL;
		}

		public static string GetRuntimePlatformString()
		{
			return null;
		}

		public static string GetSystemInfo()
		{
			return null;
		}

		public static string GetPlayerPrefsString(string name)
		{
			return null;
		}

		public static void SetPlayerPrefsString(string name, string value)
		{
		}

		public static ulong GetPlayerPrefsUInt64(string name)
		{
			return 0uL;
		}

		public static void SetPlayerPrefsUInt64(string name, ulong value)
		{
		}

		public static bool GetAppInstalled()
		{
			return false;
		}

		public static void SetAppInstalled(bool v)
		{
		}

		public static string GenerateRandomId()
		{
			return null;
		}
	}
}
