using System;
using System.Collections;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Serializable]
	public class FOVKick
	{
		public Camera Camera;

		[HideInInspector]
		public float originalFov;

		public float FOVIncrease;

		public float TimeToIncrease;

		public float TimeToDecrease;

		public AnimationCurve IncreaseCurve;

		public void Setup(Camera camera)
		{
		}

		private void CheckStatus(Camera camera)
		{
		}

		public void ChangeCamera(Camera camera)
		{
		}

		public IEnumerator FOVKickUp()
		{
			return null;
		}

		public IEnumerator FOVKickDown()
		{
			return null;
		}
	}
}
