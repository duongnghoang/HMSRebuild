using FluentValidation.Results;

namespace Presentation.Common.Validations
{
    public interface ICommonValidator
    {
        Task<ValidationResult> ValidateAsync<T>(T instance);
    }
}