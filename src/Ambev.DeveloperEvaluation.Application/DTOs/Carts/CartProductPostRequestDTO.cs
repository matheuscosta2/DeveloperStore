namespace Ambev.DeveloperEvaluation.Application.DTOs.Carts;

public record CartProductPostRequestDTO
{
    public int ProductId { get; init; }
    public int Quantity { get; init; }
}
