using System;
using UnityEngine;
using UnityEngine.Store;

namespace AppStoresSupport
{
	[Serializable]
	public class AppStoreSettings : ScriptableObject
	{
		public string UnityClientID;

		public string UnityClientKey;

		public string UnityClientRSAPublicKey;

		public AppStoreSetting XiaomiAppStoreSetting;

		public AppInfo getAppInfo()
		{
			return null;
		}
	}
}
