﻿using Allure.Commons;
using CazamioProgect.Helpers;
using CazamioProject.DBHelpers;
using CazamioProject.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.BaseTestsDBTenants
{
    [TestFixture]
    [AllureNUnit]

    public class TenantsTestsDB
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBTenant")]
        [AllureSubSuite("RecordsAboutNewTenant")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment:  new records about that the an apartemnt added in the favorities in the table "dbo.TenantApartmentFavorities".
        //Path to cheking's: 

        public void NewTenantIdAndId()
        {
            string newTenant = DBTestDataForTenantMarketplaceOne.NEW_TENANT_FIRST_LAST_NAME;

            string tenantIdByEmail = DBTenants.GetTenantIdByEmailForNewTenantFromAspNetUsers(TestDataForWebSiteTenant.EMAIL_CURRENT_OCCUPANT_SECOND, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
            Console.WriteLine($"{tenantIdByEmail} :TenantId for new tenant {newTenant} from table AspNetUsers");

            string marketplaceIdTwo = DBTenants.GetMarketplaceIdTwoForTenantFromAspNetUsers(TestDataForWebSiteTenant.EMAIL_CURRENT_OCCUPANT_SECOND);
            Console.WriteLine($"{marketplaceIdTwo} :MarketplaceId for new tenant {newTenant} from table AspNetUsers");

            string marketplaceIdOne = DBTenants.GetMarketplaceIdOneForTenantFromAspNetUsers(TestDataForWebSiteTenant.EMAIL_CURRENT_OCCUPANT_SECOND);
            Console.WriteLine($"{marketplaceIdOne} :MarketplaceId for new tenant {newTenant} from table AspNetUsers");

            string idLast = DBTenants.GetIdByLastForNewTenantFromTenants();
            Console.WriteLine($"{idLast} :Id for new tenant {newTenant} from table Tenants");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBTenant")]
        [AllureSubSuite("RecordsAboutNewTenant")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The tables "Tenants", "AspNetUsers" and "AspNetUserRoles".
        //Path to cheking's: 
        public void RecordsAboutNewTenant()
        {
            string newTenant = DBTestDataForTenantMarketplaceOne.NEW_TENANT_FIRST_LAST_NAME;

            string idLastTenantTenants = DBTenants.GetIdByLastForNewTenantFromTenants();
            Console.WriteLine($"{idLastTenantTenants} :Id for new tenant {newTenant} from table Tenants");

            string idByEmailTenantTenants = DBTenants.GetIdByEmailForTenantFromTenants(DBTestDataForTenantMarketplaceOne.NEW_TENANT_EMAIL);
            Console.WriteLine($"{idByEmailTenantTenants} :Id for new tenant {newTenant} from table Tenants");

            string marketplaceIdByEmailTenantTenants = DBTenants.GetMarketplaceIdByEmailForTenantFromTenants(DBTestDataForTenantMarketplaceOne.NEW_TENANT_EMAIL);
            Console.WriteLine($"{marketplaceIdByEmailTenantTenants} :MarketplaceId for new tenant {newTenant} from table Tenants");

            string marketplaceIdLastTenantAspNetUsers = DBTenants.GetMarketplaceIdForNewTenantFromAspNetUsers();
            Console.WriteLine($"{marketplaceIdByEmailTenantTenants} :MarketplaceId for new tenant {newTenant} from table AspNetUsers");

            string emailConfirmedTenantAspNetUsers = DBTenants.GetEmailComfirmedByEmailForTenantFromAspNetUsers(DBTestDataForTenantMarketplaceOne.NEW_TENANT_EMAIL);
            Console.WriteLine($"{emailConfirmedTenantAspNetUsers} :EmailConfirmed for new tenant {newTenant} from table AspNetUsers");

            string userIdTenantTenants = DBTenants.GetUserIdForNewTenantTableTenants();
            Console.WriteLine($"{userIdTenantTenants} :UserId for new tenant {newTenant} from table Tenants");
            
            string userIdTenantAspNetUsers = DBTenants.GetTenantIdByEmailForNewTenantFromAspNetUsers(DBTestDataForTenantMarketplaceOne.NEW_TENANT_EMAIL, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
            Console.WriteLine($"{userIdTenantAspNetUsers} :Id for new tenant {newTenant} from table AspNetUsers");

            string idTenantAspNetUserRoles = DBTenants.GetRoleIdForNewTenantTableAspNetUserRoles();
            Console.WriteLine($"{idTenantAspNetUserRoles} :RoleId for new tenant {newTenant} from table AspNetUserRoles");

            string emailTenantAspNetUsers = DBTenants.GetEmailByLastIdForTenantFromAspNetUsers(DBTestDataForTenantMarketplaceOne.NEW_TENANT_USER_NAME);
            Console.WriteLine($"{emailTenantAspNetUsers} :Email for new tenant {newTenant} from table AspNetUsers");

            string firstNameTenantAspNetUsers = DBTenants.GetFirstNameByLastIdForTenantFromAspNetUsers(DBTestDataForTenantMarketplaceOne.NEW_TENANT_USER_NAME);
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

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment:  new records about background check and credit screening in the table "dbo.BackgroundChecks".
        //Path to cheking's: 
        public void NewRecordsAboutBackgroundCheckCreditScreening()
        {
            string tenant = DBTestDataForTenantMarketplaceOne.ALREADY_EXIST_TENANT_FIRST_LAST_NAME;

            string lastIdByEmail = DBTenants.GetLastIdByEmailFromTenantBackgroundChecks(TestDataForWebSiteTenant.EMAIL_CURRENT_OCCUPANT_SECOND, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_TWO_DEMO);
            Console.WriteLine($"{lastIdByEmail} :Last Id {tenant} from table TenantBackgroundChecks");

            string lastId = DBTenants.GetLastIdFromTenantBackgroundChecks();
            Console.WriteLine($"{lastId} :Last Id {tenant} from table TenantBackgroundChecks");

            string lastIdCreditScreening = DBTenants.GetLastIdCreditScreeningFromTenantBackgroundChecks(TestDataForWebSiteTenant.EMAIL_CURRENT_OCCUPANT_SECOND, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
            Console.WriteLine($"{lastIdCreditScreening} :Last Id for BackgroundCheck {tenant} from table TenantBackgroundChecks");

            string tenantIdByEmail = DBTenants.GetTenantIdByEmailForNewTenantFromAspNetUsers(TestDataForWebSiteTenant.EMAIL_CURRENT_OCCUPANT_SECOND, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
            Console.WriteLine($"{tenantIdByEmail} :TenantId for new tenant {tenant} from table AspNetUsers");

            string lastIdByEmailBackgroundCheck = DBTenants.GetLastBackgroundCheckByTenantIdFromTenantBackgroundChecks($"{tenantIdByEmail}", DBTestDataGeneral.BACGROUND_CHECK);
            Console.WriteLine($"{lastIdByEmailBackgroundCheck} :Last Id by email for BackgroundCheck {tenant} from table TenantBackgroundChecks");

            string lastIdBackgroundCheck = DBTenants.GetLastBackgroundCheckFromTenantBackgroundChecks(DBTestDataGeneral.BACGROUND_CHECK);
            Console.WriteLine($"{lastIdBackgroundCheck} :Last Id BackgroundCheck {tenant} from table BackgroundChecks");

            string nameBackgroundCheck = DBTenants.GetNameBackgroundCheckFromTenantBackgroundChecks($"{lastIdByEmailBackgroundCheck}");
            Console.WriteLine($"{nameBackgroundCheck} :Name this is BackgroundCheck {tenant} from table BackgroundChecks");

            string nameCreditScreening = DBTenants.GetNameCreditScreeningFromTenantBackgroundChecks($"{lastIdCreditScreening}");
            Console.WriteLine($"{nameCreditScreening} :Name this is CreditScreening {tenant} from table BackgroundChecks");

            string passedBackgroundCheck = DBTenants.GetCheckStatusBackgroundCheckFromTenantBackgroundChecks($"{lastIdBackgroundCheck}", DBTestDataGeneral.BACGROUND_CHECK);
            Console.WriteLine($"{passedBackgroundCheck} :Passed BackgroundCheck {tenant} from table BackgroundChecks");

            string passedCreditScreening = DBTenants.GetCheckStatusCreditScreeningFromTenantBackgroundChecks($"{lastIdCreditScreening}", DBTestDataGeneral.CREDIT_SCREENING);
            Console.WriteLine($"{passedCreditScreening} :Passed CreditScreening {tenant} from table BackgroundChecks");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(lastIdByEmail, lastId);
                Console.WriteLine($"Last Id from table TenantBackgroundChecks: {lastIdByEmail} = {lastId} Last Id from table TenantBackgroundChecks");

                Assert.AreEqual(lastIdCreditScreening, lastId);
                Console.WriteLine($"Last Id for CreditScreening from table TenantBackgroundChecks: {lastIdCreditScreening} = {lastId} Last Id from table TenantBackgroundChecks");

                Assert.AreEqual(lastIdByEmailBackgroundCheck, lastIdBackgroundCheck);
                Console.WriteLine($"Last Id by email for BackgroundCheck from table TenantBackgroundChecks: {lastIdByEmailBackgroundCheck} = {lastIdBackgroundCheck} Last Id BackgroundCheck of a new BackgroundCheck");

                Assert.AreEqual(nameBackgroundCheck, DBTestDataGeneral.BACGROUND_CHECK);
                Console.WriteLine($"Name BackgroundCheck from table BackgroundChecks: {nameBackgroundCheck} = {DBTestDataGeneral.BACGROUND_CHECK} Name BackgroundCheck ER");

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

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: new records about a new tenant (First Name and Last Name) in the table "dbo.TenantExtractedIdentities".
        //Path to cheking's: 
        public void RecordsInTableTenantExtractedIdentities()
        {
            string newTenant = DBTestDataForTenantMarketplaceOne.NEW_TENANT_FIRST_LAST_NAME;

            string firstNameNewTenant = DBTenants.GetFirstNameTenantTableTenantExtractedIdentities();
            Console.WriteLine($"{firstNameNewTenant} :First name a new tenant {newTenant} from table TenantExtractedIdentities");

            string lastNameNewTenant = DBTenants.GetLastNameTenantTableTenantExtractedIdentities();
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

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "TenantLeases"
        //Path to cheking's: 

        public void NewLeaseSignedThreeTenantsIntableTenantLeases()
        {
            string tenantApplicant = DBTestDataGeneral.NAME_ROLE_APPLICANT;
            string tenantOccupant = DBTestDataGeneral.NAME_ROLE_OCCUPANT;
            string tenantGuarantor = DBTestDataGeneral.NAME_ROLE_GUARANTOR;

            string tenantRay = TestDataForWebSiteTenant.FIRST_NAME_TENANT_APPLICANT;
            string tenantLiza = TestDataForWebSiteTenant.FIRST_NAME_OCCUPANT_ONE;
            string tenantJimmy = TestDataForWebSiteTenant.FIRST_NAME_GUARANTOR;

            string lastApartmentApplicationId = DBTenants.GetLastApartmentApplicationIdfromTenantLeases();
            Console.WriteLine($"{lastApartmentApplicationId} :Last ApartmentApplicationId from table TenantLeases");

            string apartmentApplicationIdForApplicant = DBTenants.GetApartmentApplicationIdForApplicantTableTenantLeases(DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_TENANT_ID);
            Console.WriteLine($"{apartmentApplicationIdForApplicant} :ApartmentApplicationId for tenant {tenantRay} {tenantApplicant} from table TenantLeases");

            string apartmentApplicationIdForOccupant = DBTenants.GetApartmentApplicationIdForOccupantTableTenantLeases(DBTestDataForTenantMarketplaceOne.TENANT_OCCUPANT_LIZA_TENANT_ID);
            Console.WriteLine($"{apartmentApplicationIdForOccupant} :ApartmentApplicationId for tenant {tenantOccupant} {tenantLiza} from table TenantLeases");

            string apartmentApplicationIdForGuarantor = DBTenants.GetApartmentApplicationIdForGuarantorTableTenantLeases(DBTestDataForTenantMarketplaceOne.TENANT_GUARANTOR_JIMMY_TENANT_ID);
            Console.WriteLine($"{apartmentApplicationIdForGuarantor} :ApartmentApplicationId for tenant {tenantGuarantor} {tenantJimmy} from table TenantLeases");

            string isLeaseSignedForApplicant = DBTenants.GetIsLeaseSignedFromTenantLeases(DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_TENANT_ID, $"{lastApartmentApplicationId}");
            Console.WriteLine($"{isLeaseSignedForApplicant} :IsLeaseSigned for tenant {tenantRay} {tenantApplicant} from table TenantLeases");

            string isLeaseSignedForOccupant = DBTenants.GetIsLeaseSignedFromTenantLeases(DBTestDataForTenantMarketplaceOne.TENANT_OCCUPANT_LIZA_TENANT_ID, $"{lastApartmentApplicationId}");
            Console.WriteLine($"{isLeaseSignedForOccupant} :IsLeaseSigned for tenant {tenantOccupant} {tenantLiza} from table TenantLeases");

            string isLeaseSignedForGuarantor = DBTenants.GetIsLeaseSignedFromTenantLeases(DBTestDataForTenantMarketplaceOne.TENANT_GUARANTOR_JIMMY_TENANT_ID, $"{lastApartmentApplicationId}");
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

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment:  new records about that the an apartemnt added in the favorities in the table "dbo.TenantApartmentFavorities".
        //Path to cheking's: 
        public void NewRecordInTableTenantApartmentFavorities()
        {
            string tenantApplicant = TestDataForWebSiteTenant.FIRST_NAME_TENANT_APPLICANT;

            string idLastFavorites = DBTenants.GetNewIdTableTenantApartmentFavorites();
            Console.WriteLine($"{idLastFavorites} :Id last {tenantApplicant} from table TenantApartmentFavorites");

            string idFavoritesByEmail = DBTenants.GetNewIdByTenantIdFromTenantApartmentFavorites(TestDataForWebSiteTenant.EMAIL_TENANT_APPLICANT);
            Console.WriteLine($"{idFavoritesByEmail} :Id by email {tenantApplicant} from table TenantApartmentFavorites");

            string tenantIdNewTenantApartmentFavorites = DBTenants.GetNewTenantIdTableTenantApartmentFavorites();
            Console.WriteLine($"{tenantIdNewTenantApartmentFavorites} :TenantIdNewTenantApartmentFavorites {tenantApplicant} from table TenantApartmentFavorites");

            string apartmentIdFromTableApartments = DBApartments.GetIdForUnitFromApartments(DBTestDataDBForAdmins.BUILDING_NAME);
            Console.WriteLine($"{apartmentIdFromTableApartments} :ApartmentId {tenantApplicant} from table Apartments");

            string apartmentIdFromTableTenantApartmentFavorites = DBTenants.GetNewApartmentIdTableTenantApartmentFavorites();
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
    }
}
