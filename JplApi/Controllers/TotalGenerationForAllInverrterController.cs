using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TotalGenerationForAllInverrterController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public TotalGenerationForAllInverrterController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetTotalGenerationForAllInverrter()
        //{
        //    var List = await _dbContext.TotalGenerationForAllInverrters.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<TotalGenerationForAllInverrter>> Get() => await _dbContext.TotalGenerationForAllInverrters.ToListAsync();

        public IActionResult GetTotalGenerationForAllInverrter()
        {
            return Ok(_dbContext.TotalGenerationForAllInverrters.ToList());
        }
    }
}
