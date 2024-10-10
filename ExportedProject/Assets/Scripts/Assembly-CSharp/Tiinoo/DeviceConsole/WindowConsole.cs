using UnityEngine;
using UnityEngine.UI;

namespace Tiinoo.DeviceConsole
{
	public class WindowConsole : MonoBehaviour
	{
		public GameObject objConsole;

		public GameObject btnToMaxSize;

		public GameObject btnToNormalSize;

		public Text uiInfoCount;

		public Text uiWarningCount;

		public Text uiErrorCount;

		public InputField uiFilter;

		public ItemVerticalLayoutGroup consoleLayoutGroup;

		public ScrollRect stackTraceScrollRect;

		public Text uiStackTrace;

		public Text uiStatus;

		public Sprite iconInfo;

		public Sprite iconWarning;

		public Sprite iconError;

		public Color bgLogLight;

		public Color bgLogDark;

		public Color bgLogSelected;

		public static bool isVisible;

		private bool m_isInited;

		private bool m_isShowInfo;

		private bool m_isShowWarning;

		private bool m_isShowError;

		private bool m_isShowWatchedLogsOnly;

		private int m_infoCount;

		private int m_warningCount;

		private int m_errorCount;

		private RectTransform m_consoleRectTransform;

		private float m_consoleNormalHeight;

		private const string METHOD_DO_FILTER = "FilterLogsAndRefresh";

		private string m_searchText;

		private bool m_isSearchTextAtBegin;

		private LogBuffer m_filteredLogBuffer;

		private bool m_isDirty;

		private const int STACK_TRACE_MAX_LENGTH = 1200;

		private const string STR_NO_STACK_TRACE = "<-- Stack trace is not available. Please try a development build. -->";

		private const string STR_ETC = "< ... etc ... >";

		private static WindowConsole m_instance;

		public static WindowConsole Instance
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void Init()
		{
		}

		private void MarkDirty()
		{
		}

		private void HandleOnLogAdded(LogEntry log)
		{
		}

		private void HandleOnLogSelected(object item)
		{
		}

		private void SetStackTraceMsg(LogEntry log)
		{
		}

		private static string CreateStackTraceMsg(LogEntry log)
		{
			return null;
		}

		public void ShowHideInfo(bool isShow)
		{
		}

		public void ShowHideWarning(bool isShow)
		{
		}

		public void ShowHideError(bool isShow)
		{
		}

		public void ToggleWatchedLogsOnly(bool isShowWatchedLogsOnly)
		{
		}

		public void Clean()
		{
		}

		public void StretchToNormalSize()
		{
		}

		public void StretchToMaxSize()
		{
		}

		public void HandleOnSearchStringChange(string s)
		{
		}

		public void ClearFilterString()
		{
		}

		private bool HasSearchText()
		{
			return false;
		}

		public void HandleOnSearchTextAtBeginChange(bool val)
		{
		}

		public void Close()
		{
		}

		private void Refresh()
		{
		}

		private void RefreshLogCount()
		{
		}

		private static string CreateLogTypeText(int logCount)
		{
			return null;
		}

		private void ResetLogCount()
		{
		}

		private void StatisticLogCount(LogEntry log)
		{
		}

		private bool FilterPassCheck1(LogEntry log)
		{
			return false;
		}

		private bool FilterPassCheck2(LogEntry log)
		{
			return false;
		}

		private void FilterLogsAndRefresh()
		{
		}

		private void FilterLogs()
		{
		}

		private bool StatisticAndFilter(LogEntry log)
		{
			return false;
		}
	}
}
