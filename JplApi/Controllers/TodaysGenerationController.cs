using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodaysGenerationController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public TodaysGenerationController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetTodaysGeneration()
        //{
        //    var List = await _dbContext.TodaysGenerations.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<TodaysGeneration>> Get() => await _dbContext.TodaysGenerations.ToListAsync();

        public IActionResult GetTodaysGeneration()
        {
            return Ok(_dbContext.TodaysGenerations.ToList());
        }
    }
}
