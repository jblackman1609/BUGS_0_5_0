using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BUGS.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Purchaser = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    CustStreetAdd = table.Column<string>(type: "TEXT", nullable: false),
                    CustCity = table.Column<string>(type: "TEXT", nullable: false),
                    CustState = table.Column<string>(type: "TEXT", nullable: false),
                    CustZipCode = table.Column<string>(type: "TEXT", nullable: false),
                    PropDescription = table.Column<string>(type: "TEXT", nullable: false),
                    BondType = table.Column<string>(type: "TEXT", nullable: false),
                    PropStreetAdd = table.Column<string>(type: "TEXT", nullable: false),
                    PropCity = table.Column<string>(type: "TEXT", nullable: false),
                    PropState = table.Column<string>(type: "TEXT", nullable: false),
                    PropZipCode = table.Column<string>(type: "TEXT", nullable: false),
                    EffectiveDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ThroughDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ContractPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    RenewalFee = table.Column<decimal>(type: "TEXT", nullable: false),
                    TransferFee = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contracts");
        }
    }
}
