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
        [AllureSuite("TestingDBBroker")]
        [AllureSubSuite("GetIdApartmentFromBD")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: 
        //Path to cheking's: 

        public void RelatedOwnerWithAdmin()
        {
            string ownerName = "Human";
            string adminName = "Fred Dred";

            string idOwner = DBOwners.GetIdOwnerByEmail();
            Console.WriteLine($"Id for owner {ownerName} from table Owners: {idOwner}");
            string landlordId = DBOwners.GetLandlordIdByOwnerEmail("g6gd433j@xitroo.com");
            Console.WriteLine($"landlordId for owner {ownerName} from table Owners: {landlordId}");
            string marketplaceId = DBOwners.GetMarketplaceIdByOwnerEmail("g6gd433j@xitroo.com");
            Console.WriteLine($"MarketplaceId for owner {ownerName} from table Owners: {marketplaceId}");
            string ownerId = DBOwners.GetOwnerIdByNameOwnerMgmt("gf645gd43h@xitroo.com");
            Console.WriteLine($"MarketplaceId for owner {ownerName} from table Owners: {ownerId}");
            Assert.AreEqual(idOwner, ownerId);
            Console.WriteLine($"Id for owner {ownerName} from Owners: {idOwner} = {ownerId} OwnerId for owner {ownerName} in the table OwnerManagements");
            string idAdmin = DBAdmins.GetIdAdminFromLandlordsT("su1per2ad3min@gmail.com");
            Console.WriteLine($"Id for admin {adminName} from table Landlords: {idAdmin}");
            Assert.AreEqual(landlordId, idAdmin);
            Console.WriteLine($"LandlordId for owner {ownerName} from table Owners: {landlordId} = {idAdmin} IdAdmin for owner {ownerName} in the table Landlords");


        }
    }
}
