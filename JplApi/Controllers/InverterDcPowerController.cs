using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InverterDcPowerController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public InverterDcPowerController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }


        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetInverterDcPower()
        //{
        //    var List = await _dbContext.InverterDcPowers.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<InverterDcPower>> Get() => await _dbContext.InverterDcPowers.ToListAsync();

        public IActionResult GetInverterDcPower()
        {
            return Ok(_dbContext.InverterDcPowers.ToList());
        }
    }
}
