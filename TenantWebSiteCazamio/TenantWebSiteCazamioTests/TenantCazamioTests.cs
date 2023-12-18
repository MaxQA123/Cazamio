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
using PutsboxWrapper;
using RimuTec.Faker;

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
        [AllureSubSuite("ApiGuiSignUp")]

        public void ApiGuiSignUp()
        {

            var email = GenerateRandomDataHelper.RandomEmail(5) + NameDomen.PUTS_BOX;
            var passwordGeneral = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var firstName = Name.FirstName();
            var lastName = Name.LastName();
            var returnUrl = ApiRequestData.RETURN_URL;
            var isNeedToVisit = ApiRequestData.FALSE;
            var role = DBTestDataGeneral.NAME_ROLE_TENANT;
            var toHowToVisit = ApiRequestData.FALSE;

            var responseSignUpTenant = SignUpTenant.ExecuteSignUp(email, passwordGeneral, firstName, lastName, returnUrl, isNeedToVisit, role, toHowToVisit);

            string link = Putsbox.GetLinkFromEmailWithValue(email, "Confirm Email");
            Browser._Driver.Navigate().GoToUrl(link);

            Console.WriteLine(responseSignUpTenant);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("WebSiteTenant")]
        [AllureSubSuite("SignUpAsTenant")]

        public void SignUpAsTenant()
        {
            #region Preconditions Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            #endregion

            Pages.HeaderCazamioTenant
                .ClickButtonSignUpHdrCzmTnnt();
            Pages.SignUpCazamioTenant
                .EnterFirstLastNameEmailPasswordSignUpPg();

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
            Console.WriteLine($"Email a new tenant: {emailPutsBox}");

            #region Postconditions

            DBRequestTeants.Tenants.DeleteCreatedUserTenant(emailPutsBox, marketplaceId);
            DBRequestAspNetUsers.AspNetUsers.DeleteCreatedUser(emailPutsBox, marketplaceId);

            #endregion

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("WebSiteTenant")]
        [AllureSubSuite("LogInTenant")]

        public void LogInTenant()
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
            Pages.HeaderCazamioTenant
                .LogOutFromAccountViaHeader();

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("WebSiteTenant")]
        [AllureSubSuite("ChangePassword")]

        public void ChangePassword()
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

        public void EditPageMyAccountTabSectionAccount()
        {
            Pages.HeaderCazamioTenant
               .ClickButtonLogInHdrCzmTnnt();
            Pages.LogInCazamioTenant
                .EnterEmailPasswordOnLgInAsTenantApplicant()
                .ClickIconShowLgInCazmTnnt()
                .SetCheckBoxRememberMeLgInCazmTnnt()
                .ClickButtonLogInLgInCazmTnnt();   
            Pages.HeaderCazamioTenant
                .SelectItemMyAccountViaButtonInFormAvatarHdrCzmTnnt();

            //Тест падает нужно обновить
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
            //Pages.DatePicker //Date of birth
                //.SelectDayOnDatePickerSecondWeek(DaysSecondWeekForDatePiker.secondWeekfourteenthNumber, "");
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
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("DemoTenant")]
        [AllureSubSuite("DemoSignUp")]

        public void DemoLogOut()
        {
            Pages.HeaderCazamioTenant
                .ClickButtonLogInHdrCzmTnnt();
            Pages.LogInCazamioTenant
                .EnterEmailPasswordOnLgInAsTenantApplicant()
                .ClickIconShowLgInCazmTnnt()
                .SetCheckBoxRememberMeLgInCazmTnnt()
                .ClickButtonLogInLgInCazmTnnt();
            Pages.HeaderCazamioTenant
                .LogOutFromAccountViaHeader();

            WaitUntil.WaitSomeInterval(5000);
        }

    }
}