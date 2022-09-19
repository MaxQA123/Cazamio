﻿using CazamioProgect.Helpers;
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
            InputGeneral.InputFunctionWithClear(FieldInputEmailRstPsswrdPg, TestDataForWebSiteLandlord.emailBrokerLiluDalas);

            return this;
        }

        [AllureStep("ClickButtonSendInstructionsRstPsswrdPg")]
        public ResetYourPassword ClickButtonSendInstructionsRstPsswrdPg()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonSendInstructionsRstPsswrdPg);

            return this;
        }

        [AllureStep("EnterNewConfirmPassword")]
        public ResetYourPassword EnterNewConfirmPassword()
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            //InputGeneral.InputFunctionWithClear(FieldInputNewPasswordRstPsswrdPg, TestDataForWebSiteLandlord.newPasswordBrokerLiluDalasBroker);
            //InputGeneral.InputFunctionWithClear(FieldInputConfirmPasswordRstPsswrdPg, TestDataForWebSiteLandlord.newPasswordBrokerLiluDalasBroker);

            InputGeneral.InputFunctionWithClear(FieldInputNewPasswordRstPsswrdPg, GeneralTestDataForAllUsers.passwordGeneral);
            InputGeneral.InputFunctionWithClear(FieldInputConfirmPasswordRstPsswrdPg, GeneralTestDataForAllUsers.passwordGeneral);

            return this;
        }

        [AllureStep("ClickButtonBackToLogInPageRstPsswrdPg")]
        public ResetYourPassword ClickIconsShowPasswordNewConfirm()
        {
            Button.Click(IconForFieldNewPsswrdRstPsswrdPg);
            Button.Click(IconForFieldConfirmPsswrdRstPsswrdPg);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonResetPasswordlRstPsswrdPg")]
        public ResetYourPassword ClickButtonResetPasswordlRstPsswrdPg()
        {
            Button.Click(ButtonResetPasswordlRstPsswrdPg);

            return this;
        }

        [AllureStep("ClickButtonBackToLogInPageRstPsswrdPg")]
        public ResetYourPassword ClickButtonBackToLogInPageRstPsswrdPg()
        {
            Button.Click(ButtonBackToLogInPageRstPsswrdPg);

            return this;
        }
    }
}