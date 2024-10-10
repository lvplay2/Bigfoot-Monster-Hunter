using System.Collections.Generic;
using UnityEngine;

namespace Tiinoo.DeviceConsole
{
	public class SwipeTouchDetector : SwipeDetector
	{
		private int m_fingerCount;

		private float m_tolerableDegreeCos;

		private Dictionary<int, Vector2> m_touchInitPositions;

		private Dictionary<int, Swipe> m_swipes;

		public SwipeTouchDetector(int fingerCount)
		{
		}

		public override void Update()
		{
		}

		private void ProcessTouchBegan(Touch touch)
		{
		}

		private void ProcessTouchEnded(Touch touch)
		{
		}

		private void ProcessTouchCanceled(Touch touch)
		{
		}

		private void ProcessSwipes()
		{
		}
	}
}
