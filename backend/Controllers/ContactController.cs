using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Data;
using backend.Models;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<ContactInfo>> GetContactInfo()
        {
            var contactInfo = await _context.ContactInfos.FirstOrDefaultAsync();
            if (contactInfo == null)
            {
                return NotFound();
            }
            return contactInfo;
        }
    }
}
