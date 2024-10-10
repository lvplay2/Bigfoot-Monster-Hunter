using UnityEngine;

namespace taecg.tools.mobileFastShadow
{
	public class MobileFastShadow : MonoBehaviour
	{
		public enum AntiAliasing
		{
			None = 1,
			Samples2 = 2,
			Samples4 = 4,
			Samples8 = 8
		}

		public Camera FollowCam;

		public LayerMask LayerCaster;

		public LayerMask LayerIgnoreReceiver;

		public Vector2 Size;

		public AntiAliasing RTAntiAliasing;

		public Texture2D FalloffTex;

		public float Intensity;

		public Vector3 Direction;

		public float ProjectionSize;

		private Camera shadowCam;

		private Transform shadowCamTrans;

		private Projector projector;

		private Material shadowMat;

		private RenderTexture shadowRT;

		public void Start()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
