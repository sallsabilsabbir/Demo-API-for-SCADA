﻿using JplApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JplApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TotalGenerationController : ControllerBase
    {
        private readonly JPL_DBContext _dbContext;

        public TotalGenerationController(JPL_DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get All Data

        [HttpGet]

        //public async Task<ActionResult<List<JPL_DBContext>>> GetTotalGeneration()
        //{
        //    var List = await _dbContext.TotalGenerations.ToListAsync();
        //    return Ok(List);
        //}


        //public async Task<IEnumerable<TotalGeneration>> Get() => await _dbContext.TotalGenerations.ToListAsync();

        public IActionResult GetTotalGeneration()
        {
            return Ok(_dbContext.TotalGenerations.ToList());
        }
    }
}
