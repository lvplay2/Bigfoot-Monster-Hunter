using System;
using System.Collections.Generic;

namespace UnityEngine.UDP
{
	[HideInInspector]
	internal class MainThreadDispatcher : MonoBehaviour
	{
		public static readonly string OBJECT_NAME;

		private static List<Action> s_Callbacks;

		private static Dictionary<float, Action> delayAction;

		private static bool s_CallbacksPending;

		public static void RunOnMainThread(Action runnable)
		{
		}

		public static void DispatchDelayJob(float waitTime, Action runnable)
		{
		}

		private IEnumerator<WaitForSeconds> WaitAndDo(float waitTime, Action runnable)
		{
			return null;
		}

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
