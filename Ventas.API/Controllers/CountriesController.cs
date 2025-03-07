using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ventas.API.Data;


namespace Ventas.API.Controllers
{
    [ApiController]
    [Route("api/countires")]
    public class CountriesController
    {
        private readonly DataContext _context;

        public CountriesController(DataContext context)
        {
            this._context = context;
        }

        [HttpPost]

        public async Task<ActionResult> PostAsync(County country)
        {
           _context.Countries.Add(country);
            await _context.SaveChangesAsync();
            return Ok(PostAsync(country);
        }

        [HttpGet]

        public async Task<IActionResult> Getasync()
        {
            return Ok(await _context.Countries.ToListAsync());
        }


    }
}
