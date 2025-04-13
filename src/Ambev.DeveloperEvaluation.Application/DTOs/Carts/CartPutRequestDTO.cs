namespace Ambev.DeveloperEvaluation.Application.DTOs.Carts;

public record CartPutRequestDTO
{
    public int Id { get; init; }
    public int UserId { get; init; }
    public DateTimeOffset Date { get; init; }
    public List<CartProductPutRequestDTO>? Products { get; init; }
}
