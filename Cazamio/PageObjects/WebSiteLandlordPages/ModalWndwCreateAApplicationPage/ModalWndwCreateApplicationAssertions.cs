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
    }
}
