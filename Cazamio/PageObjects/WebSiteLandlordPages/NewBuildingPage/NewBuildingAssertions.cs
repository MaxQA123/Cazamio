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


        [AllureStep("VerifyLocationMainAccessNewBuildingPg")]
        public NewBuilding VerifyLocationMainAccessNewBuildingPg(string nameLocationActual)
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

        public string GetNameCabTypeAccessFromTable()
        {
            WaitUntil.CustomElementIsVisible(RecordCABInTableAccessNwBldngPg, 10);
            string getNameCab = (RecordCABInTableAccessNwBldngPg).Text;
            string nameCabActual = getNameCab.ToString();

            return nameCabActual;
        }

        public string GetNameNoteTypeAccessFromTable()
        {
            WaitUntil.CustomElementIsVisible(RecordNoteInTableAccessNwBldngPg, 10);
            string getNameNote = (RecordNoteInTableAccessNwBldngPg).Text;
            string nameNoteActual = getNameNote.ToString();

            return nameNoteActual;
        }

        public string GetNamePinCodeTypeAccessFromTable()
        {
            WaitUntil.CustomElementIsVisible(RecordPinCodeInTableAccessNwBldngPg, 10);
            string getNamePinCode = (RecordPinCodeInTableAccessNwBldngPg).Text;
            string namePinCodeActual = getNamePinCode.ToString();

            return namePinCodeActual;
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

        public string GetNameConcessionFromTable()
        {
            WaitUntil.CustomElementIsVisible(RecordNameInTableConcessionNwBldngPg, 10);
            string getNameConcession = (RecordNameInTableConcessionNwBldngPg).Text;
            string nameConcessionActual = getNameConcession.ToString();

            return nameConcessionActual;
        }

        [AllureStep("VerifyNameSpecialsConcessionInTableNewBuildingPg")]
        public NewBuilding VerifyNameSpecialsConcessionInTableNewBuildingPg(string nameConcessionActual)
        {
            Assert.AreEqual(nameConcessionActual, TestDataForWebSiteAdmin.CONCESSION_NAME);

            Console.WriteLine($" ;AR: {nameConcessionActual} ER: {TestDataForWebSiteAdmin.CONCESSION_NAME}");

            return this;
        }

    }
}
