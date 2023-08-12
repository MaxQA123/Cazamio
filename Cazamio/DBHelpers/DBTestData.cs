using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.DBHelpers
{
    public class DBTestDataGeneral
    {
        public const string ID_NAME_ROLE_TENANT = "726b52a7-a146-4a18-b2cd-b133c377c715";
        public const string ID_NAME_ROLE_SUPER_ADMIN = "86779821-785f-4710-8d0c-2cc4ab5af6a9";
        public const string ID_NAME_ROLE_AGENT = "a6841be6-7bc6-4510-bf70-bd8efc887486";
        public const string ID_NAME_ROLE_BROKER = "ee430d91-8a3b-45a9-891c-94cb16935d49";
        public const string ID_NAME_ROLE_MARKETPLACE_ADMIN = "e5a4e959-d3f1-4242-9a72-6aac3acaecb4";
        public const string NAME_ROLE_TENANT = "Tenant";
        public const string NAME_ROLE_SUPER_ADMIN = "Admin";
        public const string NAME_ROLE_AGENT = "Broker";
        public const string NAME_ROLE_BROKER = "Landlord";
        public const string NAME_ROLE_MARKETPLACE_ADMIN = "MarketplaceAdmin";
        public const string MARKETPLACE_ID_TESTLANDLORD_DEMO = "1";
        public const string MARKETPLACE_ID_TESTLANDLORD_TWO_DEMO = "3";
        public const string TRUE = "True";
        public const string FALSE = "False";
        public const string BACKGROUND_CHECK = "BackgroundCheck";
        public const string CREDIT_SCREENING = "CreditScreening";
        public const string PASSED = "Passed";
        public const string NAME_ROLE_APPLICANT = "Applicant";
        public const string NAME_ROLE_OCCUPANT = "Occupant";
        public const string NAME_ROLE_GUARANTOR = "Guarantor";
    }

    public class DBTestDataPayments
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

    public class DBTestDataForTenantMarketplaceOne
    {
        public const string NEW_TENANT_EMAIL = "guarantor5935@gmail.com";
        public const string NEW_TENANT_USER_NAME = "guarantor5935@gmail.com";
        public const string NEW_TENANT_FIRST_LAST_NAME = "Rodger Vanpiece";
        public const string NEW_TENANT_FIRST_NAME = "Rodger";
        public const string NEW_TENANT_LAST_NAME = "Vanpiece";
        public const string ALREADY_EXIST_TENANT_FIRST_LAST_NAME = "Testing Test";

        public const string TENANT_APPLICANT_RAY_TENANT_ID = "153";
        public const string TENANT_APPLICANT_RAY_USER_ID = "dc996051-30d9-4960-8660-2fc99f650549";

        public const string TENANT_OCCUPANT_LIZA_TENANT_ID = "156";
        public const string TENANT_OCCUPANT_LIZA_USER_ID = "8fef0101-e209-4227-9bde-a5fd1d205d09";

        public const string TENANT_OCCUPANT_ALFRED_TENANT_ID = "155";
        public const string TENANT_OCCUPANT_ALFRED_USER_ID = "31f14a24-ac0a-4d7c-a3b3-41277a44d860";

        public const string TENANT_GUARANTOR_JIMMY_TENANT_ID = "154";
        public const string TENANT_GUARANTOR_JIMMY_USER_ID = "283d4524-1ba6-4860-952c-350c70be47aa";
    }

    public class DBTestDataForTenantMarketplaceThree
    {
        public const string NEW_TENANT_EMAIL = "";
        public const string NEW_TENANT_USER_NAME = "";
        public const string NEW_TENANT_FIRST_LAST_NAME = "";
        public const string NEW_TENANT_FIRST_NAME = "";
        public const string NEW_TENANT_LAST_NAME = "";
        public const string ALREADY_EXIST_TENANT_FIRST_LAST_NAME = "";

        public const string TENANT_APPLICANT_RAY_TENANT_ID = "";
        public const string TENANT_APPLICANT_RAY_USER_ID = "";

        public const string TENANT_OCCUPANT_LIZA_TENANT_ID = "";
        public const string TENANT_OCCUPANT_LIZA_USER_ID = "";

        public const string TENANT_OCCUPANT_ALFRED_TENANT_ID = "";
        public const string TENANT_OCCUPANT_ALFRED_USER_ID = "";

        public const string TENANT_GUARANTOR_JIMMY_TENANT_ID = "";
        public const string TENANT_GUARANTOR_JIMMY_USER_ID = "";
    }

    public class DBTestDataDBForAdmins
    {
        public const string NEW_MARKETPLACE_ADMIN_EMAIL = "marketplace1110ne@gmail.com";
        public const string NEW_MARKETPLACE_ADMIN_FIRST_LAST_NAME = "Master Yoda";
        public const string NEW_MARKETPLACE_ADMIN_FIRST_NAME = "Master";
        public const string NEW_MARKETPLACE_ADMIN_LAST_NAME = "Yoda";

        public const string NEW_BROKER_EMAIL = "admin123@putsbox.com";
        public const string NEW_BROKER_FIRST_LAST_NAME = "Martin Macfly";
        public const string NEW_BROKER_FIRST_NAME = "Martin";
        public const string NEW_BROKER_LAST_NAME = "Macfly";

        public const string NEW_AGENT_EMAIL = "agent123test@putsbox.com";
        public const string NEW_AGENT_FIRST_LAST_NAME = "Test Agent";
        public const string NEW_AGENT_FIRST_NAME = "Test";
        public const string NEW_AGENT_LAST_NAME = "Agent";
        public const string NEW_AGENT_PHONE_NUMBER = "2121234321";
        public const string NEW_AGENT_CELL_PHONE_NUMBER = "5855679876";

        public const string DELETED_AGENT_FIRST_LAST_NAME = "Creator-martin Testing";
        public const string DELETED_AGENT_EMAIL = "j8h5g3g3dd@putsbox.com";

        public const string NEW_OWNER_EMAIL = "j8k8owner@xitroo.com";
        public const string NEW_OWNER_FIRST_LAST_NAME = "Fillip";
        public const string NEW_OWNER_FIRST_NAME = "Fillip";
        public const string NEW_COMPANY_NAME_OWNER = "LLC first house 555";
        public const string NEW_OFFICE_LOCATION_OWNER = "London";

        public const string MARKETPLACE_ADMIN_EMAIL = "marketplace1chui@putsbox.com";
        public const string MARKETPLACE_ADMIN_FIRST_LAST_NAME = "Chui Chubaka";
        public const string MARKETPLACE_ADMIN_FIRST_NAME = "Chui";
        public const string MARKETPLACE_ADMIN_LAST_NAME = "Chubaka";

        public const string BROKER_MARTIN_MACFLY_ID = "fd05b9e1-e219-4b56-962f-1b0b1b54c443";
        public const string BROKER_MARTIN_MACFLY_LANDLORD_ID = "53";
        public const string BROKER_FIRST_NAME = "Martin";
        public const string BROKER_EMAIL = "admin123@putsbox.com";

        public const string AGENT_TEST_AGENT_ID = "";
        public const string AGENT_TEST_AGENT_BROKER_ID = "";
        public const string AGENT_FIRST_NAME = "Test";

        public const string OWNER_AGATA_ID = "";
        public const string OWNER_AGATA_OWNER_ID = "";
        public const string OWNER_AGATA_EMAIL = "owneragata@putsbox.com";
        public const string OWNER_FIRST_NAME = "Agata";

        public const string NEW_BUILDING_NAME = "Creator Yoda assigned to Martin 12345 House Home";

        public const string NEW_UNIT_NUMBER = "19";

        public const string BUILDING_NAME = "Creator Yoda assigned to Martin 12345 House Home";
        public const string BUILDING_LLC_NAME = "LLC Chudo life 888 wonderful";
        public const string BUILDING_ADDRESS = "101 Franklin Avenue";
        public const string BUILDING_ID = "48";
        public const string UNIT_NUMBER = "26";
        public const string APARTMENT_ID_UNIT_NUMBER = "83";
        public const string ID_UNIT_FOUR_E = "83";
    }

    public class DBTestDataDBForAdminsMySpace
    {
        #region MySpace

        public const string NEW_OWNER_EMAIL = "asd4tyu@xitroo.com";
        public const string NEW_OWNER_FIRST_LAST_NAME = "Jigo";
        public const string NEW_OWNER_FIRST_NAME = "Jigo";
        public const string NEW_COMPANY_NAME_OWNER = "OOO Almaz";
        public const string NEW_OFFICE_LOCATION_OWNER = "London";

        public const string OWNER_EMAIL = "gh67re@putsbox.com";

        public const string BROKER_MANDO_MANDALORIAN_ID = "";
        public const string BROKER_MANDO_MANDALORIAN_LANDLORD_ID = "63";
        public const string BROKER_FIRST_NAME = "Martin";
        public const string BROKER_EMAIL = "mando123broker@gmail.com";

        #endregion
    }

}
