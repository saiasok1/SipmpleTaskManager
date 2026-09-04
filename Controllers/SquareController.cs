using Microsoft.AspNetCore.Mvc;
namespace SimpleTaskManager.Controllers;


[ApiController]
[Route("square")]
public class SquareController : ControllerBase
{
    
    
    [HttpGet("{number}")]
    public IActionResult GetSquare(int number)
    {
        int square = number * number;
        return Ok(square);
    }
}