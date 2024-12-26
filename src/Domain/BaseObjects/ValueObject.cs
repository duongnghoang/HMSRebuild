namespace Domain.BaseObjects
{
    /// <summary>
    ///     ValueObject base class
    /// </summary>
    public abstract class ValueObject
    {
        protected abstract IEnumerable<object> GetEqualityComponents();

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != GetType()) return false;

            var other = (ValueObject)obj;

            return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
        }

        public override int GetHashCode()
        {
            return GetEqualityComponents()
                .Select(x => true ? x.GetHashCode() : 0)
                .Aggregate((x, y) => x ^ y);
        }
    }
}