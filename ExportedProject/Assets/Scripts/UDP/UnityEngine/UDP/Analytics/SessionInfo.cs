namespace UnityEngine.UDP.Analytics
{
	[HideInInspector]
	internal class SessionInfo
	{
		private string m_AppId;

		private string m_SessionId;

		private string m_ClientId;

		private string m_DeviceId;

		private string m_Platform;

		private string m_TargetStore;

		private string m_SystemInfo;

		private bool m_Vr;

		public string MAppId
		{
			set
			{
			}
		}

		public string MSessionId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string MClientId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string MDeviceId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string MPlatform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string MTargetStore
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string MSystemInfo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool MVr
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
