using Ambev.DeveloperEvaluation.Application.DTOs.Common;
using Microsoft.AspNetCore.Mvc;

namespace Ambev.DeveloperEvaluation.Application.DTOs.Carts;

public record CartGetResponseDTO
{
    public int Id { get; init; }
    public int UserId { get; init; }
    public DateTimeOffset Date { get; init; }
    public List<CartProductGetResponseDTO>? Products { get; init; }
}
