using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Crud_Clientes.Application.Customers;
using Crud_Clientes.Infrastructure.Persistence;
using Crud_Clientes.Infrastructure.Repositories;

namespace Crud_Clientes.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connection = configuration.GetConnectionString("DefaultConnection") ?? "Data Source=fabulosoft-app.db";
        services.AddDbContext<AppDbContext>(options => options.UseSqlite(connection));
        services.AddScoped<ICustomerRepository, EfCustomerRepository>();
        return services;
    }
}
