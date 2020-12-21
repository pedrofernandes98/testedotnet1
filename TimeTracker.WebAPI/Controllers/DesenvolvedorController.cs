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
        private readonly DataContext _context;
        private readonly IRepository _repository;

        public DesenvolvedorController(DataContext context, IRepository repository)
        {
            _repository = repository;
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

            if (desenvolvedor == null)
            {
                return BadRequest("Desenvolvedor não foi encontrado");
            }

            return Ok(desenvolvedor);
        }

        [HttpGet("byname")]
        public IActionResult GetByName(string nome)
        {
            var desenvolvedor = _context.Desenvolvedores.AsNoTracking().FirstOrDefault(x => x.Nome.Contains(nome));

            if (desenvolvedor == null)
            {
                return BadRequest("Desenvolvedor não foi encontrado");
            }

            return Ok(desenvolvedor);
        }

        [HttpPost]
        public IActionResult Post(Desenvolvedor desenvolvedor)
        {
            if (desenvolvedor != null)
            {
                _repository.Add(desenvolvedor);
                if(_repository.SaveChanges())
                {
                    return Ok("Desenvolvedor Cadastrado com Sucesso!");
                }
            }
            
            return BadRequest("Não foi impossível incluir um novo Desenvolvedor");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Desenvolvedor desenvolvedor)
        {
            var dev = _context.Desenvolvedores.AsNoTracking().FirstOrDefault(x => x.Id == id);

            if (dev != null)
            {
                _repository.Update(desenvolvedor);
                if(_repository.SaveChanges())
                {
                    return Ok("Desenvolvedor Atualizado com Sucesso!");
                }
            }

            return BadRequest("O desenvolvedor de Id = " + id + " não foi encontrado.");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Desenvolvedor desenvolvedor)
        {
            var dev = _context.Desenvolvedores.AsNoTracking().FirstOrDefault(x => x.Id == id);

            if (dev != null)
            {
                _repository.Update(desenvolvedor);
                if(_repository.SaveChanges())
                {
                    return Ok("Desenvolvedor Atualizado com Sucesso!");
                }
            }

            return BadRequest("O desenvolvedor de Id = " + id + " não foi encontrado.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var dev = _context.Desenvolvedores.AsNoTracking().FirstOrDefault(x => x.Id == id);

            if (dev != null)
            {
                _repository.Remove(dev);
                if(_repository.SaveChanges())
                {
                    return Ok("Desenvolvedor deletado com sucesso!");
                }
            }

            return BadRequest("O desenvolvedor de Id = " + id + " não foi encontrado.");
        }

    }
}