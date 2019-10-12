using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakeAPI.Data;
using CakeAPI.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CakeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CakeController : ControllerBase
    {
        private readonly CakeContext _context;
        private readonly IConfiguration _config;
        public CakeController(CakeContext context,
            IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        [HttpGet]
        [Route("[action]")]

        public async Task<IActionResult> Cakes()
        {
            var items = await _context.Cakes.ToListAsync();
            return Ok(items);
        }
    }
}