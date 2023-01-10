using Allure.Commons;
using CazamioProgect.Helpers;
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
        //Comment: records about a new tenant in the tables "Tenants", "AspNetUsers" and "AspNetUserRoles".
        //Path to cheking's: 
        public void RecordsAboutNewTenant()
        {
            string newTenant = TestDataDBForWebSiteTenant.NEW_TENANT_FIRST_LAST_NAME;

            string idTenantTenants = DBTenants.GetIdForNewTenantTableTenants();
            Console.WriteLine($"{idTenantTenants} :Id for new tenant {newTenant} from table tenants");

            string userIdTenantTenants = DBTenants.GetUserIdForNewTenantTableTenants();
            Console.WriteLine($"{userIdTenantTenants} :UserId for new tenant {newTenant} from table tenants");
            
            string idTenantAspNetUsers = DBTenants.GetIdForNewTenantTableAspNetUsers("globo34f6fhj@putsbox.com");
            Console.WriteLine($"{idTenantAspNetUsers} :Id for new tenant {newTenant} from table AspNetUsers");

            string idTenantAspNetUserRoles = DBTenants.GetRoleIdForNewTenantTableAspNetUserRoles();
            Console.WriteLine($"{idTenantAspNetUserRoles} :RoleId for new tenant {newTenant} from table AspNetUserRoles");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(userIdTenantTenants, idTenantAspNetUsers);
                Console.WriteLine($"UserId a new tenant from table Tenants: {userIdTenantTenants} = {idTenantAspNetUsers} Id for tenant from table AspNetUsers");

                Assert.AreEqual(idTenantAspNetUserRoles, TestDataDBGeneral.ID_NAME_ROLE_TENANT);
                Console.WriteLine($"RoleId tenant for a new tenant AR: {idTenantAspNetUserRoles} = {TestDataDBGeneral.ID_NAME_ROLE_TENANT} RoleId tenant for a new tenant ER");
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
        //Comment: 
        //Path to cheking's: 
        public void RecordsAboutBackgroundCheckCreditScreening()
        {
            string newTenant = TestDataDBForWebSiteTenant.NEW_TENANT_FIRST_LAST_NAME;

            string checkStatusBackgroundChecks = DBTenants.GetTenantIdForNewTenantTableTenantBackgroundChecks();
            Console.WriteLine($"{checkStatusBackgroundChecks} :CheckStatus {newTenant} from table BackgroundChecks");

            string checkStatusCreditScreening = DBTenants.GetTenantIdForNewTenantTableTenantCreditScreening();
            Console.WriteLine($"{checkStatusCreditScreening} :CheckStatus {newTenant} from table BackgroundChecks");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(checkStatusBackgroundChecks, TestDataDBForWebSiteTenant.PASSED_BACKGROUND_CHECK_TENANT);
                Console.WriteLine($"CheckStatus of BackgroundCheck for a new tenant from table BackgroundChecks AR: {checkStatusBackgroundChecks} = {TestDataDBForWebSiteTenant.PASSED_BACKGROUND_CHECK_TENANT} CheckStatus of BackgroundCheck for a new tenant from table BackgroundChecks ER");

                Assert.AreEqual(checkStatusCreditScreening, TestDataDBForWebSiteTenant.PASSED_CREDIT_SCREENING_TENANT);
                Console.WriteLine($"CheckStatus of CreditScreening for a new tenant from table BackgroundChecks AR: {checkStatusCreditScreening} = {TestDataDBForWebSiteTenant.PASSED_CREDIT_SCREENING_TENANT} CheckStatus of CreditScreening for a new tenant from table BackgroundChecks ER");
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
        //Comment: records about a new tenant (First Name and Last Name) in the table "TenantExtractedIdentities".
        //Path to cheking's: 
        public void RecordsInTableTenantExtractedIdentities()
        {
            string newTenant = TestDataDBForWebSiteTenant.NEW_TENANT_FIRST_LAST_NAME;

            string firstNameNewTenant = DBTenants.GetFirstNameTenantTableTenantExtractedIdentities();
            Console.WriteLine($"{firstNameNewTenant} :First name a new tenant {newTenant} from table TenantExtractedIdentities");

            string lastNameNewTenant = DBTenants.GetLastNameTenantTableTenantExtractedIdentities();
            Console.WriteLine($"{lastNameNewTenant} :Last name a new tenant {newTenant} from table TenantExtractedIdentities");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(firstNameNewTenant, TestDataDBForWebSiteTenant.NEW_TENANT_FIRST_NAME);
                Console.WriteLine($"First Name for a new tenant from table TenantExtractedIdentities AR: {firstNameNewTenant} = {TestDataDBForWebSiteTenant.NEW_TENANT_FIRST_NAME} First Name for a new tenant from table TenantExtractedIdentities ER");

                Assert.AreEqual(lastNameNewTenant, TestDataDBForWebSiteTenant.NEW_TENANT_LAST_NAME);
                Console.WriteLine($"Last Name for a new tenant from table TenantExtractedIdentities AR: {lastNameNewTenant} = {TestDataDBForWebSiteTenant.NEW_TENANT_LAST_NAME} Last Name for a new tenant from table TenantExtractedIdentities ER");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBTenant")]
        [AllureSubSuite("RelatedTenantsWithApplication")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: new record in the table dbo.TenantLeases
        //Path to cheking's: 

        public void RelatedTenantsWithApplication()
        {
            string tenantApplicant = TestDataDBForWebSiteTenant.NAME_ROLE_APPLICANT;
            string tenantOccupant = TestDataDBForWebSiteTenant.NAME_ROLE_OCCUPANT;
            string tenantGuarantor = TestDataDBForWebSiteTenant.NAME_ROLE_GUARANTOR;

            string newApartmentApplicationId = DBTenants.GetNewApartmentApplicationIdTableTenantLeases();
            Console.WriteLine($"{newApartmentApplicationId} :ApartmentApplicationId new from table TenantLeases");

            string apartmentApplicationIdForApplicant = DBTenants.GetApartmentApplicationIdForApplicantTableTenantLeases();
            Console.WriteLine($"{apartmentApplicationIdForApplicant} :ApartmentApplicationId for tenant {tenantApplicant} from table TenantLeases");

            string apartmentApplicationIdForOccupant = DBTenants.GetApartmentApplicationIdForOccupantTableTenantLeases();
            Console.WriteLine($"{apartmentApplicationIdForOccupant} :ApartmentApplicationId for tenant {tenantOccupant} from table TenantLeases");

            string apartmentApplicationIdForGuarantor = DBTenants.GetApartmentApplicationIdForGuarantorTableTenantLeases();
            Console.WriteLine($"{apartmentApplicationIdForGuarantor} :ApartmentApplicationId for tenant {tenantGuarantor} from table TenantLeases");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(apartmentApplicationIdForApplicant, TestDataDBForWebSiteTenant.APPLICANT_WIFE_TENANT_TENANTID);
                Console.WriteLine($"TenantId {tenantApplicant} AR: {apartmentApplicationIdForApplicant} = {TestDataDBForWebSiteTenant.APPLICANT_WIFE_TENANT_TENANTID} :TenantId {tenantApplicant} ER");

                Assert.AreEqual(apartmentApplicationIdForOccupant, TestDataDBForWebSiteTenant.OCCUPANT_CROCODILE_DENDY_TENANTID);
                Console.WriteLine($"TenantId {tenantOccupant} AR: {apartmentApplicationIdForOccupant} = {TestDataDBForWebSiteTenant.OCCUPANT_CROCODILE_DENDY_TENANTID} :TenantId {tenantOccupant} ER");

                Assert.AreEqual(apartmentApplicationIdForGuarantor, TestDataDBForWebSiteTenant.GUARANTOR_RODGER_VANPIECE_TENANTID);
                Console.WriteLine($"TenantId {tenantGuarantor} AR: {apartmentApplicationIdForGuarantor} = {TestDataDBForWebSiteTenant.GUARANTOR_RODGER_VANPIECE_TENANTID} :TenantId {tenantGuarantor} ER");
            });
        }

    }
}
