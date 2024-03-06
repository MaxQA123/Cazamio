using CazamioProgect.Helpers;
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

        [AllureStep("SelectStatusVacant")]
        public AddApartments SelectStatusVacant()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentStatus);
            WaitUntil.CustomElementIsClickable(ButtonApartmentStatus);
            Button.Click(ButtonApartmentStatus);
            WaitUntil.CustomElementIsVisible(ButtonApartmentStatus);
            WaitUntil.CustomElementIsClickable(ButtonApartmentStatus);
            Button.Click(ItemOffMarket);
            //KeyBoardActions.ClickArrowDown();
            //KeyBoardActions.ClickArrowDown();
            //KeyBoardActions.ClickEnterButton();

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

        #endregion
    }
}
