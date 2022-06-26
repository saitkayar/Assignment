namespace Core.Entities.Concrete
{
    public class Address : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string AddressName { get; set; }
        public string AddressDetail { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
