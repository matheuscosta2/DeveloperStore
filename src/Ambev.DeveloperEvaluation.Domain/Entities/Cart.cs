using Ambev.DeveloperEvaluation.Domain.Base;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Cart : BaseEntity
{
    public int UserId { get; set; }
    public DateTimeOffset Date { get; set; }

    public virtual User? User { get; set; }
    public virtual List<CartProduct>? Products { get; set; }
}
