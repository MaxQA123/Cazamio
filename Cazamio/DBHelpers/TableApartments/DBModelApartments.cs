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
            public object? LandlordId { get; set; } // this might be another data type
            public object? BuildingId { get; set; }
            public object? Unit { get; set; }
            public object? BrokerFeeRequired { get; set; }
            public object? BedroomQuantity { get; set; }
            public object? SquareFeet { get; set; }
            public object? BathroomQuantity { get; set; }
            public object? Description { get; set; }
            public object? DaysListed { get; set; }
            public object? PaidMonths { get; set; }
            public object? AvailableFrom { get; set; }
            public object? NumberOfViews { get; set; }
            public object? CreationDate { get; set; }
            public object? ModifyDate { get; set; }
            public object? IsDeleted { get; set; }
            public object? Status { get; set; }
            public object? TemplateId { get; set; }
            public object? LeaseDuration { get; set; }
            public object? ClosedDateToNotify { get; set; }
            public object? Floor { get; set; }
            public object? MarketplaceId { get; set; }
            public object? AvailableFromUtc { get; set; }
            public object? OwnerId { get; set; }
        }

        public class DBModelApartmentsCombinedOwners
        {
            public object? OwnerId { get; set; } // this might be another data type
            public object? OwnerName { get; set; }
            public object? CompanyName { get; set; }
        }

        public class DBModelApartmentsCombinedPrices
        {
            public object? PayType { get; set; } // this might be another data type
            public object? TenantNumberOfMonths { get; set; }
            public object? TakeOff { get; set; }
            public object? AvailableForCommission { get; set; }
        }
    }
}