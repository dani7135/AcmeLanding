using Microsoft.EntityFrameworkCore.Migrations;

namespace AcmeLanding.Data.Migrations
{
    public partial class _draw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Winner",
                table: "Submission_Model",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Winner",
                table: "Submission_Model");
        }
    }
}
