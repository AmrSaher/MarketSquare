namespace MarketSquare.API.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public Guid? VendorId { get; set; }
        public Vendor Vendor { get; set; }

        public Guid CartId { get; set; }
        public Cart Cart { get; set; }

        public List<Address> Addresses { get; set; }
        public List<Order> Orders { get; set; }
    }
}
