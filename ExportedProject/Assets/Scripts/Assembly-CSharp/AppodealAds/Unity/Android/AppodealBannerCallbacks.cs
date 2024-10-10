using AppodealAds.Unity.Common;
using UnityEngine;

namespace AppodealAds.Unity.Android
{
	public class AppodealBannerCallbacks : AndroidJavaProxy
	{
		private IBannerAdListener listener;

		internal AppodealBannerCallbacks(IBannerAdListener listener)
			: base((string)null)
		{
		}

		private void onBannerLoaded(int height, bool isPrecache)
		{
		}

		private void onBannerFailedToLoad()
		{
		}

		private void onBannerShown()
		{
		}

		private void onBannerClicked()
		{
		}

		private void onBannerExpired()
		{
		}
	}
}
