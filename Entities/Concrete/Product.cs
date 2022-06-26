using Core.Entities;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int UnitTypeId { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual Category Category { get; set; }
        public virtual UnitType UnitType { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
