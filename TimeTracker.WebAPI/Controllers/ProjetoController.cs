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
        private readonly IRepository _repository;

        public ProjetoController(DataContext context, IRepository repository)
        {
            _context = context;
            _repository = repository;
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
            if(projeto != null)
            {
                _repository.Add(projeto);
                if(_repository.SaveChanges())
                {
                    return Ok("Projeto Cadastrado com Sucesso!");
                };
            }
            return BadRequest("Não foi impossível incluir um novo Projeto");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Projeto projeto)
        {
            var proj = _context.Projetos.AsNoTracking().FirstOrDefault(x => x.Id == id);

            if(proj != null){
               _repository.Update(projeto);
               if(_repository.SaveChanges())
               {
                   return Ok("Projeto Atualizado com Sucesso!");
               }

            }

            return BadRequest("O projeto de Id = " + id + " não foi encontrado.");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Projeto projeto)
        {
            var proj = _context.Projetos.AsNoTracking().FirstOrDefault(x => x.Id == id);

            if(proj != null){
               _repository.Update(projeto);
               if(_repository.SaveChanges())
               {
                   return Ok("Projeto Atualizado com Sucesso!");
               }

            }

            return BadRequest("O projeto de Id = " + id + " não foi encontrado.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var projeto = _context.Projetos.AsNoTracking().FirstOrDefault(x => x.Id == id);

            if(projeto != null){
                _repository.Remove(projeto);
                if(_repository.SaveChanges())
                {
                    return Ok("Projeto deletado com sucesso!");
                }
            }

            return BadRequest("O projeto de Id = " + id + " não foi encontrado.");
        }
    }
}