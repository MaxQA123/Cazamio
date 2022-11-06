﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.Helpers
{
    public class EndPoints
    {
        public const string URL_HOME_PAGE_TENANT_WEBSITE_CAZAMIO = "https://testlanlord.cazamiodemo.com/";
        public const string urlLogInPageLandlordBrokerWebSite = "https://landlord.cazamiodemo.com/";
        public const string urlXitrooRandom = "https://xitroo.com/";
        public const string urlXitrooStaticBroker = "https://xitroo.com/#liludalastfg@xitroo.com";
        public const string urlXitrooStaticLandlord = "https://xitroo.com/#testlivelandlord@gmail.com";
        public const string urlXitrooStaticTenant = "https://xitroo.com/#kickasswiles@xitroo.com";
    }

    public class GeneralTestDataForAllUsers
    {
        public const string PASSWORD_GENERAL = "Qwerty123!";
        public const string PASSWORD_NEW_GENEREAL = "!321Qwerty";
    }

    public class TestDataForWebSiteTenant
    {
        public const string EMAIL_TENANT_APPLICANT = "tenantaplicantray@xitroo.com";
        public const string FIRST_NAME_TENANT_APPLICANT = "Ray";
        public const string LAST_NAME_TENANT_APPLICANT = "Anderson";

        public const string EMAIL_CURRENT_OCCUPANT_LIZA_LIKE = "tenantoccupantliza@xitroo.com";
        public const string FIRST_NAME_OCCUPANT_LIZA_LIKE = "Liza-Like";
        public const string LAST_NAME_OCCUPANT_LIZA_LIKE = "Junior";
        public const string PHONE_NUMBER_OCCUPANT_LIZA_LIKE = "2128765556";
        public const string NEW_FIRST_NAME_OCCUPANT_LIZA_LIKE = "Elizabeth";
        public const string NEW_LAST_NAME_OCCUPANT_LIZA_LIKE = "Taylor";
        public const string NEW_PHONE_NUMBER_OCCUPANT_LIZA_LIKE = "5151234321";

        public const string EMAIL_CURRENT_OCCUPANT_ALFRED = "tenantoccupantalfred123@xitroo.com";
        public const string FIRST_NAME_OCCUPANT_ALFRED = "Alfred";
        public const string LAST_NAME_OCCUPANT_ALFRED = "Dickins";

        public const string EMAIL_GUARANTOR_JIMMY = "tenantguarantor333jimmy@xitroo.com";
        public const string FIRST_NAME_GUARANTOR_JIMMY = "Jimmy";

        public const string YOUR_CURRENT_ADDRESS_STREET_ALFRED = "Frank";
        public const string YOUR_CURRENT_ADDRESS_CITY_ALFRED = "Saint-Germain-du-Corbéis";
        public const string YOUR_CURRENT_ADDRESS_STATE_ALFRED = "Normandy";
        public const string YOUR_CURRENT_ADDRESS_ZIP_ALFRED = "61000";
        public const string SECTION_REFERENCE_NAME_ALFRED = "Bob";
        public const string SECTION_REFERENCE_PHONE_NUMBER_ALFRED = "5857771234";
        public const string SECTION_REFERENCE_EXTENSION_NUMBER_ALFRED = "212";

        public const string YOUR_NEW__CURRENT_ADDRESS_STREET_ALFRED = "Beaubien Street";
        public const string YOUR_NEW__CURRENT_ADDRESS_CITY_ALFRED = "Detroit Lakes";
        public const string YOUR_NEW__CURRENT_ADDRESS_STATE_ALFRED = "MN";
        public const string YOUR_NEW__CURRENT_ADDRESS_ZIP_ALFRED = "56501";
        public const string SECTION_REFERENCE_NEW_NAME_ALFRED = "Duglas";
        public const string SECTION_REFERENCE_NEW_PHONE_NUMBER_ALFRED = "5854321333";
        public const string SECTION_REFERENCE_NEW_EXTENSION_NUMBER_ALFRED = "585";
    }

    public class TestDataForWebSiteAdmin
    {
        public const string EMAIL_ADMIN_TEST_GARY = "testlandlordcaz@xitroo.com";
        public const string USER_NAME_ADMIN_TEST_GARY = "Gary Test";

        public const string EMAIL_SUPER_ADMIN_SUPER = "martin@abodebyreside.com";
        public const string USER_NAME_SUPER_ADMIN = "Super User";

        public const string EMAIL_BROKER_TEST = "testbrokercaz@xitroo.com";
        public const string USER_NAME_BROKER = "Test Broker";

        public const string BUILDING_NAME = "Test building";
        public const string BUILDING_LLC_NAME = "LLC Corporation rent";
    }

    public class NameDomen
    {
        public static string XITROO = "@xitroo.com";
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
}
