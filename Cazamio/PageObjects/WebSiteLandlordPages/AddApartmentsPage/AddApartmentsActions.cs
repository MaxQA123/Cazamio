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
    }
}
