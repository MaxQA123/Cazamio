using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteCazamioTenantPages.HomePageCazamioTenant
{
    public partial class HomeCazamioTenant
    {
        [AllureStep("SearchNumberBuildingHomePg")]
        public HomeCazamioTenant SearchNumberBuildingHomePg()
        {
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputSearch, TestDataHomePageTenant.NUMBER_BUILDING);
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(5000);

            return this;
        }
    }
}
