using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TotalMaxDcPowerController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public TotalMaxDcPowerController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetTotalMaxDcPower()
        //{
        //    var List = await _dbContext.TotalMaxDcPowers.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<TotalMaxDcPower>> Get() => await _dbContext.TotalMaxDcPowers.ToListAsync();

        public IActionResult GetTotalMaxDcPower()
        {
            return Ok(_dbContext.TotalMaxDcPowers.ToList());
        }
    }
}
