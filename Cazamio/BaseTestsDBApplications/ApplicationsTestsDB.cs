using Allure.Commons;
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

namespace CazamioProject.BaseTestsDBApplications
{
    [TestFixture]
    [AllureNUnit]

    public class ApplicationsTestsDB
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("RecordNewOccupantId")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Occupants".
        //Path to cheking's: 

        public void DisplayingApartmentApplicationId()
        {
            string userIdTenant = DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_USER_ID;
            string buildingId = DBTestDataDBForAdmins.BUILDING_ID;
            string unitNumber = DBTestDataDBForAdmins.UNIT_NUMBER;

            string ApartmentApplicationId = DBTableApartmentApplications.GetApartmentApplicationIdByTenantIdApartmentid(userIdTenant, buildingId, unitNumber);
            Console.WriteLine($"{ApartmentApplicationId} :ApartmentApplicationId by TenantId BuildingId UnitNumber for application from table ApartmentApplications");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("RecordNewOccupantId")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Occupants".
        //Path to cheking's: 

        public void RecordNewOccupantId()
        {
            string buildingAddress = DBTestDataDBForAdmins.BUILDING_ADDRESS;

            string tenantOccupant = DBTestDataGeneral.NAME_ROLE_OCCUPANT;
            string tenantLiza = TestDataForWebSiteTenant.FIRST_NAME_OCCUPANT_ONE;
            
            string lastApartmentApplicationId = DBTableApartmentApplications.GetLastApartmentApplicationId();
            Console.WriteLine($"{lastApartmentApplicationId} :Last ApartmentApplicationId for application for {buildingAddress} from table ApartmentApplications");

            string occupantId = DBTableOccupants.GetLastOccupantIdByApartmentApplicationId(lastApartmentApplicationId);
            Console.WriteLine($"{occupantId} :Last by UserId for application for {tenantLiza} {tenantOccupant} for {buildingAddress} from table Occupants");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("RecordNewOccupantId")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Guarantors".
        //Path to cheking's: 

        public void RecordNewGuarantorId()
        {
            string buildingAddress = DBTestDataDBForAdmins.BUILDING_ADDRESS;

            string tenantGuarantor = DBTestDataGeneral.NAME_ROLE_GUARANTOR;
            string tenantJimmy = TestDataForWebSiteTenant.FIRST_NAME_GUARANTOR;

            string lastApartmentApplicationId = DBTableApartmentApplications.GetLastApartmentApplicationId();
            Console.WriteLine($"{lastApartmentApplicationId} :Last ApartmentApplicationId for application for {buildingAddress} from table ApartmentApplications");

            string guarantorId = DBTableGuarantors.GetLastGuarantorIdByApartmentApplicationId($"{lastApartmentApplicationId}");
            Console.WriteLine($"{guarantorId} :Last Id by GuarantorId for application for {tenantJimmy} {tenantGuarantor} for {buildingAddress} from table Guarantors");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("NewApplication")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "ApartmentApplications", "Apartments".
        //Path to cheking's: 

        public void NewApplicationTenantApplicant()
        {
            string buildingAddress = DBTestDataDBForAdmins.BUILDING_ADDRESS;

            string lastApplicationId = DBTableApartmentApplications.GetLastApartmentApplicationId();
            Console.WriteLine($"{lastApplicationId} :Last Id for application for {buildingAddress} from table ApartmentApplications");

            string idApartmentByBuildingId = DBTableApartments.GetApartmentIdByBuildingIdUnit(DBTestDataDBForAdmins.BUILDING_ID, DBTestDataDBForAdmins.UNIT_NUMBER);
            Console.WriteLine($"{idApartmentByBuildingId} :ApartmentId by BuildingId from Apartments");

            string lastApplicationIdByBuildingId = DBTableApartmentApplications.GetLastApartmentApplicationIdByApartmentId($"{idApartmentByBuildingId}");
            Console.WriteLine($"{lastApplicationIdByBuildingId} :Last Id by BuildingId for application for {buildingAddress} from table ApartmentApplications");

            string lastApplicationIdByTenantId = DBTableApartmentApplications.GetLastApartmentApplicationIdByTenantId(DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_USER_ID);
            Console.WriteLine($"{lastApplicationIdByTenantId} :Last Id by tenantId for application for {buildingAddress} from table ApartmentApplications");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(lastApplicationId, lastApplicationIdByBuildingId);
                Console.WriteLine($"ApplicationId last from ApartmentApplications: {lastApplicationId} = {lastApplicationIdByBuildingId} ApplicationId last by BuildingId from ApartmentApplications");

                Assert.AreEqual(lastApplicationId, lastApplicationIdByTenantId);
                Console.WriteLine($"ApplicationId last from ApartmentApplications: {lastApplicationId} = {lastApplicationIdByTenantId} ApplicationId last by TenantId from ApartmentApplications");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("NewApplicationTenantApplicantOccupantJointGuarantor")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "ApartmentApplications", "Apartments", "Occupants", "Guarantors".
        //Path to cheking's: 

        public void NewApplicationTenantApplicantOccupantJointGuarantor()
        {
            string buildingAddress = DBTestDataDBForAdmins.BUILDING_ADDRESS;

            string tenantApplicant = DBTestDataGeneral.NAME_ROLE_APPLICANT;
            string tenantOccupant = DBTestDataGeneral.NAME_ROLE_OCCUPANT;
            string tenantGuarantor = DBTestDataGeneral.NAME_ROLE_GUARANTOR;

            string tenantRay = TestDataForWebSiteTenant.FIRST_NAME_TENANT_APPLICANT;
            string tenantLiza = TestDataForWebSiteTenant.FIRST_NAME_OCCUPANT_ONE;
            string tenantJimmy = TestDataForWebSiteTenant.FIRST_NAME_GUARANTOR;

            string lastApartmentApplicationId = DBTableApartmentApplications.GetLastApartmentApplicationId();
            Console.WriteLine($"{lastApartmentApplicationId} :Last ApartmentApplicationId for application for {buildingAddress} from table ApartmentApplications");

            string idApartmentByBuildingId = DBTableApartments.GetApartmentIdByBuildingIdUnit(DBTestDataDBForAdmins.BUILDING_ID, DBTestDataDBForAdmins.UNIT_NUMBER);
            Console.WriteLine($"{idApartmentByBuildingId} :ApartmentId by BuildingId from Apartments");

            string lastApplicationIdByBuildingId = DBTableApartmentApplications.GetLastApartmentApplicationIdByApartmentId(idApartmentByBuildingId);
            Console.WriteLine($"{lastApplicationIdByBuildingId} :Last ApartmentApplicationId Id by BuildingId for application for {buildingAddress} from table ApartmentApplications");

            string lastApplicationIdByTenantId = DBTableApartmentApplications.GetLastApartmentApplicationIdByTenantId(DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_USER_ID);
            Console.WriteLine($"{lastApplicationIdByTenantId} :Last ApartmentApplicationId by TenantId for application for {buildingAddress} from table ApartmentApplications");

            string guarantorId = DBTableGuarantors.GetLastGuarantorIdByApartmentApplicationId($"{lastApartmentApplicationId}");
            Console.WriteLine($"{guarantorId} :Last Id by GuarantorId for application for {tenantJimmy} {tenantGuarantor} for {buildingAddress} from table Guarantors");

            string lastIdGuarantorIdApartmentApplicationId = DBTableApartmentApplicationApplicants.GetIdByGuarantorIdApartmentApplicationId(lastApartmentApplicationId, guarantorId);
            Console.WriteLine($"{lastIdGuarantorIdApartmentApplicationId} :Last Id for application for {buildingAddress} from table ApartmentApplicationApplicants");

            string occupantId = DBTableOccupants.GetLastOccupantIdByApartmentApplicationId(lastApartmentApplicationId);
            Console.WriteLine($"{occupantId} :Last by UserId for application for {tenantLiza} {tenantOccupant} for {buildingAddress} from table Occupants");

            string lastIdByOccupantIdApartmentApplicationId = DBTableApartmentApplicationApplicants.GetIdByOccupantIdApartmentApplicationId(lastApartmentApplicationId, occupantId);
            Console.WriteLine($"{lastIdByOccupantIdApartmentApplicationId} :Last by UserId for application for {tenantLiza} {tenantOccupant} for {buildingAddress} from table ApartmentApplicationApplicants");

            string lastIdByOccupantId = DBTableApartmentApplicationApplicants.GetLastIdByOccupantId(occupantId);
            Console.WriteLine($"{lastIdByOccupantId} :Last Id by OccupantId Id for application for {tenantLiza} {tenantOccupant} for {buildingAddress} from table Occupants");

            string lastIdByGuarantorId = DBTableApartmentApplicationApplicants.GetLastIdByGuarantorId(guarantorId);
            Console.WriteLine($"{lastIdByGuarantorId} :Last Id by GuarantorId for application for {tenantJimmy} {tenantGuarantor} for {buildingAddress} from table ApartmentApplicationApplicants");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(lastApartmentApplicationId, lastApplicationIdByBuildingId);
                Console.WriteLine($"ApplicationId last from ApartmentApplications: {lastApartmentApplicationId} = {lastApplicationIdByBuildingId} ApplicationId last by BuildingId from ApartmentApplications");

                Assert.AreEqual(lastApartmentApplicationId, lastApplicationIdByTenantId);
                Console.WriteLine($"ApplicationId last from ApartmentApplications: {lastApartmentApplicationId} = {lastApplicationIdByTenantId} ApplicationId last by TenantId from ApartmentApplications");

                Assert.AreEqual(lastIdGuarantorIdApartmentApplicationId, lastIdByGuarantorId);
                Console.WriteLine($"Id for {tenantGuarantor} last from ApartmentApplicationApplicants: {lastIdGuarantorIdApartmentApplicationId} = {lastIdByGuarantorId} Id last by UserId of the {tenantJimmy} {tenantGuarantor} from ApartmentApplications");

                Assert.AreEqual(lastIdByOccupantIdApartmentApplicationId, lastIdByOccupantId);
                Console.WriteLine($"Last Id by OccupantId from ApartmentApplicationApplicants: {lastIdByOccupantIdApartmentApplicationId} = {lastIdByOccupantId} Id last by UserId of the {tenantLiza} {tenantOccupant} from ApartmentApplications");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("NewRecordApplicationProgressApplicant")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "ApartmentApplicationProgress", "ApartmentApplications".
        //Path to cheking's: 

        public void NewRecordApplicationProgressApplicant()
        {
            string buildingAddress = DBTestDataDBForAdmins.BUILDING_ADDRESS;

            string lastId = DBTableApartmentApplicationProgress.GetLastId();
            Console.WriteLine($"{lastId} :Last Id for application for {buildingAddress} from table ApartmentApplicationProgress");

            string lastApartmentApplicationId = DBTableApartmentApplications.GetLastApartmentApplicationId();
            Console.WriteLine($"{lastApartmentApplicationId} :Last ApartmentApplicationId for application for {buildingAddress} from table ApartmentApplications");

            string lastIdByTenantIdApartmentApplicationId = DBTableApartmentApplicationProgress.GetLastIdByTenantIdApartmentApplicationId(DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_TENANT_ID, lastApartmentApplicationId);
            Console.WriteLine($"{lastIdByTenantIdApartmentApplicationId} :Last Id for application for {buildingAddress} from table ApartmentApplicationProgress");

            string lastApartmentApplicationIdByIdTenantId = DBTableApartmentApplicationProgress.GetLastIdApplicantByApartmentApplicationIdTenantId(DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_TENANT_ID);
            Console.WriteLine($"{lastApartmentApplicationIdByIdTenantId} :Last Id for application for {buildingAddress} from table ApartmentApplicationProgress");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(lastId, lastIdByTenantIdApartmentApplicationId);
                Console.WriteLine($"Last Id from ApartmentApplicationProgress: {lastId} = {lastIdByTenantIdApartmentApplicationId} Last Id last by TenantId ApartmentApplicationId from ApartmentApplicationProgress");

                Assert.AreEqual(lastApartmentApplicationId, lastApartmentApplicationIdByIdTenantId);
                Console.WriteLine($"Last ApartmentApplicationId from ApartmentApplicationProgress: {lastApartmentApplicationId} = {lastApartmentApplicationIdByIdTenantId} Last ApartmentApplicationId by TenantId and last Id from ApartmentApplicationProgress");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("NewRecordApplicationProgressApplicantOccupantJointGuarantor")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "ApartmentApplicationProgress", "ApartmentApplications".
        //Path to cheking's: 

        public void NewRecordApplicationProgressApplicantOccupantJointGuarantor()
        {
            string buildingAddress = DBTestDataDBForAdmins.BUILDING_ADDRESS;

            string lastIdApplicant = DBTableApartmentApplicationProgress.GetLastIdApplicantByTenantId(DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_TENANT_ID);
            Console.WriteLine($"{lastIdApplicant} :Last Id tenant-applicant for application for {buildingAddress} from table ApartmentApplicationProgress");

            string lastIdOccupant = DBTableApartmentApplicationProgress.GetLastIdByTenantId(DBTestDataForTenantMarketplaceOne.TENANT_OCCUPANT_LIZA_TENANT_ID);
            Console.WriteLine($"{lastIdOccupant} :Last Id tenant-occupant for application for {buildingAddress} from table ApartmentApplicationProgress");

            string lastIdGuarantor = DBTableApartmentApplicationProgress.GetLastIdByTenantId(DBTestDataForTenantMarketplaceOne.TENANT_GUARANTOR_JIMMY_TENANT_ID);
            Console.WriteLine($"{lastIdGuarantor} :Last Id tenant-guarantor for application for {buildingAddress} from table ApartmentApplicationProgress");

            string lastApartmentApplicationId = DBTableApartmentApplications.GetLastApartmentApplicationId();
            Console.WriteLine($"{lastApartmentApplicationId} :Last ApartmentApplicationId for application for {buildingAddress} from table ApartmentApplications");

            string lastIdApplicantByApartmentApplicationId = DBTableApartmentApplicationProgress.GetLastIdApplicantByApartmentApplicationId(lastApartmentApplicationId);
            Console.WriteLine($"{lastIdApplicantByApartmentApplicationId} :Last Id tenant-applicant for application for {buildingAddress} from table ApartmentApplicationProgress");

            string lastIdOccupantByApartmentApplicationId = DBTableApartmentApplicationProgress.GetLastIdOccupantByApartmentApplicationId(lastApartmentApplicationId);
            Console.WriteLine($"{lastIdOccupantByApartmentApplicationId} :Last Id tenant-occupant for application for {buildingAddress} from table ApartmentApplicationProgress");

            string lastIdGuarantorApartmentApplicationId = DBTableApartmentApplicationProgress.GetLastIdGuarantorByApartmentApplicationId(lastApartmentApplicationId);
            Console.WriteLine($"{lastIdGuarantorApartmentApplicationId} :Last Id tenant-guarantor for application for {buildingAddress} from table ApartmentApplicationProgress");



            Assert.Multiple(() =>
            {
                Assert.AreEqual(lastIdApplicant, lastIdApplicantByApartmentApplicationId);
                Console.WriteLine($"Last Id Applicant by TenantId from ApartmentApplicationProgress: {lastIdApplicant} = {lastIdApplicantByApartmentApplicationId} Last Id by ApartmentApplicationId from ApartmentApplicationProgress");

                Assert.AreEqual(lastIdOccupant, lastIdOccupantByApartmentApplicationId);
                Console.WriteLine($"Last Id Occupant by TenantId from ApartmentApplicationProgress: {lastIdOccupant} = {lastIdOccupantByApartmentApplicationId} Last Id by ApartmentApplicationId from ApartmentApplicationProgress");

                Assert.AreEqual(lastIdGuarantor, lastIdGuarantorApartmentApplicationId);
                Console.WriteLine($"Last Id Guarantor by TenantId from ApartmentApplicationProgress: {lastIdGuarantor} = {lastIdGuarantorApartmentApplicationId} Last Id by ApartmentApplicationId from ApartmentApplicationProgress");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("EmptyTwo")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: new record by table dbo.ApartmentApplicationProgress
        //Path to cheking's: 

        public void EmptyTwo()
        {
            
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("EmptyThree")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: by table dbo.ApartmentApplications
        //Path to cheking's: 

        public void EmptyThree()
        {
            
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("EmptyFour")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: new record by table dbo.ApartmentApplicationApplicants when at the tenant-applicant with set check the box "Joint applicant"
        //Path to cheking's: 

        public void EmptyFour()
        {
            
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("EmptyFive")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: new record by table dbo.ApartmentApplicationApplicants when at the tenant-applicant with set check the box "Joint applicant"
        //Path to cheking's: 

        public void EmptyFive()
        {
            
        }
    }
}
