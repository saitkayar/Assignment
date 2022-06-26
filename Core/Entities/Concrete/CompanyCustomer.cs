namespace Core.Entities.Concrete
{
    public class CompanyCustomer: IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string TaxNumber { get; set; }

    }
}
