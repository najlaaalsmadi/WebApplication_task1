using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication_task1.Models;

namespace WebApplication_task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly MyDbContext _context1;
        public ProductsController(MyDbContext context)
        {
            _context1 = context;

        }
        [HttpGet]
        public IActionResult Get()
        {
            var Products = _context1.Products
                .ToList();
            return Ok(Products);
        }
        [HttpGet("Id")]
        public IActionResult Get(int id)
        {
            var ProductsID = _context1.Products
                .FirstOrDefault(b => b.ProductId == id);

            return Ok(ProductsID);
        }
    }
}
