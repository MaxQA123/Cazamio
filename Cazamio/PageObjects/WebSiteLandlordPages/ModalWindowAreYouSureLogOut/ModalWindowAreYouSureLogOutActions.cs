using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ModalsWindowsPages
{
    public partial class ModalWindowAreYouSureLogOutLandlordBroker
    {
        #region ModalWindowAreYouSure

        [AllureStep("ClickButtonYesIAmSureOnMdlwndw")]
        public ModalWindowAreYouSureLogOutLandlordBroker ClickButtonYesIAmSureOnMdlwndw()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonYesIAmSureOnMdlwndw);

            return this;
        }

        [AllureStep("ClickButtonCancelOnMdlwndw")]
        public ModalWindowAreYouSureLogOutLandlordBroker ClickButtonCancelOnMdlwndw()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonCancelOnMdlwndw);

            return this;
        }

        #endregion
    }
}
