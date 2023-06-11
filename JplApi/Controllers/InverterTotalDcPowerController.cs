using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InverterTotalDcPowerController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public InverterTotalDcPowerController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }


        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetInverterTotalDcPower()
        //{
        //    var List = await _dbContext.InverterTotalDcPowers.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<InverterTotalDcPower>> Get() => await _dbContext.InverterTotalDcPowers.ToListAsync();

        public IActionResult GetInverterTotalDcPower()
        {
            return Ok(_dbContext.InverterTotalDcPowers.ToList());
        }
    }
}
