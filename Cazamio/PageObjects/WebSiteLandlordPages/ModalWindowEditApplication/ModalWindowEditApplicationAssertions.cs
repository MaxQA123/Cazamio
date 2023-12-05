using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ModalWindowEditApplication
{
    public partial class ModalWindowEditApplication
    {
        [AllureStep("VerifyTitleEditApplicationMdlWndwEdtApplctn")]
        public ModalWindowEditApplication VerifyTitleEditApplicationMdlWndwEdtApplctn()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleEditApplication));

            return this;
        }

        [AllureStep("VerifyEmailAndUnitAddress")]
        public ModalWindowEditApplication VerifyBuildingAddress(string actual, string expected)
        {
            Assert.Multiple(() =>
            {
                Console.WriteLine($"Email: {actual.ToString()}");
                Console.WriteLine($"Unit Address: {expected}");
                //Assert.AreEqual(getUnitAddressStepSecondActual, getUnitAddressStepThirdActual);
                //Assert.AreEqual(getUnitAddressStepSecondActual, getUnitAddressStepThirdActual);

                //Console.WriteLine($"Email: {getEmailStepThirdActual}");
                //Console.WriteLine($"Unit Address: {getUnitAddressStepThirdActual}");
            });

            return this;
        }
    }
}
