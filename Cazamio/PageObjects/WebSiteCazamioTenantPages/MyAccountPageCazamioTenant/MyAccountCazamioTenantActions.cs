using CazamioProgect.Helpers;
using CazamioProject.Objects;
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
        TenantApplicant tenantApplicant = new TenantApplicant().Generate();
        TenantOccupant tenantOccupant = new TenantOccupant().Generate();

        #region TabsOnMyAccountPage

        [AllureStep("ClickTabAccountOnMyAccntPg")]
        public MyAccountCazamioTenant ClickTabAccountOnMyAccntPg()
        {
            WaitUntil.CustomElementIsVisible(TabAccount);
            WaitUntil.CustomElementIsClickable(TabAccount);
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
            IconForUploadingImage.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.AVATAR_IMG_TENANT));

            return this;
        }

        [AllureStep("ClickButtonEditMyAccntPgTabAccnt")]
        public MyAccountCazamioTenant ClickButtonEditMyAccntPgTabAccnt()
        {
            WaitUntil.CustomElementIsVisible(ButtonEditMyAccntPgTabAccnt);
            WaitUntil.CustomElementIsClickable(ButtonEditMyAccntPgTabAccnt);
            Button.Click(ButtonEditMyAccntPgTabAccnt);

            return this;
        }

        [AllureStep("EnterFirstLastNameEmailPhoneNumberMyAccntPgTabAccnt")]
        public MyAccountCazamioTenant EnterFirstLastNameEmailPhoneNumberMyAccntPgTabAccnt()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputFirsNameMyAccntPgTabAccnt, tenantOccupant.FirstNameTenant);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLastNameMyAccntPgTabAccnt, tenantOccupant.LastNameTenant);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputEmailMyAccntPgTabAccnt, tenantOccupant.EmailAddressTenant);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPhoneNumberMyAccntPgTabAccnt, TestDataForWebSiteTenant.PHONE_NUMBER_OCCUPANT_ONE);

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
            InputGeneral.InputFunctionWithClear(FieldInputStreetMyAccntPgTabAccnt, TestDataForWebSiteTenant.YOUR_NEW__CURRENT_ADDRESS_STREET_SECOND);
            InputGeneral.InputFunctionWithClear(FieldInputCityMyAccntPgTabAccnt, TestDataForWebSiteTenant.YOUR_NEW__CURRENT_ADDRESS_CITY_SECOND);
            InputGeneral.InputFunctionWithClear(FieldInputStateMyAccntPgTabAccnt, TestDataForWebSiteTenant.YOUR_NEW__CURRENT_ADDRESS_STATE_SECOND);
            InputGeneral.InputFunctionWithClear(FieldInputZipCodeSectionYourCrrntAdrsMyAccntPgTabAccnt, TestDataForWebSiteTenant.YOUR_NEW__CURRENT_ADDRESS_ZIP_SECOND);

            return this;
        }

        [AllureStep("EnterSectionReferenceNamePhnNmbrExtensionNmbrMyAccntPgTabAccnt")]
        public MyAccountCazamioTenant EnterSectionReferenceNamePhnNmbrExtensionNmbrMyAccntPgTabAccnt()
        {
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputNameSectionReferenceMyAccntPgTabAccnt, TestDataForWebSiteTenant.SECTION_REFERENCE_NAME_SECOND);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputPhnNmbrSectionReferenceMyAccntPgTabAccnt, TestDataForWebSiteTenant.SECTION_REFERENCE_NEW_PHONE_NUMBER_SECOND);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputExtensionNmbrSectionReferenceMyAccntPgTabAccnt, TestDataForWebSiteTenant.SECTION_REFERENCE_EXTENSION_NUMBER_SECOND);

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
            InputGeneral.InputFunctionWithClear(FieldInputZipCodeSectionDoYouRentOrOwnThisPropertMyAccntPgTabAccnt, TestDataForWebSiteTenant.YOUR_NEW__CURRENT_ADDRESS_STREET_SECOND);

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
