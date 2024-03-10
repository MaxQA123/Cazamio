using Allure.Commons;
using AgentTests;
using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System.Threading;

namespace AgentTests
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseWeb : BaseAgent
    {

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Agent")]
        [AllureSubSuite("ChangePassword")]

        public void ChangePassword()
        {
            Pages.LogInLandlord
                .ClickLinkForgotPassword();
            Pages.ResetYourPassword
                .EnterEmailAgent()
                .ClickButtonSendInstructionsRstPsswrdPg()
                .VerifyMessageYourPasswordWasSuccessfullySentRstPsswrdPg();
            Pages.JScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.URL_PUTSBOX_EMAIL_STATIC_AGENT);
            Pages.PutsBox
                .ClickButtonBodyHtml()
                .ClickButtonResetPasswordForAdmin();

            Pages.ResetYourPassword
                .EnterNewConfirmPassword()
                .ClickIconsShowPasswordNewConfirm()
                .ClickButtonResetPasswordlRstPsswrdPg()
                .ClickButtonBackToLogInPageRstPsswrdPg();
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsAgent()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyAgentUserName(getUserNameCompare, getUserNameRoleCompare);

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Agent")]
        [AllureSubSuite("LogIn")]

        public void LogIn()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsAgent()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyAgentUserName(getUserNameCompare, getUserNameRoleCompare);

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Agent")]
        [AllureSubSuite("VerifySidebar")]

        public void VerifySidebar()
        {
            #region Preconditions

            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsAgent()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyAgentUserName(getUserNameCompare, getUserNameRoleCompare);

            #endregion

            #region Test

            Pages.SideBarLandlord
                .UploadImageAvatarUserLandlordFirst()
                .VerifyChangingAvatarImageLandlord()
                .UploadImageAvatarUserLandlordSecond()
                .VerifyChangingAvatarImageLandlord()
                .ClicklinkRemovePhotoOfLandlord()
                .VerifyRewmoveAvatarImageLandlord();
            //.ClickButtonDashboardSidebar();
            //Pages.Dashboard
            //    .VerifyTitleOfDashboardPg();
            Pages.SideBarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .VerifyTitleListOfBuildingsPg();
            Pages.SideBarLandlord
                .ClickButtonApartments();
            Pages.ListOfApartments
                .VerifyTitleListOfApartmentsPg();
            Pages.SideBarLandlord
                .ClickButtonApplications();
            Pages.ListOfApplications
                .VerifyTitleListOfApplicationsPg();
            Pages.SideBarLandlord
                .ClickButtonTransactions();
            Pages.ListOfTransactions
                .VerifyTitleTransactionsPg();
            Pages.SideBarLandlord
                .ClickButtonCommissions();
            Pages.ListOfCommissions
                .VerifyTitleListOfCommissionsPg();
            Pages.SideBarLandlord
                .ClickButtonLogOut();
            Pages.LogInLandlord
                .VerifyTitleLogInPg();

            WaitUntil.WaitSomeInterval(2000);

            #endregion
        }
    }
}