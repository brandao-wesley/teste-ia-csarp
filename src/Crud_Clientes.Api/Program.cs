using Crud_Clientes.Application.Customers;
using Crud_Clientes.Infrastructure;
using Crud_Clientes.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options => options.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<CustomerService>();
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();
app.UseCors();
app.UseSwagger();
app.UseSwaggerUI();
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    await db.Database.EnsureCreatedAsync();
}
app.MapControllers();
app.MapGet("/health", () => Results.Ok(new { status = "ok", app = "Crud_Clientes" }));
app.Run();

public partial class Program { }
