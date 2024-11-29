using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHub.DB.Migrations
{
    /// <inheritdoc />
    public partial class AddPermissionsMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("07c83ee8-96d6-4cb7-ad78-3e56a58e8db4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1a3d526f-72af-40be-8a6f-60606e655df7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("210dcfb5-85fc-488f-a828-d2d00d2d0674"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("30d745b2-c43a-4ba9-8f49-28c359315ef0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("54a33aac-4450-47ad-b646-245398ef10d4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("67a49969-f32f-43db-b9a3-b3943bc711ac"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bfbdbfd4-a49f-489c-966b-dc08cc9a37db"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cc805e85-fcf3-4095-81b2-7b4525d8dc5f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dd3e05c4-f3e3-4bb7-a066-f8066c6c1945"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f0313212-b989-470f-85dd-f28b422de02d"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("023edc93-00a2-4a58-ba97-c6975b938679"), new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("023edc93-00a2-4a58-ba97-c6975b938679"), new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("023edc93-00a2-4a58-ba97-c6975b938679"), new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("023edc93-00a2-4a58-ba97-c6975b938679"), new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("023edc93-00a2-4a58-ba97-c6975b938679"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("082c1a76-04f4-4bde-a7bc-02489abac1e6"), new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("082c1a76-04f4-4bde-a7bc-02489abac1e6"), new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("082c1a76-04f4-4bde-a7bc-02489abac1e6"), new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("082c1a76-04f4-4bde-a7bc-02489abac1e6"), new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("082c1a76-04f4-4bde-a7bc-02489abac1e6"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1a8333ac-1fc0-406d-8359-1c09fb864d32"), new Guid("31f9d350-ce1b-4328-8e67-3f17d1f0b8a8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1a8333ac-1fc0-406d-8359-1c09fb864d32"), new Guid("45a88862-a739-4878-aeed-aa9325e7c6d1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1a8333ac-1fc0-406d-8359-1c09fb864d32"), new Guid("eaf67869-b56b-45dd-9ff9-38e3899d4f73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1c3e1850-fdb7-4bb5-8311-0d78ef6bd612"), new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1c3e1850-fdb7-4bb5-8311-0d78ef6bd612"), new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1c3e1850-fdb7-4bb5-8311-0d78ef6bd612"), new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1c3e1850-fdb7-4bb5-8311-0d78ef6bd612"), new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1c3e1850-fdb7-4bb5-8311-0d78ef6bd612"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1fe5019d-9a8b-481a-afaa-25dd4e618721"), new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1fe5019d-9a8b-481a-afaa-25dd4e618721"), new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1fe5019d-9a8b-481a-afaa-25dd4e618721"), new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1fe5019d-9a8b-481a-afaa-25dd4e618721"), new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1fe5019d-9a8b-481a-afaa-25dd4e618721"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("224031ee-106d-4a04-ab60-a69430dcd5f1"), new Guid("5e216bc3-2853-4659-b513-02a1d42dfd0e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("224031ee-106d-4a04-ab60-a69430dcd5f1"), new Guid("7493b1a3-9874-450e-b0b0-3292819a4bae") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("224031ee-106d-4a04-ab60-a69430dcd5f1"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("31642eed-ff18-42a8-b869-552619a2413e"), new Guid("31f9d350-ce1b-4328-8e67-3f17d1f0b8a8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("31642eed-ff18-42a8-b869-552619a2413e"), new Guid("45a88862-a739-4878-aeed-aa9325e7c6d1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("31642eed-ff18-42a8-b869-552619a2413e"), new Guid("eaf67869-b56b-45dd-9ff9-38e3899d4f73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4922f975-5b10-4167-add3-9317376f40e5"), new Guid("5e216bc3-2853-4659-b513-02a1d42dfd0e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4922f975-5b10-4167-add3-9317376f40e5"), new Guid("7493b1a3-9874-450e-b0b0-3292819a4bae") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4922f975-5b10-4167-add3-9317376f40e5"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4a71791f-7767-4fd3-8214-954d2bd777e2"), new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4a71791f-7767-4fd3-8214-954d2bd777e2"), new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4a71791f-7767-4fd3-8214-954d2bd777e2"), new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4a71791f-7767-4fd3-8214-954d2bd777e2"), new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4a71791f-7767-4fd3-8214-954d2bd777e2"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4be6f4be-4916-443c-ab5c-9dcf71b44a16"), new Guid("5e216bc3-2853-4659-b513-02a1d42dfd0e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4be6f4be-4916-443c-ab5c-9dcf71b44a16"), new Guid("7493b1a3-9874-450e-b0b0-3292819a4bae") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4be6f4be-4916-443c-ab5c-9dcf71b44a16"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("50453f7b-9f4e-46ff-9519-590425912ab2"), new Guid("5e216bc3-2853-4659-b513-02a1d42dfd0e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("50453f7b-9f4e-46ff-9519-590425912ab2"), new Guid("7493b1a3-9874-450e-b0b0-3292819a4bae") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("50453f7b-9f4e-46ff-9519-590425912ab2"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("52ce6ca7-2bc6-4a60-b184-457fe2623dd2"), new Guid("31f9d350-ce1b-4328-8e67-3f17d1f0b8a8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("52ce6ca7-2bc6-4a60-b184-457fe2623dd2"), new Guid("45a88862-a739-4878-aeed-aa9325e7c6d1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("52ce6ca7-2bc6-4a60-b184-457fe2623dd2"), new Guid("eaf67869-b56b-45dd-9ff9-38e3899d4f73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("616356a4-3bda-402b-83ad-015076c94bd5"), new Guid("5e216bc3-2853-4659-b513-02a1d42dfd0e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("616356a4-3bda-402b-83ad-015076c94bd5"), new Guid("7493b1a3-9874-450e-b0b0-3292819a4bae") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("616356a4-3bda-402b-83ad-015076c94bd5"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("849e21e5-574f-420a-88a6-ce3722db0458"), new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("849e21e5-574f-420a-88a6-ce3722db0458"), new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("849e21e5-574f-420a-88a6-ce3722db0458"), new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("849e21e5-574f-420a-88a6-ce3722db0458"), new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("849e21e5-574f-420a-88a6-ce3722db0458"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a0d6c11e-a23a-4bea-8eae-c2e16fb6d483"), new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a0d6c11e-a23a-4bea-8eae-c2e16fb6d483"), new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a0d6c11e-a23a-4bea-8eae-c2e16fb6d483"), new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a0d6c11e-a23a-4bea-8eae-c2e16fb6d483"), new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a0d6c11e-a23a-4bea-8eae-c2e16fb6d483"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a6d19f5a-7431-47c1-8536-f11919e9a5dc"), new Guid("5e216bc3-2853-4659-b513-02a1d42dfd0e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a6d19f5a-7431-47c1-8536-f11919e9a5dc"), new Guid("7493b1a3-9874-450e-b0b0-3292819a4bae") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a6d19f5a-7431-47c1-8536-f11919e9a5dc"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b2de97aa-8f11-4322-9308-3cbe8ec6572d"), new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b2de97aa-8f11-4322-9308-3cbe8ec6572d"), new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b2de97aa-8f11-4322-9308-3cbe8ec6572d"), new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b2de97aa-8f11-4322-9308-3cbe8ec6572d"), new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b2de97aa-8f11-4322-9308-3cbe8ec6572d"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b75fdb13-5f6b-4fff-8306-8d6a1619740b"), new Guid("31f9d350-ce1b-4328-8e67-3f17d1f0b8a8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b75fdb13-5f6b-4fff-8306-8d6a1619740b"), new Guid("45a88862-a739-4878-aeed-aa9325e7c6d1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b75fdb13-5f6b-4fff-8306-8d6a1619740b"), new Guid("eaf67869-b56b-45dd-9ff9-38e3899d4f73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b94139f3-020a-4139-911e-bd7c0464867b"), new Guid("31f9d350-ce1b-4328-8e67-3f17d1f0b8a8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b94139f3-020a-4139-911e-bd7c0464867b"), new Guid("45a88862-a739-4878-aeed-aa9325e7c6d1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b94139f3-020a-4139-911e-bd7c0464867b"), new Guid("eaf67869-b56b-45dd-9ff9-38e3899d4f73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d17deb6c-4157-47be-a7aa-130f6ceab8d2"), new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d17deb6c-4157-47be-a7aa-130f6ceab8d2"), new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d17deb6c-4157-47be-a7aa-130f6ceab8d2"), new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d17deb6c-4157-47be-a7aa-130f6ceab8d2"), new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d17deb6c-4157-47be-a7aa-130f6ceab8d2"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("de885b9b-5be0-4bd7-850c-3e702dba4cde"), new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("de885b9b-5be0-4bd7-850c-3e702dba4cde"), new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("de885b9b-5be0-4bd7-850c-3e702dba4cde"), new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("de885b9b-5be0-4bd7-850c-3e702dba4cde"), new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("de885b9b-5be0-4bd7-850c-3e702dba4cde"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("eacfe38a-059f-4c80-9085-b3d53b6994ad"), new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("eacfe38a-059f-4c80-9085-b3d53b6994ad"), new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("eacfe38a-059f-4c80-9085-b3d53b6994ad"), new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("eacfe38a-059f-4c80-9085-b3d53b6994ad"), new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("eacfe38a-059f-4c80-9085-b3d53b6994ad"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f036e516-5bef-47ab-9c8e-40779f6d5854"), new Guid("31f9d350-ce1b-4328-8e67-3f17d1f0b8a8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f036e516-5bef-47ab-9c8e-40779f6d5854"), new Guid("45a88862-a739-4878-aeed-aa9325e7c6d1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f036e516-5bef-47ab-9c8e-40779f6d5854"), new Guid("eaf67869-b56b-45dd-9ff9-38e3899d4f73") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("023edc93-00a2-4a58-ba97-c6975b938679"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("082c1a76-04f4-4bde-a7bc-02489abac1e6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1a8333ac-1fc0-406d-8359-1c09fb864d32"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1c3e1850-fdb7-4bb5-8311-0d78ef6bd612"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1fe5019d-9a8b-481a-afaa-25dd4e618721"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("224031ee-106d-4a04-ab60-a69430dcd5f1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("31642eed-ff18-42a8-b869-552619a2413e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4922f975-5b10-4167-add3-9317376f40e5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4a71791f-7767-4fd3-8214-954d2bd777e2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4be6f4be-4916-443c-ab5c-9dcf71b44a16"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("50453f7b-9f4e-46ff-9519-590425912ab2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("52ce6ca7-2bc6-4a60-b184-457fe2623dd2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("616356a4-3bda-402b-83ad-015076c94bd5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("849e21e5-574f-420a-88a6-ce3722db0458"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a0d6c11e-a23a-4bea-8eae-c2e16fb6d483"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a6d19f5a-7431-47c1-8536-f11919e9a5dc"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b2de97aa-8f11-4322-9308-3cbe8ec6572d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b75fdb13-5f6b-4fff-8306-8d6a1619740b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b94139f3-020a-4139-911e-bd7c0464867b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d17deb6c-4157-47be-a7aa-130f6ceab8d2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("de885b9b-5be0-4bd7-850c-3e702dba4cde"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("eacfe38a-059f-4c80-9085-b3d53b6994ad"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f036e516-5bef-47ab-9c8e-40779f6d5854"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31f9d350-ce1b-4328-8e67-3f17d1f0b8a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45a88862-a739-4878-aeed-aa9325e7c6d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e216bc3-2853-4659-b513-02a1d42dfd0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7493b1a3-9874-450e-b0b0-3292819a4bae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eaf67869-b56b-45dd-9ff9-38e3899d4f73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8"));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0948b75f-7d51-4d2f-8af3-2ee3dcb18b9f"), "newhome-home" },
                    { new Guid("14b0d8fd-b1ca-447b-b0bf-b6c02924a667"), "gethomes-user" },
                    { new Guid("1909b61a-60a9-4e0a-84fd-363fe4cff93d"), "getdevices-devices" },
                    { new Guid("2e4d9eca-de94-47b3-a5f5-335bac70494f"), "addmotionsensor-motionsensor" },
                    { new Guid("32547e0f-2dc3-419e-ae24-43bde97a2b93"), "createadminaccount-administrator" },
                    { new Guid("4c1ebfa4-4452-430f-af7b-9c3da63645fb"), "updatenamedevice-home" },
                    { new Guid("4d2d1bfd-33b8-4d62-b0af-ae03d8d7936f"), "adddevice-home" },
                    { new Guid("4fa6c5dd-95c0-4e95-bf9a-56be9c06ea72"), "motiondetection-camera" },
                    { new Guid("505e8862-110e-40f9-86d3-63ab0a483990"), "updateroomdevice-home" },
                    { new Guid("55c3b447-34ea-4914-88e3-149050f506bf"), "persondetection-camera" },
                    { new Guid("5c83dd38-09d7-482c-ab6d-619128067601"), "open-windowsensor" },
                    { new Guid("616e5fe3-d11a-4dbd-892e-e306fdca6152"), "getnotifications-notification" },
                    { new Guid("66a2ca8d-609c-4e66-b223-d4c3161e9247"), "getrooms-home" },
                    { new Guid("6c349201-d0a9-4f59-9778-bb60532f7f96"), "createcompany-companies" },
                    { new Guid("7a5d3b92-770e-4921-83bd-51d041ca65eb"), "createcompanyowneraccount-companyowner" },
                    { new Guid("7f7a919b-529a-4b88-95a0-de194f0d8bac"), "addmotionsensor-motionsensor" },
                    { new Guid("8539385e-4cc6-4040-a720-7d600a28ab5c"), "addnotificationmembers-members" },
                    { new Guid("860569d3-c3b5-4e77-a328-6f0f9e55ac28"), "addmember-members" },
                    { new Guid("863a1263-9f6d-4d66-bedf-092696620752"), "addpermission-members" },
                    { new Guid("967be8f6-6693-4fff-96a6-cbcf03748d39"), "addcamera-camera" },
                    { new Guid("97444468-0fee-4465-b5a5-47c4bf6865b6"), "motiondetection-motionsensor" },
                    { new Guid("a33c9abe-8af8-4e80-aa29-8588eeedc24b"), "close-windowsensor" },
                    { new Guid("a597fa6c-1674-4488-9ca8-097c37b6ded1"), "addsmartlamp-smartlamp" },
                    { new Guid("a7095ce6-f37e-4993-9a9d-c32a98d72e90"), "off-smartlamp" },
                    { new Guid("ab704c64-b30a-457e-93a7-45f8053abf8f"), "addhomeownerpermission-homeowner" },
                    { new Guid("b122d3fa-aa19-41ba-8be2-96a9a335add6"), "getmembers-members" },
                    { new Guid("b71098d4-d17e-4f7b-9283-2e48ebd64f67"), "getdevices-home" },
                    { new Guid("b8170632-875f-46f1-8557-966ae758e43f"), "addrooms-home" },
                    { new Guid("ca1f6d94-0474-4938-ab59-36c05452f1be"), "deleteadminaccount-administrator" },
                    { new Guid("d3dd27a1-2531-4ed3-a89f-9a3ca725b79d"), "addsensor-windowsensor" },
                    { new Guid("e26f7572-82c7-484e-99cb-29d2c214ea92"), "addhomeownerpermission-homeowner" },
                    { new Guid("e5c53d57-2d9d-4867-928b-1477bec414c2"), "getcompany-companies" },
                    { new Guid("ea47892b-677f-4c62-a0da-1c04e9715936"), "getdevicetypes-devicetype" },
                    { new Guid("ef0a0724-7cbf-465c-b4a3-a972e5fc286b"), "on-smartlamp" },
                    { new Guid("fc9a64db-7ea6-46cb-b71f-0408df5bd965"), "getaccounts-accounts" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Password", "ProfilePhoto", "Roles", "Surname" },
                values: new object[,]
                {
                    { new Guid("19ca51d8-651c-4e22-946a-d586b030ec90"), new DateTime(2024, 10, 25, 23, 7, 13, 25, DateTimeKind.Local).AddTicks(6734), "rogerfederer@tennis.com", "Roger", "Federer@123", "federer.jpg", "[0]", "Federer" },
                    { new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f"), new DateTime(2024, 10, 25, 23, 7, 13, 25, DateTimeKind.Local).AddTicks(6776), "steffigraf@tennis.com", "Steffi", "Steffi@123", "graf.jpg", "[1]", "Graf" },
                    { new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09"), new DateTime(2024, 10, 25, 23, 7, 13, 25, DateTimeKind.Local).AddTicks(6767), "serenawilliams@tennis.com", "Serena", "Serena@123", "serena.jpg", "[2]", "Williams" },
                    { new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b"), new DateTime(2024, 10, 25, 23, 7, 13, 25, DateTimeKind.Local).AddTicks(6781), "andreagassi@tennis.com", "Andre", "Agassi@123", "agassi.jpg", "[1]", "Agassi" },
                    { new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8"), new DateTime(2024, 10, 25, 23, 7, 13, 25, DateTimeKind.Local).AddTicks(6802), "billiejeanking@tennis.com", "Billie", "King@123", "king.jpg", "[0]", "Jean King" },
                    { new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c"), new DateTime(2024, 10, 25, 23, 7, 13, 25, DateTimeKind.Local).AddTicks(6789), "martinanavratilova@tennis.com", "Martina", "Navratilova@123", "navratilova.jpg", "[1]", "Navratilova" },
                    { new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e"), new DateTime(2024, 10, 25, 23, 7, 13, 25, DateTimeKind.Local).AddTicks(6761), "rafaelnadal@tennis.com", "Rafael", "Nadal@123", "nadal.jpg", "[0]", "Nadal" },
                    { new Guid("c23ec077-7520-49a6-b66c-592a293ca5be"), new DateTime(2024, 10, 25, 23, 7, 13, 25, DateTimeKind.Local).AddTicks(6796), "johnmcenroe@tennis.com", "John", "McEnroe@123", "mcenroe.jpg", "[2]", "McEnroe" },
                    { new Guid("c80fcb59-fa93-4347-9124-c827edee9766"), new DateTime(2024, 10, 25, 23, 7, 13, 25, DateTimeKind.Local).AddTicks(6771), "novakdjokovic@tennis.com", "Novak", "Djokovic@123", "djokovic.jpg", "[2,1]", "Djokovic" },
                    { new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8"), new DateTime(2024, 10, 25, 23, 7, 13, 25, DateTimeKind.Local).AddTicks(6785), "petesampras@tennis.com", "Pete", "Sampras@123", "sampras.jpg", "[1]", "Sampras" }
                });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "PermissionId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0948b75f-7d51-4d2f-8af3-2ee3dcb18b9f"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("0948b75f-7d51-4d2f-8af3-2ee3dcb18b9f"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("0948b75f-7d51-4d2f-8af3-2ee3dcb18b9f"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("0948b75f-7d51-4d2f-8af3-2ee3dcb18b9f"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("0948b75f-7d51-4d2f-8af3-2ee3dcb18b9f"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("14b0d8fd-b1ca-447b-b0bf-b6c02924a667"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("14b0d8fd-b1ca-447b-b0bf-b6c02924a667"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("14b0d8fd-b1ca-447b-b0bf-b6c02924a667"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("14b0d8fd-b1ca-447b-b0bf-b6c02924a667"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("14b0d8fd-b1ca-447b-b0bf-b6c02924a667"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("1909b61a-60a9-4e0a-84fd-363fe4cff93d"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") },
                    { new Guid("1909b61a-60a9-4e0a-84fd-363fe4cff93d"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("1909b61a-60a9-4e0a-84fd-363fe4cff93d"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") },
                    { new Guid("1909b61a-60a9-4e0a-84fd-363fe4cff93d"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("1909b61a-60a9-4e0a-84fd-363fe4cff93d"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") },
                    { new Guid("1909b61a-60a9-4e0a-84fd-363fe4cff93d"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("1909b61a-60a9-4e0a-84fd-363fe4cff93d"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") },
                    { new Guid("1909b61a-60a9-4e0a-84fd-363fe4cff93d"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") },
                    { new Guid("1909b61a-60a9-4e0a-84fd-363fe4cff93d"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("1909b61a-60a9-4e0a-84fd-363fe4cff93d"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("2e4d9eca-de94-47b3-a5f5-335bac70494f"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("2e4d9eca-de94-47b3-a5f5-335bac70494f"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("2e4d9eca-de94-47b3-a5f5-335bac70494f"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("2e4d9eca-de94-47b3-a5f5-335bac70494f"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("2e4d9eca-de94-47b3-a5f5-335bac70494f"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("32547e0f-2dc3-419e-ae24-43bde97a2b93"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") },
                    { new Guid("32547e0f-2dc3-419e-ae24-43bde97a2b93"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") },
                    { new Guid("32547e0f-2dc3-419e-ae24-43bde97a2b93"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("4c1ebfa4-4452-430f-af7b-9c3da63645fb"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("4c1ebfa4-4452-430f-af7b-9c3da63645fb"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("4c1ebfa4-4452-430f-af7b-9c3da63645fb"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("4c1ebfa4-4452-430f-af7b-9c3da63645fb"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("4c1ebfa4-4452-430f-af7b-9c3da63645fb"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("4d2d1bfd-33b8-4d62-b0af-ae03d8d7936f"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("4d2d1bfd-33b8-4d62-b0af-ae03d8d7936f"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("4d2d1bfd-33b8-4d62-b0af-ae03d8d7936f"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("4d2d1bfd-33b8-4d62-b0af-ae03d8d7936f"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("4d2d1bfd-33b8-4d62-b0af-ae03d8d7936f"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("4fa6c5dd-95c0-4e95-bf9a-56be9c06ea72"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") },
                    { new Guid("4fa6c5dd-95c0-4e95-bf9a-56be9c06ea72"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("4fa6c5dd-95c0-4e95-bf9a-56be9c06ea72"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") },
                    { new Guid("4fa6c5dd-95c0-4e95-bf9a-56be9c06ea72"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("4fa6c5dd-95c0-4e95-bf9a-56be9c06ea72"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") },
                    { new Guid("4fa6c5dd-95c0-4e95-bf9a-56be9c06ea72"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("4fa6c5dd-95c0-4e95-bf9a-56be9c06ea72"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") },
                    { new Guid("4fa6c5dd-95c0-4e95-bf9a-56be9c06ea72"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") },
                    { new Guid("4fa6c5dd-95c0-4e95-bf9a-56be9c06ea72"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("4fa6c5dd-95c0-4e95-bf9a-56be9c06ea72"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("505e8862-110e-40f9-86d3-63ab0a483990"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("505e8862-110e-40f9-86d3-63ab0a483990"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("505e8862-110e-40f9-86d3-63ab0a483990"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("505e8862-110e-40f9-86d3-63ab0a483990"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("505e8862-110e-40f9-86d3-63ab0a483990"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("55c3b447-34ea-4914-88e3-149050f506bf"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") },
                    { new Guid("55c3b447-34ea-4914-88e3-149050f506bf"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("55c3b447-34ea-4914-88e3-149050f506bf"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") },
                    { new Guid("55c3b447-34ea-4914-88e3-149050f506bf"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("55c3b447-34ea-4914-88e3-149050f506bf"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") },
                    { new Guid("55c3b447-34ea-4914-88e3-149050f506bf"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("55c3b447-34ea-4914-88e3-149050f506bf"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") },
                    { new Guid("55c3b447-34ea-4914-88e3-149050f506bf"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") },
                    { new Guid("55c3b447-34ea-4914-88e3-149050f506bf"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("55c3b447-34ea-4914-88e3-149050f506bf"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("5c83dd38-09d7-482c-ab6d-619128067601"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") },
                    { new Guid("5c83dd38-09d7-482c-ab6d-619128067601"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("5c83dd38-09d7-482c-ab6d-619128067601"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") },
                    { new Guid("5c83dd38-09d7-482c-ab6d-619128067601"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("5c83dd38-09d7-482c-ab6d-619128067601"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") },
                    { new Guid("5c83dd38-09d7-482c-ab6d-619128067601"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("5c83dd38-09d7-482c-ab6d-619128067601"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") },
                    { new Guid("5c83dd38-09d7-482c-ab6d-619128067601"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") },
                    { new Guid("5c83dd38-09d7-482c-ab6d-619128067601"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("5c83dd38-09d7-482c-ab6d-619128067601"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("616e5fe3-d11a-4dbd-892e-e306fdca6152"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") },
                    { new Guid("616e5fe3-d11a-4dbd-892e-e306fdca6152"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("616e5fe3-d11a-4dbd-892e-e306fdca6152"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") },
                    { new Guid("616e5fe3-d11a-4dbd-892e-e306fdca6152"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("616e5fe3-d11a-4dbd-892e-e306fdca6152"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") },
                    { new Guid("616e5fe3-d11a-4dbd-892e-e306fdca6152"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("616e5fe3-d11a-4dbd-892e-e306fdca6152"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") },
                    { new Guid("616e5fe3-d11a-4dbd-892e-e306fdca6152"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") },
                    { new Guid("616e5fe3-d11a-4dbd-892e-e306fdca6152"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("616e5fe3-d11a-4dbd-892e-e306fdca6152"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("66a2ca8d-609c-4e66-b223-d4c3161e9247"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("66a2ca8d-609c-4e66-b223-d4c3161e9247"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("66a2ca8d-609c-4e66-b223-d4c3161e9247"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("66a2ca8d-609c-4e66-b223-d4c3161e9247"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("66a2ca8d-609c-4e66-b223-d4c3161e9247"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("6c349201-d0a9-4f59-9778-bb60532f7f96"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") },
                    { new Guid("6c349201-d0a9-4f59-9778-bb60532f7f96"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") },
                    { new Guid("6c349201-d0a9-4f59-9778-bb60532f7f96"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") },
                    { new Guid("7a5d3b92-770e-4921-83bd-51d041ca65eb"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") },
                    { new Guid("7a5d3b92-770e-4921-83bd-51d041ca65eb"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") },
                    { new Guid("7a5d3b92-770e-4921-83bd-51d041ca65eb"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("7f7a919b-529a-4b88-95a0-de194f0d8bac"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") },
                    { new Guid("7f7a919b-529a-4b88-95a0-de194f0d8bac"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") },
                    { new Guid("7f7a919b-529a-4b88-95a0-de194f0d8bac"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") },
                    { new Guid("8539385e-4cc6-4040-a720-7d600a28ab5c"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("8539385e-4cc6-4040-a720-7d600a28ab5c"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("8539385e-4cc6-4040-a720-7d600a28ab5c"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("8539385e-4cc6-4040-a720-7d600a28ab5c"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("8539385e-4cc6-4040-a720-7d600a28ab5c"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("860569d3-c3b5-4e77-a328-6f0f9e55ac28"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("860569d3-c3b5-4e77-a328-6f0f9e55ac28"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("860569d3-c3b5-4e77-a328-6f0f9e55ac28"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("860569d3-c3b5-4e77-a328-6f0f9e55ac28"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("860569d3-c3b5-4e77-a328-6f0f9e55ac28"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("863a1263-9f6d-4d66-bedf-092696620752"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("863a1263-9f6d-4d66-bedf-092696620752"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("863a1263-9f6d-4d66-bedf-092696620752"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("863a1263-9f6d-4d66-bedf-092696620752"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("863a1263-9f6d-4d66-bedf-092696620752"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("967be8f6-6693-4fff-96a6-cbcf03748d39"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") },
                    { new Guid("967be8f6-6693-4fff-96a6-cbcf03748d39"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") },
                    { new Guid("967be8f6-6693-4fff-96a6-cbcf03748d39"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") },
                    { new Guid("97444468-0fee-4465-b5a5-47c4bf6865b6"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") },
                    { new Guid("97444468-0fee-4465-b5a5-47c4bf6865b6"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("97444468-0fee-4465-b5a5-47c4bf6865b6"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") },
                    { new Guid("97444468-0fee-4465-b5a5-47c4bf6865b6"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("97444468-0fee-4465-b5a5-47c4bf6865b6"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") },
                    { new Guid("97444468-0fee-4465-b5a5-47c4bf6865b6"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("97444468-0fee-4465-b5a5-47c4bf6865b6"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") },
                    { new Guid("97444468-0fee-4465-b5a5-47c4bf6865b6"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") },
                    { new Guid("97444468-0fee-4465-b5a5-47c4bf6865b6"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("97444468-0fee-4465-b5a5-47c4bf6865b6"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("a33c9abe-8af8-4e80-aa29-8588eeedc24b"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") },
                    { new Guid("a33c9abe-8af8-4e80-aa29-8588eeedc24b"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("a33c9abe-8af8-4e80-aa29-8588eeedc24b"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") },
                    { new Guid("a33c9abe-8af8-4e80-aa29-8588eeedc24b"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("a33c9abe-8af8-4e80-aa29-8588eeedc24b"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") },
                    { new Guid("a33c9abe-8af8-4e80-aa29-8588eeedc24b"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("a33c9abe-8af8-4e80-aa29-8588eeedc24b"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") },
                    { new Guid("a33c9abe-8af8-4e80-aa29-8588eeedc24b"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") },
                    { new Guid("a33c9abe-8af8-4e80-aa29-8588eeedc24b"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("a33c9abe-8af8-4e80-aa29-8588eeedc24b"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("a597fa6c-1674-4488-9ca8-097c37b6ded1"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") },
                    { new Guid("a597fa6c-1674-4488-9ca8-097c37b6ded1"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") },
                    { new Guid("a597fa6c-1674-4488-9ca8-097c37b6ded1"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") },
                    { new Guid("a7095ce6-f37e-4993-9a9d-c32a98d72e90"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") },
                    { new Guid("a7095ce6-f37e-4993-9a9d-c32a98d72e90"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("a7095ce6-f37e-4993-9a9d-c32a98d72e90"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") },
                    { new Guid("a7095ce6-f37e-4993-9a9d-c32a98d72e90"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("a7095ce6-f37e-4993-9a9d-c32a98d72e90"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") },
                    { new Guid("a7095ce6-f37e-4993-9a9d-c32a98d72e90"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("a7095ce6-f37e-4993-9a9d-c32a98d72e90"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") },
                    { new Guid("a7095ce6-f37e-4993-9a9d-c32a98d72e90"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") },
                    { new Guid("a7095ce6-f37e-4993-9a9d-c32a98d72e90"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("a7095ce6-f37e-4993-9a9d-c32a98d72e90"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("ab704c64-b30a-457e-93a7-45f8053abf8f"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") },
                    { new Guid("ab704c64-b30a-457e-93a7-45f8053abf8f"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") },
                    { new Guid("ab704c64-b30a-457e-93a7-45f8053abf8f"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("b122d3fa-aa19-41ba-8be2-96a9a335add6"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("b122d3fa-aa19-41ba-8be2-96a9a335add6"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("b122d3fa-aa19-41ba-8be2-96a9a335add6"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("b122d3fa-aa19-41ba-8be2-96a9a335add6"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("b122d3fa-aa19-41ba-8be2-96a9a335add6"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("b71098d4-d17e-4f7b-9283-2e48ebd64f67"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("b71098d4-d17e-4f7b-9283-2e48ebd64f67"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("b71098d4-d17e-4f7b-9283-2e48ebd64f67"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("b71098d4-d17e-4f7b-9283-2e48ebd64f67"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("b71098d4-d17e-4f7b-9283-2e48ebd64f67"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("b8170632-875f-46f1-8557-966ae758e43f"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("b8170632-875f-46f1-8557-966ae758e43f"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("b8170632-875f-46f1-8557-966ae758e43f"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("b8170632-875f-46f1-8557-966ae758e43f"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("b8170632-875f-46f1-8557-966ae758e43f"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("ca1f6d94-0474-4938-ab59-36c05452f1be"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") },
                    { new Guid("ca1f6d94-0474-4938-ab59-36c05452f1be"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") },
                    { new Guid("ca1f6d94-0474-4938-ab59-36c05452f1be"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("d3dd27a1-2531-4ed3-a89f-9a3ca725b79d"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") },
                    { new Guid("d3dd27a1-2531-4ed3-a89f-9a3ca725b79d"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") },
                    { new Guid("d3dd27a1-2531-4ed3-a89f-9a3ca725b79d"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") },
                    { new Guid("e26f7572-82c7-484e-99cb-29d2c214ea92"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") },
                    { new Guid("e26f7572-82c7-484e-99cb-29d2c214ea92"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") },
                    { new Guid("e26f7572-82c7-484e-99cb-29d2c214ea92"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") },
                    { new Guid("e5c53d57-2d9d-4867-928b-1477bec414c2"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") },
                    { new Guid("e5c53d57-2d9d-4867-928b-1477bec414c2"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") },
                    { new Guid("e5c53d57-2d9d-4867-928b-1477bec414c2"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("ea47892b-677f-4c62-a0da-1c04e9715936"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") },
                    { new Guid("ea47892b-677f-4c62-a0da-1c04e9715936"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("ea47892b-677f-4c62-a0da-1c04e9715936"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") },
                    { new Guid("ea47892b-677f-4c62-a0da-1c04e9715936"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("ea47892b-677f-4c62-a0da-1c04e9715936"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") },
                    { new Guid("ea47892b-677f-4c62-a0da-1c04e9715936"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("ea47892b-677f-4c62-a0da-1c04e9715936"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") },
                    { new Guid("ea47892b-677f-4c62-a0da-1c04e9715936"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") },
                    { new Guid("ea47892b-677f-4c62-a0da-1c04e9715936"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("ea47892b-677f-4c62-a0da-1c04e9715936"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("ef0a0724-7cbf-465c-b4a3-a972e5fc286b"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") },
                    { new Guid("ef0a0724-7cbf-465c-b4a3-a972e5fc286b"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") },
                    { new Guid("ef0a0724-7cbf-465c-b4a3-a972e5fc286b"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") },
                    { new Guid("ef0a0724-7cbf-465c-b4a3-a972e5fc286b"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") },
                    { new Guid("ef0a0724-7cbf-465c-b4a3-a972e5fc286b"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") },
                    { new Guid("ef0a0724-7cbf-465c-b4a3-a972e5fc286b"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") },
                    { new Guid("ef0a0724-7cbf-465c-b4a3-a972e5fc286b"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") },
                    { new Guid("ef0a0724-7cbf-465c-b4a3-a972e5fc286b"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") },
                    { new Guid("ef0a0724-7cbf-465c-b4a3-a972e5fc286b"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") },
                    { new Guid("ef0a0724-7cbf-465c-b4a3-a972e5fc286b"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") },
                    { new Guid("fc9a64db-7ea6-46cb-b71f-0408df5bd965"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") },
                    { new Guid("fc9a64db-7ea6-46cb-b71f-0408df5bd965"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") },
                    { new Guid("fc9a64db-7ea6-46cb-b71f-0408df5bd965"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0948b75f-7d51-4d2f-8af3-2ee3dcb18b9f"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0948b75f-7d51-4d2f-8af3-2ee3dcb18b9f"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0948b75f-7d51-4d2f-8af3-2ee3dcb18b9f"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0948b75f-7d51-4d2f-8af3-2ee3dcb18b9f"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0948b75f-7d51-4d2f-8af3-2ee3dcb18b9f"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("14b0d8fd-b1ca-447b-b0bf-b6c02924a667"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("14b0d8fd-b1ca-447b-b0bf-b6c02924a667"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("14b0d8fd-b1ca-447b-b0bf-b6c02924a667"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("14b0d8fd-b1ca-447b-b0bf-b6c02924a667"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("14b0d8fd-b1ca-447b-b0bf-b6c02924a667"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1909b61a-60a9-4e0a-84fd-363fe4cff93d"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1909b61a-60a9-4e0a-84fd-363fe4cff93d"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1909b61a-60a9-4e0a-84fd-363fe4cff93d"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1909b61a-60a9-4e0a-84fd-363fe4cff93d"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1909b61a-60a9-4e0a-84fd-363fe4cff93d"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1909b61a-60a9-4e0a-84fd-363fe4cff93d"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1909b61a-60a9-4e0a-84fd-363fe4cff93d"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1909b61a-60a9-4e0a-84fd-363fe4cff93d"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1909b61a-60a9-4e0a-84fd-363fe4cff93d"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1909b61a-60a9-4e0a-84fd-363fe4cff93d"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2e4d9eca-de94-47b3-a5f5-335bac70494f"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2e4d9eca-de94-47b3-a5f5-335bac70494f"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2e4d9eca-de94-47b3-a5f5-335bac70494f"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2e4d9eca-de94-47b3-a5f5-335bac70494f"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2e4d9eca-de94-47b3-a5f5-335bac70494f"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("32547e0f-2dc3-419e-ae24-43bde97a2b93"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("32547e0f-2dc3-419e-ae24-43bde97a2b93"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("32547e0f-2dc3-419e-ae24-43bde97a2b93"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4c1ebfa4-4452-430f-af7b-9c3da63645fb"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4c1ebfa4-4452-430f-af7b-9c3da63645fb"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4c1ebfa4-4452-430f-af7b-9c3da63645fb"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4c1ebfa4-4452-430f-af7b-9c3da63645fb"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4c1ebfa4-4452-430f-af7b-9c3da63645fb"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4d2d1bfd-33b8-4d62-b0af-ae03d8d7936f"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4d2d1bfd-33b8-4d62-b0af-ae03d8d7936f"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4d2d1bfd-33b8-4d62-b0af-ae03d8d7936f"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4d2d1bfd-33b8-4d62-b0af-ae03d8d7936f"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4d2d1bfd-33b8-4d62-b0af-ae03d8d7936f"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4fa6c5dd-95c0-4e95-bf9a-56be9c06ea72"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4fa6c5dd-95c0-4e95-bf9a-56be9c06ea72"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4fa6c5dd-95c0-4e95-bf9a-56be9c06ea72"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4fa6c5dd-95c0-4e95-bf9a-56be9c06ea72"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4fa6c5dd-95c0-4e95-bf9a-56be9c06ea72"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4fa6c5dd-95c0-4e95-bf9a-56be9c06ea72"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4fa6c5dd-95c0-4e95-bf9a-56be9c06ea72"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4fa6c5dd-95c0-4e95-bf9a-56be9c06ea72"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4fa6c5dd-95c0-4e95-bf9a-56be9c06ea72"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4fa6c5dd-95c0-4e95-bf9a-56be9c06ea72"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("505e8862-110e-40f9-86d3-63ab0a483990"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("505e8862-110e-40f9-86d3-63ab0a483990"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("505e8862-110e-40f9-86d3-63ab0a483990"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("505e8862-110e-40f9-86d3-63ab0a483990"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("505e8862-110e-40f9-86d3-63ab0a483990"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("55c3b447-34ea-4914-88e3-149050f506bf"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("55c3b447-34ea-4914-88e3-149050f506bf"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("55c3b447-34ea-4914-88e3-149050f506bf"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("55c3b447-34ea-4914-88e3-149050f506bf"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("55c3b447-34ea-4914-88e3-149050f506bf"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("55c3b447-34ea-4914-88e3-149050f506bf"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("55c3b447-34ea-4914-88e3-149050f506bf"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("55c3b447-34ea-4914-88e3-149050f506bf"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("55c3b447-34ea-4914-88e3-149050f506bf"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("55c3b447-34ea-4914-88e3-149050f506bf"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5c83dd38-09d7-482c-ab6d-619128067601"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5c83dd38-09d7-482c-ab6d-619128067601"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5c83dd38-09d7-482c-ab6d-619128067601"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5c83dd38-09d7-482c-ab6d-619128067601"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5c83dd38-09d7-482c-ab6d-619128067601"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5c83dd38-09d7-482c-ab6d-619128067601"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5c83dd38-09d7-482c-ab6d-619128067601"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5c83dd38-09d7-482c-ab6d-619128067601"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5c83dd38-09d7-482c-ab6d-619128067601"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5c83dd38-09d7-482c-ab6d-619128067601"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("616e5fe3-d11a-4dbd-892e-e306fdca6152"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("616e5fe3-d11a-4dbd-892e-e306fdca6152"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("616e5fe3-d11a-4dbd-892e-e306fdca6152"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("616e5fe3-d11a-4dbd-892e-e306fdca6152"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("616e5fe3-d11a-4dbd-892e-e306fdca6152"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("616e5fe3-d11a-4dbd-892e-e306fdca6152"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("616e5fe3-d11a-4dbd-892e-e306fdca6152"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("616e5fe3-d11a-4dbd-892e-e306fdca6152"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("616e5fe3-d11a-4dbd-892e-e306fdca6152"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("616e5fe3-d11a-4dbd-892e-e306fdca6152"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("66a2ca8d-609c-4e66-b223-d4c3161e9247"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("66a2ca8d-609c-4e66-b223-d4c3161e9247"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("66a2ca8d-609c-4e66-b223-d4c3161e9247"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("66a2ca8d-609c-4e66-b223-d4c3161e9247"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("66a2ca8d-609c-4e66-b223-d4c3161e9247"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6c349201-d0a9-4f59-9778-bb60532f7f96"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6c349201-d0a9-4f59-9778-bb60532f7f96"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6c349201-d0a9-4f59-9778-bb60532f7f96"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7a5d3b92-770e-4921-83bd-51d041ca65eb"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7a5d3b92-770e-4921-83bd-51d041ca65eb"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7a5d3b92-770e-4921-83bd-51d041ca65eb"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7f7a919b-529a-4b88-95a0-de194f0d8bac"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7f7a919b-529a-4b88-95a0-de194f0d8bac"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7f7a919b-529a-4b88-95a0-de194f0d8bac"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8539385e-4cc6-4040-a720-7d600a28ab5c"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8539385e-4cc6-4040-a720-7d600a28ab5c"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8539385e-4cc6-4040-a720-7d600a28ab5c"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8539385e-4cc6-4040-a720-7d600a28ab5c"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8539385e-4cc6-4040-a720-7d600a28ab5c"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("860569d3-c3b5-4e77-a328-6f0f9e55ac28"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("860569d3-c3b5-4e77-a328-6f0f9e55ac28"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("860569d3-c3b5-4e77-a328-6f0f9e55ac28"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("860569d3-c3b5-4e77-a328-6f0f9e55ac28"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("860569d3-c3b5-4e77-a328-6f0f9e55ac28"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("863a1263-9f6d-4d66-bedf-092696620752"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("863a1263-9f6d-4d66-bedf-092696620752"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("863a1263-9f6d-4d66-bedf-092696620752"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("863a1263-9f6d-4d66-bedf-092696620752"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("863a1263-9f6d-4d66-bedf-092696620752"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("967be8f6-6693-4fff-96a6-cbcf03748d39"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("967be8f6-6693-4fff-96a6-cbcf03748d39"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("967be8f6-6693-4fff-96a6-cbcf03748d39"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("97444468-0fee-4465-b5a5-47c4bf6865b6"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("97444468-0fee-4465-b5a5-47c4bf6865b6"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("97444468-0fee-4465-b5a5-47c4bf6865b6"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("97444468-0fee-4465-b5a5-47c4bf6865b6"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("97444468-0fee-4465-b5a5-47c4bf6865b6"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("97444468-0fee-4465-b5a5-47c4bf6865b6"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("97444468-0fee-4465-b5a5-47c4bf6865b6"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("97444468-0fee-4465-b5a5-47c4bf6865b6"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("97444468-0fee-4465-b5a5-47c4bf6865b6"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("97444468-0fee-4465-b5a5-47c4bf6865b6"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a33c9abe-8af8-4e80-aa29-8588eeedc24b"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a33c9abe-8af8-4e80-aa29-8588eeedc24b"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a33c9abe-8af8-4e80-aa29-8588eeedc24b"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a33c9abe-8af8-4e80-aa29-8588eeedc24b"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a33c9abe-8af8-4e80-aa29-8588eeedc24b"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a33c9abe-8af8-4e80-aa29-8588eeedc24b"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a33c9abe-8af8-4e80-aa29-8588eeedc24b"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a33c9abe-8af8-4e80-aa29-8588eeedc24b"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a33c9abe-8af8-4e80-aa29-8588eeedc24b"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a33c9abe-8af8-4e80-aa29-8588eeedc24b"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a597fa6c-1674-4488-9ca8-097c37b6ded1"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a597fa6c-1674-4488-9ca8-097c37b6ded1"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a597fa6c-1674-4488-9ca8-097c37b6ded1"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a7095ce6-f37e-4993-9a9d-c32a98d72e90"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a7095ce6-f37e-4993-9a9d-c32a98d72e90"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a7095ce6-f37e-4993-9a9d-c32a98d72e90"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a7095ce6-f37e-4993-9a9d-c32a98d72e90"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a7095ce6-f37e-4993-9a9d-c32a98d72e90"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a7095ce6-f37e-4993-9a9d-c32a98d72e90"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a7095ce6-f37e-4993-9a9d-c32a98d72e90"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a7095ce6-f37e-4993-9a9d-c32a98d72e90"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a7095ce6-f37e-4993-9a9d-c32a98d72e90"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a7095ce6-f37e-4993-9a9d-c32a98d72e90"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ab704c64-b30a-457e-93a7-45f8053abf8f"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ab704c64-b30a-457e-93a7-45f8053abf8f"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ab704c64-b30a-457e-93a7-45f8053abf8f"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b122d3fa-aa19-41ba-8be2-96a9a335add6"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b122d3fa-aa19-41ba-8be2-96a9a335add6"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b122d3fa-aa19-41ba-8be2-96a9a335add6"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b122d3fa-aa19-41ba-8be2-96a9a335add6"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b122d3fa-aa19-41ba-8be2-96a9a335add6"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b71098d4-d17e-4f7b-9283-2e48ebd64f67"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b71098d4-d17e-4f7b-9283-2e48ebd64f67"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b71098d4-d17e-4f7b-9283-2e48ebd64f67"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b71098d4-d17e-4f7b-9283-2e48ebd64f67"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b71098d4-d17e-4f7b-9283-2e48ebd64f67"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b8170632-875f-46f1-8557-966ae758e43f"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b8170632-875f-46f1-8557-966ae758e43f"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b8170632-875f-46f1-8557-966ae758e43f"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b8170632-875f-46f1-8557-966ae758e43f"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b8170632-875f-46f1-8557-966ae758e43f"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ca1f6d94-0474-4938-ab59-36c05452f1be"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ca1f6d94-0474-4938-ab59-36c05452f1be"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ca1f6d94-0474-4938-ab59-36c05452f1be"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d3dd27a1-2531-4ed3-a89f-9a3ca725b79d"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d3dd27a1-2531-4ed3-a89f-9a3ca725b79d"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d3dd27a1-2531-4ed3-a89f-9a3ca725b79d"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e26f7572-82c7-484e-99cb-29d2c214ea92"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e26f7572-82c7-484e-99cb-29d2c214ea92"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e26f7572-82c7-484e-99cb-29d2c214ea92"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e5c53d57-2d9d-4867-928b-1477bec414c2"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e5c53d57-2d9d-4867-928b-1477bec414c2"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e5c53d57-2d9d-4867-928b-1477bec414c2"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ea47892b-677f-4c62-a0da-1c04e9715936"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ea47892b-677f-4c62-a0da-1c04e9715936"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ea47892b-677f-4c62-a0da-1c04e9715936"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ea47892b-677f-4c62-a0da-1c04e9715936"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ea47892b-677f-4c62-a0da-1c04e9715936"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ea47892b-677f-4c62-a0da-1c04e9715936"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ea47892b-677f-4c62-a0da-1c04e9715936"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ea47892b-677f-4c62-a0da-1c04e9715936"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ea47892b-677f-4c62-a0da-1c04e9715936"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ea47892b-677f-4c62-a0da-1c04e9715936"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ef0a0724-7cbf-465c-b4a3-a972e5fc286b"), new Guid("19ca51d8-651c-4e22-946a-d586b030ec90") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ef0a0724-7cbf-465c-b4a3-a972e5fc286b"), new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ef0a0724-7cbf-465c-b4a3-a972e5fc286b"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ef0a0724-7cbf-465c-b4a3-a972e5fc286b"), new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ef0a0724-7cbf-465c-b4a3-a972e5fc286b"), new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ef0a0724-7cbf-465c-b4a3-a972e5fc286b"), new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ef0a0724-7cbf-465c-b4a3-a972e5fc286b"), new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ef0a0724-7cbf-465c-b4a3-a972e5fc286b"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ef0a0724-7cbf-465c-b4a3-a972e5fc286b"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ef0a0724-7cbf-465c-b4a3-a972e5fc286b"), new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fc9a64db-7ea6-46cb-b71f-0408df5bd965"), new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fc9a64db-7ea6-46cb-b71f-0408df5bd965"), new Guid("c23ec077-7520-49a6-b66c-592a293ca5be") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fc9a64db-7ea6-46cb-b71f-0408df5bd965"), new Guid("c80fcb59-fa93-4347-9124-c827edee9766") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0948b75f-7d51-4d2f-8af3-2ee3dcb18b9f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("14b0d8fd-b1ca-447b-b0bf-b6c02924a667"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1909b61a-60a9-4e0a-84fd-363fe4cff93d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2e4d9eca-de94-47b3-a5f5-335bac70494f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("32547e0f-2dc3-419e-ae24-43bde97a2b93"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4c1ebfa4-4452-430f-af7b-9c3da63645fb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4d2d1bfd-33b8-4d62-b0af-ae03d8d7936f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4fa6c5dd-95c0-4e95-bf9a-56be9c06ea72"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("505e8862-110e-40f9-86d3-63ab0a483990"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("55c3b447-34ea-4914-88e3-149050f506bf"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5c83dd38-09d7-482c-ab6d-619128067601"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("616e5fe3-d11a-4dbd-892e-e306fdca6152"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("66a2ca8d-609c-4e66-b223-d4c3161e9247"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6c349201-d0a9-4f59-9778-bb60532f7f96"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7a5d3b92-770e-4921-83bd-51d041ca65eb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7f7a919b-529a-4b88-95a0-de194f0d8bac"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8539385e-4cc6-4040-a720-7d600a28ab5c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("860569d3-c3b5-4e77-a328-6f0f9e55ac28"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("863a1263-9f6d-4d66-bedf-092696620752"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("967be8f6-6693-4fff-96a6-cbcf03748d39"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("97444468-0fee-4465-b5a5-47c4bf6865b6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a33c9abe-8af8-4e80-aa29-8588eeedc24b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a597fa6c-1674-4488-9ca8-097c37b6ded1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a7095ce6-f37e-4993-9a9d-c32a98d72e90"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ab704c64-b30a-457e-93a7-45f8053abf8f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b122d3fa-aa19-41ba-8be2-96a9a335add6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b71098d4-d17e-4f7b-9283-2e48ebd64f67"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b8170632-875f-46f1-8557-966ae758e43f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ca1f6d94-0474-4938-ab59-36c05452f1be"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d3dd27a1-2531-4ed3-a89f-9a3ca725b79d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e26f7572-82c7-484e-99cb-29d2c214ea92"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e5c53d57-2d9d-4867-928b-1477bec414c2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ea47892b-677f-4c62-a0da-1c04e9715936"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ef0a0724-7cbf-465c-b4a3-a972e5fc286b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fc9a64db-7ea6-46cb-b71f-0408df5bd965"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19ca51d8-651c-4e22-946a-d586b030ec90"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1f43ab3c-7f7e-483e-9245-ec1b0ff7965f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28a92ffa-231d-4656-8fde-dcb76fff7a09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30dfbcbd-ea09-4242-8c3a-7823c8953f8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("90e1001a-93b6-435c-b4bf-226138fbf4d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc6199ce-52db-4070-84fd-8ec9d8c94e5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be464286-09ee-4dc5-9278-fe3d3216bb6e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c23ec077-7520-49a6-b66c-592a293ca5be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c80fcb59-fa93-4347-9124-c827edee9766"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ebc83688-a92f-4692-bd7f-00a9644260c8"));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("023edc93-00a2-4a58-ba97-c6975b938679"), "newhome-home" },
                    { new Guid("07c83ee8-96d6-4cb7-ad78-3e56a58e8db4"), "getdevicetypes-devicetype" },
                    { new Guid("082c1a76-04f4-4bde-a7bc-02489abac1e6"), "getmembers-members" },
                    { new Guid("1a3d526f-72af-40be-8a6f-60606e655df7"), "motiondetection-camera" },
                    { new Guid("1a8333ac-1fc0-406d-8359-1c09fb864d32"), "createcompany-companies" },
                    { new Guid("1c3e1850-fdb7-4bb5-8311-0d78ef6bd612"), "adddevice-home" },
                    { new Guid("1fe5019d-9a8b-481a-afaa-25dd4e618721"), "addmotionsensor-motionsensor" },
                    { new Guid("210dcfb5-85fc-488f-a828-d2d00d2d0674"), "open-windowsensor" },
                    { new Guid("224031ee-106d-4a04-ab60-a69430dcd5f1"), "createcompanyowneraccount-companyowner" },
                    { new Guid("30d745b2-c43a-4ba9-8f49-28c359315ef0"), "on-smartlamp" },
                    { new Guid("31642eed-ff18-42a8-b869-552619a2413e"), "addmotionsensor-motionsensor" },
                    { new Guid("4922f975-5b10-4167-add3-9317376f40e5"), "deleteadminaccount-administrator" },
                    { new Guid("4a71791f-7767-4fd3-8214-954d2bd777e2"), "getrooms-home" },
                    { new Guid("4be6f4be-4916-443c-ab5c-9dcf71b44a16"), "getaccounts-accounts" },
                    { new Guid("50453f7b-9f4e-46ff-9519-590425912ab2"), "getcompany-companies" },
                    { new Guid("52ce6ca7-2bc6-4a60-b184-457fe2623dd2"), "addhomeownerpermission-homeowner" },
                    { new Guid("54a33aac-4450-47ad-b646-245398ef10d4"), "close-windowsensor" },
                    { new Guid("616356a4-3bda-402b-83ad-015076c94bd5"), "createadminaccount-administrator" },
                    { new Guid("67a49969-f32f-43db-b9a3-b3943bc711ac"), "getnotifications-notification" },
                    { new Guid("849e21e5-574f-420a-88a6-ce3722db0458"), "updatenamedevice-home" },
                    { new Guid("a0d6c11e-a23a-4bea-8eae-c2e16fb6d483"), "addnotificationmembers-members" },
                    { new Guid("a6d19f5a-7431-47c1-8536-f11919e9a5dc"), "addhomeownerpermission-homeowner" },
                    { new Guid("b2de97aa-8f11-4322-9308-3cbe8ec6572d"), "gethomes-user" },
                    { new Guid("b75fdb13-5f6b-4fff-8306-8d6a1619740b"), "addcamera-camera" },
                    { new Guid("b94139f3-020a-4139-911e-bd7c0464867b"), "addsensor-windowsensor" },
                    { new Guid("bfbdbfd4-a49f-489c-966b-dc08cc9a37db"), "persondetection-camera" },
                    { new Guid("cc805e85-fcf3-4095-81b2-7b4525d8dc5f"), "getdevices-devices" },
                    { new Guid("d17deb6c-4157-47be-a7aa-130f6ceab8d2"), "addmember-members" },
                    { new Guid("dd3e05c4-f3e3-4bb7-a066-f8066c6c1945"), "motiondetection-motionsensor" },
                    { new Guid("de885b9b-5be0-4bd7-850c-3e702dba4cde"), "addpermission-members" },
                    { new Guid("eacfe38a-059f-4c80-9085-b3d53b6994ad"), "getdevices-home" },
                    { new Guid("f0313212-b989-470f-85dd-f28b422de02d"), "off-smartlamp" },
                    { new Guid("f036e516-5bef-47ab-9c8e-40779f6d5854"), "addsmartlamp-smartlamp" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Password", "ProfilePhoto", "Roles", "Surname" },
                values: new object[,]
                {
                    { new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d"), new DateTime(2024, 10, 25, 21, 13, 33, 484, DateTimeKind.Local).AddTicks(8803), "petesampras@tennis.com", "Pete", "Sampras@123", "sampras.jpg", "[1]", "Sampras" },
                    { new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97"), new DateTime(2024, 10, 25, 21, 13, 33, 484, DateTimeKind.Local).AddTicks(8796), "steffigraf@tennis.com", "Steffi", "Steffi@123", "graf.jpg", "[1]", "Graf" },
                    { new Guid("31f9d350-ce1b-4328-8e67-3f17d1f0b8a8"), new DateTime(2024, 10, 25, 21, 13, 33, 484, DateTimeKind.Local).AddTicks(8784), "rafaelnadal@tennis.com", "Rafael", "Nadal@123", "nadal.jpg", "[0]", "Nadal" },
                    { new Guid("45a88862-a739-4878-aeed-aa9325e7c6d1"), new DateTime(2024, 10, 25, 21, 13, 33, 484, DateTimeKind.Local).AddTicks(8763), "rogerfederer@tennis.com", "Roger", "Federer@123", "federer.jpg", "[0]", "Federer" },
                    { new Guid("5e216bc3-2853-4659-b513-02a1d42dfd0e"), new DateTime(2024, 10, 25, 21, 13, 33, 484, DateTimeKind.Local).AddTicks(8788), "serenawilliams@tennis.com", "Serena", "Serena@123", "serena.jpg", "[2]", "Williams" },
                    { new Guid("7493b1a3-9874-450e-b0b0-3292819a4bae"), new DateTime(2024, 10, 25, 21, 13, 33, 484, DateTimeKind.Local).AddTicks(8814), "johnmcenroe@tennis.com", "John", "McEnroe@123", "mcenroe.jpg", "[2]", "McEnroe" },
                    { new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82"), new DateTime(2024, 10, 25, 21, 13, 33, 484, DateTimeKind.Local).AddTicks(8810), "martinanavratilova@tennis.com", "Martina", "Navratilova@123", "navratilova.jpg", "[1]", "Navratilova" },
                    { new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332"), new DateTime(2024, 10, 25, 21, 13, 33, 484, DateTimeKind.Local).AddTicks(8800), "andreagassi@tennis.com", "Andre", "Agassi@123", "agassi.jpg", "[1]", "Agassi" },
                    { new Guid("eaf67869-b56b-45dd-9ff9-38e3899d4f73"), new DateTime(2024, 10, 25, 21, 13, 33, 484, DateTimeKind.Local).AddTicks(8842), "billiejeanking@tennis.com", "Billie", "King@123", "king.jpg", "[0]", "Jean King" },
                    { new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8"), new DateTime(2024, 10, 25, 21, 13, 33, 484, DateTimeKind.Local).AddTicks(8792), "novakdjokovic@tennis.com", "Novak", "Djokovic@123", "djokovic.jpg", "[2,1]", "Djokovic" }
                });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "PermissionId", "UserId" },
                values: new object[,]
                {
                    { new Guid("023edc93-00a2-4a58-ba97-c6975b938679"), new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d") },
                    { new Guid("023edc93-00a2-4a58-ba97-c6975b938679"), new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97") },
                    { new Guid("023edc93-00a2-4a58-ba97-c6975b938679"), new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82") },
                    { new Guid("023edc93-00a2-4a58-ba97-c6975b938679"), new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332") },
                    { new Guid("023edc93-00a2-4a58-ba97-c6975b938679"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") },
                    { new Guid("082c1a76-04f4-4bde-a7bc-02489abac1e6"), new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d") },
                    { new Guid("082c1a76-04f4-4bde-a7bc-02489abac1e6"), new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97") },
                    { new Guid("082c1a76-04f4-4bde-a7bc-02489abac1e6"), new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82") },
                    { new Guid("082c1a76-04f4-4bde-a7bc-02489abac1e6"), new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332") },
                    { new Guid("082c1a76-04f4-4bde-a7bc-02489abac1e6"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") },
                    { new Guid("1a8333ac-1fc0-406d-8359-1c09fb864d32"), new Guid("31f9d350-ce1b-4328-8e67-3f17d1f0b8a8") },
                    { new Guid("1a8333ac-1fc0-406d-8359-1c09fb864d32"), new Guid("45a88862-a739-4878-aeed-aa9325e7c6d1") },
                    { new Guid("1a8333ac-1fc0-406d-8359-1c09fb864d32"), new Guid("eaf67869-b56b-45dd-9ff9-38e3899d4f73") },
                    { new Guid("1c3e1850-fdb7-4bb5-8311-0d78ef6bd612"), new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d") },
                    { new Guid("1c3e1850-fdb7-4bb5-8311-0d78ef6bd612"), new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97") },
                    { new Guid("1c3e1850-fdb7-4bb5-8311-0d78ef6bd612"), new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82") },
                    { new Guid("1c3e1850-fdb7-4bb5-8311-0d78ef6bd612"), new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332") },
                    { new Guid("1c3e1850-fdb7-4bb5-8311-0d78ef6bd612"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") },
                    { new Guid("1fe5019d-9a8b-481a-afaa-25dd4e618721"), new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d") },
                    { new Guid("1fe5019d-9a8b-481a-afaa-25dd4e618721"), new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97") },
                    { new Guid("1fe5019d-9a8b-481a-afaa-25dd4e618721"), new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82") },
                    { new Guid("1fe5019d-9a8b-481a-afaa-25dd4e618721"), new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332") },
                    { new Guid("1fe5019d-9a8b-481a-afaa-25dd4e618721"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") },
                    { new Guid("224031ee-106d-4a04-ab60-a69430dcd5f1"), new Guid("5e216bc3-2853-4659-b513-02a1d42dfd0e") },
                    { new Guid("224031ee-106d-4a04-ab60-a69430dcd5f1"), new Guid("7493b1a3-9874-450e-b0b0-3292819a4bae") },
                    { new Guid("224031ee-106d-4a04-ab60-a69430dcd5f1"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") },
                    { new Guid("31642eed-ff18-42a8-b869-552619a2413e"), new Guid("31f9d350-ce1b-4328-8e67-3f17d1f0b8a8") },
                    { new Guid("31642eed-ff18-42a8-b869-552619a2413e"), new Guid("45a88862-a739-4878-aeed-aa9325e7c6d1") },
                    { new Guid("31642eed-ff18-42a8-b869-552619a2413e"), new Guid("eaf67869-b56b-45dd-9ff9-38e3899d4f73") },
                    { new Guid("4922f975-5b10-4167-add3-9317376f40e5"), new Guid("5e216bc3-2853-4659-b513-02a1d42dfd0e") },
                    { new Guid("4922f975-5b10-4167-add3-9317376f40e5"), new Guid("7493b1a3-9874-450e-b0b0-3292819a4bae") },
                    { new Guid("4922f975-5b10-4167-add3-9317376f40e5"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") },
                    { new Guid("4a71791f-7767-4fd3-8214-954d2bd777e2"), new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d") },
                    { new Guid("4a71791f-7767-4fd3-8214-954d2bd777e2"), new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97") },
                    { new Guid("4a71791f-7767-4fd3-8214-954d2bd777e2"), new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82") },
                    { new Guid("4a71791f-7767-4fd3-8214-954d2bd777e2"), new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332") },
                    { new Guid("4a71791f-7767-4fd3-8214-954d2bd777e2"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") },
                    { new Guid("4be6f4be-4916-443c-ab5c-9dcf71b44a16"), new Guid("5e216bc3-2853-4659-b513-02a1d42dfd0e") },
                    { new Guid("4be6f4be-4916-443c-ab5c-9dcf71b44a16"), new Guid("7493b1a3-9874-450e-b0b0-3292819a4bae") },
                    { new Guid("4be6f4be-4916-443c-ab5c-9dcf71b44a16"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") },
                    { new Guid("50453f7b-9f4e-46ff-9519-590425912ab2"), new Guid("5e216bc3-2853-4659-b513-02a1d42dfd0e") },
                    { new Guid("50453f7b-9f4e-46ff-9519-590425912ab2"), new Guid("7493b1a3-9874-450e-b0b0-3292819a4bae") },
                    { new Guid("50453f7b-9f4e-46ff-9519-590425912ab2"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") },
                    { new Guid("52ce6ca7-2bc6-4a60-b184-457fe2623dd2"), new Guid("31f9d350-ce1b-4328-8e67-3f17d1f0b8a8") },
                    { new Guid("52ce6ca7-2bc6-4a60-b184-457fe2623dd2"), new Guid("45a88862-a739-4878-aeed-aa9325e7c6d1") },
                    { new Guid("52ce6ca7-2bc6-4a60-b184-457fe2623dd2"), new Guid("eaf67869-b56b-45dd-9ff9-38e3899d4f73") },
                    { new Guid("616356a4-3bda-402b-83ad-015076c94bd5"), new Guid("5e216bc3-2853-4659-b513-02a1d42dfd0e") },
                    { new Guid("616356a4-3bda-402b-83ad-015076c94bd5"), new Guid("7493b1a3-9874-450e-b0b0-3292819a4bae") },
                    { new Guid("616356a4-3bda-402b-83ad-015076c94bd5"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") },
                    { new Guid("849e21e5-574f-420a-88a6-ce3722db0458"), new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d") },
                    { new Guid("849e21e5-574f-420a-88a6-ce3722db0458"), new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97") },
                    { new Guid("849e21e5-574f-420a-88a6-ce3722db0458"), new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82") },
                    { new Guid("849e21e5-574f-420a-88a6-ce3722db0458"), new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332") },
                    { new Guid("849e21e5-574f-420a-88a6-ce3722db0458"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") },
                    { new Guid("a0d6c11e-a23a-4bea-8eae-c2e16fb6d483"), new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d") },
                    { new Guid("a0d6c11e-a23a-4bea-8eae-c2e16fb6d483"), new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97") },
                    { new Guid("a0d6c11e-a23a-4bea-8eae-c2e16fb6d483"), new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82") },
                    { new Guid("a0d6c11e-a23a-4bea-8eae-c2e16fb6d483"), new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332") },
                    { new Guid("a0d6c11e-a23a-4bea-8eae-c2e16fb6d483"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") },
                    { new Guid("a6d19f5a-7431-47c1-8536-f11919e9a5dc"), new Guid("5e216bc3-2853-4659-b513-02a1d42dfd0e") },
                    { new Guid("a6d19f5a-7431-47c1-8536-f11919e9a5dc"), new Guid("7493b1a3-9874-450e-b0b0-3292819a4bae") },
                    { new Guid("a6d19f5a-7431-47c1-8536-f11919e9a5dc"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") },
                    { new Guid("b2de97aa-8f11-4322-9308-3cbe8ec6572d"), new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d") },
                    { new Guid("b2de97aa-8f11-4322-9308-3cbe8ec6572d"), new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97") },
                    { new Guid("b2de97aa-8f11-4322-9308-3cbe8ec6572d"), new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82") },
                    { new Guid("b2de97aa-8f11-4322-9308-3cbe8ec6572d"), new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332") },
                    { new Guid("b2de97aa-8f11-4322-9308-3cbe8ec6572d"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") },
                    { new Guid("b75fdb13-5f6b-4fff-8306-8d6a1619740b"), new Guid("31f9d350-ce1b-4328-8e67-3f17d1f0b8a8") },
                    { new Guid("b75fdb13-5f6b-4fff-8306-8d6a1619740b"), new Guid("45a88862-a739-4878-aeed-aa9325e7c6d1") },
                    { new Guid("b75fdb13-5f6b-4fff-8306-8d6a1619740b"), new Guid("eaf67869-b56b-45dd-9ff9-38e3899d4f73") },
                    { new Guid("b94139f3-020a-4139-911e-bd7c0464867b"), new Guid("31f9d350-ce1b-4328-8e67-3f17d1f0b8a8") },
                    { new Guid("b94139f3-020a-4139-911e-bd7c0464867b"), new Guid("45a88862-a739-4878-aeed-aa9325e7c6d1") },
                    { new Guid("b94139f3-020a-4139-911e-bd7c0464867b"), new Guid("eaf67869-b56b-45dd-9ff9-38e3899d4f73") },
                    { new Guid("d17deb6c-4157-47be-a7aa-130f6ceab8d2"), new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d") },
                    { new Guid("d17deb6c-4157-47be-a7aa-130f6ceab8d2"), new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97") },
                    { new Guid("d17deb6c-4157-47be-a7aa-130f6ceab8d2"), new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82") },
                    { new Guid("d17deb6c-4157-47be-a7aa-130f6ceab8d2"), new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332") },
                    { new Guid("d17deb6c-4157-47be-a7aa-130f6ceab8d2"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") },
                    { new Guid("de885b9b-5be0-4bd7-850c-3e702dba4cde"), new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d") },
                    { new Guid("de885b9b-5be0-4bd7-850c-3e702dba4cde"), new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97") },
                    { new Guid("de885b9b-5be0-4bd7-850c-3e702dba4cde"), new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82") },
                    { new Guid("de885b9b-5be0-4bd7-850c-3e702dba4cde"), new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332") },
                    { new Guid("de885b9b-5be0-4bd7-850c-3e702dba4cde"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") },
                    { new Guid("eacfe38a-059f-4c80-9085-b3d53b6994ad"), new Guid("0186c6b8-4fff-445b-bfc6-e6db7f7d9b1d") },
                    { new Guid("eacfe38a-059f-4c80-9085-b3d53b6994ad"), new Guid("05d872d7-7aa4-4bc5-a666-3b6757d0bf97") },
                    { new Guid("eacfe38a-059f-4c80-9085-b3d53b6994ad"), new Guid("8d87a3a3-8657-4ae5-b871-62276f683d82") },
                    { new Guid("eacfe38a-059f-4c80-9085-b3d53b6994ad"), new Guid("d8d5f9eb-306d-4edd-901f-b9c783700332") },
                    { new Guid("eacfe38a-059f-4c80-9085-b3d53b6994ad"), new Guid("ee0699d5-97ed-475b-99ad-45349a8b33f8") },
                    { new Guid("f036e516-5bef-47ab-9c8e-40779f6d5854"), new Guid("31f9d350-ce1b-4328-8e67-3f17d1f0b8a8") },
                    { new Guid("f036e516-5bef-47ab-9c8e-40779f6d5854"), new Guid("45a88862-a739-4878-aeed-aa9325e7c6d1") },
                    { new Guid("f036e516-5bef-47ab-9c8e-40779f6d5854"), new Guid("eaf67869-b56b-45dd-9ff9-38e3899d4f73") }
                });
        }
    }
}
