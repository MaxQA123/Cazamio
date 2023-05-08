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
        //Willingness for testing: DONE
        //This test case is doing checking: The successfully created a new Marketplace Admin.
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

            string fullEmailPutsBox = Pages.MdlWndwCreateANewMarketplaceAdmin.GetEmailFromFieldInputEmail();
            string partEmailPutsBox = Pages.MdlWndwCreateANewMarketplaceAdmin.CopyEmailBeforeDogFromFieldInputEmail();

            Pages.MdlWndwCreateANewMarketplaceAdmin
                .ClickButtonCreate();
            Pages.ListOfMarketplaceAdmins
                .VerifyMessageMarketplaceAdminHasBeenSuccessfullyCreated();
            Pages.PaginationPicker
                .SctollToButtonNext()
                .ClickButtonLastNumberPage();

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
                .ClickButtonConfirmEmailForAdmin();

            Pages.LogInLandlord
                .PasteForEnterEmailFromEmailCreateAdmin(fullEmailPutsBox)
                .PasteForEnterPsswrdFromEmailCreateAdmin(getTextPasswordActual)
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameRoleCompareBroker = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyMarketplaceAdminUserNameRole(getUserNameRoleCompareBroker);

            WaitUntil.WaitSomeInterval(2000);
        }
    }
}
