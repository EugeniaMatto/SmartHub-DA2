using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHub.DB.Migrations
{
    /// <inheritdoc />
    public partial class UserRolesListFixMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "RolesJson",
                table: "Users",
                newName: "Roles");

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("23fd915f-864a-42f3-8061-ac79961e3145"), "newhome-home" },
                    { new Guid("289fec6f-c275-4e0e-99ea-579d0683b2bd"), "motiondetection-camera" },
                    { new Guid("323bf644-c3ef-4501-a82d-acb809957cf4"), "addhomeownerpermission-homeowner" },
                    { new Guid("33b4df56-f80a-4fdf-a56d-641e8618d82b"), "off-smartlamp" },
                    { new Guid("38de2f19-2fea-45aa-b5b5-8e6f9da90e7c"), "createcompany-companies" },
                    { new Guid("3b2f8dbb-bcc1-42cd-ba77-72afa1d822ca"), "getaccounts-accounts" },
                    { new Guid("4c707a82-4a63-4268-a5da-1bf02e47d5cb"), "getdevicetypes-devicetype" },
                    { new Guid("5123fed4-a1ff-474b-ab15-968cf8df548c"), "on-smartlamp" },
                    { new Guid("6519bab1-5296-4ef4-bfe7-aa7b90fcd5ee"), "addpermission-members" },
                    { new Guid("66959cf0-cfed-4233-ac4c-804fa4053de4"), "open-windowsensor" },
                    { new Guid("6c700d87-3219-440e-885a-b8b3447ce33f"), "getcompany-companies" },
                    { new Guid("7fb62486-1e62-43e4-a54c-f0233fd1475e"), "addcamera-camera" },
                    { new Guid("95d87f22-defb-4f47-ae38-3e9bc59cda9d"), "createadminaccount-administrator" },
                    { new Guid("99308808-b55f-47d9-b12b-c3e263b00950"), "addsensor-windowsensor" },
                    { new Guid("b56fc959-b137-4a3e-8568-a1e3d6780f76"), "motiondetection-motionsensor" },
                    { new Guid("b6dac8a5-0e9e-4fda-8cbf-2086a6e74b87"), "addnotificationmembers-members" },
                    { new Guid("bf908216-0341-49e7-983f-4cfc8a48b618"), "addhomeownerpermission-homeowner" },
                    { new Guid("c68e57bf-acbe-4139-8b9b-aeb23d08e7d9"), "getmembers-members" },
                    { new Guid("c7328610-86fa-4668-bbd0-8a6dfca4a993"), "updatenamedevice-home" },
                    { new Guid("c9f74d67-1b13-4809-ac9b-1cc3d0fd2df6"), "createcompanyowneraccount-companyowner" },
                    { new Guid("cf32e499-9273-442e-a24d-02e9cdff661b"), "getnotifications-notification" },
                    { new Guid("d3db3dc6-5fd1-4a0f-a3e0-54ac1a10ece2"), "addsmartlamp-smartlamp" },
                    { new Guid("d433b8e4-f1f3-4640-b501-3178c04d919d"), "addmember-members" },
                    { new Guid("dd709dd0-8622-4be9-91d6-7caa74401274"), "persondetection-camera" },
                    { new Guid("e6de765d-c4ae-4ac1-bc6e-ec5f133fc3e0"), "getdevices-home" },
                    { new Guid("e8bde265-a646-4eb9-b8d7-78384ff2786d"), "gethomes-user" },
                    { new Guid("eb2df1eb-53d8-4f14-9eab-240d00ed92dd"), "adddevice-home" },
                    { new Guid("f227705b-71b0-474c-a7cf-c171ca619e43"), "deleteadminaccount-administrator" },
                    { new Guid("f3c7b6a5-c9f4-4f70-97a8-a0295f4e6583"), "addmotionsensor-motionsensor" },
                    { new Guid("f6a4816f-7b1d-417b-87b4-b72bcb6aea44"), "addmotionsensor-motionsensor" },
                    { new Guid("fba8c000-ae56-4553-84bf-074f8203ea2e"), "close-windowsensor" },
                    { new Guid("fcf63289-25b3-4b61-875f-a5b03019aebc"), "getdevices-devices" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Password", "ProfilePhoto", "Roles", "Surname" },
                values: new object[,]
                {
                    { new Guid("05b85637-fe5b-42b8-a951-d197ea65b9d7"), new DateTime(2024, 10, 24, 22, 51, 47, 276, DateTimeKind.Local).AddTicks(2414), "andreagassi@tennis.com", "Andre", "Agassi@123", "agassi.jpg", "[1]", "Agassi" },
                    { new Guid("29a26908-80ea-4bc4-86eb-5d0acb11f4fe"), new DateTime(2024, 10, 24, 22, 51, 47, 276, DateTimeKind.Local).AddTicks(2380), "steffigraf@tennis.com", "Steffi", "Steffi@123", "graf.jpg", "[1]", "Graf" },
                    { new Guid("62b0117d-1b24-4edd-9fd7-43708e0ad725"), new DateTime(2024, 10, 24, 22, 51, 47, 276, DateTimeKind.Local).AddTicks(2368), "rafaelnadal@tennis.com", "Rafael", "Nadal@123", "nadal.jpg", "[0]", "Nadal" },
                    { new Guid("8617ac23-695a-4640-af73-1c4840ad4459"), new DateTime(2024, 10, 24, 22, 51, 47, 276, DateTimeKind.Local).AddTicks(2344), "rogerfederer@tennis.com", "Roger", "Federer@123", "federer.jpg", "[0]", "Federer" },
                    { new Guid("8f103d97-fb04-496e-9274-5b69100325bb"), new DateTime(2024, 10, 24, 22, 51, 47, 276, DateTimeKind.Local).AddTicks(2373), "serenawilliams@tennis.com", "Serena", "Serena@123", "serena.jpg", "[2]", "Williams" },
                    { new Guid("b927e1d7-c63b-4ca4-901d-4198edfa742a"), new DateTime(2024, 10, 24, 22, 51, 47, 276, DateTimeKind.Local).AddTicks(2376), "novakdjokovic@tennis.com", "Novak", "Djokovic@123", "djokovic.jpg", "[2]", "Djokovic" }
                });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "PermissionId", "UserId" },
                values: new object[,]
                {
                    { new Guid("23fd915f-864a-42f3-8061-ac79961e3145"), new Guid("05b85637-fe5b-42b8-a951-d197ea65b9d7") },
                    { new Guid("23fd915f-864a-42f3-8061-ac79961e3145"), new Guid("29a26908-80ea-4bc4-86eb-5d0acb11f4fe") },
                    { new Guid("323bf644-c3ef-4501-a82d-acb809957cf4"), new Guid("62b0117d-1b24-4edd-9fd7-43708e0ad725") },
                    { new Guid("323bf644-c3ef-4501-a82d-acb809957cf4"), new Guid("8617ac23-695a-4640-af73-1c4840ad4459") },
                    { new Guid("38de2f19-2fea-45aa-b5b5-8e6f9da90e7c"), new Guid("62b0117d-1b24-4edd-9fd7-43708e0ad725") },
                    { new Guid("38de2f19-2fea-45aa-b5b5-8e6f9da90e7c"), new Guid("8617ac23-695a-4640-af73-1c4840ad4459") },
                    { new Guid("3b2f8dbb-bcc1-42cd-ba77-72afa1d822ca"), new Guid("8f103d97-fb04-496e-9274-5b69100325bb") },
                    { new Guid("3b2f8dbb-bcc1-42cd-ba77-72afa1d822ca"), new Guid("b927e1d7-c63b-4ca4-901d-4198edfa742a") },
                    { new Guid("6519bab1-5296-4ef4-bfe7-aa7b90fcd5ee"), new Guid("05b85637-fe5b-42b8-a951-d197ea65b9d7") },
                    { new Guid("6519bab1-5296-4ef4-bfe7-aa7b90fcd5ee"), new Guid("29a26908-80ea-4bc4-86eb-5d0acb11f4fe") },
                    { new Guid("6c700d87-3219-440e-885a-b8b3447ce33f"), new Guid("8f103d97-fb04-496e-9274-5b69100325bb") },
                    { new Guid("6c700d87-3219-440e-885a-b8b3447ce33f"), new Guid("b927e1d7-c63b-4ca4-901d-4198edfa742a") },
                    { new Guid("7fb62486-1e62-43e4-a54c-f0233fd1475e"), new Guid("62b0117d-1b24-4edd-9fd7-43708e0ad725") },
                    { new Guid("7fb62486-1e62-43e4-a54c-f0233fd1475e"), new Guid("8617ac23-695a-4640-af73-1c4840ad4459") },
                    { new Guid("95d87f22-defb-4f47-ae38-3e9bc59cda9d"), new Guid("8f103d97-fb04-496e-9274-5b69100325bb") },
                    { new Guid("95d87f22-defb-4f47-ae38-3e9bc59cda9d"), new Guid("b927e1d7-c63b-4ca4-901d-4198edfa742a") },
                    { new Guid("99308808-b55f-47d9-b12b-c3e263b00950"), new Guid("62b0117d-1b24-4edd-9fd7-43708e0ad725") },
                    { new Guid("99308808-b55f-47d9-b12b-c3e263b00950"), new Guid("8617ac23-695a-4640-af73-1c4840ad4459") },
                    { new Guid("b6dac8a5-0e9e-4fda-8cbf-2086a6e74b87"), new Guid("05b85637-fe5b-42b8-a951-d197ea65b9d7") },
                    { new Guid("b6dac8a5-0e9e-4fda-8cbf-2086a6e74b87"), new Guid("29a26908-80ea-4bc4-86eb-5d0acb11f4fe") },
                    { new Guid("bf908216-0341-49e7-983f-4cfc8a48b618"), new Guid("8f103d97-fb04-496e-9274-5b69100325bb") },
                    { new Guid("bf908216-0341-49e7-983f-4cfc8a48b618"), new Guid("b927e1d7-c63b-4ca4-901d-4198edfa742a") },
                    { new Guid("c68e57bf-acbe-4139-8b9b-aeb23d08e7d9"), new Guid("05b85637-fe5b-42b8-a951-d197ea65b9d7") },
                    { new Guid("c68e57bf-acbe-4139-8b9b-aeb23d08e7d9"), new Guid("29a26908-80ea-4bc4-86eb-5d0acb11f4fe") },
                    { new Guid("c7328610-86fa-4668-bbd0-8a6dfca4a993"), new Guid("05b85637-fe5b-42b8-a951-d197ea65b9d7") },
                    { new Guid("c7328610-86fa-4668-bbd0-8a6dfca4a993"), new Guid("29a26908-80ea-4bc4-86eb-5d0acb11f4fe") },
                    { new Guid("c9f74d67-1b13-4809-ac9b-1cc3d0fd2df6"), new Guid("8f103d97-fb04-496e-9274-5b69100325bb") },
                    { new Guid("c9f74d67-1b13-4809-ac9b-1cc3d0fd2df6"), new Guid("b927e1d7-c63b-4ca4-901d-4198edfa742a") },
                    { new Guid("d3db3dc6-5fd1-4a0f-a3e0-54ac1a10ece2"), new Guid("62b0117d-1b24-4edd-9fd7-43708e0ad725") },
                    { new Guid("d3db3dc6-5fd1-4a0f-a3e0-54ac1a10ece2"), new Guid("8617ac23-695a-4640-af73-1c4840ad4459") },
                    { new Guid("d433b8e4-f1f3-4640-b501-3178c04d919d"), new Guid("05b85637-fe5b-42b8-a951-d197ea65b9d7") },
                    { new Guid("d433b8e4-f1f3-4640-b501-3178c04d919d"), new Guid("29a26908-80ea-4bc4-86eb-5d0acb11f4fe") },
                    { new Guid("e6de765d-c4ae-4ac1-bc6e-ec5f133fc3e0"), new Guid("05b85637-fe5b-42b8-a951-d197ea65b9d7") },
                    { new Guid("e6de765d-c4ae-4ac1-bc6e-ec5f133fc3e0"), new Guid("29a26908-80ea-4bc4-86eb-5d0acb11f4fe") },
                    { new Guid("e8bde265-a646-4eb9-b8d7-78384ff2786d"), new Guid("05b85637-fe5b-42b8-a951-d197ea65b9d7") },
                    { new Guid("e8bde265-a646-4eb9-b8d7-78384ff2786d"), new Guid("29a26908-80ea-4bc4-86eb-5d0acb11f4fe") },
                    { new Guid("eb2df1eb-53d8-4f14-9eab-240d00ed92dd"), new Guid("05b85637-fe5b-42b8-a951-d197ea65b9d7") },
                    { new Guid("eb2df1eb-53d8-4f14-9eab-240d00ed92dd"), new Guid("29a26908-80ea-4bc4-86eb-5d0acb11f4fe") },
                    { new Guid("f227705b-71b0-474c-a7cf-c171ca619e43"), new Guid("8f103d97-fb04-496e-9274-5b69100325bb") },
                    { new Guid("f227705b-71b0-474c-a7cf-c171ca619e43"), new Guid("b927e1d7-c63b-4ca4-901d-4198edfa742a") },
                    { new Guid("f3c7b6a5-c9f4-4f70-97a8-a0295f4e6583"), new Guid("62b0117d-1b24-4edd-9fd7-43708e0ad725") },
                    { new Guid("f3c7b6a5-c9f4-4f70-97a8-a0295f4e6583"), new Guid("8617ac23-695a-4640-af73-1c4840ad4459") },
                    { new Guid("f6a4816f-7b1d-417b-87b4-b72bcb6aea44"), new Guid("05b85637-fe5b-42b8-a951-d197ea65b9d7") },
                    { new Guid("f6a4816f-7b1d-417b-87b4-b72bcb6aea44"), new Guid("29a26908-80ea-4bc4-86eb-5d0acb11f4fe") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("289fec6f-c275-4e0e-99ea-579d0683b2bd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("33b4df56-f80a-4fdf-a56d-641e8618d82b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4c707a82-4a63-4268-a5da-1bf02e47d5cb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5123fed4-a1ff-474b-ab15-968cf8df548c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("66959cf0-cfed-4233-ac4c-804fa4053de4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b56fc959-b137-4a3e-8568-a1e3d6780f76"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cf32e499-9273-442e-a24d-02e9cdff661b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dd709dd0-8622-4be9-91d6-7caa74401274"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fba8c000-ae56-4553-84bf-074f8203ea2e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fcf63289-25b3-4b61-875f-a5b03019aebc"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("23fd915f-864a-42f3-8061-ac79961e3145"), new Guid("05b85637-fe5b-42b8-a951-d197ea65b9d7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("23fd915f-864a-42f3-8061-ac79961e3145"), new Guid("29a26908-80ea-4bc4-86eb-5d0acb11f4fe") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("323bf644-c3ef-4501-a82d-acb809957cf4"), new Guid("62b0117d-1b24-4edd-9fd7-43708e0ad725") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("323bf644-c3ef-4501-a82d-acb809957cf4"), new Guid("8617ac23-695a-4640-af73-1c4840ad4459") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("38de2f19-2fea-45aa-b5b5-8e6f9da90e7c"), new Guid("62b0117d-1b24-4edd-9fd7-43708e0ad725") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("38de2f19-2fea-45aa-b5b5-8e6f9da90e7c"), new Guid("8617ac23-695a-4640-af73-1c4840ad4459") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3b2f8dbb-bcc1-42cd-ba77-72afa1d822ca"), new Guid("8f103d97-fb04-496e-9274-5b69100325bb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3b2f8dbb-bcc1-42cd-ba77-72afa1d822ca"), new Guid("b927e1d7-c63b-4ca4-901d-4198edfa742a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6519bab1-5296-4ef4-bfe7-aa7b90fcd5ee"), new Guid("05b85637-fe5b-42b8-a951-d197ea65b9d7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6519bab1-5296-4ef4-bfe7-aa7b90fcd5ee"), new Guid("29a26908-80ea-4bc4-86eb-5d0acb11f4fe") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6c700d87-3219-440e-885a-b8b3447ce33f"), new Guid("8f103d97-fb04-496e-9274-5b69100325bb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6c700d87-3219-440e-885a-b8b3447ce33f"), new Guid("b927e1d7-c63b-4ca4-901d-4198edfa742a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7fb62486-1e62-43e4-a54c-f0233fd1475e"), new Guid("62b0117d-1b24-4edd-9fd7-43708e0ad725") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7fb62486-1e62-43e4-a54c-f0233fd1475e"), new Guid("8617ac23-695a-4640-af73-1c4840ad4459") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("95d87f22-defb-4f47-ae38-3e9bc59cda9d"), new Guid("8f103d97-fb04-496e-9274-5b69100325bb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("95d87f22-defb-4f47-ae38-3e9bc59cda9d"), new Guid("b927e1d7-c63b-4ca4-901d-4198edfa742a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("99308808-b55f-47d9-b12b-c3e263b00950"), new Guid("62b0117d-1b24-4edd-9fd7-43708e0ad725") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("99308808-b55f-47d9-b12b-c3e263b00950"), new Guid("8617ac23-695a-4640-af73-1c4840ad4459") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b6dac8a5-0e9e-4fda-8cbf-2086a6e74b87"), new Guid("05b85637-fe5b-42b8-a951-d197ea65b9d7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b6dac8a5-0e9e-4fda-8cbf-2086a6e74b87"), new Guid("29a26908-80ea-4bc4-86eb-5d0acb11f4fe") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bf908216-0341-49e7-983f-4cfc8a48b618"), new Guid("8f103d97-fb04-496e-9274-5b69100325bb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bf908216-0341-49e7-983f-4cfc8a48b618"), new Guid("b927e1d7-c63b-4ca4-901d-4198edfa742a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c68e57bf-acbe-4139-8b9b-aeb23d08e7d9"), new Guid("05b85637-fe5b-42b8-a951-d197ea65b9d7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c68e57bf-acbe-4139-8b9b-aeb23d08e7d9"), new Guid("29a26908-80ea-4bc4-86eb-5d0acb11f4fe") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c7328610-86fa-4668-bbd0-8a6dfca4a993"), new Guid("05b85637-fe5b-42b8-a951-d197ea65b9d7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c7328610-86fa-4668-bbd0-8a6dfca4a993"), new Guid("29a26908-80ea-4bc4-86eb-5d0acb11f4fe") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c9f74d67-1b13-4809-ac9b-1cc3d0fd2df6"), new Guid("8f103d97-fb04-496e-9274-5b69100325bb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c9f74d67-1b13-4809-ac9b-1cc3d0fd2df6"), new Guid("b927e1d7-c63b-4ca4-901d-4198edfa742a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d3db3dc6-5fd1-4a0f-a3e0-54ac1a10ece2"), new Guid("62b0117d-1b24-4edd-9fd7-43708e0ad725") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d3db3dc6-5fd1-4a0f-a3e0-54ac1a10ece2"), new Guid("8617ac23-695a-4640-af73-1c4840ad4459") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d433b8e4-f1f3-4640-b501-3178c04d919d"), new Guid("05b85637-fe5b-42b8-a951-d197ea65b9d7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d433b8e4-f1f3-4640-b501-3178c04d919d"), new Guid("29a26908-80ea-4bc4-86eb-5d0acb11f4fe") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e6de765d-c4ae-4ac1-bc6e-ec5f133fc3e0"), new Guid("05b85637-fe5b-42b8-a951-d197ea65b9d7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e6de765d-c4ae-4ac1-bc6e-ec5f133fc3e0"), new Guid("29a26908-80ea-4bc4-86eb-5d0acb11f4fe") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e8bde265-a646-4eb9-b8d7-78384ff2786d"), new Guid("05b85637-fe5b-42b8-a951-d197ea65b9d7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e8bde265-a646-4eb9-b8d7-78384ff2786d"), new Guid("29a26908-80ea-4bc4-86eb-5d0acb11f4fe") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("eb2df1eb-53d8-4f14-9eab-240d00ed92dd"), new Guid("05b85637-fe5b-42b8-a951-d197ea65b9d7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("eb2df1eb-53d8-4f14-9eab-240d00ed92dd"), new Guid("29a26908-80ea-4bc4-86eb-5d0acb11f4fe") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f227705b-71b0-474c-a7cf-c171ca619e43"), new Guid("8f103d97-fb04-496e-9274-5b69100325bb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f227705b-71b0-474c-a7cf-c171ca619e43"), new Guid("b927e1d7-c63b-4ca4-901d-4198edfa742a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f3c7b6a5-c9f4-4f70-97a8-a0295f4e6583"), new Guid("62b0117d-1b24-4edd-9fd7-43708e0ad725") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f3c7b6a5-c9f4-4f70-97a8-a0295f4e6583"), new Guid("8617ac23-695a-4640-af73-1c4840ad4459") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f6a4816f-7b1d-417b-87b4-b72bcb6aea44"), new Guid("05b85637-fe5b-42b8-a951-d197ea65b9d7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f6a4816f-7b1d-417b-87b4-b72bcb6aea44"), new Guid("29a26908-80ea-4bc4-86eb-5d0acb11f4fe") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("23fd915f-864a-42f3-8061-ac79961e3145"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("323bf644-c3ef-4501-a82d-acb809957cf4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("38de2f19-2fea-45aa-b5b5-8e6f9da90e7c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3b2f8dbb-bcc1-42cd-ba77-72afa1d822ca"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6519bab1-5296-4ef4-bfe7-aa7b90fcd5ee"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6c700d87-3219-440e-885a-b8b3447ce33f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7fb62486-1e62-43e4-a54c-f0233fd1475e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("95d87f22-defb-4f47-ae38-3e9bc59cda9d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("99308808-b55f-47d9-b12b-c3e263b00950"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b6dac8a5-0e9e-4fda-8cbf-2086a6e74b87"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bf908216-0341-49e7-983f-4cfc8a48b618"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c68e57bf-acbe-4139-8b9b-aeb23d08e7d9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c7328610-86fa-4668-bbd0-8a6dfca4a993"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c9f74d67-1b13-4809-ac9b-1cc3d0fd2df6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d3db3dc6-5fd1-4a0f-a3e0-54ac1a10ece2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d433b8e4-f1f3-4640-b501-3178c04d919d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e6de765d-c4ae-4ac1-bc6e-ec5f133fc3e0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e8bde265-a646-4eb9-b8d7-78384ff2786d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("eb2df1eb-53d8-4f14-9eab-240d00ed92dd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f227705b-71b0-474c-a7cf-c171ca619e43"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f3c7b6a5-c9f4-4f70-97a8-a0295f4e6583"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f6a4816f-7b1d-417b-87b4-b72bcb6aea44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05b85637-fe5b-42b8-a951-d197ea65b9d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29a26908-80ea-4bc4-86eb-5d0acb11f4fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62b0117d-1b24-4edd-9fd7-43708e0ad725"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8617ac23-695a-4640-af73-1c4840ad4459"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f103d97-fb04-496e-9274-5b69100325bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b927e1d7-c63b-4ca4-901d-4198edfa742a"));

            migrationBuilder.RenameColumn(
                name: "Roles",
                table: "Users",
                newName: "RolesJson");

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
        }
    }
}
