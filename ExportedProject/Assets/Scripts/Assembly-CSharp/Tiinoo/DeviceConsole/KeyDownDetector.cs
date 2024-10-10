using System;
using UnityEngine;

namespace Tiinoo.DeviceConsole
{
	public class KeyDownDetector : GestureDetector
	{
		public static Action<KeyCode> onKeyDown;

		private KeyCode m_key;

		public KeyDownDetector(KeyCode key)
		{
		}

		public override void Update()
		{
		}
	}
}
