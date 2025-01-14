using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Presentation.Common.Validations
{
    public class CommonValidator : ICommonValidator
    {
        private readonly IServiceProvider _serviceProvider;

        public CommonValidator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Validate<T>(T instance)
        {
            // Resolve the FluentValidation validator for the type
            var validator = _serviceProvider.GetService<IValidator<T>>();
            if (validator == null)
            {
                throw new InvalidOperationException($"No FluentValidation validator found for type {typeof(T).Name}");
            }

            // Execute FluentValidation
            var result = validator.Validate(instance);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}