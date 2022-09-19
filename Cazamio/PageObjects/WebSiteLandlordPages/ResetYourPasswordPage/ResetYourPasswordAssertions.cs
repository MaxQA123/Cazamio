using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ResetYourPasswordPage
{
    public partial class ResetYourPassword
    {
        [AllureStep("VerifyMessageYourPasswordWasSuccessfullySentRstPsswrdPg")]
        public ResetYourPassword VerifyMessageYourPasswordWasSuccessfullySentRstPsswrdPg()
        {
            WaitUntil.WaitSomeInterval(1000);
            Assert.IsTrue(Successfully.IsVisible(MessageYourPasswordWasSuccessfullySentRstPsswrdPg));

            return this;
        }
    }
}
