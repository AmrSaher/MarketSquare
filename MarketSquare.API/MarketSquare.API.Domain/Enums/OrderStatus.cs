namespace MarketSquare.API.Domain.Enums
{
    public enum OrderStatus
    {
        Confirmed = 1,                // Payment successful.
        Processing = 2,               // At least one vendor is preparing items.
        PartiallyShipped = 3,         // Some vendors shipped their items, others didn’t yet.
        Shipped = 4,                  // All vendors shipped their items.
        Delivered = 5,                // Customer received all items.
        Completed = 6,                // Delivery confirmed + return period ended.
        Cancelled = 7,                // Order cancelled before shipping.
        Refunded = 8,                 // Money returned to the customer.
    }
}
