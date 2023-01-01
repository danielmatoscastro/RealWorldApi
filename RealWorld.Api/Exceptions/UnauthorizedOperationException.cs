namespace RealWorld.Api.Exceptions;

public class UnauthorizedOperationException : Exception
{
    public UnauthorizedOperationException(string operation) : base($"User is not authorized to do {operation}")
    {
        
    }
}