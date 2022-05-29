using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Widgets.Marketplace.Models;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Widgets.Marketplace.Components
{
    [ViewComponent(Name = "Marketplace")]
    public class MarketplaceViewComponent : NopViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string widgetZone, object additionalData)
        {
            var model = new MarketplaceButtonModel()
            {
                IsEnabled = true,
                NumberOfVendors = 4
            };

            return View("~/Plugins/Widgets.Marketplace/Views/Shared/Components/MarketplaceButton.cshtml", model);
        }
    }
}