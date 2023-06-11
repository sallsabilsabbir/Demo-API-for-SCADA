using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InverterTotalAcPowerController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public InverterTotalAcPowerController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }


        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetInverterTotalAcPower()
        //{
        //    var List = await _dbContext.InverterTotalAcPowers.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<InverterTotalAcPower>> Get() => await _dbContext.InverterTotalAcPowers.ToListAsync();

        public IActionResult GetInverterTotalAcPower()
        {
            return Ok(_dbContext.InverterTotalAcPowers.ToList());
        }
    }
}
