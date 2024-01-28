using CazamioProgect.Helpers;
using CazamioProject.Objects;
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
        TenantApplicant tenantApplicant = new TenantApplicant().Generate();

        [AllureStep("EnterEmailOnFrgtPsswrdPg")]
        public ForgotPassword EnterEmailOnFrgtPsswrdPg()
        {
            InputGeneral.InputFunctionWithClear(InputFieldEmailFrgtPsswrdPg, tenantApplicant.EmailAddressTenant);

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
