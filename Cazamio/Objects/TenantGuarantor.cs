using CazamioProgect.Helpers;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.Objects
{
    public class TenantGuarantor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ShortEmail { get; set; }
        public string EmailAddressTenant { get; set; }
        public string FirstNameTenant { get; set; }
        public string LastNameTenant { get; set; }
        public string FullNameTenant { get; set; }

        public TenantGuarantor Generate()
        {
            string firsName = "TenantQA";
            string lastName = Name.LastName();
            string shortEmail = GenerateRandomDataHelper.RandomEmail(5) + GenerateRandomDataHelper.RandomNumberWithoutZero(3) + GenerateRandomDataHelper.RandomEmail(2);
            string emailAddressTenant = "tenantgua123jim@putsbox.com";
            string firstNameTenant = "Jimmy";
            string lastNameTenant = "Todeski";
            string fullNameTenant = firstNameTenant + " " + lastNameTenant;

            var tenantGuarantor = new TenantGuarantor()
            {
                FirstName = firsName,
                LastName = lastName,
                EmailAddress = shortEmail + NameDomen.PUTS_BOX,
                ShortEmail = shortEmail,
                EmailAddressTenant = emailAddressTenant,
                FirstNameTenant = firstNameTenant,
                LastNameTenant = lastNameTenant,
                FullNameTenant = fullNameTenant,
            };
            return tenantGuarantor;
        }
    }
}
