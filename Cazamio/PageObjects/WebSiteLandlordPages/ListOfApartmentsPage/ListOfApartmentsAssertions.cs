using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfApartmentsPage
{
    public partial class ListOfApartments
    {
        [AllureStep("VerifyTitleListOfApartmentsPg")]
        public ListOfApartments VerifyTitleListOfApartmentsPg()
        {
            WaitUntil.WaitSomeInterval(2000);
            Assert.IsTrue(Successfully.IsVisible(TitleListOfApartmentsPage));

            return this;
        }
    }
}
