using System.Collections.Generic;
using AppodealAds.Unity.Common;

namespace AppodealAds.Unity.Api
{
	public class Appodeal
	{
		public enum LogLevel
		{
			None = 0,
			Debug = 1,
			Verbose = 2
		}

		public const int NONE = 0;

		public const int INTERSTITIAL = 3;

		public const int BANNER = 4;

		public const int BANNER_BOTTOM = 8;

		public const int BANNER_TOP = 16;

		public const int BANNER_VIEW = 64;

		public const int MREC = 512;

		public const int REWARDED_VIDEO = 128;

		public const int NON_SKIPPABLE_VIDEO = 128;

		public const int BANNER_HORIZONTAL_SMART = -1;

		public const int BANNER_HORIZONTAL_CENTER = -2;

		public const int BANNER_HORIZONTAL_RIGHT = -3;

		public const int BANNER_HORIZONTAL_LEFT = -4;

		public const string APPODEAL_PLUGIN_VERSION = "2.8.63";

		private static IAppodealAdsClient client;

		private static IAppodealAdsClient getInstance()
		{
			return null;
		}

		public static void initialize(string appKey, int adTypes)
		{
		}

		public static void initialize(string appKey, int adTypes, bool hasConsent)
		{
		}

		public static bool show(int adTypes)
		{
			return false;
		}

		public static bool show(int adTypes, string placement)
		{
			return false;
		}

		public static bool showBannerView(int YAxis, int XGravity, string placement)
		{
			return false;
		}

		public static bool showMrecView(int YAxis, int XGravity, string placement)
		{
			return false;
		}

		public static bool isLoaded(int adTypes)
		{
			return false;
		}

		public static void cache(int adTypes)
		{
		}

		public static void hide(int adTypes)
		{
		}

		public static void hideBannerView()
		{
		}

		public static void hideMrecView()
		{
		}

		public static void setAutoCache(int adTypes, bool autoCache)
		{
		}

		public static bool isPrecache(int adTypes)
		{
			return false;
		}

		public static void onResume(int adTypes)
		{
		}

		public static void setSmartBanners(bool value)
		{
		}

		public static void setBannerBackground(bool value)
		{
		}

		public static void setBannerAnimation(bool value)
		{
		}

		public static void setTabletBanners(bool value)
		{
		}

		public static void setTesting(bool test)
		{
		}

		public static void setLogLevel(LogLevel log)
		{
		}

		public static void setChildDirectedTreatment(bool value)
		{
		}

		public static void updateConsent(bool value)
		{
		}

		public static void resetFilterMatureContetnFlag()
		{
		}

		public static void disableNetwork(string network)
		{
		}

		public static void disableNetwork(string network, int adType)
		{
		}

		public static void disableLocationPermissionCheck()
		{
		}

		public static void disableWriteExternalStoragePermissionCheck()
		{
		}

		public static void setTriggerOnLoadedOnPrecache(int adTypes, bool onLoadedTriggerBoth)
		{
		}

		public static void muteVideosIfCallsMuted(bool value)
		{
		}

		public static void showTestScreen()
		{
		}

		public static bool canShow(int adTypes)
		{
			return false;
		}

		public static bool canShow(int adTypes, string placement)
		{
			return false;
		}

		public static void setSegmentFilter(string name, bool value)
		{
		}

		public static void setSegmentFilter(string name, int value)
		{
		}

		public static void setSegmentFilter(string name, double value)
		{
		}

		public static void setSegmentFilter(string name, string value)
		{
		}

		public static void setExtraData(string key, bool value)
		{
		}

		public static void setExtraData(string key, int value)
		{
		}

		public static void setExtraData(string key, double value)
		{
		}

		public static void setExtraData(string key, string value)
		{
		}

		public static void trackInAppPurchase(double amount, string currency)
		{
		}

		public static string getNativeSDKVersion()
		{
			return null;
		}

		public static string getPluginVersion()
		{
			return null;
		}

		public static void setInterstitialCallbacks(IInterstitialAdListener listener)
		{
		}

		public static void setNonSkippableVideoCallbacks(INonSkippableVideoAdListener listener)
		{
		}

		public static void setRewardedVideoCallbacks(IRewardedVideoAdListener listener)
		{
		}

		public static void setBannerCallbacks(IBannerAdListener listener)
		{
		}

		public static void setMrecCallbacks(IMrecAdListener listener)
		{
		}

		public static void requestAndroidMPermissions(IPermissionGrantedListener listener)
		{
		}

		public static KeyValuePair<string, double> getRewardParameters()
		{
			return default(KeyValuePair<string, double>);
		}

		public static KeyValuePair<string, double> getRewardParameters(string placement)
		{
			return default(KeyValuePair<string, double>);
		}

		public static double getPredictedEcpm(int adType)
		{
			return 0.0;
		}

		public static void destroy(int adTypes)
		{
		}

		public static string getUnityVersion()
		{
			return null;
		}
	}
}
