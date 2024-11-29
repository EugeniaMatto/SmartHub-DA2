using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHub.DB.Migrations;

/// <inheritdoc />
public partial class PermissionUserMigration : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Permission_User_UserId",
            table: "Permission");

        migrationBuilder.DropIndex(
            name: "IX_Permission_UserId",
            table: "Permission");

        migrationBuilder.DropColumn(
            name: "UserId",
            table: "Permission");

        migrationBuilder.AddColumn<string>(
            name: "Name",
            table: "Permission",
            type: "nvarchar(max)",
            nullable: false,
            defaultValue: string.Empty);

        migrationBuilder.CreateTable(
            name: "UserPermissions",
            columns: table => new
            {
                PermissionsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_UserPermissions", x => new { x.PermissionsId, x.UserId });
                table.ForeignKey(
                    name: "FK_UserPermissions_Permission_PermissionsId",
                    column: x => x.PermissionsId,
                    principalTable: "Permission",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_UserPermissions_User_UserId",
                    column: x => x.UserId,
                    principalTable: "User",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_UserPermissions_UserId",
            table: "UserPermissions",
            column: "UserId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "UserPermissions");

        migrationBuilder.DropColumn(
            name: "Name",
            table: "Permission");

        migrationBuilder.AddColumn<Guid>(
            name: "UserId",
            table: "Permission",
            type: "uniqueidentifier",
            nullable: true);

        migrationBuilder.CreateIndex(
            name: "IX_Permission_UserId",
            table: "Permission",
            column: "UserId");

        migrationBuilder.AddForeignKey(
            name: "FK_Permission_User_UserId",
            table: "Permission",
            column: "UserId",
            principalTable: "User",
            principalColumn: "Id");
    }
}
