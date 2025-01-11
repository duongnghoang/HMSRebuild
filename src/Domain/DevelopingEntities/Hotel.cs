namespace Domain.DevelopingEntities
{
    public class Hotel
    {
        public int Id { get; private set; }

        public int HotelOwnerId { get; private set; }

        public string HotelName { get; private set; }

        public string Address { get; private set; }

        public string District { get; private set; }

        public string Province { get; private set; }
        
        public string Country { get; private set; }

        public string PostalCode { get; private set; }

        public string ContactNumber { get; private set; }

        public string ContactEmail { get; private set; }

        public string Website { get; private set; }

        public string? Note { get; private set; }
    }
}