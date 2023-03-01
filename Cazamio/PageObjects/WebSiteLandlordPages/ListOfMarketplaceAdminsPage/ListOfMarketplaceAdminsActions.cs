using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ListOfMarketplaceAdmins
{
    public partial class ListOfMarketplaceAdmins
    {
        [AllureStep("ClickButtonCreateMarketplaceAdmin")]
        public ListOfMarketplaceAdmins ClickButtonCreateMarketplaceAdmin()
        {
            Button.Click(ButtonCreateMarketplaceAdmin);

            return this;
        }

        [AllureStep("GetLastEmailFromTable")]
        public string GetLastEmailFromTable()
        {
            WaitUntil.CustomElementIsVisible(LastMarketplaceAdminEmailOnPage);
            string getEmail = LastMarketplaceAdminEmailOnPage.Text;
            string getEmailActual = getEmail.ToString();

            return getEmailActual;
        }
    }
}
