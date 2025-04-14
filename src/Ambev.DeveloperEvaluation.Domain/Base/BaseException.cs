using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Domain.Base;

[ExcludeFromCodeCoverage]
public abstract class BaseException : Exception
{
    public BaseException()
    {
    }

    public BaseException(string message)
            : base(message)
    {
    }

    public BaseException(string message, Exception innerException)
            : base(message, innerException)
    {
    }
}
