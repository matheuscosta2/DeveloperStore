using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Interfaces.Repositories;
using Ambev.DeveloperEvaluation.Infrastructure.Contexts;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Infrastructure.Repositories;

[ExcludeFromCodeCoverage]
public class BranchRepository : BaseRepository<Branch>, IBranchRepository
{
    public BranchRepository(PostgreDbContext dbContext, ILogger<BranchRepository> logger) : base(dbContext, logger)
    {
    }
}
