using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.Objects
{
    public class PaymentOptions
    {
        public DeliverCheckNoteInfo DeliverCheckNote { get; set; }
        public ZelleInfo Zelle { get; set; }

        public class DeliverCheckNoteInfo
        {
            public string ForBuildingScreening { get; set; }
            public string ForBuildingHold { get; set; }
            public string ForApartment { get; set; }
        }

        public class ZelleInfo
        {
            public string ForBuildingScreening { get; set; }
            public string ForBuildingHold { get; set; }
            public string ForApartment { get; set; }
        }

        public PaymentOptions Generate()
        {
            string deliverCheckNoteForBuildingScreening = "Deliver check for Building screening (12345) (%$#@!) (09876)";
            string deliverCheckNoteForBuildingHold = "Deliver check for Building hold (12345) (%$#@!) (09876)";
            string deliverCheckNoteForApartment = "Deliver check for Apartment (12345) (%$#@!) (09876)";
            string forZelleBuildingScreening = "screening5building@xitroo.com 2128712345";
            string forZelleBuildingHold = "holdg7building@xitroo.com 5180987456";
            string zelleForApartment = "screening5apart@xitroo.com 5180987123";

            var paymentOptions = new PaymentOptions()
            {
                DeliverCheckNote = new DeliverCheckNoteInfo
                {
                    ForBuildingScreening = deliverCheckNoteForBuildingScreening,
                    ForBuildingHold = deliverCheckNoteForBuildingHold,
                    ForApartment = deliverCheckNoteForApartment
                },
                Zelle = new ZelleInfo
                {
                    ForBuildingScreening = forZelleBuildingScreening,
                    ForBuildingHold = forZelleBuildingHold,
                    ForApartment = zelleForApartment
                },
            };
            return paymentOptions;
        }
    }
}
