using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore;
using Awesome.Plugins.PlatformPlugin;

namespace Awesome.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}

		public override void Start ()
		{
			base.Start();

			var platformPlugin = Mvx.Resolve<IPlatformPlugin>();

			_hello = "Hello " + platformPlugin.PlatformString;
		}
    }
}
