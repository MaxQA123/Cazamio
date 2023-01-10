using Allure.Commons;
using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.BaseTestsDBTenants
{
    [TestFixture]
    [AllureNUnit]

    public class TenantsTestsDB
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBTenant")]
        [AllureSubSuite("RelatedOwnerWithAdmin")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: records about a new tenant in the tables "Tenants", "AspNetUsers" and "AspNetUserRoles"
        //Path to cheking's: 
        public void RecordsAboutNewTenant()
        {
            string newTenant = TestDataDBForWebSiteTenant.NEW_TENANT_FIRST_LAST_NAME;

            string idTenantTenants = DBTenants.GetIdForNewTenantTableTenants();
            Console.WriteLine($"Id for new tenant {newTenant} from table tenants: {idTenantTenants}");

            string userIdTenantTenants = DBTenants.GetUserIdForNewTenantTableTenants();
            Console.WriteLine($"UserId for new tenant {newTenant} from table tenants: {userIdTenantTenants}");
            
            string idTenantAspNetUsers = DBTenants.GetIdForNewTenantTableAspNetUsers("globo34f6fhj@putsbox.com");
            Console.WriteLine($"Id for new tenant {newTenant} from table AspNetUsers: {idTenantAspNetUsers}");

            string idTenantAspNetUserRoles = DBTenants.GetRoleIdForNewTenantTableAspNetUserRoles();
            Console.WriteLine($"RoleId for new tenant {newTenant} from table AspNetUserRoles: {idTenantAspNetUserRoles}");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(userIdTenantTenants, idTenantAspNetUsers);
                Console.WriteLine($"UserId a new tenant from table Tenants: {userIdTenantTenants} = {idTenantAspNetUsers} Id for tenant from table AspNetUsers");

                Assert.AreEqual(idTenantAspNetUserRoles, TestDataDBGeneral.ID_NAME_ROLE_TENANT);
                Console.WriteLine($"RoleId tenant for a new tenant AR: {idTenantAspNetUserRoles} = {TestDataDBGeneral.ID_NAME_ROLE_TENANT} RoleId tenant for a new tenant ER");
            });
        }
    }
}
