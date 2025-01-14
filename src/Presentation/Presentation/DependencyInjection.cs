using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using FluentValidation;
using Presentation.Common.Validations;

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