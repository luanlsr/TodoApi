using Microsoft.EntityFrameworkCore;
using TodoApi.src.Database.Domain;

namespace TodoApi.src.Database
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Todo> Tasks { get; set; }
    }
}
