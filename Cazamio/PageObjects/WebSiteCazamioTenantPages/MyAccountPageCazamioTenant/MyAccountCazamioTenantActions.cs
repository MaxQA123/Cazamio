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
            InputGeneral.InputFunctionWithClear(FieldInputFirsNameMyAccntPgTabAccnt, TestDataForWebSiteTenant.firstNameCurrentOccupantTomCruz);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputLastNameMyAccntPgTabAccnt, TestDataForWebSiteTenant.lastNameCurrentOccupantTenantTomCruz);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputEmailMyAccntPgTabAccnt, TestDataForWebSiteTenant.EMAIL_CURRENT_OCCUPANT_LIZA_LIKE);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputPhoneNumberMyAccntPgTabAccnt, TestDataForWebSiteTenant.phoneNumberCurrentOccupantTomCruz);

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
            InputGeneral.InputFunctionWithClear(FieldInputStreetMyAccntPgTabAccnt, TestDataForWebSiteTenant.yourNewCurrentAddressStreetTerryLee);
            InputGeneral.InputFunctionWithClear(FieldInputCityMyAccntPgTabAccnt, TestDataForWebSiteTenant.yourNewCurrentAddressCityTerryLee);
            InputGeneral.InputFunctionWithClear(FieldInputStateMyAccntPgTabAccnt, TestDataForWebSiteTenant.yourNewCurrentAddressStateTerryLee);
            InputGeneral.InputFunctionWithClear(FieldInputZipCodeSectionYourCrrntAdrsMyAccntPgTabAccnt, TestDataForWebSiteTenant.yourNewCurrentAddressZipTerryLee);

            return this;
        }

        [AllureStep("EnterSectionReferenceNamePhnNmbrExtensionNmbrMyAccntPgTabAccnt")]
        public MyAccountCazamioTenant EnterSectionReferenceNamePhnNmbrExtensionNmbrMyAccntPgTabAccnt()
        {
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputNameSectionReferenceMyAccntPgTabAccnt, TestDataForWebSiteTenant.sectionReferenceNameTerryLee);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputPhnNmbrSectionReferenceMyAccntPgTabAccnt, TestDataForWebSiteTenant.sectionReferencePhoneNumberTerryLee);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputExtensionNmbrSectionReferenceMyAccntPgTabAccnt, TestDataForWebSiteTenant.sectionReferenceExtensionNumberTerryLee);

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
            InputGeneral.InputFunctionWithClear(FieldInputZipCodeSectionDoYouRentOrOwnThisPropertMyAccntPgTabAccnt, TestDataForWebSiteTenant.yourCurrentCurrentAddressZipTerryLee);

            return this;
        }

        [AllureStep("ClickButtonSaveMyAccntPgTabAccnt")]
        public MyAccountCazamioTenant ClickButtonSaveMyAccntPgTabAccnt()
        {
            WaitUntil.CustomElementIsInVisible(ErrorStreetIsRequiredMyAccntPgTabAccnt);
            ButtonSaveMyAccntPgTabAccnt.SendKeys("");
            Button.Click(ButtonSaveMyAccntPgTabAccnt);

            return this;
        }

        #endregion

    }
}
