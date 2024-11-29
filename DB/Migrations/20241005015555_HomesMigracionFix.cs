using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHub.DB.Migrations;

/// <inheritdoc />
public partial class HomesMigracionFix : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<Guid>(
            name: "DeviceId",
            table: "Hardwares",
            type: "uniqueidentifier",
            nullable: false,
            defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

        migrationBuilder.CreateIndex(
            name: "IX_Hardwares_DeviceId",
            table: "Hardwares",
            column: "DeviceId");

        migrationBuilder.AddForeignKey(
            name: "FK_Hardwares_Devices_DeviceId",
            table: "Hardwares",
            column: "DeviceId",
            principalTable: "Devices",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Hardwares_Devices_DeviceId",
            table: "Hardwares");

        migrationBuilder.DropIndex(
            name: "IX_Hardwares_DeviceId",
            table: "Hardwares");

        migrationBuilder.DropColumn(
            name: "DeviceId",
            table: "Hardwares");
    }
}
