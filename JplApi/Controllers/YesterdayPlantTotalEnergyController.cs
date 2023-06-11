using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YesterdayPlantTotalEnergyController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public YesterdayPlantTotalEnergyController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetYesterdayPlantTotalEnergy()
        //{
        //    var List = await _dbContext.YesterdayPlantTotalEnergies.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<YesterdayPlantTotalEnergy>> Get() => await _dbContext.YesterdayPlantTotalEnergies.ToListAsync();

        public IActionResult GetYesterdayPlantTotalEnergy()
        {
            return Ok(_dbContext.YesterdayPlantTotalEnergies.ToList());
        }
    }
}
