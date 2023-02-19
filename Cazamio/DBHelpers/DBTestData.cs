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
        public const string NAME_ROLE_TENANT = "Tenant";
        public const string NAME_ROLE_SUPER_ADMIN = "Admin";
        public const string NAME_ROLE_AGENT = "Broker";
        public const string NAME_ROLE_BROKER = "Landlord";
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
        public const string NEW_TENANT_EMAIL = "h222erfd5dr4r@putsbox.com";
        public const string NEW_TENANT_USER_NAME = "h222erfd5dr4r@putsbox.com";
        public const string NEW_TENANT_FIRST_LAST_NAME = "Pete Duda";
        public const string NEW_TENANT_FIRST_NAME = "Pete";
        public const string NEW_TENANT_LAST_NAME = "Duda";
        public const string ALREADY_EXIST_TENANT_FIRST_LAST_NAME = "Testing Test";

        public const string TENANT_APPLICANT_RAY_TENANT_ID = "87";
        public const string TENANT_APPLICANT_RAY_USER_ID = "4bb26583-6a79-40c7-8839-508774a9daf8";

        public const string TENANT_OCCUPANT_LIZA_TENANT_ID = "90";
        public const string TENANT_OCCUPANT_LIZA_USER_ID = "74af5e76-4590-44b4-9a24-72cae8aa7201";

        public const string TENANT_OCCUPANT_ALFRED_TENANT_ID = "102";
        public const string TENANT_OCCUPANT_ALFRED_USER_ID = "1e037059-0fd0-43d8-b972-167a7351c4e1";

        public const string TENANT_GUARANTOR_JIMMY_TENANT_ID = "88";
        public const string TENANT_GUARANTOR_JIMMY_USER_ID = "ca977e7a-726f-4bbf-b5a9-1506d4c57469";
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
        public const string NEW_BROKER_EMAIL = "m39mf745bb@putsbox.com";
        public const string NEW_BROKER_FIRST_LAST_NAME = "Frido Dido";
        public const string NEW_BROKER_FIRST_NAME = "Frido";

        public const string NEW_AGENT_EMAIL = "j81ndv5s@putsbox.com";
        public const string NEW_AGENT_FIRST_LAST_NAME = "Cowboy Malrboro";
        public const string NEW_AGENT_FIRST_NAME = "Cowboy";
        public const string DELETED_AGENT_FIRST_LAST_NAME = "Creator-martin Testing";
        public const string DELETED_AGENT_EMAIL = "j8h5g3g3dd@putsbox.com";

        public const string NEW_OWNER_EMAIL = "u3l4o8d6f@putsbox.com";
        public const string NEW_OWNER_FIRST_LAST_NAME = "Snow Row";
        public const string NEW_OWNER_FIRST_NAME = "Snow";
        public const string NEW_COMPANY_NAME_OWNER = "LLC New Daily";
        public const string NEW_OFFICE_LOCATION_OWNER = "Toronto";

        public const string BROKER_MARTIN_MACFLY_ID = "de0e57c0-6b1d-4f43-8640-f5592382c8be";
        public const string BROKER_MARTIN_MACFLY_LANDLORD_ID = "31";
        public const string BROKER_FIRST_NAME = "Martin";

        public const string AGENT_TEST_AGENT_ID = "f49afbfa-8834-4e59-991b-7ffbbe07e866";
        public const string AGENT_TEST_AGENT_BROKER_ID = "49";
        public const string AGENT_FIRST_NAME = "Test";

        public const string OWNER_AGATA_ID = "de0e57c0-6b1d-4f43-8640-f5592382c8be";
        public const string OWNER_AGATA_OWNER_ID = "35";
        public const string OWNER_AGATA_EMAIL = "owneragata@putsbox.com";
        public const string OWNER_FIRST_NAME = "Agata";

        public const string NEW_BUILDING_NAME = "House Creator Martin 111 four";

        public const string NEW_UNIT_NUMBER = "16";

        public const string BUILDING_NAME = "Creator Martin two";
        public const string BUILDING_LLC_NAME = "LLC Chudo";
        public const string BUILDING_ADDRESS = "510 East 11th Street";
        public const string BUILDING_ID = "48";
        public const string UNIT_NUMBER = "11";
        public const string APARTMENT_ID_UNIT_NUMBER = "83";
        public const string ID_UNIT_FOUR_E = "83";
    }
}
