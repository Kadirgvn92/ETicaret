using ETicaret.Application.Repositories;
using ETicaret.Persistance.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaret.Persistance;
public static class ServiceRegistration
{
    public static void AddPersistanceServices(this IServiceCollection services)
    {
        services.AddSingleton<ICustomerReadRepository, CustomerReadRepository>();
        services.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();
        services.AddSingleton<IOrderReadRepository, OrderReadRepository>();
        services.AddSingleton<IOrderWriteRepository, OrderWriteRepository>();
        services.AddSingleton<IProductReadRepository, ProductReadRepository>();
        services.AddSingleton<IProductWriteRepository, ProductWriteRepository>();
    }
}
