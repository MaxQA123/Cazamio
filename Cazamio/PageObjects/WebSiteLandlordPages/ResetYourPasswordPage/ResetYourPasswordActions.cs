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
        [AllureStep("EnterEmailAgent")]
        public ResetYourPassword EnterEmailSuperAdmin()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailRstPsswrdPg, TestDataForWebSiteAdmin.EMAIL_SUPER_ADMIN);

            return this;
        }

        [AllureStep("EnterEmailAgent")]
        public ResetYourPassword EnterEmailAgent()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailRstPsswrdPg, TestDataForWebSiteAdmin.EMAIL_AGENT_MARIE_URMSTRONG);

            return this;
        }

        [AllureStep("EnterEmailBroker")]
        public ResetYourPassword EnterEmailBroker()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailRstPsswrdPg, TestDataForWebSiteAdmin.EMAIL_BROKER_ALA_DIN);

            return this;
        }

        [AllureStep("EnterEmailMarketplaceAdmin")]
        public ResetYourPassword EnterEmailMarketplaceAdmin()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailRstPsswrdPg, TestDataForWebSiteAdmin.EMAIL_MARKETPLACE_ADMIN_CHUI_CHUBAKA);

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
            Browser._Driver.SwitchTo().Window(tabsList[3]);
            InputGeneral.InputFunctionWithClear(FieldInputNewPasswordRstPsswrdPg, GeneralTestDataForAllUsers.PASSWORD_GENERAL);
            InputGeneral.InputFunctionWithClear(FieldInputConfirmPasswordRstPsswrdPg, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

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
            Button.Click(ButtonBackToLoginPageRstPsswrdPg);

            return this;
        }
    }
}
