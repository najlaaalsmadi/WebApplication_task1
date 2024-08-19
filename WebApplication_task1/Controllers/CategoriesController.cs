using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication_task1.Models;

namespace WebApplication_task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly MyDbContext _context;
        public CategoriesController(MyDbContext context)
        {
            _context = context;

        }
        [HttpGet]
        public IActionResult Get()
        {
            var categories = _context.Categories.ToList();
            return Ok(categories);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var categoriesID = _context.Categories.Where(b => b.CategoryId == id);
            return Ok(categoriesID);
        }
    }
}
