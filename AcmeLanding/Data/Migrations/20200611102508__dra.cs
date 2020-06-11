using Microsoft.EntityFrameworkCore.Migrations;

namespace AcmeLanding.Data.Migrations
{
    public partial class _dra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Winner",
                table: "Submission_Model",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Winner",
                table: "Submission_Model",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
