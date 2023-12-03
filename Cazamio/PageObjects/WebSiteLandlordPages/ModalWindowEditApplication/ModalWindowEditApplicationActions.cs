using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ModalWindowEditApplication
{
    public partial class ModalWindowEditApplication
    {
        [AllureStep("ClickButtonInFormEditApplication")]
        public ModalWindowEditApplication ClickButtonInFormEditApplication()
        {
            WaitUntil.WaitSomeInterval(1000);
            WaitUntil.CustomElementIsVisible(ButtonInFormEditApplication);
            Button.Click(ButtonInFormEditApplication);

            return this;
        }

        //[AllureStep("GetUserNameFromSideBar")]
        //public string GeFullUnitAddress()
        //{
        //    WaitUntil.CustomElementIsVisible(UserNameOfSidebarLandlordWebSite);
        //    string getUserName = UserNameOfSidebarLandlordWebSite.Text;
        //    string getUserNameActual = getUserName.ToString();

        //    return getUserNameActual;
        //}
    }
}
