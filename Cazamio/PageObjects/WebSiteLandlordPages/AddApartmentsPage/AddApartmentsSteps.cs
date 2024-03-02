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

        [AllureStep("EnterUnitNumberBedsBathsSqFoot")]
        public AddApartments EnterUnitNumberBedsBathsSqFoot()
        {
            WaitUntil.CustomElementIsVisible(FieldInputUnitNumberAddAprtmntsUnitsPage, 10);
            InputGeneral.InputFunctionWithClear(FieldInputUnitNumberAddAprtmntsUnitsPage, TestDataForWebSiteAdmin.UNIT_NUMBER);

            WaitUntil.CustomElementIsVisible(FieldInputBedroomsAddAprtmntsUnitsPage, 10);
            InputGeneral.InputFunctionWithClear(FieldInputBedroomsAddAprtmntsUnitsPage, GenerateRandomDataHelper.RandomNumberWithoutZero(1));

            WaitUntil.CustomElementIsVisible(FieldInputHalfBedroomsAddAprtmntsUnitsPage, 10);
            InputGeneral.InputFunctionWithClear(FieldInputHalfBedroomsAddAprtmntsUnitsPage, TestDataForWebSiteAdmin.HALF_BEDS_BATHS_NUMBER);

            WaitUntil.CustomElementIsVisible(FieldInputBathroomsAddAprtmntsUnitsPage, 10);
            InputGeneral.InputFunctionWithClear(FieldInputBathroomsAddAprtmntsUnitsPage, GenerateRandomDataHelper.RandomNumberWithoutZero(1));

            WaitUntil.CustomElementIsVisible(FieldInputHalfBathroomsAddAprtmntsUnitsPage, 10);
            InputGeneral.InputFunctionWithClear(FieldInputHalfBathroomsAddAprtmntsUnitsPage, TestDataForWebSiteAdmin.HALF_BEDS_BATHS_NUMBER);

            WaitUntil.CustomElementIsVisible(FieldInputSqFootAddAprtmntsUnitsPage, 10);
            InputGeneral.InputFunctionWithClear(FieldInputSqFootAddAprtmntsUnitsPage, GenerateRandomDataHelper.RandomNumberWithoutZero(3));

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

        #endregion
    }
}
