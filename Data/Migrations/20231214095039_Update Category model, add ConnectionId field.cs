using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gu.Process.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategorymodeladdConnectionIdfield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ConnectionId",
                table: "Categories",
                type: "uuid",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConnectionId",
                table: "Categories");
        }
    }
}
