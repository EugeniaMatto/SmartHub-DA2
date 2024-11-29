using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHub.DB.Migrations
{
    /// <inheritdoc />
    public partial class RoomHomeMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0030e40c-c138-4a19-9181-77c96a700b3e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("16372418-2534-4e27-bd7f-6a7288f7cfb2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3442bc30-8d88-4c6e-9fcb-86cb231082fd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("546b7c89-7413-43a5-96c9-5e1071992947"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("63155c52-d5ad-4ef9-9935-8b7365b90385"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9aaeefff-83bd-4342-8982-aece678c5a6a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a684fb37-aee7-4157-8304-b6626d8dba30"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cedf65fa-1f00-430f-bdeb-059b476f29af"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d876adf4-2d7c-424a-9e54-48ee8a4d4b07"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("eb51f52e-83a4-4b67-98ef-499b43d64ca0"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("008e8016-3edc-4439-9036-5aea63a622f3"), new Guid("5cfb46e7-eef0-48d7-9fc7-3b0463f5737e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("008e8016-3edc-4439-9036-5aea63a622f3"), new Guid("74739b4e-3170-4fb5-b9d0-5925342529e4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("008e8016-3edc-4439-9036-5aea63a622f3"), new Guid("8776c602-600e-4750-a501-7e7557165ece") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("008e8016-3edc-4439-9036-5aea63a622f3"), new Guid("98b52fce-f8e4-431c-88b0-8c7e136dbfc5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("008e8016-3edc-4439-9036-5aea63a622f3"), new Guid("e85e659a-9be8-4d12-bbee-3bc9214853f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("03c54dd2-7534-4c0d-97b7-d86a3f75bf76"), new Guid("29cd95bc-9090-463c-817a-c471fbb5a525") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("03c54dd2-7534-4c0d-97b7-d86a3f75bf76"), new Guid("8776c602-600e-4750-a501-7e7557165ece") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("03c54dd2-7534-4c0d-97b7-d86a3f75bf76"), new Guid("ce3741c4-894e-4248-a025-f8224ca21f3c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("092746b5-edaf-43a1-b543-a3f16e93626e"), new Guid("027743d7-bc4f-4c5d-b1e4-331114e797ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("092746b5-edaf-43a1-b543-a3f16e93626e"), new Guid("dcef6f39-62af-43f2-b358-14b40d5077be") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("092746b5-edaf-43a1-b543-a3f16e93626e"), new Guid("e091684d-d6cf-4be9-bcf9-5cff1cb108a3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("119b959b-5643-45a2-9a6d-8f6606f61df0"), new Guid("29cd95bc-9090-463c-817a-c471fbb5a525") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("119b959b-5643-45a2-9a6d-8f6606f61df0"), new Guid("8776c602-600e-4750-a501-7e7557165ece") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("119b959b-5643-45a2-9a6d-8f6606f61df0"), new Guid("ce3741c4-894e-4248-a025-f8224ca21f3c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1d95fbcf-d6a4-4186-97a4-cd9e7e340b0f"), new Guid("5cfb46e7-eef0-48d7-9fc7-3b0463f5737e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1d95fbcf-d6a4-4186-97a4-cd9e7e340b0f"), new Guid("74739b4e-3170-4fb5-b9d0-5925342529e4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1d95fbcf-d6a4-4186-97a4-cd9e7e340b0f"), new Guid("8776c602-600e-4750-a501-7e7557165ece") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1d95fbcf-d6a4-4186-97a4-cd9e7e340b0f"), new Guid("98b52fce-f8e4-431c-88b0-8c7e136dbfc5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1d95fbcf-d6a4-4186-97a4-cd9e7e340b0f"), new Guid("e85e659a-9be8-4d12-bbee-3bc9214853f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1f37e047-599b-485c-b1e1-d8cdaa695232"), new Guid("5cfb46e7-eef0-48d7-9fc7-3b0463f5737e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1f37e047-599b-485c-b1e1-d8cdaa695232"), new Guid("74739b4e-3170-4fb5-b9d0-5925342529e4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1f37e047-599b-485c-b1e1-d8cdaa695232"), new Guid("8776c602-600e-4750-a501-7e7557165ece") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1f37e047-599b-485c-b1e1-d8cdaa695232"), new Guid("98b52fce-f8e4-431c-88b0-8c7e136dbfc5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1f37e047-599b-485c-b1e1-d8cdaa695232"), new Guid("e85e659a-9be8-4d12-bbee-3bc9214853f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("32f9293e-087c-42f5-9e9b-258bc8216ce4"), new Guid("027743d7-bc4f-4c5d-b1e4-331114e797ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("32f9293e-087c-42f5-9e9b-258bc8216ce4"), new Guid("dcef6f39-62af-43f2-b358-14b40d5077be") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("32f9293e-087c-42f5-9e9b-258bc8216ce4"), new Guid("e091684d-d6cf-4be9-bcf9-5cff1cb108a3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("39a3c9f2-2c34-4a45-bf57-98f980fa7a80"), new Guid("29cd95bc-9090-463c-817a-c471fbb5a525") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("39a3c9f2-2c34-4a45-bf57-98f980fa7a80"), new Guid("8776c602-600e-4750-a501-7e7557165ece") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("39a3c9f2-2c34-4a45-bf57-98f980fa7a80"), new Guid("ce3741c4-894e-4248-a025-f8224ca21f3c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3c69a52c-0a45-4da1-9898-94f3b8d7220e"), new Guid("027743d7-bc4f-4c5d-b1e4-331114e797ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3c69a52c-0a45-4da1-9898-94f3b8d7220e"), new Guid("dcef6f39-62af-43f2-b358-14b40d5077be") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3c69a52c-0a45-4da1-9898-94f3b8d7220e"), new Guid("e091684d-d6cf-4be9-bcf9-5cff1cb108a3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("561b4d2e-f9cd-42d3-8407-48d8d693ee57"), new Guid("5cfb46e7-eef0-48d7-9fc7-3b0463f5737e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("561b4d2e-f9cd-42d3-8407-48d8d693ee57"), new Guid("74739b4e-3170-4fb5-b9d0-5925342529e4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("561b4d2e-f9cd-42d3-8407-48d8d693ee57"), new Guid("8776c602-600e-4750-a501-7e7557165ece") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("561b4d2e-f9cd-42d3-8407-48d8d693ee57"), new Guid("98b52fce-f8e4-431c-88b0-8c7e136dbfc5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("561b4d2e-f9cd-42d3-8407-48d8d693ee57"), new Guid("e85e659a-9be8-4d12-bbee-3bc9214853f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5fbf9614-8c44-412b-9693-df32e6e44723"), new Guid("5cfb46e7-eef0-48d7-9fc7-3b0463f5737e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5fbf9614-8c44-412b-9693-df32e6e44723"), new Guid("74739b4e-3170-4fb5-b9d0-5925342529e4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5fbf9614-8c44-412b-9693-df32e6e44723"), new Guid("8776c602-600e-4750-a501-7e7557165ece") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5fbf9614-8c44-412b-9693-df32e6e44723"), new Guid("98b52fce-f8e4-431c-88b0-8c7e136dbfc5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5fbf9614-8c44-412b-9693-df32e6e44723"), new Guid("e85e659a-9be8-4d12-bbee-3bc9214853f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6822f66a-0e21-4cd4-9265-9419b990a75a"), new Guid("5cfb46e7-eef0-48d7-9fc7-3b0463f5737e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6822f66a-0e21-4cd4-9265-9419b990a75a"), new Guid("74739b4e-3170-4fb5-b9d0-5925342529e4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6822f66a-0e21-4cd4-9265-9419b990a75a"), new Guid("8776c602-600e-4750-a501-7e7557165ece") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6822f66a-0e21-4cd4-9265-9419b990a75a"), new Guid("98b52fce-f8e4-431c-88b0-8c7e136dbfc5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6822f66a-0e21-4cd4-9265-9419b990a75a"), new Guid("e85e659a-9be8-4d12-bbee-3bc9214853f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("706c3caf-499f-44b9-92a8-ef0af92f8005"), new Guid("5cfb46e7-eef0-48d7-9fc7-3b0463f5737e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("706c3caf-499f-44b9-92a8-ef0af92f8005"), new Guid("74739b4e-3170-4fb5-b9d0-5925342529e4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("706c3caf-499f-44b9-92a8-ef0af92f8005"), new Guid("8776c602-600e-4750-a501-7e7557165ece") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("706c3caf-499f-44b9-92a8-ef0af92f8005"), new Guid("98b52fce-f8e4-431c-88b0-8c7e136dbfc5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("706c3caf-499f-44b9-92a8-ef0af92f8005"), new Guid("e85e659a-9be8-4d12-bbee-3bc9214853f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7108ebdc-d8ae-4705-9e30-670bddfea383"), new Guid("5cfb46e7-eef0-48d7-9fc7-3b0463f5737e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7108ebdc-d8ae-4705-9e30-670bddfea383"), new Guid("74739b4e-3170-4fb5-b9d0-5925342529e4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7108ebdc-d8ae-4705-9e30-670bddfea383"), new Guid("8776c602-600e-4750-a501-7e7557165ece") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7108ebdc-d8ae-4705-9e30-670bddfea383"), new Guid("98b52fce-f8e4-431c-88b0-8c7e136dbfc5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7108ebdc-d8ae-4705-9e30-670bddfea383"), new Guid("e85e659a-9be8-4d12-bbee-3bc9214853f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8357b55d-20b3-4566-a41d-4f6957549702"), new Guid("29cd95bc-9090-463c-817a-c471fbb5a525") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8357b55d-20b3-4566-a41d-4f6957549702"), new Guid("8776c602-600e-4750-a501-7e7557165ece") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8357b55d-20b3-4566-a41d-4f6957549702"), new Guid("ce3741c4-894e-4248-a025-f8224ca21f3c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b0ecbadc-e38e-43ca-b064-892ed2790e26"), new Guid("027743d7-bc4f-4c5d-b1e4-331114e797ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b0ecbadc-e38e-43ca-b064-892ed2790e26"), new Guid("dcef6f39-62af-43f2-b358-14b40d5077be") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b0ecbadc-e38e-43ca-b064-892ed2790e26"), new Guid("e091684d-d6cf-4be9-bcf9-5cff1cb108a3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b88f20ec-d886-4af0-885c-5d78aeb24373"), new Guid("027743d7-bc4f-4c5d-b1e4-331114e797ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b88f20ec-d886-4af0-885c-5d78aeb24373"), new Guid("dcef6f39-62af-43f2-b358-14b40d5077be") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b88f20ec-d886-4af0-885c-5d78aeb24373"), new Guid("e091684d-d6cf-4be9-bcf9-5cff1cb108a3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c558e4ba-5d99-4bc9-b55e-c82c53792253"), new Guid("29cd95bc-9090-463c-817a-c471fbb5a525") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c558e4ba-5d99-4bc9-b55e-c82c53792253"), new Guid("8776c602-600e-4750-a501-7e7557165ece") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c558e4ba-5d99-4bc9-b55e-c82c53792253"), new Guid("ce3741c4-894e-4248-a025-f8224ca21f3c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d8be9808-734d-40a6-a377-a27f56c1eecb"), new Guid("29cd95bc-9090-463c-817a-c471fbb5a525") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d8be9808-734d-40a6-a377-a27f56c1eecb"), new Guid("8776c602-600e-4750-a501-7e7557165ece") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d8be9808-734d-40a6-a377-a27f56c1eecb"), new Guid("ce3741c4-894e-4248-a025-f8224ca21f3c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e43a5938-6ed2-4967-a5d0-52e7ae2b6252"), new Guid("027743d7-bc4f-4c5d-b1e4-331114e797ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e43a5938-6ed2-4967-a5d0-52e7ae2b6252"), new Guid("dcef6f39-62af-43f2-b358-14b40d5077be") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e43a5938-6ed2-4967-a5d0-52e7ae2b6252"), new Guid("e091684d-d6cf-4be9-bcf9-5cff1cb108a3") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f4ee80cf-83e7-4d51-8212-4c252936d0e8"), new Guid("5cfb46e7-eef0-48d7-9fc7-3b0463f5737e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f4ee80cf-83e7-4d51-8212-4c252936d0e8"), new Guid("74739b4e-3170-4fb5-b9d0-5925342529e4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f4ee80cf-83e7-4d51-8212-4c252936d0e8"), new Guid("8776c602-600e-4750-a501-7e7557165ece") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f4ee80cf-83e7-4d51-8212-4c252936d0e8"), new Guid("98b52fce-f8e4-431c-88b0-8c7e136dbfc5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f4ee80cf-83e7-4d51-8212-4c252936d0e8"), new Guid("e85e659a-9be8-4d12-bbee-3bc9214853f8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f6f6a3cd-ac08-4f82-ac3d-3f77cd1eb0a0"), new Guid("5cfb46e7-eef0-48d7-9fc7-3b0463f5737e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f6f6a3cd-ac08-4f82-ac3d-3f77cd1eb0a0"), new Guid("74739b4e-3170-4fb5-b9d0-5925342529e4") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f6f6a3cd-ac08-4f82-ac3d-3f77cd1eb0a0"), new Guid("8776c602-600e-4750-a501-7e7557165ece") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f6f6a3cd-ac08-4f82-ac3d-3f77cd1eb0a0"), new Guid("98b52fce-f8e4-431c-88b0-8c7e136dbfc5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f6f6a3cd-ac08-4f82-ac3d-3f77cd1eb0a0"), new Guid("e85e659a-9be8-4d12-bbee-3bc9214853f8") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("008e8016-3edc-4439-9036-5aea63a622f3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("03c54dd2-7534-4c0d-97b7-d86a3f75bf76"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("092746b5-edaf-43a1-b543-a3f16e93626e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("119b959b-5643-45a2-9a6d-8f6606f61df0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1d95fbcf-d6a4-4186-97a4-cd9e7e340b0f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1f37e047-599b-485c-b1e1-d8cdaa695232"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("32f9293e-087c-42f5-9e9b-258bc8216ce4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("39a3c9f2-2c34-4a45-bf57-98f980fa7a80"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3c69a52c-0a45-4da1-9898-94f3b8d7220e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("561b4d2e-f9cd-42d3-8407-48d8d693ee57"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5fbf9614-8c44-412b-9693-df32e6e44723"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6822f66a-0e21-4cd4-9265-9419b990a75a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("706c3caf-499f-44b9-92a8-ef0af92f8005"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7108ebdc-d8ae-4705-9e30-670bddfea383"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8357b55d-20b3-4566-a41d-4f6957549702"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b0ecbadc-e38e-43ca-b064-892ed2790e26"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b88f20ec-d886-4af0-885c-5d78aeb24373"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c558e4ba-5d99-4bc9-b55e-c82c53792253"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d8be9808-734d-40a6-a377-a27f56c1eecb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e43a5938-6ed2-4967-a5d0-52e7ae2b6252"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f4ee80cf-83e7-4d51-8212-4c252936d0e8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f6f6a3cd-ac08-4f82-ac3d-3f77cd1eb0a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("027743d7-bc4f-4c5d-b1e4-331114e797ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29cd95bc-9090-463c-817a-c471fbb5a525"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5cfb46e7-eef0-48d7-9fc7-3b0463f5737e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74739b4e-3170-4fb5-b9d0-5925342529e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8776c602-600e-4750-a501-7e7557165ece"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("98b52fce-f8e4-431c-88b0-8c7e136dbfc5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ce3741c4-894e-4248-a025-f8224ca21f3c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dcef6f39-62af-43f2-b358-14b40d5077be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e091684d-d6cf-4be9-bcf9-5cff1cb108a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e85e659a-9be8-4d12-bbee-3bc9214853f8"));

            migrationBuilder.AddColumn<string>(
                name: "Rooms",
                table: "Homes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "Room",
                table: "Hardwares",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("06629fc9-d121-4586-bf95-21886f045df1"), "createcompanyowneraccount-companyowner" },
                    { new Guid("108c76c1-f352-451a-8464-269053d2d5c5"), "getcompany-companies" },
                    { new Guid("1337bdee-e195-41d4-8d30-20cc44d4db51"), "getnotifications-notification" },
                    { new Guid("1917ea15-d762-4277-b13a-980a476b1991"), "getaccounts-accounts" },
                    { new Guid("23b162c5-7b85-44b4-be86-b46d7fa3be0b"), "addmember-members" },
                    { new Guid("37b3241c-4ae3-4a0f-9796-b3a14a25fbca"), "getdevicetypes-devicetype" },
                    { new Guid("51e0b49c-3590-4e30-a00d-05aca114fdbf"), "open-windowsensor" },
                    { new Guid("52376afd-eb8a-4bd0-9278-d0a6b1c4f164"), "addhomeownerpermission-homeowner" },
                    { new Guid("5b6f2650-04dc-444a-a212-813a57aaea18"), "addsensor-windowsensor" },
                    { new Guid("5e8df53a-15b4-4caa-8306-a44d3bd143a6"), "motiondetection-motionsensor" },
                    { new Guid("648d4378-b89d-4491-8ab6-0d49a485a1dc"), "off-smartlamp" },
                    { new Guid("69e4f819-a5ca-41fd-8775-50d689506332"), "addpermission-members" },
                    { new Guid("6cebc42e-d5f8-44ca-b621-8ecc2b624e73"), "addsmartlamp-smartlamp" },
                    { new Guid("71dd38b8-efab-44b6-b6f7-5572db7ae8b5"), "addmotionsensor-motionsensor" },
                    { new Guid("77da324b-dd05-4c82-bc40-b574d43dc47c"), "getdevices-home" },
                    { new Guid("a3ff8ff2-a2e6-459f-9f9e-18642f2a5404"), "deleteadminaccount-administrator" },
                    { new Guid("ac9ee154-c6c4-4765-a7dd-168d51d96526"), "addcamera-camera" },
                    { new Guid("ae2462b7-ca1a-4e1e-8004-7ebc3d133149"), "on-smartlamp" },
                    { new Guid("afc68adc-941f-4ed2-bd49-8c1da98e00b3"), "adddevice-home" },
                    { new Guid("b1186ef5-6ba9-4818-b724-1cdb58f933ef"), "getmembers-members" },
                    { new Guid("b7fbd728-fa3d-4727-b1cd-50a089da148a"), "persondetection-camera" },
                    { new Guid("ba998e50-29cc-4039-b8c7-02ccd243af26"), "gethomes-user" },
                    { new Guid("c05802c7-41da-4d94-a468-0997cfb59f0f"), "addhomeownerpermission-homeowner" },
                    { new Guid("d15509ee-a5a9-4130-aaf0-b1e8c0ee467d"), "newhome-home" },
                    { new Guid("d53ef3aa-99c4-4197-96db-a4629e688b6f"), "getdevices-devices" },
                    { new Guid("e664aec4-5252-4af7-b087-121c96cc12d7"), "addmotionsensor-motionsensor" },
                    { new Guid("ee1ca303-029b-4ebe-a197-57c5fb38884d"), "close-windowsensor" },
                    { new Guid("fbaf28f1-30ee-4331-9b9a-8035fcabea75"), "addnotificationmembers-members" },
                    { new Guid("fcb3880e-acc2-45d6-89d9-596968611764"), "createcompany-companies" },
                    { new Guid("fd0a6608-dbc7-47ab-b9d9-b446ab08631a"), "createadminaccount-administrator" },
                    { new Guid("fdd480d1-21e1-4e03-b458-1c1c289d0e1e"), "motiondetection-camera" },
                    { new Guid("fe5025a4-b6b6-4b26-b421-3626ead715c3"), "updatenamedevice-home" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Password", "ProfilePhoto", "Roles", "Surname" },
                values: new object[,]
                {
                    { new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e"), new DateTime(2024, 10, 25, 16, 28, 55, 734, DateTimeKind.Local).AddTicks(37), "novakdjokovic@tennis.com", "Novak", "Djokovic@123", "djokovic.jpg", "[2,1]", "Djokovic" },
                    { new Guid("33e81783-f4fd-4a60-866c-00f3ba468156"), new DateTime(2024, 10, 25, 16, 28, 55, 734, DateTimeKind.Local).AddTicks(29), "rafaelnadal@tennis.com", "Rafael", "Nadal@123", "nadal.jpg", "[0]", "Nadal" },
                    { new Guid("656880a2-1494-43c2-925e-da38b3094a57"), new DateTime(2024, 10, 25, 16, 28, 55, 734, DateTimeKind.Local).AddTicks(34), "serenawilliams@tennis.com", "Serena", "Serena@123", "serena.jpg", "[2]", "Williams" },
                    { new Guid("80204bee-54a0-40c5-902d-f4ee20d197a7"), new DateTime(2024, 10, 25, 16, 28, 55, 734, DateTimeKind.Local).AddTicks(44), "andreagassi@tennis.com", "Andre", "Agassi@123", "agassi.jpg", "[1]", "Agassi" },
                    { new Guid("90a32d8e-de43-47b7-9968-3805cc5abf6c"), new DateTime(2024, 10, 25, 16, 28, 55, 734, DateTimeKind.Local).AddTicks(47), "petesampras@tennis.com", "Pete", "Sampras@123", "sampras.jpg", "[1]", "Sampras" },
                    { new Guid("9ec1fd2c-66b3-4009-8e14-89f54d678fe0"), new DateTime(2024, 10, 25, 16, 28, 55, 734, DateTimeKind.Local).AddTicks(5), "rogerfederer@tennis.com", "Roger", "Federer@123", "federer.jpg", "[0]", "Federer" },
                    { new Guid("a606a1bd-40eb-4e15-abea-a3d346380288"), new DateTime(2024, 10, 25, 16, 28, 55, 734, DateTimeKind.Local).AddTicks(56), "johnmcenroe@tennis.com", "John", "McEnroe@123", "mcenroe.jpg", "[2]", "McEnroe" },
                    { new Guid("cadce08d-3e77-469d-baeb-40f5c5f0fd74"), new DateTime(2024, 10, 25, 16, 28, 55, 734, DateTimeKind.Local).AddTicks(60), "billiejeanking@tennis.com", "Billie", "King@123", "king.jpg", "[0]", "Jean King" },
                    { new Guid("d3034edf-f2f2-4311-aec2-290a56dc94b7"), new DateTime(2024, 10, 25, 16, 28, 55, 734, DateTimeKind.Local).AddTicks(50), "martinanavratilova@tennis.com", "Martina", "Navratilova@123", "navratilova.jpg", "[1]", "Navratilova" },
                    { new Guid("ddc53a2e-3c1b-4615-8259-666192a1f49f"), new DateTime(2024, 10, 25, 16, 28, 55, 734, DateTimeKind.Local).AddTicks(40), "steffigraf@tennis.com", "Steffi", "Steffi@123", "graf.jpg", "[1]", "Graf" }
                });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "PermissionId", "UserId" },
                values: new object[,]
                {
                    { new Guid("06629fc9-d121-4586-bf95-21886f045df1"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") },
                    { new Guid("06629fc9-d121-4586-bf95-21886f045df1"), new Guid("656880a2-1494-43c2-925e-da38b3094a57") },
                    { new Guid("06629fc9-d121-4586-bf95-21886f045df1"), new Guid("a606a1bd-40eb-4e15-abea-a3d346380288") },
                    { new Guid("108c76c1-f352-451a-8464-269053d2d5c5"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") },
                    { new Guid("108c76c1-f352-451a-8464-269053d2d5c5"), new Guid("656880a2-1494-43c2-925e-da38b3094a57") },
                    { new Guid("108c76c1-f352-451a-8464-269053d2d5c5"), new Guid("a606a1bd-40eb-4e15-abea-a3d346380288") },
                    { new Guid("1917ea15-d762-4277-b13a-980a476b1991"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") },
                    { new Guid("1917ea15-d762-4277-b13a-980a476b1991"), new Guid("656880a2-1494-43c2-925e-da38b3094a57") },
                    { new Guid("1917ea15-d762-4277-b13a-980a476b1991"), new Guid("a606a1bd-40eb-4e15-abea-a3d346380288") },
                    { new Guid("23b162c5-7b85-44b4-be86-b46d7fa3be0b"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") },
                    { new Guid("23b162c5-7b85-44b4-be86-b46d7fa3be0b"), new Guid("80204bee-54a0-40c5-902d-f4ee20d197a7") },
                    { new Guid("23b162c5-7b85-44b4-be86-b46d7fa3be0b"), new Guid("90a32d8e-de43-47b7-9968-3805cc5abf6c") },
                    { new Guid("23b162c5-7b85-44b4-be86-b46d7fa3be0b"), new Guid("d3034edf-f2f2-4311-aec2-290a56dc94b7") },
                    { new Guid("23b162c5-7b85-44b4-be86-b46d7fa3be0b"), new Guid("ddc53a2e-3c1b-4615-8259-666192a1f49f") },
                    { new Guid("52376afd-eb8a-4bd0-9278-d0a6b1c4f164"), new Guid("33e81783-f4fd-4a60-866c-00f3ba468156") },
                    { new Guid("52376afd-eb8a-4bd0-9278-d0a6b1c4f164"), new Guid("9ec1fd2c-66b3-4009-8e14-89f54d678fe0") },
                    { new Guid("52376afd-eb8a-4bd0-9278-d0a6b1c4f164"), new Guid("cadce08d-3e77-469d-baeb-40f5c5f0fd74") },
                    { new Guid("5b6f2650-04dc-444a-a212-813a57aaea18"), new Guid("33e81783-f4fd-4a60-866c-00f3ba468156") },
                    { new Guid("5b6f2650-04dc-444a-a212-813a57aaea18"), new Guid("9ec1fd2c-66b3-4009-8e14-89f54d678fe0") },
                    { new Guid("5b6f2650-04dc-444a-a212-813a57aaea18"), new Guid("cadce08d-3e77-469d-baeb-40f5c5f0fd74") },
                    { new Guid("69e4f819-a5ca-41fd-8775-50d689506332"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") },
                    { new Guid("69e4f819-a5ca-41fd-8775-50d689506332"), new Guid("80204bee-54a0-40c5-902d-f4ee20d197a7") },
                    { new Guid("69e4f819-a5ca-41fd-8775-50d689506332"), new Guid("90a32d8e-de43-47b7-9968-3805cc5abf6c") },
                    { new Guid("69e4f819-a5ca-41fd-8775-50d689506332"), new Guid("d3034edf-f2f2-4311-aec2-290a56dc94b7") },
                    { new Guid("69e4f819-a5ca-41fd-8775-50d689506332"), new Guid("ddc53a2e-3c1b-4615-8259-666192a1f49f") },
                    { new Guid("6cebc42e-d5f8-44ca-b621-8ecc2b624e73"), new Guid("33e81783-f4fd-4a60-866c-00f3ba468156") },
                    { new Guid("6cebc42e-d5f8-44ca-b621-8ecc2b624e73"), new Guid("9ec1fd2c-66b3-4009-8e14-89f54d678fe0") },
                    { new Guid("6cebc42e-d5f8-44ca-b621-8ecc2b624e73"), new Guid("cadce08d-3e77-469d-baeb-40f5c5f0fd74") },
                    { new Guid("71dd38b8-efab-44b6-b6f7-5572db7ae8b5"), new Guid("33e81783-f4fd-4a60-866c-00f3ba468156") },
                    { new Guid("71dd38b8-efab-44b6-b6f7-5572db7ae8b5"), new Guid("9ec1fd2c-66b3-4009-8e14-89f54d678fe0") },
                    { new Guid("71dd38b8-efab-44b6-b6f7-5572db7ae8b5"), new Guid("cadce08d-3e77-469d-baeb-40f5c5f0fd74") },
                    { new Guid("77da324b-dd05-4c82-bc40-b574d43dc47c"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") },
                    { new Guid("77da324b-dd05-4c82-bc40-b574d43dc47c"), new Guid("80204bee-54a0-40c5-902d-f4ee20d197a7") },
                    { new Guid("77da324b-dd05-4c82-bc40-b574d43dc47c"), new Guid("90a32d8e-de43-47b7-9968-3805cc5abf6c") },
                    { new Guid("77da324b-dd05-4c82-bc40-b574d43dc47c"), new Guid("d3034edf-f2f2-4311-aec2-290a56dc94b7") },
                    { new Guid("77da324b-dd05-4c82-bc40-b574d43dc47c"), new Guid("ddc53a2e-3c1b-4615-8259-666192a1f49f") },
                    { new Guid("a3ff8ff2-a2e6-459f-9f9e-18642f2a5404"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") },
                    { new Guid("a3ff8ff2-a2e6-459f-9f9e-18642f2a5404"), new Guid("656880a2-1494-43c2-925e-da38b3094a57") },
                    { new Guid("a3ff8ff2-a2e6-459f-9f9e-18642f2a5404"), new Guid("a606a1bd-40eb-4e15-abea-a3d346380288") },
                    { new Guid("ac9ee154-c6c4-4765-a7dd-168d51d96526"), new Guid("33e81783-f4fd-4a60-866c-00f3ba468156") },
                    { new Guid("ac9ee154-c6c4-4765-a7dd-168d51d96526"), new Guid("9ec1fd2c-66b3-4009-8e14-89f54d678fe0") },
                    { new Guid("ac9ee154-c6c4-4765-a7dd-168d51d96526"), new Guid("cadce08d-3e77-469d-baeb-40f5c5f0fd74") },
                    { new Guid("afc68adc-941f-4ed2-bd49-8c1da98e00b3"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") },
                    { new Guid("afc68adc-941f-4ed2-bd49-8c1da98e00b3"), new Guid("80204bee-54a0-40c5-902d-f4ee20d197a7") },
                    { new Guid("afc68adc-941f-4ed2-bd49-8c1da98e00b3"), new Guid("90a32d8e-de43-47b7-9968-3805cc5abf6c") },
                    { new Guid("afc68adc-941f-4ed2-bd49-8c1da98e00b3"), new Guid("d3034edf-f2f2-4311-aec2-290a56dc94b7") },
                    { new Guid("afc68adc-941f-4ed2-bd49-8c1da98e00b3"), new Guid("ddc53a2e-3c1b-4615-8259-666192a1f49f") },
                    { new Guid("b1186ef5-6ba9-4818-b724-1cdb58f933ef"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") },
                    { new Guid("b1186ef5-6ba9-4818-b724-1cdb58f933ef"), new Guid("80204bee-54a0-40c5-902d-f4ee20d197a7") },
                    { new Guid("b1186ef5-6ba9-4818-b724-1cdb58f933ef"), new Guid("90a32d8e-de43-47b7-9968-3805cc5abf6c") },
                    { new Guid("b1186ef5-6ba9-4818-b724-1cdb58f933ef"), new Guid("d3034edf-f2f2-4311-aec2-290a56dc94b7") },
                    { new Guid("b1186ef5-6ba9-4818-b724-1cdb58f933ef"), new Guid("ddc53a2e-3c1b-4615-8259-666192a1f49f") },
                    { new Guid("ba998e50-29cc-4039-b8c7-02ccd243af26"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") },
                    { new Guid("ba998e50-29cc-4039-b8c7-02ccd243af26"), new Guid("80204bee-54a0-40c5-902d-f4ee20d197a7") },
                    { new Guid("ba998e50-29cc-4039-b8c7-02ccd243af26"), new Guid("90a32d8e-de43-47b7-9968-3805cc5abf6c") },
                    { new Guid("ba998e50-29cc-4039-b8c7-02ccd243af26"), new Guid("d3034edf-f2f2-4311-aec2-290a56dc94b7") },
                    { new Guid("ba998e50-29cc-4039-b8c7-02ccd243af26"), new Guid("ddc53a2e-3c1b-4615-8259-666192a1f49f") },
                    { new Guid("c05802c7-41da-4d94-a468-0997cfb59f0f"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") },
                    { new Guid("c05802c7-41da-4d94-a468-0997cfb59f0f"), new Guid("656880a2-1494-43c2-925e-da38b3094a57") },
                    { new Guid("c05802c7-41da-4d94-a468-0997cfb59f0f"), new Guid("a606a1bd-40eb-4e15-abea-a3d346380288") },
                    { new Guid("d15509ee-a5a9-4130-aaf0-b1e8c0ee467d"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") },
                    { new Guid("d15509ee-a5a9-4130-aaf0-b1e8c0ee467d"), new Guid("80204bee-54a0-40c5-902d-f4ee20d197a7") },
                    { new Guid("d15509ee-a5a9-4130-aaf0-b1e8c0ee467d"), new Guid("90a32d8e-de43-47b7-9968-3805cc5abf6c") },
                    { new Guid("d15509ee-a5a9-4130-aaf0-b1e8c0ee467d"), new Guid("d3034edf-f2f2-4311-aec2-290a56dc94b7") },
                    { new Guid("d15509ee-a5a9-4130-aaf0-b1e8c0ee467d"), new Guid("ddc53a2e-3c1b-4615-8259-666192a1f49f") },
                    { new Guid("e664aec4-5252-4af7-b087-121c96cc12d7"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") },
                    { new Guid("e664aec4-5252-4af7-b087-121c96cc12d7"), new Guid("80204bee-54a0-40c5-902d-f4ee20d197a7") },
                    { new Guid("e664aec4-5252-4af7-b087-121c96cc12d7"), new Guid("90a32d8e-de43-47b7-9968-3805cc5abf6c") },
                    { new Guid("e664aec4-5252-4af7-b087-121c96cc12d7"), new Guid("d3034edf-f2f2-4311-aec2-290a56dc94b7") },
                    { new Guid("e664aec4-5252-4af7-b087-121c96cc12d7"), new Guid("ddc53a2e-3c1b-4615-8259-666192a1f49f") },
                    { new Guid("fbaf28f1-30ee-4331-9b9a-8035fcabea75"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") },
                    { new Guid("fbaf28f1-30ee-4331-9b9a-8035fcabea75"), new Guid("80204bee-54a0-40c5-902d-f4ee20d197a7") },
                    { new Guid("fbaf28f1-30ee-4331-9b9a-8035fcabea75"), new Guid("90a32d8e-de43-47b7-9968-3805cc5abf6c") },
                    { new Guid("fbaf28f1-30ee-4331-9b9a-8035fcabea75"), new Guid("d3034edf-f2f2-4311-aec2-290a56dc94b7") },
                    { new Guid("fbaf28f1-30ee-4331-9b9a-8035fcabea75"), new Guid("ddc53a2e-3c1b-4615-8259-666192a1f49f") },
                    { new Guid("fcb3880e-acc2-45d6-89d9-596968611764"), new Guid("33e81783-f4fd-4a60-866c-00f3ba468156") },
                    { new Guid("fcb3880e-acc2-45d6-89d9-596968611764"), new Guid("9ec1fd2c-66b3-4009-8e14-89f54d678fe0") },
                    { new Guid("fcb3880e-acc2-45d6-89d9-596968611764"), new Guid("cadce08d-3e77-469d-baeb-40f5c5f0fd74") },
                    { new Guid("fd0a6608-dbc7-47ab-b9d9-b446ab08631a"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") },
                    { new Guid("fd0a6608-dbc7-47ab-b9d9-b446ab08631a"), new Guid("656880a2-1494-43c2-925e-da38b3094a57") },
                    { new Guid("fd0a6608-dbc7-47ab-b9d9-b446ab08631a"), new Guid("a606a1bd-40eb-4e15-abea-a3d346380288") },
                    { new Guid("fe5025a4-b6b6-4b26-b421-3626ead715c3"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") },
                    { new Guid("fe5025a4-b6b6-4b26-b421-3626ead715c3"), new Guid("80204bee-54a0-40c5-902d-f4ee20d197a7") },
                    { new Guid("fe5025a4-b6b6-4b26-b421-3626ead715c3"), new Guid("90a32d8e-de43-47b7-9968-3805cc5abf6c") },
                    { new Guid("fe5025a4-b6b6-4b26-b421-3626ead715c3"), new Guid("d3034edf-f2f2-4311-aec2-290a56dc94b7") },
                    { new Guid("fe5025a4-b6b6-4b26-b421-3626ead715c3"), new Guid("ddc53a2e-3c1b-4615-8259-666192a1f49f") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1337bdee-e195-41d4-8d30-20cc44d4db51"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("37b3241c-4ae3-4a0f-9796-b3a14a25fbca"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("51e0b49c-3590-4e30-a00d-05aca114fdbf"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5e8df53a-15b4-4caa-8306-a44d3bd143a6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("648d4378-b89d-4491-8ab6-0d49a485a1dc"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ae2462b7-ca1a-4e1e-8004-7ebc3d133149"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b7fbd728-fa3d-4727-b1cd-50a089da148a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d53ef3aa-99c4-4197-96db-a4629e688b6f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ee1ca303-029b-4ebe-a197-57c5fb38884d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fdd480d1-21e1-4e03-b458-1c1c289d0e1e"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("06629fc9-d121-4586-bf95-21886f045df1"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("06629fc9-d121-4586-bf95-21886f045df1"), new Guid("656880a2-1494-43c2-925e-da38b3094a57") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("06629fc9-d121-4586-bf95-21886f045df1"), new Guid("a606a1bd-40eb-4e15-abea-a3d346380288") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("108c76c1-f352-451a-8464-269053d2d5c5"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("108c76c1-f352-451a-8464-269053d2d5c5"), new Guid("656880a2-1494-43c2-925e-da38b3094a57") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("108c76c1-f352-451a-8464-269053d2d5c5"), new Guid("a606a1bd-40eb-4e15-abea-a3d346380288") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1917ea15-d762-4277-b13a-980a476b1991"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1917ea15-d762-4277-b13a-980a476b1991"), new Guid("656880a2-1494-43c2-925e-da38b3094a57") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1917ea15-d762-4277-b13a-980a476b1991"), new Guid("a606a1bd-40eb-4e15-abea-a3d346380288") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("23b162c5-7b85-44b4-be86-b46d7fa3be0b"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("23b162c5-7b85-44b4-be86-b46d7fa3be0b"), new Guid("80204bee-54a0-40c5-902d-f4ee20d197a7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("23b162c5-7b85-44b4-be86-b46d7fa3be0b"), new Guid("90a32d8e-de43-47b7-9968-3805cc5abf6c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("23b162c5-7b85-44b4-be86-b46d7fa3be0b"), new Guid("d3034edf-f2f2-4311-aec2-290a56dc94b7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("23b162c5-7b85-44b4-be86-b46d7fa3be0b"), new Guid("ddc53a2e-3c1b-4615-8259-666192a1f49f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("52376afd-eb8a-4bd0-9278-d0a6b1c4f164"), new Guid("33e81783-f4fd-4a60-866c-00f3ba468156") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("52376afd-eb8a-4bd0-9278-d0a6b1c4f164"), new Guid("9ec1fd2c-66b3-4009-8e14-89f54d678fe0") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("52376afd-eb8a-4bd0-9278-d0a6b1c4f164"), new Guid("cadce08d-3e77-469d-baeb-40f5c5f0fd74") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5b6f2650-04dc-444a-a212-813a57aaea18"), new Guid("33e81783-f4fd-4a60-866c-00f3ba468156") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5b6f2650-04dc-444a-a212-813a57aaea18"), new Guid("9ec1fd2c-66b3-4009-8e14-89f54d678fe0") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5b6f2650-04dc-444a-a212-813a57aaea18"), new Guid("cadce08d-3e77-469d-baeb-40f5c5f0fd74") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("69e4f819-a5ca-41fd-8775-50d689506332"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("69e4f819-a5ca-41fd-8775-50d689506332"), new Guid("80204bee-54a0-40c5-902d-f4ee20d197a7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("69e4f819-a5ca-41fd-8775-50d689506332"), new Guid("90a32d8e-de43-47b7-9968-3805cc5abf6c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("69e4f819-a5ca-41fd-8775-50d689506332"), new Guid("d3034edf-f2f2-4311-aec2-290a56dc94b7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("69e4f819-a5ca-41fd-8775-50d689506332"), new Guid("ddc53a2e-3c1b-4615-8259-666192a1f49f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6cebc42e-d5f8-44ca-b621-8ecc2b624e73"), new Guid("33e81783-f4fd-4a60-866c-00f3ba468156") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6cebc42e-d5f8-44ca-b621-8ecc2b624e73"), new Guid("9ec1fd2c-66b3-4009-8e14-89f54d678fe0") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6cebc42e-d5f8-44ca-b621-8ecc2b624e73"), new Guid("cadce08d-3e77-469d-baeb-40f5c5f0fd74") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("71dd38b8-efab-44b6-b6f7-5572db7ae8b5"), new Guid("33e81783-f4fd-4a60-866c-00f3ba468156") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("71dd38b8-efab-44b6-b6f7-5572db7ae8b5"), new Guid("9ec1fd2c-66b3-4009-8e14-89f54d678fe0") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("71dd38b8-efab-44b6-b6f7-5572db7ae8b5"), new Guid("cadce08d-3e77-469d-baeb-40f5c5f0fd74") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("77da324b-dd05-4c82-bc40-b574d43dc47c"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("77da324b-dd05-4c82-bc40-b574d43dc47c"), new Guid("80204bee-54a0-40c5-902d-f4ee20d197a7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("77da324b-dd05-4c82-bc40-b574d43dc47c"), new Guid("90a32d8e-de43-47b7-9968-3805cc5abf6c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("77da324b-dd05-4c82-bc40-b574d43dc47c"), new Guid("d3034edf-f2f2-4311-aec2-290a56dc94b7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("77da324b-dd05-4c82-bc40-b574d43dc47c"), new Guid("ddc53a2e-3c1b-4615-8259-666192a1f49f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a3ff8ff2-a2e6-459f-9f9e-18642f2a5404"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a3ff8ff2-a2e6-459f-9f9e-18642f2a5404"), new Guid("656880a2-1494-43c2-925e-da38b3094a57") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a3ff8ff2-a2e6-459f-9f9e-18642f2a5404"), new Guid("a606a1bd-40eb-4e15-abea-a3d346380288") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ac9ee154-c6c4-4765-a7dd-168d51d96526"), new Guid("33e81783-f4fd-4a60-866c-00f3ba468156") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ac9ee154-c6c4-4765-a7dd-168d51d96526"), new Guid("9ec1fd2c-66b3-4009-8e14-89f54d678fe0") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ac9ee154-c6c4-4765-a7dd-168d51d96526"), new Guid("cadce08d-3e77-469d-baeb-40f5c5f0fd74") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("afc68adc-941f-4ed2-bd49-8c1da98e00b3"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("afc68adc-941f-4ed2-bd49-8c1da98e00b3"), new Guid("80204bee-54a0-40c5-902d-f4ee20d197a7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("afc68adc-941f-4ed2-bd49-8c1da98e00b3"), new Guid("90a32d8e-de43-47b7-9968-3805cc5abf6c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("afc68adc-941f-4ed2-bd49-8c1da98e00b3"), new Guid("d3034edf-f2f2-4311-aec2-290a56dc94b7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("afc68adc-941f-4ed2-bd49-8c1da98e00b3"), new Guid("ddc53a2e-3c1b-4615-8259-666192a1f49f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b1186ef5-6ba9-4818-b724-1cdb58f933ef"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b1186ef5-6ba9-4818-b724-1cdb58f933ef"), new Guid("80204bee-54a0-40c5-902d-f4ee20d197a7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b1186ef5-6ba9-4818-b724-1cdb58f933ef"), new Guid("90a32d8e-de43-47b7-9968-3805cc5abf6c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b1186ef5-6ba9-4818-b724-1cdb58f933ef"), new Guid("d3034edf-f2f2-4311-aec2-290a56dc94b7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b1186ef5-6ba9-4818-b724-1cdb58f933ef"), new Guid("ddc53a2e-3c1b-4615-8259-666192a1f49f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ba998e50-29cc-4039-b8c7-02ccd243af26"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ba998e50-29cc-4039-b8c7-02ccd243af26"), new Guid("80204bee-54a0-40c5-902d-f4ee20d197a7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ba998e50-29cc-4039-b8c7-02ccd243af26"), new Guid("90a32d8e-de43-47b7-9968-3805cc5abf6c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ba998e50-29cc-4039-b8c7-02ccd243af26"), new Guid("d3034edf-f2f2-4311-aec2-290a56dc94b7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ba998e50-29cc-4039-b8c7-02ccd243af26"), new Guid("ddc53a2e-3c1b-4615-8259-666192a1f49f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c05802c7-41da-4d94-a468-0997cfb59f0f"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c05802c7-41da-4d94-a468-0997cfb59f0f"), new Guid("656880a2-1494-43c2-925e-da38b3094a57") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c05802c7-41da-4d94-a468-0997cfb59f0f"), new Guid("a606a1bd-40eb-4e15-abea-a3d346380288") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d15509ee-a5a9-4130-aaf0-b1e8c0ee467d"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d15509ee-a5a9-4130-aaf0-b1e8c0ee467d"), new Guid("80204bee-54a0-40c5-902d-f4ee20d197a7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d15509ee-a5a9-4130-aaf0-b1e8c0ee467d"), new Guid("90a32d8e-de43-47b7-9968-3805cc5abf6c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d15509ee-a5a9-4130-aaf0-b1e8c0ee467d"), new Guid("d3034edf-f2f2-4311-aec2-290a56dc94b7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d15509ee-a5a9-4130-aaf0-b1e8c0ee467d"), new Guid("ddc53a2e-3c1b-4615-8259-666192a1f49f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e664aec4-5252-4af7-b087-121c96cc12d7"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e664aec4-5252-4af7-b087-121c96cc12d7"), new Guid("80204bee-54a0-40c5-902d-f4ee20d197a7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e664aec4-5252-4af7-b087-121c96cc12d7"), new Guid("90a32d8e-de43-47b7-9968-3805cc5abf6c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e664aec4-5252-4af7-b087-121c96cc12d7"), new Guid("d3034edf-f2f2-4311-aec2-290a56dc94b7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e664aec4-5252-4af7-b087-121c96cc12d7"), new Guid("ddc53a2e-3c1b-4615-8259-666192a1f49f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fbaf28f1-30ee-4331-9b9a-8035fcabea75"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fbaf28f1-30ee-4331-9b9a-8035fcabea75"), new Guid("80204bee-54a0-40c5-902d-f4ee20d197a7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fbaf28f1-30ee-4331-9b9a-8035fcabea75"), new Guid("90a32d8e-de43-47b7-9968-3805cc5abf6c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fbaf28f1-30ee-4331-9b9a-8035fcabea75"), new Guid("d3034edf-f2f2-4311-aec2-290a56dc94b7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fbaf28f1-30ee-4331-9b9a-8035fcabea75"), new Guid("ddc53a2e-3c1b-4615-8259-666192a1f49f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fcb3880e-acc2-45d6-89d9-596968611764"), new Guid("33e81783-f4fd-4a60-866c-00f3ba468156") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fcb3880e-acc2-45d6-89d9-596968611764"), new Guid("9ec1fd2c-66b3-4009-8e14-89f54d678fe0") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fcb3880e-acc2-45d6-89d9-596968611764"), new Guid("cadce08d-3e77-469d-baeb-40f5c5f0fd74") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fd0a6608-dbc7-47ab-b9d9-b446ab08631a"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fd0a6608-dbc7-47ab-b9d9-b446ab08631a"), new Guid("656880a2-1494-43c2-925e-da38b3094a57") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fd0a6608-dbc7-47ab-b9d9-b446ab08631a"), new Guid("a606a1bd-40eb-4e15-abea-a3d346380288") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fe5025a4-b6b6-4b26-b421-3626ead715c3"), new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fe5025a4-b6b6-4b26-b421-3626ead715c3"), new Guid("80204bee-54a0-40c5-902d-f4ee20d197a7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fe5025a4-b6b6-4b26-b421-3626ead715c3"), new Guid("90a32d8e-de43-47b7-9968-3805cc5abf6c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fe5025a4-b6b6-4b26-b421-3626ead715c3"), new Guid("d3034edf-f2f2-4311-aec2-290a56dc94b7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fe5025a4-b6b6-4b26-b421-3626ead715c3"), new Guid("ddc53a2e-3c1b-4615-8259-666192a1f49f") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("06629fc9-d121-4586-bf95-21886f045df1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("108c76c1-f352-451a-8464-269053d2d5c5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1917ea15-d762-4277-b13a-980a476b1991"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("23b162c5-7b85-44b4-be86-b46d7fa3be0b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("52376afd-eb8a-4bd0-9278-d0a6b1c4f164"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5b6f2650-04dc-444a-a212-813a57aaea18"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("69e4f819-a5ca-41fd-8775-50d689506332"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6cebc42e-d5f8-44ca-b621-8ecc2b624e73"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("71dd38b8-efab-44b6-b6f7-5572db7ae8b5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("77da324b-dd05-4c82-bc40-b574d43dc47c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a3ff8ff2-a2e6-459f-9f9e-18642f2a5404"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ac9ee154-c6c4-4765-a7dd-168d51d96526"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("afc68adc-941f-4ed2-bd49-8c1da98e00b3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b1186ef5-6ba9-4818-b724-1cdb58f933ef"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ba998e50-29cc-4039-b8c7-02ccd243af26"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c05802c7-41da-4d94-a468-0997cfb59f0f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d15509ee-a5a9-4130-aaf0-b1e8c0ee467d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e664aec4-5252-4af7-b087-121c96cc12d7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fbaf28f1-30ee-4331-9b9a-8035fcabea75"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fcb3880e-acc2-45d6-89d9-596968611764"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fd0a6608-dbc7-47ab-b9d9-b446ab08631a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fe5025a4-b6b6-4b26-b421-3626ead715c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e464fa4-3454-40eb-b1a3-24bec6b2a90e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33e81783-f4fd-4a60-866c-00f3ba468156"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("656880a2-1494-43c2-925e-da38b3094a57"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80204bee-54a0-40c5-902d-f4ee20d197a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("90a32d8e-de43-47b7-9968-3805cc5abf6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ec1fd2c-66b3-4009-8e14-89f54d678fe0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a606a1bd-40eb-4e15-abea-a3d346380288"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cadce08d-3e77-469d-baeb-40f5c5f0fd74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3034edf-f2f2-4311-aec2-290a56dc94b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ddc53a2e-3c1b-4615-8259-666192a1f49f"));

            migrationBuilder.DropColumn(
                name: "Rooms",
                table: "Homes");

            migrationBuilder.DropColumn(
                name: "Room",
                table: "Hardwares");

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0030e40c-c138-4a19-9181-77c96a700b3e"), "motiondetection-camera" },
                    { new Guid("008e8016-3edc-4439-9036-5aea63a622f3"), "getmembers-members" },
                    { new Guid("03c54dd2-7534-4c0d-97b7-d86a3f75bf76"), "createcompanyowneraccount-companyowner" },
                    { new Guid("092746b5-edaf-43a1-b543-a3f16e93626e"), "addmotionsensor-motionsensor" },
                    { new Guid("119b959b-5643-45a2-9a6d-8f6606f61df0"), "createadminaccount-administrator" },
                    { new Guid("16372418-2534-4e27-bd7f-6a7288f7cfb2"), "close-windowsensor" },
                    { new Guid("1d95fbcf-d6a4-4186-97a4-cd9e7e340b0f"), "addpermission-members" },
                    { new Guid("1f37e047-599b-485c-b1e1-d8cdaa695232"), "getdevices-home" },
                    { new Guid("32f9293e-087c-42f5-9e9b-258bc8216ce4"), "addcamera-camera" },
                    { new Guid("3442bc30-8d88-4c6e-9fcb-86cb231082fd"), "on-smartlamp" },
                    { new Guid("39a3c9f2-2c34-4a45-bf57-98f980fa7a80"), "getcompany-companies" },
                    { new Guid("3c69a52c-0a45-4da1-9898-94f3b8d7220e"), "addsmartlamp-smartlamp" },
                    { new Guid("546b7c89-7413-43a5-96c9-5e1071992947"), "getdevices-devices" },
                    { new Guid("561b4d2e-f9cd-42d3-8407-48d8d693ee57"), "adddevice-home" },
                    { new Guid("5fbf9614-8c44-412b-9693-df32e6e44723"), "newhome-home" },
                    { new Guid("63155c52-d5ad-4ef9-9935-8b7365b90385"), "persondetection-camera" },
                    { new Guid("6822f66a-0e21-4cd4-9265-9419b990a75a"), "addnotificationmembers-members" },
                    { new Guid("706c3caf-499f-44b9-92a8-ef0af92f8005"), "gethomes-user" },
                    { new Guid("7108ebdc-d8ae-4705-9e30-670bddfea383"), "addmember-members" },
                    { new Guid("8357b55d-20b3-4566-a41d-4f6957549702"), "deleteadminaccount-administrator" },
                    { new Guid("9aaeefff-83bd-4342-8982-aece678c5a6a"), "open-windowsensor" },
                    { new Guid("a684fb37-aee7-4157-8304-b6626d8dba30"), "motiondetection-motionsensor" },
                    { new Guid("b0ecbadc-e38e-43ca-b064-892ed2790e26"), "addsensor-windowsensor" },
                    { new Guid("b88f20ec-d886-4af0-885c-5d78aeb24373"), "addhomeownerpermission-homeowner" },
                    { new Guid("c558e4ba-5d99-4bc9-b55e-c82c53792253"), "getaccounts-accounts" },
                    { new Guid("cedf65fa-1f00-430f-bdeb-059b476f29af"), "off-smartlamp" },
                    { new Guid("d876adf4-2d7c-424a-9e54-48ee8a4d4b07"), "getdevicetypes-devicetype" },
                    { new Guid("d8be9808-734d-40a6-a377-a27f56c1eecb"), "addhomeownerpermission-homeowner" },
                    { new Guid("e43a5938-6ed2-4967-a5d0-52e7ae2b6252"), "createcompany-companies" },
                    { new Guid("eb51f52e-83a4-4b67-98ef-499b43d64ca0"), "getnotifications-notification" },
                    { new Guid("f4ee80cf-83e7-4d51-8212-4c252936d0e8"), "updatenamedevice-home" },
                    { new Guid("f6f6a3cd-ac08-4f82-ac3d-3f77cd1eb0a0"), "addmotionsensor-motionsensor" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Password", "ProfilePhoto", "Roles", "Surname" },
                values: new object[,]
                {
                    { new Guid("027743d7-bc4f-4c5d-b1e4-331114e797ee"), new DateTime(2024, 10, 25, 15, 5, 17, 32, DateTimeKind.Local).AddTicks(6686), "rafaelnadal@tennis.com", "Rafael", "Nadal@123", "nadal.jpg", "[0]", "Nadal" },
                    { new Guid("29cd95bc-9090-463c-817a-c471fbb5a525"), new DateTime(2024, 10, 25, 15, 5, 17, 32, DateTimeKind.Local).AddTicks(6690), "serenawilliams@tennis.com", "Serena", "Serena@123", "serena.jpg", "[2]", "Williams" },
                    { new Guid("5cfb46e7-eef0-48d7-9fc7-3b0463f5737e"), new DateTime(2024, 10, 25, 15, 5, 17, 32, DateTimeKind.Local).AddTicks(6710), "martinanavratilova@tennis.com", "Martina", "Navratilova@123", "navratilova.jpg", "[1]", "Navratilova" },
                    { new Guid("74739b4e-3170-4fb5-b9d0-5925342529e4"), new DateTime(2024, 10, 25, 15, 5, 17, 32, DateTimeKind.Local).AddTicks(6706), "petesampras@tennis.com", "Pete", "Sampras@123", "sampras.jpg", "[1]", "Sampras" },
                    { new Guid("8776c602-600e-4750-a501-7e7557165ece"), new DateTime(2024, 10, 25, 15, 5, 17, 32, DateTimeKind.Local).AddTicks(6694), "novakdjokovic@tennis.com", "Novak", "Djokovic@123", "djokovic.jpg", "[2,1]", "Djokovic" },
                    { new Guid("98b52fce-f8e4-431c-88b0-8c7e136dbfc5"), new DateTime(2024, 10, 25, 15, 5, 17, 32, DateTimeKind.Local).AddTicks(6697), "steffigraf@tennis.com", "Steffi", "Steffi@123", "graf.jpg", "[1]", "Graf" },
                    { new Guid("ce3741c4-894e-4248-a025-f8224ca21f3c"), new DateTime(2024, 10, 25, 15, 5, 17, 32, DateTimeKind.Local).AddTicks(6713), "johnmcenroe@tennis.com", "John", "McEnroe@123", "mcenroe.jpg", "[2]", "McEnroe" },
                    { new Guid("dcef6f39-62af-43f2-b358-14b40d5077be"), new DateTime(2024, 10, 25, 15, 5, 17, 32, DateTimeKind.Local).AddTicks(6719), "billiejeanking@tennis.com", "Billie", "King@123", "king.jpg", "[0]", "Jean King" },
                    { new Guid("e091684d-d6cf-4be9-bcf9-5cff1cb108a3"), new DateTime(2024, 10, 25, 15, 5, 17, 32, DateTimeKind.Local).AddTicks(6659), "rogerfederer@tennis.com", "Roger", "Federer@123", "federer.jpg", "[0]", "Federer" },
                    { new Guid("e85e659a-9be8-4d12-bbee-3bc9214853f8"), new DateTime(2024, 10, 25, 15, 5, 17, 32, DateTimeKind.Local).AddTicks(6702), "andreagassi@tennis.com", "Andre", "Agassi@123", "agassi.jpg", "[1]", "Agassi" }
                });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "PermissionId", "UserId" },
                values: new object[,]
                {
                    { new Guid("008e8016-3edc-4439-9036-5aea63a622f3"), new Guid("5cfb46e7-eef0-48d7-9fc7-3b0463f5737e") },
                    { new Guid("008e8016-3edc-4439-9036-5aea63a622f3"), new Guid("74739b4e-3170-4fb5-b9d0-5925342529e4") },
                    { new Guid("008e8016-3edc-4439-9036-5aea63a622f3"), new Guid("8776c602-600e-4750-a501-7e7557165ece") },
                    { new Guid("008e8016-3edc-4439-9036-5aea63a622f3"), new Guid("98b52fce-f8e4-431c-88b0-8c7e136dbfc5") },
                    { new Guid("008e8016-3edc-4439-9036-5aea63a622f3"), new Guid("e85e659a-9be8-4d12-bbee-3bc9214853f8") },
                    { new Guid("03c54dd2-7534-4c0d-97b7-d86a3f75bf76"), new Guid("29cd95bc-9090-463c-817a-c471fbb5a525") },
                    { new Guid("03c54dd2-7534-4c0d-97b7-d86a3f75bf76"), new Guid("8776c602-600e-4750-a501-7e7557165ece") },
                    { new Guid("03c54dd2-7534-4c0d-97b7-d86a3f75bf76"), new Guid("ce3741c4-894e-4248-a025-f8224ca21f3c") },
                    { new Guid("092746b5-edaf-43a1-b543-a3f16e93626e"), new Guid("027743d7-bc4f-4c5d-b1e4-331114e797ee") },
                    { new Guid("092746b5-edaf-43a1-b543-a3f16e93626e"), new Guid("dcef6f39-62af-43f2-b358-14b40d5077be") },
                    { new Guid("092746b5-edaf-43a1-b543-a3f16e93626e"), new Guid("e091684d-d6cf-4be9-bcf9-5cff1cb108a3") },
                    { new Guid("119b959b-5643-45a2-9a6d-8f6606f61df0"), new Guid("29cd95bc-9090-463c-817a-c471fbb5a525") },
                    { new Guid("119b959b-5643-45a2-9a6d-8f6606f61df0"), new Guid("8776c602-600e-4750-a501-7e7557165ece") },
                    { new Guid("119b959b-5643-45a2-9a6d-8f6606f61df0"), new Guid("ce3741c4-894e-4248-a025-f8224ca21f3c") },
                    { new Guid("1d95fbcf-d6a4-4186-97a4-cd9e7e340b0f"), new Guid("5cfb46e7-eef0-48d7-9fc7-3b0463f5737e") },
                    { new Guid("1d95fbcf-d6a4-4186-97a4-cd9e7e340b0f"), new Guid("74739b4e-3170-4fb5-b9d0-5925342529e4") },
                    { new Guid("1d95fbcf-d6a4-4186-97a4-cd9e7e340b0f"), new Guid("8776c602-600e-4750-a501-7e7557165ece") },
                    { new Guid("1d95fbcf-d6a4-4186-97a4-cd9e7e340b0f"), new Guid("98b52fce-f8e4-431c-88b0-8c7e136dbfc5") },
                    { new Guid("1d95fbcf-d6a4-4186-97a4-cd9e7e340b0f"), new Guid("e85e659a-9be8-4d12-bbee-3bc9214853f8") },
                    { new Guid("1f37e047-599b-485c-b1e1-d8cdaa695232"), new Guid("5cfb46e7-eef0-48d7-9fc7-3b0463f5737e") },
                    { new Guid("1f37e047-599b-485c-b1e1-d8cdaa695232"), new Guid("74739b4e-3170-4fb5-b9d0-5925342529e4") },
                    { new Guid("1f37e047-599b-485c-b1e1-d8cdaa695232"), new Guid("8776c602-600e-4750-a501-7e7557165ece") },
                    { new Guid("1f37e047-599b-485c-b1e1-d8cdaa695232"), new Guid("98b52fce-f8e4-431c-88b0-8c7e136dbfc5") },
                    { new Guid("1f37e047-599b-485c-b1e1-d8cdaa695232"), new Guid("e85e659a-9be8-4d12-bbee-3bc9214853f8") },
                    { new Guid("32f9293e-087c-42f5-9e9b-258bc8216ce4"), new Guid("027743d7-bc4f-4c5d-b1e4-331114e797ee") },
                    { new Guid("32f9293e-087c-42f5-9e9b-258bc8216ce4"), new Guid("dcef6f39-62af-43f2-b358-14b40d5077be") },
                    { new Guid("32f9293e-087c-42f5-9e9b-258bc8216ce4"), new Guid("e091684d-d6cf-4be9-bcf9-5cff1cb108a3") },
                    { new Guid("39a3c9f2-2c34-4a45-bf57-98f980fa7a80"), new Guid("29cd95bc-9090-463c-817a-c471fbb5a525") },
                    { new Guid("39a3c9f2-2c34-4a45-bf57-98f980fa7a80"), new Guid("8776c602-600e-4750-a501-7e7557165ece") },
                    { new Guid("39a3c9f2-2c34-4a45-bf57-98f980fa7a80"), new Guid("ce3741c4-894e-4248-a025-f8224ca21f3c") },
                    { new Guid("3c69a52c-0a45-4da1-9898-94f3b8d7220e"), new Guid("027743d7-bc4f-4c5d-b1e4-331114e797ee") },
                    { new Guid("3c69a52c-0a45-4da1-9898-94f3b8d7220e"), new Guid("dcef6f39-62af-43f2-b358-14b40d5077be") },
                    { new Guid("3c69a52c-0a45-4da1-9898-94f3b8d7220e"), new Guid("e091684d-d6cf-4be9-bcf9-5cff1cb108a3") },
                    { new Guid("561b4d2e-f9cd-42d3-8407-48d8d693ee57"), new Guid("5cfb46e7-eef0-48d7-9fc7-3b0463f5737e") },
                    { new Guid("561b4d2e-f9cd-42d3-8407-48d8d693ee57"), new Guid("74739b4e-3170-4fb5-b9d0-5925342529e4") },
                    { new Guid("561b4d2e-f9cd-42d3-8407-48d8d693ee57"), new Guid("8776c602-600e-4750-a501-7e7557165ece") },
                    { new Guid("561b4d2e-f9cd-42d3-8407-48d8d693ee57"), new Guid("98b52fce-f8e4-431c-88b0-8c7e136dbfc5") },
                    { new Guid("561b4d2e-f9cd-42d3-8407-48d8d693ee57"), new Guid("e85e659a-9be8-4d12-bbee-3bc9214853f8") },
                    { new Guid("5fbf9614-8c44-412b-9693-df32e6e44723"), new Guid("5cfb46e7-eef0-48d7-9fc7-3b0463f5737e") },
                    { new Guid("5fbf9614-8c44-412b-9693-df32e6e44723"), new Guid("74739b4e-3170-4fb5-b9d0-5925342529e4") },
                    { new Guid("5fbf9614-8c44-412b-9693-df32e6e44723"), new Guid("8776c602-600e-4750-a501-7e7557165ece") },
                    { new Guid("5fbf9614-8c44-412b-9693-df32e6e44723"), new Guid("98b52fce-f8e4-431c-88b0-8c7e136dbfc5") },
                    { new Guid("5fbf9614-8c44-412b-9693-df32e6e44723"), new Guid("e85e659a-9be8-4d12-bbee-3bc9214853f8") },
                    { new Guid("6822f66a-0e21-4cd4-9265-9419b990a75a"), new Guid("5cfb46e7-eef0-48d7-9fc7-3b0463f5737e") },
                    { new Guid("6822f66a-0e21-4cd4-9265-9419b990a75a"), new Guid("74739b4e-3170-4fb5-b9d0-5925342529e4") },
                    { new Guid("6822f66a-0e21-4cd4-9265-9419b990a75a"), new Guid("8776c602-600e-4750-a501-7e7557165ece") },
                    { new Guid("6822f66a-0e21-4cd4-9265-9419b990a75a"), new Guid("98b52fce-f8e4-431c-88b0-8c7e136dbfc5") },
                    { new Guid("6822f66a-0e21-4cd4-9265-9419b990a75a"), new Guid("e85e659a-9be8-4d12-bbee-3bc9214853f8") },
                    { new Guid("706c3caf-499f-44b9-92a8-ef0af92f8005"), new Guid("5cfb46e7-eef0-48d7-9fc7-3b0463f5737e") },
                    { new Guid("706c3caf-499f-44b9-92a8-ef0af92f8005"), new Guid("74739b4e-3170-4fb5-b9d0-5925342529e4") },
                    { new Guid("706c3caf-499f-44b9-92a8-ef0af92f8005"), new Guid("8776c602-600e-4750-a501-7e7557165ece") },
                    { new Guid("706c3caf-499f-44b9-92a8-ef0af92f8005"), new Guid("98b52fce-f8e4-431c-88b0-8c7e136dbfc5") },
                    { new Guid("706c3caf-499f-44b9-92a8-ef0af92f8005"), new Guid("e85e659a-9be8-4d12-bbee-3bc9214853f8") },
                    { new Guid("7108ebdc-d8ae-4705-9e30-670bddfea383"), new Guid("5cfb46e7-eef0-48d7-9fc7-3b0463f5737e") },
                    { new Guid("7108ebdc-d8ae-4705-9e30-670bddfea383"), new Guid("74739b4e-3170-4fb5-b9d0-5925342529e4") },
                    { new Guid("7108ebdc-d8ae-4705-9e30-670bddfea383"), new Guid("8776c602-600e-4750-a501-7e7557165ece") },
                    { new Guid("7108ebdc-d8ae-4705-9e30-670bddfea383"), new Guid("98b52fce-f8e4-431c-88b0-8c7e136dbfc5") },
                    { new Guid("7108ebdc-d8ae-4705-9e30-670bddfea383"), new Guid("e85e659a-9be8-4d12-bbee-3bc9214853f8") },
                    { new Guid("8357b55d-20b3-4566-a41d-4f6957549702"), new Guid("29cd95bc-9090-463c-817a-c471fbb5a525") },
                    { new Guid("8357b55d-20b3-4566-a41d-4f6957549702"), new Guid("8776c602-600e-4750-a501-7e7557165ece") },
                    { new Guid("8357b55d-20b3-4566-a41d-4f6957549702"), new Guid("ce3741c4-894e-4248-a025-f8224ca21f3c") },
                    { new Guid("b0ecbadc-e38e-43ca-b064-892ed2790e26"), new Guid("027743d7-bc4f-4c5d-b1e4-331114e797ee") },
                    { new Guid("b0ecbadc-e38e-43ca-b064-892ed2790e26"), new Guid("dcef6f39-62af-43f2-b358-14b40d5077be") },
                    { new Guid("b0ecbadc-e38e-43ca-b064-892ed2790e26"), new Guid("e091684d-d6cf-4be9-bcf9-5cff1cb108a3") },
                    { new Guid("b88f20ec-d886-4af0-885c-5d78aeb24373"), new Guid("027743d7-bc4f-4c5d-b1e4-331114e797ee") },
                    { new Guid("b88f20ec-d886-4af0-885c-5d78aeb24373"), new Guid("dcef6f39-62af-43f2-b358-14b40d5077be") },
                    { new Guid("b88f20ec-d886-4af0-885c-5d78aeb24373"), new Guid("e091684d-d6cf-4be9-bcf9-5cff1cb108a3") },
                    { new Guid("c558e4ba-5d99-4bc9-b55e-c82c53792253"), new Guid("29cd95bc-9090-463c-817a-c471fbb5a525") },
                    { new Guid("c558e4ba-5d99-4bc9-b55e-c82c53792253"), new Guid("8776c602-600e-4750-a501-7e7557165ece") },
                    { new Guid("c558e4ba-5d99-4bc9-b55e-c82c53792253"), new Guid("ce3741c4-894e-4248-a025-f8224ca21f3c") },
                    { new Guid("d8be9808-734d-40a6-a377-a27f56c1eecb"), new Guid("29cd95bc-9090-463c-817a-c471fbb5a525") },
                    { new Guid("d8be9808-734d-40a6-a377-a27f56c1eecb"), new Guid("8776c602-600e-4750-a501-7e7557165ece") },
                    { new Guid("d8be9808-734d-40a6-a377-a27f56c1eecb"), new Guid("ce3741c4-894e-4248-a025-f8224ca21f3c") },
                    { new Guid("e43a5938-6ed2-4967-a5d0-52e7ae2b6252"), new Guid("027743d7-bc4f-4c5d-b1e4-331114e797ee") },
                    { new Guid("e43a5938-6ed2-4967-a5d0-52e7ae2b6252"), new Guid("dcef6f39-62af-43f2-b358-14b40d5077be") },
                    { new Guid("e43a5938-6ed2-4967-a5d0-52e7ae2b6252"), new Guid("e091684d-d6cf-4be9-bcf9-5cff1cb108a3") },
                    { new Guid("f4ee80cf-83e7-4d51-8212-4c252936d0e8"), new Guid("5cfb46e7-eef0-48d7-9fc7-3b0463f5737e") },
                    { new Guid("f4ee80cf-83e7-4d51-8212-4c252936d0e8"), new Guid("74739b4e-3170-4fb5-b9d0-5925342529e4") },
                    { new Guid("f4ee80cf-83e7-4d51-8212-4c252936d0e8"), new Guid("8776c602-600e-4750-a501-7e7557165ece") },
                    { new Guid("f4ee80cf-83e7-4d51-8212-4c252936d0e8"), new Guid("98b52fce-f8e4-431c-88b0-8c7e136dbfc5") },
                    { new Guid("f4ee80cf-83e7-4d51-8212-4c252936d0e8"), new Guid("e85e659a-9be8-4d12-bbee-3bc9214853f8") },
                    { new Guid("f6f6a3cd-ac08-4f82-ac3d-3f77cd1eb0a0"), new Guid("5cfb46e7-eef0-48d7-9fc7-3b0463f5737e") },
                    { new Guid("f6f6a3cd-ac08-4f82-ac3d-3f77cd1eb0a0"), new Guid("74739b4e-3170-4fb5-b9d0-5925342529e4") },
                    { new Guid("f6f6a3cd-ac08-4f82-ac3d-3f77cd1eb0a0"), new Guid("8776c602-600e-4750-a501-7e7557165ece") },
                    { new Guid("f6f6a3cd-ac08-4f82-ac3d-3f77cd1eb0a0"), new Guid("98b52fce-f8e4-431c-88b0-8c7e136dbfc5") },
                    { new Guid("f6f6a3cd-ac08-4f82-ac3d-3f77cd1eb0a0"), new Guid("e85e659a-9be8-4d12-bbee-3bc9214853f8") }
                });
        }
    }
}
