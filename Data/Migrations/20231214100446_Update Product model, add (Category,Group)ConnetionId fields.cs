using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gu.Process.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductmodeladdCategoryGroupConnetionIdfields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CategoryConnectionId",
                table: "Products",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "GroupConnectionId",
                table: "Products",
                type: "uuid",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryConnectionId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "GroupConnectionId",
                table: "Products");
        }
    }
}
