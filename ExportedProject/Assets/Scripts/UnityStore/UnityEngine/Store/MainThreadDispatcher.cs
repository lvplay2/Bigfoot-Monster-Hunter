using System;
using System.Collections.Generic;

namespace UnityEngine.Store
{
	[HideInInspector]
	internal class MainThreadDispatcher : MonoBehaviour
	{
		public static readonly string OBJECT_NAME;

		private static List<Action> s_Callbacks;

		private static bool s_CallbacksPending;

		public static void RunOnMainThread(Action runnable)
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
