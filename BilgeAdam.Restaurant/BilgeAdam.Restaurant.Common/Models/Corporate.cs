using System;
using System.Collections.Generic;

namespace BilgeAdam.Restaurant.Common.Models
{
    public class Corporate : ModelBase
    {
        public Corporate(string title)
        {
            Title = title; //ReadOnly property'ler "sadece ve sadece" constructor'da set edilebilir
        }
        public string Title { get; }
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Reservation> Reservations { get; set; }
        public IEnumerable<Table> Tables { get; set; }
        public IEnumerable<Product> Menu { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
