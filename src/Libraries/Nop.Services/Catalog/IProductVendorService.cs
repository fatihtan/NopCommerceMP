using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Vendors;

namespace Nop.Services.Catalog
{
    /// <summary>
    /// Product vendor service
    /// </summary>
    public interface IProductVendorService
    {
        Task<IList<Vendor>> GetVendorsByProductIdAsync(int productId);
    }
}