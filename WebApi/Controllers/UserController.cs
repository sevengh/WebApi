using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Djone", "Bill", "Bob", "Ray", "Lee", "Smith"
        };

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("[action]")]
        public EmptyResult? Create([FromBody] User value)
        {
            return null;
        }

        [HttpGet]
        [Route("[action]")]
        public IEnumerable<User> GetAll()
        {
            return Enumerable.Range(1, 5).Select(index => new User
            {
                Name = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        [Route("[action]")]
        public Category GetOne(int id)
        {
            return new Category
            {
                Name = "Djon"
            };
        }

        [HttpPut]
        [Route("[action]")]
        public bool Update(int id, [FromBody] User value)
        {
            return false;
        }

        [HttpDelete]
        [Route("[action]")]
        public bool Delete(int id)
        {
            return false;
        }
    }
}