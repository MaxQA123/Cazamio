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
        [AllureStep("ClickButtonAddBuilding")]
        public ListOfBuildings ClickButtonAddBuilding()
        {
            WaitUntil.ElementIsClickable(ButtonAdd, 10);
            Button.Click(ButtonAdd);

            return this;
        }

        [AllureStep("SelectItemFirstBuildingOnPage")]
        public ListOfBuildings SelectItemFirstBuildingOnPage()
        {
            WaitUntil.ElementIsClickable(ItemFirstBuildingOnPage, 10);
            Button.Click(ItemFirstBuildingOnPage);

            return this;
        }
    }
}
