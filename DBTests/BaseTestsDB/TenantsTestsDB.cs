using Allure.Commons;
using ApiTests.Base;
using CazamioProgect.Helpers;
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
using CazamioProject.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTests.BaseTestsDB
{
    [TestFixture]
    [AllureNUnit]

    public class TenantsTestsDB : Base
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBTenant")]
        [AllureSubSuite("RecordsAboutNewTenant")]

        public void NewTenantIdAndId()
        {
            string newTenant = DBTestDataForTenantMarketplaceOne.NEW_TENANT_FIRST_LAST_NAME;

            string tenantIdByEmail = DBRequestAspNetUsersOld.GetIdByEmailMarketplaceIdNewTenant(TestDataForWebSiteTenant.EMAIL_CURRENT_OCCUPANT_SECOND, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
            Console.WriteLine($"{tenantIdByEmail} :TenantId for new tenant {newTenant} from table AspNetUsers");

            string marketplaceIdTwo = DBRequestAspNetUsersOld.GetMarketplaceIdTwoByEmailMaxMarketplaceId(TestDataForWebSiteTenant.EMAIL_CURRENT_OCCUPANT_SECOND);
            Console.WriteLine($"{marketplaceIdTwo} :MarketplaceId for new tenant {newTenant} from table AspNetUsers");

            string marketplaceIdOne = DBRequestAspNetUsersOld.GetMarketplaceIdOneByEmailMinMarketplaceId(TestDataForWebSiteTenant.EMAIL_CURRENT_OCCUPANT_SECOND);
            Console.WriteLine($"{marketplaceIdOne} :MarketplaceId for new tenant {newTenant} from table AspNetUsers");

            string idLast = DBRequestTenantsOld.GetLastIdNewTenant();
            Console.WriteLine($"{idLast} :Id for new tenant {newTenant} from table Tenants");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBTenant")]
        [AllureSubSuite("RecordsAboutNewTenant")]

        public void RecordsAboutNewTenant()
        {
            string newTenant = DBTestDataForTenantMarketplaceOne.NEW_TENANT_FIRST_LAST_NAME;

            string idLastTenantTenants = DBRequestTenantsOld.GetLastIdNewTenant();
            Console.WriteLine($"{idLastTenantTenants} :Id for new tenant {newTenant} from table Tenants");

            string idByEmailTenantTenants = DBRequestTenantsOld.GetIdByEmail(DBTestDataForTenantMarketplaceOne.NEW_TENANT_EMAIL);
            Console.WriteLine($"{idByEmailTenantTenants} :Id by email for new tenant {newTenant} from table Tenants");

            string marketplaceIdByEmailTenantTenants = DBRequestTenantsOld.GetMarketplaceIdByEmailUserId(DBTestDataForTenantMarketplaceOne.NEW_TENANT_EMAIL);
            Console.WriteLine($"{marketplaceIdByEmailTenantTenants} :MarketplaceId for new tenant {newTenant} from table Tenants");

            string marketplaceIdLastTenantAspNetUsers = DBRequestAspNetUsersOld.GetLastMarketplaceIdNewTenant();
            Console.WriteLine($"{marketplaceIdByEmailTenantTenants} :MarketplaceId for new tenant {newTenant} from table AspNetUsers");

            string emailConfirmedTenantAspNetUsers = DBRequestAspNetUsersOld.GetEmailComfirmedByEmail(DBTestDataForTenantMarketplaceOne.NEW_TENANT_EMAIL);
            Console.WriteLine($"{emailConfirmedTenantAspNetUsers} :EmailConfirmed for new tenant {newTenant} from table AspNetUsers");

            string userIdTenantTenants = DBRequestTenantsOld.GetLastUserIdNewTenant();
            Console.WriteLine($"{userIdTenantTenants} :UserId for new tenant {newTenant} from table Tenants");
            
            string userIdTenantAspNetUsers = DBRequestAspNetUsersOld.GetIdByEmailMarketplaceIdNewTenant(DBTestDataForTenantMarketplaceOne.NEW_TENANT_EMAIL, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
            Console.WriteLine($"{userIdTenantAspNetUsers} :Id for new tenant {newTenant} from table AspNetUsers");

            string idTenantAspNetUserRoles = DBTableAspNetUserRoles.GetLastRoleIdNewTenantByUserId();
            Console.WriteLine($"{idTenantAspNetUserRoles} :RoleId for new tenant {newTenant} from table AspNetUserRoles");

            string emailTenantAspNetUsers = DBRequestAspNetUsersOld.GetEmailByUserName(DBTestDataForTenantMarketplaceOne.NEW_TENANT_USER_NAME);
            Console.WriteLine($"{emailTenantAspNetUsers} :Email for new tenant {newTenant} from table AspNetUsers");

            string firstNameTenantAspNetUsers = DBRequestAspNetUsersOld.GetFirstNameByUserName(DBTestDataForTenantMarketplaceOne.NEW_TENANT_USER_NAME);
            Console.WriteLine($"{firstNameTenantAspNetUsers} :FirstName for new tenant {newTenant} from table AspNetUsers");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(idLastTenantTenants, idByEmailTenantTenants);
                Console.WriteLine($"Id a new tenant from table Tenants: {idLastTenantTenants} = {idByEmailTenantTenants} Id for tenant from table AspNetUsers");

                Assert.AreEqual(marketplaceIdByEmailTenantTenants, marketplaceIdLastTenantAspNetUsers);
                Console.WriteLine($"MarketplaceId a new tenant from table Tenants: {marketplaceIdByEmailTenantTenants} = {marketplaceIdLastTenantAspNetUsers} MarketplaceId for tenant from table AspNetUsers");

                Assert.AreEqual(emailConfirmedTenantAspNetUsers, DBTestDataGeneral.TRUE);
                Console.WriteLine($"EmailConfirmed a new tenant from table AspNetUsers: {emailConfirmedTenantAspNetUsers} = {DBTestDataGeneral.TRUE} MarketplaceId for tenant ER");

                Assert.AreEqual(userIdTenantTenants, userIdTenantAspNetUsers);
                Console.WriteLine($"UserId a new tenant from table Tenants: {userIdTenantTenants} = {userIdTenantAspNetUsers} UserId for tenant from table AspNetUsers");

                Assert.AreEqual(idTenantAspNetUserRoles, DBTestDataGeneral.ID_NAME_ROLE_TENANT);
                Console.WriteLine($"RoleId tenant for a new tenant AspNetUserRoles: {idTenantAspNetUserRoles} = {DBTestDataGeneral.ID_NAME_ROLE_TENANT} RoleId tenant for a new tenant ER");

                Assert.AreEqual(emailTenantAspNetUsers, DBTestDataForTenantMarketplaceOne.NEW_TENANT_EMAIL);
                Console.WriteLine($"Email a new tenant AspNetUsers: {emailTenantAspNetUsers} = {DBTestDataForTenantMarketplaceOne.NEW_TENANT_EMAIL} Email for a new tenant ER");

                Assert.AreEqual(firstNameTenantAspNetUsers, DBTestDataForTenantMarketplaceOne.NEW_TENANT_FIRST_NAME);
                Console.WriteLine($"FirstName a new tenant AspNetUsers: {firstNameTenantAspNetUsers} = {DBTestDataForTenantMarketplaceOne.NEW_TENANT_FIRST_NAME} FirstName a new tenant ER");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBTenant")]
        [AllureSubSuite("RecordsAboutNewTenant")]

        public void NewRecordsAboutBackgroundCheckCreditScreening()
        {
            string tenant = DBTestDataForTenantMarketplaceOne.NEW_TENANT_FIRST_LAST_NAME;

            string lastIdByEmail = DBTableTenantBackgroundChecks.GetLastIdByEmailMarketplaceId(DBTestDataForTenantMarketplaceOne.NEW_TENANT_EMAIL, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
            Console.WriteLine($"{lastIdByEmail} :Last Id CreditScreening by email {tenant} from table TenantBackgroundChecks");

            string lastId = DBTableTenantBackgroundChecks.GetLastId();
            Console.WriteLine($"{lastId} :Last Id CreditScreening {tenant} from table TenantBackgroundChecks");

            string lastIdCreditScreening = DBTableTenantBackgroundChecks.GetLastIdCreditScreeningByBackgroundCheckTypeTenantId(DBTestDataForTenantMarketplaceOne.NEW_TENANT_EMAIL, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO, DBTestDataGeneral.CREDIT_SCREENING);
            Console.WriteLine($"{lastIdCreditScreening} :Last Id by BackgroundCheckType TenantId for BackgroundCheck {tenant} from table TenantBackgroundChecks");

            string tenantIdByEmail = DBRequestAspNetUsersOld.GetIdByEmailMarketplaceIdNewTenant(DBTestDataForTenantMarketplaceOne.NEW_TENANT_EMAIL, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
            Console.WriteLine($"{tenantIdByEmail} :TenantId for new tenant {tenant} from table AspNetUsers");

            string lastIdByEmailBackgroundCheck = DBTableTenantBackgroundChecks.GetLastIdBackgroundCheckByTenantIdBackgroundCheckType(tenantIdByEmail, DBTestDataGeneral.BACKGROUND_CHECK);
            Console.WriteLine($"{lastIdByEmailBackgroundCheck} :Last Id by email for BackgroundCheck {tenant} from table TenantBackgroundChecks");

            string lastIdBackgroundCheck = DBTableTenantBackgroundChecks.GetLastIdBackgroundCheckBackgroundCheckType(DBTestDataGeneral.BACKGROUND_CHECK);
            Console.WriteLine($"{lastIdBackgroundCheck} :Last Id BackgroundCheck {tenant} from table BackgroundChecks");

            string nameBackgroundCheck = DBTableTenantBackgroundChecks.GetNameBackgroundCheckTypeById(lastIdByEmailBackgroundCheck);
            Console.WriteLine($"{nameBackgroundCheck} :Name this is BackgroundCheck {tenant} from table BackgroundChecks");

            string nameCreditScreening = DBTableTenantBackgroundChecks.GetNameBackgroundCheckTypeById(lastIdCreditScreening);
            Console.WriteLine($"{nameCreditScreening} :Name this is CreditScreening {tenant} from table BackgroundChecks");

            string passedBackgroundCheck = DBTableTenantBackgroundChecks.GetNameCheckStatusByIdBackgroundCheckType(lastIdBackgroundCheck, DBTestDataGeneral.BACKGROUND_CHECK);
            Console.WriteLine($"{passedBackgroundCheck} :Passed BackgroundCheck {tenant} from table BackgroundChecks");

            string passedCreditScreening = DBTableTenantBackgroundChecks.GetNameCheckStatusByIdBackgroundCheckType(lastIdCreditScreening, DBTestDataGeneral.CREDIT_SCREENING);
            Console.WriteLine($"{passedCreditScreening} :Passed CreditScreening {tenant} from table BackgroundChecks");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(lastIdByEmail, lastId);
                Console.WriteLine($"Last Id from table TenantBackgroundChecks: {lastIdByEmail} = {lastId} Last Id from table TenantBackgroundChecks");

                Assert.AreEqual(lastIdCreditScreening, lastId);
                Console.WriteLine($"Last Id for CreditScreening from table TenantBackgroundChecks: {lastIdCreditScreening} = {lastId} Last Id from table TenantBackgroundChecks");

                Assert.AreEqual(lastIdByEmailBackgroundCheck, lastIdBackgroundCheck);
                Console.WriteLine($"Last Id by email for BackgroundCheck from table TenantBackgroundChecks: {lastIdByEmailBackgroundCheck} = {lastIdBackgroundCheck} Last Id BackgroundCheck of a new BackgroundCheck");

                Assert.AreEqual(nameBackgroundCheck, DBTestDataGeneral.BACKGROUND_CHECK);
                Console.WriteLine($"Name BackgroundCheck from table BackgroundChecks: {nameBackgroundCheck} = {DBTestDataGeneral.BACKGROUND_CHECK} Name BackgroundCheck ER");

                Assert.AreEqual(nameCreditScreening, DBTestDataGeneral.CREDIT_SCREENING);
                Console.WriteLine($"Name CreditScreening from table BackgroundChecks: {nameCreditScreening} = {DBTestDataGeneral.CREDIT_SCREENING} Name CreditScreening ER");

                Assert.AreEqual(passedBackgroundCheck, DBTestDataGeneral.PASSED);
                Console.WriteLine($"Passed BackgroundCheck from table BackgroundChecks: {passedBackgroundCheck} = {DBTestDataGeneral.PASSED} Passed BackgroundCheck ER");

                Assert.AreEqual(passedCreditScreening, DBTestDataGeneral.PASSED);
                Console.WriteLine($"Passed CreditScreening from table BackgroundChecks: {passedCreditScreening} = {DBTestDataGeneral.PASSED} Passed CreditScreening ER");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBTenant")]
        [AllureSubSuite("RecordsInTableTenantExtractedIdentities")]

        public void RecordsInTableTenantExtractedIdentities()
        {
            string newTenant = DBTestDataForTenantMarketplaceOne.NEW_TENANT_FIRST_LAST_NAME;

            string firstNameNewTenant = DBTableTenantExtractedIdentities.GetFirstNameTenantByTenantId();
            Console.WriteLine($"{firstNameNewTenant} :First name a new tenant {newTenant} from table TenantExtractedIdentities");

            string lastNameNewTenant = DBTableTenantExtractedIdentities.GetLastNameTenantByTenantId();
            Console.WriteLine($"{lastNameNewTenant} :Last name a new tenant {newTenant} from table TenantExtractedIdentities");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(firstNameNewTenant, DBTestDataForTenantMarketplaceOne.NEW_TENANT_FIRST_NAME);
                Console.WriteLine($"First Name for a new tenant from table TenantExtractedIdentities AR: {firstNameNewTenant} = {DBTestDataForTenantMarketplaceOne.NEW_TENANT_FIRST_NAME} First Name for a new tenant from table TenantExtractedIdentities ER");

                Assert.AreEqual(lastNameNewTenant, DBTestDataForTenantMarketplaceOne.NEW_TENANT_LAST_NAME);
                Console.WriteLine($"Last Name for a new tenant from table TenantExtractedIdentities AR: {lastNameNewTenant} = {DBTestDataForTenantMarketplaceOne.NEW_TENANT_LAST_NAME} Last Name for a new tenant from table TenantExtractedIdentities ER");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBTenant")]
        [AllureSubSuite("NewLeaseSignedThreeTenantsIntableTenantLeases")]

        public void NewLeaseSignedThreeTenantsIntableTenantLeases()
        {
            string tenantApplicant = DBTestDataGeneral.NAME_ROLE_APPLICANT;
            string tenantOccupant = DBTestDataGeneral.NAME_ROLE_OCCUPANT;
            string tenantGuarantor = DBTestDataGeneral.NAME_ROLE_GUARANTOR;

            string tenantRay = TestDataForWebSiteTenant.FIRST_NAME_TENANT_APPLICANT;
            string tenantLiza = TestDataForWebSiteTenant.FIRST_NAME_OCCUPANT_ONE;
            string tenantJimmy = TestDataForWebSiteTenant.FIRST_NAME_GUARANTOR;

            string lastApartmentApplicationId = DBRequestTenantLeasesOLD.GetLastApartmentApplicationId();
            Console.WriteLine($"{lastApartmentApplicationId} :Last ApartmentApplicationId from table TenantLeases");

            string apartmentApplicationIdForApplicant = DBRequestTenantLeasesOLD.GetApartmentApplicationIdByIdTenantId(DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_TENANT_ID);
            Console.WriteLine($"{apartmentApplicationIdForApplicant} :ApartmentApplicationId for tenant {tenantRay} {tenantApplicant} from table TenantLeases");

            string apartmentApplicationIdForOccupant = DBRequestTenantLeasesOLD.GetApartmentApplicationIdByIdTenantId(DBTestDataForTenantMarketplaceOne.TENANT_OCCUPANT_LIZA_TENANT_ID);
            Console.WriteLine($"{apartmentApplicationIdForOccupant} :ApartmentApplicationId for tenant {tenantOccupant} {tenantLiza} from table TenantLeases");

            string apartmentApplicationIdForGuarantor = DBRequestTenantLeasesOLD.GetApartmentApplicationIdByIdTenantId(DBTestDataForTenantMarketplaceOne.TENANT_GUARANTOR_JIMMY_TENANT_ID);
            Console.WriteLine($"{apartmentApplicationIdForGuarantor} :ApartmentApplicationId for tenant {tenantGuarantor} {tenantJimmy} from table TenantLeases");

            string isLeaseSignedForApplicant = DBRequestTenantLeasesOLD.GetIsLeaseSignedByTenantIdApartmentApplicationId(DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_TENANT_ID, lastApartmentApplicationId);
            Console.WriteLine($"{isLeaseSignedForApplicant} :IsLeaseSigned for tenant {tenantRay} {tenantApplicant} from table TenantLeases");

            string isLeaseSignedForOccupant = DBRequestTenantLeasesOLD.GetIsLeaseSignedByTenantIdApartmentApplicationId(DBTestDataForTenantMarketplaceOne.TENANT_OCCUPANT_LIZA_TENANT_ID, lastApartmentApplicationId);
            Console.WriteLine($"{isLeaseSignedForOccupant} :IsLeaseSigned for tenant {tenantOccupant} {tenantLiza} from table TenantLeases");

            string isLeaseSignedForGuarantor = DBRequestTenantLeasesOLD.GetIsLeaseSignedByTenantIdApartmentApplicationId(DBTestDataForTenantMarketplaceOne.TENANT_GUARANTOR_JIMMY_TENANT_ID, lastApartmentApplicationId);
            Console.WriteLine($"{isLeaseSignedForGuarantor} :IsLeaseSigned for tenant {tenantGuarantor} {tenantJimmy} from table TenantLeases");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(lastApartmentApplicationId, apartmentApplicationIdForApplicant);
                Console.WriteLine($"ApartmentApplicationId last from table TenantLeases {apartmentApplicationIdForApplicant} = {apartmentApplicationIdForApplicant} :ApartmentApplicationId for {tenantRay} {tenantApplicant} from table TenantLeases");

                Assert.AreEqual(lastApartmentApplicationId, apartmentApplicationIdForOccupant);
                Console.WriteLine($"ApartmentApplicationId last from table TenantLeases {apartmentApplicationIdForApplicant} = {apartmentApplicationIdForOccupant} :ApartmentApplicationId for {tenantOccupant} {tenantLiza} from table TenantLeases");

                Assert.AreEqual(lastApartmentApplicationId, apartmentApplicationIdForGuarantor);
                Console.WriteLine($"ApartmentApplicationId last from table TenantLeases {apartmentApplicationIdForApplicant} = {apartmentApplicationIdForGuarantor} :ApartmentApplicationId for {tenantGuarantor} {tenantJimmy} from table TenantLeases");

                Assert.AreEqual(isLeaseSignedForApplicant, DBTestDataGeneral.TRUE);
                Console.WriteLine($"True IsLeaseSigned for tenant {tenantApplicant} from table TenantLeases {isLeaseSignedForApplicant} = {DBTestDataGeneral.TRUE} :ApartmentApplicationId for {tenantRay} {tenantApplicant} ER");

                Assert.AreEqual(isLeaseSignedForOccupant, DBTestDataGeneral.TRUE);
                Console.WriteLine($"True IsLeaseSigned for tenant {tenantOccupant} from table TenantLeases {isLeaseSignedForOccupant} = {DBTestDataGeneral.TRUE} :ApartmentApplicationId for {tenantOccupant} {tenantLiza} ER");

                Assert.AreEqual(isLeaseSignedForGuarantor, DBTestDataGeneral.TRUE);
                Console.WriteLine($"True IsLeaseSigned for tenant {tenantGuarantor} from table TenantLeases {isLeaseSignedForGuarantor} = {DBTestDataGeneral.TRUE} :ApartmentApplicationId for {tenantGuarantor} {tenantJimmy} ER");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBTenant")]
        [AllureSubSuite("RecordsAboutNewTenant")]

        public void NewRecordInTableTenantApartmentFavorities()
        {
            string tenantApplicant = TestDataForWebSiteTenant.FIRST_NAME_TENANT_APPLICANT;

            string idLastFavorites = DBTableTenantApartmentFavorites.GetLastId();
            Console.WriteLine($"{idLastFavorites} :Id last {tenantApplicant} from table TenantApartmentFavorites");

            string idFavoritesByEmail = DBTableTenantApartmentFavorites.GetLastIdByTenantIdEmail(TestDataForWebSiteTenant.EMAIL_TENANT_APPLICANT);
            Console.WriteLine($"{idFavoritesByEmail} :Id by email {tenantApplicant} from table TenantApartmentFavorites");

            string tenantIdNewTenantApartmentFavorites = DBTableTenantApartmentFavorites.GetLastTenantIdById();
            Console.WriteLine($"{tenantIdNewTenantApartmentFavorites} :TenantIdNewTenantApartmentFavorites {tenantApplicant} from table TenantApartmentFavorites");

            string apartmentIdFromTableApartments = DBRequestApartments.GetIdForUnitFromApartments(DBTestDataDBForAdmins.BUILDING_NAME, DBTestDataDBForAdmins.UNIT_NUMBER);
            Console.WriteLine($"{apartmentIdFromTableApartments} :ApartmentId {tenantApplicant} from table Apartments");

            string apartmentIdFromTableTenantApartmentFavorites = DBTableTenantApartmentFavorites.GetLastApartmentIdById();
            Console.WriteLine($"{apartmentIdFromTableTenantApartmentFavorites} :ApartmentId {tenantApplicant} from table TenantApartmentFavorites");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(idLastFavorites, idFavoritesByEmail);
                Console.WriteLine($"Id for a new favorities from table TenantApartmentFavorites: {idLastFavorites} = {idFavoritesByEmail} Id for a favorities from table TenantApartmentFavorites");

                Assert.AreEqual(tenantIdNewTenantApartmentFavorites, DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_USER_ID);
                Console.WriteLine($"TenantId for a new favorities from table TenantApartmentFavorites: {tenantIdNewTenantApartmentFavorites} = {DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_USER_ID} TenantId for a favorities ER");

                Assert.AreEqual(apartmentIdFromTableApartments, apartmentIdFromTableTenantApartmentFavorites);
                Console.WriteLine($"TenantId for a new apartment favorities from table TenantApartmentFavorites AR: {apartmentIdFromTableApartments} = {apartmentIdFromTableTenantApartmentFavorites} TenantId for a new apartment favorities from table TenantApartmentFavorites ER");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBTenant")]
        [AllureSubSuite("DeleteNewApplicationWithTenantCreatedViaCreateApplication")]

        public void DeleteNewApplicationWithTenantCreatedViaButtonPlusApplication()
        {
            #region Preconditions

            string buildingAddress = "2 Linden Street";
            string unitNumber = "62";

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;
            string emailTenant = "task1567n40t@putsbox.com";

            #endregion

            var apartmentId = DBRequestApartments.Apartments.GetIdByUnitNumberAndBuildingAddressForApartment(buildingAddress, unitNumber, marketplaceId).Id;
            Console.WriteLine($"ApartmentId: {apartmentId}");
            var apartmentApplicationId = DBRequestApartmentApplications.ApartmentApplications.GetApartmentApplicationIdByApartmentIdTenantEmail(apartmentId, emailTenant, marketplaceId).Id;
            Console.WriteLine($"ApartmentApplicationId: {apartmentApplicationId}");
            DBRequestTenantLeases.TenantLeases.DeleteRecordByApartmentApplicationId(apartmentApplicationId, emailTenant, marketplaceId);
            WaitUntil.WaitSomeInterval(100);
            DBRequestApplicationGeneralQuestions.ApplicationGeneralQuestions.DeleteRecordByApartmentApplicationId(apartmentApplicationId, emailTenant, marketplaceId);
            WaitUntil.WaitSomeInterval(100);
            DBRequestApplicationBasicInformation.ApplicationBasicInformation.DeleteRecordByApartmentApplicationId(apartmentApplicationId, emailTenant, marketplaceId);
            WaitUntil.WaitSomeInterval(100);
            DBRequestApplicationRequiredDocuments.ApplicationRequiredDocuments.DeleteRecordByApartmentApplicationId(apartmentApplicationId, emailTenant, marketplaceId);
            WaitUntil.WaitSomeInterval(100);
            DBRequestApplicationRentalHistories.ApplicationRentalHistories.DeleteRecordByApartmentApplicationId(apartmentApplicationId, emailTenant, marketplaceId);
            WaitUntil.WaitSomeInterval(100);
            DBRequestApplicationOccupations.ApplicationOccupations.DeleteRecordByApartmentApplicationId(apartmentApplicationId, emailTenant, marketplaceId);
            WaitUntil.WaitSomeInterval(100);
            DBRequestApplicationPrices.ApplicationPrices.DeleteRecordByApartmentApplicationId(apartmentApplicationId);
            WaitUntil.WaitSomeInterval(100);
            DBRequestApartmentApplicationProgress.ApartmentApplicationProgress.DeleteRecordByApartmentApplicationId(apartmentApplicationId, emailTenant, marketplaceId);
            WaitUntil.WaitSomeInterval(100);
            DBRequestApartmentApplications.ApartmentApplications.DeleteRecordByApartmentId(apartmentId, emailTenant, marketplaceId);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBTenant")]
        [AllureSubSuite("Demo")]

        public void DeleteNewTenantCreatedViaButtonPlusApplication()
        {
            #region Preconditions

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;
            string emailTenant = "task1567n40t@putsbox.com";

            #endregion

            DBRequestChatCursors.ChatCursors.DeleteRecordByEmailMarketplaceId(marketplaceId, emailTenant);
            WaitUntil.WaitSomeInterval(100);
            DBRequestApartmentHistories.ApartmentHistories.DeleteRecordByEmailMarketplaceId(marketplaceId, emailTenant);
            WaitUntil.WaitSomeInterval(100);
            DBRequestApartmentApplicationProgress.ApartmentApplicationProgress.DeleteRecordByEmailMarketplaceId(marketplaceId, emailTenant);
            WaitUntil.WaitSomeInterval(100);
            DBRequestApplicationPrices.ApplicationPrices.DeleteRecordByEmailMarketplaceId(marketplaceId, emailTenant);
            WaitUntil.WaitSomeInterval(100);
            DBRequestTenantLeases.TenantLeases.DeleteRecordByEmailMarketplaceId(marketplaceId, emailTenant);
            WaitUntil.WaitSomeInterval(100);
            DBRequestApartmentApplications.ApartmentApplications.DeleteRecordByEmailMarketplaceId(marketplaceId, emailTenant);
            WaitUntil.WaitSomeInterval(100);
            DBRequestTeants.Tenants.DeleteCreatedUserTenant(marketplaceId, emailTenant);
            WaitUntil.WaitSomeInterval(100);
            DBRequestAspNetUsers.AspNetUsers.DeleteCreatedUser(emailTenant, marketplaceId);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBTenant")]
        [AllureSubSuite("Demo")]

        public void Demo()
        {
            #region Preconditions

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;
            string emailTenant = "task1567n40t@putsbox.com";

            #endregion

            DBRequestChatCursors.ChatCursors.DeleteRecordByEmailMarketplaceId(marketplaceId, emailTenant);
            WaitUntil.WaitSomeInterval(100);
            DBRequestApartmentHistories.ApartmentHistories.DeleteRecordByEmailMarketplaceId(marketplaceId, emailTenant);
            WaitUntil.WaitSomeInterval(100);
            DBRequestApartmentApplicationProgress.ApartmentApplicationProgress.DeleteRecordByEmailMarketplaceId(marketplaceId, emailTenant);
            WaitUntil.WaitSomeInterval(100);
            DBRequestApplicationPrices.ApplicationPrices.DeleteRecordByEmailMarketplaceId(marketplaceId, emailTenant);
            WaitUntil.WaitSomeInterval(100);
            DBRequestTenantLeases.TenantLeases.DeleteRecordByEmailMarketplaceId(marketplaceId, emailTenant);
            WaitUntil.WaitSomeInterval(100);
            DBRequestApartmentApplications.ApartmentApplications.DeleteRecordByEmailMarketplaceId(marketplaceId, emailTenant);
            WaitUntil.WaitSomeInterval(100);
            DBRequestTeants.Tenants.DeleteCreatedUserTenant(marketplaceId, emailTenant);
            WaitUntil.WaitSomeInterval(100);
            DBRequestAspNetUsers.AspNetUsers.DeleteCreatedUser(emailTenant, marketplaceId);
        }
    }
}
