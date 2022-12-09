using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteCazamioTenantPages.ForgotPasswordPage
{
    public partial class ForgotPassword
    {
        [AllureStep("EnterEmailOnFrgtPsswrdPg")]
        public ForgotPassword EnterEmailOnFrgtPsswrdPg()
        {
            InputGeneral.InputFunctionWithClear(InputFieldEmailFrgtPsswrdPg, TestDataForWebSiteTenant.EMAIL_CURRENT_OCCUPANT_ONE);

            return this;
        }

        [AllureStep("EnterEmailOnFrgtPsswrdPg")]
        public ForgotPassword ClickButtonSendRecoveryLinkFrgtPsswrdPg()
        {
            Button.Click(ButtonSendRecoveryLinkFrgtPsswrdPg);

            return this;
        }
    }
}
