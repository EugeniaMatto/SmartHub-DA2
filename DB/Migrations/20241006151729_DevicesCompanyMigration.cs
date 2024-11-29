using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHub.DB.Migrations;

/// <inheritdoc />
public partial class DevicesCompanyMigration : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropIndex(
            name: "IX_Companies_OwnerId",
            table: "Companies");

        migrationBuilder.AddColumn<DateTime>(
            name: "CreatedAt",
            table: "Devices",
            type: "datetime2",
            nullable: false,
            defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        migrationBuilder.AddColumn<string>(
            name: "Description",
            table: "Devices",
            type: "nvarchar(max)",
            nullable: false,
            defaultValue: string.Empty);

        migrationBuilder.AddColumn<Guid>(
            name: "DeviceId",
            table: "Devices",
            type: "uniqueidentifier",
            nullable: true);

        migrationBuilder.AddColumn<string>(
            name: "Model",
            table: "Devices",
            type: "nvarchar(max)",
            nullable: false,
            defaultValue: string.Empty);

        migrationBuilder.AddColumn<string>(
            name: "Type",
            table: "Devices",
            type: "nvarchar(max)",
            nullable: false,
            defaultValue: string.Empty);

        migrationBuilder.CreateIndex(
            name: "IX_Devices_DeviceId",
            table: "Devices",
            column: "DeviceId");

        migrationBuilder.CreateIndex(
            name: "IX_Companies_OwnerId",
            table: "Companies",
            column: "OwnerId",
            unique: true);

        migrationBuilder.AddForeignKey(
            name: "FK_Devices_Devices_DeviceId",
            table: "Devices",
            column: "DeviceId",
            principalTable: "Devices",
            principalColumn: "Id");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Devices_Devices_DeviceId",
            table: "Devices");

        migrationBuilder.DropIndex(
            name: "IX_Devices_DeviceId",
            table: "Devices");

        migrationBuilder.DropIndex(
            name: "IX_Companies_OwnerId",
            table: "Companies");

        migrationBuilder.DropColumn(
            name: "CreatedAt",
            table: "Devices");

        migrationBuilder.DropColumn(
            name: "Description",
            table: "Devices");

        migrationBuilder.DropColumn(
            name: "DeviceId",
            table: "Devices");

        migrationBuilder.DropColumn(
            name: "Model",
            table: "Devices");

        migrationBuilder.DropColumn(
            name: "Type",
            table: "Devices");

        migrationBuilder.CreateIndex(
            name: "IX_Companies_OwnerId",
            table: "Companies",
            column: "OwnerId");
    }
}
