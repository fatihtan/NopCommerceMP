using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Widgets.Marketplace.Models
{
    public class ProductVendorListViewModel
    {
        public bool IsEnabled { get; set; }

        public List<ProductVendorBriefInfo> ProductVendorBriefInfoList { get; set; }

        public ProductVendorListViewModel()
        {
            this.ProductVendorBriefInfoList = new List<ProductVendorBriefInfo>();
        }
    }

    public class ProductVendorBriefInfo
    {
        public int ProductVendorMappingId { get; set; }

        public string VendorName { get; set; }

        public string VendorURL { get; set; }

        public decimal Price { get; set; }

        public decimal OldPrice { get; set; }

        public ProductVendorBriefInfo(int productVendorMappingId, string vendorName, string vendorURL, decimal price, decimal oldPrice)
        {
            this.ProductVendorMappingId = productVendorMappingId;
            this.VendorName = vendorName;
            this.VendorURL = vendorURL;
            this.Price = price;
            this.OldPrice = oldPrice;
        }
    }
}
