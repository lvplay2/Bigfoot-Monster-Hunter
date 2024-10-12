using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
	public class WaterHoseParticles : MonoBehaviour
	{
		public static float lastSoundTime;

		public float force;

		private List<ParticleCollisionEvent> m_CollisionEvents;

		private ParticleSystem m_ParticleSystem;

		private void Start()
		{
		}

		private void OnParticleCollision(GameObject other)
		{
		}
	}
}
