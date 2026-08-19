using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Festpay.Onboarding.Infra.Migrations
{
    /// <inheritdoc />
    public partial class EntityTrasacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    IdContaOrigem = table.Column<Guid>(type: "TEXT", nullable: false),
                    IdContaDestino = table.Column<Guid>(type: "TEXT", nullable: false),
                    Valor = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    CreatedUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeactivatedUtc = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transacao_Accounts_IdContaDestino",
                        column: x => x.IdContaDestino,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transacao_Accounts_IdContaOrigem",
                        column: x => x.IdContaOrigem,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transacao_IdContaDestino",
                table: "Transacao",
                column: "IdContaDestino");

            migrationBuilder.CreateIndex(
                name: "IX_Transacao_IdContaOrigem",
                table: "Transacao",
                column: "IdContaOrigem");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transacao");
        }
    }
}
