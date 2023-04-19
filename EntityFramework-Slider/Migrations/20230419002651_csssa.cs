using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_Slider.Migrations
{
    public partial class csssa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Experts",
                table: "Experts");

            migrationBuilder.RenameTable(
                name: "Experts",
                newName: "FloExperts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FloExperts",
                table: "FloExperts",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FloExperts",
                table: "FloExperts");

            migrationBuilder.RenameTable(
                name: "FloExperts",
                newName: "Experts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Experts",
                table: "Experts",
                column: "Id");
        }
    }
}
