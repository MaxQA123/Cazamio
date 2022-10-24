using Allure.Commons;
using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System.Threading;
using TenantCazamioTests;

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
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("WebSiteCazamioTenant")]
        [AllureSubSuite("SignUpAsTenant")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: in progress.
        //This test case is doing checking: The successfully SignUp as tenant.
        //Comment: Bug: on email hasn't came a letter for confirming.

        public void SignUpAsTenant()
        {
            Pages.HeaderCazamioTenant
                .ClickButtonSignUpHdrCzmTnnt();
            Pages.SignUpCazamioTenant
                .EnterFirstLastNameEmailPasswordSignUpPg()
                .ClickIconShowSignUpPg()
                .ClickButtonGetStartedSignUpPg();

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("WebSiteCazamioTenant")]
        [AllureSubSuite("LogInAsTenant")]

        //Date of publication: 24.08.2022.
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

            WaitUntil.WaitSomeInterval(2000);
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
    }
}