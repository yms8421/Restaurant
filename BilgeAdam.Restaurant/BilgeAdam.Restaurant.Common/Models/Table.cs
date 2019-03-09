using BilgeAdam.Restaurant.Common.Enums;
using System.Collections.Generic;

namespace BilgeAdam.Restaurant.Common.Models
{
    public class Table : ModelBase
    {
        public int Capacity { get; set; }
        public string Label { get; set; }
        public TableType Type { get; set; }
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
