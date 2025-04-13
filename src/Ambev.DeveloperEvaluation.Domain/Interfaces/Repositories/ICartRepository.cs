using Ambev.DeveloperEvaluation.Domain.Base.Interfaces;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Interfaces.Repositories;

public interface ICartRepository : IBaseRepository<Cart>
{
    Task<Cart?> GetWithProductsByIdAsync(int id);
}
