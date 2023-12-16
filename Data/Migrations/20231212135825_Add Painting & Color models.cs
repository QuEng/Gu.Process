using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gu.Process.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPaintingColormodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ColorIds",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColorIds",
                table: "Products");
        }
    }
}
