using System;
using Microsoft.EntityFrameworkCore;
using DotNetWebApp.Models;

namespace DotNetWebApp.Data;

public class DatabaseContext : DbContext
{
	public DatabaseContext(DbContextOptions options) : base(options) { }

	public DbSet<Todo> Todo { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Todo>().HasData(
		  new Todo { ID = 1, Name = "アンドロイドは電気羊の夢を見るか?", CreatedAt = DateTime.Now },
		  new Todo { ID = 2, Name = "幼年期の終り", CreatedAt = DateTime.Now },
		  new Todo { ID = 3, Name = "一九八四年", CreatedAt = DateTime.Now }
		);
	}
}

