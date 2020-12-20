using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeTracker.WebAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Desenvolvedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desenvolvedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projetos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projetos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LacamentosHoras",
                columns: table => new
                {
                    DesenvolvedorId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProjetoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataFim = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LacamentosHoras", x => new { x.DesenvolvedorId, x.ProjetoId });
                    table.ForeignKey(
                        name: "FK_LacamentosHoras_Desenvolvedores_DesenvolvedorId",
                        column: x => x.DesenvolvedorId,
                        principalTable: "Desenvolvedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LacamentosHoras_Projetos_ProjetoId",
                        column: x => x.ProjetoId,
                        principalTable: "Projetos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Desenvolvedores",
                columns: new[] { "Id", "Email", "Nome", "Telefone" },
                values: new object[] { 1, "Kent@gmail.com", "Marta", "33225555" });

            migrationBuilder.InsertData(
                table: "Desenvolvedores",
                columns: new[] { "Id", "Email", "Nome", "Telefone" },
                values: new object[] { 2, "Isabela@gmail.com", "Paula", "3354288" });

            migrationBuilder.InsertData(
                table: "Desenvolvedores",
                columns: new[] { "Id", "Email", "Nome", "Telefone" },
                values: new object[] { 3, "Antonia@gmail.com", "Laura", "55668899" });

            migrationBuilder.InsertData(
                table: "Desenvolvedores",
                columns: new[] { "Id", "Email", "Nome", "Telefone" },
                values: new object[] { 4, "Maria@gmail.com", "Luiza", "6565659" });

            migrationBuilder.InsertData(
                table: "Desenvolvedores",
                columns: new[] { "Id", "Email", "Nome", "Telefone" },
                values: new object[] { 5, "Machado@gmail.com", "Lucas", "565685415" });

            migrationBuilder.InsertData(
                table: "Desenvolvedores",
                columns: new[] { "Id", "Email", "Nome", "Telefone" },
                values: new object[] { 6, "Alvares@gmail.com", "Pedro", "456454545" });

            migrationBuilder.InsertData(
                table: "Desenvolvedores",
                columns: new[] { "Id", "Email", "Nome", "Telefone" },
                values: new object[] { 7, "José@gmail.com", "Paulo", "9874512" });

            migrationBuilder.InsertData(
                table: "Projetos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 1, "", "WebAPI" });

            migrationBuilder.InsertData(
                table: "Projetos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 2, "", "WebForms" });

            migrationBuilder.InsertData(
                table: "Projetos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 3, "", "AspNetMVC" });

            migrationBuilder.InsertData(
                table: "Projetos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 4, "", "Inglês" });

            migrationBuilder.InsertData(
                table: "Projetos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 5, "", "LogicaProgramacao" });

            migrationBuilder.CreateIndex(
                name: "IX_LacamentosHoras_ProjetoId",
                table: "LacamentosHoras",
                column: "ProjetoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LacamentosHoras");

            migrationBuilder.DropTable(
                name: "Desenvolvedores");

            migrationBuilder.DropTable(
                name: "Projetos");
        }
    }
}
