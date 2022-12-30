using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteCazamioTenantPages.ApartmentDetailsTenantPage
{
    public partial class ApartmentDetailsTenant
    {
        [AllureStep("ClickButtonSubmitApplicationTn")]
        public ApartmentDetailsTenant ClickButtonSubmitApplicationTn()
        {
            WaitUntil.WaitSomeInterval(500);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[1]);
            WaitUntil.WaitSomeInterval(2000);
            Button.Click(ButtonSubmitApplication);

            return this;
        }
    }
}
