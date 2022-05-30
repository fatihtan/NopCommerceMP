using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Payments.Iyzico.Areas.Admin.Models;
using Nop.Plugin.Payments.Iyzico.Infrastructure;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Messages;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;

namespace Nop.Plugin.Payments.Iyzico.Areas.Admin.Controllers
{
    [Area(AreaNames.Admin)]
    [AutoValidateAntiforgeryToken]
    [ValidateIpAddress]
    [AuthorizeAdmin]
    [ValidateVendor]
    [SaveSelectedTab]
    public class IyzicoConfigurationController : BasePluginController
    {
        private readonly ISettingService _iSettingService;
        private readonly INotificationService _iNotificationService;
        private readonly ILocalizationService _ilocalizationService;

        public IyzicoConfigurationController(
            ISettingService iSettingService,
            ILocalizationService ilocalizationService,
            INotificationService iNotificationService)
        {
            this._iSettingService = iSettingService;
            this._iNotificationService = iNotificationService;
            this._ilocalizationService = ilocalizationService;
        }

        public async Task<IActionResult> Configure()
        {
            var settings = await _iSettingService.LoadSettingAsync<IyzicoSettings>();
            var model = new IyzicoConfigurationModel()
            {
                APIKey = settings.APIKey,
                SecretKey = settings.SecretKey,
                URL = settings.URL,
                CallbackURL = settings.CallbackURL
            };

            return View("~/Plugins/Payments.Iyzico/Areas/Admin/Views/IyzicoConfiguration/Configure.cshtml", model);
        }

        [HttpPost]
        public async Task<IActionResult> Configure(IyzicoConfigurationModel model)
        {
            var settings = new IyzicoSettings()
            {
                APIKey = model.APIKey,
                SecretKey = model.SecretKey,
                URL = model.URL,
                CallbackURL = model.CallbackURL
            };

            await _iSettingService.SaveSettingAsync(settings);
            await _iSettingService.ClearCacheAsync();

            this._iNotificationService.SuccessNotification(await this._ilocalizationService.GetResourceAsync("Admin.Plugins.Saved"));

            return await Configure();
        }
    }
}
