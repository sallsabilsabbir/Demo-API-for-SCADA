using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmbentTemperatureController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public AmbentTemperatureController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext ;
        }

        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetAmbentTemperature()
        //{
        //    var List = await _dbContext.AmbentTemperatures.ToListAsync();
        //    return Ok(List);
        //}

        
        //public async Task<IEnumerable<AmbentTemperature>> Get() => await _dbContext.AmbentTemperatures.ToListAsync();

        public IActionResult GetAmbentTemperature()
        {
            return Ok(_dbContext.AmbentTemperatures.ToList());
        }

    }
}
