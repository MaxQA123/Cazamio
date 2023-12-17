using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ApplicationDetailPage
{
    public partial class ApplicationDetail
    {
        [AllureStep("ClickButtonEditApplication")]
        public ApplicationDetail ClickButtonEditApplication()
        {
            WaitUntil.WaitSomeInterval(1000);
            WaitUntil.CustomElementIsVisible(ButtonEditApplication);
            Button.Click(ButtonEditApplication);

            return this;
        }

        [AllureStep("GetNetRentApplctnDtlPg")]
        public decimal GetNetRentApplctnDtlPg()
        {
            WaitUntil.WaitSomeInterval(1000);
            WaitUntil.CustomElementIsVisible(FieldInputNetRentApplctnDtlPg);
            string getNetRentString = FieldInputNetRentApplctnDtlPg.GetAttribute("value");
            string resultString = getNetRentString.Substring(1);
            decimal resultDecimal = decimal.Parse(resultString);
            Console.WriteLine(resultDecimal);

            return resultDecimal;
        }
    }
}
