using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHub.DB.Migrations;

/// <inheritdoc />
public partial class HomesMigracion : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Homes",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Ubication_Lat = table.Column<int>(type: "int", nullable: true),
                Ubication_Lon = table.Column<int>(type: "int", nullable: true),
                OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                MaxMembers = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Homes", x => x.Id);
                table.ForeignKey(
                    name: "FK_Homes_User_OwnerId",
                    column: x => x.OwnerId,
                    principalTable: "User",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Hardwares",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Online = table.Column<bool>(type: "bit", nullable: false),
                HomeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Hardwares", x => x.Id);
                table.ForeignKey(
                    name: "FK_Hardwares_Homes_HomeId",
                    column: x => x.HomeId,
                    principalTable: "Homes",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "NotificationMembers",
            columns: table => new
            {
                HomeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_NotificationMembers", x => new { x.UserId, x.HomeId });
                table.ForeignKey(
                    name: "FK_NotificationMembers_Homes_HomeId",
                    column: x => x.HomeId,
                    principalTable: "Homes",
                    principalColumn: "Id");
                table.ForeignKey(
                    name: "FK_NotificationMembers_User_UserId",
                    column: x => x.UserId,
                    principalTable: "User",
                    principalColumn: "Id");
            });

        migrationBuilder.CreateTable(
            name: "UserHomePermissions",
            columns: table => new
            {
                UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                HomeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Permissions = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_UserHomePermissions", x => new { x.UserId, x.HomeId });
                table.ForeignKey(
                    name: "FK_UserHomePermissions_Homes_HomeId",
                    column: x => x.HomeId,
                    principalTable: "Homes",
                    principalColumn: "Id");
                table.ForeignKey(
                    name: "FK_UserHomePermissions_User_UserId",
                    column: x => x.UserId,
                    principalTable: "User",
                    principalColumn: "Id");
            });

        migrationBuilder.CreateIndex(
            name: "IX_Hardwares_HomeId",
            table: "Hardwares",
            column: "HomeId");

        migrationBuilder.CreateIndex(
            name: "IX_Homes_OwnerId",
            table: "Homes",
            column: "OwnerId");

        migrationBuilder.CreateIndex(
            name: "IX_NotificationMembers_HomeId",
            table: "NotificationMembers",
            column: "HomeId");

        migrationBuilder.CreateIndex(
            name: "IX_UserHomePermissions_HomeId",
            table: "UserHomePermissions",
            column: "HomeId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Hardwares");

        migrationBuilder.DropTable(
            name: "NotificationMembers");

        migrationBuilder.DropTable(
            name: "UserHomePermissions");

        migrationBuilder.DropTable(
            name: "Homes");
    }
}
