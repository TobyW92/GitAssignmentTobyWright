using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GitAssignmentTobyWright.Models;

namespace GitAssignmentTobyWright.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        private readonly ILogger<NameController> _logger;

        public NameController(ILogger<NameController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var person = new Name { NameFirst = "Toby", NameLast = "Wright", GithubID = "TobyW92" };
            return Ok(person);
        }

    }
}
