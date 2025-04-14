using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Interfaces.Repositories;
using Ambev.DeveloperEvaluation.Infrastructure.Contexts;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Infrastructure.Repositories;

[ExcludeFromCodeCoverage]
public class ProductRepository : BaseRepository<Product>, IProductRepository
{
    public ProductRepository(PostgreDbContext dbContext, ILogger<ProductRepository> logger) : base(dbContext, logger)
    {
    }
}
