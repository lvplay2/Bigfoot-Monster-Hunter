using AppodealAds.Unity.Common;
using UnityEngine;

namespace AppodealAds.Unity.Android
{
	public class AppodealMrecCallbacks : AndroidJavaProxy
	{
		private IMrecAdListener listener;

		internal AppodealMrecCallbacks(IMrecAdListener listener)
			: base((string)null)
		{
		}

		private void onMrecLoaded(bool isPrecache)
		{
		}

		private void onMrecFailedToLoad()
		{
		}

		private void onMrecShown()
		{
		}

		private void onMrecClicked()
		{
		}

		private void onMrecExpired()
		{
		}
	}
}
