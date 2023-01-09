using Allure.Commons;
using CazamioProgect.Helpers;
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
        [AllureSubSuite("GetIdBuildingByName")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: by table dbo.ApartmentApplicationProgress
        //Path to cheking's: 

        public void RelatedApplicationWithTenant()
        {
            string tenantApplicant = "Applicant";
            string tenantOccupant = "Occupant";
            string tenantGuarantor = "Guarantor";
            string apartmentNumber = "Fred Dred";

            string idTenantApplicant = DBApplications.GetTenantIdApplicant("tenantswife@gmail.com");
            Console.WriteLine($"Id for tenant {tenantApplicant} from table tenants: {idTenantApplicant}");
            string idTenantOccupant = DBApplications.GetTenantIOccupant("apipostman65455@gmail.com");
            Console.WriteLine($"Id for tenant {tenantApplicant} from table tenants: {idTenantOccupant}");
            string idTenantGuarantor = DBApplications.GetTenantIGuarantor("guarantor5935@gmail.com");
            Console.WriteLine($"Id for tenant {tenantApplicant} from table tenants: {idTenantGuarantor}");
            string idApplication = DBApplications.GetIdNewApplication();
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
    }
}
