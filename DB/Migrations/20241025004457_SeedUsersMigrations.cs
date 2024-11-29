using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHub.DB.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsersMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_User_OwnerId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Homes_User_OwnerId",
                table: "Homes");

            migrationBuilder.DropForeignKey(
                name: "FK_NotificationMembers_User_UserId",
                table: "NotificationMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_User_UserId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_User_UserId",
                table: "Sessions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserHomePermissions_User_UserId",
                table: "UserHomePermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPermissions_Permission_PermissionsId",
                table: "UserPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPermissions_User_UserId",
                table: "UserPermissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permission",
                table: "Permission");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Permission",
                newName: "Permissions");

            migrationBuilder.RenameColumn(
                name: "PermissionsId",
                table: "UserPermissions",
                newName: "PermissionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("097c6a9c-a088-4609-a87d-28f41f0037a8"), "addsmartlamp-smartlamp" },
                    { new Guid("1daa72b4-c992-49be-bb3a-1cdec8d83bcc"), "getdevices-devices" },
                    { new Guid("28120997-bbcf-4e84-9264-f334f32455c7"), "updatenamedevice-home" },
                    { new Guid("2f52f473-4535-49b1-b187-544c487017ea"), "open-windowsensor" },
                    { new Guid("3e752bda-417c-4e8b-9880-2d7c0390fedb"), "addhomeownerpermission-homeowner" },
                    { new Guid("439bd59f-22d2-4796-b200-1c0e55169110"), "addmotionsensor-motionsensor" },
                    { new Guid("4cf7df27-f09b-40f9-9e18-f6eb0083266a"), "motiondetection-camera" },
                    { new Guid("51079df2-9e33-42b4-b036-fa7ca910a389"), "addcamera-camera" },
                    { new Guid("5a759b54-cfb0-4d76-84fa-0a0d5e02d49c"), "createcompany-companies" },
                    { new Guid("5d59bf73-6a58-419e-8c4e-da91c7aa4da1"), "on-smartlamp" },
                    { new Guid("5d68ce10-bafa-4a4e-9924-92746dd836ba"), "deleteadminaccount-administrator" },
                    { new Guid("5f4151ef-1fbd-4e74-9b74-29572d848ac8"), "addmember-members" },
                    { new Guid("6f1dacc1-41ac-4bdd-9003-fa4b603ed464"), "newhome-home" },
                    { new Guid("7d5a71ca-1c6e-4bd0-aef8-ae80a30071e5"), "getcompany-companies" },
                    { new Guid("7d9f0272-2c49-4a7c-a11d-c51053664feb"), "getdevices-home" },
                    { new Guid("86aa671c-e40e-457e-94b2-ec5b06b0050c"), "persondetection-camera" },
                    { new Guid("86daad74-b654-46a0-a828-88f1caa8e916"), "getaccounts-accounts" },
                    { new Guid("8f918d86-97c6-4931-8aac-a020ee223be7"), "getnotifications-notification" },
                    { new Guid("90e84acf-9eb4-4ccc-95f1-2f0343543c2c"), "addpermission-members" },
                    { new Guid("9aef3b5e-c20f-4447-b328-237bd492d3a2"), "createadminaccount-administrator" },
                    { new Guid("b049944b-8703-44b0-9496-bedc49a4d27f"), "getdevicetypes-devicetype" },
                    { new Guid("b68703af-b7fc-42db-8fe8-b96bc4ff6eed"), "addhomeownerpermission-homeowner" },
                    { new Guid("bcc72968-945f-46d3-bdbf-883a2d50b174"), "off-smartlamp" },
                    { new Guid("bf049bd6-427d-468c-95d1-7ba39eb213d7"), "addnotificationmembers-members" },
                    { new Guid("c01d65af-d033-4461-9c17-f852c7cfac31"), "addmotionsensor-motionsensor" },
                    { new Guid("cb257bfa-4a08-4c84-b5c1-b62b25b4b900"), "addsensor-windowsensor" },
                    { new Guid("cd35650c-f847-4684-8a1d-a6f816c1a79e"), "getmembers-members" },
                    { new Guid("d8aae869-3da9-4ed7-864d-16cba076d030"), "close-windowsensor" },
                    { new Guid("db709097-0761-4987-bb60-2b92b506c0ce"), "motiondetection-motionsensor" },
                    { new Guid("e37179a5-5ecd-45a8-a1e9-65565ad16aad"), "gethomes-user" },
                    { new Guid("ecc85e36-ef44-410e-bb8c-d6cef66b38ac"), "adddevice-home" },
                    { new Guid("f2a2964f-d437-427d-9a60-29dd11826c59"), "createcompanyowneraccount-companyowner" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Password", "ProfilePhoto", "RolesJson", "Surname" },
                values: new object[,]
                {
                    { new Guid("206b6b90-f67d-4c75-bb70-7aca5b8c6d94"), new DateTime(2024, 10, 24, 21, 44, 56, 447, DateTimeKind.Local).AddTicks(353), "novakdjokovic@tennis.com", "Novak", "Djokovic@123", "djokovic.jpg", "[2]", "Djokovic" },
                    { new Guid("705d203c-e015-4699-b10e-adbac5712927"), new DateTime(2024, 10, 24, 21, 44, 56, 447, DateTimeKind.Local).AddTicks(363), "steffigraf@tennis.com", "Steffi", "Steffi@123", "graf.jpg", "[1]", "Graf" },
                    { new Guid("a6e4d48f-4481-4333-9390-f9f17cccff0f"), new DateTime(2024, 10, 24, 21, 44, 56, 447, DateTimeKind.Local).AddTicks(105), "rogerfederer@tennis.com", "Roger", "Federer@123", "federer.jpg", "[0]", "Federer" },
                    { new Guid("b854bbd2-78f0-49d6-906b-97caeeb45e6c"), new DateTime(2024, 10, 24, 21, 44, 56, 447, DateTimeKind.Local).AddTicks(340), "serenawilliams@tennis.com", "Serena", "Serena@123", "serena.jpg", "[2]", "Williams" },
                    { new Guid("d04994b2-980b-4bf6-b9e0-9179f078b003"), new DateTime(2024, 10, 24, 21, 44, 56, 447, DateTimeKind.Local).AddTicks(374), "andreagassi@tennis.com", "Andre", "Agassi@123", "agassi.jpg", "[1]", "Agassi" },
                    { new Guid("f2afd291-d368-4b90-9451-0d9d7f0046f0"), new DateTime(2024, 10, 24, 21, 44, 56, 447, DateTimeKind.Local).AddTicks(322), "rafaelnadal@tennis.com", "Rafael", "Nadal@123", "nadal.jpg", "[0]", "Nadal" }
                });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "PermissionId", "UserId" },
                values: new object[,]
                {
                    { new Guid("097c6a9c-a088-4609-a87d-28f41f0037a8"), new Guid("a6e4d48f-4481-4333-9390-f9f17cccff0f") },
                    { new Guid("097c6a9c-a088-4609-a87d-28f41f0037a8"), new Guid("f2afd291-d368-4b90-9451-0d9d7f0046f0") },
                    { new Guid("28120997-bbcf-4e84-9264-f334f32455c7"), new Guid("705d203c-e015-4699-b10e-adbac5712927") },
                    { new Guid("28120997-bbcf-4e84-9264-f334f32455c7"), new Guid("d04994b2-980b-4bf6-b9e0-9179f078b003") },
                    { new Guid("3e752bda-417c-4e8b-9880-2d7c0390fedb"), new Guid("206b6b90-f67d-4c75-bb70-7aca5b8c6d94") },
                    { new Guid("3e752bda-417c-4e8b-9880-2d7c0390fedb"), new Guid("b854bbd2-78f0-49d6-906b-97caeeb45e6c") },
                    { new Guid("439bd59f-22d2-4796-b200-1c0e55169110"), new Guid("705d203c-e015-4699-b10e-adbac5712927") },
                    { new Guid("439bd59f-22d2-4796-b200-1c0e55169110"), new Guid("d04994b2-980b-4bf6-b9e0-9179f078b003") },
                    { new Guid("51079df2-9e33-42b4-b036-fa7ca910a389"), new Guid("a6e4d48f-4481-4333-9390-f9f17cccff0f") },
                    { new Guid("51079df2-9e33-42b4-b036-fa7ca910a389"), new Guid("f2afd291-d368-4b90-9451-0d9d7f0046f0") },
                    { new Guid("5a759b54-cfb0-4d76-84fa-0a0d5e02d49c"), new Guid("a6e4d48f-4481-4333-9390-f9f17cccff0f") },
                    { new Guid("5a759b54-cfb0-4d76-84fa-0a0d5e02d49c"), new Guid("f2afd291-d368-4b90-9451-0d9d7f0046f0") },
                    { new Guid("5d68ce10-bafa-4a4e-9924-92746dd836ba"), new Guid("206b6b90-f67d-4c75-bb70-7aca5b8c6d94") },
                    { new Guid("5d68ce10-bafa-4a4e-9924-92746dd836ba"), new Guid("b854bbd2-78f0-49d6-906b-97caeeb45e6c") },
                    { new Guid("5f4151ef-1fbd-4e74-9b74-29572d848ac8"), new Guid("705d203c-e015-4699-b10e-adbac5712927") },
                    { new Guid("5f4151ef-1fbd-4e74-9b74-29572d848ac8"), new Guid("d04994b2-980b-4bf6-b9e0-9179f078b003") },
                    { new Guid("6f1dacc1-41ac-4bdd-9003-fa4b603ed464"), new Guid("705d203c-e015-4699-b10e-adbac5712927") },
                    { new Guid("6f1dacc1-41ac-4bdd-9003-fa4b603ed464"), new Guid("d04994b2-980b-4bf6-b9e0-9179f078b003") },
                    { new Guid("7d5a71ca-1c6e-4bd0-aef8-ae80a30071e5"), new Guid("206b6b90-f67d-4c75-bb70-7aca5b8c6d94") },
                    { new Guid("7d5a71ca-1c6e-4bd0-aef8-ae80a30071e5"), new Guid("b854bbd2-78f0-49d6-906b-97caeeb45e6c") },
                    { new Guid("7d9f0272-2c49-4a7c-a11d-c51053664feb"), new Guid("705d203c-e015-4699-b10e-adbac5712927") },
                    { new Guid("7d9f0272-2c49-4a7c-a11d-c51053664feb"), new Guid("d04994b2-980b-4bf6-b9e0-9179f078b003") },
                    { new Guid("86daad74-b654-46a0-a828-88f1caa8e916"), new Guid("206b6b90-f67d-4c75-bb70-7aca5b8c6d94") },
                    { new Guid("86daad74-b654-46a0-a828-88f1caa8e916"), new Guid("b854bbd2-78f0-49d6-906b-97caeeb45e6c") },
                    { new Guid("90e84acf-9eb4-4ccc-95f1-2f0343543c2c"), new Guid("705d203c-e015-4699-b10e-adbac5712927") },
                    { new Guid("90e84acf-9eb4-4ccc-95f1-2f0343543c2c"), new Guid("d04994b2-980b-4bf6-b9e0-9179f078b003") },
                    { new Guid("9aef3b5e-c20f-4447-b328-237bd492d3a2"), new Guid("206b6b90-f67d-4c75-bb70-7aca5b8c6d94") },
                    { new Guid("9aef3b5e-c20f-4447-b328-237bd492d3a2"), new Guid("b854bbd2-78f0-49d6-906b-97caeeb45e6c") },
                    { new Guid("b68703af-b7fc-42db-8fe8-b96bc4ff6eed"), new Guid("a6e4d48f-4481-4333-9390-f9f17cccff0f") },
                    { new Guid("b68703af-b7fc-42db-8fe8-b96bc4ff6eed"), new Guid("f2afd291-d368-4b90-9451-0d9d7f0046f0") },
                    { new Guid("bf049bd6-427d-468c-95d1-7ba39eb213d7"), new Guid("705d203c-e015-4699-b10e-adbac5712927") },
                    { new Guid("bf049bd6-427d-468c-95d1-7ba39eb213d7"), new Guid("d04994b2-980b-4bf6-b9e0-9179f078b003") },
                    { new Guid("c01d65af-d033-4461-9c17-f852c7cfac31"), new Guid("a6e4d48f-4481-4333-9390-f9f17cccff0f") },
                    { new Guid("c01d65af-d033-4461-9c17-f852c7cfac31"), new Guid("f2afd291-d368-4b90-9451-0d9d7f0046f0") },
                    { new Guid("cb257bfa-4a08-4c84-b5c1-b62b25b4b900"), new Guid("a6e4d48f-4481-4333-9390-f9f17cccff0f") },
                    { new Guid("cb257bfa-4a08-4c84-b5c1-b62b25b4b900"), new Guid("f2afd291-d368-4b90-9451-0d9d7f0046f0") },
                    { new Guid("cd35650c-f847-4684-8a1d-a6f816c1a79e"), new Guid("705d203c-e015-4699-b10e-adbac5712927") },
                    { new Guid("cd35650c-f847-4684-8a1d-a6f816c1a79e"), new Guid("d04994b2-980b-4bf6-b9e0-9179f078b003") },
                    { new Guid("e37179a5-5ecd-45a8-a1e9-65565ad16aad"), new Guid("705d203c-e015-4699-b10e-adbac5712927") },
                    { new Guid("e37179a5-5ecd-45a8-a1e9-65565ad16aad"), new Guid("d04994b2-980b-4bf6-b9e0-9179f078b003") },
                    { new Guid("ecc85e36-ef44-410e-bb8c-d6cef66b38ac"), new Guid("705d203c-e015-4699-b10e-adbac5712927") },
                    { new Guid("ecc85e36-ef44-410e-bb8c-d6cef66b38ac"), new Guid("d04994b2-980b-4bf6-b9e0-9179f078b003") },
                    { new Guid("f2a2964f-d437-427d-9a60-29dd11826c59"), new Guid("206b6b90-f67d-4c75-bb70-7aca5b8c6d94") },
                    { new Guid("f2a2964f-d437-427d-9a60-29dd11826c59"), new Guid("b854bbd2-78f0-49d6-906b-97caeeb45e6c") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Users_OwnerId",
                table: "Companies",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Homes_Users_OwnerId",
                table: "Homes",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationMembers_Users_UserId",
                table: "NotificationMembers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Users_UserId",
                table: "Notifications",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Users_UserId",
                table: "Sessions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserHomePermissions_Users_UserId",
                table: "UserHomePermissions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPermissions_Permissions_PermissionId",
                table: "UserPermissions",
                column: "PermissionId",
                principalTable: "Permissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPermissions_Users_UserId",
                table: "UserPermissions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Users_OwnerId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Homes_Users_OwnerId",
                table: "Homes");

            migrationBuilder.DropForeignKey(
                name: "FK_NotificationMembers_Users_UserId",
                table: "NotificationMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Users_UserId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Users_UserId",
                table: "Sessions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserHomePermissions_Users_UserId",
                table: "UserHomePermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPermissions_Permissions_PermissionId",
                table: "UserPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPermissions_Users_UserId",
                table: "UserPermissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1daa72b4-c992-49be-bb3a-1cdec8d83bcc"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2f52f473-4535-49b1-b187-544c487017ea"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4cf7df27-f09b-40f9-9e18-f6eb0083266a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5d59bf73-6a58-419e-8c4e-da91c7aa4da1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("86aa671c-e40e-457e-94b2-ec5b06b0050c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8f918d86-97c6-4931-8aac-a020ee223be7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b049944b-8703-44b0-9496-bedc49a4d27f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bcc72968-945f-46d3-bdbf-883a2d50b174"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d8aae869-3da9-4ed7-864d-16cba076d030"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("db709097-0761-4987-bb60-2b92b506c0ce"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("097c6a9c-a088-4609-a87d-28f41f0037a8"), new Guid("a6e4d48f-4481-4333-9390-f9f17cccff0f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("097c6a9c-a088-4609-a87d-28f41f0037a8"), new Guid("f2afd291-d368-4b90-9451-0d9d7f0046f0") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("28120997-bbcf-4e84-9264-f334f32455c7"), new Guid("705d203c-e015-4699-b10e-adbac5712927") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("28120997-bbcf-4e84-9264-f334f32455c7"), new Guid("d04994b2-980b-4bf6-b9e0-9179f078b003") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3e752bda-417c-4e8b-9880-2d7c0390fedb"), new Guid("206b6b90-f67d-4c75-bb70-7aca5b8c6d94") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3e752bda-417c-4e8b-9880-2d7c0390fedb"), new Guid("b854bbd2-78f0-49d6-906b-97caeeb45e6c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("439bd59f-22d2-4796-b200-1c0e55169110"), new Guid("705d203c-e015-4699-b10e-adbac5712927") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("439bd59f-22d2-4796-b200-1c0e55169110"), new Guid("d04994b2-980b-4bf6-b9e0-9179f078b003") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("51079df2-9e33-42b4-b036-fa7ca910a389"), new Guid("a6e4d48f-4481-4333-9390-f9f17cccff0f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("51079df2-9e33-42b4-b036-fa7ca910a389"), new Guid("f2afd291-d368-4b90-9451-0d9d7f0046f0") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5a759b54-cfb0-4d76-84fa-0a0d5e02d49c"), new Guid("a6e4d48f-4481-4333-9390-f9f17cccff0f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5a759b54-cfb0-4d76-84fa-0a0d5e02d49c"), new Guid("f2afd291-d368-4b90-9451-0d9d7f0046f0") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5d68ce10-bafa-4a4e-9924-92746dd836ba"), new Guid("206b6b90-f67d-4c75-bb70-7aca5b8c6d94") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5d68ce10-bafa-4a4e-9924-92746dd836ba"), new Guid("b854bbd2-78f0-49d6-906b-97caeeb45e6c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5f4151ef-1fbd-4e74-9b74-29572d848ac8"), new Guid("705d203c-e015-4699-b10e-adbac5712927") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5f4151ef-1fbd-4e74-9b74-29572d848ac8"), new Guid("d04994b2-980b-4bf6-b9e0-9179f078b003") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6f1dacc1-41ac-4bdd-9003-fa4b603ed464"), new Guid("705d203c-e015-4699-b10e-adbac5712927") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6f1dacc1-41ac-4bdd-9003-fa4b603ed464"), new Guid("d04994b2-980b-4bf6-b9e0-9179f078b003") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7d5a71ca-1c6e-4bd0-aef8-ae80a30071e5"), new Guid("206b6b90-f67d-4c75-bb70-7aca5b8c6d94") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7d5a71ca-1c6e-4bd0-aef8-ae80a30071e5"), new Guid("b854bbd2-78f0-49d6-906b-97caeeb45e6c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7d9f0272-2c49-4a7c-a11d-c51053664feb"), new Guid("705d203c-e015-4699-b10e-adbac5712927") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7d9f0272-2c49-4a7c-a11d-c51053664feb"), new Guid("d04994b2-980b-4bf6-b9e0-9179f078b003") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("86daad74-b654-46a0-a828-88f1caa8e916"), new Guid("206b6b90-f67d-4c75-bb70-7aca5b8c6d94") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("86daad74-b654-46a0-a828-88f1caa8e916"), new Guid("b854bbd2-78f0-49d6-906b-97caeeb45e6c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("90e84acf-9eb4-4ccc-95f1-2f0343543c2c"), new Guid("705d203c-e015-4699-b10e-adbac5712927") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("90e84acf-9eb4-4ccc-95f1-2f0343543c2c"), new Guid("d04994b2-980b-4bf6-b9e0-9179f078b003") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9aef3b5e-c20f-4447-b328-237bd492d3a2"), new Guid("206b6b90-f67d-4c75-bb70-7aca5b8c6d94") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9aef3b5e-c20f-4447-b328-237bd492d3a2"), new Guid("b854bbd2-78f0-49d6-906b-97caeeb45e6c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b68703af-b7fc-42db-8fe8-b96bc4ff6eed"), new Guid("a6e4d48f-4481-4333-9390-f9f17cccff0f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b68703af-b7fc-42db-8fe8-b96bc4ff6eed"), new Guid("f2afd291-d368-4b90-9451-0d9d7f0046f0") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bf049bd6-427d-468c-95d1-7ba39eb213d7"), new Guid("705d203c-e015-4699-b10e-adbac5712927") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bf049bd6-427d-468c-95d1-7ba39eb213d7"), new Guid("d04994b2-980b-4bf6-b9e0-9179f078b003") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c01d65af-d033-4461-9c17-f852c7cfac31"), new Guid("a6e4d48f-4481-4333-9390-f9f17cccff0f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c01d65af-d033-4461-9c17-f852c7cfac31"), new Guid("f2afd291-d368-4b90-9451-0d9d7f0046f0") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cb257bfa-4a08-4c84-b5c1-b62b25b4b900"), new Guid("a6e4d48f-4481-4333-9390-f9f17cccff0f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cb257bfa-4a08-4c84-b5c1-b62b25b4b900"), new Guid("f2afd291-d368-4b90-9451-0d9d7f0046f0") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cd35650c-f847-4684-8a1d-a6f816c1a79e"), new Guid("705d203c-e015-4699-b10e-adbac5712927") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cd35650c-f847-4684-8a1d-a6f816c1a79e"), new Guid("d04994b2-980b-4bf6-b9e0-9179f078b003") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e37179a5-5ecd-45a8-a1e9-65565ad16aad"), new Guid("705d203c-e015-4699-b10e-adbac5712927") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e37179a5-5ecd-45a8-a1e9-65565ad16aad"), new Guid("d04994b2-980b-4bf6-b9e0-9179f078b003") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ecc85e36-ef44-410e-bb8c-d6cef66b38ac"), new Guid("705d203c-e015-4699-b10e-adbac5712927") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ecc85e36-ef44-410e-bb8c-d6cef66b38ac"), new Guid("d04994b2-980b-4bf6-b9e0-9179f078b003") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f2a2964f-d437-427d-9a60-29dd11826c59"), new Guid("206b6b90-f67d-4c75-bb70-7aca5b8c6d94") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f2a2964f-d437-427d-9a60-29dd11826c59"), new Guid("b854bbd2-78f0-49d6-906b-97caeeb45e6c") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("097c6a9c-a088-4609-a87d-28f41f0037a8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("28120997-bbcf-4e84-9264-f334f32455c7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3e752bda-417c-4e8b-9880-2d7c0390fedb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("439bd59f-22d2-4796-b200-1c0e55169110"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("51079df2-9e33-42b4-b036-fa7ca910a389"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5a759b54-cfb0-4d76-84fa-0a0d5e02d49c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5d68ce10-bafa-4a4e-9924-92746dd836ba"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5f4151ef-1fbd-4e74-9b74-29572d848ac8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6f1dacc1-41ac-4bdd-9003-fa4b603ed464"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7d5a71ca-1c6e-4bd0-aef8-ae80a30071e5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7d9f0272-2c49-4a7c-a11d-c51053664feb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("86daad74-b654-46a0-a828-88f1caa8e916"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("90e84acf-9eb4-4ccc-95f1-2f0343543c2c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9aef3b5e-c20f-4447-b328-237bd492d3a2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b68703af-b7fc-42db-8fe8-b96bc4ff6eed"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bf049bd6-427d-468c-95d1-7ba39eb213d7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c01d65af-d033-4461-9c17-f852c7cfac31"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cb257bfa-4a08-4c84-b5c1-b62b25b4b900"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cd35650c-f847-4684-8a1d-a6f816c1a79e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e37179a5-5ecd-45a8-a1e9-65565ad16aad"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ecc85e36-ef44-410e-bb8c-d6cef66b38ac"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f2a2964f-d437-427d-9a60-29dd11826c59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("206b6b90-f67d-4c75-bb70-7aca5b8c6d94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("705d203c-e015-4699-b10e-adbac5712927"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6e4d48f-4481-4333-9390-f9f17cccff0f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b854bbd2-78f0-49d6-906b-97caeeb45e6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d04994b2-980b-4bf6-b9e0-9179f078b003"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2afd291-d368-4b90-9451-0d9d7f0046f0"));

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Permissions",
                newName: "Permission");

            migrationBuilder.RenameColumn(
                name: "PermissionId",
                table: "UserPermissions",
                newName: "PermissionsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permission",
                table: "Permission",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_User_OwnerId",
                table: "Companies",
                column: "OwnerId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Homes_User_OwnerId",
                table: "Homes",
                column: "OwnerId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationMembers_User_UserId",
                table: "NotificationMembers",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_User_UserId",
                table: "Notifications",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_User_UserId",
                table: "Sessions",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserHomePermissions_User_UserId",
                table: "UserHomePermissions",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPermissions_Permission_PermissionsId",
                table: "UserPermissions",
                column: "PermissionsId",
                principalTable: "Permission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPermissions_User_UserId",
                table: "UserPermissions",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
