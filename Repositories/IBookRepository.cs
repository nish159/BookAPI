using System;
using BookAPI.Models;

namespace BookAPI.Repositories
{
	public interface IBookRepository
	{
		Task<IEnumerable<Book>> Get();

		Task<Book> Get(int id);

		Task<Book> Create(Book book);

		Task Update(Book book);

		Task Delete(int id);
	}
}
