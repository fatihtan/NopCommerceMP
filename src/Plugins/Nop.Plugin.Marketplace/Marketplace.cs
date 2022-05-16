using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Services.Cms;
using Nop.Services.Common;
using Nop.Services.Plugins;

namespace Nop.Plugin.Marketplace
{
    public class Marketplace : BasePlugin, IMiscPlugin
    {
        public override Task InstallAsync()
        {
            return base.InstallAsync();
        }

        public override Task UninstallAsync()
        {
            return base.UninstallAsync();
        }
    }
}