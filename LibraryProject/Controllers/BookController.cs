using LibraryProject.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LibraryProject.Controllers
{
    [Route("v1/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var response = await _bookService.GetBooksAsync();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(long id)
        {
            var response = await _bookService.GetBookByIdAsync(id);
            return Ok(response);
        }
    }
}
