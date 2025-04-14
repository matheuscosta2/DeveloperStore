using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Interfaces.Repositories;
using Ambev.DeveloperEvaluation.Infrastructure.Contexts;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Infrastructure.Repositories;

[ExcludeFromCodeCoverage]
public class CartProductRepository : BaseRepository<CartProduct>, ICartProductRepository
{
    public CartProductRepository(PostgreDbContext dbContext, ILogger<CartProductRepository> logger) : base(dbContext, logger)
    {
    }
}
