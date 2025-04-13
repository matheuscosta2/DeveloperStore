using Ambev.DeveloperEvaluation.Domain.Base;

namespace Ambev.DeveloperEvaluation.Domain.Exceptions;

public class InvalidPaginationParametersException : BaseException
{
    public InvalidPaginationParametersException(string message) : base(message)
    {
    }
}
