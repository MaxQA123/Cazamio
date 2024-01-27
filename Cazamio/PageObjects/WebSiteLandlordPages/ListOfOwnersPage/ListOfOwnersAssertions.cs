using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfOwnersPage
{
    public partial class ListOfOwners
    {
        [AllureStep("VerifyTitleListOfOwnersPg")]
        public ListOfOwners VerifyTitleListOfOwnersPg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleListOfOwnersPage));

            return this;
        }

        [AllureStep("VerifyMessageSuccessCreatedOwner")]
        public ListOfOwners VerifyMessageSuccessCreatedOwner()
        {
            WaitUntil.CustomElementIsVisible(MessageOwnerHasBeenSuccessfullyCreated);
            Assert.IsTrue(Successfully.IsVisible(MessageOwnerHasBeenSuccessfullyCreated));
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("VerifyEmailForNewOwner")]
        public ListOfOwners VerifyEmailForNewOwner(string getOwnerEmailFromModalWndw, string getLastEmailFromPage)
        {
            WaitUntil.WaitSomeInterval(3000);
            Assert.AreEqual(getOwnerEmailFromModalWndw, getLastEmailFromPage);
            Console.WriteLine($"{getOwnerEmailFromModalWndw} :Email in the time creating");
            Console.WriteLine($"{getLastEmailFromPage} :Email after creating");

            return this;
        }
    }
}
