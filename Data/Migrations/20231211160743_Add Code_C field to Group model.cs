using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gu.Process.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCode_CfieldtoGroupmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<char>(
                name: "Code_C",
                table: "Groups",
                type: "character(1)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code_C",
                table: "Groups");
        }
    }
}
