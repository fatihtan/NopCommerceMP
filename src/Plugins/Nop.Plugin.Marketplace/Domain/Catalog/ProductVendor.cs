﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Core.Domain.Common;

namespace Nop.Plugin.Marketplace.Domain.Catalog
{
    public class ProductVendor : BaseEntity, ISoftDeletedEntity
    {
        public int ProductId { get; set; }

        public int VendorId { get; set; }

        public decimal Price { get; set; }

        public decimal OldPrice { get; set; }

        public decimal ProductCost { get; set; }

        public bool IsActive { get; set; }

        public bool Deleted { get; set; }
    }
}