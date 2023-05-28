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
            Button.Click(ButtonAdd);

            return this;
        }
    }
}
