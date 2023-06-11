using JplApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CumulativePoaAvgController : Controller
    {
        private readonly JPL_DBContext _dbContext;

        public CumulativePoaAvgController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }


        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetCumulativePoaAvg()
        //{
        //    var List = await _dbContext.CumulativePoaAvgs.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<CumulativePoaAvg>> Get() => await _dbContext.CumulativePoaAvgs.ToListAsync();

        public IActionResult GetCumulativePoaAvg()
        {
            return Ok(_dbContext.CumulativePoaAvgs.ToList());
        }
    }
}
