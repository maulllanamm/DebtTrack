using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DebtTrack.Persistence.Migrations
{
    public partial class fix_forign_key_transaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transactions_users_activity_id",
                table: "transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_transactions_users_participant_id",
                table: "transactions");

            migrationBuilder.AddForeignKey(
                name: "FK_transactions_activities_activity_id",
                table: "transactions",
                column: "activity_id",
                principalTable: "activities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transactions_participants_participant_id",
                table: "transactions",
                column: "participant_id",
                principalTable: "participants",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transactions_activities_activity_id",
                table: "transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_transactions_participants_participant_id",
                table: "transactions");

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
    }
}
