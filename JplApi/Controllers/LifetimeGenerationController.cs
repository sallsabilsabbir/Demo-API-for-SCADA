using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LifetimeGenerationController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public LifetimeGenerationController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }


        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetLifetimeGeneration()
        //{
        //    var List = await _dbContext.LifetimeGenerations.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<LifetimeGeneration>> Get() => await _dbContext.LifetimeGenerations.ToListAsync();

        public IActionResult GetLifetimeGeneration()
        {
            return Ok(_dbContext.LifetimeGenerations.ToList());
        }
    }
}
