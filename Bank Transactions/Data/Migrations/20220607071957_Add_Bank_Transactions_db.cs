using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bank_Transactions.Data.Migrations
{
    public partial class Add_Bank_Transactions_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionId = table.Column<int>(nullable: false),
                    AccountNumber = table.Column<string>(nullable: true),
                    BeneficiaryName = table.Column<string>(nullable: true),
                    BankName = table.Column<string>(nullable: true),
                    SWIFTCode = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
