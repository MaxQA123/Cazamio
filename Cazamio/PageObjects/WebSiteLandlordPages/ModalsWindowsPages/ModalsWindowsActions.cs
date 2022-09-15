using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ModalsWindowsPages
{
    public partial class ModalsWindowsLandlordBroker
    {
        #region ModalWindowAreYouSure

        [AllureStep("ClickButtonYesIAmSureOnMdlwndw")]
        public ModalsWindowsLandlordBroker ClickButtonYesIAmSureOnMdlwndw()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonYesIAmSureOnMdlwndw);

            return this;
        }

        [AllureStep("ClickButtonCancelOnMdlwndw")]
        public ModalsWindowsLandlordBroker ClickButtonCancelOnMdlwndw()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonCancelOnMdlwndw);

            return this;
        }

        #endregion
    }
}
