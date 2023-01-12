using NUnit.Framework;
using Allure.Commons;
using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using PutsboxWrapper;
using NUnit.Framework;

namespace BrokerAdminTests
{
    [TestFixture]
    [AllureNUnit]

    public class Tests : BaseBrokerAdmin
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("BrokerAdmin")]
        [AllureSubSuite("LogIn")]

        //Date of publication: 25.08.2022.
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn as lanlord.
        //Comment: 

        public void LogIn()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyAdminUserName(getUserNameCompare, getUserNameRoleCompare);

            WaitUntil.WaitSomeInterval(2000);

        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("BrokerAdmin")]
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
                .EnterEmailLandlordForRstPsswrdPg()
                .ClickButtonSendInstructionsRstPsswrdPg()
                .VerifyMessageYourPasswordWasSuccessfullySentRstPsswrdPg();
            Pages.JScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.URL_XITROO_STATIC_ADMIN);
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
                .EnterChangingEmailPasswordLogInPgAsAdmin()
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
        [AllureSuite("BrokerAdmin")]
        [AllureSubSuite("VerifySidebar")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: That the images uploaded and switching between the pages successfully via the sidebar.
        //Comment: 

        public void VerifySidebar()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyAdminUserName(getUserNameCompare, getUserNameRoleCompare);

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

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        //[Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("BrokerAdmin")]
        [AllureSubSuite("CreateNewBroker")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully creaated a new broker.
        //Comment: 

        public void CreateNewBroker()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyAdminUserName(getUserNameCompare, getUserNameRoleCompare)
                .ClickButtonBrokersSidebar();
            Pages.Brokers
                .ClickButtonCreateBrokerBrokersPage();
            Pages.ModalWindowCreateNewBroker
                .EnterFirstLastNameEmailPhnNmbrCellMdlWndw();

            string fullEmailPutsBox = Pages.ModalWindowCreateNewBroker.CopyEmailFromMdlWndwCreateBroker();
            string partEmailPutsBox = Pages.ModalWindowCreateNewBroker.CopyEmailBeforeDogFromModalWindowCreateNewBroker();

            Pages.ModalWindowCreateNewBroker
                .ClickButtonSaveCrtNwBrkrOnMdlwndw()
                .VerifyMessageNewBrokerCreatedSuccessfullyCrtNwBrkrOnMdlwndw();
            KeyBoardActions.ClickEscapeButton();
            
            Pages.SideBarLandlord
                .ClickButtonLogOutSidebar();
            Pages.JScriptExecutorHelper
                .OpenNewTab()
                .OpenPutsBox(Pages.PutsBox.TitleLetterCreateAdmin, partEmailPutsBox);
            Pages.PutsBox
                .VerifyTitleLetterCreateAdmin()
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
                .VerifyOnlyBrokerUserNameRole(getUserNameRoleCompareBroker);

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("BrokerAdmin")]
        [AllureSubSuite("AddBuilding")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: in progress.
        //This test case is doing checking: That the images uploaded and switching between the pages successfully via the sidebar.
        //Comment: 

        public void AddBuilding()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyAdminUserName(getUserNameCompare, getUserNameRoleCompare);
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
        [AllureSuite("BrokerAdmin")]
        [AllureSubSuite("DemoPutsBox")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing:
        //This test case is doing checking:
        //Comment: 

        public void DemoPutsBox()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsAdmin();
                //.ClickIconShowLogInPg()
                //.ClickButtonLetsGoLogInPg();
            Pages.JScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.URL_PUTSBOX_EMAIL_STATIC_TENANT_APPLICANT);

            WaitUntil.WaitSomeInterval(2000);
        }
    }
}