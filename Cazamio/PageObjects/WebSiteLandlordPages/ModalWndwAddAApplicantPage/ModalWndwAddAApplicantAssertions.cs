using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ModalWndwAddAApplicantPage
{
    public partial class ModalWndwAddAApplicant
    {
        [AllureStep("VerifyTitleCreateApplicationModalWndw")]
        public ModalWndwAddAApplicant VerifyTitleCreateApplicationModalWndw()
        {
            WaitUntil.CustomElementIsVisible(TitleAddApplicantMdlWndw);
            Assert.IsTrue(Successfully.IsVisible(TitleAddApplicantMdlWndw));

            return this;
        }
    }
}
