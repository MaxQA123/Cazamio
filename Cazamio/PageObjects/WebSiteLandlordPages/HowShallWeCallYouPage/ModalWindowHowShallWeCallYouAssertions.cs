using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.HowShallWeCallYouPage
{
    public partial class ModalWindowHowShallWeCallYou
    {
        [AllureStep("VerifyTitleCreateApplicationModalWndw")]
        public ModalWindowHowShallWeCallYou VerifyTitleHowShallWeCallYouMdlWndw()
        {
            WaitUntil.CustomElementIsVisible(TitleHowShallWeCallYouMdlWndw);
            Assert.IsTrue(Successfully.IsVisible(TitleHowShallWeCallYouMdlWndw));

            return this;
        }
    }
}
