using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHub.DB.Migrations;

/// <inheritdoc />
public partial class NotificationFixedMigration : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Hardwares_Devices_DeviceId",
            table: "Hardwares");

        migrationBuilder.DropForeignKey(
            name: "FK_Notifications_Devices_DeviceId",
            table: "Notifications");

        migrationBuilder.DropForeignKey(
            name: "FK_Notifications_User_UserId",
            table: "Notifications");

        migrationBuilder.RenameColumn(
            name: "DeviceId",
            table: "Notifications",
            newName: "HardwareId");

        migrationBuilder.RenameIndex(
            name: "IX_Notifications_DeviceId",
            table: "Notifications",
            newName: "IX_Notifications_HardwareId");

        migrationBuilder.AlterColumn<int>(
            name: "Role",
            table: "User",
            type: "int",
            nullable: false,
            oldClrType: typeof(string),
            oldType: "nvarchar(max)");

        migrationBuilder.AddColumn<Guid>(
            name: "CompanyId",
            table: "User",
            type: "uniqueidentifier",
            nullable: true);

        migrationBuilder.AlterColumn<int>(
            name: "Type",
            table: "Devices",
            type: "int",
            nullable: false,
            oldClrType: typeof(string),
            oldType: "nvarchar(max)");

        migrationBuilder.AddForeignKey(
            name: "FK_Hardwares_Devices_DeviceId",
            table: "Hardwares",
            column: "DeviceId",
            principalTable: "Devices",
            principalColumn: "Id");

        migrationBuilder.AddForeignKey(
            name: "FK_Notifications_Hardwares_HardwareId",
            table: "Notifications",
            column: "HardwareId",
            principalTable: "Hardwares",
            principalColumn: "Id");

        migrationBuilder.AddForeignKey(
            name: "FK_Notifications_User_UserId",
            table: "Notifications",
            column: "UserId",
            principalTable: "User",
            principalColumn: "Id");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Hardwares_Devices_DeviceId",
            table: "Hardwares");

        migrationBuilder.DropForeignKey(
            name: "FK_Notifications_Hardwares_HardwareId",
            table: "Notifications");

        migrationBuilder.DropForeignKey(
            name: "FK_Notifications_User_UserId",
            table: "Notifications");

        migrationBuilder.DropColumn(
            name: "CompanyId",
            table: "User");

        migrationBuilder.RenameColumn(
            name: "HardwareId",
            table: "Notifications",
            newName: "DeviceId");

        migrationBuilder.RenameIndex(
            name: "IX_Notifications_HardwareId",
            table: "Notifications",
            newName: "IX_Notifications_DeviceId");

        migrationBuilder.AlterColumn<string>(
            name: "Role",
            table: "User",
            type: "nvarchar(max)",
            nullable: false,
            oldClrType: typeof(int),
            oldType: "int");

        migrationBuilder.AlterColumn<string>(
            name: "Type",
            table: "Devices",
            type: "nvarchar(max)",
            nullable: false,
            oldClrType: typeof(int),
            oldType: "int");

        migrationBuilder.AddForeignKey(
            name: "FK_Hardwares_Devices_DeviceId",
            table: "Hardwares",
            column: "DeviceId",
            principalTable: "Devices",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_Notifications_Devices_DeviceId",
            table: "Notifications",
            column: "DeviceId",
            principalTable: "Devices",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_Notifications_User_UserId",
            table: "Notifications",
            column: "UserId",
            principalTable: "User",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    }
}
