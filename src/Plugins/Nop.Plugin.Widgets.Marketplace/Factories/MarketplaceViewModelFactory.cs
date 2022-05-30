using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nop.Core.Domain.Vendors;
using Nop.Data;
using Nop.Plugin.Widgets.Marketplace.Models;
using Nop.Plugin.Widgets.Marketplace.Services;
using Nop.Services.Seo;

namespace Nop.Plugin.Widgets.Marketplace.Factories
{
    public class MarketplaceViewModelFactory : IMarketplaceViewModelFactory
    {
        private readonly IProductVendorService _iProductVendorService;
        private readonly IRepository<Vendor> _vendorRepository;
        private readonly IUrlRecordService _urlRecordService;

        public MarketplaceViewModelFactory(
            IProductVendorService iProductVendorService,
            IRepository<Vendor> vendorRepository,
            IUrlRecordService urlRecordService)
        {
            this._iProductVendorService = iProductVendorService;
            this._vendorRepository = vendorRepository;
            this._urlRecordService = urlRecordService;
        }

        public async Task<int> GetVendorCount(int productId)
        {
            var productVendorMappings = await this._iProductVendorService.GetProductVendorByProductIdAsync(productId);

            return
                (from pvm in productVendorMappings
                 join v in _vendorRepository.Table on pvm.VendorId equals v.Id
                 select pvm.VendorId).Distinct().Count();
        }

        public async Task<ProductVendorListViewModel> GetVendorList(int productId)
        {
            var productVendorMappings = await this._iProductVendorService.GetProductVendorByProductIdAsync(productId);

            List<ProductVendorBriefInfo> productVendorBriefInfoList = 
                (from pvm in productVendorMappings
                 join v in _vendorRepository.Table on pvm.VendorId equals v.Id
                 orderby pvm.Price
                select new ProductVendorBriefInfo(pvm.Id, v.Name, this._urlRecordService.GetSeNameAsync(v).Result, pvm.Price, pvm.OldPrice)).ToList();


            var model = new ProductVendorListViewModel()
            {
                IsEnabled = productVendorBriefInfoList.Any(),
                ProductVendorBriefInfoList = productVendorBriefInfoList
            };

            return model;
        }
    }
}
