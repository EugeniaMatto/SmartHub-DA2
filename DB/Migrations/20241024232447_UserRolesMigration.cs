using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHub.DB.Migrations;

/// <inheritdoc />
public partial class UserRolesMigration : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "Role",
            table: "User");

        migrationBuilder.AddColumn<string>(
            name: "RolesJson",
            table: "User",
            type: "nvarchar(max)",
            nullable: false,
            defaultValue: string.Empty);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "RolesJson",
            table: "User");

        migrationBuilder.AddColumn<int>(
            name: "Role",
            table: "User",
            type: "int",
            nullable: false,
            defaultValue: 0);
    }
}
