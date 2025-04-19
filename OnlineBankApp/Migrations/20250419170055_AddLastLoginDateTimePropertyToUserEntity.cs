using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineBankApp.Migrations
{
    /// <inheritdoc />
    public partial class AddLastLoginDateTimePropertyToUserEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastLoginDateTime",
                table: "users",
                type: "datetime(6)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastLoginDateTime",
                table: "users");
        }
    }
}
