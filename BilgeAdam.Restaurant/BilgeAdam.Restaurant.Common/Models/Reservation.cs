using System;

namespace BilgeAdam.Restaurant.Common.Models
{
    public class Reservation : ModelBase
    {
        public Client Client { get; set; }
        public Table Table { get; set; }
        public DateTime ReservationDate { get; set; }
    }
}
