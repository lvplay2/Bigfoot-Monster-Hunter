using AppodealAds.Unity.Common;

namespace AppodealAds.Unity.Api
{
	public class UserSettings
	{
		public enum Gender
		{
			OTHER = 0,
			MALE = 1,
			FEMALE = 2
		}

		private static IAppodealAdsClient client;

		private static IAppodealAdsClient getInstance()
		{
			return null;
		}

		public UserSettings setUserId(string id)
		{
			return null;
		}

		public UserSettings setAge(int age)
		{
			return null;
		}

		public UserSettings setGender(Gender gender)
		{
			return null;
		}
	}
}
