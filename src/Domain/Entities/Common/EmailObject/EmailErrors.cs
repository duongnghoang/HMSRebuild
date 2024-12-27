using Domain.Shared;

namespace Domain.Entities.Common.EmailObject
{
    public class EmailErrors
    {
        public static readonly Error Empty = new(
            "Email.Empty",
            "Email cannot be empty");

        public static readonly Error TooLong = new(
            "Email.TooLong",
            "Email is too long");

        public static readonly Error InvalidFormat = new(
            "Email.InvalidFormat",
            "Invalid email format");
    }
}