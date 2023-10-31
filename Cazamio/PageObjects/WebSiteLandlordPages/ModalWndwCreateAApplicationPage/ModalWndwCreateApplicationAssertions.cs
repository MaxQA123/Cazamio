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
    public partial class ModalWndwCreateAApplication
    {
        [AllureStep("VerifyTitleCreateApplicationModalWndw")]
        public ModalWndwCreateAApplication VerifyTitleCreateApplicationModalWndw()
        {
            WaitUntil.CustomElementIsVisible(TitleCreateApplicationModalWndw);
            Assert.IsTrue(Successfully.IsVisible(TitleCreateApplicationModalWndw));

            return this;
        }

        [AllureStep("VerifyEmailAndUnitAddress")]
        public ModalWndwCreateAApplication VerifyEmailAndUnitAddress( string getEmailStepFirstActual, string getUnitAddressStepSecondActual, string getEmailStepThirdActual, string getUnitAddressStepThirdActual)
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
        public ModalWndwCreateAApplication VerifyEmail(string getEmailStepFirstActual, string getEmailStepThirdActual)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(getEmailStepFirstActual, getEmailStepThirdActual);

                Console.WriteLine($"Email: {getEmailStepThirdActual}");
            });

            return this;
        }

        [AllureStep("VerifyFieldsAutocompleteInStepThird")]
        public ModalWndwCreateAApplication VerifyFieldsAutocompleteInStepThird(decimal? getLeasePriceFromDb, decimal? getSecurityDepositFromDb, int? getMonthlyRentsPrePaymentFromDb, string getRentalTermsFromDb, string getLeasePriceActual, string getSecurityDepositActual, string getMonthlyRentsPrePaymentActual, string getRentalTermsActual)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(getLeasePriceFromDb, getLeasePriceActual);
                Assert.AreEqual(getSecurityDepositFromDb, getSecurityDepositActual);
                Assert.AreEqual(getMonthlyRentsPrePaymentFromDb, getMonthlyRentsPrePaymentActual);
                Assert.AreEqual(getRentalTermsFromDb, getRentalTermsActual);

                Console.WriteLine($"Lease Price: {getLeasePriceActual}");
                Console.WriteLine($"Security Deposit: {getSecurityDepositActual}");
                Console.WriteLine($"Monthly Rents Pre Payment: {getMonthlyRentsPrePaymentActual}");
                Console.WriteLine($"Rental Terms: {getRentalTermsActual}");
            });

            return this;
        }

        [AllureStep("VerifyMessageStepFourModalWndw")]
        public ModalWndwCreateAApplication VerifyMessageStepFourModalWndw()
        {
            WaitUntil.CustomElementIsVisible(MessageStepFourModalWndw);
            Assert.IsTrue(Successfully.IsVisible(MessageStepFourModalWndw));

            return this;
        }
    }
}
