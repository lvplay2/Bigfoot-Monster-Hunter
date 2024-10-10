using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Tiinoo.DeviceConsole
{
	public class UIWindowMgr : MonoBehaviour
	{
		public Canvas canvas;

		public EventSystem eventSystem;

		public UIWindow.Cfg[] cfgs;

		private Dictionary<UIWindow.Id, UIWindow.Cfg> m_windowCfgs;

		[SerializeField]
		private List<UIWindow.Id> m_windowIdList;

		private RectTransform m_canvasRectTrans;

		private static UIWindowMgr m_instance;

		public static UIWindowMgr Instance
		{
			get
			{
				return null;
			}
		}

		public int Count
		{
			get
			{
				return 0;
			}
		}

		public float CanvasWidth
		{
			get
			{
				return 0f;
			}
		}

		public float CanvasHeight
		{
			get
			{
				return 0f;
			}
		}

		private void Awake()
		{
		}

		public void Init(DCSettings settings)
		{
		}

		private static GameObject ClonePrefab(GameObject prefab, Transform parent)
		{
			return null;
		}

		public void PopUpWindow(UIWindow.Id windowId, bool showPrevWindow = true)
		{
		}

		public void SwitchWindow(UIWindow.Id windowId)
		{
		}

		public void CloseCurrentWindow()
		{
		}

		public void CloseWindow(UIWindow.Id windowId)
		{
		}

		public void CloseAllWindows()
		{
		}

		private void AddWindow(UIWindow.Id windowId, bool showPrevWindow)
		{
		}

		private void RemoveWindow(UIWindow.Id windowId)
		{
		}

		public UIWindow.Cfg FindWindowCfg(UIWindow.Id windowId)
		{
			return null;
		}

		public Component FindWindowComponent(UIWindow.Id windowId, Type type)
		{
			return null;
		}

		private void DisplayCurrentWindow(bool show)
		{
		}

		private static void DisplayWindow(UIWindow.Cfg cfg, bool show)
		{
		}

		public UIWindow.Id GetCurrentWindowId()
		{
			return default(UIWindow.Id);
		}

		private int FindWindowIndex(UIWindow.Id windowId)
		{
			return 0;
		}
	}
}
