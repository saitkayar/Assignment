using Core.Entities;

namespace Entities.Concrete
{
    public class ProductTransaction : IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string UnitTypeName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Tax { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual Product Product { get; set; }
        public virtual UnitType UnitType { get; set; }
    }
}
