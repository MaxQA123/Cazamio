using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ListOfBrokersPage
{
    public partial class ListOfBrokers
    {
        [AllureStep("ClickButtonCreateBroker")]
        public ListOfBrokers ClickButtonCreateBroker()
        {
            WaitUntil.CustomElementIsVisible(ButtonCreateBroker);
            Button.Click(ButtonCreateBroker);

            return this;
        }

        [AllureStep("CopyEmailFromModalWindowCreateNewBroker")]
        public string CopyEmailLastRecordEmailForLastBrokerInList()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyEmail = LastRecordEmailForLastBrokerInList.Text;
            string copyEmailActual = copyEmail.ToString();

            return copyEmailActual;
        }
    }
}
