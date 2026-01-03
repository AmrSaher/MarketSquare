namespace MarketSquare.API.Domain.Entities
{
    public class Vendor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LogoUrl { get; set; }
        public bool IsApproved { get; set; } = false;

        public Guid UserId { get; set; }
        public User User { get; set; }

        public List<Product> Products { get; set; }
        public List<SubOrder> Orders { get; set; }
    }
}
