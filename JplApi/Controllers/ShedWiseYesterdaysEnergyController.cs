using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShedWiseYesterdaysEnergyController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public ShedWiseYesterdaysEnergyController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetShedWiseYesterdaysEnergy()
        //{
        //    var List = await _dbContext.ShedWiseYesterdaysEnergies.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<ShedWiseYesterdaysEnergy>> Get() => await _dbContext.ShedWiseYesterdaysEnergies.ToListAsync();

        public IActionResult GetShedWiseYesterdaysEnergy()
        {
            return Ok(_dbContext.ShedWiseYesterdaysEnergies.ToList());
        }
    }
}
