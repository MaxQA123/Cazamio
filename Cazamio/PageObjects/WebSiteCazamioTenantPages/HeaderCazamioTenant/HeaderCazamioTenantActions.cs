using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteCazamioTenantPages.HeaderCazamioTenant
{
    public partial class HeaderCazamioTenant
    {
        [AllureStep("ClickButtonSignUpHdrCzmTnnt")]
        public HeaderCazamioTenant ClickButtonSignUpHdrCzmTnnt()
        {
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonSignUpHdrCzmTnnt);

            return this;
        }

        [AllureStep("ClickButtonLogInHdrCzmTnnt")]
        public HeaderCazamioTenant ClickButtonLogInHdrCzmTnnt()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonLogInHdrCzmTnnt.Click();

            return this;
        }

        [AllureStep("ClickButtonMyPreApprovedApartmentsHdrCzmTnnt")]
        public HeaderCazamioTenant ClickButtonMyPreApprovedApartmentsHdrCzmTnnt()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonMyPreApprovedApartmentsHdrCzmTnnt.Click();

            return this;
        }

        [AllureStep("ClickButtonMyApplicationsHdrCzmTnnt")]
        public HeaderCazamioTenant ClickButtonMyApplicationsHdrCzmTnnt()
        {
            WaitUntil.WaitSomeInterval(5000);
            ButtonMyApplicationsHdrCzmTnnt.Click();

            return this;
        }

        [AllureStep("SctollToButtonMyApplicationsHdrCzmTnntn")]
        public HeaderCazamioTenant SctollToButtonMyApplicationsHdrCzmTnntn()
        {
            WaitUntil.WaitSomeInterval(250);
            ScrollingJScriptExecutorHelper.ScrollToElement(ButtonMyApplicationsHdrCzmTnnt);

            return this;
        }
    }
}
