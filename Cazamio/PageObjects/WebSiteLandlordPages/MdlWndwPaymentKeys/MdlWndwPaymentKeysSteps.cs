using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.MdlWndwPaymentKeys
{
    public partial class MdlWndwPaymentKeys
    {
        [AllureStep("SelectPaymentSystemAuthorizeNet")]
        public MdlWndwPaymentKeys SelectPaymentSystemAuthorizeNet()
        {
            WaitUntil.CustomElementIsVisible(ButtonSearchPaymentSystem);
            WaitUntil.CustomElementIsClickable(ButtonSearchPaymentSystem);
            Button.Click(ButtonSearchPaymentSystem);
            Button.Click(ItemAuthorizeNet);

            return this;
        }
    }
}
