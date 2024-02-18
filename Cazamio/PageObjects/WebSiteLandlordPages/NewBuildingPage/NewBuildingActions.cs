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
            WaitUntil.CustomElementIsVisible(RecordNameInTableConcessions);
            string getNameConcession = (RecordNameInTableConcessions).Text;
            string nameConcessionActual = getNameConcession.ToString();

            return nameConcessionActual;
        }

        [AllureStep("GetNameFreeStuffFromTable")]
        public string GetNameFreeStuffFromTable()
        {
            WaitUntil.CustomElementIsVisible(RecordNameInTableFreeStuff);
            string getNameConcession = (RecordNameInTableFreeStuff).Text;
            string nameConcessionActual = getNameConcession.ToString();

            return nameConcessionActual;
        }

        [AllureStep("ClickButtonGeneralNext")]
        public NewBuilding ClickButtonGeneralNext()
        {
            WaitUntil.CustomElementIsVisible(ButtonGeneralNext);
            WaitUntil.CustomElementIsClickable(ButtonGeneralNext);
            Button.Click(ButtonGeneralNext);

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

        [AllureStep("ClickTabImages")]
        public NewBuilding ClickTabImages()
        {
            WaitUntil.CustomElementIsVisible(TabImages);
            WaitUntil.CustomElementIsClickable(TabImages);
            Button.Click(TabImages);

            return this;
        }

        #endregion

        #region Amenities

        [AllureStep("ClickFieldInputSearchForAmenities")]
        public NewBuilding ClickFieldInputSearchForAmenities()
        {
            WaitUntil.CustomElementIsVisible(FieldInputSearchForAmenities);
            WaitUntil.CustomElementIsClickable(FieldInputSearchForAmenities);
            Button.Click(FieldInputSearchForAmenities);

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

        #endregion

        #region Specials

        [AllureStep("ClickTabFreeStuff")]
        public NewBuilding ClickTabFreeStuff()
        {
            WaitUntil.CustomElementIsVisible(TabFreeStuff);
            WaitUntil.ElementIsClickable(TabFreeStuff);
            Button.Click(TabFreeStuff);

            return this;
        }

        [AllureStep("ClickButtonAddSpecials")]
        public NewBuilding ClickButtonAddSpecials()
        {
            WaitUntil.CustomElementIsVisible(ButtonAddSpecials);
            WaitUntil.ElementIsClickable(ButtonAddSpecials);
            Button.Click(ButtonAddSpecials);

            return this;
        }

        [AllureStep("ClickButtonLeaseSignedTriggerEvent")]
        public NewBuilding ClickButtonLeaseSignedTriggerEvent()
        {
            WaitUntil.CustomElementIsVisible(ButtonLeaseSignedTriggerEvent);
            WaitUntil.ElementIsClickable(ButtonLeaseSignedTriggerEvent);
            Button.Click(ButtonLeaseSignedTriggerEvent);

            return this;
        }

        #endregion

        #region Images

        [AllureStep("UploadFourImages")]
        public NewBuilding UploadFourImages()
        {
            WaitUntil.CustomElementIsVisible(ButtonUploadImage);
            WaitUntil.CustomElementIsClickable(ButtonUploadImage);
            ButtonUploadImage.SendKeys(Path.GetFullPath(Path.Combine(Browser.RootPath() + UploadImages.IMAGE_HOUSE_FOR_BUILDING) + "\n" +
                                                                      Browser.RootPath() + UploadImages.IMAGE_PARKING_FOR_BUILDING + "\n" +
                                                                      Browser.RootPath() + UploadImages.IMAGE_POOL_FOR_BUILDING + "\n" +
                                                                      Browser.RootPath() + UploadImages.IMAGE_YARD_FOR_BUILDING));
            WaitUntil.WaitSomeInterval(5000);

            return this;
        }

        [AllureStep("ClickButtonSaveBuilding")]
        public NewBuilding ClickButtonSaveBuilding()
        {
            WaitUntil.WaitSomeInterval(5000);
            KeyBoardActions.ScrollToDown();
            WaitUntil.CustomElementIsVisible(ButtonSaveBuilding);
            WaitUntil.CustomElementIsClickable(ButtonSaveBuilding);
            Button.Click(ButtonSaveBuilding);

            return this;
        }

        #endregion

    }
}
