using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaxDcPowerController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public MaxDcPowerController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }


        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetMaxDcPower()
        //{
        //    var List = await _dbContext.MaxDcPowers.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<MaxDcPower>> Get() => await _dbContext.MaxDcPowers.ToListAsync();

        public IActionResult GetMaxDcPower()
        {
            return Ok(_dbContext.MaxDcPowers.ToList());
        }
    }
}
