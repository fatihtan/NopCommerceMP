using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Widgets.Marketplace.Factories;
using Nop.Plugin.Widgets.Marketplace.Models;
using Nop.Plugin.Widgets.Marketplace.Services;
using Nop.Web.Framework.Components;
using Nop.Web.Models.Catalog;

namespace Nop.Plugin.Widgets.Marketplace.Components
{
    [ViewComponent(Name = "ProductVendorList")]
    public class ProductVendorListViewComponent : NopViewComponent
    {
        private readonly IMarketplaceViewModelFactory _iMarketplaceViewModelFactory;

        public ProductVendorListViewComponent(IMarketplaceViewModelFactory iMarketplaceViewModelFactory)
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
            var model = await this._iMarketplaceViewModelFactory.GetVendorList(productDetailsModel.Id);

            return View("~/Plugins/Widgets.Marketplace/Views/Shared/Components/ProductVendorList.cshtml", model);
        }
    }
}