using System;
using UnityEngine;

namespace Tiinoo.DeviceConsole
{
	public class WindowUtil : MonoBehaviour
	{
		public static void ShowAlert(string title, string message, string ok = null)
		{
		}

		public static void ShowMessageBox(string title, string message, Action okCallback = null, Action cancelCallback = null)
		{
		}

		public static void ShowMessageBox(string title, string message, string ok, string cancel, Action okCallback, Action cancelCallback)
		{
		}
	}
}
