using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.AddApartmentsPage
{
    public partial class AddApartments
    {
        [AllureStep("VerifyTitleAddApartmentsPage")]
        public AddApartments VerifyTitleAddApartmentsPage()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleAddApartmentsPage));

            return this;
        }
    }
}
