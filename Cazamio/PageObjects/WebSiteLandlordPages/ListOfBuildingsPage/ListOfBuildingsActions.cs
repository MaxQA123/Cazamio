using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfBuildingsPage
{
    public partial class ListOfBuildings
    {
        string buildingAddress = TestDataForWebSiteAdmin.SHORT_ADDRESS_BUILDING_FIFTEEN_MP_FOR_BROKER;

        [AllureStep("ClickButtonAddBuilding")]
        public ListOfBuildings ClickButtonAddBuilding()
        {
            WaitUntil.CustomElementIsVisible(ButtonAdd);
            WaitUntil.WaitForElementClickable(ButtonAdd, 10);
            Button.Click(ButtonAdd);

            return this;
        }

        [AllureStep("SelectItemFirstBuildingOnPage")]
        public ListOfBuildings SelectItemFirstBuildingOnPage()
        {
            WaitUntil.CustomElementIsVisible(ItemFirstBuildingOnPage);
            Button.Click(ItemFirstBuildingOnPage);

            return this;
        }

        [AllureStep("OpenPageApartmentView")]
        public ListOfBuildings OpenPageApartmentView()
        {
            Pages.SideBarLandlord
               .ClickButtonBuildingsSidebar();
            WaitUntil.CustomElementIsVisible(TitleListOfBuildingsPage);
            VerifyTitleListOfBuildingsPg();
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(FieldInputSearchOnListOfBuildingsPg);
            InputGeneral.InputFunctionWithClear(FieldInputSearchOnListOfBuildingsPg, buildingAddress);
            WaitUntil.CustomElementIsVisible(ItemFirstBuildingOnPage);
            Button.Click(ItemFirstBuildingOnPage);
            WaitUntil.WaitSomeInterval(3000);
            Pages.BuildingView
                .ClickTabApartmentsBldngVwPg();
            KeyBoardActions.ScrollToDown();
            Pages.BuildingView
                .SelectUnitFourInTabApartmentsBldngVwPg();
            

            return this;
        }

    }
}
