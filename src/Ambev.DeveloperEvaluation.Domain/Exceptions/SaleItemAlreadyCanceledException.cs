using Ambev.DeveloperEvaluation.Domain.Base;

namespace Ambev.DeveloperEvaluation.Domain.Exceptions;

public class SaleItemAlreadyCanceledException : BaseException
{
    public SaleItemAlreadyCanceledException(string message) : base(message)
    {
    }
}
