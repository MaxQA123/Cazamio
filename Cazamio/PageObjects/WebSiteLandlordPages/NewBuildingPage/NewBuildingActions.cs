using CazamioProgect.Helpers;
using CazamioProject.Objects;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using RimuTec.Faker;
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
        private static IWebElement _tabsForSwitchingOnPage;

        Building building = new Building().Generate();
        Owner owner = new Owner().Generate();

        [AllureStep("SelectorTabsOnNewBuildingsPg")]
        public static IList <IWebElement> SelectorTabsOnNewBuildingsPg(string _locationTab)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@class = 'wizard-navigation']//ul[@class = 'nav nav-pills']";
            _tabsForSwitchingOnPage = Browser._Driver.FindElement(By.XPath(str));
            return _tabsForSwitchingOnPage.FindElements(By.XPath($"./li[contains(@class, 'nav-item')]"));
        }

        [AllureStep("SelectTabOnNewBuildingsPg")]
        public NewBuilding SelectTabOnNewBuildingsPg(int tab, string locationTab)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _tab = SelectorTabsOnNewBuildingsPg(locationTab);

            _tab.Where(x => x.Text== "Images").Select(x => x).FirstOrDefault().Click();

            return this;
        }

        #region NewBuilding the tab Basic Details

        [AllureStep("EnterBuildingName")]
        public NewBuilding EnterBuildingName()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBuildingName, building.BuildingName);
            
            return this;
        }

        [AllureStep("EnterLlcNameForBroker")]
        public NewBuilding EnterLlcNameForBroker()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLlcName, building.LlcName.ForBroker);

            return this;
        }

        [AllureStep("ClickButtonSelectPetPolicies")]
        public NewBuilding ClickButtonSelectPetPolicies()
        {
            Button.Click(ButtonSelectPetPolicies);

            return this;
        }

        [AllureStep("EnterCreditScreeningFee")]
        public NewBuilding EnterCreditScreeningFee()
        {
            WaitUntil.CustomElementIsVisible(FieldInputCreditScreeningFee);
            WaitUntil.CustomElementIsClickable(FieldInputCreditScreeningFee);
            InputGeneral.InputFunctionWithClear(FieldInputCreditScreeningFee, building.CreditScreeningFee.ForEntering);

            return this;
        }

        [AllureStep("EnterHoldDeposit")]
        public NewBuilding EnterHoldDeposit()
        {
            WaitUntil.CustomElementIsVisible(FieldInputHoldDeposit);
            WaitUntil.CustomElementIsClickable(FieldInputHoldDeposit);
            InputGeneral.InputFunctionWithClear(FieldInputHoldDeposit, building.HoldDeposit);

            return this;
        }

        [AllureStep("ClickBtnSelectPaymentMethodsForCreditScreeningFee")]
        public NewBuilding ClickBtnSelectPaymentMethodsForCreditScreeningFee()
        {
            WaitUntil.CustomElementIsVisible(BtnSelectPaymentMethodsForCreditScreeningFee);
            WaitUntil.CustomElementIsClickable(BtnSelectPaymentMethodsForCreditScreeningFee);
            Button.Click(BtnSelectPaymentMethodsForCreditScreeningFee);

            return this;
        }

        [AllureStep("ClickBtnSelectPaymentMethodsForHoldDeposit")]
        public NewBuilding ClickBtnSelectPaymentMethodsForHoldDeposit()
        {
            WaitUntil.CustomElementIsVisible(BtnSelectPaymentMethodsForHoldDeposit);
            WaitUntil.CustomElementIsClickable(BtnSelectPaymentMethodsForHoldDeposit);
            Button.Click(BtnSelectPaymentMethodsForHoldDeposit);

            return this;
        }

        [AllureStep("GetValueFromFieldCreditScreeningFee")]
        public string GetValueFromFieldCreditScreeningFee()
        {
            WaitUntil.CustomElementIsVisible(FieldInputCreditScreeningFee);
            string getValue = FieldInputCreditScreeningFee.GetAttribute("value");
            string getValueActual = getValue.ToString();

            return getValueActual;
        }

        //This hidden
        //[AllureStep("GetNameCabTypeAccessFromTable")]
        //public string GetNameCabTypeAccessFromTable()
        //{
        //    WaitUntil.CustomElementIsVisible(RecordCABInTableAccessNwBldngPg, 10);
        //    string getNameCab = (RecordCABInTableAccessNwBldngPg).Text;
        //    string nameCabActual = getNameCab.ToString();

        //    return nameCabActual;
        //}

        [AllureStep("GetNameNoteTypeAccessFromTable")]
        public string GetNameNoteTypeAccessFromTable()
        {
            WaitUntil.CustomElementIsVisible(RecordNoteInTableAccessNwBldngPg);
            string getNameNote = (RecordNoteInTableAccessNwBldngPg).Text;
            string nameNoteActual = getNameNote.ToString();

            return nameNoteActual;
        }

        [AllureStep("GetNamePinCodeTypeAccessFromTable")]
        public string GetNamePinCodeTypeAccessFromTable()
        {
            WaitUntil.CustomElementIsVisible(RecordPinCodeInTableAccessNwBldngPg, 10);
            string getNamePinCode = (RecordPinCodeInTableAccessNwBldngPg).Text;
            string namePinCodeActual = getNamePinCode.ToString();

            return namePinCodeActual;
        }

        [AllureStep("GetNameConcessionFromTable")]
        public string GetNameConcessionFromTable()
        {
            WaitUntil.CustomElementIsVisible(RecordNameInTableConcessionNwBldngPg, 10);
            string getNameConcession = (RecordNameInTableConcessionNwBldngPg).Text;
            string nameConcessionActual = getNameConcession.ToString();

            return nameConcessionActual;
        }

        [AllureStep("ClickButtonGeneralNextNwBldngPg")]
        public NewBuilding ClickButtonGeneralNextNwBldngPg()
        {
            WaitUntil.WaitSomeInterval(3000);
            //WaitUntil.CustomElementIsVisible(ButtonGeneralNextNwBldngPg, 10);
            Button.Click(ButtonGeneralNextNwBldngPg);

            return this;
        }

        [AllureStep("ClickBtnEditForPaymentSystem")]
        public NewBuilding ClickBtnEditForPaymentSystem()
        {
            WaitUntil.CustomElementIsVisible(BtnEditForPaymentSystem);
            Button.Click(BtnEditForPaymentSystem);

            return this;
        }

        #endregion

        #region Tabs

        [AllureStep("ClickTabAmenities")]
        public NewBuilding ClickTabAmenities()
        {
            WaitUntil.CustomElementIsVisible(TabAmenities);
            WaitUntil.CustomElementIsClickable(TabAmenities);
            Button.Click(TabAmenities);

            return this;
        }

        [AllureStep("ClickTabAccess")]
        public NewBuilding ClickTabAccess()
        {
            WaitUntil.CustomElementIsVisible(TabAccess);
            WaitUntil.CustomElementIsClickable(TabAccess);
            Button.Click(TabAccess);

            return this;
        }

        [AllureStep("ClickTabSpecials")]
        public NewBuilding ClickTabSpecials()
        {
            WaitUntil.CustomElementIsVisible(TabSpecials);
            WaitUntil.CustomElementIsClickable(TabSpecials);
            Button.Click(TabSpecials);

            return this;
        }

        #endregion

        #region Amenities

        [AllureStep("ClickFieldInputSearchForAmenities")]
        public NewBuilding ClickFieldInputSearchForAmenitiesg()
        {
            WaitUntil.CustomElementIsInVisible(FieldInputSearchForAmenitiesNwBldngPg);
            WaitUntil.CustomElementIsClickable(FieldInputSearchForAmenitiesNwBldngPg);
            Button.Click(FieldInputSearchForAmenitiesNwBldngPg);

            return this;
        }

        private static IWebElement _elementAmenitiesForBuilding;

        [AllureStep("SelectorAmenitiesForBuilding")]
        public static IList<IWebElement> SelectorAmenitiesForBuilding(string _itemAmenity)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@class = 'search-choice-wrapper']";
            _elementAmenitiesForBuilding = Browser._Driver.FindElement(By.XPath(str));
            return _elementAmenitiesForBuilding.FindElements(By.XPath($".//div[contains(text(), '{_itemAmenity}')]"));
        }

        [AllureStep("SelectAmenitiesForBuilding")]
        public NewBuilding SelectAmenitiesForBuilding(int numberItem, string itemAmenity)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _numberItem = SelectorAmenitiesForBuilding(itemAmenity);

            _numberItem[numberItem].Click();

            return this;
        }

        #endregion

        #region Access

        [AllureStep("ClickButtonAddLock")]
        public NewBuilding ClickButtonAddLock()
        {
            WaitUntil.CustomElementIsVisible(ButtonAddLock);
            Button.Click(ButtonAddLock);

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

        //This item had been hidden
        //[AllureStep("AddItemAccessTypeCabForAccessNwBldngPg")]
        //public NewBuilding AddItemAccessTypeCabForAccessNwBldngPg()
        //{
        //    WaitUntil.WaitSomeInterval(3000);
        //    WaitUntil.CustomElementIsVisible(ButtonAccessType);
        //    InputGeneral.InputFunctionWithClear(FieldInputLocationForAccess, TestDataForWebSiteAdmin.THIRD_NAME_LOCATION);
        //    Button.Click(ButtonAccessType);
        //    Button.Click(ItemPinCode);
        //    KeyBoardActions.ClickEnterButton();
        //    WaitUntil.WaitSomeInterval(100);
        //    InputGeneral.InputFunctionWithClear(FieldInputLockGuideForAccess, GenerateRandomDataHelper.RandomNumberWithoutZero(5));
        //    WaitUntil.WaitSomeInterval(100);
        //    InputGeneral.InputFunctionWithClear(FieldInputCustomNoteForAccess, building.TextLorem);
        //    WaitUntil.WaitSomeInterval(100);
        //    ButtonSelectImageForAccess.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_FOR_LOCK_OK));
        //    WaitUntil.SuccessCustomElementIsVisible(MessageSuccessUploadImageForAccess);
        //    WaitUntil.WaitSomeInterval(100);
        //    Button.Click(ButtonSaveForLock);

        //    return this;
        //}

        #endregion

        #region Specials

        [AllureStep("ClickButtonAddSpecialsNwBldngPg")]
        public NewBuilding ClickButtonAddSpecialsNwBldngPg()
        {
            WaitUntil.CustomElementIsVisible(ButtonAddSpecialsNwBldngPg, 10);
            Button.Click(ButtonAddSpecialsNwBldngPg);

            return this;
        }

        [AllureStep("AddConcessionSpecialsNwBldngPg")]
        public NewBuilding AddConcessionSpecialsNwBldngPg()
        {
            WaitUntil.CustomElementIsVisible(FieldInputNameSpecialsNwBldngPg, 10);
            InputGeneral.InputFunctionWithClear(FieldInputNameSpecialsNwBldngPg, TestDataForWebSiteAdmin.CONCESSION_NAME);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthsFreeSpecialsNwBldngPg, TestDataForWebSiteAdmin.CONCESSION_MONTHS_FREE);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeaseTermsSpecialsNwBldngPg, TestDataForWebSiteAdmin.CONCESSION_LEASE_TERMS);
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonYesSpecialsNwBldngPg);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputDateFromSpecialsNwBldngPg);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectorDaysPickerDaysSecondLine();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputDateToSpecialsNwBldngPg);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .ClickButtonArrowNextMonth();
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectorDaysPickerDaysSecondLine();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveSpecialsNwBldngPg);

            return this;
        }

        [AllureStep("AddFreeStuffSpecialsNwBldngPg")]
        public NewBuilding AddFreeStuffSpecialsNwBldngPg()
        {
            WaitUntil.CustomElementIsVisible(FieldInputNameSpecialsNwBldngPg, 10);
            InputGeneral.InputFunctionWithClear(FieldInputNameSpecialsNwBldngPg, TestDataForWebSiteAdmin.FREE_STUFF_NAME);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputSelectItemsSpecialsNwBldngPg);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemFreeNetflixSpecialsNwBldngPg);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemGoogleSpeakerSpecialsNwBldngPg);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonYesSpecialsNwBldngPg);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputDateFromSpecialsNwBldngPg);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectorDaysPickerDaysSecondLine();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputDateToSpecialsNwBldngPg);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .ClickButtonArrowNextMonth();
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectorDaysPickerDaysSecondLine();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveSpecialsNwBldngPg);

            return this;
        }

        #endregion

        #region Images

        [AllureStep("UploadImagesForNewBuilding")]
        public NewBuilding UploadImagesForNewBuilding()
        {
            WaitUntil.CustomElementIsVisible(ButtonUploadImageNwBldngPg, 10);
            ButtonUploadImageNwBldngPg.SendKeys(Path.GetFullPath(Path.Combine(Browser.RootPath() + UploadImages.IMAGE_HOUSE_FOR_BUILDING) + "\n" +
                                                                      Browser.RootPath() + UploadImages.IMAGE_PARKING_FOR_BUILDING + "\n" +
                                                                      Browser.RootPath() + UploadImages.IMAGE_POOL_FOR_BUILDING + "\n" +
                                                                      Browser.RootPath() + UploadImages.IMAGE_YARD_FOR_BUILDING));
            WaitUntil.WaitSomeInterval(3000);

            return this;
        }

        [AllureStep("ClickButtonSaveNwBldngPg")]
        public NewBuilding ClickButtonSaveNwBldngPg()
        {
            WaitUntil.WaitSomeInterval(3000);
            Button.Click(ButtonSaveNwBldngPg);

            return this;
        }

        #endregion

    }
}
