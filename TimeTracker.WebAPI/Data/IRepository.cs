using TimeTracker.WebAPI.Models;

namespace TimeTracker.WebAPI.Data
{
    public interface IRepository
    {
         void Add<T>(T entity) where T : class;

         void Update<T>(T entity) where T : class;

         void Remove<T>(T entity) where T : class;

         bool SaveChanges();

         Desenvolvedor[] GetAllDesenvolvedores(bool includeProjetos = false);

         Desenvolvedor[] GetAllDesenvolvedoresByProjetoId(int ProjetoId, bool includeProjetos = false);

         Desenvolvedor GetDesenvolvedorById(int DesenvolvedorId, bool includeProjetos = false);

         Desenvolvedor GetDesenvolvedorByName(string nome, bool includeProjetos = false);

         Projeto[] GetAllProjetos(bool includeDesenvolvedor = false);

         Projeto[] GetAllProjetosByDesenvolvedorId(int devId,bool includeDesenvolvedor = false);

         Projeto GetProjetoById(int projetoId, bool includeDesenvolvedor = false);

         Projeto GetProjetoByNama(string nome, bool includeDesenvolvedor = false);

    }
}