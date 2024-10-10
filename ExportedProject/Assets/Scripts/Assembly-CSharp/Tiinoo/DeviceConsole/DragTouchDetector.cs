using UnityEngine;

namespace Tiinoo.DeviceConsole
{
	public class DragTouchDetector : DragDetector
	{
		private Vector2 m_startPos;

		private Vector2 m_currentPos;

		private Vector2 m_offset;

		private Touch m_touch;

		public override void Update()
		{
		}
	}
}
