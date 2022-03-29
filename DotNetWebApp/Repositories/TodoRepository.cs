using System;
using Microsoft.EntityFrameworkCore;
using DotNetWebApp.Data;
using DotNetWebApp.Models;

namespace DotNetWebApp.Repositories;

public class TodoRepository
{
	private readonly DatabaseContext _db;

	public TodoRepository(DatabaseContext db)
	{
		_db = db;
	}

	public async Task<List<Todo>> SelectAll()
	{
		return await _db.Todo.ToListAsync();
	}
}

