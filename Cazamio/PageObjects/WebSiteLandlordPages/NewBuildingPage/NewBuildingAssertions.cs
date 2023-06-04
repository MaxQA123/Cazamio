using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.NewBuildingPage
{
    public partial class NewBuilding
    {
        [AllureStep("VerifyTitleListOfBuildingsPg")]
        public NewBuilding VerifyTitleNewBuildingPg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleNewBuildingPage));

            return this;
        }

        public string CopyNameLocation()
        {
            WaitUntil.CustomElementIsVisible(FieldInputLocationForAccessNwBldngPg, 10);
            string getNameLocation = (FieldInputLocationForAccessNwBldngPg).GetAttribute("value");
            string nameLocationActual = getNameLocation.ToString();

            return nameLocationActual;
        }


        [AllureStep("VerifyLocationAccessNewBuildingPg")]
        public NewBuilding VerifyLocationAccessNewBuildingPg(string nameLocationActual)
        {
            Assert.AreEqual(nameLocationActual, TestDataForWebSiteAdmin.FIRST_NAME_LOCATION);

            Console.WriteLine($"AR: {nameLocationActual} ER: {TestDataForWebSiteAdmin.FIRST_NAME_LOCATION}");

            return this;
        }
    }
}
