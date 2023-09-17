using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.DBHelpers.TableOwnerPhoneNumbers
{
    public class DBModelsOwnerPhoneNumbers
    {
        public object? Id { get; set; } // this might be another data type
        public object? OwnerId { get; set; }
        public object? PhoneNumber { get; set; }
        public object? Extension { get; set; }
        public object? CreationDate { get; set; }
        public object? ModifyDate { get; set; }
        public object? IsDeleted { get; set; }
    }
}
