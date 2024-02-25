using Microsoft.AspNetCore.Mvc;
using YourNamespace.Models;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok("All books listed.");
        }

        [HttpPost]
        public IActionResult CreateBook()
        {
            return Ok("New book created.");
        }

        [HttpGet("{bookId}")]
        public IActionResult GetBookById(int bookId)
        {
            return Ok($"Book with ID: {bookId} retrieved.");
        }

        [HttpPut("{bookId}")]
        public IActionResult UpdateBook(int bookId, [FromBody] Book book)
        {
            return Ok($"Book with ID: {bookId} updated.");
        }

        [HttpDelete("{bookId}")]
        public IActionResult DeleteBook(int bookId)
        {
            return Ok($"Book with ID: {bookId} deleted.");
        }
    }
}
