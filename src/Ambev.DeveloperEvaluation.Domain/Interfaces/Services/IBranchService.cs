using Ambev.DeveloperEvaluation.Domain.Base;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Interfaces.Services;

public interface IBranchService
{
    Task<PagedResult<Branch>> GetAllAsync(int? id = default, bool? isActive = default, string? name = default, DateTimeOffset? startDate = default, DateTimeOffset? endDate = default, int page = 1, int maxResults = 10, string? orderByClause = default);
    Task<Branch?> GetByIdAsync(int id);
    Task<Branch> CreateAsync(Branch request);
    Task<Branch> UpdateAsync(int id, Branch request);
    Task DeleteAsync(int id);
}
