using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHub.DB.Migrations;

/// <inheritdoc />
public partial class FixLoopMigration : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_UserPermissions_User_UsersId",
            table: "UserPermissions");

        migrationBuilder.RenameColumn(
            name: "UsersId",
            table: "UserPermissions",
            newName: "UserId");

        migrationBuilder.RenameIndex(
            name: "IX_UserPermissions_UsersId",
            table: "UserPermissions",
            newName: "IX_UserPermissions_UserId");

        migrationBuilder.AddForeignKey(
            name: "FK_UserPermissions_User_UserId",
            table: "UserPermissions",
            column: "UserId",
            principalTable: "User",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_UserPermissions_User_UserId",
            table: "UserPermissions");

        migrationBuilder.RenameColumn(
            name: "UserId",
            table: "UserPermissions",
            newName: "UsersId");

        migrationBuilder.RenameIndex(
            name: "IX_UserPermissions_UserId",
            table: "UserPermissions",
            newName: "IX_UserPermissions_UsersId");

        migrationBuilder.AddForeignKey(
            name: "FK_UserPermissions_User_UsersId",
            table: "UserPermissions",
            column: "UsersId",
            principalTable: "User",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    }
}
