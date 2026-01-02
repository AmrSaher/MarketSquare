namespace MarketSquare.API.Domain.Enums
{
    public enum SubOrderStatus
    {
        Pending = 1,              // Vendor notified but hasn’t accepted yet.
        Accepted = 2,             // Vendor accepted the order.
        Preparing = 3,            // Vendor is packing the product.
        ReadyToShip = 4,          // Waiting for courier pickup.
        Shipped = 5,              // Vendor shipped the product.
        Delivered = 6,            // Product delivered to customer.
        Cancelled = 7,            // Vendor cancelled their part.
        Returned = 8,             // Customer returned the item.
        Refunded = 9,             // Vendor refund processed.
    }
}
