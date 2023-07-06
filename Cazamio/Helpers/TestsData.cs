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
        public const string URL_PUTSBOX_EMAIL_STATIC_MARKETPLACE_ADMIN = "https://putsbox.com/marketplace1chui/inspect";
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
        public const string CODE_PHONE_NUMBER_ONE = "212";
        public const string CODE_PHONE_NUMBER_TWO = "585";
        public const string TEXT_LOREM = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio et ante tincidunt tempus. Donec vitae sapien ut libero venenatis faucibus. Nullam quis ante. Etiam sit amet orci eget eros faucibus tincidunt. Duis leo. Sed fringilla mauris sit amet nibh. Donec sodales sagittis magna. Sed consequat, leo eget bibendum sodales, augue velit cursus nunc,";
    }

    public class TestDataForWebSiteTenant
    {
        public const string EMAIL_TENANT_APPLICANT = "tenantapp123ray@putsbox.com";
        public const string FIRST_LAST_NAME_TENANT_APPLICANT = "Ray Anredson";
        public const string FIRST_NAME_TENANT_APPLICANT = "Ray";
        public const string LAST_NAME_TENANT_APPLICANT = "Anderson";

        public const string EMAIL_CURRENT_OCCUPANT_ONE = "tenantocc123liza@putsbox.com";
        public const string FIRST_NAME_OCCUPANT_ONE = "Liza-Like";
        public const string LAST_NAME_OCCUPANT_ONE = "Junior";
        public const string PHONE_NUMBER_OCCUPANT_ONE = "2128765556";
        public const string NEW_FIRST_NAME_OCCUPANT_ONE = "Elizabeth";
        public const string NEW_LAST_NAME_OCCUPANT_ONE = "Taylor";
        public const string NEW_PHONE_NUMBER_OCCUPANT_ONE = "5151234321";

        public const string EMAIL_CURRENT_OCCUPANT_SECOND = "tenantocc123liza@putsbox.com";
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

        public const string EMAIL_MARKETPLACE_ADMIN_CHUI_CHUBAKA = "marketplace1chui@putsbox.com";
        public const string USER_NAME_MARKETPLACE_ADMIN_CHUI_CHUBAKA = "Chui Chubaka";
        public const string USER_NAME_ROLE_MARKETPLACE_ADMIN = "Marketplace Admin";

        public const string EMAIL_BROKER_MARTIN_MACFLY = "admin123@putsbox.com";
        public const string USER_NAME_BROKER_MARTIN_MACFLY = "Martin Macfly";
        public const string USER_NAME_ROLE_BROKER = "Broker";

        public const string EMAIL_SUPER_ADMIN = "superadmin123@putsbox.com";
        public const string USER_NAME_SUPER_ADMIN = "Super User";
        public const string USER_NAME_ROLE_SUPER_ADMIN = "Super Admin";

        public const string EMAIL_AGENT_TEST = "agent123test@putsbox.com";
        public const string USER_NAME_AGENT = "Test Agent";
        public const string USER_NAME_ROLE_AGENT = "Agent";

        public const string ADDRESS_BUILDING = "4 Times Square";
        public const string CITY_BUILDING = "New York";
        public const string STATE_BUILDING = "NY";
        public const string ZIP_BUILDING = "10036";
        public const string NEIGHBORHOOD_BUILDING = "Manhattan";
        public const string BUILDING_NAME_NEW_BUILDING = "Original ZIP Manhattan Creator Chui Assigned Martin";
        public const string BUILDING_LLC_NAME_NEW_BUILDING = "LLC Home-House town";
        public const string DESCRIPTION_NEW_BUILDING = "DESCRIPTION FOR BUILDING 1234567890 ";
        public const string INTERNAL_NOTES_NEW_BUILDING = "Internal Notes FOR BUILDING 0987654321 ";
        public const string FIRST_NAME_LOCATION = "Main Entrance";
        public const string SECOND_NAME_LOCATION = "Apartment";
        public const string THIRD_NAME_LOCATION = "Concierge";
        public const string CAB_NAME_LOCK_ACCESS = "CAB";
        public const string NOTE_NAME_LOCK_ACCESS = "Note";
        public const string PIN_CODE_NAME_LOCK_ACCESS = "PinCode";
        public const string CONCESSION_NAME = "Concess1";
        public const string CONCESSION_MONTHS_FREE = "7";
        public const string CONCESSION_LEASE_TERMS = "55";
        public const string FREE_STUFF_NAME = "FreeStuff1";

        public const string BUILDING_NAME = "Diamond Hall";
        public const string BUILDING_LLC_NAME = "LLC Rent Corporation";

        public const string UNIT_NUMBER = "1Q";
        public const string HALF_BEDS_BATHS_NUMBER = "1";
        public const string DEFAULT_MONTHLY_RENTS_PREPAYMENT = "1";
        public const string DEFAULT_APARTMENT_TYPE = "MultiFamily";
        public const string DEFAULT_APARTMENT_HOLD_DEPOSIT = "500";
        public const string DEFAULT_RENTAL_TERMS = "12 months\r\ncancel";
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
        public const string IMAGE_FOR_LOCK_OK = $"\\UploadImages\\OK.jpg";
        public const string IMAGE_HOUSE_FOR_BUILDING = $"\\UploadImages\\HouseOne.jpg";
        public const string IMAGE_POOL_FOR_BUILDING = $"\\UploadImages\\Pool.jpg";
        public const string IMAGE_PARKING_FOR_BUILDING = $"\\UploadImages\\Parking.jpg";
        public const string IMAGE_YARD_FOR_BUILDING = $"\\UploadImages\\Yard.jpg";
    }

    #region TestsDataDaysForDatePickerAdmins

    public class DaysFirstLineForDatePiker
    {
        public const int FIRST_LINE_FIRST_NUMBER = 0;
        public const int FIRST_LINE_SECOND_NUMBER = 1;
        public const int FIRST_LINE_THIRD_NUMBER = 2;
        public const int FIRST_LINE_FOURTH_NUMBER = 3;
        public const int FIRST_LINE_FIVETH_NUMBER = 4;
        public const int FIRST_LINE_SIXTH_NUMBER = 5;
        public const int FIRST_LINE_SEVENTH_NUMBER = 6;

    }

    public class DaysSecondLineForDatePiker
    {
        public const int SECOND_LINE_FIRST_NUMBER = 0;
        public const int SECOND_LINE_SECOND_NUMBER = 1;
        public const int SECOND_LINE_THIRD_NUMBER = 2;
        public const int SECOND_LINE_FOURTH_NUMBER = 3;
        public const int SECOND_LINE_FIVETH_NUMBER = 4;
        public const int SECOND_LINE_SIXTH_NUMBER = 5;
        public const int SECOND_LINE_SEVENTH_NUMBER = 6;
    }

    public class DaysThirdLineForDatePiker
    {
        public const int THIRD_LINE_FIRST_NUMBER = 0;
        public const int THIRD_LINE_SECOND_NUMBER = 1;
        public const int THIRD_LINE_THIRD_NUMBER = 2;
        public const int THIRD_LINE_FOURTH_NUMBER = 3;
        public const int THIRD_LINE_FIVETH_NUMBER = 4;
        public const int THIRD_LINE_SIXTH_NUMBER = 5;
        public const int THIRD_LINE_SEVENTH_NUMBER = 6;
    }

    public class DaysFourthLineForDatePiker
    {
        public const int FOURTH_LINE_FIRST_NUMBER = 0;
        public const int FOURTH_LINE_SECOND_NUMBER = 1;
        public const int FOURTH_LINE_THIRD_NUMBER = 2;
        public const int FOURTH_LINE_FOURTH_NUMBER = 3;
        public const int FOURTH_LINE_FIVETH_NUMBER = 4;
        public const int FOURTH_LINE_SIXTH_NUMBER = 5;
        public const int FOURTH_LINE_SEVENTH_NUMBER = 6;
    }

    public class DaysFivethLineForDatePiker
    {
        public const int FIVETH_LINE_FIRST_NUMBER = 0;
        public const int FIVETH_LINE_SECOND_NUMBER = 1;
        public const int FIVETH_LINE_THIRD_NUMBER = 2;
        public const int FIVETH_LINE_FOURTH_NUMBER = 3;
        public const int FIVETH_LINE_FIVETH_NUMBER = 4;
        public const int FIVETH_LINE_SIXTH_NUMBER = 5;
        public const int FIVETH_LINE_SEVENTH_NUMBER = 6;
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
        public const int TAB_BASIC_DETAILS = 0;
        public const int TAB_AMENITIES = 1;
        public const int TAB_ACCESS = 2;
        public const int TAB_SPECIALS = 3;
        public const int TAB_IMAGES = 4;
    }

    public class ItemsPetPolicies
    {
        public const int CASE_BY_CASE = 0;
        public const int PETS_FEE = 1;
        public const int ALL_PETS_ALLOWED = 2;
        public const int SMALL_PETS_ALLOWED = 3;
        public const int CATS_ONLY = 4;
        public const int NO_PETS = 5;
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

    public class PaginationList
    {
        public const int PAGE_TWO = 0;
        public const int apartmentCardTwo = 1;
        public const int apartmentCardThree = 2;
        public const int apartmentCardFour = 3;
        public const int apartmentCardFive = 4;
    }

    public class PaginationListOfMarketplaceAdminsPage
    {
        public const int PAGE_TWO = 0;
        public const int PAGE_THREE = 1;
        public const int PAGE_FOUR = 2;
        public const int PAGE_FIVE = 3;
        public const int PAGE_SIX = 4;
    }

    public class ListOfAmenitiesForBuildingAdminsPage
    {
        public const int FIRST_TAG = 0;
    }

    public class ListOfAccessTypesForBuildingAdminsPage
    {
        public const int BLUETOOTH = 0;
        public const int WIFI = 1;
        public const int PIN_CODE = 2;
        public const int NOTE = 3;
        public const int CAB = 4;
    }

}
