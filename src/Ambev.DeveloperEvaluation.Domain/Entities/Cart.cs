using Ambev.DeveloperEvaluation.Domain.Base;
using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

[ExcludeFromCodeCoverage]
public class Cart : BaseEntity
{
    public int UserId { get; set; }
    public DateTimeOffset Date { get; set; }

    public virtual User? User { get; set; }
    public virtual List<CartProduct>? Products { get; set; }
}
