using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core.Domain.Common;
using Nop.Core.Domain.Vendors;

namespace Nop.Core.Domain.Catalog
{
    /// <summary>
    /// Represents a product vendor mapping
    /// </summary>
    public class ProductVendor : BaseEntity, ISoftDeletedEntity
    {
        /// <summary>
        /// Gets or sets the product identifier
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the vendor identifier
        /// </summary>
        public int VendorId { get; set; }

        /// <summary>
        /// Gets or sets the product price on vendor mapping
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the product old price on vendor mapping
        /// </summary>
        public decimal OldPrice { get; set; }

        /// <summary>
        /// Gets or sets the product cost on vendor mapping
        /// </summary>
        public decimal ProductCost { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity has been active or inactive
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity has been deleted
        /// </summary>
        public bool Deleted { get; set; }

        public Vendor Vendor { get; set; }
    }
}