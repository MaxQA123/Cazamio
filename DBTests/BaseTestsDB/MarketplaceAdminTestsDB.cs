using Allure.Commons;
using CazamioProject.DBHelpers;
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

    public class MarketplaceAdminTestsDB
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBMarketplaceAdmin")]
        [AllureSubSuite("RelatedBuidingBroker")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "MarketplaceAdmins", "AspNetRoles".
        //Path to cheking's:

        public void CreateMarketplaceAdmin()
        {
            string newMarketplaceAdmin = DBTestDataDBForAdmins.NEW_MARKETPLACE_ADMIN_FIRST_NAME;

            string userIdMAByEmail = DBTableAspNetUsers.GetIdByEmailMarketplaceId(DBTestDataDBForAdmins.NEW_MARKETPLACE_ADMIN_EMAIL, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
            Console.WriteLine($"{userIdMAByEmail} :UserId MA by Email from table AspNetUsers");

            string lastUserIdMA = DBTableMarketplaceAdmins.GetLastUserIdNewMarketplaceAd();
            Console.WriteLine($"{lastUserIdMA} :UserId last MA from table MarketplaceAdmins");

            string lastMarketplaceIdMA = DBTableMarketplaceAdmins.GetLastMarketplaceIdNewMarketplaceAd();
            Console.WriteLine($"{lastMarketplaceIdMA} :MarketplsaceId last MA from table MarketplaceAdmins");

            string lastMarketplaceIdByUserIdMA = DBTableMarketplaceAdmins.GetLastMarketplaceIdByUserIdNewMarketplaceAd(userIdMAByEmail);
            Console.WriteLine($"{lastMarketplaceIdByUserIdMA} :MarketplsaceId last by UserId MA from table MarketplaceAdmins");

            string lastIdMA = DBTableMarketplaceAdmins.GetLastIdNewMarketplaceAd();
            Console.WriteLine($"{lastIdMA} :Id last by UserId MA from table MarketplaceAdmins");

            string lastIByUserIddMA = DBTableMarketplaceAdmins.GetLastIdByUserIdNewMarketplaceAd(lastUserIdMA);
            Console.WriteLine($"{lastIByUserIddMA} :Id last by UserId MA from table MarketplaceAdmins");

            string nameRoleByEmailMA = DBTableAspNetRoles.GetRoleNameByEmail(DBTestDataDBForAdmins.NEW_MARKETPLACE_ADMIN_EMAIL);
            Console.WriteLine($"{nameRoleByEmailMA} :Name role by email MA from table AspNetRoles");

            string roleIdByUserIdMA = DBTableAspNetUserRoles.GetRoleIdNewByUserId(userIdMAByEmail);
            Console.WriteLine($"{roleIdByUserIdMA} :Name role by email MA from table AspNetRoles");

            string emailMA = DBTableAspNetUsers.GetEmailByIdNew(userIdMAByEmail);
            Console.WriteLine($"{emailMA} :Email by id MA from table AspNetUsers");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(userIdMAByEmail, lastUserIdMA);
                Console.WriteLine($"UserId a new MA from table AspNetUsers: {userIdMAByEmail} = {lastUserIdMA} UserId last for MA from table MarketplaceAdmins");

                Assert.AreEqual(lastMarketplaceIdMA, lastMarketplaceIdByUserIdMA);
                Console.WriteLine($"MarketplsaceId last a new MA from table AspNetUsers: {lastMarketplaceIdMA} = {lastMarketplaceIdByUserIdMA} MarketplsaceId last by UserId for MA from table MarketplaceAdmins");

                Assert.AreEqual(lastIdMA, lastIByUserIddMA);
                Console.WriteLine($"Id last a new MA from table AspNetUsers: {lastIdMA} = {lastIByUserIddMA} Id last by UserId for MA from table MarketplaceAdmins");

                Assert.AreEqual(nameRoleByEmailMA, DBTestDataGeneral.NAME_ROLE_MARKETPLACE_ADMIN);
                Console.WriteLine($"Name role by email for MA from table AspNetRoles: {nameRoleByEmailMA} = {DBTestDataGeneral.NAME_ROLE_MARKETPLACE_ADMIN} Name role for MA ER");

                Assert.AreEqual(roleIdByUserIdMA, DBTestDataGeneral.ID_NAME_ROLE_MARKETPLACE_ADMIN);
                Console.WriteLine($"RoleId by UserId for MA from table AspNetUserRoles: {roleIdByUserIdMA} = {DBTestDataGeneral.ID_NAME_ROLE_MARKETPLACE_ADMIN} RoleId for MA ER");

                Assert.AreEqual(emailMA, DBTestDataDBForAdmins.NEW_MARKETPLACE_ADMIN_EMAIL);
                Console.WriteLine($"Email by Id for MA from table AspNetUsers: {emailMA} = {DBTestDataDBForAdmins.NEW_MARKETPLACE_ADMIN_EMAIL} Email for MA ER");
            });
        }
    }
}
