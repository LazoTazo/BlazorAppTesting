using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppTesting.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pendientes",
                columns: table => new
                {
                    PendienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    c_descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    f_createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    n_priodidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pendientes", x => x.PendienteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pendientes");
        }
    }
}
