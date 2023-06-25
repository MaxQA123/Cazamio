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
            Assert.IsTrue(Successfully.IsVisible(TitleBuildingViewPage));

            return this;
        }
    }
}
