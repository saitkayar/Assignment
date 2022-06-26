using Core.Entities;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class SaleTransaction : IEntity
    {
        public int Id { get; set; }
        public int TransactionId { get; set; }
        public int ReceiverId { get; set; }
        public int SellerId { get; set; }
        public virtual UserCustomer Receiver { get; set; }
        public virtual Person Seller { get; set; }

    }
}
