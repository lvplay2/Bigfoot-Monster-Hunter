using UnityEngine;

namespace UnityStandardAssets.Vehicles.Ball
{
	public class Ball : MonoBehaviour
	{
		[SerializeField]
		private float m_MovePower;

		[SerializeField]
		private bool m_UseTorque;

		[SerializeField]
		private float m_MaxAngularVelocity;

		[SerializeField]
		private float m_JumpPower;

		private const float k_GroundRayLength = 1f;

		private Rigidbody m_Rigidbody;

		private void Start()
		{
		}

		public void Move(Vector3 moveDirection, bool jump)
		{
		}
	}
}
