using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.NewBuildingPage
{
    public partial class NewBuilding
    {
        [AllureStep("EnterFullAddressNewBuildingAssgndRlBrkr")]
        public NewBuilding EnterFullAddressNewBuildingAssgndRlBrkr()
        {
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputAddressNwBldngPg, building.NumberWithAddressRoleBrkr);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputCityNwBldngPg, building.City.CityNewYork);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputStateNwBldngPg, building.State);
            WaitUntil.WaitSomeInterval(1000);
            InputGeneral.InputFunctionWithClear(FieldInputZipNwBldngPg, building.Zip.ZipBuildingAssignedRoleBrkr);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputNeighborhoodNwBldngPg, building.Neighborhood.BuildingAssignedRoleBrkr);

            return this;
        }

        [AllureStep("EnterLongInternalNotesDescription")]
        public NewBuilding EnterLongInternalNotesDescription()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputDescroptionNwBldngPg, building.DescriptionLong);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputInternalNotesNwBldngPg, building.InternalNotesLong);

            return this;
        }

        [AllureStep("EnterCreditScreeningFeeHoldDeposit")]
        public NewBuilding EnterCreditScreeningFeeHoldDeposit()
        {
            WaitUntil.CustomElementIsVisible(FieldInputCreditScreeningFee);
            WaitUntil.CustomElementIsClickable(FieldInputCreditScreeningFee);
            InputGeneral.InputFunctionWithClearDemo(FieldInputCreditScreeningFee, building.CreditScreeningFee.ForEntering);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputHoldDeposit, building.HoldDeposit);

            return this;
        }

        [AllureStep("SelectOwnerWithBroker")]
        public NewBuilding SelectOwnerWithBroker()
        {
            Button.Click(ButtonMenuOwnerSelect);
            WaitUntil.WaitSomeInterval(500);
            Button.Click(SetItemForAutotestForBroker());

            return this;
        }

        [AllureStep("SelectPaymentsMethodsNwBldngPage")]
        public NewBuilding SelectPaymentsMethodsNwBldngPage()
        {
            Button.Click(ButtonSelectPaymentsMethodsNwBldngPg);
            Pages.ModalWindowPaymentOptions
                .VerifyTitlePaymentOptionsMdlWndwOptns();
            Pages.ModalWindowPaymentOptions
                .SelectPaymentsMethodsNwBldngPg();
            WaitUntil.WaitSomeInterval(3000);

            return this;
        }
    }
}
