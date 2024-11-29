using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHub.DB.Migrations;

/// <inheritdoc />
public partial class CompanyMigration : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<Guid>(
            name: "CompanyId",
            table: "Devices",
            type: "uniqueidentifier",
            nullable: false,
            defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

        migrationBuilder.CreateTable(
            name: "Companies",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                LogoURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Rut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Companies", x => x.Id);
                table.ForeignKey(
                    name: "FK_Companies_User_OwnerId",
                    column: x => x.OwnerId,
                    principalTable: "User",
                    principalColumn: "Id");
            });

        migrationBuilder.CreateIndex(
            name: "IX_Devices_CompanyId",
            table: "Devices",
            column: "CompanyId");

        migrationBuilder.CreateIndex(
            name: "IX_Companies_OwnerId",
            table: "Companies",
            column: "OwnerId");

        migrationBuilder.AddForeignKey(
            name: "FK_Devices_Companies_CompanyId",
            table: "Devices",
            column: "CompanyId",
            principalTable: "Companies",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Devices_Companies_CompanyId",
            table: "Devices");

        migrationBuilder.DropTable(
            name: "Companies");

        migrationBuilder.DropIndex(
            name: "IX_Devices_CompanyId",
            table: "Devices");

        migrationBuilder.DropColumn(
            name: "CompanyId",
            table: "Devices");
    }
}
