using CazamioProgect.Helpers;
using CazamioProject.Objects;
using CazamioProject.Tables;
using CazamioProject.Tables.TableEnums;
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
        Building building = new Building().Generate();
        Apartment apartment = new Apartment().Generate();

        [AllureStep("ClickButtonAddBuilding")]
        public ListOfBuildings ClickButtonAddBuilding()
        {
            WaitUntil.WaitSomeInterval(10000);
            WaitUntil.CustomElementIsVisible(ButtonAdd, 10);
            WaitUntil.CustomElementIsClickable(ButtonAdd, 10);
            Button.Click(ButtonAdd);

            return this;
        }

        [AllureStep("SearchBuildingMarkAdmBroker")]
        public ListOfBuildings SearchBuildingMarkAdmBroker()
        {
            WaitUntil.WaitSomeInterval(5000);
            WaitUntil.CustomElementIsVisible(FieldInputSearch);
            WaitUntil.CustomElementIsClickable(FieldInputSearch);
            InputGeneral.InputFunctionWithClear(FieldInputSearch, apartment.BuildingShortAddress.MarkAdmAssignedBroker);

            return this;
        }

        [AllureStep("SelectItemFirst")]
        public ListOfBuildings SelectItemFirst()
        {
            WaitUntil.CustomElementIsVisible(ItemFirstBuildingOnPage);
            WaitUntil.CustomElementIsClickable(ItemFirstBuildingOnPage);
            Button.Click(ItemFirstBuildingOnPage);

            return this;
        }

        [AllureStep("OpenPageApartmentView")]
        public ListOfBuildings OpenPageApartmentView()
        {
            Pages.SideBarLandlord
               .ClickButtonBuildings();
            WaitUntil.CustomElementIsVisible(TitleListOfBuildingsPage);
            VerifyTitleListOfBuildingsPg();
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(FieldInputSearch);
            InputGeneral.InputFunctionWithClear(FieldInputSearch, buildingAddress);
            WaitUntil.CustomElementIsVisible(ItemFirstBuildingOnPage);
            Button.Click(ItemFirstBuildingOnPage);
            WaitUntil.WaitSomeInterval(3000);
            Pages.BuildingView
                .ClickButtonAddInTabApartments();
            KeyBoardActions.ScrollToDown();
            Pages.BuildingView
                .SelectUnitFourInTabApartmentsBldngVwPg();
            

            return this;
        }

        [AllureStep("DemoTables")]
        public ListOfBuildings DemoTables()
        {
            var building = new TableElementProvider().GetCellElement(BuildingsTable.Name, 1);
            Console.WriteLine(building.Text);

            return this;
        }

    }
}
