using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
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
            InputGeneral.InputFunctionWithClear(FieldInputEmailMyAccntPgTabAccnt, TestDataForWebSiteCazamio.emailNewOccupantTerryLee);
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

        [AllureStep("ClickFieldInputDateOfBirthMyAccntPgTabAccnt")]
        public MyAccountCazamioTenant ClickFieldInputDateOfBirthMyAccntPgTabAccnt()
        {
            Button.Click(FieldInputDateOfBirthMyAccntPgTabAccnt);

            return this;
        }

        [AllureStep("EnterStreetCityStateZipMyAccntPgTabAccnt")]
        public MyAccountCazamioTenant EnterStreetCityStateZipCodeMyAccntPgTabAccnt()
        {
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputStreetMyAccntPgTabAccnt, TestDataForWebSiteCazamio.yourNewCurrentAddressStreetTerryLee);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputCityMyAccntPgTabAccnt, TestDataForWebSiteCazamio.yourNewCurrentAddressCityTerryLee);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputStateMyAccntPgTabAccnt, TestDataForWebSiteCazamio.yourNewCurrentAddressStateTerryLee);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputZipCodeSectionYourCrrntAdrsMyAccntPgTabAccnt, TestDataForWebSiteCazamio.yourNewCurrentAddressZipTerryLee);

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

        #endregion

    }
}
