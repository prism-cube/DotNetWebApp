using DotNetWebApp.Models;

namespace DotNetWebApp.Repositories;

public interface ITodoRepository
{
	Task<List<Todo>> SelectAll();
}

