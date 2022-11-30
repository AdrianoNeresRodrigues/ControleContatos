using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleContatos.Migrations
{
    public partial class UsuarioModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ContatoModel",
                table: "ContatoModel");

            migrationBuilder.RenameTable(
                name: "ContatoModel",
                newName: "Contatos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contatos",
                table: "Contatos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perfil = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualização = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contatos",
                table: "Contatos");

            migrationBuilder.RenameTable(
                name: "Contatos",
                newName: "ContatoModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContatoModel",
                table: "ContatoModel",
                column: "Id");
        }
    }
}
