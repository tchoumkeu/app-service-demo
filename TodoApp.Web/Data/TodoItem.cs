namespace TodoApp.Web.Data;

public class TodoItem
{
    public long Id { get; set; }
    public string? Title { get; set; }
    public bool Complete { get; set; }
}
