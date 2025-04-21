using Microsoft.AspNetCore.Mvc;
using ApplicationTrackerAPI.Data;
using ApplicationTrackerAPI.Models;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class ApplicationController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ApplicationController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Application>>> GetJobApplications()
    {
        return await _context.Applications.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Application>> PostJobApplication(Application jobApplication)
    {
        _context.Applications.Add(jobApplication);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetJobApplications), new { id = jobApplication.Id }, jobApplication);
    }
}