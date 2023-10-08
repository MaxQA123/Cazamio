using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfApplicationsPage
{
    public partial class ListOfApplications
    {
        [AllureStep("ClickButtonPlusApplication")]
        public ListOfApplications ClickButtonPlusApplication()
        {
            WaitUntil.CustomElementIsVisible(ButtonPlusApplication);
            Button.Click(ButtonPlusApplication);

            return this;
        }
    }
}
