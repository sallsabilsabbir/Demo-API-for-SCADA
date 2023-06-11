using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantDatumController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public PlantDatumController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }


        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetPlantDatum()
        //{
        //    var List = await _dbContext.PlantData.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<PlantDatum>> Get() => await _dbContext.PlantData.ToListAsync();

        public IActionResult GetPlantDatum()
        {
            return Ok(_dbContext.PlantData.ToList());
        }
    }
}
