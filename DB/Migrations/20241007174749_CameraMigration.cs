using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHub.DB.Migrations;

/// <inheritdoc />
public partial class CameraMigration : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<string>(
            name: "CamSupportedActionsJson",
            table: "Devices",
            type: "nvarchar(max)",
            nullable: true);

        migrationBuilder.AddColumn<string>(
            name: "DeviceType",
            table: "Devices",
            type: "nvarchar(13)",
            maxLength: 13,
            nullable: false,
            defaultValue: string.Empty);

        migrationBuilder.AddColumn<string>(
            name: "UseTypeJson",
            table: "Devices",
            type: "nvarchar(max)",
            nullable: true);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "CamSupportedActionsJson",
            table: "Devices");

        migrationBuilder.DropColumn(
            name: "DeviceType",
            table: "Devices");

        migrationBuilder.DropColumn(
            name: "UseTypeJson",
            table: "Devices");
    }
}
