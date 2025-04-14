using Ambev.DeveloperEvaluation.Domain.Base;
using Ambev.DeveloperEvaluation.Domain.Base.Interfaces;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Reflection;

namespace Ambev.DeveloperEvaluation.Infrastructure.Contexts;

[ExcludeFromCodeCoverage]
public class PostgreDbContext : DbContext
{
    public PostgreDbContext(DbContextOptions<PostgreDbContext> options) : base(options)
    {
        base.Database.EnsureCreated();
    }

    public DbSet<Branch> Branches { get; set; }
    public DbSet<BranchProduct> BranchProducts { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<SaleItem> SaleItems { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartProduct> CartProducts { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        EnsureIsNotDeletedFilter(builder);

        foreach (var entityType in builder.Model.GetEntityTypes())
        {
            var clrType = entityType.ClrType;
            if (typeof(IBaseEntity).IsAssignableFrom(clrType))
            {
                builder.Entity(clrType).HasKey(nameof(BaseEntity.Id));
            }
        }

        builder.Entity<User>()
    .OwnsOne(u => u.Name);
        builder.Entity<User>()
            .OwnsOne(u => u.Address, a =>
            {
                a.OwnsOne(ad => ad.Geolocation);
            });

        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }

    private void EnsureIsNotDeletedFilter(ModelBuilder builder)
    {
        foreach (var entityType in builder.Model.GetEntityTypes())
        {
            if (typeof(IBaseEntity).IsAssignableFrom(entityType.ClrType))
            {
                var parameter = Expression.Parameter(entityType.ClrType, "e");
                var property = Expression.Property(parameter, nameof(IBaseEntity.IsDeleted));
                var body = Expression.Not(property);
                var lambda = Expression.Lambda(body, parameter);

                builder.Entity(entityType.ClrType).HasQueryFilter(lambda);
            }
        }
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        ConfigureTimestamps();
        return await base.SaveChangesAsync(cancellationToken);
    }

    public override int SaveChanges()
    {
        ConfigureTimestamps();
        return base.SaveChanges();
    }

    private void ConfigureTimestamps()
    {
        var entries = ChangeTracker.Entries<IBaseEntity>();

        foreach (var entry in entries)
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedAt = DateTime.UtcNow;
                entry.Entity.UpdatedAt = DateTime.UtcNow;
            }
            else if (entry.State == EntityState.Modified)
                entry.Entity.UpdatedAt = DateTime.UtcNow;
        }
    }
}
