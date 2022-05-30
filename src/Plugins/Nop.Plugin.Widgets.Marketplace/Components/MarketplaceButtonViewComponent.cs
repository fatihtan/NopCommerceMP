using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Widgets.Marketplace.Factories;
using Nop.Plugin.Widgets.Marketplace.Models;
using Nop.Web.Framework.Components;
using Nop.Web.Models.Catalog;

namespace Nop.Plugin.Widgets.Marketplace.Components
{
    [ViewComponent(Name = "MarketplaceButton")]
    public class MarketplaceButtonViewComponent : NopViewComponent
    {
        private readonly IMarketplaceViewModelFactory _iMarketplaceViewModelFactory;

        public MarketplaceButtonViewComponent(IMarketplaceViewModelFactory iMarketplaceViewModelFactory)
        {
            this._iMarketplaceViewModelFactory = iMarketplaceViewModelFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(string widgetZone, object additionalData)
        {
            if (additionalData is not ProductDetailsModel)
            {
                throw new ArgumentException(nameof(additionalData));
            }

            var productDetailsModel = additionalData as ProductDetailsModel;

            var vendorCount = await this._iMarketplaceViewModelFactory.GetVendorCount(productDetailsModel.Id);
            var model = new MarketplaceButtonViewModel()
            {
                IsEnabled = vendorCount != 0,
                NumberOfVendors = vendorCount
            };

            return View("~/Plugins/Widgets.Marketplace/Views/Shared/Components/MarketplaceButton.cshtml", model);
        }
    }
}