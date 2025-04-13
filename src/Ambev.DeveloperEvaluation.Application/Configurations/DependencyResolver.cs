using Ambev.DeveloperEvaluation.Application.Commands.Auth;
using Ambev.DeveloperEvaluation.Application.Commands.Users;
using Ambev.DeveloperEvaluation.Application.Common.Security;
using Ambev.DeveloperEvaluation.Application.Mappers.Branches;
using Ambev.DeveloperEvaluation.Application.Mappers.BranchProducts;
using Ambev.DeveloperEvaluation.Application.Mappers.Carts;
using Ambev.DeveloperEvaluation.Application.Mappers.Products;
using Ambev.DeveloperEvaluation.Application.Mappers.Sales;
using Ambev.DeveloperEvaluation.Application.Mappers.Users;
using Ambev.DeveloperEvaluation.Application.Services;
using Ambev.DeveloperEvaluation.Application.Validators.Auth;
using Ambev.DeveloperEvaluation.Application.Validators.Users;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Interfaces.Common;
using Ambev.DeveloperEvaluation.Domain.Interfaces.Intergrations;
using Ambev.DeveloperEvaluation.Domain.Interfaces.Repositories;
using Ambev.DeveloperEvaluation.Domain.Interfaces.Services;
using Ambev.DeveloperEvaluation.Domain.Validators;
using Ambev.DeveloperEvaluation.Infrastructure.Contexts;
using Ambev.DeveloperEvaluation.Infrastructure.Integrations;
using Ambev.DeveloperEvaluation.Infrastructure.Repositories;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Ambev.DeveloperEvaluation.Application.Configurations;

[ExcludeFromCodeCoverage]
public static class DependencyResolver
{
    public static IServiceCollection ResolveDependencies(this IServiceCollection services)
    {
        services.ResolveAutoMapper();
        services.ResolveFluentValidators();
        services.ResolveRepositories();
        services.ResolveServices();
        services.ResolveMediatR();
        services.ResolveCommons();

        services.AddSingleton<IRabbitMQIntegration, RabbitMQIntegration>();

        return services;
    }

    private static void ResolveRepositories(this IServiceCollection services)
    {
        services.AddDbContext<PostgreDbContext>(options =>
            options.UseNpgsql(Environment.GetEnvironmentVariable("POSTGRES_CONNECTION_STRING"), npgsqlOptions =>
                npgsqlOptions.CommandTimeout(180))
            .EnableSensitiveDataLogging(true));

        services.AddScoped<IBranchRepository, BranchRepository>();
        services.AddScoped<IBranchProductRepository, BranchProductRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<ISaleRepository, SaleRepository>();
        services.AddScoped<ISaleItemRepository, SaleItemRepository>();
        services.AddScoped<ICartRepository, CartRepository>();
        services.AddScoped<ICartProductRepository, CartProductRepository>();
    }

    private static void ResolveServices(this IServiceCollection services)
    {
        services.AddScoped<IBranchService, BranchService>();
        services.AddScoped<IBranchProductService, BranchProductService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<ISaleService, SaleService>();
        services.AddScoped<ICartService, CartService>();
    }

    private static void ResolveAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(BranchMapperProfile));
        services.AddAutoMapper(typeof(ProductMapperProfile));
        services.AddAutoMapper(typeof(BranchProductMapperProfile));
        services.AddAutoMapper(typeof(SaleMapperProfile));
        services.AddAutoMapper(typeof(CartMapperProfile));
        services.AddAutoMapper(typeof(UserProfile));
    }

    private static void ResolveFluentValidators(this IServiceCollection services)
    {
        services.AddScoped<IValidator<Branch>, BranchValidator>();
        services.AddScoped<IValidator<BranchProduct>, BranchProductValidator>();
        services.AddScoped<IValidator<Product>, ProductValidator>();
        services.AddScoped<IValidator<ProductRating>, ProductRatingValidator>();
        services.AddScoped<IValidator<Sale>, SaleValidator>();
        services.AddScoped<IValidator<SaleItem>, SaleItemValidator>();
        services.AddScoped<IValidator<Cart>, CartValidator>();
        services.AddScoped<IValidator<CartProduct>, CartProductValidator>();

        #region Users
        services.AddScoped<IValidator<User>, UserValidator>();
        services.AddScoped<IValidator<CreateUserCommand>, CreateUserCommandValidator>();
        services.AddScoped<IValidator<GetUserCommand>, GetUserCommandValidator>();
        services.AddScoped<IValidator<DeleteUserCommand>, DeleteUserCommandValidator>();
        services.AddScoped<IValidator<AuthenticateUserCommand>, AuthenticateUserCommandValidator>();
        #endregion
    }
    private static void ResolveCommons(this IServiceCollection services)
    {
        services.AddScoped<IPasswordHasher, BCryptPasswordHasher>();
        services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
    }

    private static void ResolveMediatR(this IServiceCollection services)
     => services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
}