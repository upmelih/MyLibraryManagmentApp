using Microsoft.AspNetCore.Mvc;
using System.Reflection.PortableExecutable;
using YourNamespace.Models;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReaderController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllReaders()
        {
            return Ok("All readers listed.");
        }

        [HttpPost]
        public IActionResult CreateReader([FromBody] Reader reader)
        {
            return Ok("New reader created.");
        }

        [HttpGet("{readerId}")]
        public IActionResult GetReaderById(int readerId)
        {
            return Ok($"Reader with ID: {readerId} retrieved.");
        }

        [HttpPut("{readerId}")]
        public IActionResult UpdateReader(int readerId, [FromBody] Reader reader)
        {
            return Ok($"Reader with ID: {readerId} updated.");
        }

        [HttpDelete("{readerId}")]
        public IActionResult DeleteReader(int readerId)
        {
            return Ok($"Reader with ID: {readerId} deleted.");
        }
    }
}
