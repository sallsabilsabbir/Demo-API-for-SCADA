using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SavingsAndProfitController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public SavingsAndProfitController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetSavingsAndProfit()
        //{
        //    var List = await _dbContext. SavingsAndProfits.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<SavingsAndProfit>> Get() => await _dbContext.SavingsAndProfits.ToListAsync();

        public IActionResult GetSavingsAndProfit()
        {
            return Ok(_dbContext.SavingsAndProfits.ToList());
        }
    }
}
