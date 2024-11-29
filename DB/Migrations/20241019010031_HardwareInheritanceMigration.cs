using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHub.DB.Migrations;

/// <inheritdoc />
public partial class HardwareInheritanceMigration : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<string>(
            name: "HardwareType",
            table: "Hardwares",
            type: "nvarchar(13)",
            maxLength: 13,
            nullable: false,
            defaultValue: string.Empty);

        migrationBuilder.AddColumn<bool>(
            name: "IsOn",
            table: "Hardwares",
            type: "bit",
            nullable: true);

        migrationBuilder.AddColumn<bool>(
            name: "IsOpen",
            table: "Hardwares",
            type: "bit",
            nullable: true);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "HardwareType",
            table: "Hardwares");

        migrationBuilder.DropColumn(
            name: "IsOn",
            table: "Hardwares");

        migrationBuilder.DropColumn(
            name: "IsOpen",
            table: "Hardwares");
    }
}
