using UnityEngine;

namespace Tiinoo.DeviceConsole
{
	public class ItemRow
	{
		public object item;

		public int itemIndex;

		public RectTransform rect;

		public ItemDrawer drawer;

		public static ItemRow Create(Transform itemParent, GameObject itemPrefab)
		{
			return null;
		}

		public static float GetItemHeight(GameObject item)
		{
			return 0f;
		}
	}
}
