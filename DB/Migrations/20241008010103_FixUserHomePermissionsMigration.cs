using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHub.DB.Migrations;

/// <inheritdoc />
public partial class FixUserHomePermissionsMigration : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.RenameColumn(
            name: "Permissions",
            table: "UserHomePermissions",
            newName: "PermissionsJson");

        migrationBuilder.AddColumn<string>(
            name: "UserEmail",
            table: "Notifications",
            type: "nvarchar(max)",
            nullable: false,
            defaultValue: string.Empty);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "UserEmail",
            table: "Notifications");

        migrationBuilder.RenameColumn(
            name: "PermissionsJson",
            table: "UserHomePermissions",
            newName: "Permissions");
    }
}
