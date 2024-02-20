using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.BuildingViewPage
{
    public partial class BuildingView
    {
        [AllureStep("VerifyTitleBuildingViewPage")]
        public BuildingView VerifyTitleBuildingViewPage()
        {
            WaitUntil.CustomElementIsVisible(TitleBuildingViewPage);
            Assert.IsTrue(Successfully.IsVisible(TitleBuildingViewPage));

            return this;
        }

        [AllureStep("VerifyBuildingAddress")]
        public BuildingView VerifyBuildingAddress(string getAddressNewBuildingActual, string getAddressBuildingView)
        {
            Assert.AreEqual(getAddressNewBuildingActual, getAddressBuildingView);

            return this;
        }
    }
}
