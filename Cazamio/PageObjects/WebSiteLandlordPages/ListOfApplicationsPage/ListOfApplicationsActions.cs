using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfApplicationsPage
{
    public partial class ListOfApplications
    {
        string unitAddressTwoWashingtonSquareUnitTwo = TestDataForWebSiteAdmin.SHORT_ADDRESS_UNIT_FIFTEEN_MP;

        [AllureStep("ClickButtonPlusApplication")]
        public ListOfApplications ClickButtonPlusApplication()
        {
            WaitUntil.WaitSomeInterval(4000);
            WaitUntil.CustomElementIsVisible(ButtonPlusApplication);
            Button.Click(ButtonPlusApplication);

            return this;
        }

        [AllureStep("SelectItemTwoWashingtonSquareUnitTwo")]
        public ListOfApplications SelectItemTwoWashingtonSquareUnitTwo()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(FieldInputSearchLstOfApplctn);
            Button.Click(FieldInputSearchLstOfApplctn);
            InputGeneral.InputFunctionWithClear(FieldInputSearchLstOfApplctn, unitAddressTwoWashingtonSquareUnitTwo);
            WaitUntil.CustomElementIsVisible(ItemTwoWashingtonSquareUnitTwo);
            Button.Click(ItemTwoWashingtonSquareUnitTwo);

            return this;
        }
    }
}
