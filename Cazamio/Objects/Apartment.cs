using CazamioProgect.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.Objects
{
    public class Apartment
    {
        public UnitNumberInfo UnitNumber { get; set; }
        public BedroomsInfo Bedrooms { get; set; }
        public HalfBedroomsInfo HalfBedrooms { get; set; }
        public BathroomsInfo Bathrooms { get; set; }
        public HalfBathroomsInfo HalfBathrooms { get; set; }
        public SqFootInfo SqFoot { get; set; }
        public LeasePriceInfo LeasePrice { get; set; }
        public SecurityDepositInfo SecurityDeposit { get; set; }
        public MonthlyRentsPrePaymentInfo MonthlyRentsPrePayment { get; set; }
        public FloorInfo Floor { get; set; }
        public ApartmentStatusInfo ApartmentStatus { get; set; }
        public string FullUserNameBroker { get; set; }

        public class UnitNumberInfo
        {
            public string UnitNumberMarkAdmAssignedRoleAgntBrkr { get; set; }
            public string UnitNumberMarkAdmAssignedRoleBrkr { get; set; }
            public string UnitNumberBrokerAssignedRoleAgntBrkr { get; set; }
            public string UnitNumberBrokerAssignedRoleBrkr { get; set; }
            public string UnitNumberAgntBrkrAssignedRoleAgntBrkr { get; set; }
        }

        public class BedroomsInfo
        {
            public string OneNumber { get; set; }
            public string TwoNumber { get; set; }
        }

        public class HalfBedroomsInfo
        {
            public string OneNumber { get; set; }
            public string TwoNumber { get; set; }
        }

        public class BathroomsInfo
        {
            public string OneNumber { get; set; }
            public string TwoNumber { get; set; }
        }

        public class HalfBathroomsInfo
        {
            public string OneNumber { get; set; }
            public string TwoNumber { get; set; }
        }

        public class SqFootInfo
        {
            public string OneNumber { get; set; }
            public string TwoNumber { get; set; }
            public string ThreeNumber { get; set; }
            public string FifteenNumber { get; set; }
        }

        public class LeasePriceInfo
        {
            public string OneNumber { get; set; }
            public string TwoNumber { get; set; }
            public string ThreeNumber { get; set; }
            public string FourNumber { get; set; }
        }

        public class SecurityDepositInfo
        {
            public string OneNumber { get; set; }
            public string TwoNumber { get; set; }
            public string ThreeNumber { get; set; }
            public string FourNumber { get; set; }
        }

        public class MonthlyRentsPrePaymentInfo
        {
            public string OneNumber { get; set; }
            public string TwoNumber { get; set; }
        }

        public class FloorInfo
        {
            public string OneNumber { get; set; }
            public string TwoNumber { get; set; }
            public string ThreeNumber { get; set; }
        }

        public class ApartmentStatusInfo
        {
            public string OffMarket { get; set; }
            public string Occupied { get; set; }
            public string Vacant { get; set; }
            public string DepositReceived { get; set; }
            public string ApplicationSubmitted { get; set; }
            public string SignedLease { get; set; }
        }

        public Apartment Generate()
        {
            string unitNumberMarkAdmAssignedRoleAgntBrkr = "1";
            string unitNumberMarkAdmAssignedRoleBrkr = "9999";
            string unitNumberBrokerAssignedRoleAgntBrkr = "AA";
            string unitNumberBrokerAssignedRoleBrkr = "1A";
            string unitNumberAgntBrkrAssignedRoleAgntBrkr = "1-9";
            string bedroomsOneNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(1);
            string bedroomsTwoNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(2);
            string halfBedroomsOneNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(1);
            string halfBedroomsTwoNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(2);
            string bathroomsOneNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(1);
            string bathroomsTwoNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(2);
            string halfBathroomsOneNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(1);
            string halfBathroomsTwoNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(2);
            string sqFootOneNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(1);
            string sqFootTwoNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(2);
            string sqFootThreeNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(3);
            string sqFootFifteenNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(15);
            string leasePriceOneNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(1);
            string leasePriceTwoNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(2);
            string leasePriceThreeNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(3);
            string leasePriceFourNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(4);
            string securityDepositOneNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(1);
            string securityDepositTwoNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(2);
            string securityDepositThreeNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(3);
            string securityDepositFourNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(4);
            string monthlyRentsPrePaymentOneNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(1);
            string monthlyRentsPrePaymentTwoNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(2);
            string floorOneNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(1);
            string floorTwoNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(2);
            string floorThreeNumber = GenerateRandomDataHelper.RandomNumberWithoutZero(3);
            string itemOffMarket = "";
            string itemOccupied = "";
            string itemVacant = "";
            string itemDepositReceived = "";
            string itemApplicationSubmitted = "";
            string itemSignedLease = "";

            string fullUserNameBroker = "Leoautotest Feabroker";

            var apartment = new Apartment()
            {
                UnitNumber = new UnitNumberInfo
                {
                    UnitNumberMarkAdmAssignedRoleAgntBrkr = unitNumberMarkAdmAssignedRoleAgntBrkr,
                    UnitNumberMarkAdmAssignedRoleBrkr = unitNumberMarkAdmAssignedRoleBrkr,
                    UnitNumberBrokerAssignedRoleAgntBrkr = unitNumberBrokerAssignedRoleAgntBrkr,
                    UnitNumberBrokerAssignedRoleBrkr = unitNumberBrokerAssignedRoleBrkr,
                    UnitNumberAgntBrkrAssignedRoleAgntBrkr = unitNumberAgntBrkrAssignedRoleAgntBrkr
                },
                Bedrooms = new BedroomsInfo
                {
                    OneNumber = bedroomsOneNumber,
                    TwoNumber = bedroomsTwoNumber
                },
                HalfBedrooms = new HalfBedroomsInfo
                {
                    OneNumber = halfBedroomsOneNumber,
                    TwoNumber = halfBedroomsTwoNumber
                },
                Bathrooms = new BathroomsInfo
                {
                    OneNumber = bathroomsOneNumber,
                    TwoNumber = bathroomsTwoNumber
                },
                HalfBathrooms = new HalfBathroomsInfo
                {
                    OneNumber = halfBathroomsOneNumber,
                    TwoNumber = halfBathroomsTwoNumber
                },
                SqFoot = new SqFootInfo
                {
                    OneNumber = sqFootOneNumber,
                    TwoNumber = sqFootTwoNumber,
                    ThreeNumber = sqFootThreeNumber,
                    FifteenNumber = sqFootFifteenNumber
                },
                LeasePrice = new LeasePriceInfo
                {
                    OneNumber = leasePriceOneNumber,
                    TwoNumber = leasePriceTwoNumber,
                    ThreeNumber = leasePriceThreeNumber,
                    FourNumber = leasePriceFourNumber
                },
                SecurityDeposit = new SecurityDepositInfo
                {
                    OneNumber = securityDepositOneNumber,
                    TwoNumber = securityDepositTwoNumber,
                    ThreeNumber = securityDepositThreeNumber,
                    FourNumber = securityDepositFourNumber
                },
                MonthlyRentsPrePayment = new MonthlyRentsPrePaymentInfo
                {
                    OneNumber = monthlyRentsPrePaymentOneNumber,
                    TwoNumber = monthlyRentsPrePaymentTwoNumber
                },
                Floor = new FloorInfo
                {
                    OneNumber = floorOneNumber,
                    TwoNumber = floorTwoNumber,
                    ThreeNumber = floorThreeNumber
                },
                ApartmentStatus = new ApartmentStatusInfo
                {
                    OffMarket = itemOffMarket,
                    Occupied = itemOccupied,
                    Vacant = itemVacant,
                    DepositReceived = itemDepositReceived,
                    ApplicationSubmitted = itemApplicationSubmitted,
                    SignedLease = itemSignedLease
                },
                FullUserNameBroker = fullUserNameBroker,

            };
            return apartment;
        }
    }
}
