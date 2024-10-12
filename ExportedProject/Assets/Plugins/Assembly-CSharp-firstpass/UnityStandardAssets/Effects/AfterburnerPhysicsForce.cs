using UnityEngine;

namespace UnityStandardAssets.Effects
{
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		public float effectAngle;

		public float effectWidth;

		public float effectDistance;

		public float force;

		private Collider[] m_Cols;

		private SphereCollider m_Sphere;

		private void OnEnable()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
