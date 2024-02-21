using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.NewBuildingPage
{
    public partial class NewBuilding
    {
        [AllureStep("EnterFullAddress")]
        public NewBuilding EnterFullAddress()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputAddress, building.NumberWithAddressRoleBrkr);
            WaitUntil.WaitSomeInterval(500);
            KeyBoardActions.ClickTab();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCity, building.City.NewYork);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputState, building.State);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputZip, building.Zip.ZipBuildingAssignedRoleBrkr);
            WaitUntil.WaitSomeInterval(500);
            KeyBoardActions.ClickArrowDown();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputNeighborhood, building.Neighborhood.BuildingAssignedRoleBrkr);

            return this;
        }

        [AllureStep("EnterAddressCityState")]
        public NewBuilding EnterAddressCityState()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputAddress, building.NumberWithAddressRoleAgent);
            WaitUntil.WaitSomeInterval(500);
            KeyBoardActions.ClickTab();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCity, building.City.Brooklyn);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputState, building.State);
            WaitUntil.WaitSomeInterval(100);

            return this;
        }

        [AllureStep("EnterLongInternalNotesDescription")]
        public NewBuilding EnterLongInternalNotesDescription()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputDescroption, building.DescriptionLong);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputInternalNotes, building.InternalNotesLong);

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

        [AllureStep("SelectOwnerWithAgent")]
        public NewBuilding SelectOwnerWithAgent()
        {
            Button.Click(ButtonMenuOwnerSelect);
            WaitUntil.WaitSomeInterval(500);
            Button.Click(SetItemForAutotestForAgentBroker());

            return this;
        }

        [AllureStep("AddItemAccessTypePinCode")]
        public NewBuilding AddItemAccessTypePinCode()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(ButtonAccessType);
            Button.Click(ButtonAccessType);
            Button.Click(ItemPinCode);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPinCodeForFirstEnter, GenerateRandomDataHelper.RandomNumberWithoutZero(1));
            KeyBoardActions.ClickSpaceButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithoutClear(FieldInputPinCodeForNextEnter, GenerateRandomDataHelper.RandomNumberWithoutZero(1));
            KeyBoardActions.ClickSpaceButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithoutClear(FieldInputPinCodeForNextEnter, GenerateRandomDataHelper.RandomNumberWithoutZero(1));
            KeyBoardActions.ClickSpaceButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithoutClear(FieldInputPinCodeForNextEnter, GenerateRandomDataHelper.RandomNumberWithoutZero(1));
            KeyBoardActions.ClickSpaceButton();
            InputGeneral.InputFunctionWithClear(FieldInputCustomNoteForAccess, building.TextLorem.TextLoremForPinCode);
            WaitUntil.WaitSomeInterval(100);
            ButtonSelectImageForAccess.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_BUILDING_LOCK_PIN_CODE));
            WaitUntil.SuccessCustomElementIsVisible(MessageSuccessUploadImageForAccess);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveForLock);

            return this;
        }

        [AllureStep("AddItemAccessTypeNote")]
        public NewBuilding AddItemAccessTypeNote()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(ButtonAccessType);
            Button.Click(ButtonAccessType);
            Button.Click(ItemNote);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCustomNoteForAccess, building.TextLorem.TextLoremForNote);
            WaitUntil.WaitSomeInterval(100);
            ButtonSelectImageForAccess.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_BUILDING_LOCK_NOTE));
            WaitUntil.SuccessCustomElementIsVisible(MessageSuccessUploadImageForAccess);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveForLock);

            return this;
        }

        [AllureStep("AddConcessionIsActive")]
        public NewBuilding AddConcessionIsActive()
        {
            WaitUntil.CustomElementIsVisible(FieldInputNameSpecials);
            WaitUntil.CustomElementIsClickable(FieldInputNameSpecials);
            InputGeneral.InputFunctionWithClear(FieldInputNameSpecials, building.Concessions.Name);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthsFree, building.Concessions.MonthsFree);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeaseTerms, building.Concessions.LeaseTerms);
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonYesSpecials);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputDateFrom);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectCurrentDay();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputDateTo);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectCurrentDayPlusOneDay();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveSpecials);

            return this;
        }

        [AllureStep("AddFreeStuffIsActive")]
        public NewBuilding AddFreeStuffIsActive()
        {
            WaitUntil.CustomElementIsVisible(FieldInputNameSpecials);
            WaitUntil.CustomElementIsClickable(FieldInputNameSpecials);
            InputGeneral.InputFunctionWithClear(FieldInputNameSpecials, building.FreeStuff.Name);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputSelectItemsFreeStuff);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemFreeNetflix);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemGoogleSpeaker);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonYesSpecials);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputDateFrom);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectCurrentDay();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputDateTo);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectCurrentDayPlusOneDay();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ScrollToDown();
            Button.Click(ButtonLeaseSignedTriggerEvent);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveSpecials);

            return this;
        }

        [AllureStep("SelectFiveAmenities")]
        public NewBuilding SelectFiveAmenities()
        {
            WaitUntil.WaitSomeInterval(500);
            Pages.NewBuilding
            .SelectAmenitiesForBuilding(ListOfAmenitiesForBuildingAdminsPage.FIRST_TAG, " ")
            .SelectAmenitiesForBuilding(ListOfAmenitiesForBuildingAdminsPage.FIRST_TAG, " ")
            .SelectAmenitiesForBuilding(ListOfAmenitiesForBuildingAdminsPage.FIRST_TAG, " ")
            .SelectAmenitiesForBuilding(ListOfAmenitiesForBuildingAdminsPage.FIRST_TAG, " ")
            .SelectAmenitiesForBuilding(ListOfAmenitiesForBuildingAdminsPage.FIRST_TAG, " ");

            return this;
        }
    }
}
