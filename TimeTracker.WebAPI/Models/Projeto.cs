using System;
using System.Collections.Generic;

namespace TimeTracker.WebAPI.Models
{
    public class Projeto
    {
        public Projeto()
        {

        }

        public Projeto(int id, string nome, string descricao)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            //this.Auditoria_DataCadastro = auditoria_DataCadastro;
        }
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        //public DateTime Auditoria_DataCadastro { get; set; }

        public IEnumerable<LancamentoHoras> Lancamentos_Horas { get; set; }

    }
}