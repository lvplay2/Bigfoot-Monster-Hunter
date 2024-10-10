using System;
using System.Collections.Generic;

namespace Tiinoo.DeviceConsole
{
	public class ItemRowContainer
	{
		private List<ItemRow> m_poolRows;

		private List<ItemRow> m_visibleRows;

		private ItemContainer m_itemContainer;

		private Func<ItemRow> m_funcCreateRow;

		public int PoolRowCount
		{
			get
			{
				return 0;
			}
		}

		public int VisibleRowCount
		{
			get
			{
				return 0;
			}
		}

		public void Init(ItemContainer itemContainer, Func<ItemRow> funcCreateRow)
		{
		}

		public void InvalidateVisibleRows()
		{
		}

		public void InvalidateRow(int itemIndex)
		{
		}

		public bool ProcessVisibleItemsNotInRange(int beginItemIndex, int endItemIndex)
		{
			return false;
		}

		public bool ProcessInvisibleItemsInRange(int beginItemIndex, int endItemIndex)
		{
			return false;
		}

		private bool IsVisibleItem(int itemIndex)
		{
			return false;
		}

		private ItemRow RequestRow(int itemIndex)
		{
			return null;
		}

		private void SetRow(ItemRow row, int itemIndex)
		{
		}

		private static ItemRow PopEndRow(List<ItemRow> rows)
		{
			return null;
		}

		public void UpdateVisibleRowsItemIndex(List<object> items)
		{
		}

		public ItemRow GetPoolRow(int index)
		{
			return null;
		}

		public ItemRow GetVisibleRow(int index)
		{
			return null;
		}
	}
}
