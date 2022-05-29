using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Services.Cms;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;

namespace Nop.Plugin.Widgets.Marketplace
{
    public class MarketplacePlugin : BasePlugin, IWidgetPlugin
    {
        public bool HideInWidgetList => false;

        public string GetWidgetViewComponentName(string widgetZone)
        {
            return "Marketplace";
        }

        public async Task<IList<string>> GetWidgetZonesAsync()
        {
            return await Task.FromResult(new List<string> { PublicWidgetZones.ProductDetailsPriceBottom });
        }
    }
}