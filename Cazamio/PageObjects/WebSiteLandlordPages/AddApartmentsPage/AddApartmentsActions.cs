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
        [AllureStep("EnterUnitNumberBedsBathsSqFoot")]
        public AddApartments EnterUnitNumberBedsBathsSqFoot()
        {
            WaitUntil.CustomElementIsVisible(FieldInputUnitNumberAddAprtmntsUnitsPage, 10);
            InputGeneral.InputFunctionWithClear(FieldInputUnitNumberAddAprtmntsUnitsPage, TestDataForWebSiteAdmin.UNIT_NUMBER);
            
            WaitUntil.CustomElementIsVisible(FieldInputBedroomsAddAprtmntsUnitsPage, 10);
            InputGeneral.InputFunctionWithClear(FieldInputBedroomsAddAprtmntsUnitsPage, GenerateRandomDataHelper.RandomNumber(1));
            
            WaitUntil.CustomElementIsVisible(FieldInputHalfBedroomsAddAprtmntsUnitsPage, 10);
            InputGeneral.InputFunctionWithClear(FieldInputHalfBedroomsAddAprtmntsUnitsPage, TestDataForWebSiteAdmin.HALF_BEDS_BATHS_NUMBER);
            
            WaitUntil.CustomElementIsVisible(FieldInputBathroomsAddAprtmntsUnitsPage, 10);
            InputGeneral.InputFunctionWithClear(FieldInputBathroomsAddAprtmntsUnitsPage, GenerateRandomDataHelper.RandomNumber(1));
            
            WaitUntil.CustomElementIsVisible(FieldInputHalfBathroomsAddAprtmntsUnitsPage, 10);
            InputGeneral.InputFunctionWithClear(FieldInputHalfBathroomsAddAprtmntsUnitsPage, TestDataForWebSiteAdmin.HALF_BEDS_BATHS_NUMBER);
            
            WaitUntil.CustomElementIsVisible(FieldInputSqFootAddAprtmntsUnitsPage, 10);
            InputGeneral.InputFunctionWithClear(FieldInputSqFootAddAprtmntsUnitsPage, GenerateRandomDataHelper.RandomNumber(3));

            return this;
        }

        [AllureStep("EnterUnitNumberBedsBathsSqFoot")]
        public AddApartments EnterLeasePriceSecurityDeposit()
        //SecurityDeposit autofill
        {
            WaitUntil.CustomElementIsVisible(FieldInputLeasePriceAddAprtmntsUnitsPage, 10);
            InputGeneral.InputFunctionWithClear(FieldInputLeasePriceAddAprtmntsUnitsPage, GenerateRandomDataHelper.RandomNumber(4));

            return this;
        }

        [AllureStep("EnterFieldInputFloorAddAprtmntsUnitsPage")]
        public AddApartments EnterFieldInputFloorAddAprtmntsUnitsPage()
        {
            WaitUntil.CustomElementIsVisible(FieldInputFloorAddAprtmntsUnitsPage, 10);
            InputGeneral.InputFunctionWithClear(FieldInputFloorAddAprtmntsUnitsPage, GenerateRandomDataHelper.RandomNumber(2));

            return this;
        }

        [AllureStep("SelectStatusVacantAddAprtmntsUnitsPage")]
        public AddApartments SelectStatusVacantAddAprtmntsUnitsPage()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentStatusAddAprtmntsUnitsPage, 10);
            Button.Click(ButtonApartmentStatusAddAprtmntsUnitsPage);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();

            return this;
        }

        [AllureStep("SelectAgentAddAprtmntsUnitsPage")]
        public AddApartments SelectAgentAddAprtmntsUnitsPage()
        {
            WaitUntil.CustomElementIsVisible(ButtonAssignedAgentAddAprtmntsUnitsPage, 10);
            Button.Click(ButtonAssignedAgentAddAprtmntsUnitsPage);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();

            return this;
        }

        [AllureStep("SelectDateAvailableFromAprtmntsUnitsPage")]
        public AddApartments SelectDateAvailableFromAprtmntsUnitsPage()
        {
            WaitUntil.CustomElementIsVisible(FieldInputAvailableFromAddAprtmntsUnitsPage, 10);
            Button.Click(FieldInputAvailableFromAddAprtmntsUnitsPage);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectDayOnDatePickerSecondLine(DaysThirdLineForDatePiker.THIRD_LINE_FIRST_NUMBER, " ");

            return this;
        }

        [AllureStep("ClickButtonPaymentMethodsAddAprtmntsUnitsPage")]
        public AddApartments ClickButtonPaymentMethodsAddAprtmntsUnitsPage()
        {
            WaitUntil.CustomElementIsVisible(ButtonPaymentMethodsAddAprtmntsUnitsPage, 10);
            Button.Click(ButtonPaymentMethodsAddAprtmntsUnitsPage);
            
            return this;
        }

        [AllureStep("EnterDescriptionInternalNotesAddAprtmntsUnitsPage")]
        public AddApartments EnterDescriptionInternalNotesAddAprtmntsUnitsPage()
        {
            WaitUntil.CustomElementIsVisible(FieldInputDescriptionAddAprtmntsUnitsPage, 10);
            InputGeneral.InputFunctionWithClear(FieldInputDescriptionAddAprtmntsUnitsPage, GeneralTestDataForAllUsers.TEXT_DESCRIPTION_FOR_APARTMENT + GeneralTestDataForAllUsers.TEXT_LOREM);
            WaitUntil.CustomElementIsVisible(FieldInputInternalNotesAddAprtmntsUnitsPage, 10);
            InputGeneral.InputFunctionWithClear(FieldInputInternalNotesAddAprtmntsUnitsPage, GeneralTestDataForAllUsers.TEXT_INTERNAL_NOTES_FOR_APARTMENT + GeneralTestDataForAllUsers.TEXT_LOREM);

            return this;
        }

        [AllureStep("ClickButtonGeneralNextAddAprtmntsgPg")]
        public AddApartments ClickButtonGeneralNextAddAprtmntsgPg()
        {
            WaitUntil.CustomElementIsVisible(ButtonGeneralNextAddAprtmntsgPg, 10);
            Button.Click(ButtonGeneralNextAddAprtmntsgPg);

            return this;
        }
    }
}
