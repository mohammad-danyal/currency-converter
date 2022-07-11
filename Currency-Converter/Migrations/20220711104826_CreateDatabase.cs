using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace currency_converter.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Audit",
                columns: table => new
                {
                    ConversionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GBPValue = table.Column<double>(type: "REAL", nullable: false),
                    ConvertedValue = table.Column<double>(type: "REAL", nullable: false),
                    CurrencyConvertedTo = table.Column<string>(type: "TEXT", nullable: true),
                    ConversionDateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audit", x => x.ConversionId);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    CurrencyId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CurrencyName = table.Column<string>(type: "TEXT", nullable: true),
                    Multiplier = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.CurrencyId);
                });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CurrencyId", "CurrencyName", "Multiplier" },
                values: new object[] { 1, "AUD", 1.76 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CurrencyId", "CurrencyName", "Multiplier" },
                values: new object[] { 2, "EUR", 1.1699999999999999 });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "CurrencyId", "CurrencyName", "Multiplier" },
                values: new object[] { 3, "USD", 1.2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audit");

            migrationBuilder.DropTable(
                name: "Currency");
        }
    }
}
