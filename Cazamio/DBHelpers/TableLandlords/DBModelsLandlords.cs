using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.DBHelpers.TableLandlords
{
    public class DBModelsLandlords
    {
        public object? Id { get; set; } // this might be another data type
        public object? UserId { get; set; }
        public object? CreationDate { get; set; }
        public object? ModifyDate { get; set; }
        public object? IsDeleted { get; set; }
        public object? IsBanned { get; set; }
        public object? MarketplaceId { get; set; }
        public object? AccountOwner { get; set; }
    }
}
