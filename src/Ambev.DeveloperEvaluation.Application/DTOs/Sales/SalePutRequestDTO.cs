using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.DTOs.Sales;

public record SalePutRequestDTO
{
    public int Id { get; init; }
    public SaleStatus Status { get; init; }
    public DateTimeOffset Date { get; init; }
    public int UserId { get; init; }
    public int BranchId { get; init; }
    public decimal TotalAmount { get; init; }
    public DateTimeOffset? CancelledAt { get; init; }
}
