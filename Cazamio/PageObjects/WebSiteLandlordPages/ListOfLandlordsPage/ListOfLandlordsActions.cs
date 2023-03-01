using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ListOfLandlordsPage
{
    public partial class ListOfLandlords
    {
        [AllureStep("ClickButtonCreateLandlord")]
        public ListOfLandlords ClickButtonCreateLandlord()
        {
            Button.Click(ButtonCreateLandlord);

            return this;
        }
    }
}
