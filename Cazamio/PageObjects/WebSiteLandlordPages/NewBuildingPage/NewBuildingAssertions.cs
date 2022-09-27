using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.NewBuildingPage
{
    public partial class NewBuilding
    {
        [AllureStep("VerifyTitleListOfBuildingsPg")]
        public NewBuilding VerifyTitleNewBuildingPg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleNewBuildingPage));

            return this;
        }
    }
}
