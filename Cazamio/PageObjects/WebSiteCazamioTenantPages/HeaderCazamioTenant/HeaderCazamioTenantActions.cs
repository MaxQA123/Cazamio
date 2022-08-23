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
            WaitUntil.WaitSomeInterval(1000);
            ButtonMyApplicationsHdrCzmTnnt.Click();

            return this;
        }
    }
}
