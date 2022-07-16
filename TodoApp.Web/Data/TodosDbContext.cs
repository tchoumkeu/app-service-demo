using Microsoft.EntityFrameworkCore;

namespace TodoApp.Web.Data;

public class TodosDbContext : DbContext
{
    public TodosDbContext(DbContextOptions<TodosDbContext> options) : base(options)
    {
    }

    public DbSet<TodoItem> Todos { get; set; }
}
