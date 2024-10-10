using AppodealAds.Unity.Common;
using UnityEngine;

namespace AppodealAds.Unity.Android
{
	public class AppodealNonSkippableVideoCallbacks : AndroidJavaProxy
	{
		private INonSkippableVideoAdListener listener;

		internal AppodealNonSkippableVideoCallbacks(INonSkippableVideoAdListener listener)
			: base((string)null)
		{
		}

		private void onNonSkippableVideoLoaded(bool isPrecache)
		{
		}

		private void onNonSkippableVideoFailedToLoad()
		{
		}

		private void onNonSkippableVideoShown()
		{
		}

		private void onNonSkippableVideoFinished()
		{
		}

		private void onNonSkippableVideoClosed(bool finished)
		{
		}

		private void onNonSkippableVideoExpired()
		{
		}
	}
}
