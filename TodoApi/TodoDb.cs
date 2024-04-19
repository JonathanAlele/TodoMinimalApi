using Microsoft.EntityFrameworkCore;

namespace TodoApi
{
	// Central point of contact between the Model and the DB
	public class TodoDb : DbContext
	{

		public DbSet<Todo> Todos => Set<Todo>();
		public TodoDb(DbContextOptions<TodoDb> options) : base(options)
		{

		}
	}
}
