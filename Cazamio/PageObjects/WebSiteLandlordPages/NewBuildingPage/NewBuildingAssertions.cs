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
            WaitUntil.CustomElementIsVisible(FieldInputLocationForAccess);
            string getNameLocation = (FieldInputLocationForAccess).GetAttribute("value");
            string nameLocationActual = getNameLocation.ToString();

            return nameLocationActual;
        }


        [AllureStep("VerifyLocationMainAccess")]
        public NewBuilding VerifyLocationMainAccess(string nameLocationActual)
        {
            Assert.AreEqual(nameLocationActual, building.NameLocation.MainEntrance);

            Console.WriteLine($"AR: {nameLocationActual} ER: {building.NameLocation.MainEntrance}");

            return this;
        }

        [AllureStep("VerifyLocationApartment")]
        public NewBuilding VerifyLocationApartment(string copyActualNameLocationTwo)
        {
            Assert.AreEqual(copyActualNameLocationTwo, building.NameLocation.Apartment);

            Console.WriteLine($"AR: {copyActualNameLocationTwo} ER: {building.NameLocation.Apartment}");

            return this;
        }

        [AllureStep("VerifyValueByDefaulScreeningFee")]
        public NewBuilding VerifyValueByDefaulScreeningFee(string valueScreeningFeeByDefault)
        {
            Assert.AreEqual(valueScreeningFeeByDefault, building.CreditScreeningFee.ByDefault);

            Console.WriteLine($"Value Screening Fee by default AR: {valueScreeningFeeByDefault} ER: {building.CreditScreeningFee.ByDefault}");

            return this;
        }

        public NewBuilding VerifyTypeAccessFromTable(string nameNoteActual, string namePinCodeActual)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(nameNoteActual, TestDataForWebSiteAdmin.NOTE_NAME_LOCK_ACCESS);
                Assert.AreEqual(namePinCodeActual, TestDataForWebSiteAdmin.PIN_CODE_NAME_LOCK_ACCESS);
            });

            return this;
        }

        [AllureStep("VerifyNameConcessionAndFreeStuff")]
        public NewBuilding VerifyNameConcessionAndFreeStuff(string nameConcessionActual, string getNameFreeStuffActual)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(nameConcessionActual, building.Concessions.Name);
                Assert.AreEqual(getNameFreeStuffActual, building.FreeStuff.Name);
            });

            return this;
        }

        [AllureStep("VerifyMessageSavedSuccessfullyBuilding")]
        public NewBuilding VerifyMessageSavedSuccessfullyBuilding()
        {
            WaitUntil.CustomElementIsVisible(MessageSavedSuccessfullyBuilding);
            Assert.IsTrue(Successfully.IsVisible(MessageSavedSuccessfullyBuilding));

            return this;
        }
        
    }
}
