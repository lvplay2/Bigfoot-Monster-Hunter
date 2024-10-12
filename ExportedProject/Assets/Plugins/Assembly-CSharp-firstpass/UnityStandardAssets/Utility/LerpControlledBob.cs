using System;
using System.Collections;

namespace UnityStandardAssets.Utility
{
	[Serializable]
	public class LerpControlledBob
	{
		public float BobDuration;

		public float BobAmount;

		private float m_Offset;

		public float Offset()
		{
			return 0f;
		}

		public IEnumerator DoBobCycle()
		{
			return null;
		}
	}
}
