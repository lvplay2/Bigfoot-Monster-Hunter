using UnityEngine;

namespace taecg.tools.thirdPersonController
{
	public class FreeLookCam : MonoBehaviour
	{
		public Transform Target;

		public float FollowSpeed;

		[SerializeField]
		private float m_TurnSpeed;

		[SerializeField]
		private float m_TurnSmoothing;

		public float TiltMax;

		public float TiltMin;

		private Transform m_Cam;

		private Transform m_Pivot;

		private float m_LookAngle;

		private float m_TiltAngle;

		private const float k_LookDistance = 100f;

		private Vector3 m_PivotEulers;

		private Quaternion m_PivotTargetRot;

		private Quaternion m_TransformTargetRot;

		private void Awake()
		{
		}

		protected void Update()
		{
		}

		private void FollowTarget(float deltaTime)
		{
		}

		private void HandleRotationMovement()
		{
		}
	}
}
