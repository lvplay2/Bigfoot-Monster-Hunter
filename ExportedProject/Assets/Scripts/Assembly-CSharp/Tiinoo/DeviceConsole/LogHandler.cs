using System;
using UnityEngine;

namespace Tiinoo.DeviceConsole
{
	public static class LogHandler
	{
		public static Action<LogEntry> onLogAdded;

		public static Action onExceptionOccur;

		private static LogBuffer m_logBuffer;

		public static LogBuffer LogBuffer
		{
			get
			{
				return null;
			}
		}

		public static void LogCallback(string logString, string stackTrace, LogType type)
		{
		}
	}
}
