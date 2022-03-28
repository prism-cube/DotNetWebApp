using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using DotNetWebApp.Requests.Todo;
using DotNetWebApp.Services;
using DotNetWebApp.ViewModels.Todo;
using DotNetWebApp.Utils.Filters;

namespace DotNetWebApp.Controllers;

[AutoValidateAntiforgeryToken]
[Route("todo")]
public class TodoController : Controller
{
    private readonly ILogger<TodoController> _logger;
    private readonly TodoService _service;

    public TodoController(ILogger<TodoController> logger, TodoService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet("")]
    [ImportModelState]
    public IActionResult Index()
    {
        var viewModel = new IndexViewModel()
        {
            DateTimeNow = DateTime.Now,
        };
        return View(viewModel);
    }

    [HttpPost("")]
    [ExportModelState]
    public IActionResult Index(IndexRequest request)
    {
        if (!ModelState.IsValid)
        {
            return RedirectToAction(nameof(Index));
        }

        var message = _service.GetMessage();

        var viewModel = new IndexViewModel()
        {
            Name = request.Name,
            Meta = request.Meta,
            Number = Convert.ToInt32(request.Number),
            DateTimeNow = request.DateTimeNow,
        };
        return View(viewModel);
    }

    [HttpGet("detail/{detailID:int}")]
    public IActionResult Detail(DetailRequest request, int detailID)
    {
        var viewModel = new DetailViewModel()
        {
            DetailID = detailID,
            DetailParam = request.DetailParam,
        };

        return View(viewModel);
    }
}
