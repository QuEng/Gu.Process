using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gu.Process.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPaintingIdsfieldtoProductmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PaintingIds",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaintingIds",
                table: "Products");
        }
    }
}
