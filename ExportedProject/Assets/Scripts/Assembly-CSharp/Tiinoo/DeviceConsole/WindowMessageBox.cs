using System;
using UnityEngine;
using UnityEngine.UI;

namespace Tiinoo.DeviceConsole
{
	public class WindowMessageBox : MonoBehaviour
	{
		public Text uiTitle;

		public Text uiMessage;

		public Text uiOKText;

		public Text uiCancelText;

		private Action m_okCallback;

		private Action m_cancelCallback;

		public void ShowMessageBox(string title, string message, string ok, string cancel, Action okCallback, Action cancelCallback)
		{
		}

		public void ClickOK()
		{
		}

		public void ClickCancel()
		{
		}
	}
}
