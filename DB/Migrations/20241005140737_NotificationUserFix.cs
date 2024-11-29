using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHub.DB.Migrations;

/// <inheritdoc />
public partial class NotificationUserFix : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropPrimaryKey(
            name: "PK_UserHomePermissions",
            table: "UserHomePermissions");

        migrationBuilder.DropPrimaryKey(
            name: "PK_NotificationMembers",
            table: "NotificationMembers");

        migrationBuilder.AddPrimaryKey(
            name: "PK_UserHomePermissions",
            table: "UserHomePermissions",
            column: "Id");

        migrationBuilder.AddPrimaryKey(
            name: "PK_NotificationMembers",
            table: "NotificationMembers",
            column: "Id");

        migrationBuilder.CreateIndex(
            name: "IX_UserHomePermissions_UserId",
            table: "UserHomePermissions",
            column: "UserId");

        migrationBuilder.CreateIndex(
            name: "IX_NotificationMembers_UserId",
            table: "NotificationMembers",
            column: "UserId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropPrimaryKey(
            name: "PK_UserHomePermissions",
            table: "UserHomePermissions");

        migrationBuilder.DropIndex(
            name: "IX_UserHomePermissions_UserId",
            table: "UserHomePermissions");

        migrationBuilder.DropPrimaryKey(
            name: "PK_NotificationMembers",
            table: "NotificationMembers");

        migrationBuilder.DropIndex(
            name: "IX_NotificationMembers_UserId",
            table: "NotificationMembers");

        migrationBuilder.AddPrimaryKey(
            name: "PK_UserHomePermissions",
            table: "UserHomePermissions",
            columns: ["UserId", "HomeId"]);

        migrationBuilder.AddPrimaryKey(
            name: "PK_NotificationMembers",
            table: "NotificationMembers",
            columns: ["UserId", "HomeId"]);
    }
}
