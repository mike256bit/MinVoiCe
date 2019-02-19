using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MinVoiCe.Migrations
{
    public partial class WorktimesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Clients_ClientId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Projects",
                newName: "ClientID");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_ClientId",
                table: "Projects",
                newName: "IX_Projects_ClientID");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Clients",
                newName: "ClientID");

            migrationBuilder.AlterColumn<int>(
                name: "ClientID",
                table: "Projects",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Worktimes",
                columns: table => new
                {
                    WorktimeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Hours = table.Column<double>(nullable: false),
                    WeekRange = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Amount = table.Column<double>(nullable: false),
                    IncludeInNextInvoice = table.Column<bool>(nullable: false),
                    ProjectID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worktimes", x => x.WorktimeID);
                    table.ForeignKey(
                        name: "FK_Worktimes_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Worktimes_ProjectID",
                table: "Worktimes",
                column: "ProjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Clients_ClientID",
                table: "Projects",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "ClientID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Clients_ClientID",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "Worktimes");

            migrationBuilder.RenameColumn(
                name: "ClientID",
                table: "Projects",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_ClientID",
                table: "Projects",
                newName: "IX_Projects_ClientId");

            migrationBuilder.RenameColumn(
                name: "ClientID",
                table: "Clients",
                newName: "ClientId");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Projects",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Clients_ClientId",
                table: "Projects",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
