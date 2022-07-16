using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Todo.Web.Models;
using TodoApp.Web.Data;

namespace Todo.Web.Controllers;

public class TodosController : Controller
{
    private readonly ITodoService _todoService;
    private readonly ILogger<TodosController> _logger;

    public TodosController(ILogger<TodosController> logger, ITodoService todoService)
    {
        _logger = logger;
        _todoService = todoService;
    }

    public IActionResult Index()
    {
        return View(_todoService.GetAll());
    }

    public IActionResult Create(TodoItem item)
    {
        _todoService.Add(item);

        return RedirectToAction(nameof(Index));
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
