using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nop.Core.Infrastructure;
using Nop.Plugin.Widgets.Marketplace.Factories;
using Nop.Plugin.Widgets.Marketplace.Services;

namespace Nop.Plugin.Widgets.Marketplace.Infrastructure
{
    public class MarketplaceStartup : INopStartup
    {
        public int Order => int.MaxValue;

        public void Configure(IApplicationBuilder application)
        {
            
        }

        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductVendorService, ProductVendorService>();
            services.AddScoped<IMarketplaceViewModelFactory, MarketplaceViewModelFactory>();
        }
    }
}