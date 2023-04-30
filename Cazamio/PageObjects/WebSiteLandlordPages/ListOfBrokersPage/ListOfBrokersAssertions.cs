using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ListOfBrokersPage
{
    public partial class ListOfBrokers
    {
        [AllureStep("VerifyTitleListOfBrokersPg")]
        public ListOfBrokers VerifyTitleListOfBrokersPg()
        {
            WaitUntil.CustomElementIsVisible(TitleListOfBrokers);
            Assert.IsTrue(Successfully.IsVisible(TitleListOfBrokers));

            return this;
        }
    }
}
