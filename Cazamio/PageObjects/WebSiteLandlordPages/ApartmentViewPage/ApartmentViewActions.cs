using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ApartmentViewPage
{
    public partial class ApartmentView
    {
        [AllureStep("ClickButtonPlusApplication")]
        public ApartmentView ClickButtonPlusApplication()
        {
            WaitUntil.CustomElementIsVisible(ButtonPlusApplication);
            Button.Click(ButtonPlusApplication);

            return this;
        }
    }
}
