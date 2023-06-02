using Microsoft.AspNetCore.Mvc;

namespace WebAppDocker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        private readonly ILogger<HelloController> logger;

        public HelloController(ILogger<HelloController> logger) => this.logger = logger;

        [HttpGet(Name = "GetHelloSerega")]
        public ActionResult<string> Get()
        {
            this.logger.LogInformation("HelloController GET-method called");

            return this.Ok($"GET. Hello Serega. Time [{DateTime.Now.Ticks}]");
        }

        [HttpPost(Name = "PostHelloSerega")]
        public ActionResult<string> Post()
        {
            // fetch('https://localhost:8443/Hello', {method: 'POST'})
            //    .then(response => response.text())
            //    .then(data => console.log(data));

            this.logger.LogInformation("HelloController POST-method called");

            return this.Ok($"POST. Privet Serega. Time [{DateTime.Now.Ticks}]");
        }

        [HttpPut(Name = "PutHelloSerega")]
        public ActionResult<Point> Put(Point point)
        {
            // fetch('https://localhost:8443/Hello', {
            //   method: 'PUT',
            //   headers: { 'Accept': 'application/json', 'Content-Type': 'application/json' },
            //   body: JSON.stringify({ x: 1, y: 2})
            // }).then(res => res.json())
            //  .then(data => console.log(JSON.stringify(data)))

            this.logger.LogInformation("HelloController PUT-method called");

            return this.Ok(new Point { X = ++point.X, Y = ++point.Y });
        }
    }
}