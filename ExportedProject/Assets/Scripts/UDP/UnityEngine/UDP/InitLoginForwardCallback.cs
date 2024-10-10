namespace UnityEngine.UDP
{
	public class InitLoginForwardCallback : AndroidJavaProxy
	{
		private IInitListener _initListener;

		public InitLoginForwardCallback(IInitListener initListener)
			: base((string)null)
		{
		}

		public void onInitFinished(int resultCode, string message, AndroidJavaObject jo)
		{
		}
	}
}
