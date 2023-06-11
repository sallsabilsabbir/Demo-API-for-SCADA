using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivePowerController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public LivePowerController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }


        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetLivePower()
        //{
        //    var List = await _dbContext.LivePowers.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<LivePower>> Get() => await _dbContext.LivePowers.ToListAsync();

        public IActionResult GetLivePower()
        {
            return Ok(_dbContext.LivePowers.ToList());
        }
    }
}
