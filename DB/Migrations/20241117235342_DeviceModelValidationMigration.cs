using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHub.DB.Migrations
{
    /// <inheritdoc />
    public partial class DeviceModelValidationMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("01d254b7-37a9-4693-903d-405bfd06eeb2"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("01d254b7-37a9-4693-903d-405bfd06eeb2"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("01d254b7-37a9-4693-903d-405bfd06eeb2"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("05180053-fa51-4263-b26c-c8eb55d0cc2f"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("05180053-fa51-4263-b26c-c8eb55d0cc2f"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("05180053-fa51-4263-b26c-c8eb55d0cc2f"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("05180053-fa51-4263-b26c-c8eb55d0cc2f"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("05180053-fa51-4263-b26c-c8eb55d0cc2f"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("05180053-fa51-4263-b26c-c8eb55d0cc2f"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("05180053-fa51-4263-b26c-c8eb55d0cc2f"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("05180053-fa51-4263-b26c-c8eb55d0cc2f"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("05180053-fa51-4263-b26c-c8eb55d0cc2f"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("05180053-fa51-4263-b26c-c8eb55d0cc2f"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("07e8ff14-1ce0-457d-970c-69c745eb574e"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("07e8ff14-1ce0-457d-970c-69c745eb574e"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("07e8ff14-1ce0-457d-970c-69c745eb574e"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("09f8a3de-43f3-42e4-99c5-09b1fb91b24c"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("09f8a3de-43f3-42e4-99c5-09b1fb91b24c"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("09f8a3de-43f3-42e4-99c5-09b1fb91b24c"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("09f8a3de-43f3-42e4-99c5-09b1fb91b24c"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("09f8a3de-43f3-42e4-99c5-09b1fb91b24c"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0e7edc7b-9688-4f76-a0f7-3baba00dd077"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0e7edc7b-9688-4f76-a0f7-3baba00dd077"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0e7edc7b-9688-4f76-a0f7-3baba00dd077"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0e7edc7b-9688-4f76-a0f7-3baba00dd077"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0e7edc7b-9688-4f76-a0f7-3baba00dd077"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0e7edc7b-9688-4f76-a0f7-3baba00dd077"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0e7edc7b-9688-4f76-a0f7-3baba00dd077"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0e7edc7b-9688-4f76-a0f7-3baba00dd077"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0e7edc7b-9688-4f76-a0f7-3baba00dd077"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0e7edc7b-9688-4f76-a0f7-3baba00dd077"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("123192d4-318e-4395-8bfe-fc8ac1e5f6c7"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("123192d4-318e-4395-8bfe-fc8ac1e5f6c7"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("123192d4-318e-4395-8bfe-fc8ac1e5f6c7"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18d90191-4dac-4b79-a2b2-4ca4a910c20b"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18d90191-4dac-4b79-a2b2-4ca4a910c20b"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18d90191-4dac-4b79-a2b2-4ca4a910c20b"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18d90191-4dac-4b79-a2b2-4ca4a910c20b"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18d90191-4dac-4b79-a2b2-4ca4a910c20b"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("25a95351-ac71-4b27-b4a5-ffd76b355d5c"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("25a95351-ac71-4b27-b4a5-ffd76b355d5c"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("25a95351-ac71-4b27-b4a5-ffd76b355d5c"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("31fa3476-ffea-408c-8d11-0e345d9e6e9b"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("31fa3476-ffea-408c-8d11-0e345d9e6e9b"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("31fa3476-ffea-408c-8d11-0e345d9e6e9b"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("34706640-abae-4206-b395-8688da213ee4"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("34706640-abae-4206-b395-8688da213ee4"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("34706640-abae-4206-b395-8688da213ee4"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("34706640-abae-4206-b395-8688da213ee4"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("34706640-abae-4206-b395-8688da213ee4"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("34706640-abae-4206-b395-8688da213ee4"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("34706640-abae-4206-b395-8688da213ee4"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("34706640-abae-4206-b395-8688da213ee4"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("34706640-abae-4206-b395-8688da213ee4"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("34706640-abae-4206-b395-8688da213ee4"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4285bf3b-2150-4c7d-bde0-2ae392f8c4e8"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4285bf3b-2150-4c7d-bde0-2ae392f8c4e8"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4285bf3b-2150-4c7d-bde0-2ae392f8c4e8"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4285bf3b-2150-4c7d-bde0-2ae392f8c4e8"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4285bf3b-2150-4c7d-bde0-2ae392f8c4e8"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4285bf3b-2150-4c7d-bde0-2ae392f8c4e8"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4285bf3b-2150-4c7d-bde0-2ae392f8c4e8"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4285bf3b-2150-4c7d-bde0-2ae392f8c4e8"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4285bf3b-2150-4c7d-bde0-2ae392f8c4e8"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4285bf3b-2150-4c7d-bde0-2ae392f8c4e8"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("46442ca2-3775-49b9-af9e-3794214a71e0"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("46442ca2-3775-49b9-af9e-3794214a71e0"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("46442ca2-3775-49b9-af9e-3794214a71e0"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4e784112-5544-4879-98db-8daaf9082135"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4e784112-5544-4879-98db-8daaf9082135"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4e784112-5544-4879-98db-8daaf9082135"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4f332726-7b86-48f4-b3fe-a9ab53057d12"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4f332726-7b86-48f4-b3fe-a9ab53057d12"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4f332726-7b86-48f4-b3fe-a9ab53057d12"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5fff3ba2-9f13-4550-956e-1419b425c3a9"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5fff3ba2-9f13-4550-956e-1419b425c3a9"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5fff3ba2-9f13-4550-956e-1419b425c3a9"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5fff3ba2-9f13-4550-956e-1419b425c3a9"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5fff3ba2-9f13-4550-956e-1419b425c3a9"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("605daf83-93e6-4742-bcbf-4515107a66b5"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("605daf83-93e6-4742-bcbf-4515107a66b5"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("605daf83-93e6-4742-bcbf-4515107a66b5"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("605daf83-93e6-4742-bcbf-4515107a66b5"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("605daf83-93e6-4742-bcbf-4515107a66b5"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6c074926-8c66-4cbc-8693-b04e64a4ca70"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6c074926-8c66-4cbc-8693-b04e64a4ca70"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6c074926-8c66-4cbc-8693-b04e64a4ca70"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("708eebc6-8f17-4fe5-ae66-c3846e09b182"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("708eebc6-8f17-4fe5-ae66-c3846e09b182"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("708eebc6-8f17-4fe5-ae66-c3846e09b182"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("75e3a6ec-2c71-4cdb-b5b6-27e13e78f8f7"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("75e3a6ec-2c71-4cdb-b5b6-27e13e78f8f7"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("75e3a6ec-2c71-4cdb-b5b6-27e13e78f8f7"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7ce918b9-9751-4649-a532-923a2fe8e58b"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7ce918b9-9751-4649-a532-923a2fe8e58b"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7ce918b9-9751-4649-a532-923a2fe8e58b"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7ce918b9-9751-4649-a532-923a2fe8e58b"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7ce918b9-9751-4649-a532-923a2fe8e58b"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8314e7a1-9725-4b08-be40-26614781e77f"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8314e7a1-9725-4b08-be40-26614781e77f"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8314e7a1-9725-4b08-be40-26614781e77f"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8314e7a1-9725-4b08-be40-26614781e77f"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8314e7a1-9725-4b08-be40-26614781e77f"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8b401275-21e7-4e67-ac64-98fe95d52fb0"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8b401275-21e7-4e67-ac64-98fe95d52fb0"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8b401275-21e7-4e67-ac64-98fe95d52fb0"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8b401275-21e7-4e67-ac64-98fe95d52fb0"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8b401275-21e7-4e67-ac64-98fe95d52fb0"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8b401275-21e7-4e67-ac64-98fe95d52fb0"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8b401275-21e7-4e67-ac64-98fe95d52fb0"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8b401275-21e7-4e67-ac64-98fe95d52fb0"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8b401275-21e7-4e67-ac64-98fe95d52fb0"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8b401275-21e7-4e67-ac64-98fe95d52fb0"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9632c2ef-79a4-45e1-90db-064855fd4eee"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9632c2ef-79a4-45e1-90db-064855fd4eee"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9632c2ef-79a4-45e1-90db-064855fd4eee"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("966e3761-9e30-4975-9902-7d6d81fc0e54"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("966e3761-9e30-4975-9902-7d6d81fc0e54"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("966e3761-9e30-4975-9902-7d6d81fc0e54"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("997ac669-bcd1-4d3c-b38a-1c3050a774bf"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("997ac669-bcd1-4d3c-b38a-1c3050a774bf"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("997ac669-bcd1-4d3c-b38a-1c3050a774bf"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a02296dc-9392-4ef9-9e3d-5af8e889cc7c"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a02296dc-9392-4ef9-9e3d-5af8e889cc7c"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a02296dc-9392-4ef9-9e3d-5af8e889cc7c"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a02296dc-9392-4ef9-9e3d-5af8e889cc7c"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a02296dc-9392-4ef9-9e3d-5af8e889cc7c"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a02296dc-9392-4ef9-9e3d-5af8e889cc7c"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a02296dc-9392-4ef9-9e3d-5af8e889cc7c"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a02296dc-9392-4ef9-9e3d-5af8e889cc7c"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a02296dc-9392-4ef9-9e3d-5af8e889cc7c"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a02296dc-9392-4ef9-9e3d-5af8e889cc7c"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a8a546a2-fc19-4496-8f71-7fe2477538bf"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a8a546a2-fc19-4496-8f71-7fe2477538bf"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a8a546a2-fc19-4496-8f71-7fe2477538bf"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a8a546a2-fc19-4496-8f71-7fe2477538bf"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a8a546a2-fc19-4496-8f71-7fe2477538bf"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a9c7f68d-80b7-4c26-98a3-a1237d3a74be"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a9c7f68d-80b7-4c26-98a3-a1237d3a74be"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a9c7f68d-80b7-4c26-98a3-a1237d3a74be"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a9c7f68d-80b7-4c26-98a3-a1237d3a74be"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a9c7f68d-80b7-4c26-98a3-a1237d3a74be"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa44e395-8089-478b-9b17-e3aedeb5f887"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa44e395-8089-478b-9b17-e3aedeb5f887"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa44e395-8089-478b-9b17-e3aedeb5f887"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa44e395-8089-478b-9b17-e3aedeb5f887"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa44e395-8089-478b-9b17-e3aedeb5f887"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa44e395-8089-478b-9b17-e3aedeb5f887"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa44e395-8089-478b-9b17-e3aedeb5f887"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa44e395-8089-478b-9b17-e3aedeb5f887"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa44e395-8089-478b-9b17-e3aedeb5f887"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa44e395-8089-478b-9b17-e3aedeb5f887"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ad915dfa-0463-4b42-8e33-11b4539f519c"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ad915dfa-0463-4b42-8e33-11b4539f519c"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ad915dfa-0463-4b42-8e33-11b4539f519c"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ad915dfa-0463-4b42-8e33-11b4539f519c"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ad915dfa-0463-4b42-8e33-11b4539f519c"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ad915dfa-0463-4b42-8e33-11b4539f519c"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ad915dfa-0463-4b42-8e33-11b4539f519c"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ad915dfa-0463-4b42-8e33-11b4539f519c"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ad915dfa-0463-4b42-8e33-11b4539f519c"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ad915dfa-0463-4b42-8e33-11b4539f519c"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b31418a4-070d-42c8-841e-5aa4de008184"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b31418a4-070d-42c8-841e-5aa4de008184"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b31418a4-070d-42c8-841e-5aa4de008184"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b31418a4-070d-42c8-841e-5aa4de008184"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b31418a4-070d-42c8-841e-5aa4de008184"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b31418a4-070d-42c8-841e-5aa4de008184"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b31418a4-070d-42c8-841e-5aa4de008184"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b31418a4-070d-42c8-841e-5aa4de008184"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b31418a4-070d-42c8-841e-5aa4de008184"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b31418a4-070d-42c8-841e-5aa4de008184"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c8e9702e-5185-4bda-8ac6-a394171ddb40"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c8e9702e-5185-4bda-8ac6-a394171ddb40"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c8e9702e-5185-4bda-8ac6-a394171ddb40"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ce7ff9d8-5936-4c7c-9ba5-c65689bebf05"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ce7ff9d8-5936-4c7c-9ba5-c65689bebf05"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ce7ff9d8-5936-4c7c-9ba5-c65689bebf05"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ce7ff9d8-5936-4c7c-9ba5-c65689bebf05"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ce7ff9d8-5936-4c7c-9ba5-c65689bebf05"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d3f4d967-1368-473b-bcee-cedd83518b8c"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d3f4d967-1368-473b-bcee-cedd83518b8c"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d3f4d967-1368-473b-bcee-cedd83518b8c"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d3f4d967-1368-473b-bcee-cedd83518b8c"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d3f4d967-1368-473b-bcee-cedd83518b8c"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d8209c2d-6779-4ce7-b7ff-e0585631a004"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d8209c2d-6779-4ce7-b7ff-e0585631a004"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d8209c2d-6779-4ce7-b7ff-e0585631a004"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d8209c2d-6779-4ce7-b7ff-e0585631a004"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d8209c2d-6779-4ce7-b7ff-e0585631a004"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f34af2b3-5e49-4183-95a5-05821cdcb820"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f34af2b3-5e49-4183-95a5-05821cdcb820"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f34af2b3-5e49-4183-95a5-05821cdcb820"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f34af2b3-5e49-4183-95a5-05821cdcb820"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f34af2b3-5e49-4183-95a5-05821cdcb820"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f34af2b3-5e49-4183-95a5-05821cdcb820"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f34af2b3-5e49-4183-95a5-05821cdcb820"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f34af2b3-5e49-4183-95a5-05821cdcb820"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f34af2b3-5e49-4183-95a5-05821cdcb820"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f34af2b3-5e49-4183-95a5-05821cdcb820"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f75fc379-eb23-49ad-a60e-0b4e0556e7eb"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f75fc379-eb23-49ad-a60e-0b4e0556e7eb"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f75fc379-eb23-49ad-a60e-0b4e0556e7eb"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f75fc379-eb23-49ad-a60e-0b4e0556e7eb"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f75fc379-eb23-49ad-a60e-0b4e0556e7eb"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f75fc379-eb23-49ad-a60e-0b4e0556e7eb"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f75fc379-eb23-49ad-a60e-0b4e0556e7eb"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f75fc379-eb23-49ad-a60e-0b4e0556e7eb"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f75fc379-eb23-49ad-a60e-0b4e0556e7eb"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f75fc379-eb23-49ad-a60e-0b4e0556e7eb"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f8800c36-2e0b-4862-9db2-3f230c19515b"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f8800c36-2e0b-4862-9db2-3f230c19515b"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f8800c36-2e0b-4862-9db2-3f230c19515b"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f8800c36-2e0b-4862-9db2-3f230c19515b"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f8800c36-2e0b-4862-9db2-3f230c19515b"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f97ac710-1562-436d-8ea5-a21da10e372a"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f97ac710-1562-436d-8ea5-a21da10e372a"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f97ac710-1562-436d-8ea5-a21da10e372a"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f97ac710-1562-436d-8ea5-a21da10e372a"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f97ac710-1562-436d-8ea5-a21da10e372a"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("01d254b7-37a9-4693-903d-405bfd06eeb2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("05180053-fa51-4263-b26c-c8eb55d0cc2f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("07e8ff14-1ce0-457d-970c-69c745eb574e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("09f8a3de-43f3-42e4-99c5-09b1fb91b24c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0e7edc7b-9688-4f76-a0f7-3baba00dd077"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("123192d4-318e-4395-8bfe-fc8ac1e5f6c7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("18d90191-4dac-4b79-a2b2-4ca4a910c20b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("25a95351-ac71-4b27-b4a5-ffd76b355d5c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("31fa3476-ffea-408c-8d11-0e345d9e6e9b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("34706640-abae-4206-b395-8688da213ee4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4285bf3b-2150-4c7d-bde0-2ae392f8c4e8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("46442ca2-3775-49b9-af9e-3794214a71e0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4e784112-5544-4879-98db-8daaf9082135"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4f332726-7b86-48f4-b3fe-a9ab53057d12"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5fff3ba2-9f13-4550-956e-1419b425c3a9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("605daf83-93e6-4742-bcbf-4515107a66b5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6c074926-8c66-4cbc-8693-b04e64a4ca70"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("708eebc6-8f17-4fe5-ae66-c3846e09b182"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("75e3a6ec-2c71-4cdb-b5b6-27e13e78f8f7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7ce918b9-9751-4649-a532-923a2fe8e58b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8314e7a1-9725-4b08-be40-26614781e77f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8b401275-21e7-4e67-ac64-98fe95d52fb0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9632c2ef-79a4-45e1-90db-064855fd4eee"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("966e3761-9e30-4975-9902-7d6d81fc0e54"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("997ac669-bcd1-4d3c-b38a-1c3050a774bf"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a02296dc-9392-4ef9-9e3d-5af8e889cc7c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a8a546a2-fc19-4496-8f71-7fe2477538bf"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a9c7f68d-80b7-4c26-98a3-a1237d3a74be"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("aa44e395-8089-478b-9b17-e3aedeb5f887"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ad915dfa-0463-4b42-8e33-11b4539f519c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b31418a4-070d-42c8-841e-5aa4de008184"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c8e9702e-5185-4bda-8ac6-a394171ddb40"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ce7ff9d8-5936-4c7c-9ba5-c65689bebf05"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d3f4d967-1368-473b-bcee-cedd83518b8c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d8209c2d-6779-4ce7-b7ff-e0585631a004"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f34af2b3-5e49-4183-95a5-05821cdcb820"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f75fc379-eb23-49ad-a60e-0b4e0556e7eb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f8800c36-2e0b-4862-9db2-3f230c19515b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f97ac710-1562-436d-8ea5-a21da10e372a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("032766bb-f502-4422-a235-8c051ad7bbd8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f114abd-8fdb-4983-8859-b242d7439e69"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa960763-b8e2-4fff-957b-61af6be52815"));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("06dad6c1-2f8b-4e61-afe2-a584c662e3db"), "getcompany-companies" },
                    { new Guid("0d00a92a-332e-408d-bf08-f496b239f91c"), "getnotifications-notification" },
                    { new Guid("180a99f4-bfd9-4907-a2d5-78acfa5a73c0"), "persondetection-camera" },
                    { new Guid("1e94c084-6f19-4d3b-88fe-e12d4dbf6015"), "off-smartlamp" },
                    { new Guid("25a8aed0-6640-4f6c-97f9-a797419640c9"), "updateroomdevice-home" },
                    { new Guid("2aa6588c-b999-42b8-bc98-71512e3e0616"), "addhomeownerpermission-homeowner" },
                    { new Guid("2c55c172-73c6-4e84-9d30-df45a11364fc"), "getmembers-members" },
                    { new Guid("2d00f75c-e127-4bdb-b390-271c43f51fc5"), "addpermission-members" },
                    { new Guid("33e65c77-5987-4482-a241-e8d48384d09a"), "addhomeownerpermission-homeowner" },
                    { new Guid("37b64d7b-d9a7-4fb2-8ea0-79ffc5a1efbf"), "getrooms-home" },
                    { new Guid("45593135-7c96-4afc-a226-827bffbf40f6"), "getpermissions-home" },
                    { new Guid("534abbac-10c2-4a24-a8cb-5857ad12488a"), "addmotionsensor-motionsensor" },
                    { new Guid("566818dd-6065-4cb4-9bcf-e8406467594c"), "createadminaccount-administrator" },
                    { new Guid("58bfeb75-ce29-44e5-bfdd-3c57d1d3b215"), "deleteadminaccount-administrator" },
                    { new Guid("5fc6182f-e4c2-4217-ac43-86123fd559bd"), "getaccounts-accounts" },
                    { new Guid("6324823f-33bf-4751-83e1-ada3a8d99b4f"), "selectdevicemodelvalidator-devices" },
                    { new Guid("6425ff54-1abf-4012-a616-96dd188ae62f"), "addmember-members" },
                    { new Guid("648d0504-2178-4f81-aa4b-5510bf69cca4"), "close-windowsensor" },
                    { new Guid("76625912-a4f8-4226-97fb-e3866d5dc2cf"), "getdevicemodelvalidators-devices" },
                    { new Guid("76962c57-3fe9-4e54-b0a8-e8f50b418754"), "addmotionsensor-motionsensor" },
                    { new Guid("7cd272f5-3b5d-4d1a-9ae6-190c81301f8d"), "importdevices-devices" },
                    { new Guid("9053f060-28f6-4186-8f76-0f59fc9f9195"), "motiondetection-camera" },
                    { new Guid("a3393a58-37a6-4b16-950a-3a8693df733e"), "gethomes-user" },
                    { new Guid("b0055e5f-de6f-46e4-a2fc-fa8c749401de"), "getdevices-home" },
                    { new Guid("b41eb4ea-1cbf-4947-a029-55314a22e965"), "adddevice-home" },
                    { new Guid("b4567409-1dec-4d77-826a-284975a546ab"), "addsmartlamp-smartlamp" },
                    { new Guid("b61013e1-17ff-4972-998f-69d79ad1072c"), "on-smartlamp" },
                    { new Guid("b8c954e1-b873-4255-a2b0-917cd4b47b32"), "createcompany-companies" },
                    { new Guid("bac15d33-070a-4b6a-8019-9d1a4b6faacc"), "addcamera-camera" },
                    { new Guid("bd17b2ee-1fe3-4e07-8743-68953d3dbb7f"), "getcompanyuser-companies" },
                    { new Guid("bf63dac8-1d49-4800-9af0-29705c641502"), "motiondetection-motionsensor" },
                    { new Guid("c4cf6c32-bbd0-4da2-8212-31ed6979d939"), "open-windowsensor" },
                    { new Guid("cc21448c-0978-43c4-8dca-aaa8fc48c5ce"), "addnotificationmembers-members" },
                    { new Guid("cdc72686-fb25-4622-a3e8-f98a2db7a1fe"), "updatenamedevice-home" },
                    { new Guid("cfc32ba1-be48-4c94-8fe8-e1fc2128b5bb"), "addrooms-home" },
                    { new Guid("d0ea86d3-ef15-4a5a-b2bc-e694447350c2"), "getimporters-devices" },
                    { new Guid("d19940ff-85ff-4cdc-a4bd-4241782025b3"), "createcompanyowneraccount-companyowner" },
                    { new Guid("e026d538-a71f-4064-80f3-07221f63e79c"), "newhome-home" },
                    { new Guid("e381f44d-16da-4d13-99bd-ccada05fed7d"), "addsensor-windowsensor" },
                    { new Guid("ea210e41-809d-442d-9d65-940f4953fa15"), "getdevices-devices" },
                    { new Guid("fd352840-6074-4299-9e83-0df81fedb097"), "getdevicetypes-devicetype" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Password", "ProfilePhoto", "Roles", "Surname" },
                values: new object[,]
                {
                    { new Guid("01dbba0e-177c-4540-876c-8af29235658b"), new DateTime(2024, 11, 17, 20, 53, 42, 285, DateTimeKind.Local).AddTicks(6961), "petesampras@tennis.com", "Pete", "Sampras@123", "sampras.jpg", "[1]", "Sampras" },
                    { new Guid("1ccc748f-585a-4151-9774-9a63fd152af8"), new DateTime(2024, 11, 17, 20, 53, 42, 285, DateTimeKind.Local).AddTicks(6955), "steffigraf@tennis.com", "Steffi", "Steffi@123", "graf.jpg", "[1]", "Graf" },
                    { new Guid("253f7d5d-942a-4603-a778-d139e663ba4c"), new DateTime(2024, 11, 17, 20, 53, 42, 285, DateTimeKind.Local).AddTicks(6968), "johnmcenroe@tennis.com", "John", "McEnroe@123", "mcenroe.jpg", "[2]", "McEnroe" },
                    { new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf"), new DateTime(2024, 11, 17, 20, 53, 42, 285, DateTimeKind.Local).AddTicks(6971), "billiejeanking@tennis.com", "Billie", "King@123", "king.jpg", "[0]", "Jean King" },
                    { new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d"), new DateTime(2024, 11, 17, 20, 53, 42, 285, DateTimeKind.Local).AddTicks(6965), "martinanavratilova@tennis.com", "Martina", "Navratilova@123", "navratilova.jpg", "[1]", "Navratilova" },
                    { new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c"), new DateTime(2024, 11, 17, 20, 53, 42, 285, DateTimeKind.Local).AddTicks(6948), "serenawilliams@tennis.com", "Serena", "Serena@123", "serena.jpg", "[2]", "Williams" },
                    { new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a"), new DateTime(2024, 11, 17, 20, 53, 42, 285, DateTimeKind.Local).AddTicks(6951), "novakdjokovic@tennis.com", "Novak", "Djokovic@123", "djokovic.jpg", "[2,1]", "Djokovic" },
                    { new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56"), new DateTime(2024, 11, 17, 20, 53, 42, 285, DateTimeKind.Local).AddTicks(6958), "andreagassi@tennis.com", "Andre", "Agassi@123", "agassi.jpg", "[1]", "Agassi" },
                    { new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4"), new DateTime(2024, 11, 17, 20, 53, 42, 285, DateTimeKind.Local).AddTicks(6944), "rafaelnadal@tennis.com", "Rafael", "Nadal@123", "nadal.jpg", "[0]", "Nadal" },
                    { new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e"), new DateTime(2024, 11, 17, 20, 53, 42, 285, DateTimeKind.Local).AddTicks(6918), "rogerfederer@tennis.com", "Roger", "Federer@123", "federer.jpg", "[0]", "Federer" }
                });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "PermissionId", "UserId" },
                values: new object[,]
                {
                    { new Guid("06dad6c1-2f8b-4e61-afe2-a584c662e3db"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") },
                    { new Guid("06dad6c1-2f8b-4e61-afe2-a584c662e3db"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") },
                    { new Guid("06dad6c1-2f8b-4e61-afe2-a584c662e3db"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("0d00a92a-332e-408d-bf08-f496b239f91c"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("0d00a92a-332e-408d-bf08-f496b239f91c"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("0d00a92a-332e-408d-bf08-f496b239f91c"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") },
                    { new Guid("0d00a92a-332e-408d-bf08-f496b239f91c"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") },
                    { new Guid("0d00a92a-332e-408d-bf08-f496b239f91c"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("0d00a92a-332e-408d-bf08-f496b239f91c"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") },
                    { new Guid("0d00a92a-332e-408d-bf08-f496b239f91c"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("0d00a92a-332e-408d-bf08-f496b239f91c"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("0d00a92a-332e-408d-bf08-f496b239f91c"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") },
                    { new Guid("0d00a92a-332e-408d-bf08-f496b239f91c"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") },
                    { new Guid("180a99f4-bfd9-4907-a2d5-78acfa5a73c0"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("180a99f4-bfd9-4907-a2d5-78acfa5a73c0"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("180a99f4-bfd9-4907-a2d5-78acfa5a73c0"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") },
                    { new Guid("180a99f4-bfd9-4907-a2d5-78acfa5a73c0"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") },
                    { new Guid("180a99f4-bfd9-4907-a2d5-78acfa5a73c0"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("180a99f4-bfd9-4907-a2d5-78acfa5a73c0"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") },
                    { new Guid("180a99f4-bfd9-4907-a2d5-78acfa5a73c0"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("180a99f4-bfd9-4907-a2d5-78acfa5a73c0"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("180a99f4-bfd9-4907-a2d5-78acfa5a73c0"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") },
                    { new Guid("180a99f4-bfd9-4907-a2d5-78acfa5a73c0"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") },
                    { new Guid("1e94c084-6f19-4d3b-88fe-e12d4dbf6015"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("1e94c084-6f19-4d3b-88fe-e12d4dbf6015"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("1e94c084-6f19-4d3b-88fe-e12d4dbf6015"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") },
                    { new Guid("1e94c084-6f19-4d3b-88fe-e12d4dbf6015"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") },
                    { new Guid("1e94c084-6f19-4d3b-88fe-e12d4dbf6015"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("1e94c084-6f19-4d3b-88fe-e12d4dbf6015"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") },
                    { new Guid("1e94c084-6f19-4d3b-88fe-e12d4dbf6015"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("1e94c084-6f19-4d3b-88fe-e12d4dbf6015"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("1e94c084-6f19-4d3b-88fe-e12d4dbf6015"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") },
                    { new Guid("1e94c084-6f19-4d3b-88fe-e12d4dbf6015"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") },
                    { new Guid("25a8aed0-6640-4f6c-97f9-a797419640c9"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("25a8aed0-6640-4f6c-97f9-a797419640c9"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("25a8aed0-6640-4f6c-97f9-a797419640c9"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("25a8aed0-6640-4f6c-97f9-a797419640c9"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("25a8aed0-6640-4f6c-97f9-a797419640c9"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("2aa6588c-b999-42b8-bc98-71512e3e0616"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") },
                    { new Guid("2aa6588c-b999-42b8-bc98-71512e3e0616"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") },
                    { new Guid("2aa6588c-b999-42b8-bc98-71512e3e0616"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("2c55c172-73c6-4e84-9d30-df45a11364fc"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("2c55c172-73c6-4e84-9d30-df45a11364fc"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("2c55c172-73c6-4e84-9d30-df45a11364fc"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("2c55c172-73c6-4e84-9d30-df45a11364fc"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("2c55c172-73c6-4e84-9d30-df45a11364fc"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("2d00f75c-e127-4bdb-b390-271c43f51fc5"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("2d00f75c-e127-4bdb-b390-271c43f51fc5"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("2d00f75c-e127-4bdb-b390-271c43f51fc5"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("2d00f75c-e127-4bdb-b390-271c43f51fc5"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("2d00f75c-e127-4bdb-b390-271c43f51fc5"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("33e65c77-5987-4482-a241-e8d48384d09a"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") },
                    { new Guid("33e65c77-5987-4482-a241-e8d48384d09a"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") },
                    { new Guid("33e65c77-5987-4482-a241-e8d48384d09a"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") },
                    { new Guid("37b64d7b-d9a7-4fb2-8ea0-79ffc5a1efbf"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("37b64d7b-d9a7-4fb2-8ea0-79ffc5a1efbf"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("37b64d7b-d9a7-4fb2-8ea0-79ffc5a1efbf"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("37b64d7b-d9a7-4fb2-8ea0-79ffc5a1efbf"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("37b64d7b-d9a7-4fb2-8ea0-79ffc5a1efbf"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("45593135-7c96-4afc-a226-827bffbf40f6"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("45593135-7c96-4afc-a226-827bffbf40f6"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("45593135-7c96-4afc-a226-827bffbf40f6"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") },
                    { new Guid("45593135-7c96-4afc-a226-827bffbf40f6"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") },
                    { new Guid("45593135-7c96-4afc-a226-827bffbf40f6"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("45593135-7c96-4afc-a226-827bffbf40f6"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") },
                    { new Guid("45593135-7c96-4afc-a226-827bffbf40f6"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("45593135-7c96-4afc-a226-827bffbf40f6"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("45593135-7c96-4afc-a226-827bffbf40f6"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") },
                    { new Guid("45593135-7c96-4afc-a226-827bffbf40f6"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") },
                    { new Guid("534abbac-10c2-4a24-a8cb-5857ad12488a"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") },
                    { new Guid("534abbac-10c2-4a24-a8cb-5857ad12488a"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") },
                    { new Guid("534abbac-10c2-4a24-a8cb-5857ad12488a"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") },
                    { new Guid("566818dd-6065-4cb4-9bcf-e8406467594c"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") },
                    { new Guid("566818dd-6065-4cb4-9bcf-e8406467594c"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") },
                    { new Guid("566818dd-6065-4cb4-9bcf-e8406467594c"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("58bfeb75-ce29-44e5-bfdd-3c57d1d3b215"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") },
                    { new Guid("58bfeb75-ce29-44e5-bfdd-3c57d1d3b215"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") },
                    { new Guid("58bfeb75-ce29-44e5-bfdd-3c57d1d3b215"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("5fc6182f-e4c2-4217-ac43-86123fd559bd"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") },
                    { new Guid("5fc6182f-e4c2-4217-ac43-86123fd559bd"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") },
                    { new Guid("5fc6182f-e4c2-4217-ac43-86123fd559bd"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("6324823f-33bf-4751-83e1-ada3a8d99b4f"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") },
                    { new Guid("6324823f-33bf-4751-83e1-ada3a8d99b4f"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") },
                    { new Guid("6324823f-33bf-4751-83e1-ada3a8d99b4f"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") },
                    { new Guid("6425ff54-1abf-4012-a616-96dd188ae62f"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("6425ff54-1abf-4012-a616-96dd188ae62f"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("6425ff54-1abf-4012-a616-96dd188ae62f"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("6425ff54-1abf-4012-a616-96dd188ae62f"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("6425ff54-1abf-4012-a616-96dd188ae62f"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("648d0504-2178-4f81-aa4b-5510bf69cca4"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("648d0504-2178-4f81-aa4b-5510bf69cca4"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("648d0504-2178-4f81-aa4b-5510bf69cca4"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") },
                    { new Guid("648d0504-2178-4f81-aa4b-5510bf69cca4"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") },
                    { new Guid("648d0504-2178-4f81-aa4b-5510bf69cca4"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("648d0504-2178-4f81-aa4b-5510bf69cca4"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") },
                    { new Guid("648d0504-2178-4f81-aa4b-5510bf69cca4"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("648d0504-2178-4f81-aa4b-5510bf69cca4"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("648d0504-2178-4f81-aa4b-5510bf69cca4"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") },
                    { new Guid("648d0504-2178-4f81-aa4b-5510bf69cca4"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") },
                    { new Guid("76625912-a4f8-4226-97fb-e3866d5dc2cf"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") },
                    { new Guid("76625912-a4f8-4226-97fb-e3866d5dc2cf"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") },
                    { new Guid("76625912-a4f8-4226-97fb-e3866d5dc2cf"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") },
                    { new Guid("76962c57-3fe9-4e54-b0a8-e8f50b418754"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("76962c57-3fe9-4e54-b0a8-e8f50b418754"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("76962c57-3fe9-4e54-b0a8-e8f50b418754"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("76962c57-3fe9-4e54-b0a8-e8f50b418754"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("76962c57-3fe9-4e54-b0a8-e8f50b418754"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("7cd272f5-3b5d-4d1a-9ae6-190c81301f8d"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") },
                    { new Guid("7cd272f5-3b5d-4d1a-9ae6-190c81301f8d"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") },
                    { new Guid("7cd272f5-3b5d-4d1a-9ae6-190c81301f8d"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") },
                    { new Guid("9053f060-28f6-4186-8f76-0f59fc9f9195"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("9053f060-28f6-4186-8f76-0f59fc9f9195"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("9053f060-28f6-4186-8f76-0f59fc9f9195"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") },
                    { new Guid("9053f060-28f6-4186-8f76-0f59fc9f9195"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") },
                    { new Guid("9053f060-28f6-4186-8f76-0f59fc9f9195"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("9053f060-28f6-4186-8f76-0f59fc9f9195"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") },
                    { new Guid("9053f060-28f6-4186-8f76-0f59fc9f9195"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("9053f060-28f6-4186-8f76-0f59fc9f9195"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("9053f060-28f6-4186-8f76-0f59fc9f9195"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") },
                    { new Guid("9053f060-28f6-4186-8f76-0f59fc9f9195"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") },
                    { new Guid("a3393a58-37a6-4b16-950a-3a8693df733e"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("a3393a58-37a6-4b16-950a-3a8693df733e"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("a3393a58-37a6-4b16-950a-3a8693df733e"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("a3393a58-37a6-4b16-950a-3a8693df733e"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("a3393a58-37a6-4b16-950a-3a8693df733e"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("b0055e5f-de6f-46e4-a2fc-fa8c749401de"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("b0055e5f-de6f-46e4-a2fc-fa8c749401de"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("b0055e5f-de6f-46e4-a2fc-fa8c749401de"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("b0055e5f-de6f-46e4-a2fc-fa8c749401de"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("b0055e5f-de6f-46e4-a2fc-fa8c749401de"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("b41eb4ea-1cbf-4947-a029-55314a22e965"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("b41eb4ea-1cbf-4947-a029-55314a22e965"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("b41eb4ea-1cbf-4947-a029-55314a22e965"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("b41eb4ea-1cbf-4947-a029-55314a22e965"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("b41eb4ea-1cbf-4947-a029-55314a22e965"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("b4567409-1dec-4d77-826a-284975a546ab"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") },
                    { new Guid("b4567409-1dec-4d77-826a-284975a546ab"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") },
                    { new Guid("b4567409-1dec-4d77-826a-284975a546ab"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") },
                    { new Guid("b61013e1-17ff-4972-998f-69d79ad1072c"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("b61013e1-17ff-4972-998f-69d79ad1072c"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("b61013e1-17ff-4972-998f-69d79ad1072c"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") },
                    { new Guid("b61013e1-17ff-4972-998f-69d79ad1072c"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") },
                    { new Guid("b61013e1-17ff-4972-998f-69d79ad1072c"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("b61013e1-17ff-4972-998f-69d79ad1072c"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") },
                    { new Guid("b61013e1-17ff-4972-998f-69d79ad1072c"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("b61013e1-17ff-4972-998f-69d79ad1072c"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("b61013e1-17ff-4972-998f-69d79ad1072c"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") },
                    { new Guid("b61013e1-17ff-4972-998f-69d79ad1072c"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") },
                    { new Guid("b8c954e1-b873-4255-a2b0-917cd4b47b32"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") },
                    { new Guid("b8c954e1-b873-4255-a2b0-917cd4b47b32"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") },
                    { new Guid("b8c954e1-b873-4255-a2b0-917cd4b47b32"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") },
                    { new Guid("bac15d33-070a-4b6a-8019-9d1a4b6faacc"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") },
                    { new Guid("bac15d33-070a-4b6a-8019-9d1a4b6faacc"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") },
                    { new Guid("bac15d33-070a-4b6a-8019-9d1a4b6faacc"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") },
                    { new Guid("bd17b2ee-1fe3-4e07-8743-68953d3dbb7f"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") },
                    { new Guid("bd17b2ee-1fe3-4e07-8743-68953d3dbb7f"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") },
                    { new Guid("bd17b2ee-1fe3-4e07-8743-68953d3dbb7f"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") },
                    { new Guid("bf63dac8-1d49-4800-9af0-29705c641502"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("bf63dac8-1d49-4800-9af0-29705c641502"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("bf63dac8-1d49-4800-9af0-29705c641502"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") },
                    { new Guid("bf63dac8-1d49-4800-9af0-29705c641502"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") },
                    { new Guid("bf63dac8-1d49-4800-9af0-29705c641502"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("bf63dac8-1d49-4800-9af0-29705c641502"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") },
                    { new Guid("bf63dac8-1d49-4800-9af0-29705c641502"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("bf63dac8-1d49-4800-9af0-29705c641502"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("bf63dac8-1d49-4800-9af0-29705c641502"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") },
                    { new Guid("bf63dac8-1d49-4800-9af0-29705c641502"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") },
                    { new Guid("c4cf6c32-bbd0-4da2-8212-31ed6979d939"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("c4cf6c32-bbd0-4da2-8212-31ed6979d939"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("c4cf6c32-bbd0-4da2-8212-31ed6979d939"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") },
                    { new Guid("c4cf6c32-bbd0-4da2-8212-31ed6979d939"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") },
                    { new Guid("c4cf6c32-bbd0-4da2-8212-31ed6979d939"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("c4cf6c32-bbd0-4da2-8212-31ed6979d939"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") },
                    { new Guid("c4cf6c32-bbd0-4da2-8212-31ed6979d939"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("c4cf6c32-bbd0-4da2-8212-31ed6979d939"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("c4cf6c32-bbd0-4da2-8212-31ed6979d939"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") },
                    { new Guid("c4cf6c32-bbd0-4da2-8212-31ed6979d939"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") },
                    { new Guid("cc21448c-0978-43c4-8dca-aaa8fc48c5ce"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("cc21448c-0978-43c4-8dca-aaa8fc48c5ce"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("cc21448c-0978-43c4-8dca-aaa8fc48c5ce"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("cc21448c-0978-43c4-8dca-aaa8fc48c5ce"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("cc21448c-0978-43c4-8dca-aaa8fc48c5ce"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("cdc72686-fb25-4622-a3e8-f98a2db7a1fe"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("cdc72686-fb25-4622-a3e8-f98a2db7a1fe"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("cdc72686-fb25-4622-a3e8-f98a2db7a1fe"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("cdc72686-fb25-4622-a3e8-f98a2db7a1fe"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("cdc72686-fb25-4622-a3e8-f98a2db7a1fe"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("cfc32ba1-be48-4c94-8fe8-e1fc2128b5bb"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("cfc32ba1-be48-4c94-8fe8-e1fc2128b5bb"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("cfc32ba1-be48-4c94-8fe8-e1fc2128b5bb"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("cfc32ba1-be48-4c94-8fe8-e1fc2128b5bb"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("cfc32ba1-be48-4c94-8fe8-e1fc2128b5bb"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("d0ea86d3-ef15-4a5a-b2bc-e694447350c2"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") },
                    { new Guid("d0ea86d3-ef15-4a5a-b2bc-e694447350c2"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") },
                    { new Guid("d0ea86d3-ef15-4a5a-b2bc-e694447350c2"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") },
                    { new Guid("d19940ff-85ff-4cdc-a4bd-4241782025b3"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") },
                    { new Guid("d19940ff-85ff-4cdc-a4bd-4241782025b3"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") },
                    { new Guid("d19940ff-85ff-4cdc-a4bd-4241782025b3"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("e026d538-a71f-4064-80f3-07221f63e79c"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("e026d538-a71f-4064-80f3-07221f63e79c"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("e026d538-a71f-4064-80f3-07221f63e79c"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("e026d538-a71f-4064-80f3-07221f63e79c"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("e026d538-a71f-4064-80f3-07221f63e79c"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("e381f44d-16da-4d13-99bd-ccada05fed7d"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") },
                    { new Guid("e381f44d-16da-4d13-99bd-ccada05fed7d"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") },
                    { new Guid("e381f44d-16da-4d13-99bd-ccada05fed7d"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") },
                    { new Guid("ea210e41-809d-442d-9d65-940f4953fa15"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("ea210e41-809d-442d-9d65-940f4953fa15"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("ea210e41-809d-442d-9d65-940f4953fa15"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") },
                    { new Guid("ea210e41-809d-442d-9d65-940f4953fa15"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") },
                    { new Guid("ea210e41-809d-442d-9d65-940f4953fa15"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("ea210e41-809d-442d-9d65-940f4953fa15"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") },
                    { new Guid("ea210e41-809d-442d-9d65-940f4953fa15"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("ea210e41-809d-442d-9d65-940f4953fa15"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("ea210e41-809d-442d-9d65-940f4953fa15"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") },
                    { new Guid("ea210e41-809d-442d-9d65-940f4953fa15"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") },
                    { new Guid("fd352840-6074-4299-9e83-0df81fedb097"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") },
                    { new Guid("fd352840-6074-4299-9e83-0df81fedb097"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") },
                    { new Guid("fd352840-6074-4299-9e83-0df81fedb097"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") },
                    { new Guid("fd352840-6074-4299-9e83-0df81fedb097"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") },
                    { new Guid("fd352840-6074-4299-9e83-0df81fedb097"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") },
                    { new Guid("fd352840-6074-4299-9e83-0df81fedb097"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") },
                    { new Guid("fd352840-6074-4299-9e83-0df81fedb097"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") },
                    { new Guid("fd352840-6074-4299-9e83-0df81fedb097"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") },
                    { new Guid("fd352840-6074-4299-9e83-0df81fedb097"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") },
                    { new Guid("fd352840-6074-4299-9e83-0df81fedb097"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("06dad6c1-2f8b-4e61-afe2-a584c662e3db"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("06dad6c1-2f8b-4e61-afe2-a584c662e3db"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("06dad6c1-2f8b-4e61-afe2-a584c662e3db"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d00a92a-332e-408d-bf08-f496b239f91c"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d00a92a-332e-408d-bf08-f496b239f91c"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d00a92a-332e-408d-bf08-f496b239f91c"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d00a92a-332e-408d-bf08-f496b239f91c"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d00a92a-332e-408d-bf08-f496b239f91c"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d00a92a-332e-408d-bf08-f496b239f91c"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d00a92a-332e-408d-bf08-f496b239f91c"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d00a92a-332e-408d-bf08-f496b239f91c"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d00a92a-332e-408d-bf08-f496b239f91c"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d00a92a-332e-408d-bf08-f496b239f91c"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("180a99f4-bfd9-4907-a2d5-78acfa5a73c0"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("180a99f4-bfd9-4907-a2d5-78acfa5a73c0"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("180a99f4-bfd9-4907-a2d5-78acfa5a73c0"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("180a99f4-bfd9-4907-a2d5-78acfa5a73c0"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("180a99f4-bfd9-4907-a2d5-78acfa5a73c0"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("180a99f4-bfd9-4907-a2d5-78acfa5a73c0"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("180a99f4-bfd9-4907-a2d5-78acfa5a73c0"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("180a99f4-bfd9-4907-a2d5-78acfa5a73c0"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("180a99f4-bfd9-4907-a2d5-78acfa5a73c0"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("180a99f4-bfd9-4907-a2d5-78acfa5a73c0"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1e94c084-6f19-4d3b-88fe-e12d4dbf6015"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1e94c084-6f19-4d3b-88fe-e12d4dbf6015"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1e94c084-6f19-4d3b-88fe-e12d4dbf6015"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1e94c084-6f19-4d3b-88fe-e12d4dbf6015"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1e94c084-6f19-4d3b-88fe-e12d4dbf6015"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1e94c084-6f19-4d3b-88fe-e12d4dbf6015"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1e94c084-6f19-4d3b-88fe-e12d4dbf6015"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1e94c084-6f19-4d3b-88fe-e12d4dbf6015"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1e94c084-6f19-4d3b-88fe-e12d4dbf6015"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1e94c084-6f19-4d3b-88fe-e12d4dbf6015"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("25a8aed0-6640-4f6c-97f9-a797419640c9"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("25a8aed0-6640-4f6c-97f9-a797419640c9"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("25a8aed0-6640-4f6c-97f9-a797419640c9"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("25a8aed0-6640-4f6c-97f9-a797419640c9"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("25a8aed0-6640-4f6c-97f9-a797419640c9"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2aa6588c-b999-42b8-bc98-71512e3e0616"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2aa6588c-b999-42b8-bc98-71512e3e0616"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2aa6588c-b999-42b8-bc98-71512e3e0616"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2c55c172-73c6-4e84-9d30-df45a11364fc"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2c55c172-73c6-4e84-9d30-df45a11364fc"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2c55c172-73c6-4e84-9d30-df45a11364fc"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2c55c172-73c6-4e84-9d30-df45a11364fc"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2c55c172-73c6-4e84-9d30-df45a11364fc"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2d00f75c-e127-4bdb-b390-271c43f51fc5"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2d00f75c-e127-4bdb-b390-271c43f51fc5"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2d00f75c-e127-4bdb-b390-271c43f51fc5"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2d00f75c-e127-4bdb-b390-271c43f51fc5"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2d00f75c-e127-4bdb-b390-271c43f51fc5"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("33e65c77-5987-4482-a241-e8d48384d09a"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("33e65c77-5987-4482-a241-e8d48384d09a"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("33e65c77-5987-4482-a241-e8d48384d09a"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("37b64d7b-d9a7-4fb2-8ea0-79ffc5a1efbf"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("37b64d7b-d9a7-4fb2-8ea0-79ffc5a1efbf"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("37b64d7b-d9a7-4fb2-8ea0-79ffc5a1efbf"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("37b64d7b-d9a7-4fb2-8ea0-79ffc5a1efbf"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("37b64d7b-d9a7-4fb2-8ea0-79ffc5a1efbf"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("45593135-7c96-4afc-a226-827bffbf40f6"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("45593135-7c96-4afc-a226-827bffbf40f6"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("45593135-7c96-4afc-a226-827bffbf40f6"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("45593135-7c96-4afc-a226-827bffbf40f6"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("45593135-7c96-4afc-a226-827bffbf40f6"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("45593135-7c96-4afc-a226-827bffbf40f6"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("45593135-7c96-4afc-a226-827bffbf40f6"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("45593135-7c96-4afc-a226-827bffbf40f6"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("45593135-7c96-4afc-a226-827bffbf40f6"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("45593135-7c96-4afc-a226-827bffbf40f6"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("534abbac-10c2-4a24-a8cb-5857ad12488a"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("534abbac-10c2-4a24-a8cb-5857ad12488a"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("534abbac-10c2-4a24-a8cb-5857ad12488a"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("566818dd-6065-4cb4-9bcf-e8406467594c"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("566818dd-6065-4cb4-9bcf-e8406467594c"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("566818dd-6065-4cb4-9bcf-e8406467594c"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("58bfeb75-ce29-44e5-bfdd-3c57d1d3b215"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("58bfeb75-ce29-44e5-bfdd-3c57d1d3b215"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("58bfeb75-ce29-44e5-bfdd-3c57d1d3b215"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5fc6182f-e4c2-4217-ac43-86123fd559bd"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5fc6182f-e4c2-4217-ac43-86123fd559bd"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5fc6182f-e4c2-4217-ac43-86123fd559bd"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6324823f-33bf-4751-83e1-ada3a8d99b4f"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6324823f-33bf-4751-83e1-ada3a8d99b4f"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6324823f-33bf-4751-83e1-ada3a8d99b4f"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6425ff54-1abf-4012-a616-96dd188ae62f"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6425ff54-1abf-4012-a616-96dd188ae62f"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6425ff54-1abf-4012-a616-96dd188ae62f"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6425ff54-1abf-4012-a616-96dd188ae62f"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6425ff54-1abf-4012-a616-96dd188ae62f"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("648d0504-2178-4f81-aa4b-5510bf69cca4"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("648d0504-2178-4f81-aa4b-5510bf69cca4"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("648d0504-2178-4f81-aa4b-5510bf69cca4"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("648d0504-2178-4f81-aa4b-5510bf69cca4"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("648d0504-2178-4f81-aa4b-5510bf69cca4"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("648d0504-2178-4f81-aa4b-5510bf69cca4"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("648d0504-2178-4f81-aa4b-5510bf69cca4"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("648d0504-2178-4f81-aa4b-5510bf69cca4"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("648d0504-2178-4f81-aa4b-5510bf69cca4"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("648d0504-2178-4f81-aa4b-5510bf69cca4"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("76625912-a4f8-4226-97fb-e3866d5dc2cf"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("76625912-a4f8-4226-97fb-e3866d5dc2cf"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("76625912-a4f8-4226-97fb-e3866d5dc2cf"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("76962c57-3fe9-4e54-b0a8-e8f50b418754"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("76962c57-3fe9-4e54-b0a8-e8f50b418754"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("76962c57-3fe9-4e54-b0a8-e8f50b418754"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("76962c57-3fe9-4e54-b0a8-e8f50b418754"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("76962c57-3fe9-4e54-b0a8-e8f50b418754"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7cd272f5-3b5d-4d1a-9ae6-190c81301f8d"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7cd272f5-3b5d-4d1a-9ae6-190c81301f8d"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7cd272f5-3b5d-4d1a-9ae6-190c81301f8d"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9053f060-28f6-4186-8f76-0f59fc9f9195"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9053f060-28f6-4186-8f76-0f59fc9f9195"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9053f060-28f6-4186-8f76-0f59fc9f9195"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9053f060-28f6-4186-8f76-0f59fc9f9195"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9053f060-28f6-4186-8f76-0f59fc9f9195"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9053f060-28f6-4186-8f76-0f59fc9f9195"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9053f060-28f6-4186-8f76-0f59fc9f9195"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9053f060-28f6-4186-8f76-0f59fc9f9195"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9053f060-28f6-4186-8f76-0f59fc9f9195"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9053f060-28f6-4186-8f76-0f59fc9f9195"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a3393a58-37a6-4b16-950a-3a8693df733e"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a3393a58-37a6-4b16-950a-3a8693df733e"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a3393a58-37a6-4b16-950a-3a8693df733e"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a3393a58-37a6-4b16-950a-3a8693df733e"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a3393a58-37a6-4b16-950a-3a8693df733e"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b0055e5f-de6f-46e4-a2fc-fa8c749401de"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b0055e5f-de6f-46e4-a2fc-fa8c749401de"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b0055e5f-de6f-46e4-a2fc-fa8c749401de"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b0055e5f-de6f-46e4-a2fc-fa8c749401de"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b0055e5f-de6f-46e4-a2fc-fa8c749401de"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b41eb4ea-1cbf-4947-a029-55314a22e965"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b41eb4ea-1cbf-4947-a029-55314a22e965"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b41eb4ea-1cbf-4947-a029-55314a22e965"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b41eb4ea-1cbf-4947-a029-55314a22e965"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b41eb4ea-1cbf-4947-a029-55314a22e965"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b4567409-1dec-4d77-826a-284975a546ab"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b4567409-1dec-4d77-826a-284975a546ab"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b4567409-1dec-4d77-826a-284975a546ab"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b61013e1-17ff-4972-998f-69d79ad1072c"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b61013e1-17ff-4972-998f-69d79ad1072c"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b61013e1-17ff-4972-998f-69d79ad1072c"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b61013e1-17ff-4972-998f-69d79ad1072c"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b61013e1-17ff-4972-998f-69d79ad1072c"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b61013e1-17ff-4972-998f-69d79ad1072c"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b61013e1-17ff-4972-998f-69d79ad1072c"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b61013e1-17ff-4972-998f-69d79ad1072c"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b61013e1-17ff-4972-998f-69d79ad1072c"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b61013e1-17ff-4972-998f-69d79ad1072c"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b8c954e1-b873-4255-a2b0-917cd4b47b32"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b8c954e1-b873-4255-a2b0-917cd4b47b32"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b8c954e1-b873-4255-a2b0-917cd4b47b32"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bac15d33-070a-4b6a-8019-9d1a4b6faacc"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bac15d33-070a-4b6a-8019-9d1a4b6faacc"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bac15d33-070a-4b6a-8019-9d1a4b6faacc"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bd17b2ee-1fe3-4e07-8743-68953d3dbb7f"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bd17b2ee-1fe3-4e07-8743-68953d3dbb7f"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bd17b2ee-1fe3-4e07-8743-68953d3dbb7f"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bf63dac8-1d49-4800-9af0-29705c641502"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bf63dac8-1d49-4800-9af0-29705c641502"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bf63dac8-1d49-4800-9af0-29705c641502"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bf63dac8-1d49-4800-9af0-29705c641502"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bf63dac8-1d49-4800-9af0-29705c641502"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bf63dac8-1d49-4800-9af0-29705c641502"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bf63dac8-1d49-4800-9af0-29705c641502"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bf63dac8-1d49-4800-9af0-29705c641502"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bf63dac8-1d49-4800-9af0-29705c641502"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bf63dac8-1d49-4800-9af0-29705c641502"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c4cf6c32-bbd0-4da2-8212-31ed6979d939"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c4cf6c32-bbd0-4da2-8212-31ed6979d939"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c4cf6c32-bbd0-4da2-8212-31ed6979d939"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c4cf6c32-bbd0-4da2-8212-31ed6979d939"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c4cf6c32-bbd0-4da2-8212-31ed6979d939"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c4cf6c32-bbd0-4da2-8212-31ed6979d939"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c4cf6c32-bbd0-4da2-8212-31ed6979d939"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c4cf6c32-bbd0-4da2-8212-31ed6979d939"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c4cf6c32-bbd0-4da2-8212-31ed6979d939"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c4cf6c32-bbd0-4da2-8212-31ed6979d939"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cc21448c-0978-43c4-8dca-aaa8fc48c5ce"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cc21448c-0978-43c4-8dca-aaa8fc48c5ce"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cc21448c-0978-43c4-8dca-aaa8fc48c5ce"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cc21448c-0978-43c4-8dca-aaa8fc48c5ce"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cc21448c-0978-43c4-8dca-aaa8fc48c5ce"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cdc72686-fb25-4622-a3e8-f98a2db7a1fe"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cdc72686-fb25-4622-a3e8-f98a2db7a1fe"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cdc72686-fb25-4622-a3e8-f98a2db7a1fe"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cdc72686-fb25-4622-a3e8-f98a2db7a1fe"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cdc72686-fb25-4622-a3e8-f98a2db7a1fe"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cfc32ba1-be48-4c94-8fe8-e1fc2128b5bb"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cfc32ba1-be48-4c94-8fe8-e1fc2128b5bb"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cfc32ba1-be48-4c94-8fe8-e1fc2128b5bb"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cfc32ba1-be48-4c94-8fe8-e1fc2128b5bb"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cfc32ba1-be48-4c94-8fe8-e1fc2128b5bb"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d0ea86d3-ef15-4a5a-b2bc-e694447350c2"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d0ea86d3-ef15-4a5a-b2bc-e694447350c2"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d0ea86d3-ef15-4a5a-b2bc-e694447350c2"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d19940ff-85ff-4cdc-a4bd-4241782025b3"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d19940ff-85ff-4cdc-a4bd-4241782025b3"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d19940ff-85ff-4cdc-a4bd-4241782025b3"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e026d538-a71f-4064-80f3-07221f63e79c"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e026d538-a71f-4064-80f3-07221f63e79c"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e026d538-a71f-4064-80f3-07221f63e79c"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e026d538-a71f-4064-80f3-07221f63e79c"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e026d538-a71f-4064-80f3-07221f63e79c"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e381f44d-16da-4d13-99bd-ccada05fed7d"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e381f44d-16da-4d13-99bd-ccada05fed7d"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e381f44d-16da-4d13-99bd-ccada05fed7d"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ea210e41-809d-442d-9d65-940f4953fa15"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ea210e41-809d-442d-9d65-940f4953fa15"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ea210e41-809d-442d-9d65-940f4953fa15"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ea210e41-809d-442d-9d65-940f4953fa15"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ea210e41-809d-442d-9d65-940f4953fa15"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ea210e41-809d-442d-9d65-940f4953fa15"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ea210e41-809d-442d-9d65-940f4953fa15"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ea210e41-809d-442d-9d65-940f4953fa15"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ea210e41-809d-442d-9d65-940f4953fa15"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ea210e41-809d-442d-9d65-940f4953fa15"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fd352840-6074-4299-9e83-0df81fedb097"), new Guid("01dbba0e-177c-4540-876c-8af29235658b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fd352840-6074-4299-9e83-0df81fedb097"), new Guid("1ccc748f-585a-4151-9774-9a63fd152af8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fd352840-6074-4299-9e83-0df81fedb097"), new Guid("253f7d5d-942a-4603-a778-d139e663ba4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fd352840-6074-4299-9e83-0df81fedb097"), new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fd352840-6074-4299-9e83-0df81fedb097"), new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fd352840-6074-4299-9e83-0df81fedb097"), new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fd352840-6074-4299-9e83-0df81fedb097"), new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fd352840-6074-4299-9e83-0df81fedb097"), new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fd352840-6074-4299-9e83-0df81fedb097"), new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fd352840-6074-4299-9e83-0df81fedb097"), new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("06dad6c1-2f8b-4e61-afe2-a584c662e3db"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0d00a92a-332e-408d-bf08-f496b239f91c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("180a99f4-bfd9-4907-a2d5-78acfa5a73c0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1e94c084-6f19-4d3b-88fe-e12d4dbf6015"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("25a8aed0-6640-4f6c-97f9-a797419640c9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2aa6588c-b999-42b8-bc98-71512e3e0616"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2c55c172-73c6-4e84-9d30-df45a11364fc"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2d00f75c-e127-4bdb-b390-271c43f51fc5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("33e65c77-5987-4482-a241-e8d48384d09a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("37b64d7b-d9a7-4fb2-8ea0-79ffc5a1efbf"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("45593135-7c96-4afc-a226-827bffbf40f6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("534abbac-10c2-4a24-a8cb-5857ad12488a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("566818dd-6065-4cb4-9bcf-e8406467594c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("58bfeb75-ce29-44e5-bfdd-3c57d1d3b215"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5fc6182f-e4c2-4217-ac43-86123fd559bd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6324823f-33bf-4751-83e1-ada3a8d99b4f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6425ff54-1abf-4012-a616-96dd188ae62f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("648d0504-2178-4f81-aa4b-5510bf69cca4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("76625912-a4f8-4226-97fb-e3866d5dc2cf"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("76962c57-3fe9-4e54-b0a8-e8f50b418754"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7cd272f5-3b5d-4d1a-9ae6-190c81301f8d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9053f060-28f6-4186-8f76-0f59fc9f9195"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a3393a58-37a6-4b16-950a-3a8693df733e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b0055e5f-de6f-46e4-a2fc-fa8c749401de"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b41eb4ea-1cbf-4947-a029-55314a22e965"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b4567409-1dec-4d77-826a-284975a546ab"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b61013e1-17ff-4972-998f-69d79ad1072c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b8c954e1-b873-4255-a2b0-917cd4b47b32"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bac15d33-070a-4b6a-8019-9d1a4b6faacc"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bd17b2ee-1fe3-4e07-8743-68953d3dbb7f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bf63dac8-1d49-4800-9af0-29705c641502"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c4cf6c32-bbd0-4da2-8212-31ed6979d939"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cc21448c-0978-43c4-8dca-aaa8fc48c5ce"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cdc72686-fb25-4622-a3e8-f98a2db7a1fe"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cfc32ba1-be48-4c94-8fe8-e1fc2128b5bb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d0ea86d3-ef15-4a5a-b2bc-e694447350c2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d19940ff-85ff-4cdc-a4bd-4241782025b3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e026d538-a71f-4064-80f3-07221f63e79c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e381f44d-16da-4d13-99bd-ccada05fed7d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ea210e41-809d-442d-9d65-940f4953fa15"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fd352840-6074-4299-9e83-0df81fedb097"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01dbba0e-177c-4540-876c-8af29235658b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ccc748f-585a-4151-9774-9a63fd152af8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("253f7d5d-942a-4603-a778-d139e663ba4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ad2de58-a0f2-4470-b7d7-5bfb1109accf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ac142d4-569b-4d5e-a30e-8b482ca2b74d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73c6f1d9-49de-4ee0-b442-9f6134c95c4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9843bb5e-ba69-4925-8a30-9d874ce4269a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3c7db5e-998c-49f1-a313-d48d2c0ebd56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba6580e0-d5cb-4f2c-bd14-55ef551cb7b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f529643b-9d32-4f8b-b0d0-b90ff669666e"));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("01d254b7-37a9-4693-903d-405bfd06eeb2"), "addsensor-windowsensor" },
                    { new Guid("05180053-fa51-4263-b26c-c8eb55d0cc2f"), "motiondetection-motionsensor" },
                    { new Guid("07e8ff14-1ce0-457d-970c-69c745eb574e"), "createcompany-companies" },
                    { new Guid("09f8a3de-43f3-42e4-99c5-09b1fb91b24c"), "getmembers-members" },
                    { new Guid("0e7edc7b-9688-4f76-a0f7-3baba00dd077"), "persondetection-camera" },
                    { new Guid("123192d4-318e-4395-8bfe-fc8ac1e5f6c7"), "addcamera-camera" },
                    { new Guid("18d90191-4dac-4b79-a2b2-4ca4a910c20b"), "addmotionsensor-motionsensor" },
                    { new Guid("25a95351-ac71-4b27-b4a5-ffd76b355d5c"), "addhomeownerpermission-homeowner" },
                    { new Guid("31fa3476-ffea-408c-8d11-0e345d9e6e9b"), "addsmartlamp-smartlamp" },
                    { new Guid("34706640-abae-4206-b395-8688da213ee4"), "getpermissions-home" },
                    { new Guid("4285bf3b-2150-4c7d-bde0-2ae392f8c4e8"), "close-windowsensor" },
                    { new Guid("46442ca2-3775-49b9-af9e-3794214a71e0"), "getaccounts-accounts" },
                    { new Guid("4e784112-5544-4879-98db-8daaf9082135"), "addmotionsensor-motionsensor" },
                    { new Guid("4f332726-7b86-48f4-b3fe-a9ab53057d12"), "deleteadminaccount-administrator" },
                    { new Guid("5fff3ba2-9f13-4550-956e-1419b425c3a9"), "addnotificationmembers-members" },
                    { new Guid("605daf83-93e6-4742-bcbf-4515107a66b5"), "newhome-home" },
                    { new Guid("6c074926-8c66-4cbc-8693-b04e64a4ca70"), "getcompanyuser-companies" },
                    { new Guid("708eebc6-8f17-4fe5-ae66-c3846e09b182"), "addhomeownerpermission-homeowner" },
                    { new Guid("75e3a6ec-2c71-4cdb-b5b6-27e13e78f8f7"), "createcompanyowneraccount-companyowner" },
                    { new Guid("7ce918b9-9751-4649-a532-923a2fe8e58b"), "getrooms-home" },
                    { new Guid("8314e7a1-9725-4b08-be40-26614781e77f"), "addpermission-members" },
                    { new Guid("8b401275-21e7-4e67-ac64-98fe95d52fb0"), "motiondetection-camera" },
                    { new Guid("9632c2ef-79a4-45e1-90db-064855fd4eee"), "getcompany-companies" },
                    { new Guid("966e3761-9e30-4975-9902-7d6d81fc0e54"), "importdevices-devices" },
                    { new Guid("997ac669-bcd1-4d3c-b38a-1c3050a774bf"), "getimporters-devices" },
                    { new Guid("a02296dc-9392-4ef9-9e3d-5af8e889cc7c"), "open-windowsensor" },
                    { new Guid("a8a546a2-fc19-4496-8f71-7fe2477538bf"), "getdevices-home" },
                    { new Guid("a9c7f68d-80b7-4c26-98a3-a1237d3a74be"), "gethomes-user" },
                    { new Guid("aa44e395-8089-478b-9b17-e3aedeb5f887"), "getnotifications-notification" },
                    { new Guid("ad915dfa-0463-4b42-8e33-11b4539f519c"), "on-smartlamp" },
                    { new Guid("b31418a4-070d-42c8-841e-5aa4de008184"), "off-smartlamp" },
                    { new Guid("c8e9702e-5185-4bda-8ac6-a394171ddb40"), "createadminaccount-administrator" },
                    { new Guid("ce7ff9d8-5936-4c7c-9ba5-c65689bebf05"), "updateroomdevice-home" },
                    { new Guid("d3f4d967-1368-473b-bcee-cedd83518b8c"), "updatenamedevice-home" },
                    { new Guid("d8209c2d-6779-4ce7-b7ff-e0585631a004"), "addrooms-home" },
                    { new Guid("f34af2b3-5e49-4183-95a5-05821cdcb820"), "getdevices-devices" },
                    { new Guid("f75fc379-eb23-49ad-a60e-0b4e0556e7eb"), "getdevicetypes-devicetype" },
                    { new Guid("f8800c36-2e0b-4862-9db2-3f230c19515b"), "adddevice-home" },
                    { new Guid("f97ac710-1562-436d-8ea5-a21da10e372a"), "addmember-members" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Password", "ProfilePhoto", "Roles", "Surname" },
                values: new object[,]
                {
                    { new Guid("032766bb-f502-4422-a235-8c051ad7bbd8"), new DateTime(2024, 11, 17, 0, 49, 48, 680, DateTimeKind.Local).AddTicks(6340), "rogerfederer@tennis.com", "Roger", "Federer@123", "federer.jpg", "[0]", "Federer" },
                    { new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e"), new DateTime(2024, 11, 17, 0, 49, 48, 680, DateTimeKind.Local).AddTicks(6363), "rafaelnadal@tennis.com", "Rafael", "Nadal@123", "nadal.jpg", "[0]", "Nadal" },
                    { new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5"), new DateTime(2024, 11, 17, 0, 49, 48, 680, DateTimeKind.Local).AddTicks(6380), "petesampras@tennis.com", "Pete", "Sampras@123", "sampras.jpg", "[1]", "Sampras" },
                    { new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2"), new DateTime(2024, 11, 17, 0, 49, 48, 680, DateTimeKind.Local).AddTicks(6386), "johnmcenroe@tennis.com", "John", "McEnroe@123", "mcenroe.jpg", "[2]", "McEnroe" },
                    { new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f"), new DateTime(2024, 11, 17, 0, 49, 48, 680, DateTimeKind.Local).AddTicks(6371), "novakdjokovic@tennis.com", "Novak", "Djokovic@123", "djokovic.jpg", "[2,1]", "Djokovic" },
                    { new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab"), new DateTime(2024, 11, 17, 0, 49, 48, 680, DateTimeKind.Local).AddTicks(6374), "steffigraf@tennis.com", "Steffi", "Steffi@123", "graf.jpg", "[1]", "Graf" },
                    { new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01"), new DateTime(2024, 11, 17, 0, 49, 48, 680, DateTimeKind.Local).AddTicks(6390), "billiejeanking@tennis.com", "Billie", "King@123", "king.jpg", "[0]", "Jean King" },
                    { new Guid("8f114abd-8fdb-4983-8859-b242d7439e69"), new DateTime(2024, 11, 17, 0, 49, 48, 680, DateTimeKind.Local).AddTicks(6368), "serenawilliams@tennis.com", "Serena", "Serena@123", "serena.jpg", "[2]", "Williams" },
                    { new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301"), new DateTime(2024, 11, 17, 0, 49, 48, 680, DateTimeKind.Local).AddTicks(6382), "martinanavratilova@tennis.com", "Martina", "Navratilova@123", "navratilova.jpg", "[1]", "Navratilova" },
                    { new Guid("fa960763-b8e2-4fff-957b-61af6be52815"), new DateTime(2024, 11, 17, 0, 49, 48, 680, DateTimeKind.Local).AddTicks(6377), "andreagassi@tennis.com", "Andre", "Agassi@123", "agassi.jpg", "[1]", "Agassi" }
                });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "PermissionId", "UserId" },
                values: new object[,]
                {
                    { new Guid("01d254b7-37a9-4693-903d-405bfd06eeb2"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") },
                    { new Guid("01d254b7-37a9-4693-903d-405bfd06eeb2"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") },
                    { new Guid("01d254b7-37a9-4693-903d-405bfd06eeb2"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") },
                    { new Guid("05180053-fa51-4263-b26c-c8eb55d0cc2f"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") },
                    { new Guid("05180053-fa51-4263-b26c-c8eb55d0cc2f"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") },
                    { new Guid("05180053-fa51-4263-b26c-c8eb55d0cc2f"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("05180053-fa51-4263-b26c-c8eb55d0cc2f"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") },
                    { new Guid("05180053-fa51-4263-b26c-c8eb55d0cc2f"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("05180053-fa51-4263-b26c-c8eb55d0cc2f"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("05180053-fa51-4263-b26c-c8eb55d0cc2f"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") },
                    { new Guid("05180053-fa51-4263-b26c-c8eb55d0cc2f"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") },
                    { new Guid("05180053-fa51-4263-b26c-c8eb55d0cc2f"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("05180053-fa51-4263-b26c-c8eb55d0cc2f"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("07e8ff14-1ce0-457d-970c-69c745eb574e"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") },
                    { new Guid("07e8ff14-1ce0-457d-970c-69c745eb574e"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") },
                    { new Guid("07e8ff14-1ce0-457d-970c-69c745eb574e"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") },
                    { new Guid("09f8a3de-43f3-42e4-99c5-09b1fb91b24c"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("09f8a3de-43f3-42e4-99c5-09b1fb91b24c"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("09f8a3de-43f3-42e4-99c5-09b1fb91b24c"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("09f8a3de-43f3-42e4-99c5-09b1fb91b24c"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("09f8a3de-43f3-42e4-99c5-09b1fb91b24c"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("0e7edc7b-9688-4f76-a0f7-3baba00dd077"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") },
                    { new Guid("0e7edc7b-9688-4f76-a0f7-3baba00dd077"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") },
                    { new Guid("0e7edc7b-9688-4f76-a0f7-3baba00dd077"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("0e7edc7b-9688-4f76-a0f7-3baba00dd077"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") },
                    { new Guid("0e7edc7b-9688-4f76-a0f7-3baba00dd077"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("0e7edc7b-9688-4f76-a0f7-3baba00dd077"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("0e7edc7b-9688-4f76-a0f7-3baba00dd077"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") },
                    { new Guid("0e7edc7b-9688-4f76-a0f7-3baba00dd077"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") },
                    { new Guid("0e7edc7b-9688-4f76-a0f7-3baba00dd077"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("0e7edc7b-9688-4f76-a0f7-3baba00dd077"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("123192d4-318e-4395-8bfe-fc8ac1e5f6c7"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") },
                    { new Guid("123192d4-318e-4395-8bfe-fc8ac1e5f6c7"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") },
                    { new Guid("123192d4-318e-4395-8bfe-fc8ac1e5f6c7"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") },
                    { new Guid("18d90191-4dac-4b79-a2b2-4ca4a910c20b"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("18d90191-4dac-4b79-a2b2-4ca4a910c20b"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("18d90191-4dac-4b79-a2b2-4ca4a910c20b"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("18d90191-4dac-4b79-a2b2-4ca4a910c20b"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("18d90191-4dac-4b79-a2b2-4ca4a910c20b"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("25a95351-ac71-4b27-b4a5-ffd76b355d5c"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") },
                    { new Guid("25a95351-ac71-4b27-b4a5-ffd76b355d5c"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") },
                    { new Guid("25a95351-ac71-4b27-b4a5-ffd76b355d5c"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") },
                    { new Guid("31fa3476-ffea-408c-8d11-0e345d9e6e9b"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") },
                    { new Guid("31fa3476-ffea-408c-8d11-0e345d9e6e9b"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") },
                    { new Guid("31fa3476-ffea-408c-8d11-0e345d9e6e9b"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") },
                    { new Guid("34706640-abae-4206-b395-8688da213ee4"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") },
                    { new Guid("34706640-abae-4206-b395-8688da213ee4"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") },
                    { new Guid("34706640-abae-4206-b395-8688da213ee4"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("34706640-abae-4206-b395-8688da213ee4"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") },
                    { new Guid("34706640-abae-4206-b395-8688da213ee4"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("34706640-abae-4206-b395-8688da213ee4"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("34706640-abae-4206-b395-8688da213ee4"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") },
                    { new Guid("34706640-abae-4206-b395-8688da213ee4"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") },
                    { new Guid("34706640-abae-4206-b395-8688da213ee4"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("34706640-abae-4206-b395-8688da213ee4"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("4285bf3b-2150-4c7d-bde0-2ae392f8c4e8"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") },
                    { new Guid("4285bf3b-2150-4c7d-bde0-2ae392f8c4e8"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") },
                    { new Guid("4285bf3b-2150-4c7d-bde0-2ae392f8c4e8"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("4285bf3b-2150-4c7d-bde0-2ae392f8c4e8"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") },
                    { new Guid("4285bf3b-2150-4c7d-bde0-2ae392f8c4e8"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("4285bf3b-2150-4c7d-bde0-2ae392f8c4e8"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("4285bf3b-2150-4c7d-bde0-2ae392f8c4e8"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") },
                    { new Guid("4285bf3b-2150-4c7d-bde0-2ae392f8c4e8"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") },
                    { new Guid("4285bf3b-2150-4c7d-bde0-2ae392f8c4e8"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("4285bf3b-2150-4c7d-bde0-2ae392f8c4e8"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("46442ca2-3775-49b9-af9e-3794214a71e0"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") },
                    { new Guid("46442ca2-3775-49b9-af9e-3794214a71e0"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("46442ca2-3775-49b9-af9e-3794214a71e0"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") },
                    { new Guid("4e784112-5544-4879-98db-8daaf9082135"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") },
                    { new Guid("4e784112-5544-4879-98db-8daaf9082135"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") },
                    { new Guid("4e784112-5544-4879-98db-8daaf9082135"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") },
                    { new Guid("4f332726-7b86-48f4-b3fe-a9ab53057d12"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") },
                    { new Guid("4f332726-7b86-48f4-b3fe-a9ab53057d12"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("4f332726-7b86-48f4-b3fe-a9ab53057d12"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") },
                    { new Guid("5fff3ba2-9f13-4550-956e-1419b425c3a9"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("5fff3ba2-9f13-4550-956e-1419b425c3a9"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("5fff3ba2-9f13-4550-956e-1419b425c3a9"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("5fff3ba2-9f13-4550-956e-1419b425c3a9"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("5fff3ba2-9f13-4550-956e-1419b425c3a9"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("605daf83-93e6-4742-bcbf-4515107a66b5"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("605daf83-93e6-4742-bcbf-4515107a66b5"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("605daf83-93e6-4742-bcbf-4515107a66b5"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("605daf83-93e6-4742-bcbf-4515107a66b5"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("605daf83-93e6-4742-bcbf-4515107a66b5"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("6c074926-8c66-4cbc-8693-b04e64a4ca70"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") },
                    { new Guid("6c074926-8c66-4cbc-8693-b04e64a4ca70"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") },
                    { new Guid("6c074926-8c66-4cbc-8693-b04e64a4ca70"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") },
                    { new Guid("708eebc6-8f17-4fe5-ae66-c3846e09b182"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") },
                    { new Guid("708eebc6-8f17-4fe5-ae66-c3846e09b182"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("708eebc6-8f17-4fe5-ae66-c3846e09b182"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") },
                    { new Guid("75e3a6ec-2c71-4cdb-b5b6-27e13e78f8f7"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") },
                    { new Guid("75e3a6ec-2c71-4cdb-b5b6-27e13e78f8f7"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("75e3a6ec-2c71-4cdb-b5b6-27e13e78f8f7"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") },
                    { new Guid("7ce918b9-9751-4649-a532-923a2fe8e58b"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("7ce918b9-9751-4649-a532-923a2fe8e58b"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("7ce918b9-9751-4649-a532-923a2fe8e58b"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("7ce918b9-9751-4649-a532-923a2fe8e58b"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("7ce918b9-9751-4649-a532-923a2fe8e58b"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("8314e7a1-9725-4b08-be40-26614781e77f"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("8314e7a1-9725-4b08-be40-26614781e77f"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("8314e7a1-9725-4b08-be40-26614781e77f"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("8314e7a1-9725-4b08-be40-26614781e77f"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("8314e7a1-9725-4b08-be40-26614781e77f"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("8b401275-21e7-4e67-ac64-98fe95d52fb0"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") },
                    { new Guid("8b401275-21e7-4e67-ac64-98fe95d52fb0"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") },
                    { new Guid("8b401275-21e7-4e67-ac64-98fe95d52fb0"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("8b401275-21e7-4e67-ac64-98fe95d52fb0"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") },
                    { new Guid("8b401275-21e7-4e67-ac64-98fe95d52fb0"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("8b401275-21e7-4e67-ac64-98fe95d52fb0"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("8b401275-21e7-4e67-ac64-98fe95d52fb0"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") },
                    { new Guid("8b401275-21e7-4e67-ac64-98fe95d52fb0"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") },
                    { new Guid("8b401275-21e7-4e67-ac64-98fe95d52fb0"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("8b401275-21e7-4e67-ac64-98fe95d52fb0"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("9632c2ef-79a4-45e1-90db-064855fd4eee"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") },
                    { new Guid("9632c2ef-79a4-45e1-90db-064855fd4eee"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("9632c2ef-79a4-45e1-90db-064855fd4eee"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") },
                    { new Guid("966e3761-9e30-4975-9902-7d6d81fc0e54"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") },
                    { new Guid("966e3761-9e30-4975-9902-7d6d81fc0e54"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") },
                    { new Guid("966e3761-9e30-4975-9902-7d6d81fc0e54"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") },
                    { new Guid("997ac669-bcd1-4d3c-b38a-1c3050a774bf"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") },
                    { new Guid("997ac669-bcd1-4d3c-b38a-1c3050a774bf"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") },
                    { new Guid("997ac669-bcd1-4d3c-b38a-1c3050a774bf"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") },
                    { new Guid("a02296dc-9392-4ef9-9e3d-5af8e889cc7c"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") },
                    { new Guid("a02296dc-9392-4ef9-9e3d-5af8e889cc7c"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") },
                    { new Guid("a02296dc-9392-4ef9-9e3d-5af8e889cc7c"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("a02296dc-9392-4ef9-9e3d-5af8e889cc7c"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") },
                    { new Guid("a02296dc-9392-4ef9-9e3d-5af8e889cc7c"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("a02296dc-9392-4ef9-9e3d-5af8e889cc7c"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("a02296dc-9392-4ef9-9e3d-5af8e889cc7c"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") },
                    { new Guid("a02296dc-9392-4ef9-9e3d-5af8e889cc7c"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") },
                    { new Guid("a02296dc-9392-4ef9-9e3d-5af8e889cc7c"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("a02296dc-9392-4ef9-9e3d-5af8e889cc7c"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("a8a546a2-fc19-4496-8f71-7fe2477538bf"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("a8a546a2-fc19-4496-8f71-7fe2477538bf"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("a8a546a2-fc19-4496-8f71-7fe2477538bf"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("a8a546a2-fc19-4496-8f71-7fe2477538bf"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("a8a546a2-fc19-4496-8f71-7fe2477538bf"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("a9c7f68d-80b7-4c26-98a3-a1237d3a74be"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("a9c7f68d-80b7-4c26-98a3-a1237d3a74be"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("a9c7f68d-80b7-4c26-98a3-a1237d3a74be"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("a9c7f68d-80b7-4c26-98a3-a1237d3a74be"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("a9c7f68d-80b7-4c26-98a3-a1237d3a74be"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("aa44e395-8089-478b-9b17-e3aedeb5f887"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") },
                    { new Guid("aa44e395-8089-478b-9b17-e3aedeb5f887"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") },
                    { new Guid("aa44e395-8089-478b-9b17-e3aedeb5f887"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("aa44e395-8089-478b-9b17-e3aedeb5f887"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") },
                    { new Guid("aa44e395-8089-478b-9b17-e3aedeb5f887"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("aa44e395-8089-478b-9b17-e3aedeb5f887"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("aa44e395-8089-478b-9b17-e3aedeb5f887"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") },
                    { new Guid("aa44e395-8089-478b-9b17-e3aedeb5f887"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") },
                    { new Guid("aa44e395-8089-478b-9b17-e3aedeb5f887"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("aa44e395-8089-478b-9b17-e3aedeb5f887"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("ad915dfa-0463-4b42-8e33-11b4539f519c"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") },
                    { new Guid("ad915dfa-0463-4b42-8e33-11b4539f519c"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") },
                    { new Guid("ad915dfa-0463-4b42-8e33-11b4539f519c"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("ad915dfa-0463-4b42-8e33-11b4539f519c"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") },
                    { new Guid("ad915dfa-0463-4b42-8e33-11b4539f519c"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("ad915dfa-0463-4b42-8e33-11b4539f519c"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("ad915dfa-0463-4b42-8e33-11b4539f519c"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") },
                    { new Guid("ad915dfa-0463-4b42-8e33-11b4539f519c"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") },
                    { new Guid("ad915dfa-0463-4b42-8e33-11b4539f519c"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("ad915dfa-0463-4b42-8e33-11b4539f519c"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("b31418a4-070d-42c8-841e-5aa4de008184"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") },
                    { new Guid("b31418a4-070d-42c8-841e-5aa4de008184"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") },
                    { new Guid("b31418a4-070d-42c8-841e-5aa4de008184"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("b31418a4-070d-42c8-841e-5aa4de008184"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") },
                    { new Guid("b31418a4-070d-42c8-841e-5aa4de008184"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("b31418a4-070d-42c8-841e-5aa4de008184"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("b31418a4-070d-42c8-841e-5aa4de008184"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") },
                    { new Guid("b31418a4-070d-42c8-841e-5aa4de008184"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") },
                    { new Guid("b31418a4-070d-42c8-841e-5aa4de008184"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("b31418a4-070d-42c8-841e-5aa4de008184"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("c8e9702e-5185-4bda-8ac6-a394171ddb40"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") },
                    { new Guid("c8e9702e-5185-4bda-8ac6-a394171ddb40"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("c8e9702e-5185-4bda-8ac6-a394171ddb40"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") },
                    { new Guid("ce7ff9d8-5936-4c7c-9ba5-c65689bebf05"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("ce7ff9d8-5936-4c7c-9ba5-c65689bebf05"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("ce7ff9d8-5936-4c7c-9ba5-c65689bebf05"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("ce7ff9d8-5936-4c7c-9ba5-c65689bebf05"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("ce7ff9d8-5936-4c7c-9ba5-c65689bebf05"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("d3f4d967-1368-473b-bcee-cedd83518b8c"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("d3f4d967-1368-473b-bcee-cedd83518b8c"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("d3f4d967-1368-473b-bcee-cedd83518b8c"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("d3f4d967-1368-473b-bcee-cedd83518b8c"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("d3f4d967-1368-473b-bcee-cedd83518b8c"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("d8209c2d-6779-4ce7-b7ff-e0585631a004"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("d8209c2d-6779-4ce7-b7ff-e0585631a004"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("d8209c2d-6779-4ce7-b7ff-e0585631a004"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("d8209c2d-6779-4ce7-b7ff-e0585631a004"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("d8209c2d-6779-4ce7-b7ff-e0585631a004"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("f34af2b3-5e49-4183-95a5-05821cdcb820"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") },
                    { new Guid("f34af2b3-5e49-4183-95a5-05821cdcb820"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") },
                    { new Guid("f34af2b3-5e49-4183-95a5-05821cdcb820"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("f34af2b3-5e49-4183-95a5-05821cdcb820"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") },
                    { new Guid("f34af2b3-5e49-4183-95a5-05821cdcb820"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("f34af2b3-5e49-4183-95a5-05821cdcb820"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("f34af2b3-5e49-4183-95a5-05821cdcb820"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") },
                    { new Guid("f34af2b3-5e49-4183-95a5-05821cdcb820"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") },
                    { new Guid("f34af2b3-5e49-4183-95a5-05821cdcb820"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("f34af2b3-5e49-4183-95a5-05821cdcb820"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("f75fc379-eb23-49ad-a60e-0b4e0556e7eb"), new Guid("032766bb-f502-4422-a235-8c051ad7bbd8") },
                    { new Guid("f75fc379-eb23-49ad-a60e-0b4e0556e7eb"), new Guid("1ed8ae8f-9718-41d9-a4fd-6e8014a60b8e") },
                    { new Guid("f75fc379-eb23-49ad-a60e-0b4e0556e7eb"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("f75fc379-eb23-49ad-a60e-0b4e0556e7eb"), new Guid("5c1cfb37-2a8a-4f71-9ed8-f190cd7302e2") },
                    { new Guid("f75fc379-eb23-49ad-a60e-0b4e0556e7eb"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("f75fc379-eb23-49ad-a60e-0b4e0556e7eb"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("f75fc379-eb23-49ad-a60e-0b4e0556e7eb"), new Guid("87d33311-fc05-4f1f-a5f0-d090d7ef0a01") },
                    { new Guid("f75fc379-eb23-49ad-a60e-0b4e0556e7eb"), new Guid("8f114abd-8fdb-4983-8859-b242d7439e69") },
                    { new Guid("f75fc379-eb23-49ad-a60e-0b4e0556e7eb"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("f75fc379-eb23-49ad-a60e-0b4e0556e7eb"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("f8800c36-2e0b-4862-9db2-3f230c19515b"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("f8800c36-2e0b-4862-9db2-3f230c19515b"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("f8800c36-2e0b-4862-9db2-3f230c19515b"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("f8800c36-2e0b-4862-9db2-3f230c19515b"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("f8800c36-2e0b-4862-9db2-3f230c19515b"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") },
                    { new Guid("f97ac710-1562-436d-8ea5-a21da10e372a"), new Guid("23ca9092-230b-47ef-a511-6d47b8c6aaa5") },
                    { new Guid("f97ac710-1562-436d-8ea5-a21da10e372a"), new Guid("70bd4bf5-c9a1-4dcb-85dd-11dcb2ada27f") },
                    { new Guid("f97ac710-1562-436d-8ea5-a21da10e372a"), new Guid("7a404ea5-d485-480b-bbea-0961ab6414ab") },
                    { new Guid("f97ac710-1562-436d-8ea5-a21da10e372a"), new Guid("b56be067-cb35-4fd0-8f65-2f0a80d96301") },
                    { new Guid("f97ac710-1562-436d-8ea5-a21da10e372a"), new Guid("fa960763-b8e2-4fff-957b-61af6be52815") }
                });
        }
    }
}
