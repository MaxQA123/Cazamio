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
            Assert.AreEqual(nameLocationActual, TestDataForWebSiteAdmin.FIRST_NAME_LOCATION);

            Console.WriteLine($"AR: {nameLocationActual} ER: {TestDataForWebSiteAdmin.FIRST_NAME_LOCATION}");

            return this;
        }

        [AllureStep("VerifyLocationApartmentAccessNewBuildingPg")]
        public NewBuilding VerifyLocationApartmentAccessNewBuildingPg(string copyActualNameLocationTwo)
        {
            Assert.AreEqual(copyActualNameLocationTwo, TestDataForWebSiteAdmin.SECOND_NAME_LOCATION);

            Console.WriteLine($"AR: {copyActualNameLocationTwo} ER: {TestDataForWebSiteAdmin.SECOND_NAME_LOCATION}");

            return this;
        }

        [AllureStep("VerifyValueByDefaulScreeningFee")]
        public NewBuilding VerifyValueByDefaulScreeningFee(string valueScreeningFeeByDefault)
        {
            Assert.AreEqual(valueScreeningFeeByDefault, building.CreditScreeningFee.ByDefault);

            Console.WriteLine($"Value Screening Fee by default AR: {valueScreeningFeeByDefault} ER: {building.CreditScreeningFee.ByDefault}");

            return this;
        }

        public void VerifyTypeAccessFromTable(string nameCabActual, string nameNoteActual, string namePinCodeActual)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(nameCabActual, TestDataForWebSiteAdmin.CAB_NAME_LOCK_ACCESS);
                //Console.Write($"{nameCabActual} = {TestDataForWebSiteAdmin.CAB_NAME_LOCK_ACCESS}");
                Assert.AreEqual(nameNoteActual, TestDataForWebSiteAdmin.NOTE_NAME_LOCK_ACCESS);
                //Console.Write($"{nameNoteActual} = {TestDataForWebSiteAdmin.NOTE_NAME_LOCK_ACCESS}");
                Assert.AreEqual(namePinCodeActual, TestDataForWebSiteAdmin.PIN_CODE_NAME_LOCK_ACCESS);
                Console.Write($"{nameCabActual} = {TestDataForWebSiteAdmin.CAB_NAME_LOCK_ACCESS}; {nameNoteActual} = {TestDataForWebSiteAdmin.NOTE_NAME_LOCK_ACCESS}; {namePinCodeActual} = {TestDataForWebSiteAdmin.PIN_CODE_NAME_LOCK_ACCESS}");
            });
        }

        [AllureStep("VerifyNameSpecialsConcessionInTableNewBuildingPg")]
        public NewBuilding VerifyNameSpecialsConcessionInTableNewBuildingPg(string nameConcessionActual)
        {
            Assert.AreEqual(nameConcessionActual, TestDataForWebSiteAdmin.CONCESSION_NAME);

            Console.WriteLine($" ;AR: {nameConcessionActual} ER: {TestDataForWebSiteAdmin.CONCESSION_NAME}");

            return this;
        }

        [AllureStep("VerifyMessageSavedSuccessfullyBuildingNwBldngPg")]
        public NewBuilding VerifyMessageSavedSuccessfullyBuildingNwBldngPg()
        {
            WaitUntil.CustomElementIsVisible(MessageSavedSuccessfullyBuildingNwBldngPg, 10);
            Assert.IsTrue(Successfully.IsVisible(MessageSavedSuccessfullyBuildingNwBldngPg));

            return this;
        }
        
    }
}
