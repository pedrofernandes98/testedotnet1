using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TimeTracker.WebAPI.Models;

namespace TimeTracker.WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProjetoController : ControllerBase
    {
        public ProjetoController()
        {
            
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("OK");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            

            return Ok("OK");
        }
    }
}