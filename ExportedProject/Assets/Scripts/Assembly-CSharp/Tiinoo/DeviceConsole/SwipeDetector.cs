using System;
using UnityEngine;

namespace Tiinoo.DeviceConsole
{
	public abstract class SwipeDetector : GestureDetector
	{
		public enum Swipe
		{
			Invalid = 0,
			Left = 1,
			Right = 2,
			Up = 3,
			Down = 4
		}

		public static float MIN_SWIPE_DISTANCE;

		public static float MAX_TOLERABLE_DEGREE;

		public static Action onSwipeLeft;

		public static Action onSwipeRight;

		public static Action onSwipeUp;

		public static Action onSwipeDown;

		protected static float CalculateTolerableDegreeCos()
		{
			return 0f;
		}

		protected static Swipe DetectSwipe(Vector2 offset, float tolerableDegreeCos)
		{
			return default(Swipe);
		}

		protected static void NotifySwipe(Swipe swipe)
		{
		}
	}
}
