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
            string nameOwner = DBTestDataDBForAdmins.NEW_OWNER_FIRST_LAST_NAME;

            string createdByUserIdViaEmail = DBTableOwners.GetCreatedByUserIdOwnerByOwnerEmail(DBTestDataDBForAdmins.NEW_OWNER_EMAIL);
            Console.WriteLine($"{createdByUserIdViaEmail} :CreatedByUserId wner via email for owner {nameOwner} from table Owners");

            string createdByUserIdViaId = DBTableOwners.GetLasCreatedByUserIdById();
            Console.WriteLine($"{createdByUserIdViaId} :CreatedByUserId owner via id for owner {nameOwner} from table Owners");

            string ownerIdViaEmail = DBTableOwners.GetIdOwnerByOwnerEmail(DBTestDataDBForAdmins.NEW_OWNER_EMAIL);
            Console.WriteLine($"{ownerIdViaEmail} :OwnerId wner via email for owner {nameOwner} from table Owners");

            string ownerIdOwnerViaId = DBTableOwners.GetLastIdNewOwner();
            Console.WriteLine($"{ownerIdOwnerViaId} :OwnerId owner via id for owner {nameOwner} from table Owners");

            string landlordIdOwnerViaEmail = DBTableOwners.GetLandlordIdOwnerByOwnerEmail(DBTestDataDBForAdmins.NEW_OWNER_EMAIL);
            Console.WriteLine($"{landlordIdOwnerViaEmail} :LandlordId owner via email for owner {nameOwner} from table Owners");

            string landlordIdOwnerViaId = DBTableOwners.GetLastLandlordIdOwnerByIdOwner();
            Console.WriteLine($"{landlordIdOwnerViaId} :LandlordId owner via id for owner {nameOwner} from table Owners");

            string marketplaceIdOwnerViaEmail = DBTableOwners.GetMarketplaceIdOwnerByOwnerEmail(DBTestDataDBForAdmins.NEW_OWNER_EMAIL);
            Console.WriteLine($"{marketplaceIdOwnerViaEmail} :LandlordId owner via email for owner {nameOwner} from table Owners");

            string marketplaceIdOwnerViaId = DBTableOwners.GetLastMarketplaceIdOwner();
            Console.WriteLine($"{marketplaceIdOwnerViaId} :LandlordId owner via id for owner {nameOwner} from table Owners");

            string emailOwnerViaId = DBTableOwners.GetLastOwnerEmailNewOwnerByIdOwners();
            Console.WriteLine($"{emailOwnerViaId} :Email owner via id for owner {nameOwner} from table Owners");

            string ownerNameOwnerViaId = DBTableOwners.GetOwnerNameNewOwnerByIdOwners();
            Console.WriteLine($"{ownerNameOwnerViaId} :Owner Name owner via id for owner {nameOwner} from table Owners");

            string companyNameOwnerViaId = DBTableOwners.GetLastCompanyNameNewOwnerByIdOwners();
            Console.WriteLine($"{companyNameOwnerViaId} :Company Name owner via id for owner {nameOwner} from table Owners");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(createdByUserIdViaEmail, createdByUserIdViaId);
                Console.WriteLine($"CreatedByUserId owner via email for owner from table Owners: {createdByUserIdViaEmail} = {createdByUserIdViaId} CreatedByUserId owner via id for owner from table Owners");

                Assert.AreEqual(ownerIdViaEmail, ownerIdOwnerViaId);
                Console.WriteLine($"OwnerId owner via email for owner from table Owners: {ownerIdViaEmail} = {ownerIdOwnerViaId} OwnerId owner via id for owner from table Owners");

                Assert.AreEqual(landlordIdOwnerViaEmail, landlordIdOwnerViaId);
                Console.WriteLine($"LandlordId owner via email for owner from table Owners: {landlordIdOwnerViaEmail} = {landlordIdOwnerViaId} LandlordId owner via id for owner from table Owners");

                Assert.AreEqual(marketplaceIdOwnerViaEmail, marketplaceIdOwnerViaId);
                Console.WriteLine($"LandlordId owner via email for owner from table Owners: {marketplaceIdOwnerViaEmail} = {marketplaceIdOwnerViaId} LandlordId owner via id for owner from table Owners");

                Assert.AreEqual(emailOwnerViaId, DBTestDataDBForAdmins.NEW_OWNER_EMAIL);
                Console.WriteLine($"Email owner via email for owner from table Owners: {emailOwnerViaId} = {DBTestDataDBForAdmins.NEW_OWNER_EMAIL} Email owner via id for owner ER");

                Assert.AreEqual(ownerNameOwnerViaId, DBTestDataDBForAdmins.NEW_OWNER_FIRST_NAME);
                Console.WriteLine($"Owner Name owner via email for owner from table Owners: {companyNameOwnerViaId} = {DBTestDataDBForAdmins.NEW_OWNER_FIRST_NAME} Owner Name owner via id for owner ER");

                Assert.AreEqual(companyNameOwnerViaId, DBTestDataDBForAdmins.NEW_COMPANY_NAME_OWNER);
                Console.WriteLine($"Company Owner owner via email for owner from table Owners: {companyNameOwnerViaId} = {DBTestDataDBForAdmins.NEW_COMPANY_NAME_OWNER} LandlordId owner via id for owner ER");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBOwner")]
        [AllureSubSuite("Empty")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: 
        //Path to cheking's: 

        public void Empty()
        {
            
        }
    }
}
