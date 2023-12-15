using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.LogInPage
{
    public partial class LogInLandlord
    {
        [AllureStep("VerifyTitleLogInPg")]
        public LogInLandlord VerifyTitleLogInPg()
        {
            WaitUntil.CustomElementIsVisible(TitleLogInPg);
            Assert.IsTrue(Successfully.IsVisible(TitleLogInPg));

            return this;
        }
    }
}
