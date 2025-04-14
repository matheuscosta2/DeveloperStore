using Ambev.DeveloperEvaluation.Api.v1.Configurations;
using Ambev.DeveloperEvaluation.Api.v1.Middlewares;
using Ambev.DeveloperEvaluation.Application.Configurations;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Interfaces.Repositories;
using Ambev.DeveloperEvaluation.Domain.Interfaces.Common;
using Serilog;
using System.Text.Json.Serialization;
using Ambev.DeveloperEvaluation.Domain.Enums;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddSwaggerConfig();

builder.Services.AddLoggingSerilog(new LoggerConfiguration());

builder.Services.AddLogging(c => c.ClearProviders());

builder.Services.AddCustomApiVersioning();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.ResolveDependencies();

builder.Services.AddAuthenticationConfiguration();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware(typeof(ExceptionMiddleware));

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

// Adicionando criação de usuário inicial
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var userRepository = services.GetRequiredService<IUserRepository>();
    var passwordHasher = services.GetRequiredService<IPasswordHasher>();

    var existingUser = await userRepository.GetActiveByEmailAsync("admin@admin.com");
    if (existingUser == null)
    {
        var adminUser = new User
        {
            Email = "admin@admin.com",
            Username = "admin",
            Password = passwordHasher.HashPassword("Admin@123"),
            Role = UserRole.Manager,
            Status = UserStatus.Active,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };

        await userRepository.AddAsync(adminUser);
    }
}

app.Run();