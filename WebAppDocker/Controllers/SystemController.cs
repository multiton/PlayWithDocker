using Microsoft.AspNetCore.Mvc;

namespace WebAppDocker.Controllers
{
    [ApiController]
    [Route("[controller]")]    
    public class SystemController : ControllerBase
    {
        [HttpGet("OSVersion")]
        public ActionResult<string> GetOsVersion()
            => Ok(Environment.OSVersion);

        [HttpGet("Environment")]
        public ActionResult<string> GetEnvironment()
            => Ok(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));
    }
}