using System;
using System.Collections.Generic;
namespace TimeTracker.WebAPI.Models
{
    public class Desenvolvedor
    {
        public Desenvolvedor()
        {

        }
        public Desenvolvedor(int id, string nome, string email, string telefone)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
            //this.Auditoria_DataCadastro = auditoria_DataCadastro;

        }
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        //public DateTime Auditoria_DataCadastro { get; set; }

        public IEnumerable<LancamentoHoras> Lancamentos_Horas { get; set; }

    }
}