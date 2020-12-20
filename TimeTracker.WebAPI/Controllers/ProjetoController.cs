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
    public class ProjetoController : ControllerBase
    {
        private readonly DataContext _context;
        public ProjetoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var projetos = _context.Projetos.AsNoTracking().ToList<Projeto>();
            return Ok(projetos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var projeto = _context.Projetos.AsNoTracking().FirstOrDefault(x => x.Id == id);

            if(projeto == null){
                return BadRequest("Projeto não encontrado");
            }
            return Ok(projeto);
        }

        [HttpGet("byname")]
        public IActionResult GetByName(string nome)
        {
            var projeto = _context.Projetos.AsNoTracking().FirstOrDefault(x => x.Nome.Contains(nome));

            if(projeto == null){
                return BadRequest("Projeto não foi encontrado");
            }

            return Ok(projeto);
        }

        [HttpPost]
        public IActionResult Post(Projeto projeto)
        {
            if(projeto == null){
                return BadRequest("Não foi impossível incluir um novo Desenvolvedor");
            }

            _context.Projetos.Add(projeto);
            var novoProjetovedorId =  _context.SaveChanges();

            return Ok("Projeto Cadastrado com Sucesso!");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Projeto projeto)
        {
            var proj = _context.Projetos.AsNoTracking().FirstOrDefault(x => x.Id == id);

            if(proj == null){
                return BadRequest("O projeto de Id = " + id + " não foi encontrado.");
            }

            _context.Projetos.Update(projeto);
            _context.SaveChanges();
            
            return Ok("Projeto Atualizado com Sucesso!");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Projeto projeto)
        {
            var proj = _context.Projetos.AsNoTracking().FirstOrDefault(x => x.Id == id);

            if(proj == null){
                return BadRequest("O projeto de Id = " + id + " não foi encontrado.");
            }

            _context.Projetos.Update(projeto);
            _context.SaveChanges();
            
            return Ok("Projeto Atualizado com Sucesso!");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var projeto = _context.Projetos.AsNoTracking().FirstOrDefault(x => x.Id == id);

            if(projeto == null){
                return BadRequest("O projeto de Id = " + id + " não foi encontrado.");
            }

            _context.Projetos.Remove(projeto);
            _context.SaveChanges();

            return Ok("Projeto deletado com sucesso!");
        }
    }
}