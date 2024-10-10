using AppodealAds.Unity.Common;
using UnityEngine;

namespace AppodealAds.Unity.Android
{
	public class AppodealRewardedVideoCallbacks : AndroidJavaProxy
	{
		private IRewardedVideoAdListener listener;

		internal AppodealRewardedVideoCallbacks(IRewardedVideoAdListener listener)
			: base((string)null)
		{
		}

		private void onRewardedVideoLoaded(bool precache)
		{
		}

		private void onRewardedVideoFailedToLoad()
		{
		}

		private void onRewardedVideoShown()
		{
		}

		private void onRewardedVideoFinished(double amount, AndroidJavaObject name)
		{
		}

		private void onRewardedVideoFinished(double amount, string name)
		{
		}

		private void onRewardedVideoClosed(bool finished)
		{
		}

		private void onRewardedVideoExpired()
		{
		}

		private void onRewardedVideoClicked()
		{
		}
	}
}
