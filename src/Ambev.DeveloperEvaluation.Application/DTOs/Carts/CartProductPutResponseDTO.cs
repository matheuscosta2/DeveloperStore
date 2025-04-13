namespace Ambev.DeveloperEvaluation.Application.DTOs.Carts;

public record CartProductPutResponseDTO
{
    public int ProductId { get; init; }
    public int Quantity { get; init; }
}
