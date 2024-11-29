using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHub.DB.Migrations
{
    /// <inheritdoc />
    public partial class CompanyOwnerPerimssionsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
