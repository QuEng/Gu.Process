using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gu.Process.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameCodesfieldsinGroupandSubGroupmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Code_B",
                table: "SubGroups",
                newName: "Code_C");

            migrationBuilder.RenameColumn(
                name: "Code_C",
                table: "Groups",
                newName: "Code_B");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Code_C",
                table: "SubGroups",
                newName: "Code_B");

            migrationBuilder.RenameColumn(
                name: "Code_B",
                table: "Groups",
                newName: "Code_C");
        }
    }
}
