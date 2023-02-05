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

namespace CazamioProject.BaseTestsDBOwners
{
    [TestFixture]
    [AllureNUnit]

    public class OwnersTestsDB
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBOwner")]
        [AllureSubSuite("RecordsDBAboutNewOwner")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Owners".
        //Path to cheking's: 

        public void RecordsDBAboutNewOwner()
        {
            string nameOwner = TestDataDBForWebSiteAdmin.NEW_OWNER_FIRST_LAST_NAME;

            string ownerIdOwnerViaEmail = DBOwners.GetCreatedByUserIdOwnerByEmailFromOwners(TestDataDBForWebSiteAdmin.NEW_OWNER_EMAIL);
            Console.WriteLine($"{ownerIdOwnerViaEmail} :CreatedByUserId wner via email for owner {nameOwner} from table Owners");

            string ownerIdOwnerViaId = DBOwners.GetCreatedByUserIdNewOwnerFromOwners();
            Console.WriteLine($"{ownerIdOwnerViaId} :CreatedByUserId owner via id for owner {nameOwner} from table Owners");

            string landlordIdOwnerViaEmail = DBOwners.GetLandlordIdOwnerByEmailFromOwners(TestDataDBForWebSiteAdmin.NEW_OWNER_EMAIL);
            Console.WriteLine($"{landlordIdOwnerViaEmail} :LandlordId owner via email for owner {nameOwner} from table Owners");

            string landlordIdOwnerViaId = DBOwners.GetLandlordIdOwnerByIdFromOwners();
            Console.WriteLine($"{landlordIdOwnerViaId} :LandlordId owner via id for owner {nameOwner} from table Owners");

            string marketplaceIdOwnerViaEmail = DBOwners.GetMarketplaceIdOwnerByEmailFromOwners(TestDataDBForWebSiteAdmin.NEW_OWNER_EMAIL);
            Console.WriteLine($"{marketplaceIdOwnerViaEmail} :LandlordId owner via email for owner {nameOwner} from table Owners");

            string marketplaceIdOwnerViaId = DBOwners.GetMarketplaceIdOwnerByIdFromOwners();
            Console.WriteLine($"{marketplaceIdOwnerViaId} :LandlordId owner via id for owner {nameOwner} from table Owners");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(ownerIdOwnerViaEmail, ownerIdOwnerViaId);
                Console.WriteLine($"CreatedByUserId owner via email for owner from table Owners: {ownerIdOwnerViaEmail} = {ownerIdOwnerViaId} CreatedByUserId owner via id for owner from table Owners");

                Assert.AreEqual(landlordIdOwnerViaEmail, landlordIdOwnerViaId);
                Console.WriteLine($"LandlordId owner via email for owner from table Owners: {landlordIdOwnerViaEmail} = {landlordIdOwnerViaId} LandlordId owner via id for owner from table Owners");

                Assert.AreEqual(marketplaceIdOwnerViaEmail, marketplaceIdOwnerViaId);
                Console.WriteLine($"LandlordId owner via email for owner from table Owners: {marketplaceIdOwnerViaEmail} = {marketplaceIdOwnerViaId} LandlordId owner via id for owner from table Owners");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBOwner")]
        [AllureSubSuite("RelatedOwnerWithAdmin")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: 
        //Path to cheking's: 

        public void RelatedOwnerWithAdmin()
        {
            
        }
    }
}
