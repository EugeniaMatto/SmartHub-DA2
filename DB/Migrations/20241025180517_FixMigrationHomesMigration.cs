using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHub.DB.Migrations
{
    /// <inheritdoc />
    public partial class FixMigrationHomesMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
