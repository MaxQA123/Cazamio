using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ListOfMarketplaceAdmins
{
    public partial class ListOfMarketplaceAdmins
    {
        [AllureStep("VerifyTitleListOfMarketplaceAdmins")]
        public ListOfMarketplaceAdmins VerifyTitleListOfMarketplaceAdmins()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleListOfMarketplaceAdmins));

            return this;
        }

        [AllureStep("VerifyMessageMarketplaceAdminHasBeenSuccessfullyCreated")]
        public ListOfMarketplaceAdmins VerifyMessageMarketplaceAdminHasBeenSuccessfullyCreated()
        {
            WaitUntil.CustomElementIsVisible(MessageMarketplaceAdminHasBeenSuccessfullyCreated);
            Assert.IsTrue(Successfully.IsVisible(MessageMarketplaceAdminHasBeenSuccessfullyCreated));

            return this;
        }
    }
}
