using Ambev.DeveloperEvaluation.Domain.Base.Interfaces;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Interfaces.Repositories;

public interface ISaleRepository : IBaseRepository<Sale>
{
    Task<Sale?> GetWithItemsByIdAsync(int id);
}
