using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.Helpers
{
    public class EndPoints
    {
        public const string URL_HOME_PAGE_TENANT_WEBSITE_CAZAMIO = "https://testlandlord-demo.cazamiodemo.com/";
        public const string URL_LOGIN_ADMIN_WEBSITE = "https://landlord-demo.cazamiodemo.com/account/signin";
        
        public const string URL_XITROO_EMAIL_RANDOM = "https://xitroo.com/";
        public const string URL_XITROO_STATIC_SUPER_ADMIN = "https://xitroo.com/#testadmin@xitroo.com";
        public const string URL_XITROO_STATIC_BROKER = "https://xitroo.com/#evilhtingale@xitroo.com";
        public const string URL_XITROO_STATIC_ADMIN = "https://xitroo.com/#testlandlordcaz@xitroo.com";
        public const string URL_XITROO_STATIC_TENANT = "https://xitroo.com/#tenantoccupantliza@xitroo.com";

        public const string URL_PUTSBOX_EMAIL_STATIC_SUPER_ADMIN = "https://putsbox.com/superadmin123/inspect";
        public const string URL_PUTSBOX_EMAIL_STATIC_AGENT = "https://putsbox.com/agent123test/inspect";
        public const string URL_PUTSBOX_EMAIL_STATIC_BROKER = "https://putsbox.com/admin123/inspect";
        public const string URL_PUTSBOX_EMAIL_STATIC_TENANT_APPLICANT = "https://putsbox.com/tenantapp123ray/inspect";
        public const string URL_PUTSBOX_EMAIL_STATIC_TENANT_OCCUPANT = "https://putsbox.com/tenantocc123liza/inspect";
        public const string URL_PUTSBOX_EMAIL_STATIC_TENANT_GUARANTOR = "https://putsbox.com/tenantgua123jim/inspect";
    }

    public class ConnectionDb
    {
        public const string GET_CONNECTION_STRING_TO_DB = "Server=20.110.40.246,1433;Database=CazamioStageDb;User Id=CazaQA;Password=sadvN742sJGB;TrustServerCertificate=True";
    }


    public class GeneralTestDataForAllUsers
    {
        public const string PASSWORD_GENERAL = "Qwerty123!";
        public const string PASSWORD_NEW_GENEREAL = "!321Qwerty";
    }

    public class TestDataDBGeneral
    {
        public const string ID_NAME_ROLE_TENANT = "726b52a7-a146-4a18-b2cd-b133c377c715";
        public const string ID_NAME_ROLE_SUPER_ADMIN = "86779821-785f-4710-8d0c-2cc4ab5af6a9";
        public const string ID_NAME_ROLE_AGENT = "a6841be6-7bc6-4510-bf70-bd8efc887486";
        public const string ID_NAME_ROLE_BROKER = "ee430d91-8a3b-45a9-891c-94cb16935d49";
        public const string NAME_ROLE_TENANT = "Tenant";
        public const string NAME_ROLE_SUPER_ADMIN = "Admin";
        public const string NAME_ROLE_AGENT = "Broker";
        public const string NAME_ROLE_BROKER = "Landlord";
        public const string MARKETPLACE_ID_TESTLANDLORD_DEMO = "1";
        public const string MARKETPLACE_ID_TESTLANDLORDTWO_DEMO = "3";
        public const string TRUE = "True";
        public const string FALSE = "False";

    }

    public class TestDataDBPayments
    {
        public const string TRANSACTION_ID_DELIVER_CHECK = "DeliverCheck";
        public const string TRANSACTION_STATUS_FAILED = "Failed";
        public const string TRANSACTION_STATUS_COMPLETED = "Completed";
        public const string TRANSACTION_STATUS_PENDING = "Pending";
        public const string TRANSACTION_TYPE_TENANT_APPLICATION = "TenantApplication";
        public const string TRANSACTION_TYPE_TENANT_HOLDING_DEPOSIT = "HoldingDepositPayment";
        public const string TRANSACTION_TYPE_TENANT_SINGING_LEASE = "SigningLease";
        public const string PROVIDER_NAME_CARDKNOX = "Cardknox";
        public const string PROVIDER_NAME_DELIVER_CHECK = "DeliverCheck";
    }

    public class TestDataDBForWebSiteTenant
    {
        public const string NEW_TENANT_EMAIL = "indigo123fgh@putsbox.com";
        public const string NEW_TENANT_FIRST_LAST_NAME = "Kelail Wolf";
        public const string NEW_TENANT_FIRST_NAME = "Indigo";
        public const string NEW_TENANT_LAST_NAME = "Alfa";
        public const string PASSED_BACKGROUND_CHECK_TENANT = "Passed";
        public const string PASSED_CREDIT_SCREENING_TENANT = "Passed";


        public const string NAME_ROLE_APPLICANT = "Applicant";
        public const string NAME_ROLE_OCCUPANT = "Occupant";
        public const string NAME_ROLE_GUARANTOR = "Guarantor";

        public const string APPLICANT_WIFE_TENANT_TENANTID = "75";
        public const string APPLICANT_WIFE_TENANT_USERID = "5efc0edc-d03f-4f1e-9bf2-c1cc2453b36f";
        
        public const string OCCUPANT_CROCODILE_DENDY_TENANTID = "47";
        public const string OCCUPANT_CROCODILE_DENDY_USERID = "1397a512-6600-40d8-95cd-e76f1e3af5e2";
        public const string OCCUPANT_CROCODILE_DENDY_EMAIL = "apipostman65455@gmail.com";

        public const string GUARANTOR_RODGER_VANPIECE_TENANTID = "48";
        public const string GUARANTOR_RODGER_VANPIECE_USERID = "149fcd30-8ddb-4c3d-9ffb-4c466861f25a";
        public const string GUARANTOR_RODGER_VANPIECE_EMAIL = "guarantor5935@gmail.com";
    }

    public class TestDataDBForWebSiteAdmin
    {
        public const string NEW_BROKER_EMAIL = "broker7djil@putsbox.com";
        public const string NEW_BROKER_FIRST_LAST_NAME = "Djill Coneri";
        public const string NEW_BROKER_FIRST_NAME = "Djill";
        public const string NEW_BROKER_ID = "1d1d8a02-b40a-42c4-b59f-dd0313bb1613";

        public const string NEW_AGENT_EMAIL = "new333ag@putsbox.com";
        public const string NEW_AGENT_FIRST_LAST_NAME = "Tiger Lion";
        public const string DELETED_AGENT_FIRST_LAST_NAME = "Creator-martin Testing";
        public const string DELETED_AGENT_EMAIL = "j8h5g3g3dd@putsbox.com";

        public const string BROKER_MARTIN_MACFLY_ID = "de0e57c0-6b1d-4f43-8640-f5592382c8be";
        public const string BROKER_MARTIN_MACFLY_LANDLORDID = "31";
        public const string BROKER_FIRST_NAME = "Martin";

        public const string AGENT_TEST_AGENT_ID = "f49afbfa-8834-4e59-991b-7ffbbe07e866";
        public const string AGENT_TEST_AGENT_BROKERDID = "31";
        public const string AGENT_FIRST_NAME = "Test";

        public const string NEW_BUILDING_NAME = "Creator Martin House two";

        public const string BUILDING_NAME = "Creator Martin two";
        public const string BUILDING_LLC_NAME = "LLC Chudo";
        public const string BUILDING_ADDRESS = "510 East 11th Street";
        public const string BUILDINGID = "22";
        public const string UNIT_NUMBER = "4E";
        public const string ID_TABLE_APARTMENTS_APARTMENTID = "83";
        public const string ID_UNIT_FOUR_E = "83";
    }

    public class TestDataForWebSiteTenant
    {
        public const string EMAIL_TENANT_APPLICANT = "tenantapp123ray@putsbox.com";
        public const string FIRST_NAME_TENANT_APPLICANT = "Ray";
        public const string LAST_NAME_TENANT_APPLICANT = "Anderson";

        public const string EMAIL_CURRENT_OCCUPANT_ONE = "tenantoccupantliza@xitroo.com";
        public const string FIRST_NAME_OCCUPANT_ONE = "Liza-Like";
        public const string LAST_NAME_OCCUPANT_ONE = "Junior";
        public const string PHONE_NUMBER_OCCUPANT_ONE = "2128765556";
        public const string NEW_FIRST_NAME_OCCUPANT_ONE = "Elizabeth";
        public const string NEW_LAST_NAME_OCCUPANT_ONE = "Taylor";
        public const string NEW_PHONE_NUMBER_OCCUPANT_ONE = "5151234321";

        public const string EMAIL_CURRENT_OCCUPANT_SECOND = "tenantoccupantalfred123@xitroo.com";
        public const string FIRST_NAME_OCCUPANT_SECOND = "Alfred";
        public const string LAST_NAME_OCCUPANT_SECOND = "Dickins";

        public const string EMAIL_GUARANTOR = "tenantguarantor333jimmy@xitroo.com";
        public const string FIRST_NAME_GUARANTOR = "Jimmy";

        public const string YOUR_CURRENT_ADDRESS_STREET_SECOND = "Frank";
        public const string YOUR_CURRENT_ADDRESS_CITY_SECOND = "Saint-Germain-du-Corbéis";
        public const string YOUR_CURRENT_ADDRESS_STATE_SECOND = "Normandy";
        public const string YOUR_CURRENT_ADDRESS_ZIP_SECOND = "61000";
        public const string SECTION_REFERENCE_NAME_SECOND = "Bob";
        public const string SECTION_REFERENCE_PHONE_NUMBER_SECOND = "5857771234";
        public const string SECTION_REFERENCE_EXTENSION_NUMBER_SECOND = "212";

        public const string YOUR_NEW__CURRENT_ADDRESS_STREET_SECOND = "Beaubien Street";
        public const string YOUR_NEW__CURRENT_ADDRESS_CITY_SECOND = "Detroit Lakes";
        public const string YOUR_NEW__CURRENT_ADDRESS_STATE_SECOND = "MN";
        public const string YOUR_NEW__CURRENT_ADDRESS_ZIP_SECOND = "56501";
        public const string SECTION_REFERENCE_NEW_NAME_SECOND = "Duglas";
        public const string SECTION_REFERENCE_NEW_PHONE_NUMBER_SECOND = "5854321333";
        public const string SECTION_REFERENCE_NEW_EXTENSION_NUMBER_SECOND = "585";
    }

    public class TestDataHomePageTenant
    {
        public const string NUMBER_BUILDING = "12";
    }

    public class TestDataForWebSiteAdmin
    {
        public const string MARKETPLACE_SUBDOMAIN = "testlandlord-demo";

        public const string USER_NAME_ROLE_OWNER = "Owner";


        public const string EMAIL_BROKER_MARTIN_MACFLY = "admin123@putsbox.com";
        public const string USER_NAME_BROKER_MARTIN_MACFLY = "Martin Macfly";
        public const string USER_NAME_ROLE_BROKER = "Broker";

        public const string EMAIL_SUPER_ADMIN_SUPER = "superadmin123@putsbox.com";
        public const string USER_NAME_SUPER_ADMIN = "Super User";
        public const string USER_NAME_ROLE_SUPER_ADMIN = "Super Admin";

        public const string EMAIL_AGENT_TEST = "agent123test@putsbox.com";
        public const string USER_NAME_AGENT = "Test Agent";
        public const string USER_NAME_ROLE_AGENT = "Agent";

        public const string BUILDING_NAME = "Diamond Hall";
        public const string BUILDING_LLC_NAME = "LLC Rent Corporation";
    }

    public class NameDomen
    {
        public static string XITROO = "@xitroo.com";
        public const string PUTS_BOX = "@putsbox.com";
    }

    public class UploadImages
    {
        public const string AVATAR_IMG_TENANT = $"\\UploadImages\\TenantImgEnot.jpg";
        public const string LOGO_IMG_ADMIN_FIRST = $"\\UploadImages\\LogoLandLord1.jpg";
        public const string LOGO_IMG_ADMIN_SECOND = $"\\UploadImages\\LogoLandlord2.jpg";
        public const string AVATAR_IMG_ADMIN_FIRST = $"\\UploadImages\\2AvatarLandLord.jpg";
        public const string AVATAR_IMG_ADMIN_SECOND = $"\\UploadImages\\3AvatarKoalaLandlord.jpg";
    }

    #region TestsDataDaysForDatePickerTenant

    public class DaysFirstWeekForDatePiker
    {
        public const int firstWeekfirstNumber = 0;
        public const int firstWeeksecondNumber = 1;
        public const int firstWeekthirdNumber = 2;
        public const int firstWeekfourthNumber = 3;
        public const int firstWeekfivethNumber = 4;
        public const int firstWeekksixthNumber = 5;
        public const int firstWeekseventhNumber = 6;

    }

    public class DaysSecondWeekForDatePiker
    {
        public const int secondWeekeighthNumber = 0;
        public const int secondWeekninethNumber = 1;
        public const int secondWeektenthNumber = 2;
        public const int secondWeekeleventhNumber = 3;
        public const int secondWeektwelvethNumber = 4;
        public const int secondWeekthirteenthNumber = 5;
        public const int secondWeekfourteenthNumber = 6;
    }

    public class DaysThirdWeekForDatePiker
    {
        public const int thirdWeekfiveteenthNumber = 0;
        public const int thirdWeeksixteenthNumber = 1;
        public const int thirdWeekseventeenthNumber = 2;
        public const int thirdWeekeighteenthNumber = 3;
        public const int thirdWeeknineteenthNumber = 4;
        public const int thirdWeektwentythNumber = 5;
        public const int thirdWeektwentyFirstNumber = 6;
    }

    public class DaysFourthWeekForDatePiker
    {
        public const int fourthWeektwentySecondNumber = 0;
        public const int fourthWeektwentyThirdNumber = 1;
        public const int fourthWeektwentyFourthNumber = 2;
        public const int fourthWeektwentyFivethNumber = 3;
        public const int fourthWeektwentySixthNumber = 4;
        public const int fourthWeektwentySeventhNumber = 5;
        public const int fourthWeektwentyEightthNumber = 6;
    }

    public class DaysFivethWeekForDatePiker
    {
        public const int fivethWeektwentyNinethNumber = 0;
        public const int fivethWeekthirtyNumber = 1;
        public const int fivethWeekthirtyFirstNumber = 2;
        public const int fivethWeekthirtySecondNumber = 3;
        public const int fivethWeekthirtyThirdNumber = 4;
        public const int fivethWeekthirtyFourthNumber = 5;
        public const int fivethWeekthirtyFivethNumber = 6;
    }

    #endregion

    #region TestsDataYearsForDatePickerTenant

    public class YearsFirstLineForDatePiker
    {
        public const int firstLineFirstYear = 0;
        public const int firstLineSecondYear = 1;
        public const int firstLineThirdYear = 2;
        public const int firstLineFourthYear = 3;

    }

    public class YearsSecondLineForDatePiker
    {
        public const int secondLineFirstYear = 0;
        public const int secondLineSecondYear = 1;
        public const int secondLineThirdYear = 2;
        public const int secondLineFourthYear = 3;
    }

    public class YearsThirdLineForDatePiker
    {
        public const int thirdLineFirstYear = 0;
        public const int thirdLineSecondYear = 1;
        public const int thirdLineThirdYear = 2;
        public const int thirdLineFourthYear = 3;
    }

    public class YearsFourthLineForDatePiker
    {
        public const int fourthLineFirstYear = 0;
        public const int fourthLineSecondYear = 1;
        public const int fourthLineThirdYear = 2;
        public const int fourthLineFourthYear = 3;
    }

    public class YearsFivethLineForDatePiker
    {
        public const int fivethLineFirstYear = 0;
        public const int fivethLineSecondYear = 1;
        public const int fivethLineThirdYear = 2;
        public const int fivethLineFourthYear = 3;
    }

    public class YearsSixthLineForDatePiker
    {
        public const int sixthLineFirstYear = 0;
        public const int sixthLineSecondYear = 1;
        public const int sixthLineThirdYear = 2;
        public const int sixthLineFourthYear = 3;
    }

    #endregion

    #region TestsDataMonthsForDatePickerTenant

    public class MonthsFirstLineForDatePiker
    {
        public const int firstLineJanuary = 0;
        public const int firstLineFebruary = 1;
        public const int firstLineMarch = 2;
        public const int firstLineApril = 3;

    }

    public class MonthsSecondLineForDatePiker
    {
        public const int secondLineMay = 0;
        public const int secondLineJune = 1;
        public const int secondLineJuly = 2;
        public const int secondLineAugust = 3;
    }

    public class MonthsThirdLineForDatePiker
    {
        public const int thirdLineSeptember = 0;
        public const int thirdLineOctober = 1;
        public const int thirdLineNovember = 2;
        public const int thirdLineDecember = 3;
    }

    #endregion

    public class TabsOnNewBuildingPage
    {
        public const int tabBasicDetails = 0;
        public const int tabAmenities = 1;
        public const int tabAccess = 2;
        public const int tabSpecials = 3;
        public const int tabImages = 4;
    }

    public class CardApartmentOnListOfApartments
    {
        public const int apartmentCardOne = 0;
        public const int apartmentCardTwo = 1;
        public const int apartmentCardThree = 2;
        public const int apartmentCardFour = 3;
        public const int apartmentCardFive = 4;
        public const int apartmentCardSix = 5;
        public const int apartmentCardSeven = 6;
        public const int apartmentCardEight = 7;
        public const int apartmentCardNine = 8;
        public const int apartmentCardTen = 9;
        public const int apartmentCardEleven = 10;
        public const int apartmentCardTwelve = 11;
    }
}
