using System;

namespace DotNetWebApp.Models;

public record Todo
{
	public int ID { get; init; }

	public string Name { get; init; }

	public DateTime CreatedAt { get; init; }
}

