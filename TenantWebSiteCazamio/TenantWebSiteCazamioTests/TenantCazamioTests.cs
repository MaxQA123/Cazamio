using Allure.Commons;
using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
using CazamioProject.DBHelpers;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using CazamioProject;
using System.Threading;
using TenantCazamioTests;
using CazamioProject.ApiHelpers;
using CazamioProject.ApiHelpers.ApiPagesObjects.ApiTenantPages.SignUpTenant;
using CazamioProgect.PageObjects.EmailPutsBox;

namespace TenantCazamioTests
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseWeb : BaseTenantCazamio
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("WebSiteTenant")]
        [AllureSubSuite("SignUpAsTenant")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully SignUp as tenant.
        //Comment:

        public void SignUpAsTenant()
        {
            Pages.HeaderCazamioTenant
                .ClickButtonSignUpHdrCzmTnnt();
            Pages.SignUpCazamioTenant
                .DemoEnterFirstLastNameEmailPasswordSignUpPg()
                .ClickIconShowSignUpPg();

            string emailPutsBox = Pages.SignUpCazamioTenant.CopyEmailFromSignUpPg();
            string partEmailPutsBox = Pages.SignUpCazamioTenant.CopyEmailBeforeDogFromSignUpPg();

            Pages.SignUpCazamioTenant
                .ClickButtonGetStartedSignUpPg();
            Pages.JScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(($"https://putsbox.com/{partEmailPutsBox}/inspect"));
            Pages.PutsBox
                .ClickButtonBodyHtml()
                .ClickButtonConfirmEmailForTenant();
            Pages.HeaderCazamioTenant
               .ClickButtonMyApplicationsHdrCzmTnnt();
            Pages.MyAccountCazamioTenant
                .ClickTabAccountOnMyAccntPg()
                .ClickButtonEditMyAccntPgTabAccnt()
                .VerifyEmailNewTenant(emailPutsBox);

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("WebSiteTenant")]
        [AllureSubSuite("LogInAsTenant")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn as tenant.
        //Comment: 

        public void LogInAsTenant()
        {
            Pages.HeaderCazamioTenant
                .ClickButtonLogInHdrCzmTnnt();
            Pages.LogInCazamioTenant
                .EnterEmailPasswordOnLgInAsTenantApplicant()
                .ClickIconShowLgInCazmTnnt()
                .SetCheckBoxRememberMeLgInCazmTnnt()
                .ClickButtonLogInLgInCazmTnnt();
            Pages.HeaderCazamioTenant
                .ClickButtonMyApplicationsHdrCzmTnnt();
            Pages.MyAccountCazamioTenant
                .ClickTabAccountOnMyAccntPg();

            string getFirstNameForCompare = Pages.MyAccountCazamioTenant.GetFirstNameFromMyAccount();
            string getLastNameForCompare = Pages.MyAccountCazamioTenant.GetLastNameFromMyAccount();

            Pages.MyAccountCazamioTenant
                .VerifyTenatFirstLastNameTW(getFirstNameForCompare, getLastNameForCompare);

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("WebSiteTenant")]
        [AllureSubSuite("ForgotPasswordAsTenant")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The tenant had changed the password successfully.
        //Comment:

        public void ForgotPasswordAsTenant()
        {
            Pages.HeaderCazamioTenant
                .ClickButtonLogInHdrCzmTnnt();
            Pages.LogInCazamioTenant
                .ClickButtonForgotPasswordLgInCazmTnnt();
            Pages.ForgotPassword
                .EnterEmailOnFrgtPsswrdPg()
                .ClickButtonSendRecoveryLinkFrgtPsswrdPg();
            Pages.JScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.URL_PUTSBOX_EMAIL_STATIC_TENANT_APPLICANT);
            Pages.PutsBox
                .ClickButtonBodyHtml()
                .ClickButtonResetPasswordForTenant();
            Pages.CreateNewPassword
                .EnterInputFieldPassswordCreateNewPsswrdPg()
                .ClickIconShowCreateNewPsswrdPg()
                .ClickButtonSaveMyPasswordCreateNewPsswrdPg();
            Pages.LogInCazamioTenant
                .VerifyMessageYouHaveSuccesfullyChangedYourPasswordLgInPg()
                .EnterEmailNewPasswordOnLogInPg()
                .ClickIconShowLgInCazmTnnt()
                .ClickButtonLogInLgInCazmTnnt();
            Pages.HeaderCazamioTenant
                .ClickButtonMyApplicationsHdrCzmTnnt();
            Pages.MyAccountCazamioTenant
                .ClickTabAccountOnMyAccntPg();

            string getFirstNameForCompare = Pages.MyAccountCazamioTenant.GetFirstNameFromMyAccount();
            string getLastNameForCompare = Pages.MyAccountCazamioTenant.GetLastNameFromMyAccount();

            Pages.MyAccountCazamioTenant
                .VerifyTenatFirstLastNameTW(getFirstNameForCompare, getLastNameForCompare);

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("WebSiteTenant")]
        [AllureSubSuite("SearchApartmentViaHomePage")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing: 
        //Willingness for testing: Done.
        //This test case is doing checking: An apartment had found via the field search on the home page.
        //Comment:

        public void SearchApartmentViaHomePage()
        {
            Pages.HeaderCazamioTenant
                .ClickButtonLogInHdrCzmTnnt();
            Pages.LogInCazamioTenant
                .EnterEmailPasswordOnLgInAsTenantApplicant()
                .ClickIconShowLgInCazmTnnt()
                .SetCheckBoxRememberMeLgInCazmTnnt()
                .ClickButtonLogInLgInCazmTnnt();
            Pages.HomeCazamioTenant
                .SearchNumberBuildingHomePg();
            Pages.ListOfApartmentsTenant
                .SelectApartmentCard(CardApartmentOnListOfApartments.apartmentCardOne, "");

            WaitUntil.WaitSomeInterval(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("WebSiteTenant")]
        [AllureSubSuite("EditPageMyAccountTabSectionAccount")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully had edited page "My Account" in the tad\section "Account".
        //Comment: BUG 

        public void EditPageMyAccountTabSectionAccount()
        {
            Pages.HeaderCazamioTenant
                .ClickButtonLogInHdrCzmTnnt();
            Pages.LogInCazamioTenant
                .EnterEmailPasswordOnLgInAsOccupantLiza()
                .ClickIconShowLgInCazmTnnt()
                .SetCheckBoxRememberMeLgInCazmTnnt()
                .ClickButtonLogInLgInCazmTnnt();
            Pages.HeaderCazamioTenant
                .ClickButtonMyApplicationsHdrCzmTnnt();
            Pages.MyAccountCazamioTenant
                .ClickTabAccountOnMyAccntPg();

            string getFirstNameForCompare = Pages.MyAccountCazamioTenant.GetFirstNameFromMyAccount();
            string getLastNameForCompare = Pages.MyAccountCazamioTenant.GetLastNameFromMyAccount();

            Pages.MyAccountCazamioTenant
                .VerifyTenatFirstLastNameTW(getFirstNameForCompare, getLastNameForCompare);

            Pages.MyAccountCazamioTenant
                .ClickButtonEditMyAccntPgTabAccnt()
                .UploadImageForTenant()
                .EnterFirstLastNameEmailPhoneNumberMyAccntPgTabAccnt()
                .SctollToDateOfBirth()
                .ClickFieldInputDateOfBirthMyAccntPgTabAccnt();
            Pages.DatePicker //Date of birth
                .SelectDayOnDatePickerSecondWeek(DaysSecondWeekForDatePiker.secondWeekfourteenthNumber, "");
            Pages.MyAccountCazamioTenant
                .EnterStreetCityStateZipCodeMyAccntPgTabAccnt()
                .SelectItemFromDrpDwnIRentThisPropertyDoYouRntMyAccntPgTabAccnt()
                .EnterRentMortgageCostMyAccntPgTabAccnt()
                .ClickFieldInputLivingThereSinceMyAccntPgTabAccnt();
            Pages.DatePicker //Living there since
                .ClickButtonDropDownYearMonth()
                .SelectYearsPickerYearsFirstLine(YearsFirstLineForDatePiker.firstLineFirstYear, "")
                .SelectMonthPickerMonthFirstLine(MonthsFirstLineForDatePiker.firstLineFebruary, "");
            KeyBoardActions
                .ClickArrowRight();
            KeyBoardActions
                .ClickEnterButton();
            Pages.MyAccountCazamioTenant
                .EnterSectionReferenceNamePhnNmbrExtensionNmbrMyAccntPgTabAccnt();
            Pages.MyAccountCazamioTenant
                .ClickButtonSaveMyAccntPgTabAccnt()
                .VerifyEnterData();

            WaitUntil.WaitSomeInterval(2000);
        }

        

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        //[Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("DemoTenant")]
        [AllureSubSuite("DemoSignUp")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully SignUp as tenant.
        //Comment:

        public void DemoSignUp()
        {

            //Pages.HeaderCazamioTenant
            //    .ClickButtonSignUpHdrCzmTnnt();
            //Pages.SignUpCazamioTenant
            //    .DemoEnterFirstLastNameEmailPasswordSignUpPg()
            //    .ClickIconShowSignUpPg();

            //string emailPutsBox = Pages.SignUpCazamioTenant.CopyEmailFromSignUpPg();
            //string partEmailPutsBox = Pages.SignUpCazamioTenant.CopyEmailBeforeDogFromSignUpPg();

            //Pages.SignUpCazamioTenant
            //    .ClickButtonGetStartedSignUpPg();
            //Pages.JScriptExecutorHelper
            //    .OpenNewTab();
            //Browser._Driver.Navigate().GoToUrl(($"https://putsbox.com/{partEmailPutsBox}/inspect"));
            //Pages.PutsBox
            //    .ClickButtonBodyHtml()
            //    .ClickButtonConfirmEmailForTenant();
            //Pages.HeaderCazamioTenant
            //   .ClickButtonMyApplicationsHdrCzmTnnt();
            //Pages.MyAccountCazamioTenant
            //    .ClickTabAccountOnMyAccntPg()
            //    .ClickButtonEditMyAccntPgTabAccnt()
            //    .VerifyEmailNewTenant(emailPutsBox);

            //WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("DemoTenant")]
        [AllureSubSuite("DemoSignUp")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: in progress.
        //This test case is doing checking: 
        //Comment:

        public void DemoPaymentHoldDeposit()
        {
            Pages.HeaderCazamioTenant
                .ClickButtonLogInHdrCzmTnnt();
            Pages.LogInCazamioTenant
                .EnterEmailPasswordOnLgInAsTenantApplicant()
                .ClickIconShowLgInCazmTnnt()
                .SetCheckBoxRememberMeLgInCazmTnnt()
                .ClickButtonLogInLgInCazmTnnt();
            Pages.HomeCazamioTenant
                .SearchNumberBuildingHomePg();
            Pages.ListOfApartmentsTenant
                .SelectApartmentCard(CardApartmentOnListOfApartments.apartmentCardOne, "");
            Pages.ApartmentDetailsTenant
                .ClickButtonSubmitApplicationTn();

            WaitUntil.WaitSomeInterval(5000);
        }

        [Test]
        public void DemoMix()
        {
            var email = "test" + DateTime.Now.ToString("yyyyMMddThhmmss");
            var mail = email + "@putsbox.com";
            var passwordGeneral = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var firstName = DBTestDataForTenantMarketplaceOne.NEW_TENANT_FIRST_NAME;
            var lastName = DBTestDataForTenantMarketplaceOne.NEW_TENANT_LAST_NAME;
            var returnUrl = ApiRequestData.RETURN_URL;
            var isNeedToVisit = ApiRequestData.FALSE;
            var role = DBTestDataGeneral.NAME_ROLE_TENANT;
            var toHowToVisit = ApiRequestData.FALSE;

            var responseSignUpTenant = SignUpTenant.ExecuteSignUp(mail, passwordGeneral, firstName, lastName, returnUrl, isNeedToVisit, role, toHowToVisit);

            VerifyPutsBox.VerifyVisibilityOfToaster(email);

            Console.WriteLine(responseSignUpTenant);
        }

    }
}