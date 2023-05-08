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

        [AllureStep("VerifyMessageBrokerHasBeenSuccessfullyCreated")]
        public ListOfBrokers VerifyMessageBrokerHasBeenSuccessfullyCreated()
        {
            WaitUntil.CustomElementIsVisible(MessageBrokerHasBeenSuccessfullyCreated);
            Assert.IsTrue(Successfully.IsVisible(MessageBrokerHasBeenSuccessfullyCreated));

            return this;
        }

        [AllureStep("VerifyEmailInListOfBrokers")]
        public ListOfBrokers VerifyEmailInListOfBrokers(string getFullEmail, string getEmailFromListOfBrokers)
        {
            WaitUntil.WaitSomeInterval(500);
            Assert.AreEqual(getFullEmail, getEmailFromListOfBrokers);

            Console.WriteLine($"Email a new broker: {getFullEmail}");

            return this;
        }
    }
}
