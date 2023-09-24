using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.ApiHelpers.TableTenants
{
    public class DBModelsTenants
    {
        public object? Id { get; set; } // this might be another data type
        public object? UserId { get; set; }
        public object? CreditAmount { get; set; }
        public object? CreationDate { get; set; }
        public object? ModifyDate { get; set; }
        public object? IsDeleted { get; set; }
        public object? GeneralApplicationProgress { get; set; }
        public object? MarketplaceId { get; set; }
    }
}
