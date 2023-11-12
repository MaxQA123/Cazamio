using Allure.Commons;
using ApiTests.Base;
using CazamioProgect.Helpers;
using CazamioProject.DBHelpers;
using CazamioProject.DBHelpers.TableApartmentApplicationProgress;
using CazamioProject.DBHelpers.TableApplicationBasicInformation;
using CazamioProject.DBHelpers.TableApplicationGeneralQuestions;
using CazamioProject.DBHelpers.TableApplicationOccupations;
using CazamioProject.DBHelpers.TableApplicationPrices;
using CazamioProject.DBHelpers.TableApplicationRentalHistories;
using CazamioProject.DBHelpers.TableApplicationRequiredDocuments;
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

    public class ApplicationsTestsDB : Base
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("RecordNewOccupantId")]

        public void DisplayingApartmentApplicationId()
        {
            string userIdTenant = DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_USER_ID;
            string buildingId = DBTestDataDBForAdmins.BUILDING_ID;
            string unitNumber = DBTestDataDBForAdmins.UNIT_NUMBER;

            string ApartmentApplicationId = DBRequestApartmentApplicationsOLD.GetApartmentApplicationIdByTenantIdApartmentid(userIdTenant, buildingId, unitNumber);
            Console.WriteLine($"{ApartmentApplicationId} :ApartmentApplicationId by TenantId BuildingId UnitNumber for application from table ApartmentApplications");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("RecordNewOccupantId")]

        public void RecordNewOccupantId()
        {
            string buildingAddress = DBTestDataDBForAdmins.BUILDING_ADDRESS;

            string tenantOccupant = DBTestDataGeneral.NAME_ROLE_OCCUPANT;
            string tenantLiza = TestDataForWebSiteTenant.FIRST_NAME_OCCUPANT_ONE;
            
            string lastApartmentApplicationId = DBRequestApartmentApplicationsOLD.GetLastApartmentApplicationId();
            Console.WriteLine($"{lastApartmentApplicationId} :Last ApartmentApplicationId for application for {buildingAddress} from table ApartmentApplications");

            string occupantId = DBRequestOccupantsOLD.GetLastOccupantIdByApartmentApplicationId(lastApartmentApplicationId);
            Console.WriteLine($"{occupantId} :Last by UserId for application for {tenantLiza} {tenantOccupant} for {buildingAddress} from table Occupants");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("RecordNewOccupantId")]

        public void RecordNewGuarantorId()
        {
            string buildingAddress = DBTestDataDBForAdmins.BUILDING_ADDRESS;

            string tenantGuarantor = DBTestDataGeneral.NAME_ROLE_GUARANTOR;
            string tenantJimmy = TestDataForWebSiteTenant.FIRST_NAME_GUARANTOR;

            string lastApartmentApplicationId = DBRequestApartmentApplicationsOLD.GetLastApartmentApplicationId();
            Console.WriteLine($"{lastApartmentApplicationId} :Last ApartmentApplicationId for application for {buildingAddress} from table ApartmentApplications");

            string guarantorId = DBRequestGuarantorsOLD.GetLastGuarantorIdByApartmentApplicationId($"{lastApartmentApplicationId}");
            Console.WriteLine($"{guarantorId} :Last Id by GuarantorId for application for {tenantJimmy} {tenantGuarantor} for {buildingAddress} from table Guarantors");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("NewApplication")]

        public void NewApplicationTenantApplicant()
        {
            string buildingAddress = DBTestDataDBForAdmins.BUILDING_ADDRESS;

            string lastId = DBRequestApartmentApplicationsOLD.GetLastApartmentApplicationId();
            Console.WriteLine($"{lastId} :Last Id for application for {buildingAddress} from table ApartmentApplications");

            string idApartmentByBuildingId = DBRequestApartments.GetApartmentIdByBuildingIdUnit(DBTestDataDBForAdmins.BUILDING_ID, DBTestDataDBForAdmins.UNIT_NUMBER);
            Console.WriteLine($"{idApartmentByBuildingId} :ApartmentId by BuildingId from Apartments");

            string lastApplicationIdByBuildingId = DBRequestApartmentApplicationsOLD.GetLastApartmentApplicationIdByApartmentId($"{idApartmentByBuildingId}");
            Console.WriteLine($"{lastApplicationIdByBuildingId} :Last Id by BuildingId for application for {buildingAddress} from table ApartmentApplications");

            string lastApplicationIdByTenantId = DBRequestApartmentApplicationsOLD.GetLastApartmentApplicationIdByTenantId(DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_USER_ID);
            Console.WriteLine($"{lastApplicationIdByTenantId} :Last Id by tenantId for application for {buildingAddress} from table ApartmentApplications");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(lastId, lastApplicationIdByBuildingId);
                Console.WriteLine($"ApplicationId last from ApartmentApplications: {lastId} = {lastApplicationIdByBuildingId} ApplicationId last by BuildingId from ApartmentApplications");

                Assert.AreEqual(lastId, lastApplicationIdByTenantId);
                Console.WriteLine($"ApplicationId last from ApartmentApplications: {lastId} = {lastApplicationIdByTenantId} ApplicationId last by TenantId from ApartmentApplications");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("NewApplicationTenantApplicantOccupantJointGuarantor")]

        public void NewApplicationTenantApplicantOccupantJointGuarantor()
        {
            string buildingAddress = DBTestDataDBForAdmins.BUILDING_ADDRESS;

            string tenantApplicant = DBTestDataGeneral.NAME_ROLE_APPLICANT;
            string tenantOccupant = DBTestDataGeneral.NAME_ROLE_OCCUPANT;
            string tenantGuarantor = DBTestDataGeneral.NAME_ROLE_GUARANTOR;

            string tenantRay = TestDataForWebSiteTenant.FIRST_NAME_TENANT_APPLICANT;
            string tenantLiza = TestDataForWebSiteTenant.FIRST_NAME_OCCUPANT_ONE;
            string tenantJimmy = TestDataForWebSiteTenant.FIRST_NAME_GUARANTOR;

            string lastApartmentApplicationId = DBRequestApartmentApplicationsOLD.GetLastApartmentApplicationId();
            Console.WriteLine($"{lastApartmentApplicationId} :Last ApartmentApplicationId for application for {buildingAddress} from table ApartmentApplications");

            string idApartmentByBuildingId = DBRequestApartments.GetApartmentIdByBuildingIdUnit(DBTestDataDBForAdmins.BUILDING_ID, DBTestDataDBForAdmins.UNIT_NUMBER);
            Console.WriteLine($"{idApartmentByBuildingId} :ApartmentId by BuildingId from Apartments");

            string lastApplicationIdByBuildingId = DBRequestApartmentApplicationsOLD.GetLastApartmentApplicationIdByApartmentId(idApartmentByBuildingId);
            Console.WriteLine($"{lastApplicationIdByBuildingId} :Last ApartmentApplicationId Id by BuildingId for application for {buildingAddress} from table ApartmentApplications");

            string lastApplicationIdByTenantId = DBRequestApartmentApplicationsOLD.GetLastApartmentApplicationIdByTenantId(DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_USER_ID);
            Console.WriteLine($"{lastApplicationIdByTenantId} :Last ApartmentApplicationId by TenantId for application for {buildingAddress} from table ApartmentApplications");

            string guarantorId = DBRequestGuarantorsOLD.GetLastGuarantorIdByApartmentApplicationId($"{lastApartmentApplicationId}");
            Console.WriteLine($"{guarantorId} :Last Id by GuarantorId for application for {tenantJimmy} {tenantGuarantor} for {buildingAddress} from table Guarantors");

            string lastIdGuarantorIdApartmentApplicationId = DBRequestApartmentApplicationApplicantsOLD.GetIdByGuarantorIdApartmentApplicationId(lastApartmentApplicationId, guarantorId);
            Console.WriteLine($"{lastIdGuarantorIdApartmentApplicationId} :Last Id for application for {buildingAddress} from table ApartmentApplicationApplicants");

            string occupantId = DBRequestOccupantsOLD.GetLastOccupantIdByApartmentApplicationId(lastApartmentApplicationId);
            Console.WriteLine($"{occupantId} :Last by UserId for application for {tenantLiza} {tenantOccupant} for {buildingAddress} from table Occupants");

            string lastIdByOccupantIdApartmentApplicationId = DBRequestApartmentApplicationApplicantsOLD.GetIdByOccupantIdApartmentApplicationId(lastApartmentApplicationId, occupantId);
            Console.WriteLine($"{lastIdByOccupantIdApartmentApplicationId} :Last by UserId for application for {tenantLiza} {tenantOccupant} for {buildingAddress} from table ApartmentApplicationApplicants");

            string lastIdByOccupantId = DBRequestApartmentApplicationApplicantsOLD.GetLastIdByOccupantId(occupantId);
            Console.WriteLine($"{lastIdByOccupantId} :Last Id by OccupantId Id for application for {tenantLiza} {tenantOccupant} for {buildingAddress} from table Occupants");

            string lastIdByGuarantorId = DBRequestApartmentApplicationApplicantsOLD.GetLastIdByGuarantorId(guarantorId);
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

        public void NewRecordApplicationProgressApplicant()
        {
            string buildingAddress = DBTestDataDBForAdmins.BUILDING_ADDRESS;

            string lastId = DBRequestApartmentApplicationProgressOLD.GetLastId();
            Console.WriteLine($"{lastId} :Last Id for application for {buildingAddress} from table ApartmentApplicationProgress");

            string lastApartmentApplicationId = DBRequestApartmentApplicationsOLD.GetLastApartmentApplicationId();
            Console.WriteLine($"{lastApartmentApplicationId} :Last ApartmentApplicationId for application for {buildingAddress} from table ApartmentApplications");

            string lastIdByTenantIdApartmentApplicationId = DBRequestApartmentApplicationProgressOLD.GetLastIdByTenantIdApartmentApplicationId(DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_TENANT_ID, lastApartmentApplicationId);
            Console.WriteLine($"{lastIdByTenantIdApartmentApplicationId} :Last Id for application for {buildingAddress} from table ApartmentApplicationProgress");

            string lastApartmentApplicationIdByIdTenantId = DBRequestApartmentApplicationProgressOLD.GetLastIdApplicantByApartmentApplicationIdTenantId(DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_TENANT_ID);
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

        public void NewRecordApplicationProgressApplicantOccupantJointGuarantor()
        {
            string buildingAddress = DBTestDataDBForAdmins.BUILDING_ADDRESS;

            string lastIdApplicant = DBRequestApartmentApplicationProgressOLD.GetLastIdApplicantByTenantId(DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_TENANT_ID);
            Console.WriteLine($"{lastIdApplicant} :Last Id tenant-applicant for application for {buildingAddress} from table ApartmentApplicationProgress");

            string lastIdOccupant = DBRequestApartmentApplicationProgressOLD.GetLastIdByTenantId(DBTestDataForTenantMarketplaceOne.TENANT_OCCUPANT_LIZA_TENANT_ID);
            Console.WriteLine($"{lastIdOccupant} :Last Id tenant-occupant for application for {buildingAddress} from table ApartmentApplicationProgress");

            string lastIdGuarantor = DBRequestApartmentApplicationProgressOLD.GetLastIdByTenantId(DBTestDataForTenantMarketplaceOne.TENANT_GUARANTOR_JIMMY_TENANT_ID);
            Console.WriteLine($"{lastIdGuarantor} :Last Id tenant-guarantor for application for {buildingAddress} from table ApartmentApplicationProgress");

            string lastApartmentApplicationId = DBRequestApartmentApplicationsOLD.GetLastApartmentApplicationId();
            Console.WriteLine($"{lastApartmentApplicationId} :Last ApartmentApplicationId for application for {buildingAddress} from table ApartmentApplications");

            string lastIdApplicantByApartmentApplicationId = DBRequestApartmentApplicationProgressOLD.GetLastIdApplicantByApartmentApplicationId(lastApartmentApplicationId);
            Console.WriteLine($"{lastIdApplicantByApartmentApplicationId} :Last Id tenant-applicant for application for {buildingAddress} from table ApartmentApplicationProgress");

            string lastIdOccupantByApartmentApplicationId = DBRequestApartmentApplicationProgressOLD.GetLastIdOccupantByApartmentApplicationId(lastApartmentApplicationId);
            Console.WriteLine($"{lastIdOccupantByApartmentApplicationId} :Last Id tenant-occupant for application for {buildingAddress} from table ApartmentApplicationProgress");

            string lastIdGuarantorApartmentApplicationId = DBRequestApartmentApplicationProgressOLD.GetLastIdGuarantorByApartmentApplicationId(lastApartmentApplicationId);
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
        [AllureSubSuite("DeleteNewlyCreatedApplicationViaButtonPlusApplicationWithTenantApplicant")]

        public void DeleteNewlyCreatedApplicationViaButtonPlusApplicationWithTenantApplicant()
        {
            #region Preconditions

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;
            string buildingAddress = "1 Washington Square";
            string unitNumber = "4";
            string emailTenant = "task1567n51t@putsbox.com";

            #endregion

            var apartmentId = DBRequestApartments.Apartments.GetIdByUnitNumberAndBuildingAddressForApartment(buildingAddress, unitNumber, marketplaceId).Id;
            Console.WriteLine($"ApartmentId: {apartmentId}");
            var apartmentApplicationId = DBRequestApartmentApplications.ApartmentApplications.GetApartmentApplicationIdByApartmentIdTenantEmail(apartmentId, emailTenant, marketplaceId).Id;
            Console.WriteLine($"ApartmentApplicationId: {apartmentApplicationId}");
            DBRequestTenantLeases.TenantLeases.DeleteRecordByApartmentApplicationIdOnlyTenantApplicant(apartmentApplicationId, emailTenant, marketplaceId);
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
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("DeleteNewlyCreatedApplicationViaButtonPlusApplicationWithNewTenantAppOccGuar")]

        public void DeleteNewlyCreatedApplicationViaButtonPlusApplicationWithNewTenantAppOccGuar()
        {
            #region Preconditions

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;
            string buildingAddress = "18 Linden Street";
            string unitNumber = "42";
            string emailTenantCreator = "task1588n11creator@putsbox.com";
            string emailTenantOccupant = "task1588n11occupant@putsbox.com";
            string emailTenantGuarantor = "task1588n11guarantor@putsbox.com";

            #endregion

            var apartmentId = DBRequestApartments.Apartments.GetIdByUnitNumberAndBuildingAddressForApartment(buildingAddress, unitNumber, marketplaceId).Id;
            Console.WriteLine($"ApartmentId: {apartmentId}");
            var apartmentApplicationId = DBRequestApartmentApplications.ApartmentApplications.GetApartmentApplicationIdByApartmentIdTenantEmail(apartmentId, emailTenantCreator, marketplaceId).Id;
            Console.WriteLine($"ApartmentApplicationId: {apartmentApplicationId}");
            DBRequestTenantLeases.TenantLeases.DeleteRecordByApartmentApplicationIdTenantAppOccGuar(apartmentApplicationId, emailTenantCreator, marketplaceId, emailTenantOccupant, emailTenantGuarantor);
            WaitUntil.WaitSomeInterval(100);
            DBRequestApartmentApplicationApplicants.ApartmentApplicationApplicants.DeleteRecordByEmailMarketplaceIdForTenantOcc(apartmentApplicationId, emailTenantOccupant, marketplaceId);
            WaitUntil.WaitSomeInterval(100);
            DBRequestApartmentApplicationApplicants.ApartmentApplicationApplicants.DeleteRecordByEmailMarketplaceIdForTenantGuar(apartmentApplicationId, emailTenantGuarantor, marketplaceId);
            WaitUntil.WaitSomeInterval(100);
            DBRequestGuarantors.Guarantors.DeleteRecordByEmailMarketplaceIdForTenantGuar(apartmentApplicationId, emailTenantGuarantor);
            WaitUntil.WaitSomeInterval(100);
            DBRequestOccupants.Occupants.DeleteRecordByEmailMarketplaceIdForTenantOcc(apartmentApplicationId, emailTenantOccupant);
            WaitUntil.WaitSomeInterval(100);
            DBRequestApartmentApplicationProgress.ApartmentApplicationProgress.DeleteRecordByApartmentApplicationId(apartmentApplicationId, emailTenantCreator, marketplaceId);
            WaitUntil.WaitSomeInterval(100);
            DBRequestApplicationPrices.ApplicationPrices.DeleteRecordByApartmentApplicationId(apartmentApplicationId);
            WaitUntil.WaitSomeInterval(100);
            DBRequestApartmentApplications.ApartmentApplications.DeleteRecordByApartmentId(apartmentId, emailTenantCreator, marketplaceId);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApplication")]
        [AllureSubSuite("EmptyFour")]

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

        public void Demo()
        {
            #region Preconditions

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;
            string buildingAddress = "1 Washington Square";
            string unitNumber = "4";
            string emailTenantCreator = TestDataForWebSiteTenant.EMAIL_TENANT_APPLICANT;
            string emailTenantOccupant = TestDataForWebSiteTenant.EMAIL_CURRENT_OCCUPANT_ONE;
            string emailTenantGuarantor = TestDataForWebSiteTenant.EMAIL_GUARANTOR;

            #endregion

            var apartmentId = DBRequestApartments.Apartments.GetIdByUnitNumberAndBuildingAddressForApartment(buildingAddress, unitNumber, marketplaceId).Id;
            Console.WriteLine($"ApartmentId: {apartmentId}");
            var apartmentApplicationId = DBRequestApartmentApplications.ApartmentApplications.GetApartmentApplicationIdByApartmentIdTenantEmail(apartmentId, emailTenantCreator, marketplaceId).Id;
            Console.WriteLine($"ApartmentApplicationId: {apartmentApplicationId}");
            DBRequestApartmentApplications.ApartmentApplications.DeleteApartmentApplicationWithTenantsAppOccGuarAlreadyCreated(apartmentId, apartmentApplicationId, emailTenantCreator, emailTenantOccupant, emailTenantGuarantor, marketplaceId);
        }
    }
}
