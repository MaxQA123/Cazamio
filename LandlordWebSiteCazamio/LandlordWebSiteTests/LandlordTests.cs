using Allure.Commons;
using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
using LandlordTests;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System.Threading;

namespace LandlordTests
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseWeb : BaseLandlord
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Landlord")]
        [AllureSubSuite("ChangePasswordAsLandlord")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: in progress.
        //This test case is doing checking: The broker successfully had been changed the password.
        //Comment: 

        public void ChangePasswordAsLandlord()
        {
            Pages.LogInLandlord
                .ClickLinkForgotPassword();
            Pages.ResetYourPassword
                .EnterEmailLandlordForRstPsswrdPg()
                .ClickButtonSendInstructionsRstPsswrdPg()
                .VerifyMessageYourPasswordWasSuccessfullySentRstPsswrdPg();
            Pages.JScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.urlXitrooStaticLandlord);
            Pages.EmailXitroo
                .ClickSearchButton()
                .OpenNewlyLetter()
                .ClickLinkForResetPasswordBroker();
            Pages.ResetYourPassword
                .EnterNewConfirmPassword()
                .ClickIconsShowPasswordNewConfirm()
                .ClickButtonResetPasswordlRstPsswrdPg()
                .ClickButtonBackToLogInPageRstPsswrdPg();
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsBroker()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();

            Pages.SideBarLandlord
                .VerifyBrokerUserName(getUserNameCompare);

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Landlord")]
        [AllureSubSuite("LogInAsLandlord")]

        //Date of publication: 25.08.2022.
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn as lanlord.
        //Comment: 

        public void LogInAsLandlord()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsLandlord()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();

            Pages.SideBarLandlord
                .VerifyLandlordUserName(getUserNameCompare);

            Thread.Sleep(5000);

        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Landlord")]
        [AllureSubSuite("VerifySidebar")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: That the images uploaded and switching between the pages successfully via the sidebar.
        //Comment: 

        public void VerifySidebar()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsLandlord()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();

            Pages.SideBarLandlord
                .VerifyLandlordUserName(getUserNameCompare);

            Pages.SideBarLandlord
                .UploadImageLogoLandlordFirst()
                .VerifyChangingLogoImageLandlord()
                .UploadImageLogoLandlordSecond()
                .VerifyChangingLogoImageLandlord()
                .UploadImageAvatarUserLandlordFirst()
                .VerifyChangingAvatarImageLandlord()
                .UploadImageAvatarUserLandlordSecond()
                .VerifyChangingAvatarImageLandlord()
                .ClicklinkRemovePhotoOfLandlord()
                .VerifyRewmoveAvatarImageLandlord()
                .ClickButtonDashboardSidebar();
            Pages.Dashboard
                .VerifyTitleOfDashboardPg();
            Pages.SideBarLandlord
                .ClickButtonBuildingsSidebar();
            Pages.ListOfBuildings
                .VerifyTitleListOfBuildingsPg();
            Pages.SideBarLandlord
                .ClickButtonApartmentsSidebar();
            Pages.ListOfApartments
                .VerifyTitleListOfApartmentsPg();
            Pages.SideBarLandlord
                .ClickButtonApplicationsSidebar();
            Pages.ListOfApplications
                .VerifyTitleListOfApplicationsPg();
            Pages.SideBarLandlord
                .ClickButtonPreApprovalsSidebar();
            Pages.PreApprovals
                .VerifyTitlePreApprovalsPagePg();
            Pages.SideBarLandlord
                .ClickButtonLeaseSignDocumentsSidebar();
            Pages.Templates
                .VerifyTitleTemplatesPagePg();
            Pages.SideBarLandlord
                .ClickButtonPaymentSettingsSidebar();
            Pages.PaymentSettings
                .VerifyTitlePaymentSettingsPagePg();
            Pages.SideBarLandlord
                .ClickButtonTransactionsSidebar();
            Pages.ListOfTransactions
                .VerifyTitleListOfTransactionsPg();
            Pages.SideBarLandlord
                .ClickButtonBrokersSidebar();
            Pages.Brokers
                .VerifyTitleBrokersPg();
            Pages.SideBarLandlord
                .ClickButtonOwnersSidebar();
            Pages.ListOfOwners
                .VerifyTitleListOfOwnersPg();
            Pages.SideBarLandlord
               .ClickButtonMarketplaceSidebar();
            Pages.Marketplace
                .VerifyTitleMarketplacePg();
            Pages.SideBarLandlord
                .ClickButtonLogOutSidebar();
            Pages.LogInLandlord
                .VerifyTitleLogInPg();

            Thread.Sleep(5000);
        }
    }
}