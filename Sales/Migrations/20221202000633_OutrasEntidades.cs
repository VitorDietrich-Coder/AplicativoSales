using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sales.Migrations
{
    public partial class OutrasEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vendedores",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    dataAniversario = table.Column<DateTime>(nullable: false),
                    salarioBase = table.Column<double>(nullable: false),
                    departamentosId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedores", x => x.id);
                    table.ForeignKey(
                        name: "FK_Vendedores_Departamento_departamentosId",
                        column: x => x.departamentosId,
                        principalTable: "Departamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecordeVendas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    data = table.Column<DateTime>(nullable: false),
                    quantidade = table.Column<double>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    vendedoresid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordeVendas", x => x.id);
                    table.ForeignKey(
                        name: "FK_RecordeVendas_Vendedores_vendedoresid",
                        column: x => x.vendedoresid,
                        principalTable: "Vendedores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecordeVendas_vendedoresid",
                table: "RecordeVendas",
                column: "vendedoresid");

            migrationBuilder.CreateIndex(
                name: "IX_Vendedores_departamentosId",
                table: "Vendedores",
                column: "departamentosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecordeVendas");

            migrationBuilder.DropTable(
                name: "Vendedores");
        }
    }
}
