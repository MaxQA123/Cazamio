﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.ApiHelpers.ApiPagesObjects.ApiSuperAdminPages.CreateMarketplaceAdminApi
{
    public class RequestCreateMarketplaceAdmin
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string subDomain { get; set; }
    }

}
