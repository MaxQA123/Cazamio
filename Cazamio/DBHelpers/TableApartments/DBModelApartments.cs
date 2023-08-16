using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.DBHelpers
{
    public class TableApartments
    {
        public class DBModelApartments
        {
            public object? Id { get; set; } // this might be another data type
            public object? ApartmentId { get; set; }
            public object? LeasePrice { get; set; }
            public object? DepositPrice { get; set; }
            public object? DateFrom { get; set; }
            public object? DateTo { get; set; }
            public object? CreationDate { get; set; }
            public object? ModifyDate { get; set; }
            public object? IsDeleted { get; set; }
            public object? PaidMonths { get; set; }
            public object? PaymentOfApartment { get; set; }
            public object? Amount { get; set; }
        }
    }
}