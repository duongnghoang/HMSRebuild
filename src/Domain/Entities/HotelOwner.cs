namespace Domain.Entities
{
    public class HotelOwner
    {
        /// <summary>
        /// Unique identifier of the hotel owner
        /// </summary>
        public long Id { get; private set; }

        /// <summary>
        /// Owner's first name
        /// </summary>
        public string FirstName { get; private set; }

        /// <summary>
        /// Owner's last name
        /// </summary>
        public string LastName { get; private set; }

        /// <summary>
        /// Date of birth
        /// </summary>
        public DateTime DateOfBirth { get; private set; }

        /// <summary>
        /// Identity number
        /// </summary>
        public string IdentityNumber { get; private set; }

        /// <summary>
        /// Email address
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// Phone number
        /// </summary>
        public string PhoneNumber { get; private set; }

        /// <summary>
        /// Address
        /// </summary>
        public string Address { get; private set; }

        /// <summary>
        /// Country
        /// </summary>
        public string Country { get; private set; }

        /// <summary>
        /// Tax identification number
        /// </summary>
        public string TaxIdentificationNumber { get; private set; }

        /// <summary>
        /// Additional note if needed
        /// </summary>
        public string? Note { get; private set; }

        /// <summary>
        /// Avatar logo
        /// </summary>
        public string? Logo { get; private set; }

        /// <summary>
        /// Identifier if the owner is active or not
        /// </summary>
        public bool IsActive { get; private set; }
    }
}