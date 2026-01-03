namespace MarketSquare.API.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; } = 0;
        public double? Sale { get; set; }

        public Guid VendorId { get; set; }
        public Vendor Vendor { get; set; }

        public List<Category> Categories { get; set; }
        public List<ProductImage> Images { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}
