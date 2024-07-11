using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DebtTrack.Persistence.Migrations
{
    public partial class add_total_amout_to_be_paid_field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "total_amount_to_be_paid",
                table: "transactions",
                type: "numeric",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "total_amount_to_be_paid",
                table: "transactions");
        }
    }
}
