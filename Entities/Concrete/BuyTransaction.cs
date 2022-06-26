using Core.Entities;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class BuyTransaction: IEntity
    {
        public int Id { get; set; }
        public int TransactionId { get; set; }
        public int CompanyCustomerID { get; set; }
        public virtual CompanyCustomer CompanyCustomer { get; set; }
    }
}
