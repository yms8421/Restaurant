using System.Collections.Generic;

namespace BilgeAdam.Restaurant.Common.Models
{
    public class Order : ModelBase
    {
        public IEnumerable<Product> Products { get; set; }
        public Client Client { get; set; }
    }
}
