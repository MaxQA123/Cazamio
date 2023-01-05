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

namespace CazamioProject.BaseTestsDBBrokers
{
    [TestFixture]
    [AllureNUnit]

    public class BrokersTestsDB
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

        public void RelatedBrokerWithAdmin()
        {
            string brokerName = "Fred Dred";

            string idBroker = DBBrokers.GetIdBrokerFromBrokersT("joingilbert901broker@gmail.com");
            Console.WriteLine($"Id for broker {brokerName} from table Brokers: {idBroker}");
            string landlordIdByEmail = DBBrokers.GetLandlordIdByBrokerId("joingilbert901broker@gmail.com");
            Console.WriteLine($"LandlordId by Email for broker {brokerName} from table LandlordBrokers: {landlordIdByEmail}");
            string landlordIdByBrokerid = DBBrokers.GetLandlordIdForNewBroker();
            Console.WriteLine($"LandlordId for new broker {brokerName} from table LandlordBrokers: {landlordIdByBrokerid}");
            Assert.AreEqual(landlordIdByEmail, landlordIdByBrokerid);
            Console.WriteLine($"LandlordId by email broker AspNetUsers: {landlordIdByEmail} = {landlordIdByBrokerid} LandlordId for new broker in the table LandlordBrokers");
        }
    }
}
