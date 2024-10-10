using System;
using UnityEngine;

namespace Tiinoo.DeviceConsole
{
	public class UIWindow
	{
		public enum Id
		{
			Alert = -1,
			MessageBox = -2,
			Invalid = 0,
			Detector = 1,
			Console = 2,
			Commands = 3,
			Dashboard = 4
		}

		[Serializable]
		public class Cfg
		{
			public Id id;

			public GameObject prefab;

			public GameObject go;
		}
	}
}
