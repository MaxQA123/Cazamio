using Allure.Commons;
using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
using CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfApplicationsPage;
using CazamioProject.DBHelpers;
using CazamioProject.DBHelpers.TableApartmentApplicationProgress;
using CazamioProject.DBHelpers.TableApartmentHistories;
using CazamioProject.DBHelpers.TableApplicationBasicInformation;
using CazamioProject.DBHelpers.TableApplicationGeneralQuestions;
using CazamioProject.DBHelpers.TableApplicationOccupations;
using CazamioProject.DBHelpers.TableApplicationPrices;
using CazamioProject.DBHelpers.TableApplicationRentalHistories;
using CazamioProject.DBHelpers.TableApplicationRequiredDocuments;
using CazamioProject.DBHelpers.TableChatCursors;
using CazamioProject.DBHelpers.TableOwnerCommissionsStructure;
using CazamioProject.DBHelpers.TableOwnerManagements;
using CazamioProject.DBHelpers.TableOwnerPhoneNumbers;
using CazamioProject.DBHelpers.TablePrices;
using CazamioProject.Helpers;
using MarketplaceAdminTests;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Threading;
using CazamioProject.PageObjects.WebSiteCazamioTenantPages.ModalWindowPleaseTellUsYourName;

namespace MarketplaceAdminTests
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseWeb : BaseMarketplaceAdmin
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("LogIn")]

        public void LogIn()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsMarketplaceAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyMarketplaceAdminUserName(getUserNameCompare, getUserNameRoleCompare);

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("VerifySidebar")]

        public void VerifySidebar()
        {

            #region Preconditions Test

            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsMarketplaceAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyMarketplaceAdminUserName(getUserNameCompare, getUserNameRoleCompare);

            #endregion

            #region Test

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
                .VerifyRewmoveAvatarImageLandlord();
            //    .ClickButtonDashboardSidebar();
            //Pages.Dashboard
            //    .VerifyTitleOfDashboardPg();
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
                .ClickButtonBrokersSidebar();
            Pages.ListOfBrokers
                .VerifyTitleListOfBrokersPg();
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
                .VerifyTitleTransactionsPg();
            Pages.SideBarLandlord
                .ClickButtonCommissionsSidebar();
            Pages.ListOfCommissions
                .VerifyTitleListOfCommissionsPg();
            Pages.SideBarLandlord
                .ClickButtonAgentsSidebar();
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
                .ClickButtonReportsAdminsSidebar();
            Pages.Reports
                .VerifyTitleReportsPage();
            Pages.SideBarLandlord
                .ClickButtonLogOutSidebar();
            Pages.LogInLandlord
                .VerifyTitleLogInPg();
            WaitUntil.WaitSomeInterval(2000);

            #endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("ChangePassword")]

        public void ChangePassword()
        {
            #region Test

            Pages.LogInLandlord
                .ClickLinkForgotPassword();
            Pages.ResetYourPassword
                .EnterEmailMarketplaceAdmin()
                .ClickButtonSendInstructionsRstPsswrdPg()
                .VerifyMessageYourPasswordWasSuccessfullySentRstPsswrdPg();
            Pages.JScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.URL_PUTSBOX_EMAIL_STATIC_MARKETPLACE_ADMIN);
            Pages.PutsBox
                .ClickButtonBodyHtml()
                .ClickButtonResetPasswordForAdmin();
            Pages.ResetYourPassword
                .EnterNewConfirmPassword()
                .ClickIconsShowPasswordNewConfirm()
                .ClickButtonResetPasswordlRstPsswrdPg()
                .ClickButtonBackToLogInPageRstPsswrdPg();
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsMarketplaceAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();
            
            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyMarketplaceAdminUserName(getUserNameCompare, getUserNameRoleCompare);

            WaitUntil.WaitSomeInterval(2000);

            #endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("CreateBroker")]

        public void CreateBroker()
        {
            #region Preconditions Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            #endregion

            #region Test

            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsMarketplaceAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyMarketplaceAdminUserName(getUserNameCompare, getUserNameRoleCompare);
            Pages.SideBarLandlord
                .ClickButtonBrokersSidebar();
            Pages.ListOfBrokers
                .VerifyTitleListOfBrokersPg()
                .ClickButtonCreateBroker();
            Pages.ModalWindowCreateNewBroker
                .VerifyTitleCreateNewBroker()
                .EnterFirstLastNamesEmail();

            string getFullEmail = Pages.ModalWindowCreateNewBroker.CopyEmailFromModalWindowCreateNewBroker();
            string getEmailBeforeDog = Pages.ModalWindowCreateNewBroker.CopyEmailBeforeDogFromModalWindowCreateNewBroker();

            Pages.ModalWindowCreateNewBroker
                .ClickButtonCreateMdlWndwCrtNwBrkr();
            Pages.ListOfBrokers
                .VerifyMessageBrokerHasBeenSuccessfullyCreated();

            WaitUntil.WaitSomeInterval(500);
            var marketplaceIdFromDb = DBRequestAspNetUsers.AspNetUsers.GetMarketplaceIdByEmailAndMarketplaceId(getFullEmail, marketplaceId);
            Console.WriteLine($"MarketplaceId from DB: {marketplaceIdFromDb.MarketplaceId}");

            string getEmailFromListOfBrokers = Pages.ListOfBrokers.CopyEmailFirstRecordEmailForFirstBrokerInList();

            Pages.ListOfBrokers
                .VerifyEmailInListOfBrokers(getFullEmail, getEmailFromListOfBrokers);
            Pages.SideBarLandlord
                .ClickButtonLogOutSidebar();
            Pages.JScriptExecutorHelper
               .OpenNewTab()
               .OpenPutsBox(Pages.PutsBox.TitleLetterCreateBrokerMySpace, getEmailBeforeDog);
            Pages.PutsBox
                .VerifyTitleLetterCreateBroker()
                .ClickButtonBodyHtml();

            string getTextPasswordActual = Pages.PutsBox.CopyPasswordFromEmailForCreateAdmin();

            Pages.PutsBox
                .ClickButtonConfirmEmailForAdmin();

            Pages.LogInLandlord
                .PasteForEnterEmailFromEmailCreateBroker(getFullEmail)
                .PasteForEnterPsswrdFromEmailCreateBroker(getTextPasswordActual)
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameRoleCompareBroker = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyOnlyBrokerUserNameRole(getUserNameRoleCompareBroker);

            #endregion

            #region Postconditions

            DBRequestAspNetUsers.AspNetUsers.GetEmailByEmailAndMarketplaceId(getFullEmail, marketplaceId);
            Console.WriteLine($"{getFullEmail}");
            WaitUntil.WaitSomeInterval(100);
            DBRequestLandlords.Landlords.DeleteCreatedUserBroker(getFullEmail, marketplaceId);
            WaitUntil.WaitSomeInterval(100);
            DBRequestAspNetUsers.AspNetUsers.DeleteCreatedUser(getFullEmail, marketplaceId);

            #endregion

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("CreateAgent")]

        public void CreateAgent()
        {
            #region Preconditions Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            #endregion

            #region Test

            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsMarketplaceAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyMarketplaceAdminUserName(getUserNameCompare, getUserNameRoleCompare)
                .ClickButtonAgentsSidebar();
            Pages.Agents
                .ClickButtonCreateAgentAgentsPage();
            Pages.ModalWindowCreateNewAgent
                .EnterFirstLastNameEmailPhnNmbrCellMdlWndw()
                .EnterBrokerAgentCommissionMdlWndw();

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
                .OpenPutsBox(Pages.PutsBox.TitleLetterCreateAgentMySpace, partEmailPutsBox);
            Pages.PutsBox
                .VerifyTitleLetterCreateAgent()
                .ClickButtonBodyHtml();

            string getTextPasswordActual = Pages.PutsBox.CopyPasswordFromEmailForCreateAdmin();

            Pages.PutsBox
                .ClickButtonConfirmEmailForAdmin();

            Pages.LogInLandlord
                .PasteForEnterEmailFromEmailCreateAgent(fullEmailPutsBox)
                .PasteForEnterPsswrdFromEmailCreateAgent(getTextPasswordActual)
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameRoleCompareAgent = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyOnlyAgentUserNameRole(getUserNameRoleCompareAgent);

            WaitUntil.WaitSomeInterval(100);
            var marketplaceIdFromDb = DBRequestAspNetUsers.AspNetUsers.GetMarketplaceIdByEmailAndMarketplaceId(fullEmailPutsBox, marketplaceId);
            Console.WriteLine($"MarketplaceId from DB: {marketplaceIdFromDb.MarketplaceId}");

            #endregion

            #region Postconditions

            WaitUntil.WaitSomeInterval(100);
            DBRequestAspNetUsers.AspNetUsers.GetEmailByEmailAndMarketplaceId(fullEmailPutsBox, marketplaceId);
            Console.WriteLine($"{fullEmailPutsBox}");
            WaitUntil.WaitSomeInterval(100);
            DBRequestBrokers.DBBrokers.DeleteCreatedUserAgent(fullEmailPutsBox, marketplaceId);
            WaitUntil.WaitSomeInterval(100);
            DBRequestAspNetUsers.AspNetUsers.DeleteCreatedUser(fullEmailPutsBox, marketplaceId);

            #endregion

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("CreateOwnerWithAssignedBroker")]

        public void CreateOwnerWithAssignedBroker()
        {
            #region Preconditions Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsMarketplaceAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyMarketplaceAdminUserName(getUserNameCompare, getUserNameRoleCompare)
                .ClickButtonOwnersSidebar();

            #endregion

            #region Test

            Pages.ListOfOwners
                .ClickButtonCreateOwner();
            Pages.ModalWndwCreateNewOwner
                .VerifyTitleCreateANewOwner()
                .EnterCompanyNameForBrokerRole()
                .EnterOwnerName()
                .EnterOwnerEmaiL()
                .EnterOfficeLocation()
                .SelectBroker()
                .EnterInternalNotes()
                .ClickButtonAddPhoneNumber()
                .EnterPhoneExtensionNumbers()
                .ClickButtonAddCommissionStructure();
            KeyBoardActions.ScrollToDown();
            Pages.ModalWndwCreateNewOwner
                .SwitchingItemsPays()
                .ClickButtonAddMgmt()
                .ClickButtonPayType()
                .SelectItemOwnerAndTenantPays()
                .EnterDataOwnerAndTenantPays()
                .ScrollDown()
                .EnterDataMgmt();

            string getOwnerEmailFromModalWndw = Pages.ModalWndwCreateNewOwner.GetEmailFromFieldOwnerEmail();

            Pages.ModalWndwCreateNewOwner
                .ClickButtonCreate();
            Pages.ListOfOwners
                .VerifyMessageSuccessCreatedOwner();

            string getLastEmailFromPage = Pages.ListOfOwners.GetFirstEmailFromTable();

            Pages.ListOfOwners
                .VerifyEmailForNewOwner(getOwnerEmailFromModalWndw, getLastEmailFromPage);

            var marketplaceIdFromDb = DbRequestOwners.DBOwners.GetMarketplaceIdByEmailUserOwner(getOwnerEmailFromModalWndw);
            Console.WriteLine($"MarketplaceId of owner: {marketplaceIdFromDb}");

            #endregion

            #region Postconditions

            DBRequestOwnerCommissionsStructure.OwnerCommissionsStructure.DeleteRecordAboutOwnerCommissionsStructure(getOwnerEmailFromModalWndw, marketplaceId);
            DBRequestOwnerPhoneNumbers.OwnerPhoneNumbers.DeleteRecordAboutOwnerPhoneNumber(getOwnerEmailFromModalWndw, marketplaceId);
            DBRequestOwnerManagements.OwnerManagements.DeleteRecordAboutOwnerManagements(getOwnerEmailFromModalWndw, marketplaceId);
            DbRequestOwners.DBOwners.DeleteCreatedUserOwner(getOwnerEmailFromModalWndw, marketplaceId);

            #endregion

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("CreateOwnerWithAssignedAgent")]

        public void CreateOwnerWithAssignedAgent()
        {
            #region Preconditions Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsMarketplaceAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyMarketplaceAdminUserName(getUserNameCompare, getUserNameRoleCompare)
                .ClickButtonOwnersSidebar();

            #endregion

            #region Test

            Pages.ListOfOwners
                .ClickButtonCreateOwner();
            Pages.ModalWndwCreateNewOwner
                .VerifyTitleCreateANewOwner()
                .EnterCompanyNameForAgentRole()
                .EnterOwnerName()
                .EnterOwnerEmaiL()
                .EnterOfficeLocation()
                .SelectAgent()
                .EnterInternalNotes()
                .ClickButtonAddPhoneNumber()
                .EnterPhoneExtensionNumbers()
                .ClickButtonAddCommissionStructure();
            KeyBoardActions.ScrollToDown();
            Pages.ModalWndwCreateNewOwner
                .SwitchingItemsPays()
                .ClickButtonAddMgmt()
                .ClickButtonPayType()
                .SelectItemOwnerAndTenantPays()
                .EnterDataOwnerAndTenantPays()
                .ScrollDown()
                .EnterDataMgmt();

            string getOwnerEmailFromModalWndw = Pages.ModalWndwCreateNewOwner.GetEmailFromFieldOwnerEmail();

            Pages.ModalWndwCreateNewOwner
                .ClickButtonCreate();
            Pages.ListOfOwners
                .VerifyMessageSuccessCreatedOwner();

            string getLastEmailFromPage = Pages.ListOfOwners.GetFirstEmailFromTable();

            Pages.ListOfOwners
                .VerifyEmailForNewOwner(getOwnerEmailFromModalWndw, getLastEmailFromPage);

            var marketplaceIdFromDb = DbRequestOwners.DBOwners.GetMarketplaceIdByEmailUserOwner(getOwnerEmailFromModalWndw);
            Console.WriteLine($"MarketplaceId of owner: {marketplaceIdFromDb}");

            #endregion

            #region Postconditions

            DBRequestOwnerCommissionsStructure.OwnerCommissionsStructure.DeleteRecordAboutOwnerCommissionsStructure(getOwnerEmailFromModalWndw, marketplaceId);
            DBRequestOwnerPhoneNumbers.OwnerPhoneNumbers.DeleteRecordAboutOwnerPhoneNumber(getOwnerEmailFromModalWndw, marketplaceId);
            DBRequestOwnerManagements.OwnerManagements.DeleteRecordAboutOwnerManagements(getOwnerEmailFromModalWndw, marketplaceId);
            DbRequestOwners.DBOwners.DeleteCreatedUserOwner(getOwnerEmailFromModalWndw, marketplaceId);

            #endregion

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("AddBuilding")]

        public void AddBuilding()
        {
            #region Preconditions Test

            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsMarketplaceAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyMarketplaceAdminUserName(getUserNameCompare, getUserNameRoleCompare);

            #endregion

            #region Test

            Pages.ListOfBuildings
                .ClickButtonAddBuilding();
            Pages.NewBuilding
                .VerifyTitleNewBuildingPg()
                .ClickDropDownMenuBrokerSelect()
                .EnterAddressNewBuilding()
                .EnterBuildingLlcNamesDescription();
            KeyBoardActions.ClickTab();
            Pages.NewBuilding
                .ClickButtonSelectPetPolicies();
            Pages.ModalWindowPetPolicies
                .VerifyTitlePetPoliciesMdlWndw()
                .SelectItemPetPolocies(ItemsPetPolicies.PETS_FEE, " ")
                .SelectItemPetPolocies(ItemsPetPolicies.CATS_ONLY, " ")
                .SelectItemPetPolocies(ItemsPetPolicies.SMALL_PETS_ALLOWED, " ")
                .SelectItemPetPolocies(ItemsPetPolicies.CASE_BY_CASE, " ")
                .SelectItemPetPolocies(ItemsPetPolicies.ALL_PETS_ALLOWED, " ")
                .SelectItemPetPolocies(ItemsPetPolicies.NO_PETS, " ")
                .ClickButtonSave();
            Pages.NewBuilding
                .EnterCreditScreeningFee()
                .SelectPaymentsMethodsNwBldngPage()
                .ClickButtonGeneralNextNwBldngPg()
                .ClickFieldInputSearchForAmenitiesNwBldngPg()
                .SelectAmenitiesForBuilding(ListOfAmenitiesForBuildingAdminsPage.FIRST_TAG, " ")
                .SelectAmenitiesForBuilding(ListOfAmenitiesForBuildingAdminsPage.FIRST_TAG, " ")
                .SelectAmenitiesForBuilding(ListOfAmenitiesForBuildingAdminsPage.FIRST_TAG, " ")
                .SelectAmenitiesForBuilding(ListOfAmenitiesForBuildingAdminsPage.FIRST_TAG, " ")
                .SelectAmenitiesForBuilding(ListOfAmenitiesForBuildingAdminsPage.FIRST_TAG, " ")
                .ClickButtonGeneralNextNwBldngPg()
                .ClickButtonAddLockForAccessNwBldngPg();

            string copyActualNameLocation = Pages.NewBuilding.CopyNameLocation();

            Pages.NewBuilding
                .VerifyLocationMainAccessNewBuildingPg(copyActualNameLocation)
                .AddItemAccessTypePinCodeForAccessNwBldngPg();
            Pages.NewBuilding
                .ClickButtonAddLockForAccessNwBldngPg();

            string copyActualNameLocationTwo = Pages.NewBuilding.CopyNameLocation();

            Pages.NewBuilding
                .VerifyLocationApartmentAccessNewBuildingPg(copyActualNameLocationTwo)
                .AddItemAccessTypeNoteForAccessNwBldngPg()
                .ClickButtonAddLockForAccessNwBldngPg()
                .AddItemAccessTypeCabForAccessNwBldngPg();

            string copyActualNameCab = Pages.NewBuilding.GetNameCabTypeAccessFromTable();
            string copyActualNameNote = Pages.NewBuilding.GetNameNoteTypeAccessFromTable();
            string copyActualNamePinCode = Pages.NewBuilding.GetNamePinCodeTypeAccessFromTable();

            Pages.NewBuilding
                .VerifyTypeAccessFromTable(copyActualNameCab, copyActualNameNote, copyActualNamePinCode);
            Pages.NewBuilding
                .ClickButtonGeneralNextNwBldngPg()
                .ClickButtonAddSpecialsNwBldngPg()
                .AddConcessionSpecialsNwBldngPg();

            string getNameConcession = Pages.NewBuilding.GetNameConcessionFromTable();

            Pages.NewBuilding
                .VerifyNameSpecialsConcessionInTableNewBuildingPg(getNameConcession)
                .ClickTabFreeStuffSpecialsNwBldngPg()
                .ClickButtonAddSpecialsNwBldngPg()
                .AddFreeStuffSpecialsNwBldngPg()
                .ClickButtonGeneralNextNwBldngPg();
            Pages.NewBuilding
                //.SelectTabOnNewBuildingsPg(TabsOnNewBuildingPage.TAB_IMAGES, " ")
                .UploadImagesForNewBuilding()
                .ClickButtonSaveNwBldngPg()
                .VerifyMessageSavedSuccessfullyBuildingNwBldngPg();

            WaitUntil.WaitSomeInterval(5000);

            #endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("AddApartment")]

        public void AddApartment()
        {
            #region Preconditions Test

            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsMarketplaceAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyMarketplaceAdminUserName(getUserNameCompare, getUserNameRoleCompare);

            #endregion

            #region Test

            Pages.ListOfBuildings
                .SelectItemFirstBuildingOnPage();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage()
                .ClickTabApartmentsBldngVwPg();
            KeyBoardActions.ScrollToDown();
            Pages.BuildingView
                .ClickButtonAddInTabApartmentsBldngVwPg();
            Pages.AddApartments
                .VerifyTitleAddApartmentsPage();

            string getBuildingNameAddApartmentsPage = Pages.AddApartments.GetBuildingNameAddApartmentsPage();

            Pages.AddApartments
                .VerifyBuildingNameAddApartmentsPage(getBuildingNameAddApartmentsPage)
                .EnterUnitNumberBedsBathsSqFoot()
                .EnterLeasePriceSecurityDeposit();

            string getLeasePrice = Pages.AddApartments.GetLeasePriceAddApartmentsPage();
            string getSecurityDeposit = Pages.AddApartments.GetSecurityDepositAddApartmentsPage();

            Pages.AddApartments
                .VerifySecurityDepositAddApartmentsPage(getLeasePrice, getSecurityDeposit);

            string getMonthlyRentsPrePayment = Pages.AddApartments.GetMonthlyRentsPrePaymentAddApartmentsPage();

            Pages.AddApartments
                .VerifyMonthlyRentsPrePaymentAddApartmentsPage(getMonthlyRentsPrePayment)
                .EnterFieldInputFloorAddAprtmntsUnitsPage()
                .SelectStatusVacantAddAprtmntsUnitsPage()
                .SelectAgentAddAprtmntsUnitsPage();
                //.SelectDateAvailableFromAprtmntsUnitsPage();

            string getApartmentType = Pages.AddApartments.GetApartmentTypeAddApartmentsPage();

            Pages.AddApartments
                .VerifyApartmentTypeAddApartmentsPage(getApartmentType);

            string getgetApartmentHoldDeposit = Pages.AddApartments.GetApartmentHoldDepositAddApartmentsPage();

            KeyBoardActions.ScrollToDown();
            Pages.AddApartments
                .VerifyApartmentHoldDepositAddApartmentsPage(getgetApartmentHoldDeposit)
                .ClickButtonPaymentMethodsAddAprtmntsUnitsPage();
            Pages.ModalWindowPaymentOptions
                .VerifyTitlePaymentOptionsMdlWndwOptns()
                .SelectPaymentsMethodsNwBldngPg();

            string getRentalTerms = Pages.AddApartments.GetRentalTermsAddApartmentsPage();

            Pages.AddApartments
                .VerifyRentalTermsAddApartmentsPage(getRentalTerms);

            string getThreeRecentPaystubs = Pages.AddApartments.GetRequiredDocumentsThreeRecentPaystubsAddApartmentsPage();
            string getPhotoId = Pages.AddApartments.GetRequiredDocumentsPhotoIdAddApartmentsPage();
            string getTwoMostRecentBankStatements = Pages.AddApartments.GetRequiredDocumentsTwoMostRecentBankStatementsAddApartmentsPage();
            string getMostRecentWTwoOrOneZeroNineNine = Pages.AddApartments.GetRequiredDocumentsMostRecentWTwoOrOneZeroNineNineAddApartmentsPage();

            Pages.AddApartments
                .VerifyRequiredDocumentsByDefaultAddApartmentsPage(getThreeRecentPaystubs, getPhotoId, getTwoMostRecentBankStatements, getMostRecentWTwoOrOneZeroNineNine)
                .EnterDescriptionInternalNotesAddAprtmntsUnitsPage()
                .ClickButtonGeneralNextAddAprtmntsgPg()
                .ClickFieldInputSearchForAmenitiesAddAprtmntsgPg()
                .SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ")
                .SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ")
                .SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ")
                .SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ")
                .SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ")
                .ClickButtonGeneralNextAddAprtmntsgPg();

            WaitUntil.WaitSomeInterval(5000);

            #endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("CreateApplicationWithTenantAppAddedToSystemViaButtonPlusApplication")]

        #region Preconditions

        //Ќужно учесть количество слов дл€ Regex в коротком адресе дома и номер юнита, например, "1 Washington Square #4".
        //” апартамента должно быть только одно заначение в поле "Rental terms".

        #endregion

        public void CreateApplicationWithTenantAppAddedToSystemViaButtonPlusApplication()
        {
            #region Preconditions Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;
            string buildingAddress = "2 Washington Square";
            string unitNumber = "1";
            string emailTenant = TestDataForWebSiteTenant.EMAIL_TENANT_APPLICANT;

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsMarketplaceAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyMarketplaceAdminUserName(getUserNameCompare, getUserNameRoleCompare);
            Pages.SideBarLandlord
                .ClickButtonApplicationsSidebar();

            #endregion

            #region Test

            Pages.ListOfApplications
                .ClickButtonPlusApplication();
            Pages.ModalWndwCreateApplication
                .VerifyTitleCreateApplicationModalWndw()
                .EnterExistEmailInFieldMainApplicantEmailAddressModalWndw();

            string getEmailStepFirstActual = Pages.ModalWndwCreateApplication.GetEmailStepFirst();

            Pages.ModalWndwCreateApplication
                .ClickButtonNextInFirstStepModalWndw()
                .EnterUnitShortAddressInFieldUnitAddressModalWndw();

            string getUnitAddressStepSecondActual = Pages.ModalWndwCreateApplication.GetUnitAddressStepSecond();
            string getShortAddress = Pages.ModalWndwCreateApplication.GetShortUnitAddressStepSecond();
            string getUnitNumberActuaL = Pages.ModalWndwCreateApplication.GetUnitNumberStepSecond();

            Pages.ModalWndwCreateApplication
                .ClickButtonNextInFirstStepModalWndw();

            string getEmailStepThirdActual = Pages.ModalWndwCreateApplication.GetEmailStepThird();
            string getUnitAddressStepThirdActual = Pages.ModalWndwCreateApplication.GetUnitAddressStepThird();

            Pages.ModalWndwCreateApplication
                .VerifyEmailAndUnitAddress(getEmailStepFirstActual, getUnitAddressStepSecondActual, getEmailStepThirdActual, getUnitAddressStepThirdActual);

            var getLeasePriceFromDb = DBRequestPrices.Prices.GetLeasePrice(getShortAddress, getUnitNumberActuaL, marketplaceId).LeasePrice;
            var getSecurityDepositFromDb = DBRequestPrices.Prices.GetSecurityDeposit(getShortAddress, getUnitNumberActuaL, marketplaceId).DepositPrice;
            var getMonthlyRentsPrePaymentFromDb = DBRequestPrices.Prices.GetMonthlyRentsPrePayment(getShortAddress, getUnitNumberActuaL, marketplaceId).PaidMonths;
            var getRentalTermsFromDb = DBRequestApartments.Apartments.GetLeaseDurationForApartment(getShortAddress, getUnitNumberActuaL, marketplaceId).LeaseDuration;

            Pages.ModalWndwCreateApplication
                .EnterPriceFieldInputRequestedOfferPriceModalWndw()
                .SelectDateAvailableForCreateApplicationModalWndwViaListOfApplication();

            int getLeasePriceActual = Pages.ModalWndwCreateApplication.GetLeasePriceStepThirdFromUi();
            int getSecurityDepositActual = Pages.ModalWndwCreateApplication.GetSecurityDepositStepThirdFromUi();
            int getMonthlyRentsPrePaymentActual = Pages.ModalWndwCreateApplication.GetMonthlyRentsPrePaymentStepThirdFromUi();
            string getRentalTermsActual = Pages.ModalWndwCreateApplication.GetRentalTermsStepThirdFromUi();

            Pages.ModalWndwCreateApplication
                .AddRequestedWorkForModalWndw()
                .EnterTextInFieldRefferalDetailsModalWndw()
                .AddConcessionForModalWndw();

            decimal getNetEffectiveActualFromCrtApplctn = Pages.ModalWndwCreateApplication.GetNetEffectiveStepThirdFromUi();

            Pages.ModalWndwCreateApplication
                .ClickButtonCreateStepThreeModalWndw()
                .VerifyMessageStepFourModalWndw()
                .ClickButtonCloseStepFourModalWndwModalWndw();

            Pages.ListOfApplications
                .SelectFirstItemInLitsOFApplications();
            Pages.ApplicationDetail
                .VerifyTitleApplicationDetailPg();

            decimal getNetRentActualApplctnDtlPg = Pages.ApplicationDetail.GetNetRentApplctnDtlPg();

            Pages.ApplicationDetail
                .VerifyNetRent(getNetEffectiveActualFromCrtApplctn, getNetRentActualApplctnDtlPg);
            Pages.ModalWndwCreateApplication
                .VerifyFieldsAutocompleteInStepThird((int)getLeasePriceFromDb, (int)getSecurityDepositFromDb, getMonthlyRentsPrePaymentFromDb, getRentalTermsFromDb, getLeasePriceActual, getSecurityDepositActual, getMonthlyRentsPrePaymentActual, getRentalTermsActual);

            #endregion

            #region Postconditions

            var apartmentId = DBRequestApartments.Apartments.GetIdByUnitNumberAndBuildingAddressForApartment(buildingAddress, unitNumber, marketplaceId).Id;
            Console.WriteLine($"ApartmentId: {apartmentId}");
            var apartmentApplicationId = DBRequestApartmentApplications.ApartmentApplications.GetApartmentApplicationIdByApartmentIdTenantEmail(apartmentId, emailTenant, marketplaceId).Id;
            Console.WriteLine($"ApartmentApplicationId: {apartmentApplicationId}");
            DBRequestApartmentApplications.ApartmentApplications.DeleteApartmentApplicationWithAlreadyCrtdTenantApplicant(apartmentId, apartmentApplicationId, emailTenant, marketplaceId);


            #endregion

            WaitUntil.WaitSomeInterval(3000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("CreateApplicationWithTenantsAppOccGuarTenantsAddedToSystemViiaButtonPlusApplication")]

        #region Preconditions

        //Ќужно учесть количество слов дл€ Regex в коротком адресе дома и номер юнита, например, "1 Washington Square #4".
        //” апартамента должно быть только одно заначение в поле "Rental terms".

        #endregion

        public void CreateApplicationWithTenantsAppOccGuarTenantsAddedToSystemViiaButtonPlusApplication()
        {
            #region Preconditions Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;
            string buildingAddress = "2 Washington Square";
            string unitNumber = "1";
            string emailTenantCreator = TestDataForWebSiteTenant.EMAIL_TENANT_APPLICANT;
            string emailTenantOccupant = TestDataForWebSiteTenant.EMAIL_CURRENT_OCCUPANT_ONE;
            string emailTenantGuarantor = TestDataForWebSiteTenant.EMAIL_GUARANTOR;

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsMarketplaceAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyMarketplaceAdminUserName(getUserNameCompare, getUserNameRoleCompare);
            Pages.SideBarLandlord
                .ClickButtonApplicationsSidebar();

            #endregion

            #region Test

            Pages.ListOfApplications
                .ClickButtonPlusApplication();
            Pages.ModalWndwCreateApplication
                .VerifyTitleCreateApplicationModalWndw()
                .EnterExistEmailInFieldMainApplicantEmailAddressModalWndw();

            string getEmailStepFirstActual = Pages.ModalWndwCreateApplication.GetEmailStepFirst();

            Pages.ModalWndwCreateApplication
                .ClickButtonNextInFirstStepModalWndw()
                .EnterUnitShortAddressInFieldUnitAddressModalWndw();

            string getUnitAddressStepSecondActual = Pages.ModalWndwCreateApplication.GetUnitAddressStepSecond();
            string getShortAddress = Pages.ModalWndwCreateApplication.GetShortUnitAddressStepSecond();
            string getUnitNumberActuaL = Pages.ModalWndwCreateApplication.GetUnitNumberStepSecond();

            Pages.ModalWndwCreateApplication
                .ClickButtonNextInFirstStepModalWndw();

            string getEmailStepThirdActual = Pages.ModalWndwCreateApplication.GetEmailStepThird();
            string getUnitAddressStepThirdActual = Pages.ModalWndwCreateApplication.GetUnitAddressStepThird();

            Pages.ModalWndwCreateApplication
                .VerifyEmailAndUnitAddress(getEmailStepFirstActual, getUnitAddressStepSecondActual, getEmailStepThirdActual, getUnitAddressStepThirdActual);

            var getLeasePriceFromDb = DBRequestPrices.Prices.GetLeasePrice(getShortAddress, getUnitNumberActuaL, marketplaceId).LeasePrice;
            var getSecurityDepositFromDb = DBRequestPrices.Prices.GetSecurityDeposit(getShortAddress, getUnitNumberActuaL, marketplaceId).DepositPrice;
            var getMonthlyRentsPrePaymentFromDb = DBRequestPrices.Prices.GetMonthlyRentsPrePayment(getShortAddress, getUnitNumberActuaL, marketplaceId).PaidMonths;
            var getRentalTermsFromDb = DBRequestApartments.Apartments.GetLeaseDurationForApartment(getShortAddress, getUnitNumberActuaL, marketplaceId).LeaseDuration;

            Pages.ModalWndwCreateApplication
                .EnterPriceFieldInputRequestedOfferPriceModalWndw()
                .SelectDateAvailableForCreateApplicationModalWndwViaListOfApplication();

            int getLeasePriceActual = Pages.ModalWndwCreateApplication.GetLeasePriceStepThirdFromUi();
            int getSecurityDepositActual = Pages.ModalWndwCreateApplication.GetSecurityDepositStepThirdFromUi();
            int getMonthlyRentsPrePaymentActual = Pages.ModalWndwCreateApplication.GetMonthlyRentsPrePaymentStepThirdFromUi();
            string getRentalTermsActual = Pages.ModalWndwCreateApplication.GetRentalTermsStepThirdFromUi();

            Pages.ModalWndwCreateApplication
                .AddRequestedWorkForModalWndw()
                .EnterTextInFieldRefferalDetailsModalWndw()
                .AddConcessionForModalWndw();

            decimal getNetEffectiveActualFromCrtApplctn = Pages.ModalWndwCreateApplication.GetNetEffectiveStepThirdFromUi();

            Pages.ModalWndwCreateApplication
                .ClickButtonCreateStepThreeModalWndw()
                .VerifyMessageStepFourModalWndw()
                .ClickButtonAddApplicantStepFourModalWndw();
            Pages.ModalWndwAddAApplicant
                .VerifyTitleCreateApplicationModalWndw()
                .EnterEmailTenantOccupant()
                .ClickButtonPlusAnotherApplicant()
                .EnterEmailTenantGuarantor()
                .ClickSecondCheckTheBoxThisIGuarantor()
                .ClickButtonAdd()
                .VerifyMessageAddedApplicantsToApplicationMdlWndwAddAApplicant();
            Pages.ListOfApplications
                .SelectFirstItemInLitsOFApplications();
            Pages.ApplicationDetail
                .VerifyTitleApplicationDetailPg();

            decimal getNetRentActualApplctnDtlPg = Pages.ApplicationDetail.GetNetRentApplctnDtlPg();

            Pages.ApplicationDetail
                .VerifyNetRent(getNetEffectiveActualFromCrtApplctn, getNetRentActualApplctnDtlPg);
            Pages.ModalWndwCreateApplication
                .VerifyFieldsAutocompleteInStepThird((int)getLeasePriceFromDb, (int)getSecurityDepositFromDb, getMonthlyRentsPrePaymentFromDb, getRentalTermsFromDb, getLeasePriceActual, getSecurityDepositActual, getMonthlyRentsPrePaymentActual, getRentalTermsActual);

            #endregion

            #region Postconditions

            var apartmentId = DBRequestApartments.Apartments.GetIdByUnitNumberAndBuildingAddressForApartment(buildingAddress, unitNumber, marketplaceId).Id;
            Console.WriteLine($"ApartmentId: {apartmentId}");
            var apartmentApplicationId = DBRequestApartmentApplications.ApartmentApplications.GetApartmentApplicationIdByApartmentIdTenantEmail(apartmentId, emailTenantCreator, marketplaceId).Id;
            Console.WriteLine($"ApartmentApplicationId: {apartmentApplicationId}");
            DBRequestApartmentApplications.ApartmentApplications.DeleteApartmentApplicationWithTenantsAppOccGuarAlreadyCreated(apartmentId, apartmentApplicationId, emailTenantCreator, emailTenantOccupant, emailTenantGuarantor, marketplaceId);

            #endregion

            WaitUntil.WaitSomeInterval(3000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("CreateApplicationWithTenantsAppOccGuarTenantsNotAddedToSystemViaButtonPlusApplication")]

        #region Preconditions

        //Ќужно учесть количество символов дл€ Regex в коротком адресе дома и номер юнита, например, "1 Washington Square #4".
        //” апартамента должно быть только одно заначение в поле "Rental terms".

        #endregion

        public void CreateApplicationWithTenantsAppOccGuarTenantsNotAddedToSystemViaButtonPlusApplication()
        {
            #region Preconditions Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;
            string buildingAddress = "2 Washington Square";
            string unitNumber = "1";
            //string emailTenantCreator = "task1587acre@putsbox.com";
            //string emailTenantOccupant = "task1587acre@putsbox.com";
            //string emailTenantGuarantor = "task1587acre@putsbox.com";
            string emailTenantCreator = TestDataForWebSiteTenant.EMAIL_TENANT_CREATOR_NOT_CREATED;
            string emailTenantOccupant = TestDataForWebSiteTenant.EMAIL_TENANT_OCCUPANT_NOT_CREATED;
            string emailTenantGuarantor = TestDataForWebSiteTenant.EMAIL_TENANT_GUARANTOR_NOT_CREATED;

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsMarketplaceAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyMarketplaceAdminUserName(getUserNameCompare, getUserNameRoleCompare);
            Pages.SideBarLandlord
                .ClickButtonApplicationsSidebar();

            #endregion

            #region Test

            Pages.ListOfApplications
                .ClickButtonPlusApplication();
            Pages.ModalWndwCreateApplication
                .VerifyTitleCreateApplicationModalWndw()
                .EnterNewEmailTenantAppOccGuarInFieldMainApplicantEmailAddressModalWndw();

            string getEmailStepFirstActual = Pages.ModalWndwCreateApplication.GetEmailStepFirst();
            string partEmailPutsBoxTenantCreator = Pages.ModalWndwCreateApplication.CopyEmailBeforeDogFromMdlWndwCreateApplicationStepFirst();

            Pages.ModalWndwCreateApplication
                .ClickButtonNextInFirstStepModalWndw()
                .EnterUnitShortAddressInFieldUnitAddressModalWndw();

            string getUnitAddressStepSecondActual = Pages.ModalWndwCreateApplication.GetUnitAddressStepSecond();
            string getShortAddress = Pages.ModalWndwCreateApplication.GetShortUnitAddressStepSecond();
            string getUnitNumberActuaL = Pages.ModalWndwCreateApplication.GetUnitNumberStepSecond();

            Pages.ModalWndwCreateApplication
                .ClickButtonNextInFirstStepModalWndw();

            string getEmailStepThirdActual = Pages.ModalWndwCreateApplication.GetEmailStepThird();
            string getUnitAddressStepThirdActual = Pages.ModalWndwCreateApplication.GetUnitAddressStepThird();

            Pages.ModalWndwCreateApplication
                .VerifyEmailAndUnitAddress(getEmailStepFirstActual, getUnitAddressStepSecondActual, getEmailStepThirdActual, getUnitAddressStepThirdActual);

            var getLeasePriceFromDb = DBRequestPrices.Prices.GetLeasePrice(getShortAddress, getUnitNumberActuaL, marketplaceId).LeasePrice;
            var getSecurityDepositFromDb = DBRequestPrices.Prices.GetSecurityDeposit(getShortAddress, getUnitNumberActuaL, marketplaceId).DepositPrice;
            var getMonthlyRentsPrePaymentFromDb = DBRequestPrices.Prices.GetMonthlyRentsPrePayment(getShortAddress, getUnitNumberActuaL, marketplaceId).PaidMonths;
            var getRentalTermsFromDb = DBRequestApartments.Apartments.GetLeaseDurationForApartment(getShortAddress, getUnitNumberActuaL, marketplaceId).LeaseDuration;

            Pages.ModalWndwCreateApplication
                .EnterPriceFieldInputRequestedOfferPriceModalWndw()
                .SelectDateAvailableForCreateApplicationModalWndwViaListOfApplication();

            int getLeasePriceActual = Pages.ModalWndwCreateApplication.GetLeasePriceStepThirdFromUi();
            int getSecurityDepositActual = Pages.ModalWndwCreateApplication.GetSecurityDepositStepThirdFromUi();
            int getMonthlyRentsPrePaymentActual = Pages.ModalWndwCreateApplication.GetMonthlyRentsPrePaymentStepThirdFromUi();
            string getRentalTermsActual = Pages.ModalWndwCreateApplication.GetRentalTermsStepThirdFromUi();

            Pages.ModalWndwCreateApplication
                .ClickButtonCreateStepThreeModalWndw()
                .VerifyMessageStepFourModalWndw()
                .ClickButtonAddApplicantStepFourModalWndw();
            Pages.ModalWndwAddAApplicant
                .VerifyTitleCreateApplicationModalWndw()
                .EnterEmailTenantOccupantNotCreated()
                .ClickButtonPlusAnotherApplicant()
                .EnterEmailTenantGuarantorNotCreated()
                .ClickSecondCheckTheBoxThisIGuarantor();

            string partEmailOccupant = Pages.ModalWndwAddAApplicant.GetPartEmailAddressOccupant();


            Pages.ModalWndwAddAApplicant
                .ClickButtonAdd()
                .VerifyMessageAddedApplicantsToApplicationMdlWndwAddAApplicant();

            Pages.ModalWndwCreateApplication
                .VerifyFieldsAutocompleteInStepThird((int)getLeasePriceFromDb, (int)getSecurityDepositFromDb, getMonthlyRentsPrePaymentFromDb, getRentalTermsFromDb, getLeasePriceActual, getSecurityDepositActual, getMonthlyRentsPrePaymentActual, getRentalTermsActual);

            Pages.JScriptExecutorHelper
                .OpenNewTab()
                .OpenPutsBox(Pages.PutsBox.TitleLetterCreateAdminMySpace, partEmailPutsBoxTenantCreator);
            Pages.PutsBox
                .VerifyTitleLetterCreateTenant()
                .ClickButtonBodyHtml()
                .ClickButtonConfirmEmailForTenant();
            Pages.ModalWindowPleaseTellUsYourName
                .VerifyTitleHowShallWeCallYouMdlWndw()
                .EnterFirstName()
                .EnterLastName();

            string firstNameFromModalWindowHowShallWeCallYou = Pages.ModalWindowPleaseTellUsYourName.GetFirstNameFromModalWindowHowShallWeCallYou();
            string lastNameFromModalWindowHowShallWeCallYou = Pages.ModalWindowPleaseTellUsYourName.GetLastNameFromModalWindowHowShallWeCallYou();

            Pages.ModalWindowPleaseTellUsYourName
                .ClickButtonSaveMdlWndw();
            Pages.MyAccountCazamioTenant
                .ClickTabAccountOnMyAccntPg()
                .ClickButtonEditMyAccntPgTabAccnt();
                //.VerifyEmailNewTenant(getEmailStepFirstActual);
            Pages.HeaderCazamioTenant
                .LogOutFromAccountViaHeader();
            //ѕодтвердить тенанта окупанта
            Pages.JScriptExecutorHelper
                .OpenNewTab()
                .OpenPutsBox(Pages.PutsBox.TitleLetterCreateAdminMySpace, partEmailOccupant);
            Pages.PutsBox
                .VerifyTitleLetterCreateTenant()
                .ClickButtonBodyHtml()
                .ClickButtonConfirmEmailForTenant();
            Pages.ModalWindowPleaseTellUsYourName
                .VerifyTitleHowShallWeCallYouMdlWndw()
                .EnterFirstName()
                .EnterLastName();

            //string firstNameFromModalWindowHowShallWeCallYou = Pages.ModalWindowPleaseTellUsYourName.GetFirstNameFromModalWindowHowShallWeCallYou();
            //string lastNameFromModalWindowHowShallWeCallYou = Pages.ModalWindowPleaseTellUsYourName.GetLastNameFromModalWindowHowShallWeCallYou();

            Pages.ModalWindowPleaseTellUsYourName
                .ClickButtonSaveMdlWndw();
            Pages.MyAccountCazamioTenant
                .ClickTabAccountOnMyAccntPg()
                .ClickButtonEditMyAccntPgTabAccnt();
                //.VerifyEmailNewTenant(getEmailStepFirstActual);
            Pages.HeaderCazamioTenant
                .LogOutFromAccountViaHeader();
            
            #endregion

            #region Postconditions

            var apartmentId = DBRequestApartments.Apartments.GetIdByUnitNumberAndBuildingAddressForApartment(buildingAddress, unitNumber, marketplaceId).Id;
            Console.WriteLine($"ApartmentId: {apartmentId}");
            var apartmentApplicationId = DBRequestApartmentApplications.ApartmentApplications.GetApartmentApplicationIdByApartmentIdTenantEmail(apartmentId, emailTenantCreator, marketplaceId).Id;
            Console.WriteLine($"ApartmentApplicationId: {apartmentApplicationId}");
            DBRequestApartmentApplications.ApartmentApplications.DeleteApartmentApplicationWithTenantsAppOccGuarNotAddedToSystem(apartmentId, apartmentApplicationId, emailTenantCreator, emailTenantOccupant, emailTenantGuarantor, marketplaceId);
            DBRequestAspNetUsers.AspNetUsers.DeleteFromAspNetUsersNewlyCreatedTenantsAppOccGuarNotAddedToSystem(emailTenantCreator, emailTenantOccupant, emailTenantGuarantor, marketplaceId);

            #endregion

            WaitUntil.WaitSomeInterval(3000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("CreateApplicationWithTenantAppNotAddedToSystemViaButtonPlusApplication")]

        #region Preconditions

        //Ќужно учесть количество символов дл€ Regex в коротком адресе дома и номер юнита, например, "1 Washington Square #4".
        //” апартамента должно быть только одно заначение в поле "Rental terms".
        //¬ыставить дату дл€ Date Picker больше чем текуща€ дата.

        #endregion

        public void CreateApplicationWithTenantAppNotAddedToSystemViaButtonPlusApplication()
        {
            #region Preconditions Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;
            string buildingAddress = "2 Washington Square";
            string unitNumber = "1";
            string emailTenantCreator = TestDataForWebSiteTenant.EMAIL_TENANT_NOT_CREATED;

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsMarketplaceAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyMarketplaceAdminUserName(getUserNameCompare, getUserNameRoleCompare);
            Pages.ListOfBuildings
                .OpenPageApartmentView();

            #endregion

            #region Test

            Pages.ApartmentView
                .VerifyTitleApartmentViewPg()
                .ClickButtonPlusApplication();
            Pages.ModalWndwCreateApplication
                .VerifyTitleCreateApplicationModalWndw()
                .EnterNewEmailOnlyTenantAppInFieldMainApplicantEmailAddressModalWndw();

            string getEmailStepFirstActual = Pages.ModalWndwCreateApplication.GetEmailStepFirst();
            string partEmailPutsBox = Pages.ModalWndwCreateApplication.CopyEmailBeforeDogFromMdlWndwCreateApplicationStepFirst();

            Pages.ModalWndwCreateApplication
                .ClickButtonNextInFirstStepModalWndw();

            string getEmailStepThirdActual = Pages.ModalWndwCreateApplication .GetEmailStepThird();

            Pages.ModalWndwCreateApplication
                .VerifyEmail(getEmailStepFirstActual, getEmailStepThirdActual);
            Pages.ModalWndwCreateApplication
                .EnterPriceFieldInputRequestedOfferPriceModalWndw()
                .SelectDateAvailableForCreateApplicationModalWndwViaApartmentView();

            Pages.ModalWndwCreateApplication
                .AddRequestedWorkForModalWndw()
                .EnterTextInFieldRefferalDetailsModalWndw()
                .AddConcessionForModalWndw();

            decimal getNetEffectiveActualFromCrtApplctn = Pages.ModalWndwCreateApplication.GetNetEffectiveStepThirdFromUi();

            Pages.ModalWndwCreateApplication
                .ClickButtonCreateStepThreeModalWndw()
                .VerifyMessageStepFourModalWndw()
                .ClickButtonCloseStepFourModalWndwModalWndw();
            Pages.SideBarLandlord
                .ClickButtonApplicationsSidebar();
            Pages.ListOfApplications
                .SelectFirstItemInLitsOFApplications();
            Pages.ApplicationDetail
                .VerifyTitleApplicationDetailPg();

            decimal getNetRentActualApplctnDtlPg = Pages.ApplicationDetail.GetNetRentApplctnDtlPg();

            Pages.ApplicationDetail
                .VerifyNetRent(getNetEffectiveActualFromCrtApplctn, getNetRentActualApplctnDtlPg);

            Pages.JScriptExecutorHelper
                .OpenNewTab()
                .OpenPutsBox(Pages.PutsBox.TitleLetterCreateAdminMySpace, partEmailPutsBox);
            Pages.PutsBox
                .VerifyTitleLetterCreateTenant()
                .ClickButtonBodyHtml()
                .ClickButtonConfirmEmailForTenant();
            Pages.ModalWindowPleaseTellUsYourName
                .VerifyTitleHowShallWeCallYouMdlWndw()
                .EnterFirstName()
                .EnterLastName();

            string firstNameFromModalWindowHowShallWeCallYou = Pages.ModalWindowPleaseTellUsYourName.GetFirstNameFromModalWindowHowShallWeCallYou();
            string lastNameFromModalWindowHowShallWeCallYou = Pages.ModalWindowPleaseTellUsYourName.GetLastNameFromModalWindowHowShallWeCallYou();

            Pages.ModalWindowPleaseTellUsYourName
                .ClickButtonSaveMdlWndw();
            Pages.MyAccountCazamioTenant
                .ClickTabAccountOnMyAccntPg()
                .ClickButtonEditMyAccntPgTabAccnt();

            string getFirstNameFromMyAccount = Pages.MyAccountCazamioTenant.GetFirstNameFromMyAccount();
            string getLastNameFromMyAccount = Pages.MyAccountCazamioTenant.GetLastNameFromMyAccount();

            Pages.MyAccountCazamioTenant
                .VerifyEmailFirstLastNamesNewTenant(getEmailStepFirstActual, firstNameFromModalWindowHowShallWeCallYou, lastNameFromModalWindowHowShallWeCallYou, getFirstNameFromMyAccount, getLastNameFromMyAccount);

            #endregion

            #region Postconditions

            var apartmentId = DBRequestApartments.Apartments.GetIdByUnitNumberAndBuildingAddressForApartment(buildingAddress, unitNumber, marketplaceId).Id;
            Console.WriteLine($"ApartmentId: {apartmentId}");
            var apartmentApplicationId = DBRequestApartmentApplications.ApartmentApplications.GetApartmentApplicationIdByApartmentIdTenantEmail(apartmentId, emailTenantCreator, marketplaceId).Id;
            Console.WriteLine($"ApartmentApplicationId: {apartmentApplicationId}");
            DBRequestApartmentApplications.ApartmentApplications.DeleteApplicationAndNewlyCreatedTenantApplicantCreatedViaButtonPlusApplication(apartmentId, apartmentApplicationId, emailTenantCreator, marketplaceId);

            #endregion

            WaitUntil.WaitSomeInterval(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("EditAddressInMdlWndwEditApplication")]

        public void EditAddressInMdlWndwEditApplication()
        {
            #region

            string expexted = "2 Washington Square";

            #endregion

            #region Preconditions Test

            //Ќужно 
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsMarketplaceAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyMarketplaceAdminUserName(getUserNameCompare, getUserNameRoleCompare);
            Pages.SideBarLandlord
                .ClickButtonApplicationsSidebar();
            Pages.ListOfApplications
                .SelectItemTwoWashingtonSquareUnitTwo();

            #endregion

            #region Test

            Pages.ApplicationDetail
                .ClickButtonEditApplication();
            Pages.ModalWindowEditApplication
                .VerifyTitleEditApplicationMdlWndwEdtApplctn();

            string getShortBuildingAddressStepOneEditApp = Pages.ModalWindowEditApplication.GetDemo();
            //string getUnitNumberActuaL = Pages.ModalWndwCreateApplication.GetUnitNumberStepSecond();

            Pages.ModalWindowEditApplication
                .VerifyBuildingAddress(getShortBuildingAddressStepOneEditApp, expexted)
                .ClickButtonInFormEditApplication();

            #endregion

            WaitUntil.WaitSomeInterval(3000);
        }
    }
}