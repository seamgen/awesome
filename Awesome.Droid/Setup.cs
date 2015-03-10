using Android.Content;
using Awesome.Plugins.PlatformPlugin;
using Awesome.Plugins.PlatformPlugin.Droid;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;

namespace Awesome.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
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