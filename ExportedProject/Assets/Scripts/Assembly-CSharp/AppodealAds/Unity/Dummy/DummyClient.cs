using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;

namespace AppodealAds.Unity.Dummy
{
	public class DummyClient : IAppodealAdsClient
	{
		public void initialize(string appKey, int adTypes)
		{
		}

		public void initialize(string appKey, int adTypes, bool hasConsent)
		{
		}

		public bool isInitialized(int adType)
		{
			return false;
		}

		public bool show(int adTypes)
		{
			return false;
		}

		public bool show(int adTypes, string placement)
		{
			return false;
		}

		public bool showBannerView(int YAxis, int XAxis, string Placement)
		{
			return false;
		}

		public bool showMrecView(int YAxis, int XGravity, string Placement)
		{
			return false;
		}

		public bool isLoaded(int adTypes)
		{
			return false;
		}

		public void cache(int adTypes)
		{
		}

		public void hide(int adTypes)
		{
		}

		public void hideBannerView()
		{
		}

		public void hideMrecView()
		{
		}

		public bool isPrecache(int adTypes)
		{
			return false;
		}

		public void setAutoCache(int adTypes, bool autoCache)
		{
		}

		public void onResume(int adTypes)
		{
		}

		public void setSmartBanners(bool value)
		{
		}

		public void setBannerAnimation(bool value)
		{
		}

		public void setBannerBackground(bool value)
		{
		}

		public void setTabletBanners(bool value)
		{
		}

		public void setTesting(bool test)
		{
		}

		public void setLogLevel(Appodeal.LogLevel logging)
		{
		}

		public void setChildDirectedTreatment(bool value)
		{
		}

		public void updateConsent(bool value)
		{
		}

		public void resetFilterMatureContentFlag()
		{
		}

		public void disableNetwork(string network)
		{
		}

		public void disableNetwork(string network, int adTypes)
		{
		}

		public void disableLocationPermissionCheck()
		{
		}

		public void disableWriteExternalStoragePermissionCheck()
		{
		}

		public void setTriggerOnLoadedOnPrecache(int adTypes, bool onLoadedTriggerBoth)
		{
		}

		public void muteVideosIfCallsMuted(bool value)
		{
		}

		public void showTestScreen()
		{
		}

		public string getVersion()
		{
			return null;
		}

		public bool canShow(int adTypes)
		{
			return false;
		}

		public bool canShow(int adTypes, string placement)
		{
			return false;
		}

		public void setSegmentFilter(string name, bool value)
		{
		}

		public void setSegmentFilter(string name, int value)
		{
		}

		public void setSegmentFilter(string name, double value)
		{
		}

		public void setSegmentFilter(string name, string value)
		{
		}

		public void trackInAppPurchase(double amount, string currency)
		{
		}

		public string getRewardCurrency(string placement)
		{
			return null;
		}

		public double getRewardAmount(string placement)
		{
			return 0.0;
		}

		public string getRewardCurrency()
		{
			return null;
		}

		public double getRewardAmount()
		{
			return 0.0;
		}

		public double getPredictedEcpm(int adType)
		{
			return 0.0;
		}

		public void setExtraData(string key, bool value)
		{
		}

		public void setExtraData(string key, int value)
		{
		}

		public void setExtraData(string key, double value)
		{
		}

		public void setExtraData(string key, string value)
		{
		}

		public void setInterstitialCallbacks(IInterstitialAdListener listener)
		{
		}

		public void setNonSkippableVideoCallbacks(INonSkippableVideoAdListener listener)
		{
		}

		public void setRewardedVideoCallbacks(IRewardedVideoAdListener listener)
		{
		}

		public void setBannerCallbacks(IBannerAdListener listener)
		{
		}

		public void setMrecCallbacks(IMrecAdListener listener)
		{
		}

		public void requestAndroidMPermissions(IPermissionGrantedListener listener)
		{
		}

		public void getUserSettings()
		{
		}

		public void setUserId(string id)
		{
		}

		public void setAge(int age)
		{
		}

		public void setGender(UserSettings.Gender gender)
		{
		}

		public void requestAndroidMPermissions()
		{
		}

		public void destroy(int adTypes)
		{
		}
	}
}
