using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using portrait.Data;

namespace portrait.Controller;

[ApiController]
[Route("api/[controller]")]
public class ShapesController : ControllerBase
{
    private readonly ShapesTestContext _context;

    public ShapesController(ShapesTestContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetShapes()
    {
        var shapes = await _context.Shapes.ToListAsync();
        return Ok(shapes);
    }
}