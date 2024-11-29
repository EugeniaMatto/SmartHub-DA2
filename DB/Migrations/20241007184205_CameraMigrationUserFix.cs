using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHub.DB.Migrations;

/// <inheritdoc />
public partial class CameraMigrationUserFix : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateIndex(
            name: "IX_User_CompanyId",
            table: "User",
            column: "CompanyId");

        migrationBuilder.AddForeignKey(
            name: "FK_User_Companies_CompanyId",
            table: "User",
            column: "CompanyId",
            principalTable: "Companies",
            principalColumn: "Id");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_User_Companies_CompanyId",
            table: "User");

        migrationBuilder.DropIndex(
            name: "IX_User_CompanyId",
            table: "User");
    }
}
