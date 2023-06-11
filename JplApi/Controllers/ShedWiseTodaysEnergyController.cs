using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShedWiseTodaysEnergyController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public ShedWiseTodaysEnergyController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetAmbentTemperature()
        //{
        //    var List = await _dbContext.ShedWiseTodaysEnergies.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<ShedWiseTodaysEnergy>> Get() => await _dbContext.ShedWiseTodaysEnergies.ToListAsync();

        public IActionResult GetAmbentTemperature()
        {
            return Ok(_dbContext.ShedWiseTodaysEnergies.ToList());
        }
    }
}
