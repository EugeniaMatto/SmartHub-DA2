using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHub.DB.Migrations;

/// <inheritdoc />
public partial class DevicePhotoListMigration : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Devices_Devices_DeviceId",
            table: "Devices");

        migrationBuilder.DropIndex(
            name: "IX_Devices_DeviceId",
            table: "Devices");

        migrationBuilder.DropColumn(
            name: "DeviceId",
            table: "Devices");

        migrationBuilder.AddColumn<string>(
            name: "PhotosJson",
            table: "Devices",
            type: "nvarchar(max)",
            nullable: false,
            defaultValue: string.Empty);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "PhotosJson",
            table: "Devices");

        migrationBuilder.AddColumn<Guid>(
            name: "DeviceId",
            table: "Devices",
            type: "uniqueidentifier",
            nullable: true);

        migrationBuilder.CreateIndex(
            name: "IX_Devices_DeviceId",
            table: "Devices",
            column: "DeviceId");

        migrationBuilder.AddForeignKey(
            name: "FK_Devices_Devices_DeviceId",
            table: "Devices",
            column: "DeviceId",
            principalTable: "Devices",
            principalColumn: "Id");
    }
}
