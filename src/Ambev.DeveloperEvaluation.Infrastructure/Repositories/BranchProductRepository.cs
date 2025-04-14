using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Interfaces.Repositories;
using Ambev.DeveloperEvaluation.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Infrastructure.Repositories;

[ExcludeFromCodeCoverage]
public class BranchProductRepository : BaseRepository<BranchProduct>, IBranchProductRepository
{
    public BranchProductRepository(PostgreDbContext dbContext, ILogger<BranchProductRepository> logger) : base(dbContext, logger)
    {
    }

    public async Task UpdateByProductIdAsync(int productId, string productName, ProductCategory productCategory)
    {
        var branchProducts = await _dbContext.BranchProducts
                                             .Where(bp => bp.ProductId == productId)
                                             .ToListAsync();

        foreach (var branchProduct in branchProducts)
        {
            branchProduct.ProductTitle = productName;
            branchProduct.ProductCategory = productCategory;
        }

        await _dbContext.SaveChangesAsync();
    }
}
