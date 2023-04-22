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
            InputGeneral.InputFunctionWithClear(FieldInputOwnerName, Name.FirstName());

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

        [AllureStep("ClickButtonAddPhoneNumber")]
        public ModalWndwCreateNewOwner ClickButtonAddPhoneNumber()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonAddPhoneNumber);

            return this;
        }

        [AllureStep("EnterPhoneExtensionNumbers")]
        public ModalWndwCreateNewOwner EnterPhoneExtensionNumbers()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPhoneNumber, GeneralTestDataForAllUsers.CODE_PHONE_NUMBER_ONE + GenerateRandomDataHelper.RandomPhoneNumber(7));
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputExtensionNumber, GeneralTestDataForAllUsers.CODE_PHONE_NUMBER_TWO + GenerateRandomDataHelper.RandomPhoneNumber(7));

            return this;
        }

        [AllureStep("ClickButtonAddCommissionStructure")]
        public ModalWndwCreateNewOwner ClickButtonAddCommissionStructure()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonAddCommissionStructure);

            return this;
        }

        [AllureStep("ClickButtonPayType")]
        public ModalWndwCreateNewOwner ClickButtonPayType()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonPayType);

            return this;
        }

        [AllureStep("SelectItemOwnerAndTenantPays")]
        public ModalWndwCreateNewOwner SelectItemOwnerAndTenantPays()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemOwnerAndTenantPays);

            return this;
        }

        [AllureStep("SelectItemTenantPays")]
        public ModalWndwCreateNewOwner SelectItemTenantPays()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemTenantPays);

            return this;
        }

        [AllureStep("SelectItemOwnerPays")]
        public ModalWndwCreateNewOwner SelectItemOwnerPays()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemOwnerPays);

            return this;
        }

        [AllureStep("SwitchingItemsPays")]
        public ModalWndwCreateNewOwner SwitchingItemsPays()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonPayType);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemOwnerAndTenantPays);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonPayType);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemTenantPays);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonPayType);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemOwnerPays);

            return this;
        }

        [AllureStep("EnterDataOwnerAndTenantPays")]
        public ModalWndwCreateNewOwner EnterDataOwnerAndTenantPays()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOwnerNumberOfMonths, GenerateRandomDataHelper.RandomNumber(1));
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputTenantNumberOfMonths, GenerateRandomDataHelper.RandomNumber(1));
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOwnerPercentage, GenerateRandomDataHelper.RandomNumber(2));
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputTenantPercentage, GenerateRandomDataHelper.RandomNumber(2));
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputTakeOff, GenerateRandomDataHelper.RandomNumber(2));

            return this;
        }

        [AllureStep("ClickButtonAddMgmt")]
        public ModalWndwCreateNewOwner ClickButtonAddMgmt()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonAddMgmt);

            return this;
        }

        [AllureStep("ScrollDown")]
        public ModalWndwCreateNewOwner ScrollDown()
        {
            WaitUntil.WaitSomeInterval(100);
            ScrollingJScriptExecutorHelper.ScrollToElement(ButtonAddMgmt);

            return this;
        }

        [AllureStep("EnterDataMgmt")]
        public ModalWndwCreateNewOwner EnterDataMgmt()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMgmtName, Name.FirstName() + Name.LastName());
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMgmtEmail, GenerateRandomDataHelper.RandomEmail(5) + GenerateRandomDataHelper.RandomNumber(3) + GenerateRandomDataHelper.RandomEmail(2) + NameDomen.XITROO);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPhoneNumberMgmt, GeneralTestDataForAllUsers.CODE_PHONE_NUMBER_ONE + GenerateRandomDataHelper.RandomPhoneNumber(7));
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMgmtExtensionNumber, GeneralTestDataForAllUsers.CODE_PHONE_NUMBER_TWO + GenerateRandomDataHelper.RandomPhoneNumber(7));
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMgmtOfficeLocation, Address.City());

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
