using UnityEngine;
using UnityEngine.EventSystems;

namespace Tiinoo.DeviceConsole
{
	public class DragToResize : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler
	{
		public RectTransform target;

		public bool resizeHorizontal;

		public bool resizeVertical;

		public Vector2 minSize;

		public Vector2 maxSize;

		private Vector2 m_originalTargetSize;

		private Vector2 m_originalPointerLocalPosition;

		private void Start()
		{
		}

		public void OnPointerDown(PointerEventData data)
		{
		}

		public void OnDrag(PointerEventData data)
		{
		}
	}
}
