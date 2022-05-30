using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Plugin.Widgets.Marketplace.Models;

namespace Nop.Plugin.Widgets.Marketplace.Factories
{
    public interface IMarketplaceViewModelFactory
    {
        Task<ProductVendorListViewModel> GetVendorList(int productId);

        Task<int> GetVendorCount(int productId);
    }
}
