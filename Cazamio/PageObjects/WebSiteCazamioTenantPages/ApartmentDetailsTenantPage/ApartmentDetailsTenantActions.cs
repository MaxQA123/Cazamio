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
            Button.Click(ButtonSubmitApplication);

            return this;
        }
    }
}
