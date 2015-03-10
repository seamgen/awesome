using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Touch.Platform;
using UIKit;
using Cirrious.CrossCore;
using Awesome.Plugins.PlatformPlugin;
using Awesome.Plugins.PlatformPlugin.Touch;

namespace Awesome.Touch
{
	public class Setup : MvxTouchSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			Mvx.LazyConstructAndRegisterSingleton<IPlatformPlugin, PlatformPlugin>();

			return new Core.App();
		}
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
	}
}