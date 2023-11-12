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
            WaitUntil.CustomElementIsVisible(TitleAddApplicantMdlWndwAddAApplicant);
            Assert.IsTrue(Successfully.IsVisible(TitleAddApplicantMdlWndwAddAApplicant));

            return this;
        }

        [AllureStep("VerifyMessageAddedApplicantsToApplicationMdlWndwAddAApplicant")]
        public ModalWndwAddAApplicant VerifyMessageAddedApplicantsToApplicationMdlWndwAddAApplicant()
        {
            WaitUntil.CustomElementIsVisible(MessageAddedApplicantsToApplicationMdlWndwAddAApplicant);
            Assert.IsTrue(Successfully.IsVisible(MessageAddedApplicantsToApplicationMdlWndwAddAApplicant));

            return this;
        }
    }
}
