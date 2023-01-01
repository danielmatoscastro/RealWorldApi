namespace RealWorld.Api.Exceptions;

public class ForbiddenOperation : Exception
{
    public ForbiddenOperation(string operation) : base($"{operation} is forbidden.")
    {
        
    }
}