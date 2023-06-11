using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YesterdaysDatumController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public YesterdaysDatumController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetYesterdaysDatum()
        //{
        //    var List = await _dbContext.YesterdaysData.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<YesterdaysDatum>> Get() => await _dbContext.YesterdaysData.ToListAsync();

        public IActionResult GetYesterdaysDatum()
        {
            return Ok(_dbContext.YesterdaysData.ToList());
        }
    }
}
