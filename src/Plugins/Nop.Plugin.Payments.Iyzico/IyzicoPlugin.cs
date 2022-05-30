using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Nop.Core;
using Nop.Core.Domain.Orders;
using Nop.Plugin.Payments.Iyzico.Infrastructure;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Payments;
using Nop.Services.Plugins;

namespace Nop.Plugin.Payments.Iyzico
{
    public class IyzicoPlugin : BasePlugin, IPaymentMethod
    {
        private readonly IWebHelper _iWebHelper;
        private readonly ISettingService _iSettingService;
        private readonly ILocalizationService _iLocalizationService;

        public IyzicoPlugin(
            IWebHelper iWebHelper,
            ISettingService iSettingService,
            ILocalizationService iLocalizationService)
        {
            this._iWebHelper = iWebHelper;
            this._iSettingService = iSettingService;
            this._iLocalizationService = iLocalizationService;
        }

        public bool SupportCapture => true;

        public bool SupportPartiallyRefund => true;

        public bool SupportRefund => true;

        public bool SupportVoid => true;

        public RecurringPaymentType RecurringPaymentType => RecurringPaymentType.Manual;

        public PaymentMethodType PaymentMethodType => PaymentMethodType.Standard;

        public bool SkipPaymentInfo => false;

        public Task<CancelRecurringPaymentResult> CancelRecurringPaymentAsync(CancelRecurringPaymentRequest cancelPaymentRequest)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CanRePostProcessPaymentAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<CapturePaymentResult> CaptureAsync(CapturePaymentRequest capturePaymentRequest)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> GetAdditionalHandlingFeeAsync(IList<ShoppingCartItem> cart)
        {
            throw new NotImplementedException();
        }

        public Task<ProcessPaymentRequest> GetPaymentInfoAsync(IFormCollection form)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetPaymentMethodDescriptionAsync()
        {
            throw new NotImplementedException();
        }

        public string GetPublicViewComponentName()
        {
            throw new NotImplementedException();
        }

        public Task<bool> HidePaymentMethodAsync(IList<ShoppingCartItem> cart)
        {
            throw new NotImplementedException();
        }

        public Task PostProcessPaymentAsync(PostProcessPaymentRequest postProcessPaymentRequest)
        {
            throw new NotImplementedException();
        }

        public Task<ProcessPaymentResult> ProcessPaymentAsync(ProcessPaymentRequest processPaymentRequest)
        {
            throw new NotImplementedException();
        }

        public Task<ProcessPaymentResult> ProcessRecurringPaymentAsync(ProcessPaymentRequest processPaymentRequest)
        {
            throw new NotImplementedException();
        }

        public Task<RefundPaymentResult> RefundAsync(RefundPaymentRequest refundPaymentRequest)
        {
            throw new NotImplementedException();
        }

        public Task<IList<string>> ValidatePaymentFormAsync(IFormCollection form)
        {
            throw new NotImplementedException();
        }

        public Task<VoidPaymentResult> VoidAsync(VoidPaymentRequest voidPaymentRequest)
        {
            throw new NotImplementedException();
        }

        public override async Task InstallAsync()
        {
            var settings = new IyzicoSettings()
            {
                APIKey = "",
                SecretKey = "",
                CallbackURL = "",
                URL = ""
            };

            await _iSettingService.SaveSettingAsync(settings);

            this._iLocalizationService.AddOrUpdateLocaleResourceAsync("Nop.Plugin.Payments.Iyzico.Configuration.PageTitle", "Iyzico Configuration");
            this._iLocalizationService.AddOrUpdateLocaleResourceAsync("Nop.Plugin.Payments.Iyzico.Configuration.Fields.APIKey", "API Anahtarı");

            this._iLocalizationService.AddOrUpdateLocaleResourceAsync("Nop.Plugin.Payments.Iyzico.Configuration.Fields.APIKey.Hint", "API Key");
            this._iLocalizationService.AddOrUpdateLocaleResourceAsync("Nop.Plugin.Payments.Iyzico.Configuration.Fields.SecretKey", "Secret Key");
            this._iLocalizationService.AddOrUpdateLocaleResourceAsync("Nop.Plugin.Payments.Iyzico.Configuration.Fields.URL", "URL");
            this._iLocalizationService.AddOrUpdateLocaleResourceAsync("Nop.Plugin.Payments.Iyzico.Configuration.Fields.CallbackURL", "Callback URL");


        }

        public override async Task UninstallAsync()
        {
            await _iSettingService.DeleteSettingAsync<IyzicoSettings>();
            await _iLocalizationService.DeleteLocaleResourceAsync("Nop.Plugin.Payments.Iyzico.Configuration");
        }

        public override string GetConfigurationPageUrl()
        {
            return $"{_iWebHelper.GetStoreLocation()}Admin/IyzicoConfiguration/Configure";
        }
    }
}
