using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeTracker.WebAPI.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LacamentosHoras",
                columns: new[] { "DesenvolvedorId", "ProjetoId", "DataFim", "DataInicio", "Id" },
                values: new object[] { 1, 1, new DateTime(2020, 12, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "LacamentosHoras",
                columns: new[] { "DesenvolvedorId", "ProjetoId", "DataFim", "DataInicio", "Id" },
                values: new object[] { 2, 2, new DateTime(2020, 12, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "LacamentosHoras",
                columns: new[] { "DesenvolvedorId", "ProjetoId", "DataFim", "DataInicio", "Id" },
                values: new object[] { 3, 1, new DateTime(2020, 12, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "LacamentosHoras",
                columns: new[] { "DesenvolvedorId", "ProjetoId", "DataFim", "DataInicio", "Id" },
                values: new object[] { 4, 4, new DateTime(2020, 12, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "LacamentosHoras",
                columns: new[] { "DesenvolvedorId", "ProjetoId", "DataFim", "DataInicio", "Id" },
                values: new object[] { 5, 2, new DateTime(2020, 12, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.InsertData(
                table: "LacamentosHoras",
                columns: new[] { "DesenvolvedorId", "ProjetoId", "DataFim", "DataInicio", "Id" },
                values: new object[] { 6, 1, new DateTime(2020, 12, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.InsertData(
                table: "LacamentosHoras",
                columns: new[] { "DesenvolvedorId", "ProjetoId", "DataFim", "DataInicio", "Id" },
                values: new object[] { 7, 1, new DateTime(2020, 12, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LacamentosHoras",
                keyColumns: new[] { "DesenvolvedorId", "ProjetoId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "LacamentosHoras",
                keyColumns: new[] { "DesenvolvedorId", "ProjetoId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "LacamentosHoras",
                keyColumns: new[] { "DesenvolvedorId", "ProjetoId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "LacamentosHoras",
                keyColumns: new[] { "DesenvolvedorId", "ProjetoId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "LacamentosHoras",
                keyColumns: new[] { "DesenvolvedorId", "ProjetoId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "LacamentosHoras",
                keyColumns: new[] { "DesenvolvedorId", "ProjetoId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "LacamentosHoras",
                keyColumns: new[] { "DesenvolvedorId", "ProjetoId" },
                keyValues: new object[] { 7, 1 });
        }
    }
}
