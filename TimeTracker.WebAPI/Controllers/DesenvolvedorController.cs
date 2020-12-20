using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TimeTracker.WebAPI.Models;

namespace TimeTracker.WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DesenvolvedorController : ControllerBase
    {
        public List<Desenvolvedor> Desenvolvedores = new List<Desenvolvedor>()
        {
            new Desenvolvedor(){
                Id = 1,
                Nome = "Pedro",
                Email = "ppedrohfs@gmail.com",
                Telefone = "548484848484840"
            },
            new Desenvolvedor(){
                Id = 2,
                Nome = "Henrique",
                Email = "emagrecimentos@gmail.com",
                Telefone = "4545445454"
            },
            new Desenvolvedor(){
                Id = 3,
                Nome = "Fernandes",
                Email = "Fernandes@gmail.com",
                Telefone = "4545454545454"
            }
        };
        public DesenvolvedorController()
        {
            
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Desenvolvedores);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var desenvolvedor = Desenvolvedores.FirstOrDefault(x => x.Id == id);

            if(desenvolvedor == null){
                return BadRequest("Desenvolvedor não foi encontrado");
            }

            return Ok(desenvolvedor);
        }

        [HttpPost]
        public IActionResult Post(Desenvolvedor desenvolvedor)
        {
            return Ok(desenvolvedor);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,Desenvolvedor desenvolvedor)
        {
            return Ok(desenvolvedor);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(id);
        }

    }
}