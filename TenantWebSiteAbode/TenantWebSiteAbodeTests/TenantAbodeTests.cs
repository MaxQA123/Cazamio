using Allure.Commons;
using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System.Threading;

namespace TenantAbodeTests
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseWeb : BaseTenantAbode
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("WebSiteAbodeTenant")]
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
                .EnterFirstLastNameEmailPasswordSignUpPg()
                .ClickIconShowSignUpPg();

            string emailExpected = Pages.SignUpCazamioTenant.CopyEmailFromSignUpPg();

            Pages.SignUpCazamioTenant
                .ClickButtonGetStartedSignUpPg();
            Pages.JScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.urlXitrooRandom);
            Pages.EmailXitroo
                .CopiedForEnterEmail(emailExpected)
                .ClickSearchButton();
            Pages.EmailXitroo
                .OpenNewlyLetter()
                .ClickLinkForConfirmAccountTenant();
            Pages.LogInCazamioTenant
                .CopiedForEnterEmailLogInPg(emailExpected)
                .EnterPasswordOnLogInPg()
                .ClickIconShowLgInCazmTnnt()
                .ClickButtonLogInLgInCazmTnnt();
            Pages.HeaderCazamioTenant
               .ClickButtonMyApplicationsHdrCzmTnnt();
            Pages.MyAccountCazamioTenant
                .ClickTabAccountOnMyAccntPg()
                .ClickButtonEditMyAccntPgTabAccnt()
                .VerifyEmailNewTenant(emailExpected);

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("WebSiteAbodeTenant")]
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
                .EnterEmailPasswordOnLgInAsTenantCzmTnntTW()
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

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("WebSiteCazamioTenant")]
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
                .EnterEmailPasswordOnLgInAsOccupantCzmTnntTC()
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
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("WebSiteAbodeTenant")]
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
                .EnterEmailOnFrgtPsswrdPg();
            Pages.JScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.urlXitrooStaticTenant);

            //string email = Pages.EmailXitroo.CopyEmailFromXitrooPage();

            Pages.EmailXitroo
                .ClickSearchButton()
                .OpenNewlyLetter()
                .ClickLinkForResetPasswordTenant();
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

            Thread.Sleep(5000);
        }
    }
}