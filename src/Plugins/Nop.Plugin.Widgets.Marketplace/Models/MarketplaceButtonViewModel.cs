using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Web.Framework.Models;

namespace Nop.Plugin.Widgets.Marketplace.Models
{
    public class MarketplaceButtonViewModel
    {
        public bool IsEnabled { get; set; }

        public int NumberOfVendors { get; set; }
    }
}
