using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteCazamioTenantPages.MyAccountPageCazamioTenant
{
    public partial class MyAccountCazamioTenant
    {

        #region TabsOnMyAccountPage

        [AllureStep("ClickTabAccountOnMyAccntPg")]
        public MyAccountCazamioTenant ClickTabAccountOnMyAccntPg()
        {
            Button.Click(TabAccount);

            return this;
        }

        [AllureStep("ClickTabApplicationsOnMyAccntPg")]
        public MyAccountCazamioTenant ClickTabApplicationsOnMyAccntPg()
        {
            Button.Click(TabApplications);

            return this;
        }

        [AllureStep("ClickTabFavoritesOnMyAccntPg")]
        public MyAccountCazamioTenant ClickTabFavoritesOnMyAccntPg()
        {
            Button.Click(TabFavorites);

            return this;
        }

        [AllureStep("ClickTabHistoryOnMyAccntPg")]
        public MyAccountCazamioTenant ClickTabHistoryOnMyAccntPg()
        {
            Button.Click(TabHistory);

            return this;
        }

        #endregion

        #region TabAccountSectionAccount

        [AllureStep("UploadImageForTenant")]
        public MyAccountCazamioTenant UploadImageForTenant()
        {
            WaitUntil.WaitSomeInterval(1000);
            IconForUploadingImage.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.avatarImgTenant));

            return this;
        }

        [AllureStep("ClickButtonEditMyAccntPgTabAccnt")]
        public MyAccountCazamioTenant ClickButtonEditMyAccntPgTabAccnt()
        {
            Button.Click(ButtonEditMyAccntPgTabAccnt);

            return this;
        }

        [AllureStep("EnterFirstLastNameEmailPhoneNumberMyAccntPgTabAccnt")]
        public MyAccountCazamioTenant EnterFirstLastNameEmailPhoneNumberMyAccntPgTabAccnt()
        {
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputFirsNameMyAccntPgTabAccnt, TestDataForWebSiteCazamio.firstNameNewOccupantTerryLee);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputLastNameMyAccntPgTabAccnt, TestDataForWebSiteCazamio.lastNameNewOccupantTerryLee);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputEmailMyAccntPgTabAccnt, TestDataForWebSiteCazamio.emailCurrentOccupantTerryLee);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputPhoneNumberMyAccntPgTabAccnt, TestDataForWebSiteCazamio.phoneNumberNewOccupantTerryLee);

            return this;
        }

        [AllureStep("SctollToDateOfBirth")]
        public MyAccountCazamioTenant SctollToDateOfBirth()
        {
            WaitUntil.WaitSomeInterval(250);
            ScrollingJScriptExecutorHelper.ScrollToElement(FieldInputFirsNameMyAccntPgTabAccnt);

            return this;
        }

        [AllureStep("SctollToButtonSaveCancel")]
        public MyAccountCazamioTenant SctollToButtonSaveCancel()
        {
            WaitUntil.WaitSomeInterval(250);
            ScrollingJScriptExecutorHelper.ScrollToElement(ButtonSaveMyAccntPgTabAccnt);

            return this;
        }

        [AllureStep("ClickFieldInputDateOfBirthMyAccntPgTabAccnt")]
        public MyAccountCazamioTenant ClickFieldInputDateOfBirthMyAccntPgTabAccnt()
        {
            Button.Click(FieldInputDateOfBirthMyAccntPgTabAccnt);

            return this;
        }

        [AllureStep("ClickFieldInputLivingThereSinceMyAccntPgTabAccnt")]
        public MyAccountCazamioTenant ClickFieldInputLivingThereSinceMyAccntPgTabAccnt()
        {
            WaitUntil.WaitSomeInterval(500);
            Button.Click(FieldInputLivingThereSinceMyAccntPgTabAccnt);

            return this;
        }

        [AllureStep("EnterStreetCityStateZipMyAccntPgTabAccnt")]
        public MyAccountCazamioTenant EnterStreetCityStateZipCodeMyAccntPgTabAccnt()
        {
            InputGeneral.InputFunctionWithClear(FieldInputStreetMyAccntPgTabAccnt, TestDataForWebSiteCazamio.yourNewCurrentAddressStreetTerryLee);
            InputGeneral.InputFunctionWithClear(FieldInputCityMyAccntPgTabAccnt, TestDataForWebSiteCazamio.yourNewCurrentAddressCityTerryLee);
            InputGeneral.InputFunctionWithClear(FieldInputStateMyAccntPgTabAccnt, TestDataForWebSiteCazamio.yourNewCurrentAddressStateTerryLee);
            InputGeneral.InputFunctionWithClear(FieldInputZipCodeSectionYourCrrntAdrsMyAccntPgTabAccnt, TestDataForWebSiteCazamio.yourNewCurrentAddressZipTerryLee);

            return this;
        }

        [AllureStep("EnterSectionReferenceNamePhnNmbrExtensionNmbrMyAccntPgTabAccnt")]
        public MyAccountCazamioTenant EnterSectionReferenceNamePhnNmbrExtensionNmbrMyAccntPgTabAccnt()
        {
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputNameSectionReferenceMyAccntPgTabAccnt, TestDataForWebSiteCazamio.sectionReferenceNameTerryLee);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputPhnNmbrSectionReferenceMyAccntPgTabAccnt, TestDataForWebSiteCazamio.sectionReferencePhoneNumberTerryLee);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputExtensionNmbrSectionReferenceMyAccntPgTabAccnt, TestDataForWebSiteCazamio.sectionReferenceExtensionNumberTerryLee);

            return this;
        }

        [AllureStep("SelectItemFromDropDownDoYouRentOrOwnThisProperty")]
        public MyAccountCazamioTenant SelectItemFromDrpDwnIRentThisPropertyDoYouRntMyAccntPgTabAccnt()
        {
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonDropDownDoYouRentOrOwnThisPropertMyAccntPgTabAccnt);
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ItemFromDrpDwnIOwnThisPropertyDoYouRntMyAccntPgTabAccnt);

            return this;
        }

        [AllureStep("EnterRentMortgageCostMyAccntPgTabAccnt")]
        public MyAccountCazamioTenant EnterRentMortgageCostMyAccntPgTabAccnt()
        {
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputPriceRentMortgageCostMyAccntPgTabAccnt, GenerateRandomDataHelper.RandomCostRentMortgageCost(2));
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputZipCodeSectionDoYouRentOrOwnThisPropertMyAccntPgTabAccnt, TestDataForWebSiteCazamio.yourCurrentCurrentAddressZipTerryLee);

            return this;
        }

        [AllureStep("ClickButtonSaveMyAccntPgTabAccnt")]
        public MyAccountCazamioTenant ClickButtonSaveMyAccntPgTabAccnt()
        {
            WaitUntil.CustomElementIsInVisible(ErrorStreetIsRequiredMyAccntPgTabAccnt);
            ButtonSaveMyAccntPgTabAccnt.SendKeys("");
            Button.Click(ButtonSaveMyAccntPgTabAccnt);

            Assert.IsTrue(!ErrorStreetIsRequiredMyAccntPgTabAccnt.Enabled, ErrorStreetIsRequiredMyAccntPgTabAccnt.Text);

            return this;
        }

        #endregion

    }
}
