using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DotNetWebApp.Models;

namespace DotNetWebApp.Controllers;

public class TodoController : Controller
{
    private readonly ILogger<TodoController> _logger;

    public TodoController(ILogger<TodoController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}


