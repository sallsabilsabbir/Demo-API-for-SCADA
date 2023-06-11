using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TotalAcPowerController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public TotalAcPowerController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetTotalAcPower()
        //{
        //    var List = await _dbContext.TotalAcPowers.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<TotalAcPower>> Get() => await _dbContext.TotalAcPowers.ToListAsync();

        public IActionResult GetTotalAcPower()
        {
            return Ok(_dbContext.TotalAcPowers.ToList());
        }
    }
}
