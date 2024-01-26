using CazamioProgect.Helpers;
using CazamioProject.Objects;
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
        Owner owner = new Owner().Generate();

        [AllureStep("EnterCompanyNameForAgentRole")]
        public ModalWndwCreateNewOwner EnterCompanyNameForAgentRole()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCompanyName, owner.CompanyNameWithAgent);

            return this;
        }

        [AllureStep("EnterCompanyNameForBrokerRole")]
        public ModalWndwCreateNewOwner EnterCompanyNameForBrokerRole()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCompanyName, owner.CompanyNameWithBroker);

            return this;
        }

        [AllureStep("EnterOwnerName")]
        public ModalWndwCreateNewOwner EnterOwnerName()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOwnerName, owner.FullName);

            return this;
        }

        [AllureStep("EnterOwnerEmaiL")]
        public ModalWndwCreateNewOwner EnterOwnerEmaiL()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOwnerEmail, owner.EmailAddress);

            return this;
        }

        [AllureStep("EnterOfficeLocation")]
        public ModalWndwCreateNewOwner EnterOfficeLocation()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOfficeLocation, owner.OfficeLocation);

            return this;
        }

        [AllureStep("SelectBroker")]
        public ModalWndwCreateNewOwner SelectBroker()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSelectUser);
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickEnterButton();

            return this;
        }

        [AllureStep("SelectAgent")]
        public ModalWndwCreateNewOwner SelectAgent()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSelectUser);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemAgentUser);

            return this;
        }

        [AllureStep("EnterInternalNotes")]
        public ModalWndwCreateNewOwner EnterInternalNotes()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputInternalNotes, owner.InternalNotes);

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
            InputGeneral.InputFunctionWithClear(FieldInputPhoneNumber, owner.PhoneNumber);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputExtensionNumber, owner.ExtensionNumber);

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
            InputGeneral.InputFunctionWithClear(FieldInputOwnerNumberOfMonths, owner.OwnerNumberOfMonths);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputTenantNumberOfMonths, owner.TenantNumberOfMonths);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOwnerPercentage, owner.OwnerPercentage);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputTenantPercentage, owner.TenantPercentage);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputTakeOff, owner.TakeOff);

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
            InputGeneral.InputFunctionWithClear(FieldInputMgmtName, owner.FullName);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMgmtEmail, owner.EmailAddress);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPhoneNumberMgmt, owner.PhoneNumber);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMgmtExtensionNumber, owner.ExtensionNumber);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMgmtOfficeLocation, owner.OfficeLocation);

            return this;
        }

        [AllureStep("ClickButtonCreate")]
        public ModalWndwCreateNewOwner ClickButtonCreate()
        {
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonCreate);

            return this;
        }
    }
}
