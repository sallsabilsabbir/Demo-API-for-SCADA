using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CumulatuivePrController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public CumulatuivePrController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }


        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetCumulatuivePr()
        //{
        //    var List = await _dbContext.CumulatuivePrs.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<CumulatuivePr>> Get() => await _dbContext.CumulatuivePrs.ToListAsync();

        public IActionResult GetCumulatuivePr()
        {
            return Ok(_dbContext.CumulatuivePrs.ToList());
        }
    }
}
