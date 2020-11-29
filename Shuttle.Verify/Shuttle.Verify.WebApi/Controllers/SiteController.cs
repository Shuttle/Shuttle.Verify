using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace Shuttle.Verify.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiteController : ControllerBase
    {
        [HttpGet("configuration")]
        public IActionResult GetServerConfiguration()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;

            return Ok(new
            {
                Version = $"{version.Major}.{version.Minor}.{version.Build}"
            });
        }
    }
}