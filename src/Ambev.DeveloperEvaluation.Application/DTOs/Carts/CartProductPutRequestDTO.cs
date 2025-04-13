namespace Ambev.DeveloperEvaluation.Application.DTOs.Carts;

public record CartProductPutRequestDTO
{
    public int ProductId { get; init; }
    public int Quantity { get; init; }
}
