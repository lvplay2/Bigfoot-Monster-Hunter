using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	public class ObjectResetter : MonoBehaviour
	{
		private Vector3 originalPosition;

		private Quaternion originalRotation;

		private List<Transform> originalStructure;

		private Rigidbody Rigidbody;

		private void Start()
		{
		}

		public void DelayedReset(float delay)
		{
		}

		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}
	}
}
