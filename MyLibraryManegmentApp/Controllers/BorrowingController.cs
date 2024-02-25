using Microsoft.AspNetCore.Mvc;
using YourNamespace.Models;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BorrowingController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllBorrowings()
        {
            return Ok("All borrowings listed.");
        }

        [HttpPost]
        public IActionResult CreateBorrowing([FromBody] Borrowing borrowing)
        {
            return Ok("New borrowing record created.");
        }

        [HttpGet("{borrowingId}")]
        public IActionResult GetBorrowingById(int borrowingId)
        {
            return Ok($"Borrowing record with ID: {borrowingId} retrieved.");
        }

        [HttpPut("{borrowingId}")]
        public IActionResult UpdateBorrowing(int borrowingId, [FromBody] Borrowing borrowing)
        {
            return Ok($"Borrowing record with ID: {borrowingId} updated.");
        }

        [HttpDelete("{borrowingId}")]
        public IActionResult DeleteBorrowing(int borrowingId)
        {
            return Ok($"Borrowing record with ID: {borrowingId} deleted.");
        }
    }
}
