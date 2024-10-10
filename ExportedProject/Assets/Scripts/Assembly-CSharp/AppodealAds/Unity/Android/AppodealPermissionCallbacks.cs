using AppodealAds.Unity.Common;
using UnityEngine;

namespace AppodealAds.Unity.Android
{
	public class AppodealPermissionCallbacks : AndroidJavaProxy
	{
		private IPermissionGrantedListener listener;

		internal AppodealPermissionCallbacks(IPermissionGrantedListener listener)
			: base((string)null)
		{
		}

		private void writeExternalStorageResponse(int result)
		{
		}

		private void accessCoarseLocationResponse(int result)
		{
		}
	}
}
