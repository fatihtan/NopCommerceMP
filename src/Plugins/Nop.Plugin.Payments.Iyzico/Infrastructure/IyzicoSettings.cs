using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core.Configuration;

namespace Nop.Plugin.Payments.Iyzico.Infrastructure
{
    public class IyzicoSettings : ISettings
    {
        public string APIKey { get; set; }
        public string SecretKey { get; set; }
        public string URL { get; set; }
        public string CallbackURL { get; set; }
    }
}
