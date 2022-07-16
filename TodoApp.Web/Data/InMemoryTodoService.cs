namespace TodoApp.Web.Data;

public class InMemoryTodoService : ITodoService
{
    private readonly Dictionary<Guid, TodoItem> _todos;

    public InMemoryTodoService()
    {
        _todos = new();
    }

    public void Add(TodoItem item)
    {
        item.Id = Guid.NewGuid();

        _todos.Add(item.Id, item);
    }

    public void Delete(Guid id)
    {
        if(_todos.ContainsKey(id))
        {
            _todos.Remove(id);
        }
    }

    public IEnumerable<TodoItem> GetAll()
    {
        return _todos.Values;
    }

    public void MarkComplete(Guid id)
    {
        if (_todos.ContainsKey(id))
        {
            var todo = _todos[id];
            todo.Complete = true;
        }
    }

    public void Update(TodoItem item)
    {
        _todos[item.Id] = item;
    }
}
