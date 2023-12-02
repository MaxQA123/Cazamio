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

        //[AllureStep("GetFullAddrressUnit")]
        //public string GetFullAddrressUnit()
        //{
        //    WaitUntil.WaitSomeInterval(1000);
        //    WaitUntil.CustomElementIsVisible(ValueFromStringLeadEmailModalWndw);
        //    string getEmailStepThird = ValueFromStringLeadEmailModalWndw.Text;
        //    string getEmailStepThirdActual = getEmailStepThird.ToString();
        //    //Console.WriteLine($"Email step third: {getEmailStepThirdActual}");

        //    return getEmailStepThirdActual;
        //}
    }
}
