using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TotalPrController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public TotalPrController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetTotalPr()
        //{
        //    var List = await _dbContext.TotalPrs.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<TotalPr>> Get() => await _dbContext.TotalPrs.ToListAsync();

        public IActionResult GetTotalPr()
        {
            return Ok(_dbContext.TotalPrs.ToList());
        }
    }
}
