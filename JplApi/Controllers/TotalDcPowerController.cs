using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TotalDcPowerController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public TotalDcPowerController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetTotalDcPower()
        //{
        //    var List = await _dbContext.TotalDcPowers.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<TotalDcPower>> Get() => await _dbContext.TotalDcPowers.ToListAsync();

        public IActionResult GetTotalDcPower()
        {
            return Ok(_dbContext.TotalDcPowers.ToList());
        }
    }
}
