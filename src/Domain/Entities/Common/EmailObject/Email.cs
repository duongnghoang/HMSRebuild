using Domain.BaseObjects;
using Domain.Shared;
using System.Text.RegularExpressions;

namespace Domain.Entities.Common.EmailObject
{
    public class Email : ValueObject
    {
        public string Value { get; }

        private Email(string value)
        {
            Value = value;
        }

        public static Result<Email?> Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return Result.Failure<Email>(EmailErrors.Empty);
            }

            if (value.Length > 150)
            {
                return Result.Failure<Email>(EmailErrors.TooLong);
            }

            if (!IsValidEmail(value))
            {
                return Result.Failure<Email>(EmailErrors.InvalidFormat);
            }

            return Result.Success(new Email(value.ToLowerInvariant()))!;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        private static bool IsValidEmail(string email)
        {
            var emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailRegex, RegexOptions.Compiled);
        }
    }
}