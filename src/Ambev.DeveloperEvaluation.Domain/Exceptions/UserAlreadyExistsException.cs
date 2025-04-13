namespace Ambev.DeveloperEvaluation.Domain.Exceptions;

public class UserAlreadyExistsException : BaseException
{
    public UserAlreadyExistsException(string message) : base(message)
    {
    }
}
