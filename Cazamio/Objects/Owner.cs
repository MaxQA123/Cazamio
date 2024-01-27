using CazamioProgect.Helpers;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.Objects
{
    public class Owner
    {
        public string CompanyName { get; set; }
        public string CompanyNameWithBroker { get; set; }
        public string CompanyNameWithAgent { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ShortEmail { get; set; }
        public string OfficeLocation { get; set; }
        public string InternalNotes { get; set; }
        public string PhoneNumber { get; set; }
        public string ExtensionNumber { get; set; }
        public string OwnerNumberOfMonths { get; set; }
        public string TenantNumberOfMonths { get; set; }
        public string OwnerPercentage { get; set; }
        public string TenantPercentage { get; set; }
        public string TakeOff { get; set; }
        public string EmailAddressOwnerForAgent { get; set; }
        public string EmailAddressOwnerForBroker { get; set; }

        public Owner Generate()
        {
            string companyName = "OOO assigned role";
            string roleBroker = "Broker";
            string roleAgent = "Agent";
            string FullName = Name.FirstName() + " " + Name.LastName();
            string firstName = Name.FirstName();
            string lastName = Name.LastName();
            string shortEmail = GenerateRandomDataHelper.RandomEmail(5) + GenerateRandomDataHelper.RandomNumberWithoutZero(3) + GenerateRandomDataHelper.RandomEmail(2);
            string officeLocation = Address.City();
            string internalNotes = "Owner lorem ipsum (12345) (&%$#@!)";
            string phoneNumber = "585" + GenerateRandomDataHelper.RandomPhoneNumber(7);
            string extensionNumber = "325" + GenerateRandomDataHelper.RandomPhoneNumber(7);
            string ownerNumberOfMonths = GenerateRandomDataHelper.RandomNumberWithoutZero(1);
            string tenantNumberOfMonths = GenerateRandomDataHelper.RandomNumberWithoutZero(1);
            string ownerPercentage = GenerateRandomDataHelper.RandomNumberWithoutZero(2);
            string tenantPercentage = GenerateRandomDataHelper.RandomNumberWithoutZero(2);
            string takeOff = GenerateRandomDataHelper.RandomNumberWithoutZero(2);
            string emailAddressOwnerForAgent = "owner2forag5bro@putsbox.com";
            string emailAddressOwnerForBroker = "owner2for5broker@putsbox.com";

            var owner = new Owner()
            {
                CompanyName = companyName,
                CompanyNameWithAgent = companyName + " " + roleAgent,
                CompanyNameWithBroker = companyName + " " + roleBroker,
                FullName = FullName,
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = shortEmail + NameDomen.PUTS_BOX,
                ShortEmail = shortEmail,
                OfficeLocation = officeLocation,
                InternalNotes = internalNotes,
                PhoneNumber = phoneNumber,
                ExtensionNumber = extensionNumber,
                OwnerNumberOfMonths = ownerNumberOfMonths,
                TenantNumberOfMonths = tenantNumberOfMonths,
                OwnerPercentage = ownerPercentage,
                TenantPercentage = tenantPercentage,
                TakeOff = takeOff,
                EmailAddressOwnerForAgent = emailAddressOwnerForAgent,
                EmailAddressOwnerForBroker = emailAddressOwnerForBroker,
            };
            return owner;
        }
    }
}
