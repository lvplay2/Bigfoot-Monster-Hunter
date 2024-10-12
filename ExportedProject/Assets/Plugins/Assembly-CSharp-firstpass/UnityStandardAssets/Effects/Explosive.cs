using System.Collections;
using UnityEngine;
using UnityStandardAssets.Utility;

namespace UnityStandardAssets.Effects
{
	public class Explosive : MonoBehaviour
	{
		public Transform explosionPrefab;

		public float detonationImpactVelocity;

		public float sizeMultiplier;

		public bool reset;

		public float resetTimeDelay;

		private bool m_Exploded;

		private ObjectResetter m_ObjectResetter;

		private void Start()
		{
		}

		private IEnumerator OnCollisionEnter(Collision col)
		{
			return null;
		}

		public void Reset()
		{
		}
	}
}
