using CorsDbPersistedSandbox.Models;
using CorsDbPersistedSandbox.Services;
using Microsoft.AspNetCore.Mvc;

namespace CorsDbPersistedSandbox.Controllers
{
    [ApiController]
    public sealed class BookController : Controller
    {
        readonly BookService _bookService;

        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("/books")]
        public IActionResult GetBooks() =>
            Ok(_bookService.GetBooks());

        [HttpGet("/book")]
        public IActionResult GetBook([FromQuery] int id) =>
            Ok(_bookService.GetBook(id));

        [HttpPost("/books/create")]
        public IActionResult CreateBook([FromBody] Book newBook)
        {
            _bookService.CreateBook(newBook);
            return Ok("Success, try getting book!");
        }
    }
}
