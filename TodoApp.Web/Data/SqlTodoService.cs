using Microsoft.EntityFrameworkCore;

namespace TodoApp.Web.Data;

public class SqlTodoService : ITodoService
{
    private readonly TodosDbContext _dbContext;

    public SqlTodoService(TodosDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(TodoItem item)
    {
        _dbContext.Add(item);
        _dbContext.SaveChanges();
    }

    public void Delete(long id)
    {
        var item = _dbContext.Todos.Find(id);
        if(item != null)
        {
            _dbContext.Remove(item);
            _dbContext.SaveChanges();
        }
    }

    public IEnumerable<TodoItem> GetAll()
    {
        return _dbContext.Todos.ToList();
    }

    public void MarkComplete(long id)
    {
        var item = _dbContext.Todos.Find(id);
        if (item != null)
        {
            item.Complete = true;
            _dbContext.SaveChanges();
        }
    }

    public void Update(TodoItem item)
    {
        _dbContext.Entry(item).State = EntityState.Modified;
        _dbContext.SaveChanges();
    }
}