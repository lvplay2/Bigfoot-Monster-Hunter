using AppodealAds.Unity.Common;
using UnityEngine;

public class AppodealDemo : MonoBehaviour, IPermissionGrantedListener, IInterstitialAdListener, IBannerAdListener, IMrecAdListener, INonSkippableVideoAdListener, IRewardedVideoAdListener
{
	private string appKey;

	private string interstitialLabel;

	private string rewardedLabel;

	private int buttonWidth;

	private int buttonHeight;

	private int heightScale;

	private int widthScale;

	private int toggleSize;

	private GUIStyle buttonStyle;

	private bool testingToggle;

	private bool loggingToggle;

	public void Awake()
	{
	}

	public void Init()
	{
	}

	private void OnGUI()
	{
	}

	private void InitStyles()
	{
	}

	private Texture2D MakeTexure(int width, int height, Color color)
	{
		return null;
	}

	public void showInterstitial()
	{
	}

	public void showRewardedVideo()
	{
	}

	public void showBanner()
	{
	}

	public void showBannerView()
	{
	}

	public void showMrecView()
	{
	}

	public void hideBanner()
	{
	}

	public void hideBannerView()
	{
	}

	public void hideMrecView()
	{
	}

	public void updateConsent()
	{
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}

	public void onBannerLoaded(bool precache)
	{
	}

	public void onBannerFailedToLoad()
	{
	}

	public void onBannerShown()
	{
	}

	public void onBannerClicked()
	{
	}

	public void onBannerExpired()
	{
	}

	public void onMrecLoaded(bool precache)
	{
	}

	public void onMrecFailedToLoad()
	{
	}

	public void onMrecShown()
	{
	}

	public void onMrecClicked()
	{
	}

	public void onMrecExpired()
	{
	}

	public void onInterstitialLoaded(bool isPrecache)
	{
	}

	public void onInterstitialFailedToLoad()
	{
	}

	public void onInterstitialShown()
	{
	}

	public void onInterstitialClosed()
	{
	}

	public void onInterstitialClicked()
	{
	}

	public void onInterstitialExpired()
	{
	}

	public void onNonSkippableVideoLoaded(bool isPrecache)
	{
	}

	public void onNonSkippableVideoFailedToLoad()
	{
	}

	public void onNonSkippableVideoShown()
	{
	}

	public void onNonSkippableVideoClosed(bool isFinished)
	{
	}

	public void onNonSkippableVideoFinished()
	{
	}

	public void onNonSkippableVideoExpired()
	{
	}

	public void onRewardedVideoLoaded(bool isPrecache)
	{
	}

	public void onRewardedVideoFailedToLoad()
	{
	}

	public void onRewardedVideoShown()
	{
	}

	public void onRewardedVideoClosed(bool finished)
	{
	}

	public void onRewardedVideoFinished(double amount, string name)
	{
	}

	public void onRewardedVideoExpired()
	{
	}

	public void onRewardedVideoClicked()
	{
	}

	public void writeExternalStorageResponse(int result)
	{
	}

	public void accessCoarseLocationResponse(int result)
	{
	}
}
