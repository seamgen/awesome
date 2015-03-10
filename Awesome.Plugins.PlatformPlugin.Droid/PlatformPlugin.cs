using System;

namespace Awesome.Plugins.PlatformPlugin.Droid
{
	public class PlatformPlugin : IPlatformPlugin
	{
		#region IPlatformPlugin implementation

		public string PlatformString
		{
			get
			{
				return "Android";
			}
		}

		#endregion

		public PlatformPlugin ()
		{
		}
	}
}

