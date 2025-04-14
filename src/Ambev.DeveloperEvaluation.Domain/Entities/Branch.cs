using Ambev.DeveloperEvaluation.Domain.Base;
using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Domain.Entities;
[ExcludeFromCodeCoverage]
public class Branch : BaseEntity
{
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public bool IsActive { get; set; }
}
