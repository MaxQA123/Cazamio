﻿using CazamioProgect.Helpers;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.Objects
{
    public class MarketplaceAdmin
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ShortEmail { get; set; }
        public string SubdomainMySpace { get; set; }
        public string EmailAddressMarketplaceAdmin { get; set; }
        public string FullNameMarketplaceAdmin { get; set; }

        public MarketplaceAdmin Generate()
        {
            string firsName = "Mark-admin";
            string lastName = Name.LastName();
            string shortEmail = GenerateRandomDataHelper.RandomEmail(5) + GenerateRandomDataHelper.RandomNumberWithoutZero(3) + GenerateRandomDataHelper.RandomEmail(2);
            string subdomainMySpace = "testlandlord15-demo";
            string emailAddressMarketplaceAdmin = "marketplaceadmin15@putsbox.com";
            string fullNameMarketplaceAdmin = "Mark Adm";

            var marketplaceAdmin = new MarketplaceAdmin()
            {
                FirstName = firsName,
                LastName = lastName,
                EmailAddress = shortEmail + NameDomen.PUTS_BOX,
                ShortEmail = shortEmail,
                SubdomainMySpace = subdomainMySpace,
                EmailAddressMarketplaceAdmin = emailAddressMarketplaceAdmin,
                FullNameMarketplaceAdmin = fullNameMarketplaceAdmin,
            };
            return marketplaceAdmin;
        }
    }
}
