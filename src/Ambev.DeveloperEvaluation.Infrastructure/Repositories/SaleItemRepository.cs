using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Interfaces.Repositories;
using Ambev.DeveloperEvaluation.Infrastructure.Contexts;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Infrastructure.Repositories;

[ExcludeFromCodeCoverage]
public class SaleItemRepository : BaseRepository<SaleItem>, ISaleItemRepository
{
    public SaleItemRepository(PostgreDbContext dbContext, ILogger<SaleItemRepository> logger) : base(dbContext, logger)
    {
    }
}
