using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rent_and_Booking_System.Models
{
    internal class Rental
    {
        public int Id { get; set; }
        public int VehicleNo { get; set; }
        public string PickupBranch { get; set; } = string.Empty;
        public string PickupDate { get; set; } = string.Empty;
        public string ReturnDate { get; set; } = string.Empty;
    }
}
