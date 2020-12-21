using TimeTracker.WebAPI.Models;

namespace TimeTracker.WebAPI.Data
{
    public interface IRepository
    {
         void Add<T>(T entity) where T : class;

         void Update<T>(T entity) where T : class;

         void Remove<T>(T entity) where T : class;

         bool SaveChanges();

         Desenvolvedor[] GetAllDesenvolvedores();

         Desenvolvedor[] GetAllDesenvolvedoresByProjetoId();

         Desenvolvedor GetDesenvolvedorById();

         Projeto[] GetAllProjetos();

         Projeto[] GetAllProjetosByDesenvolvedorId();

         Projeto GetProjetoById();

    }
}