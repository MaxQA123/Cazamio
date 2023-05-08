using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ModalWindowCreateNewBrokerPage
{
    public partial class ModalWindowCreateNewBroker
    {
        [AllureStep("EnterFirstLastNamesEmail")]
        public ModalWindowCreateNewBroker EnterFirstLastNamesEmail()
        {
            InputGeneral.InputFunctionWithClear(InputFieldFirstName, Name.FirstName());
            InputGeneral.InputFunctionWithClear(InputFieldLastName, Name.LastName());
            InputGeneral.InputFunctionWithClear(InputFieldEmail, GenerateRandomDataHelper.RandomEmail(5) + GenerateRandomDataHelper.RandomNumber(3) + GenerateRandomDataHelper.RandomEmail(2) + NameDomen.PUTS_BOX);

            return this;
        }

        [AllureStep("ClickButtonCreateMdlWndwCrtNwBrkr")]
        public ModalWindowCreateNewBroker ClickButtonCreateMdlWndwCrtNwBrkr()
        {
            Button.Click(ButtonCreate);

            return this;
        }
    }
}
