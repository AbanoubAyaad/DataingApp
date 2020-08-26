using System.Collections.Generic;
using DatingApp.API.Data;
using DatingApp.API.Properties.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController :ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> get()
        {
            return Ok(await _context.Values.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> get (int id)
        {
            return Ok(await _context.Values.FirstOrDefaultAsync(v=>v.Id.Equals(id)));
        }
    }
}