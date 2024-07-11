using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DebtTrack.Persistence.Migrations
{
    public partial class update_transaction_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transactions_users_creditor_id",
                table: "transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_transactions_users_debtor_id",
                table: "transactions");

            migrationBuilder.RenameColumn(
                name: "debtor_id",
                table: "transactions",
                newName: "participant_id");

            migrationBuilder.RenameColumn(
                name: "creditor_id",
                table: "transactions",
                newName: "activity_id");

            migrationBuilder.RenameIndex(
                name: "IX_transactions_debtor_id",
                table: "transactions",
                newName: "IX_transactions_participant_id");

            migrationBuilder.RenameIndex(
                name: "IX_transactions_creditor_id",
                table: "transactions",
                newName: "IX_transactions_activity_id");

            migrationBuilder.AddForeignKey(
                name: "FK_transactions_users_activity_id",
                table: "transactions",
                column: "activity_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transactions_users_participant_id",
                table: "transactions",
                column: "participant_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transactions_users_activity_id",
                table: "transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_transactions_users_participant_id",
                table: "transactions");

            migrationBuilder.RenameColumn(
                name: "participant_id",
                table: "transactions",
                newName: "debtor_id");

            migrationBuilder.RenameColumn(
                name: "activity_id",
                table: "transactions",
                newName: "creditor_id");

            migrationBuilder.RenameIndex(
                name: "IX_transactions_participant_id",
                table: "transactions",
                newName: "IX_transactions_debtor_id");

            migrationBuilder.RenameIndex(
                name: "IX_transactions_activity_id",
                table: "transactions",
                newName: "IX_transactions_creditor_id");

            migrationBuilder.AddForeignKey(
                name: "FK_transactions_users_creditor_id",
                table: "transactions",
                column: "creditor_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transactions_users_debtor_id",
                table: "transactions",
                column: "debtor_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
