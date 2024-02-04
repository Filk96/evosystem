using UM.Application.IService;
using UM.Application.Service;
using UM.Domain.IEntity;
using Microsoft.Extensions.DependencyInjection;

namespace UM.Application.Dependency
{
    public static class ServiceResolutionConfiguration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICurrentUser, CurrentUser>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IEmployeeService, EmployeeService>();

            return services;
        }
    }
}
