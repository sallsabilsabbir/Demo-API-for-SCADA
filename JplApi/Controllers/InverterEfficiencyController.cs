using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InverterEfficiencyController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public InverterEfficiencyController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }


        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetInverterEfficiency()
        //{
        //    var List = await _dbContext.InverterEfficiencies.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<InverterEfficiency>> Get() => await _dbContext.InverterEfficiencies.ToListAsync();

        public IActionResult GetCumulativePoaAvg()
        {
            return Ok(_dbContext.InverterEfficiencies.ToList());
        }
    }
}
