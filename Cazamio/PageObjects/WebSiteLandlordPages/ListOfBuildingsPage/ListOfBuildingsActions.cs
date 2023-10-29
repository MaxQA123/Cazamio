﻿using CazamioProgect.Helpers;
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
        string buildingAddress = TestDataForWebSiteAdmin.ADDRESS_BUILDING_FIFTEEN_MP;

        [AllureStep("ClickButtonAddBuilding")]
        public ListOfBuildings ClickButtonAddBuilding()
        {
            WaitUntil.CustomElementIsVisible(ButtonAdd);
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
            VerifyTitleListOfBuildingsPg();
            InputGeneral.InputFunctionWithClear(FieldInputSearchOnListOfBuildingsPg, buildingAddress);
            WaitUntil.CustomElementIsVisible(ItemFirstBuildingOnPage);
            Button.Click(ItemFirstBuildingOnPage);
            WaitUntil.WaitSomeInterval(1000);
            Pages.BuildingView
                .ClickTabApartmentsBldngVwPg();
            KeyBoardActions.ScrollToDown();
            Pages.BuildingView
                .SelectUnitFourInTabApartmentsBldngVwPg();
            

            return this;
        }

    }
}
