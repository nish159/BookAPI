using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAPI.Models;
using BookAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookAPI.Controllers
{
    // defines the path that the controller will end
    [Route("api/[controller]")]
    // provides automatic model validation and more
    [ApiController]
    // provides many property and methods that handle HTTP request
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookrepository;

        public BooksController(IBookRepository bookRepository)
        {
            _bookrepository = bookRepository;
        }

        // creating action methods for each HTTP variable we want to handle 
        // This method will convert the books to json before returning it to the caller
        [HttpGet]
        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _bookrepository.Get();
        }

        [HttpGet("{id}")]
        // returns a task action result of book object
        public async Task<ActionResult<Book>> GetBooks(int id)
        {
            return await _bookrepository.Get(id);
        }
    }
}
