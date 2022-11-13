using NUnit.Framework;
using Allure.Commons;
using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace AdminTests
{
    [TestFixture]
    [AllureNUnit]

    public class Tests : BaseAdmin
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
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
        [AllureSuite("Admin")]
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
        [AllureSuite("Admin")]
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
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
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
 

            string email = Pages.ModalWindowCreateNewBroker.CopyEmailFromMdlWndwCreateBroker();
            string firstName = Pages.ModalWindowCreateNewBroker.CopyFirstNameFromMdlWndwCreateBroker();

            Pages.ModalWindowCreateNewBroker
                .ClickButtonSaveCrtNwBrkrOnMdlwndw()
                .VerifyMessageNewBrokerCreatedSuccessfullyCrtNwBrkrOnMdlwndw();
            Pages.JScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.URL_XITROO_EMAIL_RANDOM);
            Pages.EmailXitroo
                .CopiedForEnterEmail(email)
                .ClickSearchButton();
            Pages.EmailXitroo
                .OpenNewlyLetter();

            string link = Pages.EmailXitroo.CopyLinkFromEmailXitroo();
            string copyPasswordFromEmail = Pages.EmailXitroo.CopyPasswordFromEmailForCreateBroker();

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

            Pages.LogInLandlord
                .CopiedForEnterPsswrdFromEmailCreateBroker(copyPasswordFromEmail)
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
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
    }
}