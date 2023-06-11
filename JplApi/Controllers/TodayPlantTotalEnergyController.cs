using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodayPlantTotalEnergyController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public TodayPlantTotalEnergyController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetTodayPlantTotalEnergy()
        //{
        //    var List = await _dbContext.TodayPlantTotalEnergies.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<TodayPlantTotalEnergy>> Get() => await _dbContext.TodayPlantTotalEnergies.ToListAsync();

        public IActionResult GetTodayPlantTotalEnergy()
        {
            return Ok(_dbContext.TodayPlantTotalEnergies.ToList());
        }
    }
}
