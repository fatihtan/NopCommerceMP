using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Vendors;
using Nop.Data;

namespace Nop.Services.Catalog
{
    public class ProductVendorService : IProductVendorService
    {
        protected readonly IRepository<ProductVendor> _productVendorRepository;
        protected readonly IRepository<Vendor> _vendorRepository;
        protected readonly IWorkContext _workContext;

        public ProductVendorService(
            IRepository<ProductVendor> productVendorRepository,
            IRepository<Vendor> vendorRepository,
            IWorkContext workContext)
        {
            this._vendorRepository = vendorRepository;
            this._productVendorRepository = productVendorRepository;
            this._workContext = workContext;
        }

        public Task<IList<Vendor>> GetVendorsByProductIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        //public async Task<IList<Vendor>> GetVendorsByProductIdAsync(int productId)
        //{
        //    var productVendors = this._productVendorRepository.Table.Where(pv => pv.ProductId == productId && pv.IsActive && !pv.Deleted).ToListAsync();

        //    var vendorList = from pv in productVendors.Result
        //                     join v in _vendorRepository.Table on pv.ProductId equals v.Id
        //                     select v;

        //    return await vendorList;

        //}
    }
}