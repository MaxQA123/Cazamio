using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.AddApartmentsPage
{
    public partial class AddApartments
    {
        #region Tad units

        [AllureStep("GetBuildingName")]
        public string GetBuildingName()
        {
            WaitUntil.CustomElementIsVisible(ButtonBuildingNameAddApartmentsUnitsPage);
            WaitUntil.CustomElementIsClickable(ButtonBuildingNameAddApartmentsUnitsPage);
            Button.Click(ButtonBuildingNameAddApartmentsUnitsPage);
            WaitUntil.CustomElementIsVisible(ButtonBuildingNameAddApartmentsUnitsPage);
            string getBuildingName = GetValueFromFieldBuildingName.Text;
            string getBuildingNameActual = getBuildingName.ToString();
            KeyBoardActions.ClickEnterButton();

            return getBuildingNameActual;

        }

        [AllureStep("EnterToAllFieldsMarkAdmAssignedBrkr")]
        public AddApartments EnterToAllFieldsMarkAdmAssignedBrkr()
        {
            WaitUntil.CustomElementIsVisible(FieldInputUnitNumber);
            InputGeneral.InputFunctionWithClear(FieldInputUnitNumber, apartment.UnitNumber.UnitNumberMarkAdmAssignedRoleBrkr);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBedrooms, apartment.Bedrooms.OneNumber);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputHalfBedrooms, apartment.HalfBedrooms.OneNumber);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBathrooms, apartment.Bathrooms.OneNumber);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputHalfBathrooms, apartment.HalfBathrooms.OneNumber);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputSqFoot, apartment.SqFoot.OneNumber);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeasePrice, apartment.LeasePrice.OneNumber);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputSecurityDeposit, apartment.SecurityDeposit.OneNumber);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthlyRentsPrePayment, apartment.MonthlyRentsPrePayment.OneNumber);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputFloor, apartment.Floor.OneNumber);


            return this;
        }

        [AllureStep("SelectStatusOffMarket")]
        public AddApartments SelectStatusOffMarket()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentStatus);
            WaitUntil.CustomElementIsClickable(ButtonApartmentStatus);
            Button.Click(ButtonApartmentStatus);
            WaitUntil.CustomElementIsVisible(ItemOffMarket);
            WaitUntil.CustomElementIsClickable(ItemOffMarket);
            Button.Click(ItemOffMarket);

            return this;
        }

        [AllureStep("SelectStatusOccupied")]
        public AddApartments SelectStatusOccupied()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentStatus);
            WaitUntil.CustomElementIsClickable(ButtonApartmentStatus);
            Button.Click(ButtonApartmentStatus);
            WaitUntil.CustomElementIsVisible(ItemOccupied);
            WaitUntil.CustomElementIsClickable(ItemOccupied);
            Button.Click(ItemOccupied);

            return this;
        }

        [AllureStep("SelectStatusVacant")]
        public AddApartments SelectStatusVacant()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentStatus);
            WaitUntil.CustomElementIsClickable(ButtonApartmentStatus);
            Button.Click(ButtonApartmentStatus);
            WaitUntil.CustomElementIsVisible(ItemVacant);
            WaitUntil.CustomElementIsClickable(ItemVacant);
            Button.Click(ItemVacant);

            return this;
        }

        [AllureStep("SelectStatusDepositReceived")]
        public AddApartments SelectStatusDepositReceived()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentStatus);
            WaitUntil.CustomElementIsClickable(ButtonApartmentStatus);
            Button.Click(ButtonApartmentStatus);
            WaitUntil.CustomElementIsVisible(ItemDepositReceived);
            WaitUntil.CustomElementIsClickable(ItemDepositReceived);
            Button.Click(ItemDepositReceived);

            return this;
        }

        [AllureStep("SelectStatusApplicationSubmitted")]
        public AddApartments SelectStatusApplicationSubmitted()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentStatus);
            WaitUntil.CustomElementIsClickable(ButtonApartmentStatus);
            Button.Click(ButtonApartmentStatus);
            WaitUntil.CustomElementIsVisible(ItemApplicationSubmitted);
            WaitUntil.CustomElementIsClickable(ItemApplicationSubmitted);
            Button.Click(ItemApplicationSubmitted);

            return this;
        }

        [AllureStep("SelectStatusSignedLease")]
        public AddApartments SelectStatusSignedLease()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentStatus);
            WaitUntil.CustomElementIsClickable(ButtonApartmentStatus);
            Button.Click(ButtonApartmentStatus);
            WaitUntil.CustomElementIsVisible(ItemSignedLease);
            WaitUntil.CustomElementIsClickable(ItemSignedLease);
            Button.Click(ItemSignedLease);

            return this;
        }

        [AllureStep("SelectAgentAddAprtmntsUnitsPage")]
        public AddApartments SelectAgentAddAprtmntsUnitsPage()
        {
            WaitUntil.CustomElementIsVisible(ButtonAssignedAgent);
            Button.Click(ButtonAssignedAgent);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();

            return this;
        }

        [AllureStep("SelectAgent")]
        public AddApartments SelectAgent()
        {
            WaitUntil.CustomElementIsVisible(ButtonAssignedAgent);
            WaitUntil.CustomElementIsClickable(ButtonAssignedAgent);
            Button.Click(ButtonAssignedAgent);
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(SetItemAgent());

            return this;
        }

        [AllureStep("SelectCurrentDateAvailableFrom")]
        public AddApartments SelectCurrentDateAvailableFrom()
        {
            WaitUntil.CustomElementIsVisible(FieldInputAvailableFrom);
            Button.Click(FieldInputAvailableFrom);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectCurrentDay();

            return this;
        }

        [AllureStep("SelectApartmentTypeMultiFamily")]
        public AddApartments SelectApartmentTypeMultiFamily()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentType);
            Button.Click(ButtonApartmentType);
            WaitUntil.CustomElementIsVisible(ItemMultiFamily);
            WaitUntil.CustomElementIsClickable(ItemMultiFamily);
            Button.Click(ItemMultiFamily);

            return this;
        }

        #endregion
    }
}
