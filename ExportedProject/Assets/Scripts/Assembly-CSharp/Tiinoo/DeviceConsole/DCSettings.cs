using UnityEngine;

namespace Tiinoo.DeviceConsole
{
	public class DCSettings : ScriptableObject
	{
		public enum Gesture
		{
			None = 0,
			SWIPE_DOWN_WITH_1_FINGER = 1,
			SWIPE_DOWN_WITH_2_FINGERS = 2,
			SWIPE_DOWN_WITH_3_FINGERS = 3
		}

		public Gesture openWithGesture;

		public KeyCode openWithKey;

		public int uiLayer;

		public int canvasSortOrder;

		public bool exceptionNotification;

		private static DCSettings m_instance;

		public static DCSettings Instance
		{
			get
			{
				return null;
			}
		}

		private static DCSettings Load()
		{
			return null;
		}

		private static void SaveToAsset(Object asset, string assetFolder, string assetFilename)
		{
		}
	}
}
