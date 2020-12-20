using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TimeTracker.WebAPI.Models;

namespace TimeTracker.WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Desenvolvedor> Desenvolvedores { get; set; }

        public DbSet<Projeto> Projetos { get; set; }

        public DbSet<LancamentoHoras> LacamentosHoras { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<LancamentoHoras>()
                .HasKey(x => new {x.DesenvolvedorId, x.ProjetoId});
            
            //Just for initial tests
            builder.Entity<Projeto>()
                .HasData(new List<Projeto>{
                    new Projeto(1, "WebAPI", ""),
                    new Projeto(2, "WebForms", ""),
                    new Projeto(3, "AspNetMVC", ""),
                    new Projeto(4, "Inglês", ""),
                    new Projeto(5, "LogicaProgramacao", "")
                });
            
            builder.Entity<Desenvolvedor>()
                .HasData(new List<Desenvolvedor>(){
                    new Desenvolvedor(1, "Marta", "Kent@gmail.com", "33225555"),
                    new Desenvolvedor(2, "Paula", "Isabela@gmail.com", "3354288"),
                    new Desenvolvedor(3, "Laura", "Antonia@gmail.com", "55668899"),
                    new Desenvolvedor(4, "Luiza", "Maria@gmail.com", "6565659"),
                    new Desenvolvedor(5, "Lucas", "Machado@gmail.com", "565685415"),
                    new Desenvolvedor(6, "Pedro", "Alvares@gmail.com", "456454545"),
                    new Desenvolvedor(7, "Paulo", "José@gmail.com", "9874512")
                });

        }
    }
}