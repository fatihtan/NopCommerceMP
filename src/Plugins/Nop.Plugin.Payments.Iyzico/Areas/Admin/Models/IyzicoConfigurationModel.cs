using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Plugin.Payments.Iyzico.Areas.Admin.Models
{
    public record IyzicoConfigurationModel : BaseNopModel, ISettingsModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }

        [NopResourceDisplayName("Nop.Plugin.Payments.Iyzico.Configuration.Fields.APIKey")]
        public string APIKey { get; set; }

        [NopResourceDisplayName("Nop.Plugin.Payments.Iyzico.Configuration.Fields.SecretKey")]
        public string SecretKey { get; set; }

        [NopResourceDisplayName("Nop.Plugin.Payments.Iyzico.Configuration.Fields.URL")]
        public string URL { get; set; }

        [NopResourceDisplayName("Nop.Plugin.Payments.Iyzico.Configuration.Fields.CallbackURL")]
        public string CallbackURL { get; set; }
    }
}
