namespace TodoApp.Web.Data;

public interface ITodoService
{
    void Add(TodoItem item);
    void Update(TodoItem item);
    void Delete(Guid id);
    void MarkComplete(Guid id);
    IEnumerable<TodoItem> GetAll();
}
