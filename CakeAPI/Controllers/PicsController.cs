using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IOFile = System.IO.File;

namespace CakeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PicsController : ControllerBase
    {
        private readonly IHostingEnvironment _env;
        public PicsController(IHostingEnvironment env)
        {
            _env = env;
        }

        [HttpGet("{id}")]
        public IActionResult GetImage(int id)
        {
            var webRoot = _env.WebRootPath;
            var path = Path.Combine($"{webRoot}/Pics/", $"{id}.jpg");
            var buffer = IOFile.ReadAllBytes(path);
            return File(buffer, "image/jpeg");
        }
    }
}
