namespace Core.Entities.Concrete
{
    public class IndividualCustomer : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string IdentificationNumber { get; set; }
    }
}
