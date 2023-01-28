using NUnit.Framework;
using Allure.Commons;
using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using PutsboxWrapper;
using NUnit.Framework;

namespace BrokerTests
{
    [TestFixture]
    [AllureNUnit]

    public class Tests : BaseBroker
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
        [AllureSubSuite("LogIn")]

        //Date of publication: 
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn as broker.
        //Comment: 

        public void LogIn()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsBroker()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyBrokerUserName(getUserNameCompare, getUserNameRoleCompare);

            WaitUntil.WaitSomeInterval(2000);

        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
        [AllureSubSuite("ChangePassword")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: in progress.
        //This test case is doing checking: The broker successfully had been changed the password.
        //Comment: 

        public void ChangePassword()
        {
            Pages.LogInLandlord
                .ClickLinkForgotPassword();
            Pages.ResetYourPassword
                .EnterEmailBrokerForRstPsswrdPg()
                .ClickButtonSendInstructionsRstPsswrdPg()
                .VerifyMessageYourPasswordWasSuccessfullySentRstPsswrdPg();
            Pages.JScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.URL_PUTSBOX_EMAIL_STATIC_BROKER);
            Pages.PutsBox
                .ClickButtonBodyHtml()
                .ClickButtonResetPasswordForAdmin();

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
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyBrokerUserName(getUserNameCompare, getUserNameRoleCompare);

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
        [AllureSubSuite("VerifySidebar")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: That the images uploaded and switching between the pages successfully via the sidebar.
        //Comment: 

        public void VerifySidebar()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsBroker()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyBrokerUserName(getUserNameCompare, getUserNameRoleCompare);

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
            Pages.Agents
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

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        //[Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
        [AllureSubSuite("CreateNewAgent")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully creaated a new agent.
        //Comment: 

        public void CreateNewAgent()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsBroker()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyBrokerUserName(getUserNameCompare, getUserNameRoleCompare)
                .ClickButtonBrokersSidebar();
            Pages.Agents
                .ClickButtonCreateAgentAgentsPage();
            Pages.ModalWindowCreateNewAgent
                .EnterFirstLastNameEmailPhnNmbrCellMdlWndw();

            string fullEmailPutsBox = Pages.ModalWindowCreateNewAgent.CopyEmailFromMdlWndwCreateAgent();
            string partEmailPutsBox = Pages.ModalWindowCreateNewAgent.CopyEmailBeforeDogFromModalWindowCreateNewAgent();

            Pages.ModalWindowCreateNewAgent
                .ClickButtonSaveCrtNwAgntOnMdlwndw()
                .VerifyMessageNewAgentCreatedSuccessfullyCrtNwAgntOnMdlwndw();
            KeyBoardActions.ClickEscapeButton();
            Pages.SideBarLandlord
                .ClickButtonLogOutSidebar();
            Pages.JScriptExecutorHelper
                .OpenNewTab()
                .OpenPutsBox(Pages.PutsBox.TitleLetterCreateAdmin, partEmailPutsBox);
            Pages.PutsBox
                .VerifyTitleLetterCreateBroker()
                .ClickButtonBodyHtml();

            string getTextPasswordActual = Pages.PutsBox.CopyPasswordFromEmailForCreateAdmin();

            Pages.PutsBox
                .ClickButtonResetPasswordForAdmin();
            
            Pages.LogInLandlord
                .CopiedForEnterEmailFromEmailCreateAdmin(fullEmailPutsBox)
                .CopiedForEnterPsswrdFromEmailCreateAdmin(getTextPasswordActual)
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameRoleCompareBroker = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyOnlyAgentUserNameRole(getUserNameRoleCompareBroker);

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
        [AllureSubSuite("AddBuilding")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: in progress.
        //This test case is doing checking: That the images uploaded and switching between the pages successfully via the sidebar.
        //Comment: 

        public void AddBuilding()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsBroker()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyBrokerUserName(getUserNameCompare, getUserNameRoleCompare);
            Pages.ListOfBuildings
                .VerifyTitleListOfBuildingsPg()
                .ClickButtonAddBuildingOnLstBldng();
            Pages.NewBuilding
                .VerifyTitleNewBuildingPg()
                .EnterMandatoryAddressNewBuilding()
                .EnterBuildingLlcNamesDescription()
                .SelectPaymentsMethodsNwBldngPage()
                .ClickButtonGeneralNextNwBldngPg();
            //.SelectTabOnNewBuildingsPg(TabsOnNewBuildingPage.tabAmenities, "");

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
        [AllureSubSuite("DemoPutsBox")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing:
        //This test case is doing checking:
        //Comment: 

        public void DemoPutsBox()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsBroker();
                //.ClickIconShowLogInPg()
                //.ClickButtonLetsGoLogInPg();
            Pages.JScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.URL_PUTSBOX_EMAIL_STATIC_TENANT_APPLICANT);

            WaitUntil.WaitSomeInterval(2000);
        }
    }
}