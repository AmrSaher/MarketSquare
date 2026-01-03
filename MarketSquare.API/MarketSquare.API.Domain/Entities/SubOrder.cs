using MarketSquare.API.Domain.Enums;

namespace MarketSquare.API.Domain.Entities
{
    public class SubOrder
    {
        public Guid Id { get; set; }
        public decimal TotalAmount { get; set; }
        public SubOrderStatus Status { get; set; } = SubOrderStatus.Pending;
        public DateTime? DeliveredAt { get; set; }

        public Guid VendorId { get; set; }
        public Vendor Vendor { get; set; }

        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        public List<OrderItem> Items { get; set; }
    }
}
