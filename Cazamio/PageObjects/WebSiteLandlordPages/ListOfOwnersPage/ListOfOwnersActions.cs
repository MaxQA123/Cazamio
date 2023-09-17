using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfOwnersPage
{
    public partial class ListOfOwners
    {
        [AllureStep("ClickButtonCreateOwner")]
        public ListOfOwners ClickButtonCreateOwner()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonCreateOwner);

            return this;
        }

        [AllureStep("GetFirstEmailFromTable")]
        public string GetFirstEmailFromTable()
        {
            WaitUntil.CustomElementIsVisible(FirstOwnerEmailOnPage);
            string getEmail = FirstOwnerEmailOnPage.Text;
            string getEmailActual = getEmail.ToString();

            return getEmailActual;
        }
    }
}
