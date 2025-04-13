using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Interfaces.Repositories;
using Ambev.DeveloperEvaluation.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Infrastructure.Repositories;

[ExcludeFromCodeCoverage]
public class CartRepository : BaseRepository<Cart>, ICartRepository
{
    public CartRepository(PostgreDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<Cart?> GetWithProductsByIdAsync(int id)
        => await _dbContext.Carts.Include(s => s.Products)
                                 .FirstOrDefaultAsync(s => s.Id == id);
}
