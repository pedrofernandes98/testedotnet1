using System;

namespace TimeTracker.WebAPI.Models
{
    public class LancamentoHoras
    {
        public LancamentoHoras()
        {

        }
        public LancamentoHoras(int id, DateTime dataInicio, DateTime dataFim, int desenvolvedorId, Desenvolvedor desenvolvedor, int projetoId, Projeto projeto)
        {
            this.Id = id;
            this.DataInicio = dataInicio;
            this.DataFim = dataFim;
            this.DesenvolvedorId = desenvolvedorId;
            this.Desenvolvedor = desenvolvedor;
            this.ProjetoId = projetoId;
            this.Projeto = projeto;
        }
        public int Id { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public int DesenvolvedorId { get; set; }

        public Desenvolvedor Desenvolvedor { get; set; }

        //Como na especificação do projeto traz apenas os requisitos mínimos do Lançamento de Horas, tomei a liberdade de colocar 
        //as propriedades do projeto no lançamento de horas, a fim de facilitar o relacionamento
        public int ProjetoId { get; set; }

        public Projeto Projeto { get; set; }
    }
}