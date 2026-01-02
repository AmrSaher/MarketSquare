using MarketSquare.API.Domain.Enums;

namespace MarketSquare.API.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public decimal TotalAmount { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Confirmed;
        public DateTime? DeliveredAt { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid AddressId { get; set; }
        public Address Address { get; set; }

        public List<SubOrder> SubOrders { get; set; }
    }
}
