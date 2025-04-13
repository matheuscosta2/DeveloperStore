using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Interfaces.Repositories;
using Ambev.DeveloperEvaluation.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Infrastructure.Repositories;

[ExcludeFromCodeCoverage]
public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(PostgreDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<User?> GetActiveByEmailAsync(string email)
        => await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email &&
                                                           u.Status == UserStatus.Active);
}
