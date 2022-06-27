using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;

        public CategoryController(ILogger<CategoryController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public bool Create()
        {
            return false;
        }

        /// <summary>
        /// Get all
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public IEnumerable<Category> GetAll()
        {
            return Enumerable.Range(1, 5).Select(index => new Category
            {
                Name = DateTime.Now.AddDays(index).ToString()
            })
            .ToArray();
        }

        /// <summary>
        /// Get one
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public Category GetOne(int id)
        {
            return new Category
            {
                Name = "Sample"
            };
        }

        /// <summary>
        /// Update one category
        /// </summary>
        /// <param name="id">Category id</param>
        /// <returns></returns>
        [HttpPut]
        [Route("[action]")]
        public bool Update(int id, [FromBody] User value)
        {
            return false;
        }

        /// <summary>
        /// Delete one category
        /// </summary>
        /// <param name="id">Category id</param>
        /// <returns>True - Done, False - Error</returns>
        [HttpDelete]
        [Route("[action]")]
        public bool Delete(int id)
        {
            return false;
        }
    }
}