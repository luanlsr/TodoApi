using TodoApi.src.Database.Domain;

namespace TodoApi.src.DataBase.Repositories
{
    public interface ITaskRepository
    {
        IQueryable<Todo> GetAll();
        Todo GetById(Guid id);
        Todo Save(Todo entity);

    }
}
