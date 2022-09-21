using Allure.Commons;
using BrokerTests;
using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System.Threading;

namespace BrokerTests
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseWeb : BaseBroker
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
        [AllureSubSuite("SignUpAsBroker")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully SignUp as Broker.
        //Comment: 

        public void SignUpAsBroker()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsLandlord()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();

            Pages.SideBarLandlord
                .VerifyLandlordUserName(getUserNameCompare)
                .ClickButtonBrokersSidebar();
            Pages.Brokers
                .ClickButtonCreateBrokerBrokersPage();
            Pages.ModalWindowCreateNewBroker
                .EnterFirstLastNameEmailPhnNmbrCellMdlWndw();
                //.VerifyFieldsOnMdlWndwCreateBroker()

            string email = Pages.ModalWindowCreateNewBroker.CopyEmailFromMdlWndwCreateBroker();
            string firstName = Pages.ModalWindowCreateNewBroker.CopyFirstNameFromMdlWndwCreateBroker();

            Pages.ModalWindowCreateNewBroker
                .ClickButtonSaveCrtNwBrkrOnMdlwndw()
                .VerifyMessageNewBrokerCreatedSuccessfullyCrtNwBrkrOnMdlwndw();
            Pages.JScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.urlXitrooRandom);
            Pages.EmailXitroo
                .CopiedForEnterEmail(email)
                .ClickSearchButton();
            Pages.EmailXitroo
                .OpenNewlyLetter();

            string link = Pages.EmailXitroo.CopyLinkFromEmailXitroo();

            Pages.EmailXitroo
                .ClickLinkForConfirmAccountBroker();
            Pages.SideBarLandlord
                .SwitchTabClickButtonBrokersSidebar();
            Pages.EmailXitroo
                .VerifyEmailForCretingBroker(email);

            Pages.SideBarLandlord
                .ClickButtonLogOutSidebar();

            Pages.LogInLandlord
                .CopiedForEnterEmailFromEmailCreateBroker(email);

            string copyPasswordFromEmail = Pages.EmailXitroo.CopyPasswordFromEmailForCreateBroker(firstName, link);

            Pages.LogInLandlord
                .CopiedForEnterPsswrdFromEmailCreateBroker(copyPasswordFromEmail)
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
        [AllureSubSuite("ChangePasswordAsBroker")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: in progress.
        //This test case is doing checking: The broker successfully had been changed the password.
        //Comment: 

        public void ChangePasswordAsBroker()
        {
            Pages.LogInLandlord
                .ClickLinkForgotPassword();
            Pages.ResetYourPassword
                .EnterEmailBrokerForRstPsswrdPg()
                .ClickButtonSendInstructionsRstPsswrdPg()
                .VerifyMessageYourPasswordWasSuccessfullySentRstPsswrdPg();
            Pages.JScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.urlXitrooStaticBroker);
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
        [AllureSuite("Broker")]
        [AllureSubSuite("LogInAsBroker")]

        //Date of publication: 25.08.2022.
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn as lanlord.
        //Comment: 

        public void LogInAsBroker()
        {
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
        [AllureSuite("Broker")]
        [AllureSubSuite("VerifySidebar")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: in progress.
        //This test case is doing checking: That the images uploaded and switching between the pages successfully via the sidebar.
        //Comment: 

        public void VerifySidebar()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsBroker()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();

            Pages.SideBarLandlord
                .VerifyBrokerUserName(getUserNameCompare);

            Pages.SideBarLandlord
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
                .ClickButtonOwnersSidebar();
            Pages.ListOfOwners
                .VerifyTitleListOfOwnersPg();
            Pages.SideBarLandlord
                .ClickButtonLogOutSidebar();
            Pages.LogInLandlord
                .VerifyTitleLogInPg();

            Thread.Sleep(5000);
        }
    }
}