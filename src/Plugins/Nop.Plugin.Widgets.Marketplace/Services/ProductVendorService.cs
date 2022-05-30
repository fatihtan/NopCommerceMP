using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Vendors;
using Nop.Data;
using Nop.Plugin.Widgets.Marketplace.Data.Domain;

namespace Nop.Plugin.Widgets.Marketplace.Services
{
    public class ProductVendorService : IProductVendorService
    {
        private readonly IRepository<ProductVendorMapping> _productVendorMappingRepository;
        
        public ProductVendorService(IRepository<ProductVendorMapping> productVendorMappingRepository)
        {
            this._productVendorMappingRepository = productVendorMappingRepository;
        }

        public async Task<IList<ProductVendorMapping>> GetProductVendorByProductIdAsync(int productId)
        {
            return await this._productVendorMappingRepository.Table.Where(pv => pv.ProductId == productId && !pv.Deleted).ToListAsync();
        }
    }
}