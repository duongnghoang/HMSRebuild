using System.Diagnostics.CodeAnalysis;

namespace Domain.Shared
{
    /// <summary>
    /// Result class for return data 
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Constructor for result: 
        /// + If success flag is true error should be none
        /// + If success flag is false error should be not none
        /// </summary>
        /// <param name="isSuccess"></param>
        /// <param name="error"></param>
        /// <exception cref="ArgumentException"></exception>
        protected internal Result(bool isSuccess, Error error)
        {
            if (isSuccess && error != Error.None ||
                !isSuccess && error == Error.None)
            {
                throw new ArgumentException("Invalid error", nameof(error));
            }

            IsSuccess = isSuccess;
            Error = error;
        }

        /// <summary>
        /// Is result success flag
        /// </summary>
        public bool IsSuccess { get; }

        /// <summary>
        /// Is result failure flag
        /// </summary>
        public bool IsFailure => !IsSuccess;

        /// <summary>
        /// Domain errors
        /// </summary>
        public Error Error { get; }

        public static Result Success() => new(true, Error.None);

        /// <summary>
        /// Success result with value
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Result<TValue> Success<TValue>(TValue value) => new(value, true, Error.None);

        /// <summary>
        /// Failure result with error
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        public static Result Failure(Error error) => new(false, error);

        public static Result<TValue> Failure<TValue>(Error error) => new(default, false, error);
    }

    public class Result<TValue> : Result
    {
        private readonly TValue? _value;

        protected internal Result(TValue? value, bool isSuccess, Error error)
            : base(isSuccess, error)
        {
            _value = value;
        }

        /// <summary>
        /// Value of result if success
        /// </summary>
        [NotNull]
        public TValue Value => IsSuccess
            ? _value!
            : throw new InvalidOperationException("The value of a failure result can't be accessed.");

        /// <summary>
        /// Convert value to result, if value is null return failure result
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator Result<TValue>(TValue? value) =>
            value is not null ? Success(value) : Failure<TValue>(Error.NullValue);
    }
}