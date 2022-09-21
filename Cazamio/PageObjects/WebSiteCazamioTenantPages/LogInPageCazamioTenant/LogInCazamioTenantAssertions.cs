using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.GeneralPages.LogInPageCazamioTenant
{
    public partial class LogInCazamioTenant
    {
        [AllureStep("VerifyTitleListOfBuildingsPg")]
        public LogInCazamioTenant VerifyMessageAccountWasSuccessfullyActivatedLogInPg()
        {
            WaitUntil.WaitSomeInterval(3000);
            Assert.IsTrue(Successfully.IsVisible(MessageAccountWasSuccessfullyActivated));

            return this;
        }

        [AllureStep("VerifyMessageYouHaveSuccesfullyChangedYourPasswordLgInPg")]
        public LogInCazamioTenant VerifyMessageYouHaveSuccesfullyChangedYourPasswordLgInPg()
        {
            WaitUntil.WaitSomeInterval(3000);
            Assert.IsTrue(Successfully.IsVisible(MessageYouHaveSuccesfullyChangedYourPasswordLgInPg));

            return this;
        }

        

    }
}
