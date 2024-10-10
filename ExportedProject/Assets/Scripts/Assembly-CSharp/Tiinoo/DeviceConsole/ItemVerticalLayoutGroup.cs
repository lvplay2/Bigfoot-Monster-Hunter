using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Tiinoo.DeviceConsole
{
	public class ItemVerticalLayoutGroup : LayoutGroup, ItemContainer, IPointerClickHandler, IEventSystemHandler
	{
		public ScrollRect scrollRect;

		public GameObject itemPrefab;

		public int itemSpace;

		public bool autoScrollToBottom;

		private const float SCROLL_DISTANCE_TOLERANCE = 0.0001f;

		private const int EXTRA_ROW_COUNT = 3;

		private List<object> m_items;

		private float m_itemHeight;

		private int m_visibleRowCount;

		private object m_curSelectedItem;

		private int m_curSelectedItemIndex;

		private bool m_isDirty;

		private bool m_shouldScrollToBottom;

		private ItemRowContainer m_rowContainer;

		public override float minHeight
		{
			get
			{
				return 0f;
			}
		}

		public event Action<object> onItemSelected
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

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void Refresh()
		{
		}

		private void CheckChildAlignment()
		{
		}

		private void StartListenEvents()
		{
		}

		private void MarkDirty()
		{
		}

		private float GetItemHeight()
		{
			return 0f;
		}

		private float GetRowHeight()
		{
			return 0f;
		}

		public override void SetLayoutHorizontal()
		{
		}

		public override void SetLayoutVertical()
		{
		}

		public override void CalculateLayoutInputVertical()
		{
		}

		public void AddItem(object item)
		{
		}

		public object GetItem(int index)
		{
			return null;
		}

		public void RemoveItem(object item)
		{
		}

		public void ClearItems()
		{
		}

		public object GetCurSelectedItem()
		{
			return null;
		}

		public void SetCurSelectedItem(object item)
		{
		}

		private void CheckCurSelectedItem()
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		private ItemRow CreateRow()
		{
			return null;
		}

		private void HandleScrollRectOnValueChanged(Vector2 size)
		{
		}

		private void CheckShouldScrollToBottom()
		{
		}

		private void ScrollToBottom()
		{
		}
	}
}
