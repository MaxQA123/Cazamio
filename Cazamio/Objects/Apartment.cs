﻿using CazamioProgect.Helpers;
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
        public ApartmentTypeInfo ApartmentType { get; set; }
        public string ApartmentHoldDeposit { get; set; }
        public RentalTermsInfo RentalTerms { get; set; }
        public RequiredDocumentsInfo RequiredDocuments { get; set; }
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

        public class ApartmentTypeInfo
        {
            public string MultiFamily { get; set; }
            public string SingleFamily { get; set; }
            public string Duplex { get; set; }
            public string Plex { get; set; }
            public string Loft { get; set; }
        }

        public class RentalTermsInfo
        {
            public string TwelveMonths { get; set; }
            public string EighteenMonths { get; set; }
        }

        public class RequiredDocumentsInfo
        {
            public string TwoRecentPaystubs { get; set; }
            public string SocialSecurityCard { get; set; }
            public string EmploymentVerificationLetter { get; set; }
            public string WTwoFromPreviousYear { get; set; }
            public string OtherPertinentDocuments { get; set; }
            public string GovIssuedId { get; set; }
            public string SecondaryPhotoId { get; set; }
            public string StudentVerification { get; set; }
            public string MostRecentBankStatement { get; set; }
            public string TwoMostRecentBankStatements { get; set; }
            public string LandlordReference { get; set; }
            public string ProofOfLastThreeRentPayments { get; set; }
            public string ProofOfLastTwelveRentPayments { get; set; }
            public string MostRecentWTwoOrOneThousandNine { get; set; }
            public string MostRecentCheckingAccountStatement { get; set; }
            public string MostRecentSavingsAccountStatement { get; set; }
            public string CpaLetterSelfEmployed { get; set; }
            public string PaidInvoicesSelfEmployed { get; set; }
            public string ProofOfCreditOrCollectionDisputeIfApplicable { get; set; }
            public string AnyAdditionalFinancialAssets { get; set; }
            public string ThreeMostRecentRentPayments { get; set; }
            public string MostRecentTaxReturn { get; set; }
            public string ThreeRecentPaystubs { get; set; }
            public string SixMostRecentRentPayments { get; set; }
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
            string itemOffMarket = "Off market";
            string itemOccupied = "Occupied";
            string itemVacant = "Vacant";
            string itemDepositReceived = "Deposit received";
            string itemApplicationSubmitted = "Application submitted";
            string itemSignedLease = "Signed lease";
            string itemMultiFamily = "MultiFamily";
            string itemSingleFamily = "SingleFamily";
            string itemDuplex = "Duplex";
            string itemPlex = "Plex";
            string itemLoft = "Loft";
            string valueHoldDeposit = "700";
            string itemTwelveMonths = "12 months";
            string itemEighteenMonths = "18 months";
            #region Required Documents 
            string itemTwoRecentPaystubs = "2 Recent paystubs";
            string itemSocialSecurityCard = "Social Security Card";
            string itemEmploymentVerificationLetter = "Employment Verification Letter";
            string itemWTwoFromPreviousYear = "W-2 From previous year";
            string itemOtherPertinentDocuments = "Other pertinent documents";
            string itemGovIssuedId = "Gov issued ID";
            string itemSecondaryPhotoId = "Secondary photo ID";
            string itemStudentVerification = "Student verification";
            string itemMostRecentBankStatement = "Most recent bank statement";
            string itemTwoMostRecentBankStatements = "2 Most recent bank statements";
            string itemLandlordReference = "Landlord Reference";
            string itemProofOfLastThreeRentPayments = "Proof of last 3 rent payments";
            string itemProofOfLastTwelveRentPayments = "Proof of last 12 rent payments";
            string itemMostRecentWTwoOrOneThousandNine = "Most recent W-2 or 1099";
            string itemMostRecentCheckingAccountStatement = "Most Recent checking account statement";
            string itemMostRecentSavingsAccountStatement = "Most Recent savings account statement";
            string itemCpaLetterSelfEmployed = "CPA letter (self-employed)";
            string itemPaidInvoicesSelfEmployed = "Paid invoices (self-employed)";
            string itemProofOfCreditOrCollectionDisputeIfApplicable = "Proof of credit or collection dispute (If Applicable)";
            string itemAnyAdditionalFinancialAssets = "Any additional financial assets";
            string itemThreeMostRecentRentPayments = "3 most recent rent payments";
            string itemMostRecentTaxReturn = "Most recent tax return";
            string itemThreeRecentPaystubs = "3 recent paystubs";
            string itemSixMostRecentRentPayments = "6 most recent rent payments";
            #endregion

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
                ApartmentType = new ApartmentTypeInfo
                {
                    MultiFamily = itemMultiFamily,
                    SingleFamily = itemSingleFamily,
                    Duplex = itemDuplex,
                    Plex = itemPlex,
                    Loft = itemLoft
                },
                ApartmentHoldDeposit = valueHoldDeposit,
                RentalTerms = new RentalTermsInfo
                {
                    TwelveMonths = itemTwelveMonths,
                    EighteenMonths = itemEighteenMonths
                },
                RequiredDocuments = new RequiredDocumentsInfo
                {
                    TwoRecentPaystubs = itemTwoRecentPaystubs,
                    SocialSecurityCard = itemSocialSecurityCard,
                    EmploymentVerificationLetter = itemEmploymentVerificationLetter,
                    WTwoFromPreviousYear = itemWTwoFromPreviousYear,
                    OtherPertinentDocuments = itemOtherPertinentDocuments,
                    GovIssuedId = itemGovIssuedId,
                    SecondaryPhotoId = itemSecondaryPhotoId,
                    StudentVerification = itemStudentVerification,
                    MostRecentBankStatement = itemMostRecentBankStatement,
                    TwoMostRecentBankStatements = itemTwoMostRecentBankStatements,
                    LandlordReference = itemLandlordReference,
                    ProofOfLastThreeRentPayments = itemProofOfLastThreeRentPayments,
                    ProofOfLastTwelveRentPayments = itemProofOfLastTwelveRentPayments,
                    MostRecentWTwoOrOneThousandNine = itemMostRecentWTwoOrOneThousandNine,
                    MostRecentCheckingAccountStatement = itemMostRecentCheckingAccountStatement,
                    MostRecentSavingsAccountStatement = itemMostRecentSavingsAccountStatement,
                    CpaLetterSelfEmployed = itemCpaLetterSelfEmployed,
                    PaidInvoicesSelfEmployed = itemPaidInvoicesSelfEmployed,
                    ProofOfCreditOrCollectionDisputeIfApplicable = itemProofOfCreditOrCollectionDisputeIfApplicable,
                    AnyAdditionalFinancialAssets = itemAnyAdditionalFinancialAssets,
                    ThreeMostRecentRentPayments = itemThreeMostRecentRentPayments,
                    MostRecentTaxReturn = itemMostRecentTaxReturn,
                    ThreeRecentPaystubs = itemThreeRecentPaystubs,
                    SixMostRecentRentPayments = itemSixMostRecentRentPayments
                },
                FullUserNameBroker = fullUserNameBroker,

            };
            return apartment;
        }
    }
}
