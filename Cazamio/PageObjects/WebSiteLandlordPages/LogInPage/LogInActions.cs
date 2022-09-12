using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.LogInPage
{
    public partial class LogInLandlord
    {
        [AllureStep("EnterEmailPasswordLogInPg")]
        public LogInLandlord EnterEmailPasswordLogInPg()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, TestDataForWebSiteLandlord.emailLandlordTest);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.passwordGeneral);

            return this;
        }

        [AllureStep("ClickIconShowLogInPg")]
        public LogInLandlord ClickIconShowLogInPg()
        {
            Button.Click(IconShowLogInPg);

            return this;
        }

        [AllureStep("ClickButtonLetsGoLogInPg")]
        public LogInLandlord ClickButtonLetsGoLogInPg()
        {
            Button.Click(ButtonLetsGoLogInPg);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }
    }
}
