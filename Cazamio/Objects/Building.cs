using CazamioProgect.Helpers;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.Objects
{
    public class Building
    {
        public BuildingNumberInfo BuildingNumber { get; set; }
        public AddressInfo Address { get; set; }
        public CityInfo City { get; set; }
        public string State { get; set; }
        public ZipInfo Zip { get; set; }
        public NeighborhoodInfo Neighborhood { get; set; }
        public string BuildingName { get; set; }
        public string LlcName { get; set; }
        public string Description { get; set; }
        public string InternalNotes { get; set; }

        public class AddressInfo
        {
            public string AssignedRoleAgntBrkr { get; set; }
            public string AssignedRoleBrkr { get; set; }
        }

        public class BuildingNumberInfo
        {
            public string BuildingNumberAssignedRoleAgntBrkr { get; set; }
            public string BuildingNumberAssignedRoleBrkr { get; set; }
        }

        public class CityInfo
        {
            public string CityNewYork { get; set; }
            public string CityBrooklyn { get; set; }
        }

        public class ZipInfo
        {
            public string ZipBuildingAssignedRoleAgntBrkr { get; set; }
            public string ZipBuildingAssignedRoleBrkr { get; set; }
        }

        public class NeighborhoodInfo
        {
            public string NeighborhoodBuildingAssignedRoleAgntBrkr { get; set; }
            public string NeighborhoodBuildingAssignedRoleBrkr { get; set; }
        }


        public Building Generate()
        {
            string buildingNumberAssignedRoleAgntBrkr = "9999";
            string addressAssignedRoleAgntBrkr = "East 51st Street Pedestrian Crossing";
            string zipBuildingAssignedRoleAgntBrkr = "11234";
            string neighborhoodBuildingAssignedRoleAgntBrkr = "Manhattan";
            string buildingNumberAssignedRoleBrkr = "8";
            string addressAssignedRoleBrkr = "Washington Square";
            string zipBuildingAssignedRoleBrkr = "10012";
            string neighborhoodBuildingAssignedRoleBrkr = "Manhattan";
            string cityNewYork ="New York";
            string cityBrooklyn = "Brooklyn";
            string state = "NY";
            string buildingName = "QA-Building NAME (12345) (!@#$%)";
            string LlcName = "LLC QA-HOME (12345) (!@#$%)";
            string description = "DESCRIPTION for BUILDING (12345) (09876) (&%$#@!)";
            string internalNotes = "INTERNAL NOTES for BUILDING (12345) (09876) (&%$#@!)";

            var building = new Building()
            {
                BuildingNumber = new BuildingNumberInfo
                {
                    BuildingNumberAssignedRoleAgntBrkr = buildingNumberAssignedRoleAgntBrkr,
                    BuildingNumberAssignedRoleBrkr = buildingNumberAssignedRoleBrkr
                },
                Address = new AddressInfo
                {
                    AssignedRoleAgntBrkr = addressAssignedRoleAgntBrkr,
                    AssignedRoleBrkr = addressAssignedRoleBrkr
                },
                City = new CityInfo
                {
                    CityNewYork = cityNewYork,
                    CityBrooklyn = cityBrooklyn
                },
                State = state,
                Zip = new ZipInfo
                {
                    ZipBuildingAssignedRoleAgntBrkr = zipBuildingAssignedRoleAgntBrkr,
                    ZipBuildingAssignedRoleBrkr= zipBuildingAssignedRoleBrkr
                },
                Neighborhood = new NeighborhoodInfo
                {
                    NeighborhoodBuildingAssignedRoleAgntBrkr = neighborhoodBuildingAssignedRoleAgntBrkr,
                    NeighborhoodBuildingAssignedRoleBrkr = neighborhoodBuildingAssignedRoleBrkr
                },
                BuildingName = buildingName,
                LlcName = LlcName,
                Description = description,
                InternalNotes = internalNotes,
            };
            return building;
        }
    }
}
