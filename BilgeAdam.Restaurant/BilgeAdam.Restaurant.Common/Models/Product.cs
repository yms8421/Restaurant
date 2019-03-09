using BilgeAdam.Restaurant.Common.Enums;
using System;

namespace BilgeAdam.Restaurant.Common.Models
{
    public class Product : ModelBase
    {
        public string Name { get; set; }
        public ProductType Type { get; set; }
    }
}