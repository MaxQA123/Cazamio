using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteCazamioTenantPages.ModalWindowPleaseTellUsYourName
{
    public partial class ModalWindowPleaseTellUsYourName
    {
        [AllureStep("VerifyTitleCreateApplicationModalWndw")]
        public ModalWindowPleaseTellUsYourName VerifyTitleHowShallWeCallYouMdlWndw()
        {
            WaitUntil.CustomElementIsVisible(TitleHowShallWeCallYouMdlWndw);
            Assert.IsTrue(Successfully.IsVisible(TitleHowShallWeCallYouMdlWndw));

            return this;
        }
    }
}
