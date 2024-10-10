namespace UnityEngine.Store
{
	public class LoginForwardCallback : AndroidJavaProxy
	{
		private ILoginListener loginListener;

		public LoginForwardCallback(ILoginListener loginListener)
			: base((string)null)
		{
		}

		public void onInitFinished(int resultCode)
		{
		}

		public void onLoginFinished(int resultCode, AndroidJavaObject jo)
		{
		}
	}
}
