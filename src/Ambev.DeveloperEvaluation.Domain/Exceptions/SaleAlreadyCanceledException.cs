using Ambev.DeveloperEvaluation.Domain.Base;

namespace Ambev.DeveloperEvaluation.Domain.Exceptions;

public class SaleAlreadyCanceledException : BaseException
{
    public SaleAlreadyCanceledException(string message) : base(message)
    {
    }
}
