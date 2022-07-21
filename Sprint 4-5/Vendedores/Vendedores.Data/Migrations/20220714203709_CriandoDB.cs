using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vendedores.Data.Migrations
{
    public partial class CriandoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vendedores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DocIdentificacao = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VendedoresAlteracaos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VendedorPorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EstadoPreAlteracao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendedoresAlteracaos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendedoresAlteracaos_Vendedores_VendedorPorId",
                        column: x => x.VendedorPorId,
                        principalTable: "Vendedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VendedoresAlteracaos_VendedorPorId",
                table: "VendedoresAlteracaos",
                column: "VendedorPorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendedoresAlteracaos");

            migrationBuilder.DropTable(
                name: "Vendedores");
        }
    }
}
