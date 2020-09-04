using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace XCaseManager.Messenger.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExecutionController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing-A", "Bracing-A", "Chilly-A", "Cool-A", "Mild-A", "Warm-A", "Balmy-A", "Hot-A", "Sweltering-A", "Scorching-A"
        };

        private readonly ILogger<ExecutionController> _logger;

        public ExecutionController(ILogger<ExecutionController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ExecutionItem> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new ExecutionItem
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
