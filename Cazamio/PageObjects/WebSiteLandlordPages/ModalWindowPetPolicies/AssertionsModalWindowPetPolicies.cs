using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ModalWindowPetPolicies
{
    public partial class ModalWindowPetPolicies
    {
        [AllureStep("VerifyTitlePetPoliciesMdlWndw")]
        public ModalWindowPetPolicies VerifyTitlePetPoliciesMdlWndw()
        {
            Assert.IsTrue(Successfully.IsVisible(TitlePetPolicies));

            return this;
        }
    }
}
