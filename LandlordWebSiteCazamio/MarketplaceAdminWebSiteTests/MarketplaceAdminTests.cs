using Allure.Commons;
using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
using CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfApplicationsPage;
using CazamioProject.DBHelpers;
using CazamioProject.DBHelpers.TableOwnerCommissionsStructure;
using CazamioProject.DBHelpers.TableOwnerManagements;
using CazamioProject.DBHelpers.TableOwnerPhoneNumbers;
using CazamioProject.DBHelpers.TablePrices;
using MarketplaceAdminTests;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Threading;

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
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsMarketplaceAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyMarketplaceAdminUserName(getUserNameCompare, getUserNameRoleCompare);

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
            #region Preconditions

            string marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

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
               .OpenPutsBox(Pages.PutsBox.TitleLetterCreateAdmin, getEmailBeforeDog);
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
            #region Preconditions

            string marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

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
                .OpenPutsBox(Pages.PutsBox.TitleLetterCreateAdmin, partEmailPutsBox);
            Pages.PutsBox
                .VerifyTitleLetterCreateBroker()
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
        [AllureSubSuite("CreateOwner")]

        public void CreateOwner()
        {
            #region Preconditions

            string marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            #endregion

            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsMarketplaceAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyMarketplaceAdminUserName(getUserNameCompare, getUserNameRoleCompare)
                .ClickButtonOwnersSidebar();
            Pages.ListOfOwners
                .ClickButtonCreateOwner();
            Pages.ModalWndwCreateNewOwner
                .VerifyTitleCreateANewOwner()
                .EnterCompanyName()
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
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsMarketplaceAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyMarketplaceAdminUserName(getUserNameCompare, getUserNameRoleCompare);
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
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsMarketplaceAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyMarketplaceAdminUserName(getUserNameCompare, getUserNameRoleCompare);
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
                .SelectAgentAddAprtmntsUnitsPage()
                .SelectDateAvailableFromAprtmntsUnitsPage();

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
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("CreateApplicationWhenTenantAddedToSystem")]

        #region Preconditions

        //Нужно учесть количество символов для Regex в коротком адресе дома и номер юнита, например, "1 Washington Square #4".
        
        #endregion

        public void CreateApplicationWhenTenantAddedToSystem()
        {
            #region Preconditions

            string marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            #endregion

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
                .ClickButtonPlusApplication();
            Pages.ModalWndwCreateAApplication
                .VerifyTitleCreateApplicationModalWndw()
                .EnterEmailInFieldMainApplicantEmailAddressModalWndw();

            string getEmailStepFirstActual = Pages.ModalWndwCreateAApplication.GetEmailStepFirst();

            Pages.ModalWndwCreateAApplication
                .ClickButtonNextModalWndw();

            string getUnitAddressStepSecondActual = Pages.ModalWndwCreateAApplication.GetUnitAddressStepSecond();
            string getShortAddress = Pages.ModalWndwCreateAApplication.GetShortUnitAddressStepSecond();
            string getUnitNumberActuaL = Pages.ModalWndwCreateAApplication.GetUnitNumberStepSecond();

            Pages.ModalWndwCreateAApplication
                .ClickButtonNextModalWndw();

            string getEmailStepThirdActual = Pages.ModalWndwCreateAApplication.GetEmailStepThird();
            string getUnitAddressStepThirdActual = Pages.ModalWndwCreateAApplication.GetUnitAddressStepThird();

            Pages.ModalWndwCreateAApplication
                .VerifyEmailAndUnitAddress(getEmailStepFirstActual, getUnitAddressStepSecondActual, getEmailStepThirdActual, getUnitAddressStepThirdActual);

            var getLeasePrice = DBRequestPrices.Prices.GetLeasePrice(getShortAddress, getUnitNumberActuaL, marketplaceId);
            //Получить Security Deposit

            WaitUntil.WaitSomeInterval(3000);
        }
    }
}