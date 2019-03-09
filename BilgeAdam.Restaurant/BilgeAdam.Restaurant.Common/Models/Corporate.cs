using System;
using System.Collections.Generic;

namespace BilgeAdam.Restaurant.Common.Models
{
    public class Corporate : ModelBase
    {
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Reservation> Reservations { get; set; }
        public IEnumerable<Table> Tables { get; set; }
        public IEnumerable<Product> Menu { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
