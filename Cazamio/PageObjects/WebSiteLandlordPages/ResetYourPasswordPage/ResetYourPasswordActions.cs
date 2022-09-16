using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ResetYourPasswordPage
{
    public partial class ResetYourPassword
    {
        [AllureStep("EnterEmailForRstPsswrdPg")]
        public ResetYourPassword EnterEmailForRstPsswrdPg()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailRstPsswrdPg, TestDataForWebSiteLandlord.emailBrokerMikeFlower);

            return this;
        }

        [AllureStep("ClickButtonSendInstructionsRstPsswrdPg")]
        public ResetYourPassword ClickButtonSendInstructionsRstPsswrdPg()
        {
            Button.Click(ButtonSendInstructionsRstPsswrdPg);

            return this;
        }

        [AllureStep("EnterNewConfirmPassword")]
        public ResetYourPassword EnterNewConfirmPassword()
        {
            InputGeneral.InputFunctionWithClear(FieldInputNewPasswordRstPsswrdPg, GeneralTestDataForAllUsers.passwordGeneral);
            InputGeneral.InputFunctionWithClear(FieldInputConfirmPasswordRstPsswrdPg, GeneralTestDataForAllUsers.passwordGeneral);

            return this;
        }

        [AllureStep("ClickButtonResetPasswordlRstPsswrdPg")]
        public ResetYourPassword ClickButtonResetPasswordlRstPsswrdPg()
        {
            Button.Click(ButtonResetPasswordlRstPsswrdPg);

            return this;
        }
    }
}
