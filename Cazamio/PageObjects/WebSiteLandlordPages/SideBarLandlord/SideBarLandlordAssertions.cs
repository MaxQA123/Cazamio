using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.SideBarLandlord
{
    public partial class SideBarLandlord
    {
        [AllureStep("GetUserNameFromSideBar")]
        public string GetUserNameFromSideBar()
        {
            WaitUntil.CustomElementIsVisible(UserNameOfSidebarLandlordWebSite);
            string getUserName = UserNameOfSidebarLandlordWebSite.Text;
            string getUserNameActual = getUserName.ToString();

            return getUserNameActual;
        }

        [AllureStep("GetUserNameRoleFromSideBar")]
        public string GetUserNameRoleFromSideBar()
        {
            WaitUntil.CustomElementIsVisible(UserNameRoleOfSidebarLandlordWebSite);
            string getUserNameRole = UserNameRoleOfSidebarLandlordWebSite.Text;
            string getUserNameRoleActual = getUserNameRole.ToString();

            return getUserNameRoleActual;
        }

        [AllureStep("VerifyAdminUserName")]
        public SideBarLandlord VerifyAdminUserName(string getUserNameActual, string getUserNameRoleActual)
        {
            WaitUntil.WaitSomeInterval(1500);
            string getUserNameExpected = TestDataForWebSiteAdmin.USER_NAME_ADMIN_TEST_GARY;
            string getUserNameRoleExpected = TestDataForWebSiteAdmin.USER_NAME_ROLE_ADMIN;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(getUserNameExpected, getUserNameActual);
                Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual);

                Console.WriteLine($"First Last name EX: {getUserNameExpected} First Last name AC: {getUserNameActual}");
                Console.WriteLine($"Name Role EX: {getUserNameRoleExpected} Name Role AC: {getUserNameRoleActual}");
            });
            return this;
        }

        [AllureStep("VerifyOnlyAdminUserNameRole")]
        public SideBarLandlord VerifyOnlyAdminUserNameRole(string getUserNameRoleActual)
        {
            WaitUntil.WaitSomeInterval(1500);
            string getUserNameRoleExpected = TestDataForWebSiteAdmin.USER_NAME_ROLE_ADMIN;

            
                Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual);

                Console.WriteLine($"Name Role EX: {getUserNameRoleExpected} Name Role AC: {getUserNameRoleActual}");
            
            return this;
        }

        [AllureStep("VerifySuperAdminUserName")]
        public SideBarLandlord VerifySuperAdminUserName(string getUserNameActual, string getUserNameRoleActual)
        {
            WaitUntil.WaitSomeInterval(1500);
            string getUserNameExpected = TestDataForWebSiteAdmin.USER_NAME_SUPER_ADMIN;
            string getUserNameRoleExpected = TestDataForWebSiteAdmin.USER_NAME_ROLE_SUPER_ADMIN;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(getUserNameExpected, getUserNameActual);
                Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual);

                Console.WriteLine($"First Last name EX: {getUserNameExpected} First Last name AC: {getUserNameActual}");
                Console.WriteLine($"Name role EX: {getUserNameRoleExpected} Name role AC: {getUserNameRoleActual}");
            });

            return this;
        }

        [AllureStep("VerifyBrokerUserName")]
        public SideBarLandlord VerifyBrokerUserName(string getUserNameActual, string getUserNameRoleActual)
        {
            WaitUntil.WaitSomeInterval(500);
            string getUserNameExpected = TestDataForWebSiteAdmin.USER_NAME_BROKER;
            string getUserNameRoleExpected = TestDataForWebSiteAdmin.USER_NAME_ROLE_BROKER;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(getUserNameExpected, getUserNameActual);
                Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual);

                Console.WriteLine($"First Last name EX: {getUserNameExpected} First Last name AC: {getUserNameActual}");
                Console.WriteLine($"Name role EX: {getUserNameRoleExpected} Name role AC: {getUserNameRoleActual}");
            });

            return this;
        }

        [AllureStep("VerifyChangingLogoImageLandlord")]
        public SideBarLandlord VerifyChangingLogoImageLandlord()
        {
            Assert.IsTrue(Successfully.IsVisible(MessageChangeImageLogoLandlordSuccess));

            return this;
        }

        [AllureStep("VerifyChangingAvatarImageLandlord")]
        public SideBarLandlord VerifyChangingAvatarImageLandlord()
        {
            Assert.IsTrue(Successfully.IsVisible(MessageChangeImageAvatarUserSuccess));

            return this;
        }

        [AllureStep("VerifyRewmoveAvatarImageLandlord")]
        public SideBarLandlord VerifyRewmoveAvatarImageLandlord()
        {
            Assert.IsTrue(Successfully.IsVisible(MessageRemoveImageAvatarUserSuccess));

            return this;
        }
    }
}
