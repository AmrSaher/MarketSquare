namespace MarketSquare.API.Domain.Entities
{
    public class Address
    {
        public Guid Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Sreet { get; set; }
        public string BuildingNumber { get; set; }
        public int FloorNumber { get; set; }
        public int ApartmentNumber { get; set; }
        public string City { get; set; }
        public string Governorate { get; set; }
        public bool IsDefault { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public List<Order> Orders { get; set; }
    }
}
