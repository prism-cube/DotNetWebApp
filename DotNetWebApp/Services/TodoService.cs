using System;
using DotNetWebApp.Models;
using DotNetWebApp.Repositories;

namespace DotNetWebApp.Services;

public class TodoService
{
	private readonly ITodoRepository _repository;

	public TodoService(ITodoRepository repository)
	{
		_repository = repository;
	}

	public string GetMessage()
	{
		return "TodoService!";
	}

	public List<Todo> SelectAll()
	{
		return _repository.SelectAll().Result;
	}
}

