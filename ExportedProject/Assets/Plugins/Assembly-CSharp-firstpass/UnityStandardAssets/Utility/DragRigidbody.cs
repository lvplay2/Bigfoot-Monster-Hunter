using System.Collections;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	public class DragRigidbody : MonoBehaviour
	{
		private const float k_Spring = 50f;

		private const float k_Damper = 5f;

		private const float k_Drag = 10f;

		private const float k_AngularDrag = 5f;

		private const float k_Distance = 0.2f;

		private const bool k_AttachToCenterOfMass = false;

		private SpringJoint m_SpringJoint;

		private void Update()
		{
		}

		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		private Camera FindCamera()
		{
			return null;
		}
	}
}
