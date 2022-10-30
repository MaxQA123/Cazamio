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
            string getUserName = Browser._Driver.FindElement(By.XPath("//div[@class = 'user-name']")).Text;
            string getUserNameActual = getUserName.ToString();

            return getUserNameActual;
        }

        [AllureStep("VerifyLandlordUserName")]
        public SideBarLandlord VerifyLandlordUserName(string getUserNameActual)
        {
            WaitUntil.WaitSomeInterval(1500);
            string getUserNameExpected = TestDataForWebSiteLandlord.USER_NAME_LANDLORD_TEST ;

            Assert.AreEqual(getUserNameExpected, getUserNameActual);

            Console.WriteLine($"First Last name EX: {getUserNameExpected} AC: {getUserNameActual}");

            return this;
        }

        [AllureStep("VerifyBrokerUserName")]
        public SideBarLandlord VerifyBrokerUserName(string getUserNameActual)
        {
            WaitUntil.WaitSomeInterval(500);
            string getUserNameExpected = TestDataForWebSiteLandlord.USER_NAME_BROKER;

            Assert.AreEqual(getUserNameExpected, getUserNameActual);

            Console.WriteLine($"First Last name EX: {getUserNameExpected} AC: {getUserNameActual}");

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
