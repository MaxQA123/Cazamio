using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.GeneralPages.SignUpCazamioTenantPage
{
    public partial class SignUpCazamioTenant
    {
        [AllureStep("EnterFirstLastNameEmailPasswordSignUpPg")]
        public SignUpCazamioTenant EnterFirstLastNameEmailPasswordSignUpPg()
        {
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputFirstNameSignUpPg, Name.FirstName());
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputLastNameSignUpPg, Name.LastName());
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputEmailSignUpPg, GenerateRandomDataHelper.RandomEmail(5) + NameDomen.Xitroo);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordSignUpPg, GeneralTestDataForAllUsers.passwordGeneral);

            return this;
        }

        [AllureStep("ClickIconShowSignUpPg")]
        public SignUpCazamioTenant ClickIconShowSignUpPg()
        {
            Button.Click(IconShowSignUpPg);

            return this;
        }

        [AllureStep("ClickButtonGetStartedSignUpPg")]
        public SignUpCazamioTenant ClickButtonGetStartedSignUpPg()
        {
            Button.Click(ButtonGetStartedSignUpPg);

            return this;
        }
    }
}
