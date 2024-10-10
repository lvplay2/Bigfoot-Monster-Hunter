using UnityEngine;

namespace Tiinoo.DeviceConsole
{
	public class LogEntry
	{
		private const int SHORT_MESSAGE_MAX_LENGTH = 128;

		private LogType m_logType;

		private string m_message;

		private string m_stackTrace;

		private bool m_isWatched;

		private string m_lowercaseMessage;

		private string m_shortMessage;

		public LogType logType
		{
			get
			{
				return default(LogType);
			}
		}

		public string message
		{
			get
			{
				return null;
			}
		}

		public string stackTrace
		{
			get
			{
				return null;
			}
		}

		public bool isWatched
		{
			get
			{
				return false;
			}
		}

		public string lowercaseMessage
		{
			get
			{
				return null;
			}
		}

		public string shortMessage
		{
			get
			{
				return null;
			}
		}

		public LogEntry(LogType logType, string logString, string logStackTrace)
		{
		}

		private static string CreateShortMessage(string message)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
