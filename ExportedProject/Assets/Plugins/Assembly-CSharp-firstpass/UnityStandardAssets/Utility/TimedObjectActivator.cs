using System;
using System.Collections;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	public class TimedObjectActivator : MonoBehaviour
	{
		public enum Action
		{
			Activate = 0,
			Deactivate = 1,
			Destroy = 2,
			ReloadLevel = 3,
			Call = 4
		}

		[Serializable]
		public class Entry
		{
			public GameObject target;

			public Action action;

			public float delay;
		}

		[Serializable]
		public class Entries
		{
			public Entry[] entries;
		}

		public Entries entries;

		private void Awake()
		{
		}

		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}
	}
}
