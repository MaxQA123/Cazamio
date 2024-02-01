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
        public string Cell { get; set; }
        public string BrokerCommission { get; set; }
        public string AgentCommission { get; set; }
        public string EmailAddressAgent { get; set; }
        public string FullNameAgent { get; set; }

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


        public Building Generate()
        {
            string buildingNumberAssignedRoleAgntBrkr = "9999";
            string buildingNumberAssignedRoleBrkr = "8";
            string addressAssignedRoleAgntBrkr = "East 51st Street Pedestrian Crossing";
            string addressAssignedRoleBrkr = "Washington Square";
            string cityNewYork ="New York";
            string cityBrooklyn = "Brooklyn";
            string state = "NY";
            string zipBuildingAssignedRoleAgntBrkr = "11234";
            string zipBuildingAssignedRoleBrkr = "54321";
            string cell = "518" + GenerateRandomDataHelper.RandomPhoneNumber(7);
            string brokerCommission = GenerateRandomDataHelper.RandomNumberWithoutZero(2);
            string agentCommission = GenerateRandomDataHelper.RandomNumberWithoutZero(2);
            string emailAddressAgent = "agent5lula@putsbox.com";
            string fullNameAgent = "Lula AgentQA";

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
                Cell = cell,
                BrokerCommission = brokerCommission,
                AgentCommission = agentCommission,
                EmailAddressAgent = emailAddressAgent,
                FullNameAgent = fullNameAgent,
            };
            return building;
        }
    }
}
