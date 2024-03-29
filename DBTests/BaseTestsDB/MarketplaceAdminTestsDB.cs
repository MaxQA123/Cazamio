﻿using Allure.Commons;
using ApiTests.Base;
using CazamioProgect.Helpers;
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

    public class MarketplaceAdminTestsDB : Base
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBMarketplaceAdmin")]
        [AllureSubSuite("CheckAlreadyCreatedMarketplaceAdmin")]

        public void CheckAlreadyCreatedMarketplaceAdmin()
        {
            #region Test

            string newMarketplaceAdmin = DBTestDataDBForAdmins.NEW_MARKETPLACE_ADMIN_FIRST_NAME;

            string userIdMAByEmail = DBRequestAspNetUsersOld.GetIdByEmailMarketplaceId(DBTestDataDBForAdmins.NEW_MARKETPLACE_ADMIN_EMAIL, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
            Console.WriteLine($"{userIdMAByEmail} :UserId MA by Email from table AspNetUsers");

            string lastUserIdMA = DBRequestMarketplaceAdminsOld.GetLastUserIdNewMarketplaceAd();
            Console.WriteLine($"{lastUserIdMA} :UserId last MA from table MarketplaceAdmins");

            string lastMarketplaceIdMA = DBRequestMarketplaceAdminsOld.GetLastMarketplaceIdNewMarketplaceAd();
            Console.WriteLine($"{lastMarketplaceIdMA} :MarketplsaceId last MA from table MarketplaceAdmins");

            string lastMarketplaceIdByUserIdMA = DBRequestMarketplaceAdminsOld.GetLastMarketplaceIdByUserIdNewMarketplaceAd(userIdMAByEmail);
            Console.WriteLine($"{lastMarketplaceIdByUserIdMA} :MarketplsaceId last by UserId MA from table MarketplaceAdmins");

            string lastIdMA = DBRequestMarketplaceAdminsOld.GetLastIdNewMarketplaceAd();
            Console.WriteLine($"{lastIdMA} :Id last by UserId MA from table MarketplaceAdmins");

            string lastIByUserIddMA = DBRequestMarketplaceAdminsOld.GetLastIdByUserIdNewMarketplaceAd(lastUserIdMA);
            Console.WriteLine($"{lastIByUserIddMA} :Id last by UserId MA from table MarketplaceAdmins");

            string nameRoleByEmailMA = DBTableAspNetRoles.GetRoleNameByEmail(DBTestDataDBForAdmins.NEW_MARKETPLACE_ADMIN_EMAIL);
            Console.WriteLine($"{nameRoleByEmailMA} :Name role by email MA from table AspNetRoles");

            string roleIdByUserIdMA = DBTableAspNetUserRoles.GetRoleIdNewByUserId(userIdMAByEmail);
            Console.WriteLine($"{roleIdByUserIdMA} :Name role by email MA from table AspNetRoles");

            string emailMA = DBRequestAspNetUsersOld.GetEmailByIdNew(userIdMAByEmail);
            Console.WriteLine($"{emailMA} :Email by id MA from table AspNetUsers");

            #endregion

            #region Assertions

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

            #endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBMarketplaceAdmin")]
        [AllureSubSuite("DeleteNewlyCreatedMarketplaceAdmin")]

        public void DeleteNewlyCreatedMarketplaceAdmin()
        {
            #region Preconditions

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;
            string emailMarketplaceAdmin = "ten3bagtest@gmail.com";

            #endregion

            #region Test

            DBRequestAspNetUsers.AspNetUsers.GetEmailByEmailAndMarketplaceId(emailMarketplaceAdmin, marketplaceId);
            Console.WriteLine($"{emailMarketplaceAdmin}");
            WaitUntil.WaitSomeInterval(100);
            DBRequestMarketplaceAdmins.MarketplaceAdmins.DeleteCreatedUserMarketplaceAdmin(emailMarketplaceAdmin, marketplaceId);
            WaitUntil.WaitSomeInterval(100);
            DBRequestAspNetUsers.AspNetUsers.DeleteCreatedUser(emailMarketplaceAdmin, marketplaceId);

            #endregion
        }
    }
}
