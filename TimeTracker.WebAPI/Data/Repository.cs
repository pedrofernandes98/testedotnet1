using System.Linq;
using Microsoft.EntityFrameworkCore;
using TimeTracker.WebAPI.Models;

namespace TimeTracker.WebAPI.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;
        public Repository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Remove<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public bool SaveChanges()
        {
            return(_context.SaveChanges() > 0);
        }

        public Desenvolvedor[] GetAllDesenvolvedores(bool includeProjetos = false)
        {
            IQueryable<Desenvolvedor> query = _context.Desenvolvedores;

            if(includeProjetos)
            {
                query = query.Include(x => x.Lancamentos_Horas)
                             .ThenInclude(p => p.Projeto);
            }

            query = query.AsNoTracking().OrderBy(x => x.Id);

            return query.ToArray();
        }

        public Desenvolvedor[] GetAllDesenvolvedoresByProjetoId(int ProjetoId, bool includeProjetos = false)
        {
            IQueryable<Desenvolvedor> query = _context.Desenvolvedores;

            if(includeProjetos)
            {
                query = query.Include(x => x.Lancamentos_Horas)
                             .ThenInclude(p => p.Projeto);
            }

            query = query.AsNoTracking()
                         .OrderBy(x => x.Id)
                         .Where(projeto => projeto.Lancamentos_Horas.Any(p => p.ProjetoId == ProjetoId));

            return query.ToArray();
        }

        public Desenvolvedor GetDesenvolvedorById(int DesenvolvedorId, bool includeProjetos = false)
        {
            IQueryable<Desenvolvedor> query = _context.Desenvolvedores;

            if(includeProjetos)
            {
                query = query.Include(x => x.Lancamentos_Horas)
                             .ThenInclude(p => p.Projeto);
            }

            query = query.AsNoTracking()
                         .Where(x => x.Id == DesenvolvedorId)
                         .OrderBy(x => x.Id);

            return query.FirstOrDefault();
        }

        public Projeto[] GetAllProjetos(bool includeDesenvolvedor = false)
        {
            IQueryable<Projeto> query = _context.Projetos;

            if(includeDesenvolvedor)
            {
                query = query.Include(x => x.Lancamentos_Horas)
                             .ThenInclude(dev => dev.Desenvolvedor);
            }

            query = query.AsNoTracking()
                         .OrderBy(x => x.Id);

            return query.ToArray();
        }                

        public Projeto[] GetAllProjetosByDesenvolvedorId(int devId,bool includeDesenvolvedor = false)
        {
            IQueryable<Projeto> query = _context.Projetos;

            if(includeDesenvolvedor)
            {
                query = query.Include(x => x.Lancamentos_Horas)
                             .ThenInclude(dev => dev.Desenvolvedor)
                             .Where(dev => dev.Lancamentos_Horas.Any(d => d.Id == devId));
            }

            query = query.AsNoTracking()
                         .OrderBy(x => x.Id);

            return query.ToArray();
        }

        public Projeto GetProjetoById(int projetoId, bool includeDesenvolvedor = false)
        {
            IQueryable<Projeto> query = _context.Projetos;

            if(includeDesenvolvedor)
            {
                query = query.Include(x => x.Lancamentos_Horas)
                             .ThenInclude(dev => dev.Desenvolvedor);
            }

            query = query.AsNoTracking()
                         .Where(x => x.Id == projetoId)
                         .OrderBy(x => x.Id);

            return query.FirstOrDefault();
        }
    }
}