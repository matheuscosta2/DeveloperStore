using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Interfaces.Repositories;
using Ambev.DeveloperEvaluation.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Infrastructure.Repositories;

[ExcludeFromCodeCoverage]
public class SaleRepository : BaseRepository<Sale>, ISaleRepository
{
    public SaleRepository(PostgreDbContext dbContext, ILogger<SaleRepository> logger) : base(dbContext, logger)
    {
    }

    public async Task<Sale?> GetWithItemsByIdAsync(int id)
        => await _dbContext.Sales.Include(s => s.Items)
                                 .FirstOrDefaultAsync(s => s.Id == id);
}
