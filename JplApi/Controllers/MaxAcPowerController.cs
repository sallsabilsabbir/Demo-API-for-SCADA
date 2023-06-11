using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaxAcPowerController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public MaxAcPowerController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }


        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetMaxAcPower()
        //{
        //    var List = await _dbContext.MaxAcPowers.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<MaxAcPower>> Get() => await _dbContext.MaxAcPowers.ToListAsync();

        public IActionResult GetMaxAcPower()
        {
            return Ok(_dbContext.MaxAcPowers.ToList());
        }
    }
}
