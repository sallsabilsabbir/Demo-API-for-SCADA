using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoaAvgController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public PoaAvgController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }


        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetPoaAvg()
        //{
        //    var List = await _dbContext.PoaAvgs.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<PoaAvg>> Get() => await _dbContext.PoaAvgs.ToListAsync();

        public IActionResult GetPoaAvg()
        {
            return Ok(_dbContext.PoaAvgs.ToList());
        }
    }
}
