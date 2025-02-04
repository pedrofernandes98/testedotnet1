﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimeTracker.WebAPI.Data;

namespace TimeTracker.WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201224013350_v2")]
    partial class v2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("TimeTracker.WebAPI.Models.Desenvolvedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Desenvolvedores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Kent@gmail.com",
                            Nome = "Marta",
                            Telefone = "33225555"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Isabela@gmail.com",
                            Nome = "Paula",
                            Telefone = "3354288"
                        },
                        new
                        {
                            Id = 3,
                            Email = "Antonia@gmail.com",
                            Nome = "Laura",
                            Telefone = "55668899"
                        },
                        new
                        {
                            Id = 4,
                            Email = "Maria@gmail.com",
                            Nome = "Luiza",
                            Telefone = "6565659"
                        },
                        new
                        {
                            Id = 5,
                            Email = "Machado@gmail.com",
                            Nome = "Lucas",
                            Telefone = "565685415"
                        },
                        new
                        {
                            Id = 6,
                            Email = "Alvares@gmail.com",
                            Nome = "Pedro",
                            Telefone = "456454545"
                        },
                        new
                        {
                            Id = 7,
                            Email = "José@gmail.com",
                            Nome = "Paulo",
                            Telefone = "9874512"
                        });
                });

            modelBuilder.Entity("TimeTracker.WebAPI.Models.LancamentoHoras", b =>
                {
                    b.Property<int>("DesenvolvedorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProjetoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("TEXT");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.HasKey("DesenvolvedorId", "ProjetoId");

                    b.HasIndex("ProjetoId");

                    b.ToTable("LacamentosHoras");

                    b.HasData(
                        new
                        {
                            DesenvolvedorId = 1,
                            ProjetoId = 1,
                            DataFim = new DateTime(2020, 12, 23, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicio = new DateTime(2020, 12, 23, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = 1
                        },
                        new
                        {
                            DesenvolvedorId = 2,
                            ProjetoId = 2,
                            DataFim = new DateTime(2020, 12, 23, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicio = new DateTime(2020, 12, 23, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = 2
                        },
                        new
                        {
                            DesenvolvedorId = 3,
                            ProjetoId = 1,
                            DataFim = new DateTime(2020, 12, 23, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicio = new DateTime(2020, 12, 23, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = 3
                        },
                        new
                        {
                            DesenvolvedorId = 4,
                            ProjetoId = 4,
                            DataFim = new DateTime(2020, 12, 23, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicio = new DateTime(2020, 12, 23, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = 4
                        },
                        new
                        {
                            DesenvolvedorId = 5,
                            ProjetoId = 2,
                            DataFim = new DateTime(2020, 12, 23, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicio = new DateTime(2020, 12, 23, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = 5
                        },
                        new
                        {
                            DesenvolvedorId = 6,
                            ProjetoId = 1,
                            DataFim = new DateTime(2020, 12, 23, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicio = new DateTime(2020, 12, 23, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = 6
                        },
                        new
                        {
                            DesenvolvedorId = 7,
                            ProjetoId = 1,
                            DataFim = new DateTime(2020, 12, 23, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicio = new DateTime(2020, 12, 23, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = 7
                        });
                });

            modelBuilder.Entity("TimeTracker.WebAPI.Models.Projeto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Projetos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "",
                            Nome = "WebAPI"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "",
                            Nome = "WebForms"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "",
                            Nome = "AspNetMVC"
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "",
                            Nome = "Inglês"
                        },
                        new
                        {
                            Id = 5,
                            Descricao = "",
                            Nome = "LogicaProgramacao"
                        });
                });

            modelBuilder.Entity("TimeTracker.WebAPI.Models.LancamentoHoras", b =>
                {
                    b.HasOne("TimeTracker.WebAPI.Models.Desenvolvedor", "Desenvolvedor")
                        .WithMany("Lancamentos_Horas")
                        .HasForeignKey("DesenvolvedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TimeTracker.WebAPI.Models.Projeto", "Projeto")
                        .WithMany("Lancamentos_Horas")
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Desenvolvedor");

                    b.Navigation("Projeto");
                });

            modelBuilder.Entity("TimeTracker.WebAPI.Models.Desenvolvedor", b =>
                {
                    b.Navigation("Lancamentos_Horas");
                });

            modelBuilder.Entity("TimeTracker.WebAPI.Models.Projeto", b =>
                {
                    b.Navigation("Lancamentos_Horas");
                });
#pragma warning restore 612, 618
        }
    }
}
