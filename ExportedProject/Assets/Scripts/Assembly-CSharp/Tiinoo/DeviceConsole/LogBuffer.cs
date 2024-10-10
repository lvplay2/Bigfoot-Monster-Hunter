using System.Collections.Generic;

namespace Tiinoo.DeviceConsole
{
	public class LogBuffer
	{
		private LinkedList<LogEntry> m_logs;

		public int Count
		{
			get
			{
				return 0;
			}
		}

		public LinkedList<LogEntry> Logs
		{
			get
			{
				return null;
			}
		}

		public void Add(LogEntry log)
		{
		}

		public LogEntry RemoveFirst()
		{
			return null;
		}

		public void Clear()
		{
		}
	}
}
