using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHub.DB.Migrations
{
    /// <inheritdoc />
    public partial class CompanyDeviceModelValidationMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Validator",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0ec09ab0-f4ee-4daf-a358-15e014327b12"), "getcompanyuser-companies" },
                    { new Guid("0f0baebe-81e1-4313-ad63-90bb0a7e8e64"), "addrooms-home" },
                    { new Guid("18382c9f-daa5-4277-a834-3705156ca653"), "getmembers-members" },
                    { new Guid("1bd3df79-28a6-43f5-86ba-88fbb26a3867"), "addsmartlamp-smartlamp" },
                    { new Guid("1cf5102a-a990-4897-a7a3-20e3a7a8a9c4"), "createcompany-companies" },
                    { new Guid("1d6d80d6-878a-4f3d-a24e-fc82a6b7a044"), "getpermissions-home" },
                    { new Guid("21aa7240-2887-418d-bbd4-ebc65b268642"), "getaccounts-accounts" },
                    { new Guid("2797a995-92e9-4cc6-92a6-524cc8e37ad0"), "createadminaccount-administrator" },
                    { new Guid("283a5f30-d476-4a1a-920e-3f88fdb244a9"), "persondetection-camera" },
                    { new Guid("2fbb8681-f44c-408a-9da9-83be613713eb"), "addhomeownerpermission-homeowner" },
                    { new Guid("3105272f-285f-4510-827d-68345265e5a4"), "addcamera-camera" },
                    { new Guid("36003e34-d4ee-4d69-9e17-69b75a912717"), "on-smartlamp" },
                    { new Guid("3df86421-0c34-43b9-a68b-df2a0065462b"), "addmember-members" },
                    { new Guid("3ec1778e-f770-4dfe-af78-81f8d888c013"), "createcompanyowneraccount-companyowner" },
                    { new Guid("3fbe914f-5dfb-4283-baef-ef8f2b8174a0"), "updatenamedevice-home" },
                    { new Guid("48ea25dc-0af9-4860-857e-618b566a38da"), "getimporters-devices" },
                    { new Guid("4d055f14-cf7a-40a5-b8ac-3c5f64b539b2"), "addpermission-members" },
                    { new Guid("55d423b0-c045-42ec-b3d1-53059dd9a81f"), "addsensor-windowsensor" },
                    { new Guid("5be60e33-7852-4448-ab98-34df4f167722"), "close-windowsensor" },
                    { new Guid("5e8e4361-74d0-4207-87d9-e2ca1b016fd4"), "addnotificationmembers-members" },
                    { new Guid("6bfe1e72-fb05-48a9-af9e-b64663e5bd0c"), "off-smartlamp" },
                    { new Guid("6f1153e0-a140-41b4-9430-f27b97b4755d"), "getrooms-home" },
                    { new Guid("745be69a-a826-4681-afd6-fb078077e5bb"), "getnotifications-notification" },
                    { new Guid("81cc5bdb-7ffb-4c76-9a6b-663d000a869e"), "addmotionsensor-motionsensor" },
                    { new Guid("a00824d0-de14-4255-a2fd-b432239d0fd0"), "motiondetection-camera" },
                    { new Guid("afd88a6d-94e1-49db-8326-61f25425f751"), "selectdevicemodelvalidator-devices" },
                    { new Guid("b4ff06ef-4ab5-4320-a328-34b102cf18b1"), "importdevices-devices" },
                    { new Guid("b9076b7e-ea7d-427d-8ea5-9ed2730642e2"), "motiondetection-motionsensor" },
                    { new Guid("d13c1b7f-43d8-4242-8db1-5a5d8e8e088e"), "adddevice-home" },
                    { new Guid("d5e44a76-0591-4d28-8a55-c4590a1c7cc6"), "open-windowsensor" },
                    { new Guid("d7cb89bc-3824-48f3-89f7-6b13a822b1c8"), "deleteadminaccount-administrator" },
                    { new Guid("d87de716-d773-41b7-850a-2e067b8058ea"), "getdevicemodelvalidators-devices" },
                    { new Guid("d92f5e63-0235-42fe-beb4-d108f778e799"), "getdevicetypes-devicetype" },
                    { new Guid("ddd33fee-dc86-4451-bc25-1a5a6fa9837f"), "addhomeownerpermission-homeowner" },
                    { new Guid("df2a46d3-346f-4e08-b090-b7a81e3aa650"), "gethomes-user" },
                    { new Guid("e406e50c-23c0-4944-9ec1-aa060c8fa935"), "getdevices-home" },
                    { new Guid("ebded65c-08d4-499c-b40d-3aebd18ce3f9"), "getdevices-devices" },
                    { new Guid("f1861871-1dc0-48e8-b464-cc5414ec701c"), "addmotionsensor-motionsensor" },
                    { new Guid("f1ec4f0d-1f30-4433-9742-8190339f60aa"), "getcompany-companies" },
                    { new Guid("f789a3c1-3ac6-45bd-9277-458249206097"), "updateroomdevice-home" },
                    { new Guid("ffb242b0-6803-458a-b644-2af27bfcd628"), "newhome-home" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Password", "ProfilePhoto", "Roles", "Surname" },
                values: new object[,]
                {
                    { new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73"), new DateTime(2024, 11, 17, 23, 32, 50, 578, DateTimeKind.Local).AddTicks(3595), "petesampras@tennis.com", "Pete", "Sampras@123", "sampras.jpg", "[1]", "Sampras" },
                    { new Guid("3002d8cb-7e40-4294-949e-b92328370ea3"), new DateTime(2024, 11, 17, 23, 32, 50, 578, DateTimeKind.Local).AddTicks(3601), "johnmcenroe@tennis.com", "John", "McEnroe@123", "mcenroe.jpg", "[2]", "McEnroe" },
                    { new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37"), new DateTime(2024, 11, 17, 23, 32, 50, 578, DateTimeKind.Local).AddTicks(3563), "serenawilliams@tennis.com", "Serena", "Serena@123", "serena.jpg", "[2]", "Williams" },
                    { new Guid("771457c4-087e-43f2-9ed0-80f7167c2296"), new DateTime(2024, 11, 17, 23, 32, 50, 578, DateTimeKind.Local).AddTicks(3537), "rogerfederer@tennis.com", "Roger", "Federer@123", "federer.jpg", "[0]", "Federer" },
                    { new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3"), new DateTime(2024, 11, 17, 23, 32, 50, 578, DateTimeKind.Local).AddTicks(3566), "novakdjokovic@tennis.com", "Novak", "Djokovic@123", "djokovic.jpg", "[2,1]", "Djokovic" },
                    { new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4"), new DateTime(2024, 11, 17, 23, 32, 50, 578, DateTimeKind.Local).AddTicks(3605), "billiejeanking@tennis.com", "Billie", "King@123", "king.jpg", "[0]", "Jean King" },
                    { new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2"), new DateTime(2024, 11, 17, 23, 32, 50, 578, DateTimeKind.Local).AddTicks(3592), "andreagassi@tennis.com", "Andre", "Agassi@123", "agassi.jpg", "[1]", "Agassi" },
                    { new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97"), new DateTime(2024, 11, 17, 23, 32, 50, 578, DateTimeKind.Local).AddTicks(3569), "steffigraf@tennis.com", "Steffi", "Steffi@123", "graf.jpg", "[1]", "Graf" },
                    { new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3"), new DateTime(2024, 11, 17, 23, 32, 50, 578, DateTimeKind.Local).AddTicks(3598), "martinanavratilova@tennis.com", "Martina", "Navratilova@123", "navratilova.jpg", "[1]", "Navratilova" },
                    { new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11"), new DateTime(2024, 11, 17, 23, 32, 50, 578, DateTimeKind.Local).AddTicks(3559), "rafaelnadal@tennis.com", "Rafael", "Nadal@123", "nadal.jpg", "[0]", "Nadal" }
                });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "PermissionId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0ec09ab0-f4ee-4daf-a358-15e014327b12"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") },
                    { new Guid("0ec09ab0-f4ee-4daf-a358-15e014327b12"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") },
                    { new Guid("0ec09ab0-f4ee-4daf-a358-15e014327b12"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") },
                    { new Guid("0f0baebe-81e1-4313-ad63-90bb0a7e8e64"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("0f0baebe-81e1-4313-ad63-90bb0a7e8e64"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("0f0baebe-81e1-4313-ad63-90bb0a7e8e64"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("0f0baebe-81e1-4313-ad63-90bb0a7e8e64"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("0f0baebe-81e1-4313-ad63-90bb0a7e8e64"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("18382c9f-daa5-4277-a834-3705156ca653"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("18382c9f-daa5-4277-a834-3705156ca653"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("18382c9f-daa5-4277-a834-3705156ca653"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("18382c9f-daa5-4277-a834-3705156ca653"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("18382c9f-daa5-4277-a834-3705156ca653"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("1bd3df79-28a6-43f5-86ba-88fbb26a3867"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") },
                    { new Guid("1bd3df79-28a6-43f5-86ba-88fbb26a3867"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") },
                    { new Guid("1bd3df79-28a6-43f5-86ba-88fbb26a3867"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") },
                    { new Guid("1cf5102a-a990-4897-a7a3-20e3a7a8a9c4"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") },
                    { new Guid("1cf5102a-a990-4897-a7a3-20e3a7a8a9c4"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") },
                    { new Guid("1cf5102a-a990-4897-a7a3-20e3a7a8a9c4"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") },
                    { new Guid("1d6d80d6-878a-4f3d-a24e-fc82a6b7a044"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("1d6d80d6-878a-4f3d-a24e-fc82a6b7a044"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") },
                    { new Guid("1d6d80d6-878a-4f3d-a24e-fc82a6b7a044"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") },
                    { new Guid("1d6d80d6-878a-4f3d-a24e-fc82a6b7a044"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") },
                    { new Guid("1d6d80d6-878a-4f3d-a24e-fc82a6b7a044"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("1d6d80d6-878a-4f3d-a24e-fc82a6b7a044"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") },
                    { new Guid("1d6d80d6-878a-4f3d-a24e-fc82a6b7a044"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("1d6d80d6-878a-4f3d-a24e-fc82a6b7a044"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("1d6d80d6-878a-4f3d-a24e-fc82a6b7a044"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("1d6d80d6-878a-4f3d-a24e-fc82a6b7a044"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") },
                    { new Guid("21aa7240-2887-418d-bbd4-ebc65b268642"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") },
                    { new Guid("21aa7240-2887-418d-bbd4-ebc65b268642"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") },
                    { new Guid("21aa7240-2887-418d-bbd4-ebc65b268642"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("2797a995-92e9-4cc6-92a6-524cc8e37ad0"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") },
                    { new Guid("2797a995-92e9-4cc6-92a6-524cc8e37ad0"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") },
                    { new Guid("2797a995-92e9-4cc6-92a6-524cc8e37ad0"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("283a5f30-d476-4a1a-920e-3f88fdb244a9"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("283a5f30-d476-4a1a-920e-3f88fdb244a9"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") },
                    { new Guid("283a5f30-d476-4a1a-920e-3f88fdb244a9"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") },
                    { new Guid("283a5f30-d476-4a1a-920e-3f88fdb244a9"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") },
                    { new Guid("283a5f30-d476-4a1a-920e-3f88fdb244a9"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("283a5f30-d476-4a1a-920e-3f88fdb244a9"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") },
                    { new Guid("283a5f30-d476-4a1a-920e-3f88fdb244a9"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("283a5f30-d476-4a1a-920e-3f88fdb244a9"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("283a5f30-d476-4a1a-920e-3f88fdb244a9"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("283a5f30-d476-4a1a-920e-3f88fdb244a9"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") },
                    { new Guid("2fbb8681-f44c-408a-9da9-83be613713eb"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") },
                    { new Guid("2fbb8681-f44c-408a-9da9-83be613713eb"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") },
                    { new Guid("2fbb8681-f44c-408a-9da9-83be613713eb"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") },
                    { new Guid("3105272f-285f-4510-827d-68345265e5a4"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") },
                    { new Guid("3105272f-285f-4510-827d-68345265e5a4"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") },
                    { new Guid("3105272f-285f-4510-827d-68345265e5a4"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") },
                    { new Guid("36003e34-d4ee-4d69-9e17-69b75a912717"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("36003e34-d4ee-4d69-9e17-69b75a912717"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") },
                    { new Guid("36003e34-d4ee-4d69-9e17-69b75a912717"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") },
                    { new Guid("36003e34-d4ee-4d69-9e17-69b75a912717"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") },
                    { new Guid("36003e34-d4ee-4d69-9e17-69b75a912717"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("36003e34-d4ee-4d69-9e17-69b75a912717"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") },
                    { new Guid("36003e34-d4ee-4d69-9e17-69b75a912717"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("36003e34-d4ee-4d69-9e17-69b75a912717"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("36003e34-d4ee-4d69-9e17-69b75a912717"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("36003e34-d4ee-4d69-9e17-69b75a912717"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") },
                    { new Guid("3df86421-0c34-43b9-a68b-df2a0065462b"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("3df86421-0c34-43b9-a68b-df2a0065462b"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("3df86421-0c34-43b9-a68b-df2a0065462b"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("3df86421-0c34-43b9-a68b-df2a0065462b"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("3df86421-0c34-43b9-a68b-df2a0065462b"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("3ec1778e-f770-4dfe-af78-81f8d888c013"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") },
                    { new Guid("3ec1778e-f770-4dfe-af78-81f8d888c013"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") },
                    { new Guid("3ec1778e-f770-4dfe-af78-81f8d888c013"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("3fbe914f-5dfb-4283-baef-ef8f2b8174a0"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("3fbe914f-5dfb-4283-baef-ef8f2b8174a0"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("3fbe914f-5dfb-4283-baef-ef8f2b8174a0"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("3fbe914f-5dfb-4283-baef-ef8f2b8174a0"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("3fbe914f-5dfb-4283-baef-ef8f2b8174a0"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("48ea25dc-0af9-4860-857e-618b566a38da"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") },
                    { new Guid("48ea25dc-0af9-4860-857e-618b566a38da"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") },
                    { new Guid("48ea25dc-0af9-4860-857e-618b566a38da"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") },
                    { new Guid("4d055f14-cf7a-40a5-b8ac-3c5f64b539b2"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("4d055f14-cf7a-40a5-b8ac-3c5f64b539b2"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("4d055f14-cf7a-40a5-b8ac-3c5f64b539b2"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("4d055f14-cf7a-40a5-b8ac-3c5f64b539b2"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("4d055f14-cf7a-40a5-b8ac-3c5f64b539b2"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("55d423b0-c045-42ec-b3d1-53059dd9a81f"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") },
                    { new Guid("55d423b0-c045-42ec-b3d1-53059dd9a81f"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") },
                    { new Guid("55d423b0-c045-42ec-b3d1-53059dd9a81f"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") },
                    { new Guid("5be60e33-7852-4448-ab98-34df4f167722"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("5be60e33-7852-4448-ab98-34df4f167722"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") },
                    { new Guid("5be60e33-7852-4448-ab98-34df4f167722"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") },
                    { new Guid("5be60e33-7852-4448-ab98-34df4f167722"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") },
                    { new Guid("5be60e33-7852-4448-ab98-34df4f167722"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("5be60e33-7852-4448-ab98-34df4f167722"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") },
                    { new Guid("5be60e33-7852-4448-ab98-34df4f167722"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("5be60e33-7852-4448-ab98-34df4f167722"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("5be60e33-7852-4448-ab98-34df4f167722"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("5be60e33-7852-4448-ab98-34df4f167722"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") },
                    { new Guid("5e8e4361-74d0-4207-87d9-e2ca1b016fd4"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("5e8e4361-74d0-4207-87d9-e2ca1b016fd4"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("5e8e4361-74d0-4207-87d9-e2ca1b016fd4"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("5e8e4361-74d0-4207-87d9-e2ca1b016fd4"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("5e8e4361-74d0-4207-87d9-e2ca1b016fd4"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("6bfe1e72-fb05-48a9-af9e-b64663e5bd0c"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("6bfe1e72-fb05-48a9-af9e-b64663e5bd0c"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") },
                    { new Guid("6bfe1e72-fb05-48a9-af9e-b64663e5bd0c"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") },
                    { new Guid("6bfe1e72-fb05-48a9-af9e-b64663e5bd0c"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") },
                    { new Guid("6bfe1e72-fb05-48a9-af9e-b64663e5bd0c"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("6bfe1e72-fb05-48a9-af9e-b64663e5bd0c"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") },
                    { new Guid("6bfe1e72-fb05-48a9-af9e-b64663e5bd0c"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("6bfe1e72-fb05-48a9-af9e-b64663e5bd0c"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("6bfe1e72-fb05-48a9-af9e-b64663e5bd0c"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("6bfe1e72-fb05-48a9-af9e-b64663e5bd0c"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") },
                    { new Guid("6f1153e0-a140-41b4-9430-f27b97b4755d"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("6f1153e0-a140-41b4-9430-f27b97b4755d"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("6f1153e0-a140-41b4-9430-f27b97b4755d"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("6f1153e0-a140-41b4-9430-f27b97b4755d"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("6f1153e0-a140-41b4-9430-f27b97b4755d"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("745be69a-a826-4681-afd6-fb078077e5bb"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("745be69a-a826-4681-afd6-fb078077e5bb"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") },
                    { new Guid("745be69a-a826-4681-afd6-fb078077e5bb"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") },
                    { new Guid("745be69a-a826-4681-afd6-fb078077e5bb"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") },
                    { new Guid("745be69a-a826-4681-afd6-fb078077e5bb"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("745be69a-a826-4681-afd6-fb078077e5bb"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") },
                    { new Guid("745be69a-a826-4681-afd6-fb078077e5bb"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("745be69a-a826-4681-afd6-fb078077e5bb"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("745be69a-a826-4681-afd6-fb078077e5bb"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("745be69a-a826-4681-afd6-fb078077e5bb"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") },
                    { new Guid("81cc5bdb-7ffb-4c76-9a6b-663d000a869e"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("81cc5bdb-7ffb-4c76-9a6b-663d000a869e"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("81cc5bdb-7ffb-4c76-9a6b-663d000a869e"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("81cc5bdb-7ffb-4c76-9a6b-663d000a869e"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("81cc5bdb-7ffb-4c76-9a6b-663d000a869e"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("a00824d0-de14-4255-a2fd-b432239d0fd0"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("a00824d0-de14-4255-a2fd-b432239d0fd0"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") },
                    { new Guid("a00824d0-de14-4255-a2fd-b432239d0fd0"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") },
                    { new Guid("a00824d0-de14-4255-a2fd-b432239d0fd0"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") },
                    { new Guid("a00824d0-de14-4255-a2fd-b432239d0fd0"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("a00824d0-de14-4255-a2fd-b432239d0fd0"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") },
                    { new Guid("a00824d0-de14-4255-a2fd-b432239d0fd0"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("a00824d0-de14-4255-a2fd-b432239d0fd0"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("a00824d0-de14-4255-a2fd-b432239d0fd0"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("a00824d0-de14-4255-a2fd-b432239d0fd0"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") },
                    { new Guid("afd88a6d-94e1-49db-8326-61f25425f751"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") },
                    { new Guid("afd88a6d-94e1-49db-8326-61f25425f751"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") },
                    { new Guid("afd88a6d-94e1-49db-8326-61f25425f751"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") },
                    { new Guid("b4ff06ef-4ab5-4320-a328-34b102cf18b1"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") },
                    { new Guid("b4ff06ef-4ab5-4320-a328-34b102cf18b1"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") },
                    { new Guid("b4ff06ef-4ab5-4320-a328-34b102cf18b1"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") },
                    { new Guid("b9076b7e-ea7d-427d-8ea5-9ed2730642e2"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("b9076b7e-ea7d-427d-8ea5-9ed2730642e2"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") },
                    { new Guid("b9076b7e-ea7d-427d-8ea5-9ed2730642e2"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") },
                    { new Guid("b9076b7e-ea7d-427d-8ea5-9ed2730642e2"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") },
                    { new Guid("b9076b7e-ea7d-427d-8ea5-9ed2730642e2"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("b9076b7e-ea7d-427d-8ea5-9ed2730642e2"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") },
                    { new Guid("b9076b7e-ea7d-427d-8ea5-9ed2730642e2"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("b9076b7e-ea7d-427d-8ea5-9ed2730642e2"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("b9076b7e-ea7d-427d-8ea5-9ed2730642e2"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("b9076b7e-ea7d-427d-8ea5-9ed2730642e2"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") },
                    { new Guid("d13c1b7f-43d8-4242-8db1-5a5d8e8e088e"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("d13c1b7f-43d8-4242-8db1-5a5d8e8e088e"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("d13c1b7f-43d8-4242-8db1-5a5d8e8e088e"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("d13c1b7f-43d8-4242-8db1-5a5d8e8e088e"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("d13c1b7f-43d8-4242-8db1-5a5d8e8e088e"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("d5e44a76-0591-4d28-8a55-c4590a1c7cc6"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("d5e44a76-0591-4d28-8a55-c4590a1c7cc6"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") },
                    { new Guid("d5e44a76-0591-4d28-8a55-c4590a1c7cc6"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") },
                    { new Guid("d5e44a76-0591-4d28-8a55-c4590a1c7cc6"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") },
                    { new Guid("d5e44a76-0591-4d28-8a55-c4590a1c7cc6"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("d5e44a76-0591-4d28-8a55-c4590a1c7cc6"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") },
                    { new Guid("d5e44a76-0591-4d28-8a55-c4590a1c7cc6"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("d5e44a76-0591-4d28-8a55-c4590a1c7cc6"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("d5e44a76-0591-4d28-8a55-c4590a1c7cc6"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("d5e44a76-0591-4d28-8a55-c4590a1c7cc6"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") },
                    { new Guid("d7cb89bc-3824-48f3-89f7-6b13a822b1c8"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") },
                    { new Guid("d7cb89bc-3824-48f3-89f7-6b13a822b1c8"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") },
                    { new Guid("d7cb89bc-3824-48f3-89f7-6b13a822b1c8"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("d87de716-d773-41b7-850a-2e067b8058ea"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") },
                    { new Guid("d87de716-d773-41b7-850a-2e067b8058ea"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") },
                    { new Guid("d87de716-d773-41b7-850a-2e067b8058ea"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") },
                    { new Guid("d92f5e63-0235-42fe-beb4-d108f778e799"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("d92f5e63-0235-42fe-beb4-d108f778e799"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") },
                    { new Guid("d92f5e63-0235-42fe-beb4-d108f778e799"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") },
                    { new Guid("d92f5e63-0235-42fe-beb4-d108f778e799"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") },
                    { new Guid("d92f5e63-0235-42fe-beb4-d108f778e799"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("d92f5e63-0235-42fe-beb4-d108f778e799"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") },
                    { new Guid("d92f5e63-0235-42fe-beb4-d108f778e799"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("d92f5e63-0235-42fe-beb4-d108f778e799"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("d92f5e63-0235-42fe-beb4-d108f778e799"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("d92f5e63-0235-42fe-beb4-d108f778e799"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") },
                    { new Guid("ddd33fee-dc86-4451-bc25-1a5a6fa9837f"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") },
                    { new Guid("ddd33fee-dc86-4451-bc25-1a5a6fa9837f"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") },
                    { new Guid("ddd33fee-dc86-4451-bc25-1a5a6fa9837f"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("df2a46d3-346f-4e08-b090-b7a81e3aa650"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("df2a46d3-346f-4e08-b090-b7a81e3aa650"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("df2a46d3-346f-4e08-b090-b7a81e3aa650"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("df2a46d3-346f-4e08-b090-b7a81e3aa650"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("df2a46d3-346f-4e08-b090-b7a81e3aa650"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("e406e50c-23c0-4944-9ec1-aa060c8fa935"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("e406e50c-23c0-4944-9ec1-aa060c8fa935"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("e406e50c-23c0-4944-9ec1-aa060c8fa935"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("e406e50c-23c0-4944-9ec1-aa060c8fa935"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("e406e50c-23c0-4944-9ec1-aa060c8fa935"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("ebded65c-08d4-499c-b40d-3aebd18ce3f9"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("ebded65c-08d4-499c-b40d-3aebd18ce3f9"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") },
                    { new Guid("ebded65c-08d4-499c-b40d-3aebd18ce3f9"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") },
                    { new Guid("ebded65c-08d4-499c-b40d-3aebd18ce3f9"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") },
                    { new Guid("ebded65c-08d4-499c-b40d-3aebd18ce3f9"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("ebded65c-08d4-499c-b40d-3aebd18ce3f9"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") },
                    { new Guid("ebded65c-08d4-499c-b40d-3aebd18ce3f9"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("ebded65c-08d4-499c-b40d-3aebd18ce3f9"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("ebded65c-08d4-499c-b40d-3aebd18ce3f9"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("ebded65c-08d4-499c-b40d-3aebd18ce3f9"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") },
                    { new Guid("f1861871-1dc0-48e8-b464-cc5414ec701c"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") },
                    { new Guid("f1861871-1dc0-48e8-b464-cc5414ec701c"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") },
                    { new Guid("f1861871-1dc0-48e8-b464-cc5414ec701c"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") },
                    { new Guid("f1ec4f0d-1f30-4433-9742-8190339f60aa"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") },
                    { new Guid("f1ec4f0d-1f30-4433-9742-8190339f60aa"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") },
                    { new Guid("f1ec4f0d-1f30-4433-9742-8190339f60aa"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("f789a3c1-3ac6-45bd-9277-458249206097"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("f789a3c1-3ac6-45bd-9277-458249206097"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("f789a3c1-3ac6-45bd-9277-458249206097"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("f789a3c1-3ac6-45bd-9277-458249206097"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("f789a3c1-3ac6-45bd-9277-458249206097"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") },
                    { new Guid("ffb242b0-6803-458a-b644-2af27bfcd628"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") },
                    { new Guid("ffb242b0-6803-458a-b644-2af27bfcd628"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") },
                    { new Guid("ffb242b0-6803-458a-b644-2af27bfcd628"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") },
                    { new Guid("ffb242b0-6803-458a-b644-2af27bfcd628"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") },
                    { new Guid("ffb242b0-6803-458a-b644-2af27bfcd628"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0ec09ab0-f4ee-4daf-a358-15e014327b12"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0ec09ab0-f4ee-4daf-a358-15e014327b12"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0ec09ab0-f4ee-4daf-a358-15e014327b12"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0f0baebe-81e1-4313-ad63-90bb0a7e8e64"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0f0baebe-81e1-4313-ad63-90bb0a7e8e64"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0f0baebe-81e1-4313-ad63-90bb0a7e8e64"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0f0baebe-81e1-4313-ad63-90bb0a7e8e64"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0f0baebe-81e1-4313-ad63-90bb0a7e8e64"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18382c9f-daa5-4277-a834-3705156ca653"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18382c9f-daa5-4277-a834-3705156ca653"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18382c9f-daa5-4277-a834-3705156ca653"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18382c9f-daa5-4277-a834-3705156ca653"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18382c9f-daa5-4277-a834-3705156ca653"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1bd3df79-28a6-43f5-86ba-88fbb26a3867"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1bd3df79-28a6-43f5-86ba-88fbb26a3867"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1bd3df79-28a6-43f5-86ba-88fbb26a3867"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1cf5102a-a990-4897-a7a3-20e3a7a8a9c4"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1cf5102a-a990-4897-a7a3-20e3a7a8a9c4"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1cf5102a-a990-4897-a7a3-20e3a7a8a9c4"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1d6d80d6-878a-4f3d-a24e-fc82a6b7a044"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1d6d80d6-878a-4f3d-a24e-fc82a6b7a044"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1d6d80d6-878a-4f3d-a24e-fc82a6b7a044"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1d6d80d6-878a-4f3d-a24e-fc82a6b7a044"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1d6d80d6-878a-4f3d-a24e-fc82a6b7a044"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1d6d80d6-878a-4f3d-a24e-fc82a6b7a044"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1d6d80d6-878a-4f3d-a24e-fc82a6b7a044"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1d6d80d6-878a-4f3d-a24e-fc82a6b7a044"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1d6d80d6-878a-4f3d-a24e-fc82a6b7a044"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1d6d80d6-878a-4f3d-a24e-fc82a6b7a044"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("21aa7240-2887-418d-bbd4-ebc65b268642"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("21aa7240-2887-418d-bbd4-ebc65b268642"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("21aa7240-2887-418d-bbd4-ebc65b268642"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2797a995-92e9-4cc6-92a6-524cc8e37ad0"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2797a995-92e9-4cc6-92a6-524cc8e37ad0"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2797a995-92e9-4cc6-92a6-524cc8e37ad0"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("283a5f30-d476-4a1a-920e-3f88fdb244a9"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("283a5f30-d476-4a1a-920e-3f88fdb244a9"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("283a5f30-d476-4a1a-920e-3f88fdb244a9"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("283a5f30-d476-4a1a-920e-3f88fdb244a9"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("283a5f30-d476-4a1a-920e-3f88fdb244a9"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("283a5f30-d476-4a1a-920e-3f88fdb244a9"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("283a5f30-d476-4a1a-920e-3f88fdb244a9"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("283a5f30-d476-4a1a-920e-3f88fdb244a9"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("283a5f30-d476-4a1a-920e-3f88fdb244a9"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("283a5f30-d476-4a1a-920e-3f88fdb244a9"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2fbb8681-f44c-408a-9da9-83be613713eb"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2fbb8681-f44c-408a-9da9-83be613713eb"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2fbb8681-f44c-408a-9da9-83be613713eb"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3105272f-285f-4510-827d-68345265e5a4"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3105272f-285f-4510-827d-68345265e5a4"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3105272f-285f-4510-827d-68345265e5a4"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("36003e34-d4ee-4d69-9e17-69b75a912717"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("36003e34-d4ee-4d69-9e17-69b75a912717"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("36003e34-d4ee-4d69-9e17-69b75a912717"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("36003e34-d4ee-4d69-9e17-69b75a912717"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("36003e34-d4ee-4d69-9e17-69b75a912717"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("36003e34-d4ee-4d69-9e17-69b75a912717"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("36003e34-d4ee-4d69-9e17-69b75a912717"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("36003e34-d4ee-4d69-9e17-69b75a912717"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("36003e34-d4ee-4d69-9e17-69b75a912717"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("36003e34-d4ee-4d69-9e17-69b75a912717"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3df86421-0c34-43b9-a68b-df2a0065462b"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3df86421-0c34-43b9-a68b-df2a0065462b"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3df86421-0c34-43b9-a68b-df2a0065462b"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3df86421-0c34-43b9-a68b-df2a0065462b"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3df86421-0c34-43b9-a68b-df2a0065462b"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3ec1778e-f770-4dfe-af78-81f8d888c013"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3ec1778e-f770-4dfe-af78-81f8d888c013"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3ec1778e-f770-4dfe-af78-81f8d888c013"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3fbe914f-5dfb-4283-baef-ef8f2b8174a0"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3fbe914f-5dfb-4283-baef-ef8f2b8174a0"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3fbe914f-5dfb-4283-baef-ef8f2b8174a0"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3fbe914f-5dfb-4283-baef-ef8f2b8174a0"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3fbe914f-5dfb-4283-baef-ef8f2b8174a0"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("48ea25dc-0af9-4860-857e-618b566a38da"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("48ea25dc-0af9-4860-857e-618b566a38da"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("48ea25dc-0af9-4860-857e-618b566a38da"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4d055f14-cf7a-40a5-b8ac-3c5f64b539b2"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4d055f14-cf7a-40a5-b8ac-3c5f64b539b2"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4d055f14-cf7a-40a5-b8ac-3c5f64b539b2"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4d055f14-cf7a-40a5-b8ac-3c5f64b539b2"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4d055f14-cf7a-40a5-b8ac-3c5f64b539b2"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("55d423b0-c045-42ec-b3d1-53059dd9a81f"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("55d423b0-c045-42ec-b3d1-53059dd9a81f"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("55d423b0-c045-42ec-b3d1-53059dd9a81f"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5be60e33-7852-4448-ab98-34df4f167722"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5be60e33-7852-4448-ab98-34df4f167722"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5be60e33-7852-4448-ab98-34df4f167722"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5be60e33-7852-4448-ab98-34df4f167722"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5be60e33-7852-4448-ab98-34df4f167722"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5be60e33-7852-4448-ab98-34df4f167722"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5be60e33-7852-4448-ab98-34df4f167722"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5be60e33-7852-4448-ab98-34df4f167722"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5be60e33-7852-4448-ab98-34df4f167722"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5be60e33-7852-4448-ab98-34df4f167722"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5e8e4361-74d0-4207-87d9-e2ca1b016fd4"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5e8e4361-74d0-4207-87d9-e2ca1b016fd4"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5e8e4361-74d0-4207-87d9-e2ca1b016fd4"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5e8e4361-74d0-4207-87d9-e2ca1b016fd4"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5e8e4361-74d0-4207-87d9-e2ca1b016fd4"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6bfe1e72-fb05-48a9-af9e-b64663e5bd0c"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6bfe1e72-fb05-48a9-af9e-b64663e5bd0c"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6bfe1e72-fb05-48a9-af9e-b64663e5bd0c"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6bfe1e72-fb05-48a9-af9e-b64663e5bd0c"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6bfe1e72-fb05-48a9-af9e-b64663e5bd0c"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6bfe1e72-fb05-48a9-af9e-b64663e5bd0c"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6bfe1e72-fb05-48a9-af9e-b64663e5bd0c"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6bfe1e72-fb05-48a9-af9e-b64663e5bd0c"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6bfe1e72-fb05-48a9-af9e-b64663e5bd0c"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6bfe1e72-fb05-48a9-af9e-b64663e5bd0c"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6f1153e0-a140-41b4-9430-f27b97b4755d"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6f1153e0-a140-41b4-9430-f27b97b4755d"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6f1153e0-a140-41b4-9430-f27b97b4755d"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6f1153e0-a140-41b4-9430-f27b97b4755d"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6f1153e0-a140-41b4-9430-f27b97b4755d"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("745be69a-a826-4681-afd6-fb078077e5bb"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("745be69a-a826-4681-afd6-fb078077e5bb"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("745be69a-a826-4681-afd6-fb078077e5bb"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("745be69a-a826-4681-afd6-fb078077e5bb"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("745be69a-a826-4681-afd6-fb078077e5bb"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("745be69a-a826-4681-afd6-fb078077e5bb"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("745be69a-a826-4681-afd6-fb078077e5bb"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("745be69a-a826-4681-afd6-fb078077e5bb"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("745be69a-a826-4681-afd6-fb078077e5bb"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("745be69a-a826-4681-afd6-fb078077e5bb"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("81cc5bdb-7ffb-4c76-9a6b-663d000a869e"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("81cc5bdb-7ffb-4c76-9a6b-663d000a869e"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("81cc5bdb-7ffb-4c76-9a6b-663d000a869e"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("81cc5bdb-7ffb-4c76-9a6b-663d000a869e"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("81cc5bdb-7ffb-4c76-9a6b-663d000a869e"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a00824d0-de14-4255-a2fd-b432239d0fd0"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a00824d0-de14-4255-a2fd-b432239d0fd0"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a00824d0-de14-4255-a2fd-b432239d0fd0"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a00824d0-de14-4255-a2fd-b432239d0fd0"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a00824d0-de14-4255-a2fd-b432239d0fd0"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a00824d0-de14-4255-a2fd-b432239d0fd0"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a00824d0-de14-4255-a2fd-b432239d0fd0"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a00824d0-de14-4255-a2fd-b432239d0fd0"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a00824d0-de14-4255-a2fd-b432239d0fd0"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a00824d0-de14-4255-a2fd-b432239d0fd0"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("afd88a6d-94e1-49db-8326-61f25425f751"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("afd88a6d-94e1-49db-8326-61f25425f751"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("afd88a6d-94e1-49db-8326-61f25425f751"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b4ff06ef-4ab5-4320-a328-34b102cf18b1"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b4ff06ef-4ab5-4320-a328-34b102cf18b1"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b4ff06ef-4ab5-4320-a328-34b102cf18b1"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b9076b7e-ea7d-427d-8ea5-9ed2730642e2"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b9076b7e-ea7d-427d-8ea5-9ed2730642e2"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b9076b7e-ea7d-427d-8ea5-9ed2730642e2"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b9076b7e-ea7d-427d-8ea5-9ed2730642e2"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b9076b7e-ea7d-427d-8ea5-9ed2730642e2"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b9076b7e-ea7d-427d-8ea5-9ed2730642e2"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b9076b7e-ea7d-427d-8ea5-9ed2730642e2"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b9076b7e-ea7d-427d-8ea5-9ed2730642e2"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b9076b7e-ea7d-427d-8ea5-9ed2730642e2"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b9076b7e-ea7d-427d-8ea5-9ed2730642e2"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d13c1b7f-43d8-4242-8db1-5a5d8e8e088e"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d13c1b7f-43d8-4242-8db1-5a5d8e8e088e"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d13c1b7f-43d8-4242-8db1-5a5d8e8e088e"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d13c1b7f-43d8-4242-8db1-5a5d8e8e088e"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d13c1b7f-43d8-4242-8db1-5a5d8e8e088e"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d5e44a76-0591-4d28-8a55-c4590a1c7cc6"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d5e44a76-0591-4d28-8a55-c4590a1c7cc6"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d5e44a76-0591-4d28-8a55-c4590a1c7cc6"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d5e44a76-0591-4d28-8a55-c4590a1c7cc6"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d5e44a76-0591-4d28-8a55-c4590a1c7cc6"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d5e44a76-0591-4d28-8a55-c4590a1c7cc6"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d5e44a76-0591-4d28-8a55-c4590a1c7cc6"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d5e44a76-0591-4d28-8a55-c4590a1c7cc6"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d5e44a76-0591-4d28-8a55-c4590a1c7cc6"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d5e44a76-0591-4d28-8a55-c4590a1c7cc6"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d7cb89bc-3824-48f3-89f7-6b13a822b1c8"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d7cb89bc-3824-48f3-89f7-6b13a822b1c8"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d7cb89bc-3824-48f3-89f7-6b13a822b1c8"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d87de716-d773-41b7-850a-2e067b8058ea"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d87de716-d773-41b7-850a-2e067b8058ea"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d87de716-d773-41b7-850a-2e067b8058ea"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d92f5e63-0235-42fe-beb4-d108f778e799"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d92f5e63-0235-42fe-beb4-d108f778e799"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d92f5e63-0235-42fe-beb4-d108f778e799"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d92f5e63-0235-42fe-beb4-d108f778e799"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d92f5e63-0235-42fe-beb4-d108f778e799"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d92f5e63-0235-42fe-beb4-d108f778e799"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d92f5e63-0235-42fe-beb4-d108f778e799"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d92f5e63-0235-42fe-beb4-d108f778e799"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d92f5e63-0235-42fe-beb4-d108f778e799"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d92f5e63-0235-42fe-beb4-d108f778e799"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ddd33fee-dc86-4451-bc25-1a5a6fa9837f"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ddd33fee-dc86-4451-bc25-1a5a6fa9837f"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ddd33fee-dc86-4451-bc25-1a5a6fa9837f"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("df2a46d3-346f-4e08-b090-b7a81e3aa650"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("df2a46d3-346f-4e08-b090-b7a81e3aa650"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("df2a46d3-346f-4e08-b090-b7a81e3aa650"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("df2a46d3-346f-4e08-b090-b7a81e3aa650"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("df2a46d3-346f-4e08-b090-b7a81e3aa650"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e406e50c-23c0-4944-9ec1-aa060c8fa935"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e406e50c-23c0-4944-9ec1-aa060c8fa935"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e406e50c-23c0-4944-9ec1-aa060c8fa935"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e406e50c-23c0-4944-9ec1-aa060c8fa935"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e406e50c-23c0-4944-9ec1-aa060c8fa935"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ebded65c-08d4-499c-b40d-3aebd18ce3f9"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ebded65c-08d4-499c-b40d-3aebd18ce3f9"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ebded65c-08d4-499c-b40d-3aebd18ce3f9"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ebded65c-08d4-499c-b40d-3aebd18ce3f9"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ebded65c-08d4-499c-b40d-3aebd18ce3f9"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ebded65c-08d4-499c-b40d-3aebd18ce3f9"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ebded65c-08d4-499c-b40d-3aebd18ce3f9"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ebded65c-08d4-499c-b40d-3aebd18ce3f9"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ebded65c-08d4-499c-b40d-3aebd18ce3f9"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ebded65c-08d4-499c-b40d-3aebd18ce3f9"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f1861871-1dc0-48e8-b464-cc5414ec701c"), new Guid("771457c4-087e-43f2-9ed0-80f7167c2296") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f1861871-1dc0-48e8-b464-cc5414ec701c"), new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f1861871-1dc0-48e8-b464-cc5414ec701c"), new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f1ec4f0d-1f30-4433-9742-8190339f60aa"), new Guid("3002d8cb-7e40-4294-949e-b92328370ea3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f1ec4f0d-1f30-4433-9742-8190339f60aa"), new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f1ec4f0d-1f30-4433-9742-8190339f60aa"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f789a3c1-3ac6-45bd-9277-458249206097"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f789a3c1-3ac6-45bd-9277-458249206097"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f789a3c1-3ac6-45bd-9277-458249206097"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f789a3c1-3ac6-45bd-9277-458249206097"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f789a3c1-3ac6-45bd-9277-458249206097"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ffb242b0-6803-458a-b644-2af27bfcd628"), new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ffb242b0-6803-458a-b644-2af27bfcd628"), new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ffb242b0-6803-458a-b644-2af27bfcd628"), new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ffb242b0-6803-458a-b644-2af27bfcd628"), new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ffb242b0-6803-458a-b644-2af27bfcd628"), new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0ec09ab0-f4ee-4daf-a358-15e014327b12"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0f0baebe-81e1-4313-ad63-90bb0a7e8e64"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("18382c9f-daa5-4277-a834-3705156ca653"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1bd3df79-28a6-43f5-86ba-88fbb26a3867"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1cf5102a-a990-4897-a7a3-20e3a7a8a9c4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1d6d80d6-878a-4f3d-a24e-fc82a6b7a044"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("21aa7240-2887-418d-bbd4-ebc65b268642"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2797a995-92e9-4cc6-92a6-524cc8e37ad0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("283a5f30-d476-4a1a-920e-3f88fdb244a9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2fbb8681-f44c-408a-9da9-83be613713eb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3105272f-285f-4510-827d-68345265e5a4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("36003e34-d4ee-4d69-9e17-69b75a912717"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3df86421-0c34-43b9-a68b-df2a0065462b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3ec1778e-f770-4dfe-af78-81f8d888c013"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3fbe914f-5dfb-4283-baef-ef8f2b8174a0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("48ea25dc-0af9-4860-857e-618b566a38da"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4d055f14-cf7a-40a5-b8ac-3c5f64b539b2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("55d423b0-c045-42ec-b3d1-53059dd9a81f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5be60e33-7852-4448-ab98-34df4f167722"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5e8e4361-74d0-4207-87d9-e2ca1b016fd4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6bfe1e72-fb05-48a9-af9e-b64663e5bd0c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6f1153e0-a140-41b4-9430-f27b97b4755d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("745be69a-a826-4681-afd6-fb078077e5bb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("81cc5bdb-7ffb-4c76-9a6b-663d000a869e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a00824d0-de14-4255-a2fd-b432239d0fd0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("afd88a6d-94e1-49db-8326-61f25425f751"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b4ff06ef-4ab5-4320-a328-34b102cf18b1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b9076b7e-ea7d-427d-8ea5-9ed2730642e2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d13c1b7f-43d8-4242-8db1-5a5d8e8e088e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d5e44a76-0591-4d28-8a55-c4590a1c7cc6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d7cb89bc-3824-48f3-89f7-6b13a822b1c8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d87de716-d773-41b7-850a-2e067b8058ea"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d92f5e63-0235-42fe-beb4-d108f778e799"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ddd33fee-dc86-4451-bc25-1a5a6fa9837f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("df2a46d3-346f-4e08-b090-b7a81e3aa650"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e406e50c-23c0-4944-9ec1-aa060c8fa935"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ebded65c-08d4-499c-b40d-3aebd18ce3f9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f1861871-1dc0-48e8-b464-cc5414ec701c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f1ec4f0d-1f30-4433-9742-8190339f60aa"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f789a3c1-3ac6-45bd-9277-458249206097"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ffb242b0-6803-458a-b644-2af27bfcd628"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23489d17-5e4a-48fa-aa83-02c8dbd07b73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3002d8cb-7e40-4294-949e-b92328370ea3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("568267a9-5fbb-4371-8275-242ae3ae1d37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("771457c4-087e-43f2-9ed0-80f7167c2296"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7931eb7d-1f2f-4fb8-b0d9-7eac762640f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a137387-6a06-4a3e-a403-75be7de0e6a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8dd082a4-4c26-46e3-920e-f096d407aed2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d587f9bf-a06d-4fd3-99f7-e90d66a57d97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5daa4f2-91e7-4f1b-ac05-d547b8fbf9c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb07e945-7551-4dd3-8dba-1e0ab57f0e11"));

            migrationBuilder.DropColumn(
                name: "Validator",
                table: "Companies");

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
    }
}
