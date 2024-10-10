using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Tiinoo.DeviceConsole
{
	public abstract class DragDetector : GestureDetector
	{
		public event Action<Vector2, Vector2, Vector2> onDrag
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected void NotifyOnDrag(Vector2 startPos, Vector2 endPos, Vector2 offset)
		{
		}
	}
}
