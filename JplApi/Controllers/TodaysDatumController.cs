using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodaysDatumController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public TodaysDatumController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetTodaysDatum()
        //{
        //    var List = await _dbContext.TodaysData.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<TodaysDatum>> Get() => await _dbContext.TodaysData.ToListAsync();

        public IActionResult GetTodaysDatum()
        {
            return Ok(_dbContext.TodaysData.ToList());
        }
    }
}
