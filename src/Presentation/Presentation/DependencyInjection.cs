using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Presentation.Common.Validations;
using System.Reflection;

namespace Presentation
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetAssembly(typeof(DependencyInjection)));
            services.AddScoped<ICommonValidator, CommonValidator>();

            return services;
        }
    }
}