using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteCazamioTenantPages.CreateNewPasswordPage
{
    public partial class CreateNewPassword
    {
        [AllureStep("EnterInputFieldPassswordCreateNewPsswrdPg")]
        public CreateNewPassword EnterInputFieldPassswordCreateNewPsswrdPg()
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[3]);

            WaitUntil.WaitSomeInterval(1000);
            InputGeneral.InputFunctionWithClear(InputFieldPassswordCreateNewPsswrdPg, GeneralTestDataForAllUsers.PASSWORD_NEW_GENEREAL);

            return this;
        }

        [AllureStep("ClickIconShowCreateNewPsswrdPg")]
        public CreateNewPassword ClickIconShowCreateNewPsswrdPg()
        {
            Button.Click(IconShowCreateNewPsswrdPg);

            return this;
        }

        [AllureStep("ClickButtonSaveMyPasswordCreateNewPsswrdPg")]
        public CreateNewPassword ClickButtonSaveMyPasswordCreateNewPsswrdPg()
        {
            Button.Click(ButtonSaveMyPasswordCreateNewPsswrdPg);

            return this;
        }
    }
}
