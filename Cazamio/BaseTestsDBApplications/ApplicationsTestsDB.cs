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

            string idApartmentByBuildingId = DBApartments.GetApartmentIdByBuildingIdFromApartments(DBTestDataDBForAdmins.BUILDING_ID, DBTestDataDBForAdmins.UNIT_NUMBER);
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
        //Comment: The table "ApartmentApplications", "Apartments".
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

            string idApartmentByBuildingId = DBApartments.GetApartmentIdByBuildingIdFromApartments(DBTestDataDBForAdmins.BUILDING_ID, DBTestDataDBForAdmins.UNIT_NUMBER);
            Console.WriteLine($"{idApartmentByBuildingId} :ApartmentId by BuildingId from Apartments");

            string lastApplicationIdByBuildingId = DBTableApartmentApplications.GetLastApartmentApplicationIdByApartmentId(idApartmentByBuildingId);
            Console.WriteLine($"{lastApplicationIdByBuildingId} :Last ApartmentApplicationId Id by BuildingId for application for {buildingAddress} from table ApartmentApplications");

            string lastApplicationIdByTenantId = DBTableApartmentApplications.GetLastApartmentApplicationIdByTenantId(DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_USER_ID);
            Console.WriteLine($"{lastApplicationIdByTenantId} :Last ApartmentApplicationId by TenantId for application for {buildingAddress} from table ApartmentApplications");

            string guarantorId = DBTableGuarantors.GetLastGuarantorIdByApartmentApplicationId($"{lastApartmentApplicationId}");
            Console.WriteLine($"{guarantorId} :Last Id by GuarantorId for application for {tenantJimmy} {tenantGuarantor} for {buildingAddress} from table Guarantors");

            string lastIdGuarantorApartmentApplicationApplicant = DBTableApartmentApplicationApplicants.GetIdByGuarantorIdApartmentApplicationId(lastApartmentApplicationId, guarantorId);
            Console.WriteLine($"{lastIdGuarantorApartmentApplicationApplicant} :Last Id for application for {buildingAddress} from table ApartmentApplicationApplicants");

            string occupantId = DBTableOccupants.GetLastOccupantIdByApartmentApplicationId(lastApartmentApplicationId);
            Console.WriteLine($"{occupantId} :Last by UserId for application for {tenantLiza} {tenantOccupant} for {buildingAddress} from table Occupants");

            string lastIdOccupantApartmentApplicationApplicants = DBTableApartmentApplicationApplicants.GetIdByOccupantIdApartmentApplicationId(lastApartmentApplicationId, occupantId);
            Console.WriteLine($"{lastIdOccupantApartmentApplicationApplicants} :Last by UserId for application for {tenantLiza} {tenantOccupant} for {buildingAddress} from table ApartmentApplicationApplicants");

            string lastIdOccupantByOccupantId = DBTableApartmentApplicationApplicants.GetLastIdByOccupantId(occupantId);
            Console.WriteLine($"{lastIdOccupantByOccupantId} :Last Id by OccupantId Id for application for {tenantLiza} {tenantOccupant} for {buildingAddress} from table Occupants");

            string applicationIdGuarantor = DBTableApartmentApplicationApplicants.GetLastIdByGuarantorId(guarantorId);
            Console.WriteLine($"{applicationIdGuarantor} :Last Id by UserId for application for {tenantJimmy} {tenantGuarantor} for {buildingAddress} from table ApartmentApplicationApplicants");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(lastApartmentApplicationId, lastApplicationIdByBuildingId);
                Console.WriteLine($"ApplicationId last from ApartmentApplications: {lastApartmentApplicationId} = {lastApplicationIdByBuildingId} ApplicationId last by BuildingId from ApartmentApplications");

                Assert.AreEqual(lastApartmentApplicationId, lastApplicationIdByTenantId);
                Console.WriteLine($"ApplicationId last from ApartmentApplications: {lastApartmentApplicationId} = {lastApplicationIdByTenantId} ApplicationId last by TenantId from ApartmentApplications");

                Assert.AreEqual(lastIdGuarantorApartmentApplicationApplicant, applicationIdGuarantor);
                Console.WriteLine($"Id for {tenantGuarantor} last from ApartmentApplicationApplicants: {lastIdGuarantorApartmentApplicationApplicant} = {applicationIdGuarantor} Id last by UserId of the {tenantJimmy} {tenantGuarantor} from ApartmentApplications");

                Assert.AreEqual(lastIdOccupantByOccupantId, lastIdOccupantByOccupantId);
                Console.WriteLine($"Id last from ApartmentApplicationApplicants: {lastIdOccupantByOccupantId} = {lastIdOccupantByOccupantId} Id last by UserId of the {tenantLiza} {tenantOccupant} from ApartmentApplications");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("RelatedApplicationWithTenantApplicant")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: new record by table dbo.ApartmentApplicationProgress
        //Path to cheking's: 

        public void RelatedApplicationWithTenantApplicant()
        {
            string tenantApplicant = DBTestDataGeneral.NAME_ROLE_APPLICANT;

            string idTenantApplicant = DBApplications.GetTenantIdApplicant("tenantswife@gmail.com");
            Console.WriteLine($"Id for tenant {tenantApplicant} from table tenants: {idTenantApplicant}");
            string idApplication = DBApplications.GetLastIdFromApartmentApplicationProgress();
            Console.WriteLine($"Id for new application from table tenants: {idApplication}");

            string apartmentApplicationIdApp = DBApplications.GetApartmentApplicationIdApplicant();
            Console.WriteLine($"ApartmentApplicationId for new application for applicant from table ApartmentApplicationProgress: {apartmentApplicationIdApp}");
            Assert.AreEqual(idApplication, apartmentApplicationIdApp);
            Console.WriteLine($"IdApplication a new EX: {idApplication} = {apartmentApplicationIdApp} ApartmentApplicationId by applicant");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("RelatedApplicationWithTenantsAppOccGua")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: new record by table dbo.ApartmentApplicationProgress
        //Path to cheking's: 

        public void RelatedApplicationWithTenantsAppOccGua()
        {
            string tenantApplicant = DBTestDataGeneral.NAME_ROLE_APPLICANT;
            string tenantOccupant = DBTestDataGeneral.NAME_ROLE_OCCUPANT;
            string tenantGuarantor = DBTestDataGeneral.NAME_ROLE_GUARANTOR;

            string idTenantApplicant = DBApplications.GetTenantIdApplicant("tenantswife@gmail.com");
            Console.WriteLine($"Id for tenant {tenantApplicant} from table tenants: {idTenantApplicant}");
            string idTenantOccupant = DBApplications.GetTenantIOccupant("apipostman65455@gmail.com");
            Console.WriteLine($"Id for tenant {tenantOccupant} from table tenants: {idTenantOccupant}");
            string idTenantGuarantor = DBApplications.GetTenantIGuarantor("guarantor5935@gmail.com");
            Console.WriteLine($"Id for tenant {tenantGuarantor} from table tenants: {idTenantGuarantor}");
            string idApplication = DBApplications.GetLastIdFromApartmentApplicationProgress();
            Console.WriteLine($"Id for new application from table tenants: {idApplication}");

            string apartmentApplicationIdApp = DBApplications.GetApartmentApplicationIdApplicant();
            Console.WriteLine($"ApartmentApplicationId for new application for applicant from table ApartmentApplicationProgress: {apartmentApplicationIdApp}");
            string apartmentApplicationIdOcc = DBApplications.GetApartmentApplicationIdOccupant();
            Console.WriteLine($"ApartmentApplicationId for new application for occupant from table ApartmentApplicationProgress: {apartmentApplicationIdOcc}");
            string apartmentApplicationIdGua = DBApplications.GetApartmentApplicationIdGuarantor();
            Console.WriteLine($"ApartmentApplicationId for new application for guarantor from table ApartmentApplicationProgress: {apartmentApplicationIdGua}");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(idApplication, apartmentApplicationIdApp);
                Assert.AreEqual(idApplication, apartmentApplicationIdOcc);
                Assert.AreEqual(idApplication, apartmentApplicationIdGua);

                Console.WriteLine($"IdApplication a new EX: {idApplication} = {apartmentApplicationIdApp} ApartmentApplicationId by applicant");
                Console.WriteLine($"IdApplication a new EX: {idApplication} = {apartmentApplicationIdOcc} ApartmentApplicationId by occupant");
                Console.WriteLine($"IdApplication a new EX: {idApplication} = {apartmentApplicationIdGua} ApartmentApplicationId by guarantor");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("RelateApplicationWithApartment")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: by table dbo.ApartmentApplications
        //Path to cheking's: 

        public void RelateApplicationWithApartment()
        {
            string building = DBTestDataDBForAdmins.BUILDING_NAME;
            string apartmentNumber = DBTestDataDBForAdmins.UNIT_NUMBER;

            string apartmentId = DBTableApartmentApplications.GetLastApartmentApplicationId();
            Console.WriteLine($"Building name {building} apartemnt name {apartmentNumber}, ApartmentID: {apartmentId}");

            Assert.AreEqual(apartmentId, DBTestDataDBForAdmins.APARTMENT_ID_UNIT_NUMBER);
            Console.WriteLine($"ApartmentID ER: {apartmentId} = {DBTestDataDBForAdmins.APARTMENT_ID_UNIT_NUMBER} ApartmentID AR");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("RelateApplicationWithOccGuaSetJoin")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: new record by table dbo.ApartmentApplicationApplicants when at the tenant-applicant with set check the box "Joint applicant"
        //Path to cheking's: 

        public void RelateApplicationWithOccGuaSetJoin()
        {
            string building = DBTestDataDBForAdmins.BUILDING_NAME;
            string apartmentNumber = DBTestDataDBForAdmins.UNIT_NUMBER;

            string newApartmentApplicationId = DBApplications.GetNewApartmentApplicationId();
            Console.WriteLine($"Building name {building} apartemnt name {apartmentNumber}, New ApartmentApplicationId: {newApartmentApplicationId}");
            string apartmentApplicationIdForOccGua = DBApplications.GetApartmentApplicationIdOccGua();
            Console.WriteLine($"ApartmentApplicationId for occupant and guarantor: {apartmentApplicationIdForOccGua}");
            string apartmentApplicationIdForOccupant = DBApplications.GetApartmentApplicationIdByUserIdOcc();
            Console.WriteLine($"ApartmentApplicationId for occupant: {apartmentApplicationIdForOccupant}");
            string apartmentApplicationIdForGuarantor = DBApplications.GetApartmentApplicationIdByUserIdGua();
            Console.WriteLine($"ApartmentApplicationId for guarantor: {apartmentApplicationIdForGuarantor}");
            string apartmentApplicationIdForOccByEmail = DBApplications.GetApartmentApplicationIdByEmailOcc("apipostman65455@gmail.com");
            Console.WriteLine($"ApartmentApplicationId for guarantor by email in table Occupants: {apartmentApplicationIdForOccByEmail}");
            string apartmentApplicationIdForGuaByEmail = DBApplications.GetApartmentApplicationIdByEmailOcc("guarantor5935@gmail.com");
            Console.WriteLine($"ApartmentApplicationId for guarantor by email in table Guarantors: {apartmentApplicationIdForGuaByEmail}");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(newApartmentApplicationId, apartmentApplicationIdForOccGua);
                Console.WriteLine($"New ApartmentApplicationId: {newApartmentApplicationId} = {apartmentApplicationIdForOccGua} ApartmentApplicationId For Occupant Guarantor");
                Assert.AreEqual(newApartmentApplicationId, apartmentApplicationIdForOccupant);
                Console.WriteLine($"New ApartmentApplicationId: {newApartmentApplicationId} = {apartmentApplicationIdForOccupant} ApartmentApplicationId For Occupant");
                Assert.AreEqual(newApartmentApplicationId, apartmentApplicationIdForGuarantor);
                Console.WriteLine($"New ApartmentApplicationId: {newApartmentApplicationId} = {apartmentApplicationIdForGuarantor} ApartmentApplicationId For Guarantor");
                Assert.AreEqual(newApartmentApplicationId, apartmentApplicationIdForOccByEmail);
                Console.WriteLine($"New ApartmentApplicationId: {newApartmentApplicationId} = {apartmentApplicationIdForOccByEmail} ApartmentApplicationId For Occupant in table Occupants");
                Assert.AreEqual(newApartmentApplicationId, apartmentApplicationIdForGuaByEmail);
                Console.WriteLine($"New ApartmentApplicationId: {newApartmentApplicationId} = {apartmentApplicationIdForGuaByEmail} ApartmentApplicationId For Occupant in table Guarantors");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("RelateApplicationWithOccGuaNoSetJoin")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: new record by table dbo.ApartmentApplicationApplicants when at the tenant-applicant with set check the box "Joint applicant"
        //Path to cheking's: 

        public void RelateApplicationWithOccGuaNoSetJoin()
        {
            string building = DBTestDataDBForAdmins.BUILDING_NAME;
            string apartmentNumber = DBTestDataDBForAdmins.UNIT_NUMBER;

            string newApartmentApplicationId = DBApplications.GetNewApartmentApplicationId();
            Console.WriteLine($"Building name {building} apartemnt name {apartmentNumber}, New ApartmentApplicationId: {newApartmentApplicationId}");

            string apartmentApplicationIdForGuaS = DBApplications.GetApartmentApplicationIdGuarantorS();
            Console.WriteLine($"ApartmentApplicationId for occupant and guarantor: {apartmentApplicationIdForGuaS}");

            string apartmentApplicationIdForOccupant = DBApplications.GetApartmentApplicationIdByUserIdOcc();
            Console.WriteLine($"ApartmentApplicationId for occupant: {apartmentApplicationIdForOccupant}");

            string apartmentApplicationIdForOccByEmail = DBApplications.GetApartmentApplicationIdByEmailOcc("apipostman65455@gmail.com");
            Console.WriteLine($"ApartmentApplicationId for occupant: {apartmentApplicationIdForOccByEmail}");

            string apartmentApplicationIdForGuarantor = DBApplications.GetApartmentApplicationIdByUserIdGua();
            Console.WriteLine($"ApartmentApplicationId for guarantor: {apartmentApplicationIdForGuarantor}");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(newApartmentApplicationId, apartmentApplicationIdForGuaS);
                Console.WriteLine($"New ApartmentApplicationId: {newApartmentApplicationId} = {apartmentApplicationIdForGuaS} ApartmentApplicationId For Occupant Guarantor");
                Assert.AreNotEqual(newApartmentApplicationId, apartmentApplicationIdForOccupant);
                Console.WriteLine($"New ApartmentApplicationId: {newApartmentApplicationId} = {apartmentApplicationIdForOccupant} ApartmentApplicationId For Occupant from table ApartmentApplicationApplicant");
                Assert.AreEqual(newApartmentApplicationId, apartmentApplicationIdForOccByEmail);
                Console.WriteLine($"New ApartmentApplicationId: {newApartmentApplicationId} = {apartmentApplicationIdForOccByEmail} ApartmentApplicationId For Occupant from table Occupants");
                Assert.AreEqual(newApartmentApplicationId, apartmentApplicationIdForGuarantor);
                Console.WriteLine($"New ApartmentApplicationId: {newApartmentApplicationId} = {apartmentApplicationIdForGuarantor} ApartmentApplicationId For Guarantor");
            });
        }
    }
}
