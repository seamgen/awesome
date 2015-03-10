using Awesome.Plugins.PlatformPlugin;
using Awesome.Plugins.PlatformPlugin.Phone;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.WindowsCommon.Platform;
using Windows.UI.Xaml.Controls;

namespace Awesome.Phone
{
    public class Setup : MvxWindowsSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
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