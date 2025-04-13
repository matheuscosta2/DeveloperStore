using Ambev.DeveloperEvaluation.Domain.Base.Interfaces;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Domain.Interfaces.Repositories;

public interface IBranchProductRepository : IBaseRepository<BranchProduct>
{
    Task UpdateByProductIdAsync(int productId, string productName, ProductCategory productCategory);
}
