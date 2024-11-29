using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHub.DB.Migrations;

/// <inheritdoc />
public partial class FixCompanyIdUserMigration : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_User_Companies_CompanyId",
            table: "User");

        migrationBuilder.DropIndex(
            name: "IX_User_CompanyId",
            table: "User");

        migrationBuilder.DropColumn(
            name: "CompanyId",
            table: "User");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<Guid>(
            name: "CompanyId",
            table: "User",
            type: "uniqueidentifier",
            nullable: true);

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
}
