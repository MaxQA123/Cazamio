using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ListOfLandlordsPage
{
    public partial class ListOfLandlords
    {
        [AllureStep("VerifyTitleListOfLandlordsPg")]
        public ListOfLandlords VerifyTitleListOfLandlordsPg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleListOfLandlords));

            return this;
        }
    }
}
