using RealWorld.Api.Exceptions;
using RealWorld.Api.ViewModels;

namespace RealWorld.Api.Extensions;

public static class BusinessRuleViolationExceptionExtensions
{
    public static ErrorsResponseViewModel ToErrorsResponseViewModel(this BusinessRuleViolationException ex) =>
        new ErrorsResponseViewModel
        {
            Errors = new Dictionary<string, List<string>>
            {
                { ex.Member, new List<string> { ex.Error } }
            }
        };
}