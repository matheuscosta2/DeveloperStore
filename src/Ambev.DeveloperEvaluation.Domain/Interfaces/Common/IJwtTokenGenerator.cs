using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Interfaces.Common;

public interface IJwtTokenGenerator
{
    Task<string> GenerateTokenAsync(User user);
}
