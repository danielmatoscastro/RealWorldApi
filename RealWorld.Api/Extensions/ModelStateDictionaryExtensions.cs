using Microsoft.AspNetCore.Mvc.ModelBinding;
using RealWorld.Api.ViewModels;

namespace RealWorld.Api.Extensions;

public static class ModelStateDictionaryExtensions
{
    public static ErrorsResponseViewModel ToErrorsResponseViewModel(this ModelStateDictionary modelState) =>
        new ErrorsResponseViewModel
        {
            Errors = modelState.ToDictionary(
                entry => entry.Key,
                pair => pair.Value.Errors.Select(err => err.ErrorMessage).ToList()
            )
        };
}