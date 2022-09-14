using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.PaymentSettingsPage
{
    public partial class PaymentSettings
    {
        [AllureStep("VerifyTitlePaymentSettingsPagePg")]
        public PaymentSettings VerifyTitlePaymentSettingsPagePg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitlePaymentSettingsPage));

            return this;
        }
    }
}
