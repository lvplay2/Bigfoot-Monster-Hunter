using UnityEngine;

namespace Tiinoo.DeviceConsole
{
	public class SwipeMouseDetector : SwipeDetector
	{
		private int m_button;

		private float m_tolerableDegreeCos;

		private Vector2 m_startPos;

		private Vector2 m_currentPos;

		private Vector2 m_offset;

		public SwipeMouseDetector(int button = 0)
		{
		}

		public override void Update()
		{
		}
	}
}
