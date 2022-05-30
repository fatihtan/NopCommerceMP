using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Vendors;
using Nop.Plugin.Widgets.Marketplace.Data.Domain;

namespace Nop.Plugin.Widgets.Marketplace.Services
{
    public interface IProductVendorService
    {
        Task<IList<ProductVendorMapping>> GetProductVendorByProductIdAsync(int productId);
    }
}