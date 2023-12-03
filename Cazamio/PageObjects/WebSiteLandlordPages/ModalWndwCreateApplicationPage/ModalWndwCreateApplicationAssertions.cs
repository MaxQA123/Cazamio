using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ModalWndwCreateAApplicationPage
{
    public partial class ModalWndwCreateApplication
    {
        [AllureStep("VerifyTitleCreateApplicationModalWndw")]
        public ModalWndwCreateApplication VerifyTitleCreateApplicationModalWndw()
        {
            WaitUntil.CustomElementIsVisible(TitleCreateApplicationModalWndw);
            Assert.IsTrue(Successfully.IsVisible(TitleCreateApplicationModalWndw));

            return this;
        }

        [AllureStep("VerifyEmailAndUnitAddress")]
        public ModalWndwCreateApplication VerifyEmailAndUnitAddress( string getEmailStepFirstActual, string getUnitAddressStepSecondActual, string getEmailStepThirdActual, string getUnitAddressStepThirdActual)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(getEmailStepFirstActual, getEmailStepThirdActual);
                Assert.AreEqual(getUnitAddressStepSecondActual, getUnitAddressStepThirdActual);

                Console.WriteLine($"Email: {getEmailStepThirdActual}");
                Console.WriteLine($"Unit Address: {getUnitAddressStepThirdActual}");
            });

            return this;
        }

        [AllureStep("VerifyEmail")]
        public ModalWndwCreateApplication VerifyEmail(string getEmailStepFirstActual, string getEmailStepThirdActual)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(getEmailStepFirstActual, getEmailStepThirdActual);

                Console.WriteLine($"Email: {getEmailStepThirdActual}");
            });

            return this;
        }

        [AllureStep("VerifyFieldsAutocompleteInStepThird")]
        public ModalWndwCreateApplication VerifyFieldsAutocompleteInStepThird(int getLeasePriceFromDb, int getSecurityDepositFromDb, int? getMonthlyRentsPrePaymentFromDb, string getRentalTermsFromDb, int getLeasePriceActual, int getSecurityDepositActual, int? getMonthlyRentsPrePaymentActual, string getRentalTermsActual)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(getLeasePriceFromDb, getLeasePriceActual);
                Assert.AreEqual(getSecurityDepositFromDb, getSecurityDepositActual);
                Assert.AreEqual(getMonthlyRentsPrePaymentFromDb, getMonthlyRentsPrePaymentActual);
                Assert.AreEqual(getRentalTermsFromDb, getRentalTermsActual);

                Console.WriteLine($"{getLeasePriceActual}");
                Console.WriteLine($"{getSecurityDepositActual}");
                Console.WriteLine($"{getMonthlyRentsPrePaymentActual}");
                Console.WriteLine($"{getRentalTermsActual}");
            });

            return this;
        }

        [AllureStep("VerifyMessageStepFourModalWndw")]
        public ModalWndwCreateApplication VerifyMessageStepFourModalWndw()
        {
            WaitUntil.CustomElementIsVisible(MessageStepFourModalWndw);
            Assert.IsTrue(Successfully.IsVisible(MessageStepFourModalWndw));

            return this;
        }
    }
}
