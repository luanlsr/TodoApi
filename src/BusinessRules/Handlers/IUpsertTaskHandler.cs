using TodoApi.src.BusinessRules.Requests;
using TodoApi.src.BusinessRules.Responses;

namespace TodoApi.src.BusinessRules.Handlers
{
    public interface IUpsertTaskHandler
    {
        UpsertTaskResponse Execute(UpsertTaskRequest request);
    }
}
