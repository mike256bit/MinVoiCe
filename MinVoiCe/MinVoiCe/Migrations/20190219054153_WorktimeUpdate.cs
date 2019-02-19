using Microsoft.EntityFrameworkCore.Migrations;

namespace MinVoiCe.Migrations
{
    public partial class WorktimeUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IncludeInNextInvoice",
                table: "Worktimes",
                newName: "OpenStatus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OpenStatus",
                table: "Worktimes",
                newName: "IncludeInNextInvoice");
        }
    }
}
