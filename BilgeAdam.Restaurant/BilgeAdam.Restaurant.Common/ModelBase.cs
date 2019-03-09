using BilgeAdam.Restaurant.Common.Helper;
using System;

namespace BilgeAdam.Restaurant.Common
{
    public abstract class ModelBase
    {
        public ModelBase()
        {
            Id = EnumerateManager.Generate();
            CreatedDate = DateTime.Now;
        }
        public int Id { get; private set; }
        public DateTime CreatedDate { get; private set; }
    }
}
