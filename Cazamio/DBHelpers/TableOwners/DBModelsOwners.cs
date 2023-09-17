using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.DBHelpers.TableOwners
{
    public class DBModelsOwners
    {
        public object? Id { get; set; } // this might be another data type
        public object? OwnerName { get; set; }
        public object? CompanyName { get; set; }
        public object? OwnerEmail { get; set; }
        public object? CreationDate { get; set; }
        public object? ModifyDate { get; set; }
        public object? IsDeleted { get; set; }
        public object? CreatedByUserId { get; set; }
        public object? ModifiedByUserId { get; set; }
        public object? InternalNotes { get; set; }
        public object? OfficeLocation { get; set; }
        public object? MarketplaceId { get; set; }
        public object? BrokerId { get; set; }
    }
}
