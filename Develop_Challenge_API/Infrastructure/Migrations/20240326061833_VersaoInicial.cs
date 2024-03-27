using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestrutura.Migrations
{
    public partial class VersaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "DevelopChallenge");

            migrationBuilder.CreateTable(
                name: "Clima",
                schema: "DevelopChallenge",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntidadeClimaCidadeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Condicao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CondicaoDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Min = table.Column<int>(type: "int", nullable: false),
                    Max = table.Column<int>(type: "int", nullable: false),
                    IndiceUv = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clima", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClimaAeroporto",
                schema: "DevelopChallenge",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Umidade = table.Column<int>(type: "int", nullable: false),
                    Visibilidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoIcao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PressaoAtmosferica = table.Column<int>(type: "int", nullable: false),
                    Vento = table.Column<int>(type: "int", nullable: false),
                    DirecaoVento = table.Column<int>(type: "int", nullable: false),
                    Condicao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CondicaoDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Temp = table.Column<int>(type: "int", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClimaAeroporto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClimaCidade",
                schema: "DevelopChallenge",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClimaCidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogErro",
                schema: "DevelopChallenge",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conteudo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MensagemErro = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogErro", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clima",
                schema: "DevelopChallenge");

            migrationBuilder.DropTable(
                name: "ClimaAeroporto",
                schema: "DevelopChallenge");

            migrationBuilder.DropTable(
                name: "ClimaCidade",
                schema: "DevelopChallenge");

            migrationBuilder.DropTable(
                name: "LogErro",
                schema: "DevelopChallenge");
        }
    }
}
