using System.Security.Cryptography;

namespace Domain.Utilities
{
    public static class PasswordHasher
    {
        private const int SaltSize = 16; // 128 bits
        private const int KeySize = 32; // 256 bits
        private const int Iterations = 10000; // Number of iterations for PBKDF2

        public static (byte[] Hash, byte[] Salt) HashPassword(string password)
        {
            using var algorithm = new Rfc2898DeriveBytes(
                password,
                SaltSize,
                Iterations,
                HashAlgorithmName.SHA256);

            var hash = algorithm.GetBytes(KeySize);
            var salt = algorithm.Salt;

            return (hash, salt);
        }

        public static bool VerifyPassword(string password, byte[] storedHash, byte[] storedSalt)
        {
            using var algorithm = new Rfc2898DeriveBytes(
                password,
                storedSalt,
                Iterations,
                HashAlgorithmName.SHA256);

            var hashToCompare = algorithm.GetBytes(KeySize);

            return CryptographicOperations.FixedTimeEquals(hashToCompare, storedHash);
        }
    }
}