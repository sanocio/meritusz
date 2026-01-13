using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Data;
using backend.Models;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AboutUsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AboutUsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<AboutUs>> GetAboutUs()
        {
            var aboutUs = await _context.AboutUs.FirstOrDefaultAsync();
            if (aboutUs == null)
            {
                return NotFound();
            }
            return aboutUs;
        }
    }
}
