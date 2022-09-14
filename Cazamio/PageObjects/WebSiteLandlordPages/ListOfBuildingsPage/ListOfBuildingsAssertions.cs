using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfBuildingsPage
{
    public partial class ListOfBuildings
    {
        [AllureStep("VerifyTitleListOfBuildingsPg")]
        public ListOfBuildings VerifyTitleListOfBuildingsPg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleListOfBuildingsPage));

            return this;
        }
    }
}
