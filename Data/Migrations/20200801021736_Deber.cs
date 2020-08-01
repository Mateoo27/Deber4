﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace VintageStuff.Data.Migrations
{
    public partial class Deber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    NombreCompleto = table.Column<string>(nullable: true),
                    Telefono = table.Column<int>(nullable: false),
                    Correo = table.Column<string>(nullable: true),
                    ImagenPerfil = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
