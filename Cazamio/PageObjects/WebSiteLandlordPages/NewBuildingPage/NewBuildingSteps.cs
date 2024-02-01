using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.NewBuildingPage
{
    public partial class NewBuilding
    {
        [AllureStep("EnterFullAddressNewBuildingAssgndRlBrkr")]
        public NewBuilding EnterFullAddressNewBuildingAssgndRlBrkr()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputAddressNwBldngPg, building.Address.AssignedRoleBrkr);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCityNwBldngPg, building.City.CityNewYork);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputStateNwBldngPg, building.State);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputZipNwBldngPg, building.Zip.ZipBuildingAssignedRoleBrkr);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputNeighborhoodNwBldngPg, building.Neighborhood.NeighborhoodBuildingAssignedRoleBrkr);

            return this;
        }

        [AllureStep("EnterInternalNotesDescription")]
        public NewBuilding EnterInternalNotesDescription()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputDescroptionNwBldngPg, building.Description + GeneralTestDataForAllUsers.TEXT_LOREM);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputInternalNotesNwBldngPg, building.InternalNotes + GeneralTestDataForAllUsers.TEXT_LOREM);

            return this;
        }
    }
}
