using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Data;
using backend.Models;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InsuranceProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public InsuranceProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InsuranceProduct>>> GetInsuranceProducts()
        {
            return await _context.InsuranceProducts.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InsuranceProduct>> GetInsuranceProduct(int id)
        {
            var product = await _context.InsuranceProducts.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        [HttpGet("category/{category}")]
        public async Task<ActionResult<IEnumerable<InsuranceProduct>>> GetInsuranceProductsByCategory(string category)
        {
            return await _context.InsuranceProducts
                .Where(p => p.Category == category)
                .ToListAsync();
        }
    }
}
