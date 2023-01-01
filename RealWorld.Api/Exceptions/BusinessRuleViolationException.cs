namespace RealWorld.Api.Exceptions;

public class BusinessRuleViolationException : Exception
{
    public string Member { get; private set; }
    public string Error { get; private set; }
    public BusinessRuleViolationException(string member, string error) : base($"Error at {member}: {error}")
    {
        Member = member;
        Error = error;
    }
}