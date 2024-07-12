using CantonesePronunciationApi.Models;
using CantonesePronunciationApi.Models.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CantonesePronunciationApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WordController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public WordController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost("get")]
    public async Task<ActionResult<Word>> GetWord([FromBody] WordRequestModel request)
    {
        if (string.IsNullOrWhiteSpace(request.Word))
        {
            return BadRequest("Word is required.");
        }

        var result = await _context.Words
            .FirstOrDefaultAsync(w => w.Text == request.Word);

        if (result == null)
        {
            return NotFound();
        }

        return result;
    }
}