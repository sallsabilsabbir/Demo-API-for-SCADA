using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TotalMaxAcPowerController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public TotalMaxAcPowerController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetTotalMaxAcPower()
        //{
        //    var List = await _dbContext.TotalMaxAcPowers.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<TotalMaxAcPower>> Get() => await _dbContext.TotalMaxAcPowers.ToListAsync();

        public IActionResult GetTotalMaxAcPower()
        {
            return Ok(_dbContext.TotalMaxAcPowers.ToList());
        }
    }
}
