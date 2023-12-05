using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternetBanking.Migrations
{
    /// <inheritdoc />
    public partial class fixrelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Accounts_AccountNumber",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "AccountNumber",
                table: "Transactions",
                newName: "SenderAccountAccountNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_AccountNumber",
                table: "Transactions",
                newName: "IX_Transactions_SenderAccountAccountNumber");

            migrationBuilder.AddColumn<string>(
                name: "AccountNumber1",
                table: "OTPs",
                type: "nvarchar(20)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OTPs_AccountNumber1",
                table: "OTPs",
                column: "AccountNumber1");

            migrationBuilder.CreateIndex(
                name: "IX_OTPs_TransactionId",
                table: "OTPs",
                column: "TransactionId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OTPs_Accounts_AccountNumber1",
                table: "OTPs",
                column: "AccountNumber1",
                principalTable: "Accounts",
                principalColumn: "AccountNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_OTPs_Transactions_TransactionId",
                table: "OTPs",
                column: "TransactionId",
                principalTable: "Transactions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Accounts_SenderAccountAccountNumber",
                table: "Transactions",
                column: "SenderAccountAccountNumber",
                principalTable: "Accounts",
                principalColumn: "AccountNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OTPs_Accounts_AccountNumber1",
                table: "OTPs");

            migrationBuilder.DropForeignKey(
                name: "FK_OTPs_Transactions_TransactionId",
                table: "OTPs");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Accounts_SenderAccountAccountNumber",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_OTPs_AccountNumber1",
                table: "OTPs");

            migrationBuilder.DropIndex(
                name: "IX_OTPs_TransactionId",
                table: "OTPs");

            migrationBuilder.DropColumn(
                name: "AccountNumber1",
                table: "OTPs");

            migrationBuilder.RenameColumn(
                name: "SenderAccountAccountNumber",
                table: "Transactions",
                newName: "AccountNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_SenderAccountAccountNumber",
                table: "Transactions",
                newName: "IX_Transactions_AccountNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Accounts_AccountNumber",
                table: "Transactions",
                column: "AccountNumber",
                principalTable: "Accounts",
                principalColumn: "AccountNumber");
        }
    }
}
