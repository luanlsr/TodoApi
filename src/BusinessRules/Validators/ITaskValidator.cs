using FluentValidation;
using TodoApi.src.BusinessRules.Requests;

namespace TodoApi.src.BusinessRules.Validators
{
    public interface ITaskValidator : IValidator<UpsertTaskRequest>
    {

    }
}
