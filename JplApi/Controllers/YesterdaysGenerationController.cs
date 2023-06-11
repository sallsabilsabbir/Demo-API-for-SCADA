using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YesterdaysGenerationController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public YesterdaysGenerationController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetYesterdaysGeneration()
        //{
        //    var List = await _dbContext.YesterdaysGenerations.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<YesterdaysGeneration>> Get() => await _dbContext.YesterdaysGenerations.ToListAsync();

        public IActionResult GetYesterdaysGeneration()
        {
            return Ok(_dbContext.YesterdaysGenerations.ToList());
        }
    }
}
