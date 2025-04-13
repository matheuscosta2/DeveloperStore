namespace Ambev.DeveloperEvaluation.Application.DTOs.Carts;

public record CartProductGetDetailResponseDTO
{
    public int ProductId { get; init; }
    public int Quantity { get; init; }
}
