using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Plugin.Widgets.Marketplace.Infrastructure;
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
            if (string.IsNullOrEmpty(widgetZone))
                throw new ArgumentException(nameof(widgetZone));

            if (widgetZone.Equals(PublicWidgetZones.ProductDetailsPriceTop) || widgetZone.Equals(PublicWidgetZones.ProductDetailsPriceBottom))
            {
                return MarketplaceConstants.ViewComponentProductDetailsPriceTop;
            }
            else if (widgetZone.Equals(PublicWidgetZones.ProductDetailsBeforeCollateral))
            {
                return MarketplaceConstants.ViewComponentProductDetailsBeforeCollateral;
            }
            else
            {
                throw new Exception($"Undefined widgetZone \"{widgetZone}\"");
            }
        }

        public async Task<IList<string>> GetWidgetZonesAsync()
        {
            return await Task.FromResult(new List<string> { PublicWidgetZones.ProductDetailsPriceBottom, PublicWidgetZones.ProductDetailsBeforeCollateral });
        }
    }
}