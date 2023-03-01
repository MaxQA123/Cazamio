using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.ModalWndwCreateNewOwner
{
    public partial class ModalWndwCreateNewOwner
    {
        [AllureStep("EnterCompanyName")]
        public ModalWndwCreateNewOwner EnterCompanyName()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCompanyName, Company.Name());

            return this;
        }

        [AllureStep("EnterOwnerName")]
        public ModalWndwCreateNewOwner EnterOwnerName()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOwnerName, Name.FullName());

            return this;
        }

        [AllureStep("EnterOwnerEmaiL")]
        public ModalWndwCreateNewOwner EnterOwnerEmaiL()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOwnerEmail, GenerateRandomDataHelper.RandomEmail(5) + GenerateRandomDataHelper.RandomNumber(3) + GenerateRandomDataHelper.RandomEmail(2) + NameDomen.PUTS_BOX);

            return this;
        }

        [AllureStep("EnterOfficeLocation")]
        public ModalWndwCreateNewOwner EnterOfficeLocation()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOfficeLocation, Address.City());

            return this;
        }

        [AllureStep("EnterInternalNotes")]
        public ModalWndwCreateNewOwner EnterInternalNotes()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputInternalNotes, Lorem.Sentence());

            return this;
        }

        [AllureStep("ClickButtonCreate")]
        public ModalWndwCreateNewOwner ClickButtonCreate()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonCreate);

            return this;
        }
    }
}
