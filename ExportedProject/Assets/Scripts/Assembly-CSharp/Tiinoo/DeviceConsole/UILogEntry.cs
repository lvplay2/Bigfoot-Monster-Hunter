using UnityEngine;
using UnityEngine.UI;

namespace Tiinoo.DeviceConsole
{
	public class UILogEntry : MonoBehaviour, ItemDrawer
	{
		private static Color White_Transparent;

		public Image uiBg;

		public Image uiLogType;

		public Text uiLogMessage;

		public Image uiIsWatched;

		private LogEntry m_log;

		public void Draw(object item, bool isOddRow, bool isSelected)
		{
		}

		public static Color GetBgColor(bool isOddRow, bool isSelected)
		{
			return default(Color);
		}

		public static Sprite GetLogTypeSprite(LogType logType)
		{
			return null;
		}
	}
}
