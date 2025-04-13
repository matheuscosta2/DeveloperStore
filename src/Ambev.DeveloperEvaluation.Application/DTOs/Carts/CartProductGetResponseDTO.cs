namespace Ambev.DeveloperEvaluation.Application.DTOs.Carts;

public record CartProductGetResponseDTO
{
    public int ProductId { get; init; }
    public int Quantity { get; init; }
}
