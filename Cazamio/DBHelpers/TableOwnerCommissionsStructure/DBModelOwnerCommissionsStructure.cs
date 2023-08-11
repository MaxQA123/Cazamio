using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.DBHelpers.TableOwnerCommissionsStructure
{
    public class DBModelOwnerCommissionsStructure
    {
        public object? OwnerId { get; set; } // this might be another data type
        public object? PayType { get; set; }
        public object? TenantNumberOfMonths { get; set; }
        public object? OwnerPercentage { get; set; }
        public object? TenantPercentage { get; set; }
        public object? CreationDate { get; set; }
        public object? ModifyDate { get; set; }
        public object? IsDeleted { get; set; }
        public object? TakeOff { get; set; }
        public object? OwnerNumberOfMonths { get; set; }
    }
}
