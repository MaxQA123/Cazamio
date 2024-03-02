using Allure.Commons;
using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentBrokerTests
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseWeb : BaseAgentBroker
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("AgentBroker")]
        [AllureSubSuite("LogIn")]

        

        public void LogIn()
        {
            #region Test

            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsAgentBroker()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyAgentBrokerUserNameRole(getUserNameCompare, getUserNameRoleCompare);

            WaitUntil.WaitSomeInterval(2000);

            #endregion

        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("AgentBroker")]
        [AllureSubSuite("LogOut")]

        public void LogOut()
        {
            #region Preconditions

            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsAgentBroker()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyAgentBrokerUserNameRole(getUserNameCompare, getUserNameRoleCompare);

            #endregion

            #region Test

            Pages.SideBarLandlord
                .ClickButtonLogOut();
            Pages.LogInLandlord
                .VerifyTitleLogInPg();

            WaitUntil.WaitSomeInterval(2000);

            #endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("AgentBroker")]
        [AllureSubSuite("VerifySidebar")]

        public void VerifySidebar()
        {
            #region Preconditions

            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsAgentBroker()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyAgentBrokerUserNameRole(getUserNameCompare, getUserNameRoleCompare);

            #endregion

            #region Test

            Pages.SideBarLandlord
                .UploadImageAvatarUserLandlordFirst()
                .VerifyChangingAvatarImageLandlord()
                .UploadImageAvatarUserLandlordSecond()
                .VerifyChangingAvatarImageLandlord()
                .ClicklinkRemovePhotoOfLandlord()
                .VerifyRewmoveAvatarImageLandlord();
            //.ClickButtonDashboardSidebar();
            //Pages.Dashboard
            //    .VerifyTitleOfDashboardPg();
            Pages.SideBarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .VerifyTitleListOfBuildingsPg();
            Pages.SideBarLandlord
                .ClickButtonApartments();
            Pages.ListOfApartments
                .VerifyTitleListOfApartmentsPg();
            Pages.SideBarLandlord
                .ClickButtonApplications();
            Pages.ListOfApplications
                .VerifyTitleListOfApplicationsPg();
            Pages.SideBarLandlord
                .ClickButtonTransactions();
            Pages.ListOfTransactions
                .VerifyTitleTransactionsPg();
            Pages.SideBarLandlord
                .ClickButtonCommissions();
            Pages.ListOfCommissions
                .VerifyTitleListOfCommissionsPg();
            Pages.SideBarLandlord
                .ClickButtonLogOut();
            Pages.LogInLandlord
                .VerifyTitleLogInPg();

            WaitUntil.WaitSomeInterval(2000);

            #endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
        [AllureSubSuite("AddBuildingAssignedAgentBroker")]

        public void AddBuildingAssignedAgentBroker()
        {
            #region SettingsForBuilding

            //Added Filled only mandatory the data, but full address, AuthorizeNet
            //East 51st Street Pedestrian Crossing

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                 .EnterEmailPasswordLogInPgAsAgentBroker()
                 .ClickIconShowLogInPg()
                 .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyAgentBrokerUserNameRole(getUserNameCompare, getUserNameRoleCompare)
                .ClickButtonBuildings();

            #endregion

            #region Test

            Pages.ListOfBuildings
                .ClickButtonAddBuilding();
            Pages.NewBuilding
                .VerifyTitleNewBuildingPg()
                .SelectOwnerWithAgent()
                .EnterAgntBrkrFullAddressAgentBroker()
                .ClickFieldInputInternalNotes();

            string getAddressNewBuildingActual = Pages.NewBuilding.GetValueFromFieldAddress();

            KeyBoardActions.ClickTab();

            string getValueScreeningFee = Pages.NewBuilding.GetValueFromFieldCreditScreeningFee();

            Pages.NewBuilding
                .VerifyValueByDefaulScreeningFee(getValueScreeningFee)
                .ClickBtnSelectPaymentMethodsForCreditScreeningFee();
            Pages.ModalWindowPaymentOptions
                .SelectCrdtCrdDlvrChckZlVnmForHoldBuilding();
            Pages.NewBuilding
                .ClickBtnEditForPaymentSystem();
            Pages.MdlWndwPaymentKeys
                .SelectPaymentSystemAuthorizeNet();

            string getItemAuthorizeNetActual = Pages.MdlWndwPaymentKeys.GetItemAuthorizeNet();
            string getItemApiKeyAuthorizeNetActual = Pages.MdlWndwPaymentKeys.GetItemApiKeyAuthorizeNet();

            Pages.MdlWndwPaymentKeys
                .VerifyApiKeyAuthorizeNet(getItemAuthorizeNetActual, getItemApiKeyAuthorizeNetActual);
            Pages.MdlWndwPaymentKeys
                .ClickButtonSave();
            Pages.NewBuilding
                .ClickThreeTimesButtonGeneralNext()
                .ClickTabFreeStuff()
                .ClickButtonAddSpecials()
                .AddFreeStuffInActive()
                .ClickButtonAddSpecials()
                .AddFreeStuffIsActiveWithoutName()
                //Add get value
                .ClickTabConcessions()
                .ClickButtonAddSpecials()
                .AddConcessionInActive()
                .ClickButtonAddSpecials()
                .AddConcessionIsActiveWithoutName()
                //Add get value
                //Add Assertions
                .ClickButtonGeneralNext()
                .UploadOneImages()
                .ClickButtonSaveBuilding()
                .VerifyMessageSavedSuccessfullyBuilding();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingView = Pages.BuildingView.GetValueFromFieldNotInputAddress();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressNewBuildingActual, getAddressBuildingView);

            #endregion

            WaitUntil.WaitSomeInterval(5000);
        }
    }
}