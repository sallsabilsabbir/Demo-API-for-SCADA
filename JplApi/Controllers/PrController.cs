using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public PrController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }


        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetPr()
        //{
        //    var List = await _dbContext.Prs.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<Pr>> Get() => await _dbContext.Prs.ToListAsync();

        public IActionResult GetPr()
        {
            return Ok(_dbContext.Prs.ToList());
        }
    }
}
