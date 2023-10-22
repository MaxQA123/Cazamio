using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.DBHelpers.TableApplicationBasicInformation
{
    public class DBModelsApplicationBasicInformation
    {
        public long? Id { get; set; } // this might be another data type
        public object? ApartmentApplicationId { get; set; }
        public object? TenantId { get; set; }
    }
}
