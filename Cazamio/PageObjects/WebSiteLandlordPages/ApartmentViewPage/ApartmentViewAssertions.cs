using CazamioProgect.Helpers;
using NUnit.Allure.Steps;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ApartmentViewPage
{
    public partial class ApartmentView
    {
        [AllureStep("VerifyTitleApartmentViewPg")]
        public ApartmentView VerifyTitleApartmentViewPg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleApartmentViewPg));

            return this;
        }
    }
}
