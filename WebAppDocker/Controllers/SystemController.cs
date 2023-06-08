using Microsoft.AspNetCore.Mvc;

namespace WebAppDocker.Controllers
{
    [ApiController]
    [Route("[controller]")]    
    public class SystemController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get() => Ok(Environment.OSVersion);
    }
}