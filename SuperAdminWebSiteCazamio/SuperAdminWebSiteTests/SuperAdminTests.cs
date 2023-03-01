using Allure.Commons;
using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAdminTests
{
    [TestFixture]
    [AllureNUnit]

    public class SuperAdminTests : BaseSuperAdmin
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("SuperAdmin")]
        [AllureSubSuite("CreateNewAdmin")]

        //Date of publication: 
        //Version\Build:
        //Willingness for testing: in progress
        //This test case is doing checking: The successfully create a new admin in the role super admin.
        //Comment: 

        public void CreateNewAdmin()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsSuperAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifySuperAdminUserName(getUserNameCompare, getUserNameRoleCompare)
                .ClickButtonMarketplaceAdminsSidebar();
            Pages.ListOfMarketplaceAdmins
                .VerifyTitleListOfMarketplaceAdmins()
                .ClickButtonCreateMarketplaceAdmin();
            Pages.ModalWndwCreateNewLandlord
                .VerifyTitleMdlWndwCreateNewLandlord()
                .FillMandatoryFields()
                .VerifyNameHostMarketplaceSubdomainMdlWndwCrtNwLndlrd();

            string fullEmailPutsBox = Pages.ModalWndwCreateNewLandlord.CopyFullEmailFromMdlWndwCreateNewLandlord();
            string partEmailPutsBox = Pages.ModalWndwCreateNewLandlord.CopyEmailBeforeDogFromMdlWndwCreateNewLandlord();

            Pages.ModalWndwCreateNewLandlord
                .ClickButtonCreateMdlWndwCrtNwLndlrd()
                .VerifyMessageLandlordHasBeenSuccessfullyCreated();
            Pages.SideBarLandlord
                .ClickButtonLogOutSidebar();

            Pages.JScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(($"https://putsbox.com/{partEmailPutsBox}/inspect"));
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

            string getUserNameRoleCompareAdmin = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyOnlyAdminUserNameRole(getUserNameRoleCompareAdmin);

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("SuperAdmin")]
        [AllureSubSuite("LogIn")]

        //Date of publication: 
        //Version\Build:
        //Willingness for testing: Done
        //This test case is doing checking: The successfully LogIn as super admin.
        //Comment: 

        public void LogIn()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsSuperAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifySuperAdminUserName(getUserNameCompare, getUserNameRoleCompare);

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("SuperAdmin")]
        [AllureSubSuite("CreateMarketplaceAdmin")]

        //Date of publication: 
        //Version\Build:
        //Willingness for testing: in progress
        //This test case is doing checking: The successfully create a new broker.
        //Comment: 

        public void CreateMarketplaceAdmin()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsSuperAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifySuperAdminUserName(getUserNameCompare, getUserNameRoleCompare)
                .ClickButtonMarketplaceAdminsSidebar();
            Pages.ListOfMarketplaceAdmins
                .VerifyTitleListOfMarketplaceAdmins()
                .ClickButtonCreateMarketplaceAdmin();
            Pages.MdlWndwCreateANewMarketplaceAdmin
                .VerifyTitleCreateANewMarketplaceadmin()
                .FillInMandatoryFields()
                .VerifyNameHostMarketplaceSubdomain();

            string getAdminEmailFromModalWndw = Pages.MdlWndwCreateANewMarketplaceAdmin.GetEmailFromFieldInputEmail();

            Pages.MdlWndwCreateANewMarketplaceAdmin
                .ClickButtonCreate();
            Pages.ListOfMarketplaceAdmins
                .VerifyMessageMarketplaceAdminHasBeenSuccessfullyCreated();
            Pages.PaginationPicker
                .SctollToButtonNext()
                .ClickButtonNextOnce();

            string getLastEmailFromPage = Pages.ListOfMarketplaceAdmins.GetLastEmailFromTable();

            WaitUntil.WaitSomeInterval(2000);
        }
    }
}
