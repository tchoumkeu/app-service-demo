namespace TodoApp.Web.Data;

public interface ITodoService
{
    void Add(TodoItem item);
    void Update(TodoItem item);
    void Delete(long id);
    void MarkComplete(long id);
    IEnumerable<TodoItem> GetAll();
}
