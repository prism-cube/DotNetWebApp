using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using DotNetWebApp.Requests.Todo;
using DotNetWebApp.ViewModels.Todo;
using DotNetWebApp.Utils.Filters;

namespace DotNetWebApp.Controllers;

[AutoValidateAntiforgeryToken]
public class TodoController : Controller
{
    private readonly ILogger<TodoController> _logger;

    public TodoController(ILogger<TodoController> logger)
    {
        _logger = logger;
    }

    [ImportModelState]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [ExportModelState]
    public IActionResult Index(IndexRequest request)
    {
        if (!ModelState.IsValid)
        {
            return RedirectToAction(nameof(Index));
        }

        var viewModel = new IndexViewModel()
        {
            Name = request.Name,
        };
        return View(viewModel);
    }
}
