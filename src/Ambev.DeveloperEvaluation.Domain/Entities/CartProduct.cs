using Ambev.DeveloperEvaluation.Domain.Base;
using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

[ExcludeFromCodeCoverage]
public class CartProduct : BaseEntity
{
    public int CartId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }

    public virtual Cart? Cart { get; set; }
    public virtual Product? Product { get; set; }
}
