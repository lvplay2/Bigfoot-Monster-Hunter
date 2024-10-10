using UnityEngine;

namespace taecg.tools.thirdPersonController
{
	public class ThirdPersonCharacter : MonoBehaviour
	{
		public float MoveSpeed;

		[SerializeField]
		private float m_MovingTurnSpeed;

		[SerializeField]
		private float m_StationaryTurnSpeed;

		[SerializeField]
		private float m_JumpPower;

		[SerializeField]
		private float m_GravityMultiplier;

		[SerializeField]
		private float m_RunCycleLegOffset;

		[SerializeField]
		private float m_MoveSpeedMultiplier;

		[SerializeField]
		private float m_AnimSpeedMultiplier;

		[SerializeField]
		private float m_GroundCheckDistance;

		private Rigidbody m_Rigidbody;

		private Animator m_Animator;

		private bool m_IsGrounded;

		private float m_OrigGroundCheckDistance;

		private const float k_Half = 0.5f;

		private float m_TurnAmount;

		private float m_ForwardAmount;

		private Vector3 m_GroundNormal;

		private float m_CapsuleHeight;

		private Vector3 m_CapsuleCenter;

		private CapsuleCollider m_Capsule;

		private bool m_Crouching;

		private void Start()
		{
		}

		public void Move(Vector3 move)
		{
		}

		private void HandleGroundedMovement(bool jump)
		{
		}

		public void OnAnimatorMove()
		{
		}

		private void CheckGroundStatus()
		{
		}
	}
}
