using AppodealAds.Unity.Common;
using UnityEngine;

namespace AppodealAds.Unity.Android
{
	public class AppodealInterstitialCallbacks : AndroidJavaProxy
	{
		private IInterstitialAdListener listener;

		internal AppodealInterstitialCallbacks(IInterstitialAdListener listener)
			: base((string)null)
		{
		}

		private void onInterstitialLoaded(bool isPrecache)
		{
		}

		private void onInterstitialFailedToLoad()
		{
		}

		private void onInterstitialShown()
		{
		}

		private void onInterstitialClicked()
		{
		}

		private void onInterstitialClosed()
		{
		}

		private void onInterstitialExpired()
		{
		}
	}
}
