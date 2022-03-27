using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using DotNetWebApp.Requests.Todo;
using DotNetWebApp.ViewModels.Todo;
using DotNetWebApp.Utils.Filters;
using System.Collections.ObjectModel;

namespace DotNetWebApp.Controllers;

[AutoValidateAntiforgeryToken]
[Route("todo")]
public class TodoController : Controller
{
    private readonly ILogger<TodoController> _logger;

    public TodoController(ILogger<TodoController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    [ImportModelState]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("")]
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
            Meta = request.Meta,
            Number = Convert.ToInt32(request.Number),
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
