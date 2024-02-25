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
        public NumberWithAddressInfo NumberWithAddress { get; set; }
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
            public string MarkAdmAssignedRoleAgntBrkr { get; set; }
            public string MarkAdmAssignedRoleBrkr { get; set; }
        }

        public class BuildingNumberInfo
        {
            public string BuildingNumberMarkAdmAssignedRoleAgntBrkr { get; set; }
            public string BuildingNumberMarkAdmAssignedRoleBrkr { get; set; }
        }

        public class CityInfo
        {
            public string NewYork { get; set; }
            public string Brooklyn { get; set; }
        }

        public class ZipInfo
        {
            public string ZipBuildingMarkAdmAssignedRoleAgntBrkr { get; set; }
            public string ZipBuildingMarkAdmAssignedRoleBrkr { get; set; }
            public string ZipBuildingBrokerAssignedRoleAgntBrkr { get; set; }
            public string ZipBuildingBrokerAssignedRoleBrkr { get; set; }
        }

        public class NeighborhoodInfo
        {
            public string BuildingMarkAdmAssignedRoleAgntBrkr { get; set; }
            public string BuildingMarkAdmAssignedRoleBrkr { get; set; }
            public string BuildingBrokerAssignedRoleAgntBrkr { get; set; }
            public string BuildingBrokerAssignedRoleBrkr { get; set; }
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

        public class NumberWithAddressInfo
        {
            public string MarkAdmAssignedBroker { get; set; }
            public string MarkAdmAssignedAgntBrkr { get; set; }
            public string BrokerAssignedBroker { get; set; }
            public string BrokerAssignedAgntBrkr { get; set; }
            public string AgntBrkrAssignedAgntBrkr { get; set; }
        }

        public Building Generate()
        {
            #region Settings Building for role Marketplace Admin

            string buildingNumberMarAdmAssignedRoleAgntBrkr = "9999";
            string addressMarkAdmAssignedRoleAgntBrkr = "Saint Johnson Place";
            string zipBuildingMarkAdmAssignedRoleAgntBrkr = "11213";
            string neighborhoodMarkAdmBuildingAssignedRoleAgntBrkr = "Crown Heights";

            string buildingNumberMarkAdmAssignedRoleBrkr = "27";
            string addressMarkAdmAssignedRoleBrkr = "Washington Square";
            string zipBuildingMarkAdmAssignedRoleBrkr = "10012";
            string neighborhoodBuildingMarkAdmAssignedRoleBrkr = "Manhattan";

            #endregion

            #region Settings Building for role Broker

            string buildingNumberBrokerAssignedRoleAgntBrkr = "1";
            string addressBrokerAssignedRoleAgntBrkr = "Albermale Rd";
            string zipBuildingBrokerAssignedRoleAgntBrkr = "11226";
            string neighborhoodBrokerBuildingAssignedRoleAgntBrkr = "East Flatbush";

            string buildingNumberBrokerAssignedRoleBrkr = "1-9";
            string addressBrokerAssignedRoleBrkr = "Crown St";
            string zipBuildingBrokerAssignedRoleBrkr = "11225";
            string neighborhoodBuildingBrokerAssignedRoleBrkr = "Crown Heights";

            #endregion

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
            string apiKeyAuthorizeNet = "2L7uB4UzeA9gf366";
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
                    BuildingNumberMarkAdmAssignedRoleAgntBrkr = buildingNumberMarAdmAssignedRoleAgntBrkr,
                    BuildingNumberMarkAdmAssignedRoleBrkr = buildingNumberMarkAdmAssignedRoleBrkr
                },
                Address = new AddressInfo
                {
                    MarkAdmAssignedRoleAgntBrkr = addressMarkAdmAssignedRoleAgntBrkr,
                    MarkAdmAssignedRoleBrkr = addressMarkAdmAssignedRoleBrkr
                },
                City = new CityInfo
                {
                    NewYork = cityNewYork,
                    Brooklyn = cityBrooklyn
                },
                State = state,
                Zip = new ZipInfo
                {
                    ZipBuildingMarkAdmAssignedRoleAgntBrkr = zipBuildingMarkAdmAssignedRoleAgntBrkr,
                    ZipBuildingMarkAdmAssignedRoleBrkr = zipBuildingMarkAdmAssignedRoleBrkr,
                    ZipBuildingBrokerAssignedRoleAgntBrkr = zipBuildingBrokerAssignedRoleAgntBrkr,
                    ZipBuildingBrokerAssignedRoleBrkr = zipBuildingBrokerAssignedRoleBrkr
                },
                Neighborhood = new NeighborhoodInfo
                {
                    BuildingMarkAdmAssignedRoleAgntBrkr = neighborhoodMarkAdmBuildingAssignedRoleAgntBrkr,
                    BuildingMarkAdmAssignedRoleBrkr = neighborhoodBuildingMarkAdmAssignedRoleBrkr,
                    BuildingBrokerAssignedRoleAgntBrkr = neighborhoodBrokerBuildingAssignedRoleAgntBrkr,
                    BuildingBrokerAssignedRoleBrkr = neighborhoodBuildingBrokerAssignedRoleBrkr
                },
                NumberWithAddress = new NumberWithAddressInfo
                {
                    MarkAdmAssignedBroker = buildingNumberMarkAdmAssignedRoleBrkr + " " + addressMarkAdmAssignedRoleBrkr,
                    MarkAdmAssignedAgntBrkr = buildingNumberMarAdmAssignedRoleAgntBrkr + " " + addressMarkAdmAssignedRoleAgntBrkr,
                    BrokerAssignedAgntBrkr = buildingNumberBrokerAssignedRoleAgntBrkr + " " + addressBrokerAssignedRoleAgntBrkr,
                    BrokerAssignedBroker = buildingNumberBrokerAssignedRoleBrkr + " " + addressBrokerAssignedRoleBrkr
                },
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
