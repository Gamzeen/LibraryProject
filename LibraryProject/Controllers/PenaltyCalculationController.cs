using LibraryProject.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LibraryProject.Controllers
{
    [Route("v1/penalties")]
    [ApiController]
    public class PenaltyCalculationController : ControllerBase
    {
        private readonly IBookTransactionService _bookTransactionService;

        public PenaltyCalculationController(IBookTransactionService bookTransactionService)
        {
            _bookTransactionService = bookTransactionService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(long id)
        {
            var book = await _bookTransactionService.GetBookTransactionByBookTransactionIdAsync(id);
            return Ok(book);
        }

        [HttpGet("penalty")]
        public async Task<IActionResult> Penalty(long id)
        {
            var book = _bookTransactionService.GetPenalty(id);
            return Ok(book);
        }

        [HttpPost("book")]
        public async Task<IActionResult> GiveBook(BookTransactionRequestModel request)
        {
            _bookTransactionService.CreateBookTransaction(request);
            return Ok();
        }
    }
}
