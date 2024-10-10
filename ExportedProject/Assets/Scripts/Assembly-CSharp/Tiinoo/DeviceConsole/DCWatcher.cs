using UnityEngine;

namespace Tiinoo.DeviceConsole
{
	public class DCWatcher
	{
		private static string STR_FLAG;

		public static void Log(string message)
		{
		}

		public static void Log(string message, Object context)
		{
		}

		public static void LogWarning(string message)
		{
		}

		public static void LogWarning(string message, Object context)
		{
		}

		public static void LogError(string message)
		{
		}

		public static void LogError(string message, Object context)
		{
		}

		private static void LogImpl(LogType logType, string message, Object context)
		{
		}

		public static bool HasWatchFlag(string message)
		{
			return false;
		}

		public static string RemoveWatchFlagIfHas(string message, ref bool hasWatchFlag)
		{
			return null;
		}
	}
}
