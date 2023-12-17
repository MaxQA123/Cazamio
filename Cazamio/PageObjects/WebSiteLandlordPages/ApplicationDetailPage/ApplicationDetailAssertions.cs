using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ApplicationDetailPage
{
    public partial class ApplicationDetail
    {
        [AllureStep("VerifyTitleListOfApplicationsPg")]
        public ApplicationDetail VerifyTitleApplicationDetailPg()
        {
            WaitUntil.CustomElementIsVisible(TitleApplicationDetail);
            Assert.IsTrue(Successfully.IsVisible(TitleApplicationDetail));

            return this;
        }

        [AllureStep("VerifyNetRent")]
        public ApplicationDetail VerifyNetRent(decimal getNetEffectiveActualFromCrtApplctn, decimal getNetRentActualApplctnDtlPg)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(getNetEffectiveActualFromCrtApplctn, getNetRentActualApplctnDtlPg);
            });

            return this;
        }
    }
}
