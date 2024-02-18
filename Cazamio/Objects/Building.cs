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
        public string NumberWithAddressRoleBrkr { get; set; }
        public CityInfo City { get; set; }
        public string State { get; set; }
        public ZipInfo Zip { get; set; }
        public NeighborhoodInfo Neighborhood { get; set; }
        public string BuildingName { get; set; }
        public LlcNameInfo LlcName { get; set; }
        public TextLoremInfo TextLorem { get; set; }
        public string DescriptionShort { get; set; }
        public string InternalNotesShort { get; set; }
        public string DescriptionLong { get; set; }
        public string InternalNotesLong { get; set; }
        public CreditScreeningFeeInfo CreditScreeningFee { get; set; }
        public string HoldDeposit { get; set; }
        public PaymentSystemInfo PaymentSystem { get; set; }
        public ApiKeyInfo ApiKey { get; set; }
        public NameLocationInfo NameLocation { get; set; }
        public ConcessionsInfo Concessions { get; set; }
        public FreeStuffInfo FreeStuff { get; set; }

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
            public string BuildingAssignedRoleAgntBrkr { get; set; }
            public string BuildingAssignedRoleBrkr { get; set; }
        }

        public class CreditScreeningFeeInfo
        {
            public string ForEntering { get; set; }
            public string ByDefault { get; set; }
        }

        public class PaymentSystemInfo
        {
            public string Cardknox { get; set; }
            public string AuthorizeNet { get; set; }
        }

        public class ApiKeyInfo
        {
            public string ApiKeyCardknox { get; set; }
            public string ApiKeyAuthorizeNet { get; set; }
        }

        public class TextLoremInfo
        {
            public string TextLoremCommon { get; set; }
            public string TextLoremForPinCode { get; set; }
            public string TextLoremForNote { get; set; }
        }

        public class LlcNameInfo
        {
            public string ForAgentBroker { get; set; }
            public string ForBroker { get; set; }
        }

        public class NameLocationInfo
        {
            public string MainEntrance { get; set; }
            public string Apartment { get; set; }
        }

        public class ConcessionsInfo
        {
            public string Name { get; set; }
            public string MonthsFree { get; set; }
            public string LeaseTerms { get; set; }
        }

        public class FreeStuffInfo
        {
            public string Name { get; set; }
        }

        public Building Generate()
        {
            string buildingNumberAssignedRoleAgntBrkr = "9995";
            string addressAssignedRoleAgntBrkr = "East 51st Street Pedestrian Crossing";
            string zipBuildingAssignedRoleAgntBrkr = "11234";
            string neighborhoodBuildingAssignedRoleAgntBrkr = "Manhattan";
            string buildingNumberAssignedRoleBrkr = "22";
            string addressAssignedRoleBrkr = "Washington Square";
            string zipBuildingAssignedRoleBrkr = "10012";
            string neighborhoodBuildingAssignedRoleBrkr = "Manhattan";
            string cityNewYork ="New York";
            string cityBrooklyn = "Brooklyn";
            string state = "NY";
            string buildingName = "QA-Building NAME (12345) (!@#$%)";
            string llcNameForAgentBroker = "LLC QA Agent As Broker (12345) (!@#$%)";
            string llcNameForBroker = "LLC QA Broker (12345) (!@#$%)";
            string textLoremCommon = "Lorem BUILDING ipsum dolor sit amet, 12345 67890 !@# $%^ &*() adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio et ante tincidunt tempus. Donec vitae sapien ut libero venenatis faucibus. Nullam quis ante. Etiam sit amet orci eget eros faucibus tincidunt. Duis leo. Sed fringilla mauris sit amet nibh. Donec sodales sagittis magna. Sed consequat, leo eget bibendum sodales, augue velit cursus nunc,";
            string textLoremForPinCode = "Lorem PinCode Building (12345) (&%$#@!)";
            string textLoremForNote = "Lorem NOTE Building (12345) (&%$#@!)";
            string descriptionShort = "DESCRIPTION for BUILDING (12345) (09876) (&%$#@!)";
            string internalNotesShort = "INTERNAL NOTES for BUILDING (12345) (09876) (&%$#@!)";
            string creditScreeningFeeForEntering = "9";
            string creditScreeningFeeByDefault = "20";
            string holdDeposit = "650";
            string cardknox = "Cardknox";
            string authorizeNet = "AuthorizeNet";
            string apiKeyCardknox = "czmodev359376936c0543b58126c97f9ff55c68";
            string apiKeyAuthorizeNet = "";
            string firstLocationMainEntrance = "Main Entrance";
            string secondLocationApartment = "Apartment";
            string nameConcession = "ConcessionBuilding";
            string monthsFreeConcession = "1";
            string leaseTermsConcession = "12";
            string nameFreeStuff = "FreeStuffBuilding";


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
                    BuildingAssignedRoleAgntBrkr = neighborhoodBuildingAssignedRoleAgntBrkr,
                    BuildingAssignedRoleBrkr = neighborhoodBuildingAssignedRoleBrkr
                },
                NumberWithAddressRoleBrkr = buildingNumberAssignedRoleBrkr + " " + addressAssignedRoleBrkr,
                BuildingName = buildingName,
                DescriptionShort = descriptionShort,
                InternalNotesShort = internalNotesShort,
                DescriptionLong = descriptionShort + " " + textLoremCommon,
                InternalNotesLong = internalNotesShort + " " + textLoremCommon,
                CreditScreeningFee = new CreditScreeningFeeInfo
                {
                    ForEntering = creditScreeningFeeForEntering,
                    ByDefault = creditScreeningFeeByDefault
                },
                HoldDeposit = holdDeposit,
                PaymentSystem = new PaymentSystemInfo
                {
                    Cardknox = cardknox,
                    AuthorizeNet = authorizeNet
                },
                ApiKey = new ApiKeyInfo
                {
                    ApiKeyCardknox = apiKeyCardknox,
                    ApiKeyAuthorizeNet = apiKeyAuthorizeNet
                },
                TextLorem = new TextLoremInfo
                {
                    TextLoremCommon = textLoremCommon,
                    TextLoremForPinCode = textLoremForPinCode,
                    TextLoremForNote = textLoremForNote
                },
                LlcName = new LlcNameInfo
                {
                    ForAgentBroker = llcNameForAgentBroker,
                    ForBroker = llcNameForBroker
                },
                NameLocation = new NameLocationInfo
                {
                    MainEntrance = firstLocationMainEntrance,
                    Apartment = secondLocationApartment
                },
                Concessions = new ConcessionsInfo
                {
                    Name = nameConcession,
                    MonthsFree = monthsFreeConcession,
                    LeaseTerms = leaseTermsConcession
                },
                FreeStuff = new FreeStuffInfo
                {
                    Name = nameFreeStuff
                },
            };
            return building;
        }
    }
}
