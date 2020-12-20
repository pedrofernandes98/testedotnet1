using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TimeTracker.WebAPI.Data;
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
        private readonly DataContext _context;

        public DesenvolvedorController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var desenvolvedores = _context.Desenvolvedores.AsNoTracking().ToList<Desenvolvedor>();
            return Ok(desenvolvedores);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var desenvolvedor = _context.Desenvolvedores.AsNoTracking().FirstOrDefault(x => x.Id == id);

            if(desenvolvedor == null){
                return BadRequest("Desenvolvedor não foi encontrado");
            }

            return Ok(desenvolvedor);
        }

        [HttpGet("byname")]
        public IActionResult GetByName(string nome)
        {
            var desenvolvedor = _context.Desenvolvedores.AsNoTracking().FirstOrDefault(x => x.Nome.Contains(nome));

            if(desenvolvedor == null){
                return BadRequest("Desenvolvedor não foi encontrado");
            }

            return Ok(desenvolvedor);
        }

        [HttpPost]
        public IActionResult Post(Desenvolvedor desenvolvedor)
        {
            if(desenvolvedor == null){
                return BadRequest("Não foi impossível incluir um novo Desenvolvedor");
            }

            _context.Desenvolvedores.Add(desenvolvedor);
            var novoDesenvolvedorId =  _context.SaveChanges();

            return Ok("Desenvolvedor Cadastrado com Sucesso!");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Desenvolvedor desenvolvedor)
        {
            var dev = _context.Desenvolvedores.AsNoTracking().FirstOrDefault(x => x.Id == id);

            if(dev == null){
                return BadRequest("O desenvolvedor de Id = " + id + " não foi encontrado.");
            }

            _context.Desenvolvedores.Update(desenvolvedor);
            _context.SaveChanges();
            
            return Ok("Desenvolvedor Atualizado com Sucesso!");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Desenvolvedor desenvolvedor)
        {
            var dev = _context.Desenvolvedores.AsNoTracking().FirstOrDefault(x => x.Id == id);

            if(dev == null){
                return BadRequest("O desenvolvedor de Id = " + id + " não foi encontrado.");
            }

            _context.Desenvolvedores.Update(desenvolvedor);
            _context.SaveChanges();
            
            return Ok("Desenvolvedor Atualizado com Sucesso!");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var dev = _context.Desenvolvedores.AsNoTracking().FirstOrDefault(x => x.Id == id);

            if(dev == null){
                return BadRequest("O desenvolvedor de Id = " + id + " não foi encontrado.");
            }

            _context.Desenvolvedores.Remove(dev);
            _context.SaveChanges();

            return Ok("Desenvolvedor deletado com sucesso!");
        }

    }
}