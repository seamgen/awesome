using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awesome.Plugins.PlatformPlugin.Phone
{
    public class PlatformPlugin : IPlatformPlugin
    {
        public string PlatformString
        {
            get { return "Windows"; }
        }
    }
}
