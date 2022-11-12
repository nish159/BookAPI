using System;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Models
{
	public class BookContext : DbContext
	{
		// object is a configuration of the context; injected through dependency injection
		public BookContext(DbContextOptions<BookContext> options)
			:base(options)
		{
			// ensure database is created using dbcontext
			Database.EnsureCreated();
		}

		// present a collection of books
		public DbSet<Book> Books { get; set; }
	}
}

