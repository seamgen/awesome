using System;

namespace Awesome.Plugins.PlatformPlugin.Touch
{
	public class PlatformPlugin : IPlatformPlugin
	{
		public PlatformPlugin ()
		{
		}

		#region IPlatformPlugin implementation

		public string PlatformString
		{
			get
			{
				return "iOS";
			}
		}

		#endregion
	}
}

