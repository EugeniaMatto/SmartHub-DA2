using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHub.DB.Migrations
{
    /// <inheritdoc />
    public partial class HomeOwnerPermissionUpdateMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("037c66d9-1471-4535-b52b-3a81ec3df990"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("037c66d9-1471-4535-b52b-3a81ec3df990"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("037c66d9-1471-4535-b52b-3a81ec3df990"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("037c66d9-1471-4535-b52b-3a81ec3df990"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("037c66d9-1471-4535-b52b-3a81ec3df990"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("07ef5066-f870-4e1a-aa5b-f3d52d2fa76b"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("07ef5066-f870-4e1a-aa5b-f3d52d2fa76b"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("07ef5066-f870-4e1a-aa5b-f3d52d2fa76b"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("07ef5066-f870-4e1a-aa5b-f3d52d2fa76b"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("07ef5066-f870-4e1a-aa5b-f3d52d2fa76b"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0c9ae47f-33b7-4101-a436-949b142418c7"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0c9ae47f-33b7-4101-a436-949b142418c7"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0c9ae47f-33b7-4101-a436-949b142418c7"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0c9ae47f-33b7-4101-a436-949b142418c7"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0c9ae47f-33b7-4101-a436-949b142418c7"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0c9ae47f-33b7-4101-a436-949b142418c7"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0c9ae47f-33b7-4101-a436-949b142418c7"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0c9ae47f-33b7-4101-a436-949b142418c7"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0c9ae47f-33b7-4101-a436-949b142418c7"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0c9ae47f-33b7-4101-a436-949b142418c7"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d84da76-acc1-4b2f-9a04-32168f348427"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d84da76-acc1-4b2f-9a04-32168f348427"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d84da76-acc1-4b2f-9a04-32168f348427"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d84da76-acc1-4b2f-9a04-32168f348427"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d84da76-acc1-4b2f-9a04-32168f348427"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d84da76-acc1-4b2f-9a04-32168f348427"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d84da76-acc1-4b2f-9a04-32168f348427"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d84da76-acc1-4b2f-9a04-32168f348427"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d84da76-acc1-4b2f-9a04-32168f348427"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d84da76-acc1-4b2f-9a04-32168f348427"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("11bf9897-1b7d-4875-a640-abb5521b90a3"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("11bf9897-1b7d-4875-a640-abb5521b90a3"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("11bf9897-1b7d-4875-a640-abb5521b90a3"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("11bf9897-1b7d-4875-a640-abb5521b90a3"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("11bf9897-1b7d-4875-a640-abb5521b90a3"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("12e9b8b5-b5b1-4cd9-bad2-bb994096e15b"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("12e9b8b5-b5b1-4cd9-bad2-bb994096e15b"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("12e9b8b5-b5b1-4cd9-bad2-bb994096e15b"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("12e9b8b5-b5b1-4cd9-bad2-bb994096e15b"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("12e9b8b5-b5b1-4cd9-bad2-bb994096e15b"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("12e9b8b5-b5b1-4cd9-bad2-bb994096e15b"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("12e9b8b5-b5b1-4cd9-bad2-bb994096e15b"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("12e9b8b5-b5b1-4cd9-bad2-bb994096e15b"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("12e9b8b5-b5b1-4cd9-bad2-bb994096e15b"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("12e9b8b5-b5b1-4cd9-bad2-bb994096e15b"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18c13610-ff61-4323-93f3-abfc838dfc63"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18c13610-ff61-4323-93f3-abfc838dfc63"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18c13610-ff61-4323-93f3-abfc838dfc63"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18c13610-ff61-4323-93f3-abfc838dfc63"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18c13610-ff61-4323-93f3-abfc838dfc63"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18c13610-ff61-4323-93f3-abfc838dfc63"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18c13610-ff61-4323-93f3-abfc838dfc63"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18c13610-ff61-4323-93f3-abfc838dfc63"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18c13610-ff61-4323-93f3-abfc838dfc63"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18c13610-ff61-4323-93f3-abfc838dfc63"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1a69363c-2814-4173-ac8c-252f94e16982"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1a69363c-2814-4173-ac8c-252f94e16982"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1a69363c-2814-4173-ac8c-252f94e16982"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1a69363c-2814-4173-ac8c-252f94e16982"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1a69363c-2814-4173-ac8c-252f94e16982"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1a69363c-2814-4173-ac8c-252f94e16982"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1a69363c-2814-4173-ac8c-252f94e16982"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1a69363c-2814-4173-ac8c-252f94e16982"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1a69363c-2814-4173-ac8c-252f94e16982"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1a69363c-2814-4173-ac8c-252f94e16982"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1f40e8c4-c109-412d-9cbf-177ff1806026"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1f40e8c4-c109-412d-9cbf-177ff1806026"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1f40e8c4-c109-412d-9cbf-177ff1806026"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("22df0f5c-382b-4d40-8ca6-441893ce4d7b"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("22df0f5c-382b-4d40-8ca6-441893ce4d7b"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("22df0f5c-382b-4d40-8ca6-441893ce4d7b"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("24249199-c042-4f04-9620-48455cbb0129"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("24249199-c042-4f04-9620-48455cbb0129"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("24249199-c042-4f04-9620-48455cbb0129"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("24249199-c042-4f04-9620-48455cbb0129"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("24249199-c042-4f04-9620-48455cbb0129"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("24249199-c042-4f04-9620-48455cbb0129"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("24249199-c042-4f04-9620-48455cbb0129"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("24249199-c042-4f04-9620-48455cbb0129"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("24249199-c042-4f04-9620-48455cbb0129"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("24249199-c042-4f04-9620-48455cbb0129"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("28ef49a4-aa49-4e39-a8b4-7ebf11af1bd4"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("28ef49a4-aa49-4e39-a8b4-7ebf11af1bd4"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("28ef49a4-aa49-4e39-a8b4-7ebf11af1bd4"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("28ef49a4-aa49-4e39-a8b4-7ebf11af1bd4"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("28ef49a4-aa49-4e39-a8b4-7ebf11af1bd4"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3133b598-55ee-4d36-95ee-8dc6260a6a0a"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3133b598-55ee-4d36-95ee-8dc6260a6a0a"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3133b598-55ee-4d36-95ee-8dc6260a6a0a"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("39bfe67b-c017-4a19-b482-87dd82bf9727"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("39bfe67b-c017-4a19-b482-87dd82bf9727"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("39bfe67b-c017-4a19-b482-87dd82bf9727"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("43a53e05-b748-4aac-af09-4fe46f3b953f"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("43a53e05-b748-4aac-af09-4fe46f3b953f"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("43a53e05-b748-4aac-af09-4fe46f3b953f"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("43a53e05-b748-4aac-af09-4fe46f3b953f"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("43a53e05-b748-4aac-af09-4fe46f3b953f"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("43a53e05-b748-4aac-af09-4fe46f3b953f"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("43a53e05-b748-4aac-af09-4fe46f3b953f"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("43a53e05-b748-4aac-af09-4fe46f3b953f"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("43a53e05-b748-4aac-af09-4fe46f3b953f"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("43a53e05-b748-4aac-af09-4fe46f3b953f"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("48a6d683-cb3c-4b2d-bd70-615b2acf6a42"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("48a6d683-cb3c-4b2d-bd70-615b2acf6a42"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("48a6d683-cb3c-4b2d-bd70-615b2acf6a42"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("48a6d683-cb3c-4b2d-bd70-615b2acf6a42"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("48a6d683-cb3c-4b2d-bd70-615b2acf6a42"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("48a6d683-cb3c-4b2d-bd70-615b2acf6a42"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("48a6d683-cb3c-4b2d-bd70-615b2acf6a42"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("48a6d683-cb3c-4b2d-bd70-615b2acf6a42"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("48a6d683-cb3c-4b2d-bd70-615b2acf6a42"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("48a6d683-cb3c-4b2d-bd70-615b2acf6a42"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4c452cdd-8262-41ae-92af-25c14ac08a14"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4c452cdd-8262-41ae-92af-25c14ac08a14"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4c452cdd-8262-41ae-92af-25c14ac08a14"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4c452cdd-8262-41ae-92af-25c14ac08a14"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4c452cdd-8262-41ae-92af-25c14ac08a14"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4e6feba6-5d28-4d40-bd97-1b5bb4f01a66"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4e6feba6-5d28-4d40-bd97-1b5bb4f01a66"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4e6feba6-5d28-4d40-bd97-1b5bb4f01a66"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4e6feba6-5d28-4d40-bd97-1b5bb4f01a66"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4e6feba6-5d28-4d40-bd97-1b5bb4f01a66"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5328b100-93a8-4922-9b46-6dbf318848cf"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5328b100-93a8-4922-9b46-6dbf318848cf"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5328b100-93a8-4922-9b46-6dbf318848cf"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5328b100-93a8-4922-9b46-6dbf318848cf"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5328b100-93a8-4922-9b46-6dbf318848cf"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("57c3c5e5-4381-48bc-b6c2-38f327ced4a3"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("57c3c5e5-4381-48bc-b6c2-38f327ced4a3"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("57c3c5e5-4381-48bc-b6c2-38f327ced4a3"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("61dbdcb4-d309-45e9-885c-641ce0b17328"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("61dbdcb4-d309-45e9-885c-641ce0b17328"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("61dbdcb4-d309-45e9-885c-641ce0b17328"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("63552d65-0cda-4856-9fce-c1ff3c921f80"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("63552d65-0cda-4856-9fce-c1ff3c921f80"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("63552d65-0cda-4856-9fce-c1ff3c921f80"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("63552d65-0cda-4856-9fce-c1ff3c921f80"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("63552d65-0cda-4856-9fce-c1ff3c921f80"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6bdfa048-bedb-4ca9-8d61-df560261e286"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6bdfa048-bedb-4ca9-8d61-df560261e286"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6bdfa048-bedb-4ca9-8d61-df560261e286"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6e7b18dd-4625-43e5-b5e6-cc9728c8652a"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6e7b18dd-4625-43e5-b5e6-cc9728c8652a"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6e7b18dd-4625-43e5-b5e6-cc9728c8652a"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("72b0fa48-2ded-43b7-81a2-7d580abc5cfe"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("72b0fa48-2ded-43b7-81a2-7d580abc5cfe"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("72b0fa48-2ded-43b7-81a2-7d580abc5cfe"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("72b0fa48-2ded-43b7-81a2-7d580abc5cfe"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("72b0fa48-2ded-43b7-81a2-7d580abc5cfe"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("84488c13-3e05-453f-b6a4-73384cfbe27e"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("84488c13-3e05-453f-b6a4-73384cfbe27e"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("84488c13-3e05-453f-b6a4-73384cfbe27e"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("84488c13-3e05-453f-b6a4-73384cfbe27e"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("84488c13-3e05-453f-b6a4-73384cfbe27e"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ac86ae8d-4bd2-4878-8920-04890c719188"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ac86ae8d-4bd2-4878-8920-04890c719188"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ac86ae8d-4bd2-4878-8920-04890c719188"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("adac8613-7d94-44e7-ba29-76be7b93fb11"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("adac8613-7d94-44e7-ba29-76be7b93fb11"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("adac8613-7d94-44e7-ba29-76be7b93fb11"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b07221c5-7d35-4569-8886-4870b7c0cce5"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b07221c5-7d35-4569-8886-4870b7c0cce5"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b07221c5-7d35-4569-8886-4870b7c0cce5"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b07221c5-7d35-4569-8886-4870b7c0cce5"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b07221c5-7d35-4569-8886-4870b7c0cce5"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b62f2571-4299-4553-8752-34278caaa162"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b62f2571-4299-4553-8752-34278caaa162"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b62f2571-4299-4553-8752-34278caaa162"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bca86634-fe68-448d-9bac-3ef08ce32dd0"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bca86634-fe68-448d-9bac-3ef08ce32dd0"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bca86634-fe68-448d-9bac-3ef08ce32dd0"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bca86634-fe68-448d-9bac-3ef08ce32dd0"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bca86634-fe68-448d-9bac-3ef08ce32dd0"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bca86634-fe68-448d-9bac-3ef08ce32dd0"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bca86634-fe68-448d-9bac-3ef08ce32dd0"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bca86634-fe68-448d-9bac-3ef08ce32dd0"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bca86634-fe68-448d-9bac-3ef08ce32dd0"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("bca86634-fe68-448d-9bac-3ef08ce32dd0"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c0124da2-01e6-46be-8cca-171b3ae684a0"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c0124da2-01e6-46be-8cca-171b3ae684a0"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c0124da2-01e6-46be-8cca-171b3ae684a0"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c1cf2c39-6d72-44fa-afaa-4fe1ca27122c"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c1cf2c39-6d72-44fa-afaa-4fe1ca27122c"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c1cf2c39-6d72-44fa-afaa-4fe1ca27122c"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cc4cf805-ffd2-4e69-948c-74ff7221a224"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cc4cf805-ffd2-4e69-948c-74ff7221a224"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cc4cf805-ffd2-4e69-948c-74ff7221a224"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ced383bc-ee7c-46f1-8d39-1aa435753dd5"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ced383bc-ee7c-46f1-8d39-1aa435753dd5"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ced383bc-ee7c-46f1-8d39-1aa435753dd5"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ced383bc-ee7c-46f1-8d39-1aa435753dd5"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ced383bc-ee7c-46f1-8d39-1aa435753dd5"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cfc0a1cb-d1d9-4b46-a6e4-5e7aeac0f0a8"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cfc0a1cb-d1d9-4b46-a6e4-5e7aeac0f0a8"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cfc0a1cb-d1d9-4b46-a6e4-5e7aeac0f0a8"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cfc0a1cb-d1d9-4b46-a6e4-5e7aeac0f0a8"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cfc0a1cb-d1d9-4b46-a6e4-5e7aeac0f0a8"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d7f46b06-431d-45ce-855c-3d53368169b0"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d7f46b06-431d-45ce-855c-3d53368169b0"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d7f46b06-431d-45ce-855c-3d53368169b0"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d7f46b06-431d-45ce-855c-3d53368169b0"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d7f46b06-431d-45ce-855c-3d53368169b0"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d7f46b06-431d-45ce-855c-3d53368169b0"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d7f46b06-431d-45ce-855c-3d53368169b0"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d7f46b06-431d-45ce-855c-3d53368169b0"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d7f46b06-431d-45ce-855c-3d53368169b0"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d7f46b06-431d-45ce-855c-3d53368169b0"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e123668e-85d4-4205-a4ed-6d496e136359"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e123668e-85d4-4205-a4ed-6d496e136359"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e123668e-85d4-4205-a4ed-6d496e136359"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e26487ed-ef9a-43e9-a766-00bd8bb9086b"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e26487ed-ef9a-43e9-a766-00bd8bb9086b"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e26487ed-ef9a-43e9-a766-00bd8bb9086b"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e26487ed-ef9a-43e9-a766-00bd8bb9086b"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e26487ed-ef9a-43e9-a766-00bd8bb9086b"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e26487ed-ef9a-43e9-a766-00bd8bb9086b"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e26487ed-ef9a-43e9-a766-00bd8bb9086b"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e26487ed-ef9a-43e9-a766-00bd8bb9086b"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e26487ed-ef9a-43e9-a766-00bd8bb9086b"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e26487ed-ef9a-43e9-a766-00bd8bb9086b"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e6618466-3e0a-40b5-822b-16536a331eea"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e6618466-3e0a-40b5-822b-16536a331eea"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e6618466-3e0a-40b5-822b-16536a331eea"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e6618466-3e0a-40b5-822b-16536a331eea"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e6618466-3e0a-40b5-822b-16536a331eea"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("efa11f5f-7733-4cc8-aa62-3f17ba98df9f"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("efa11f5f-7733-4cc8-aa62-3f17ba98df9f"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("efa11f5f-7733-4cc8-aa62-3f17ba98df9f"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f0703ff3-f267-438c-9be4-0d0c9f0c0662"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f0703ff3-f267-438c-9be4-0d0c9f0c0662"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f0703ff3-f267-438c-9be4-0d0c9f0c0662"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f0703ff3-f267-438c-9be4-0d0c9f0c0662"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f0703ff3-f267-438c-9be4-0d0c9f0c0662"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f2f92d0f-9513-4a83-8292-29a120c23a6f"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f2f92d0f-9513-4a83-8292-29a120c23a6f"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f2f92d0f-9513-4a83-8292-29a120c23a6f"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f99b8f27-f250-46e0-8922-72186e4837aa"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f99b8f27-f250-46e0-8922-72186e4837aa"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f99b8f27-f250-46e0-8922-72186e4837aa"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f99b8f27-f250-46e0-8922-72186e4837aa"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f99b8f27-f250-46e0-8922-72186e4837aa"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f99b8f27-f250-46e0-8922-72186e4837aa"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f99b8f27-f250-46e0-8922-72186e4837aa"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f99b8f27-f250-46e0-8922-72186e4837aa"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f99b8f27-f250-46e0-8922-72186e4837aa"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f99b8f27-f250-46e0-8922-72186e4837aa"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("037c66d9-1471-4535-b52b-3a81ec3df990"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("07ef5066-f870-4e1a-aa5b-f3d52d2fa76b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0c9ae47f-33b7-4101-a436-949b142418c7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0d84da76-acc1-4b2f-9a04-32168f348427"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("11bf9897-1b7d-4875-a640-abb5521b90a3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("12e9b8b5-b5b1-4cd9-bad2-bb994096e15b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("18c13610-ff61-4323-93f3-abfc838dfc63"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1a69363c-2814-4173-ac8c-252f94e16982"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1f40e8c4-c109-412d-9cbf-177ff1806026"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("22df0f5c-382b-4d40-8ca6-441893ce4d7b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("24249199-c042-4f04-9620-48455cbb0129"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("28ef49a4-aa49-4e39-a8b4-7ebf11af1bd4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3133b598-55ee-4d36-95ee-8dc6260a6a0a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("39bfe67b-c017-4a19-b482-87dd82bf9727"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("43a53e05-b748-4aac-af09-4fe46f3b953f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("48a6d683-cb3c-4b2d-bd70-615b2acf6a42"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4c452cdd-8262-41ae-92af-25c14ac08a14"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4e6feba6-5d28-4d40-bd97-1b5bb4f01a66"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5328b100-93a8-4922-9b46-6dbf318848cf"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("57c3c5e5-4381-48bc-b6c2-38f327ced4a3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("61dbdcb4-d309-45e9-885c-641ce0b17328"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("63552d65-0cda-4856-9fce-c1ff3c921f80"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6bdfa048-bedb-4ca9-8d61-df560261e286"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6e7b18dd-4625-43e5-b5e6-cc9728c8652a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("72b0fa48-2ded-43b7-81a2-7d580abc5cfe"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("84488c13-3e05-453f-b6a4-73384cfbe27e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ac86ae8d-4bd2-4878-8920-04890c719188"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("adac8613-7d94-44e7-ba29-76be7b93fb11"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b07221c5-7d35-4569-8886-4870b7c0cce5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b62f2571-4299-4553-8752-34278caaa162"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bca86634-fe68-448d-9bac-3ef08ce32dd0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c0124da2-01e6-46be-8cca-171b3ae684a0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c1cf2c39-6d72-44fa-afaa-4fe1ca27122c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cc4cf805-ffd2-4e69-948c-74ff7221a224"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ced383bc-ee7c-46f1-8d39-1aa435753dd5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cfc0a1cb-d1d9-4b46-a6e4-5e7aeac0f0a8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d7f46b06-431d-45ce-855c-3d53368169b0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e123668e-85d4-4205-a4ed-6d496e136359"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e26487ed-ef9a-43e9-a766-00bd8bb9086b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e6618466-3e0a-40b5-822b-16536a331eea"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("efa11f5f-7733-4cc8-aa62-3f17ba98df9f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f0703ff3-f267-438c-9be4-0d0c9f0c0662"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f2f92d0f-9513-4a83-8292-29a120c23a6f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f99b8f27-f250-46e0-8922-72186e4837aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4bf83703-9660-48e4-90f7-84334fa12e64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("682c0db7-4027-476d-baae-9776cc20e455"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8c39e161-120c-4112-9eb3-120671e7dacf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba"));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("011768f8-e4be-4182-8b82-9502db9033a1"), "createadminaccount-administrator" },
                    { new Guid("0b727d38-e3cf-457b-ae2d-f26e92c45c1a"), "addnotificationmembers-members" },
                    { new Guid("0d99f934-b3c0-4f3b-85f8-139be3381753"), "hardwareon-home" },
                    { new Guid("15865c3a-02b0-43fb-9d71-467afb3d5c30"), "getdevicemodelvalidators-devices" },
                    { new Guid("18ac9f5d-bb06-495b-ba97-3d4c613fce9e"), "updateroomdevice-home" },
                    { new Guid("29f06a8a-f868-4cd0-99bd-3d4f6775e4f1"), "motiondetection-motionsensor" },
                    { new Guid("2a16f132-4948-4b65-bfe1-99803c9c6541"), "getmembers-members" },
                    { new Guid("32981713-ae9c-49c8-924d-6fa017f49734"), "persondetection-camera" },
                    { new Guid("345ffcfd-968e-449a-a77e-7e08e2363792"), "hardwareoff-home" },
                    { new Guid("40b2b972-de1c-4b02-850a-3424af1116d5"), "getaccounts-accounts" },
                    { new Guid("445f0a35-0705-490c-b3dd-e229f8b1821f"), "gethomes-user" },
                    { new Guid("4684eb9b-d9ae-4034-b9d5-7b3f269e0bbc"), "addcamera-camera" },
                    { new Guid("4a7f937d-fe0a-4ce5-ad08-9feaae803bd6"), "getcompanyuser-companies" },
                    { new Guid("4cacaabe-0158-4ef8-8d59-1efbf552fd44"), "importdevices-devices" },
                    { new Guid("4d9c49fc-b8d5-4821-b4d6-7a0b89b9905f"), "addmotionsensor-motionsensor" },
                    { new Guid("4f5f0870-45e9-464e-b70c-6a5334adc9a9"), "getdevicetypes-devicetype" },
                    { new Guid("52b315c5-f028-479b-9cd6-18d234638cee"), "addmotionsensor-motionsensor" },
                    { new Guid("576fe3ab-f6eb-4324-ad6f-b08de29536da"), "on-smartlamp" },
                    { new Guid("5b274e82-26ac-430c-adc5-1b0f94e37d7c"), "addmember-members" },
                    { new Guid("5d4d3909-90e3-4bee-b1c6-cb1823473233"), "createcompanyowneraccount-companyowner" },
                    { new Guid("5dd1280a-ca32-4171-9b5b-be9abb256a49"), "createcompany-companies" },
                    { new Guid("654a8323-3ae2-4be7-915d-3b3c856bcb08"), "addpermission-members" },
                    { new Guid("6909f2a0-6697-46b3-8ed2-472bbdc208c7"), "getcompany-companies" },
                    { new Guid("775765c3-e0e0-4585-bfb6-1d019a007e2a"), "close-windowsensor" },
                    { new Guid("7941e0c4-52b9-4d8f-b0fe-86abc45f10ba"), "motiondetection-camera" },
                    { new Guid("7954b31f-bd0a-4130-a66e-db108c9634ab"), "getnotifications-notification" },
                    { new Guid("7bdd4ac0-f974-4b44-8c8a-57c43e86df14"), "addsensor-windowsensor" },
                    { new Guid("89b472f0-38dd-41e3-865a-478666d149f1"), "addrooms-home" },
                    { new Guid("956df0d2-0f2a-4d6c-af89-ee8575c73a7e"), "off-smartlamp" },
                    { new Guid("9c56e718-5095-4229-8425-2ebb28db3e33"), "getrooms-home" },
                    { new Guid("9cba7fdc-b617-42d3-b155-ba8f6b7c1156"), "getimporters-devices" },
                    { new Guid("aa0d6bfd-0e96-41e3-a5f6-47f6a0f0a161"), "getdevices-devices" },
                    { new Guid("b0eeca35-2e40-4539-aa55-24dfb7489661"), "getdevices-home" },
                    { new Guid("b87fe551-c466-4065-b15e-ea95dffda5d6"), "addhomeownerpermission-homeowner" },
                    { new Guid("be8b9003-9f48-4059-9cc9-3854c4b8f262"), "addsmartlamp-smartlamp" },
                    { new Guid("c1b8f116-ffdb-4acc-98c1-f3c9398d6338"), "getpermissions-home" },
                    { new Guid("c406416b-55fc-4dd5-98d9-a91f2f175911"), "changeprofilephoto-user" },
                    { new Guid("c5aeb840-ed0e-42fb-a872-fb50e3cbd9ca"), "adddevice-home" },
                    { new Guid("ce34c610-9033-4d53-8c93-97ff1fb573e4"), "selectdevicemodelvalidator-devices" },
                    { new Guid("d12c03cc-46d5-4cd7-81bc-10bd8d80c5ce"), "deleteadminaccount-administrator" },
                    { new Guid("f196825e-fd50-4385-ab38-286b5c910f7d"), "updatenamedevice-home" },
                    { new Guid("fb29d0e9-95c7-4a00-bece-95d07d2ed80a"), "add-home" },
                    { new Guid("fcb5e54b-fd12-486e-bebd-c6dcbee7d933"), "open-windowsensor" },
                    { new Guid("fceed037-1f24-456c-8d72-2e3591448d7f"), "addhomeownerpermission-homeowner" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Password", "ProfilePhoto", "Roles", "Surname" },
                values: new object[,]
                {
                    { new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7"), new DateTime(2024, 11, 19, 16, 24, 13, 137, DateTimeKind.Local).AddTicks(6834), "serenawilliams@tennis.com", "Serena", "Serena@123", "serena.jpg", "[2]", "Williams" },
                    { new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5"), new DateTime(2024, 11, 19, 16, 24, 13, 137, DateTimeKind.Local).AddTicks(6830), "rafaelnadal@tennis.com", "Rafael", "Nadal@123", "nadal.jpg", "[0]", "Nadal" },
                    { new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868"), new DateTime(2024, 11, 19, 16, 24, 13, 137, DateTimeKind.Local).AddTicks(6866), "martinanavratilova@tennis.com", "Martina", "Navratilova@123", "navratilova.jpg", "[1]", "Navratilova" },
                    { new Guid("40720596-5246-4cf3-815a-77373be4fbe8"), new DateTime(2024, 11, 19, 16, 24, 13, 137, DateTimeKind.Local).AddTicks(6872), "billiejeanking@tennis.com", "Billie", "King@123", "king.jpg", "[0]", "Jean King" },
                    { new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367"), new DateTime(2024, 11, 19, 16, 24, 13, 137, DateTimeKind.Local).AddTicks(6843), "steffigraf@tennis.com", "Steffi", "Steffi@123", "graf.jpg", "[1]", "Graf" },
                    { new Guid("9bb64b66-4b50-48ad-8721-c84df442c136"), new DateTime(2024, 11, 19, 16, 24, 13, 137, DateTimeKind.Local).AddTicks(6837), "novakdjokovic@tennis.com", "Novak", "Djokovic@123", "djokovic.jpg", "[2,1]", "Djokovic" },
                    { new Guid("a59150be-53c9-4134-b5ac-5044e249f323"), new DateTime(2024, 11, 19, 16, 24, 13, 137, DateTimeKind.Local).AddTicks(6849), "andreagassi@tennis.com", "Andre", "Agassi@123", "agassi.jpg", "[1]", "Agassi" },
                    { new Guid("c2d7472d-3857-4e06-89ac-756cecc47691"), new DateTime(2024, 11, 19, 16, 24, 13, 137, DateTimeKind.Local).AddTicks(6781), "rogerfederer@tennis.com", "Roger", "Federer@123", "federer.jpg", "[0]", "Federer" },
                    { new Guid("c58f351d-5651-467f-a227-706dff5cb5d8"), new DateTime(2024, 11, 19, 16, 24, 13, 137, DateTimeKind.Local).AddTicks(6869), "johnmcenroe@tennis.com", "John", "McEnroe@123", "mcenroe.jpg", "[2]", "McEnroe" },
                    { new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff"), new DateTime(2024, 11, 19, 16, 24, 13, 137, DateTimeKind.Local).AddTicks(6858), "petesampras@tennis.com", "Pete", "Sampras@123", "sampras.jpg", "[1]", "Sampras" }
                });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "PermissionId", "UserId" },
                values: new object[,]
                {
                    { new Guid("011768f8-e4be-4182-8b82-9502db9033a1"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") },
                    { new Guid("011768f8-e4be-4182-8b82-9502db9033a1"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("011768f8-e4be-4182-8b82-9502db9033a1"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") },
                    { new Guid("0b727d38-e3cf-457b-ae2d-f26e92c45c1a"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("0b727d38-e3cf-457b-ae2d-f26e92c45c1a"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("0b727d38-e3cf-457b-ae2d-f26e92c45c1a"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("0b727d38-e3cf-457b-ae2d-f26e92c45c1a"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("0b727d38-e3cf-457b-ae2d-f26e92c45c1a"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("0d99f934-b3c0-4f3b-85f8-139be3381753"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("0d99f934-b3c0-4f3b-85f8-139be3381753"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("0d99f934-b3c0-4f3b-85f8-139be3381753"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("0d99f934-b3c0-4f3b-85f8-139be3381753"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("0d99f934-b3c0-4f3b-85f8-139be3381753"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("15865c3a-02b0-43fb-9d71-467afb3d5c30"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("15865c3a-02b0-43fb-9d71-467afb3d5c30"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("15865c3a-02b0-43fb-9d71-467afb3d5c30"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("18ac9f5d-bb06-495b-ba97-3d4c613fce9e"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("18ac9f5d-bb06-495b-ba97-3d4c613fce9e"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("18ac9f5d-bb06-495b-ba97-3d4c613fce9e"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("18ac9f5d-bb06-495b-ba97-3d4c613fce9e"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("18ac9f5d-bb06-495b-ba97-3d4c613fce9e"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("29f06a8a-f868-4cd0-99bd-3d4f6775e4f1"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") },
                    { new Guid("29f06a8a-f868-4cd0-99bd-3d4f6775e4f1"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("29f06a8a-f868-4cd0-99bd-3d4f6775e4f1"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("29f06a8a-f868-4cd0-99bd-3d4f6775e4f1"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("29f06a8a-f868-4cd0-99bd-3d4f6775e4f1"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("29f06a8a-f868-4cd0-99bd-3d4f6775e4f1"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("29f06a8a-f868-4cd0-99bd-3d4f6775e4f1"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("29f06a8a-f868-4cd0-99bd-3d4f6775e4f1"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("29f06a8a-f868-4cd0-99bd-3d4f6775e4f1"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") },
                    { new Guid("29f06a8a-f868-4cd0-99bd-3d4f6775e4f1"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("2a16f132-4948-4b65-bfe1-99803c9c6541"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("2a16f132-4948-4b65-bfe1-99803c9c6541"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("2a16f132-4948-4b65-bfe1-99803c9c6541"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("2a16f132-4948-4b65-bfe1-99803c9c6541"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("2a16f132-4948-4b65-bfe1-99803c9c6541"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("32981713-ae9c-49c8-924d-6fa017f49734"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") },
                    { new Guid("32981713-ae9c-49c8-924d-6fa017f49734"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("32981713-ae9c-49c8-924d-6fa017f49734"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("32981713-ae9c-49c8-924d-6fa017f49734"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("32981713-ae9c-49c8-924d-6fa017f49734"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("32981713-ae9c-49c8-924d-6fa017f49734"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("32981713-ae9c-49c8-924d-6fa017f49734"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("32981713-ae9c-49c8-924d-6fa017f49734"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("32981713-ae9c-49c8-924d-6fa017f49734"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") },
                    { new Guid("32981713-ae9c-49c8-924d-6fa017f49734"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("345ffcfd-968e-449a-a77e-7e08e2363792"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("345ffcfd-968e-449a-a77e-7e08e2363792"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("345ffcfd-968e-449a-a77e-7e08e2363792"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("345ffcfd-968e-449a-a77e-7e08e2363792"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("345ffcfd-968e-449a-a77e-7e08e2363792"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("40b2b972-de1c-4b02-850a-3424af1116d5"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") },
                    { new Guid("40b2b972-de1c-4b02-850a-3424af1116d5"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("40b2b972-de1c-4b02-850a-3424af1116d5"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") },
                    { new Guid("445f0a35-0705-490c-b3dd-e229f8b1821f"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("445f0a35-0705-490c-b3dd-e229f8b1821f"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("445f0a35-0705-490c-b3dd-e229f8b1821f"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("445f0a35-0705-490c-b3dd-e229f8b1821f"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("445f0a35-0705-490c-b3dd-e229f8b1821f"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("4684eb9b-d9ae-4034-b9d5-7b3f269e0bbc"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("4684eb9b-d9ae-4034-b9d5-7b3f269e0bbc"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("4684eb9b-d9ae-4034-b9d5-7b3f269e0bbc"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("4a7f937d-fe0a-4ce5-ad08-9feaae803bd6"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("4a7f937d-fe0a-4ce5-ad08-9feaae803bd6"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("4a7f937d-fe0a-4ce5-ad08-9feaae803bd6"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("4cacaabe-0158-4ef8-8d59-1efbf552fd44"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("4cacaabe-0158-4ef8-8d59-1efbf552fd44"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("4cacaabe-0158-4ef8-8d59-1efbf552fd44"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("4d9c49fc-b8d5-4821-b4d6-7a0b89b9905f"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("4d9c49fc-b8d5-4821-b4d6-7a0b89b9905f"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("4d9c49fc-b8d5-4821-b4d6-7a0b89b9905f"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("4d9c49fc-b8d5-4821-b4d6-7a0b89b9905f"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("4d9c49fc-b8d5-4821-b4d6-7a0b89b9905f"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("4f5f0870-45e9-464e-b70c-6a5334adc9a9"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") },
                    { new Guid("4f5f0870-45e9-464e-b70c-6a5334adc9a9"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("4f5f0870-45e9-464e-b70c-6a5334adc9a9"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("4f5f0870-45e9-464e-b70c-6a5334adc9a9"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("4f5f0870-45e9-464e-b70c-6a5334adc9a9"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("4f5f0870-45e9-464e-b70c-6a5334adc9a9"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("4f5f0870-45e9-464e-b70c-6a5334adc9a9"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("4f5f0870-45e9-464e-b70c-6a5334adc9a9"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("4f5f0870-45e9-464e-b70c-6a5334adc9a9"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") },
                    { new Guid("4f5f0870-45e9-464e-b70c-6a5334adc9a9"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("52b315c5-f028-479b-9cd6-18d234638cee"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("52b315c5-f028-479b-9cd6-18d234638cee"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("52b315c5-f028-479b-9cd6-18d234638cee"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("576fe3ab-f6eb-4324-ad6f-b08de29536da"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") },
                    { new Guid("576fe3ab-f6eb-4324-ad6f-b08de29536da"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("576fe3ab-f6eb-4324-ad6f-b08de29536da"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("576fe3ab-f6eb-4324-ad6f-b08de29536da"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("576fe3ab-f6eb-4324-ad6f-b08de29536da"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("576fe3ab-f6eb-4324-ad6f-b08de29536da"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("576fe3ab-f6eb-4324-ad6f-b08de29536da"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("576fe3ab-f6eb-4324-ad6f-b08de29536da"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("576fe3ab-f6eb-4324-ad6f-b08de29536da"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") },
                    { new Guid("576fe3ab-f6eb-4324-ad6f-b08de29536da"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("5b274e82-26ac-430c-adc5-1b0f94e37d7c"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("5b274e82-26ac-430c-adc5-1b0f94e37d7c"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("5b274e82-26ac-430c-adc5-1b0f94e37d7c"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("5b274e82-26ac-430c-adc5-1b0f94e37d7c"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("5b274e82-26ac-430c-adc5-1b0f94e37d7c"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("5d4d3909-90e3-4bee-b1c6-cb1823473233"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") },
                    { new Guid("5d4d3909-90e3-4bee-b1c6-cb1823473233"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("5d4d3909-90e3-4bee-b1c6-cb1823473233"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") },
                    { new Guid("5dd1280a-ca32-4171-9b5b-be9abb256a49"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("5dd1280a-ca32-4171-9b5b-be9abb256a49"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("5dd1280a-ca32-4171-9b5b-be9abb256a49"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("654a8323-3ae2-4be7-915d-3b3c856bcb08"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("654a8323-3ae2-4be7-915d-3b3c856bcb08"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("654a8323-3ae2-4be7-915d-3b3c856bcb08"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("654a8323-3ae2-4be7-915d-3b3c856bcb08"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("654a8323-3ae2-4be7-915d-3b3c856bcb08"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("6909f2a0-6697-46b3-8ed2-472bbdc208c7"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") },
                    { new Guid("6909f2a0-6697-46b3-8ed2-472bbdc208c7"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("6909f2a0-6697-46b3-8ed2-472bbdc208c7"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") },
                    { new Guid("775765c3-e0e0-4585-bfb6-1d019a007e2a"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") },
                    { new Guid("775765c3-e0e0-4585-bfb6-1d019a007e2a"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("775765c3-e0e0-4585-bfb6-1d019a007e2a"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("775765c3-e0e0-4585-bfb6-1d019a007e2a"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("775765c3-e0e0-4585-bfb6-1d019a007e2a"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("775765c3-e0e0-4585-bfb6-1d019a007e2a"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("775765c3-e0e0-4585-bfb6-1d019a007e2a"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("775765c3-e0e0-4585-bfb6-1d019a007e2a"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("775765c3-e0e0-4585-bfb6-1d019a007e2a"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") },
                    { new Guid("775765c3-e0e0-4585-bfb6-1d019a007e2a"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("7941e0c4-52b9-4d8f-b0fe-86abc45f10ba"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") },
                    { new Guid("7941e0c4-52b9-4d8f-b0fe-86abc45f10ba"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("7941e0c4-52b9-4d8f-b0fe-86abc45f10ba"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("7941e0c4-52b9-4d8f-b0fe-86abc45f10ba"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("7941e0c4-52b9-4d8f-b0fe-86abc45f10ba"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("7941e0c4-52b9-4d8f-b0fe-86abc45f10ba"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("7941e0c4-52b9-4d8f-b0fe-86abc45f10ba"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("7941e0c4-52b9-4d8f-b0fe-86abc45f10ba"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("7941e0c4-52b9-4d8f-b0fe-86abc45f10ba"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") },
                    { new Guid("7941e0c4-52b9-4d8f-b0fe-86abc45f10ba"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("7954b31f-bd0a-4130-a66e-db108c9634ab"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") },
                    { new Guid("7954b31f-bd0a-4130-a66e-db108c9634ab"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("7954b31f-bd0a-4130-a66e-db108c9634ab"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("7954b31f-bd0a-4130-a66e-db108c9634ab"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("7954b31f-bd0a-4130-a66e-db108c9634ab"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("7954b31f-bd0a-4130-a66e-db108c9634ab"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("7954b31f-bd0a-4130-a66e-db108c9634ab"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("7954b31f-bd0a-4130-a66e-db108c9634ab"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("7954b31f-bd0a-4130-a66e-db108c9634ab"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") },
                    { new Guid("7954b31f-bd0a-4130-a66e-db108c9634ab"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("7bdd4ac0-f974-4b44-8c8a-57c43e86df14"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("7bdd4ac0-f974-4b44-8c8a-57c43e86df14"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("7bdd4ac0-f974-4b44-8c8a-57c43e86df14"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("89b472f0-38dd-41e3-865a-478666d149f1"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("89b472f0-38dd-41e3-865a-478666d149f1"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("89b472f0-38dd-41e3-865a-478666d149f1"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("89b472f0-38dd-41e3-865a-478666d149f1"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("89b472f0-38dd-41e3-865a-478666d149f1"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("956df0d2-0f2a-4d6c-af89-ee8575c73a7e"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") },
                    { new Guid("956df0d2-0f2a-4d6c-af89-ee8575c73a7e"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("956df0d2-0f2a-4d6c-af89-ee8575c73a7e"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("956df0d2-0f2a-4d6c-af89-ee8575c73a7e"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("956df0d2-0f2a-4d6c-af89-ee8575c73a7e"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("956df0d2-0f2a-4d6c-af89-ee8575c73a7e"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("956df0d2-0f2a-4d6c-af89-ee8575c73a7e"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("956df0d2-0f2a-4d6c-af89-ee8575c73a7e"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("956df0d2-0f2a-4d6c-af89-ee8575c73a7e"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") },
                    { new Guid("956df0d2-0f2a-4d6c-af89-ee8575c73a7e"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("9c56e718-5095-4229-8425-2ebb28db3e33"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("9c56e718-5095-4229-8425-2ebb28db3e33"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("9c56e718-5095-4229-8425-2ebb28db3e33"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("9c56e718-5095-4229-8425-2ebb28db3e33"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("9c56e718-5095-4229-8425-2ebb28db3e33"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("9cba7fdc-b617-42d3-b155-ba8f6b7c1156"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("9cba7fdc-b617-42d3-b155-ba8f6b7c1156"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("9cba7fdc-b617-42d3-b155-ba8f6b7c1156"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("aa0d6bfd-0e96-41e3-a5f6-47f6a0f0a161"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") },
                    { new Guid("aa0d6bfd-0e96-41e3-a5f6-47f6a0f0a161"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("aa0d6bfd-0e96-41e3-a5f6-47f6a0f0a161"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("aa0d6bfd-0e96-41e3-a5f6-47f6a0f0a161"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("aa0d6bfd-0e96-41e3-a5f6-47f6a0f0a161"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("aa0d6bfd-0e96-41e3-a5f6-47f6a0f0a161"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("aa0d6bfd-0e96-41e3-a5f6-47f6a0f0a161"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("aa0d6bfd-0e96-41e3-a5f6-47f6a0f0a161"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("aa0d6bfd-0e96-41e3-a5f6-47f6a0f0a161"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") },
                    { new Guid("aa0d6bfd-0e96-41e3-a5f6-47f6a0f0a161"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("b0eeca35-2e40-4539-aa55-24dfb7489661"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("b0eeca35-2e40-4539-aa55-24dfb7489661"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("b0eeca35-2e40-4539-aa55-24dfb7489661"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("b0eeca35-2e40-4539-aa55-24dfb7489661"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("b0eeca35-2e40-4539-aa55-24dfb7489661"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("b87fe551-c466-4065-b15e-ea95dffda5d6"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("b87fe551-c466-4065-b15e-ea95dffda5d6"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("b87fe551-c466-4065-b15e-ea95dffda5d6"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("be8b9003-9f48-4059-9cc9-3854c4b8f262"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("be8b9003-9f48-4059-9cc9-3854c4b8f262"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("be8b9003-9f48-4059-9cc9-3854c4b8f262"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("c1b8f116-ffdb-4acc-98c1-f3c9398d6338"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") },
                    { new Guid("c1b8f116-ffdb-4acc-98c1-f3c9398d6338"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("c1b8f116-ffdb-4acc-98c1-f3c9398d6338"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("c1b8f116-ffdb-4acc-98c1-f3c9398d6338"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("c1b8f116-ffdb-4acc-98c1-f3c9398d6338"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("c1b8f116-ffdb-4acc-98c1-f3c9398d6338"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("c1b8f116-ffdb-4acc-98c1-f3c9398d6338"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("c1b8f116-ffdb-4acc-98c1-f3c9398d6338"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("c1b8f116-ffdb-4acc-98c1-f3c9398d6338"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") },
                    { new Guid("c1b8f116-ffdb-4acc-98c1-f3c9398d6338"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("c406416b-55fc-4dd5-98d9-a91f2f175911"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") },
                    { new Guid("c406416b-55fc-4dd5-98d9-a91f2f175911"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("c406416b-55fc-4dd5-98d9-a91f2f175911"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("c406416b-55fc-4dd5-98d9-a91f2f175911"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("c406416b-55fc-4dd5-98d9-a91f2f175911"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("c406416b-55fc-4dd5-98d9-a91f2f175911"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("c406416b-55fc-4dd5-98d9-a91f2f175911"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("c406416b-55fc-4dd5-98d9-a91f2f175911"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("c406416b-55fc-4dd5-98d9-a91f2f175911"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") },
                    { new Guid("c406416b-55fc-4dd5-98d9-a91f2f175911"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("c5aeb840-ed0e-42fb-a872-fb50e3cbd9ca"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("c5aeb840-ed0e-42fb-a872-fb50e3cbd9ca"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("c5aeb840-ed0e-42fb-a872-fb50e3cbd9ca"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("c5aeb840-ed0e-42fb-a872-fb50e3cbd9ca"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("c5aeb840-ed0e-42fb-a872-fb50e3cbd9ca"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("ce34c610-9033-4d53-8c93-97ff1fb573e4"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("ce34c610-9033-4d53-8c93-97ff1fb573e4"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("ce34c610-9033-4d53-8c93-97ff1fb573e4"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("d12c03cc-46d5-4cd7-81bc-10bd8d80c5ce"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") },
                    { new Guid("d12c03cc-46d5-4cd7-81bc-10bd8d80c5ce"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("d12c03cc-46d5-4cd7-81bc-10bd8d80c5ce"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") },
                    { new Guid("f196825e-fd50-4385-ab38-286b5c910f7d"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("f196825e-fd50-4385-ab38-286b5c910f7d"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("f196825e-fd50-4385-ab38-286b5c910f7d"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("f196825e-fd50-4385-ab38-286b5c910f7d"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("f196825e-fd50-4385-ab38-286b5c910f7d"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("fb29d0e9-95c7-4a00-bece-95d07d2ed80a"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("fb29d0e9-95c7-4a00-bece-95d07d2ed80a"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("fb29d0e9-95c7-4a00-bece-95d07d2ed80a"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("fb29d0e9-95c7-4a00-bece-95d07d2ed80a"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("fb29d0e9-95c7-4a00-bece-95d07d2ed80a"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("fcb5e54b-fd12-486e-bebd-c6dcbee7d933"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") },
                    { new Guid("fcb5e54b-fd12-486e-bebd-c6dcbee7d933"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") },
                    { new Guid("fcb5e54b-fd12-486e-bebd-c6dcbee7d933"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") },
                    { new Guid("fcb5e54b-fd12-486e-bebd-c6dcbee7d933"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") },
                    { new Guid("fcb5e54b-fd12-486e-bebd-c6dcbee7d933"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") },
                    { new Guid("fcb5e54b-fd12-486e-bebd-c6dcbee7d933"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("fcb5e54b-fd12-486e-bebd-c6dcbee7d933"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") },
                    { new Guid("fcb5e54b-fd12-486e-bebd-c6dcbee7d933"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") },
                    { new Guid("fcb5e54b-fd12-486e-bebd-c6dcbee7d933"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") },
                    { new Guid("fcb5e54b-fd12-486e-bebd-c6dcbee7d933"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") },
                    { new Guid("fceed037-1f24-456c-8d72-2e3591448d7f"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") },
                    { new Guid("fceed037-1f24-456c-8d72-2e3591448d7f"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") },
                    { new Guid("fceed037-1f24-456c-8d72-2e3591448d7f"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("011768f8-e4be-4182-8b82-9502db9033a1"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("011768f8-e4be-4182-8b82-9502db9033a1"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("011768f8-e4be-4182-8b82-9502db9033a1"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0b727d38-e3cf-457b-ae2d-f26e92c45c1a"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0b727d38-e3cf-457b-ae2d-f26e92c45c1a"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0b727d38-e3cf-457b-ae2d-f26e92c45c1a"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0b727d38-e3cf-457b-ae2d-f26e92c45c1a"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0b727d38-e3cf-457b-ae2d-f26e92c45c1a"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d99f934-b3c0-4f3b-85f8-139be3381753"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d99f934-b3c0-4f3b-85f8-139be3381753"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d99f934-b3c0-4f3b-85f8-139be3381753"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d99f934-b3c0-4f3b-85f8-139be3381753"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0d99f934-b3c0-4f3b-85f8-139be3381753"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("15865c3a-02b0-43fb-9d71-467afb3d5c30"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("15865c3a-02b0-43fb-9d71-467afb3d5c30"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("15865c3a-02b0-43fb-9d71-467afb3d5c30"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18ac9f5d-bb06-495b-ba97-3d4c613fce9e"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18ac9f5d-bb06-495b-ba97-3d4c613fce9e"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18ac9f5d-bb06-495b-ba97-3d4c613fce9e"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18ac9f5d-bb06-495b-ba97-3d4c613fce9e"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18ac9f5d-bb06-495b-ba97-3d4c613fce9e"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("29f06a8a-f868-4cd0-99bd-3d4f6775e4f1"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("29f06a8a-f868-4cd0-99bd-3d4f6775e4f1"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("29f06a8a-f868-4cd0-99bd-3d4f6775e4f1"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("29f06a8a-f868-4cd0-99bd-3d4f6775e4f1"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("29f06a8a-f868-4cd0-99bd-3d4f6775e4f1"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("29f06a8a-f868-4cd0-99bd-3d4f6775e4f1"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("29f06a8a-f868-4cd0-99bd-3d4f6775e4f1"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("29f06a8a-f868-4cd0-99bd-3d4f6775e4f1"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("29f06a8a-f868-4cd0-99bd-3d4f6775e4f1"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("29f06a8a-f868-4cd0-99bd-3d4f6775e4f1"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2a16f132-4948-4b65-bfe1-99803c9c6541"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2a16f132-4948-4b65-bfe1-99803c9c6541"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2a16f132-4948-4b65-bfe1-99803c9c6541"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2a16f132-4948-4b65-bfe1-99803c9c6541"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("2a16f132-4948-4b65-bfe1-99803c9c6541"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("32981713-ae9c-49c8-924d-6fa017f49734"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("32981713-ae9c-49c8-924d-6fa017f49734"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("32981713-ae9c-49c8-924d-6fa017f49734"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("32981713-ae9c-49c8-924d-6fa017f49734"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("32981713-ae9c-49c8-924d-6fa017f49734"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("32981713-ae9c-49c8-924d-6fa017f49734"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("32981713-ae9c-49c8-924d-6fa017f49734"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("32981713-ae9c-49c8-924d-6fa017f49734"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("32981713-ae9c-49c8-924d-6fa017f49734"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("32981713-ae9c-49c8-924d-6fa017f49734"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("345ffcfd-968e-449a-a77e-7e08e2363792"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("345ffcfd-968e-449a-a77e-7e08e2363792"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("345ffcfd-968e-449a-a77e-7e08e2363792"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("345ffcfd-968e-449a-a77e-7e08e2363792"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("345ffcfd-968e-449a-a77e-7e08e2363792"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("40b2b972-de1c-4b02-850a-3424af1116d5"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("40b2b972-de1c-4b02-850a-3424af1116d5"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("40b2b972-de1c-4b02-850a-3424af1116d5"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("445f0a35-0705-490c-b3dd-e229f8b1821f"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("445f0a35-0705-490c-b3dd-e229f8b1821f"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("445f0a35-0705-490c-b3dd-e229f8b1821f"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("445f0a35-0705-490c-b3dd-e229f8b1821f"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("445f0a35-0705-490c-b3dd-e229f8b1821f"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4684eb9b-d9ae-4034-b9d5-7b3f269e0bbc"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4684eb9b-d9ae-4034-b9d5-7b3f269e0bbc"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4684eb9b-d9ae-4034-b9d5-7b3f269e0bbc"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4a7f937d-fe0a-4ce5-ad08-9feaae803bd6"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4a7f937d-fe0a-4ce5-ad08-9feaae803bd6"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4a7f937d-fe0a-4ce5-ad08-9feaae803bd6"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4cacaabe-0158-4ef8-8d59-1efbf552fd44"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4cacaabe-0158-4ef8-8d59-1efbf552fd44"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4cacaabe-0158-4ef8-8d59-1efbf552fd44"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4d9c49fc-b8d5-4821-b4d6-7a0b89b9905f"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4d9c49fc-b8d5-4821-b4d6-7a0b89b9905f"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4d9c49fc-b8d5-4821-b4d6-7a0b89b9905f"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4d9c49fc-b8d5-4821-b4d6-7a0b89b9905f"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4d9c49fc-b8d5-4821-b4d6-7a0b89b9905f"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4f5f0870-45e9-464e-b70c-6a5334adc9a9"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4f5f0870-45e9-464e-b70c-6a5334adc9a9"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4f5f0870-45e9-464e-b70c-6a5334adc9a9"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4f5f0870-45e9-464e-b70c-6a5334adc9a9"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4f5f0870-45e9-464e-b70c-6a5334adc9a9"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4f5f0870-45e9-464e-b70c-6a5334adc9a9"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4f5f0870-45e9-464e-b70c-6a5334adc9a9"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4f5f0870-45e9-464e-b70c-6a5334adc9a9"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4f5f0870-45e9-464e-b70c-6a5334adc9a9"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4f5f0870-45e9-464e-b70c-6a5334adc9a9"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("52b315c5-f028-479b-9cd6-18d234638cee"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("52b315c5-f028-479b-9cd6-18d234638cee"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("52b315c5-f028-479b-9cd6-18d234638cee"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("576fe3ab-f6eb-4324-ad6f-b08de29536da"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("576fe3ab-f6eb-4324-ad6f-b08de29536da"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("576fe3ab-f6eb-4324-ad6f-b08de29536da"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("576fe3ab-f6eb-4324-ad6f-b08de29536da"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("576fe3ab-f6eb-4324-ad6f-b08de29536da"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("576fe3ab-f6eb-4324-ad6f-b08de29536da"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("576fe3ab-f6eb-4324-ad6f-b08de29536da"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("576fe3ab-f6eb-4324-ad6f-b08de29536da"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("576fe3ab-f6eb-4324-ad6f-b08de29536da"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("576fe3ab-f6eb-4324-ad6f-b08de29536da"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5b274e82-26ac-430c-adc5-1b0f94e37d7c"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5b274e82-26ac-430c-adc5-1b0f94e37d7c"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5b274e82-26ac-430c-adc5-1b0f94e37d7c"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5b274e82-26ac-430c-adc5-1b0f94e37d7c"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5b274e82-26ac-430c-adc5-1b0f94e37d7c"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5d4d3909-90e3-4bee-b1c6-cb1823473233"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5d4d3909-90e3-4bee-b1c6-cb1823473233"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5d4d3909-90e3-4bee-b1c6-cb1823473233"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5dd1280a-ca32-4171-9b5b-be9abb256a49"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5dd1280a-ca32-4171-9b5b-be9abb256a49"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5dd1280a-ca32-4171-9b5b-be9abb256a49"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("654a8323-3ae2-4be7-915d-3b3c856bcb08"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("654a8323-3ae2-4be7-915d-3b3c856bcb08"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("654a8323-3ae2-4be7-915d-3b3c856bcb08"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("654a8323-3ae2-4be7-915d-3b3c856bcb08"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("654a8323-3ae2-4be7-915d-3b3c856bcb08"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6909f2a0-6697-46b3-8ed2-472bbdc208c7"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6909f2a0-6697-46b3-8ed2-472bbdc208c7"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6909f2a0-6697-46b3-8ed2-472bbdc208c7"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("775765c3-e0e0-4585-bfb6-1d019a007e2a"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("775765c3-e0e0-4585-bfb6-1d019a007e2a"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("775765c3-e0e0-4585-bfb6-1d019a007e2a"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("775765c3-e0e0-4585-bfb6-1d019a007e2a"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("775765c3-e0e0-4585-bfb6-1d019a007e2a"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("775765c3-e0e0-4585-bfb6-1d019a007e2a"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("775765c3-e0e0-4585-bfb6-1d019a007e2a"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("775765c3-e0e0-4585-bfb6-1d019a007e2a"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("775765c3-e0e0-4585-bfb6-1d019a007e2a"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("775765c3-e0e0-4585-bfb6-1d019a007e2a"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7941e0c4-52b9-4d8f-b0fe-86abc45f10ba"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7941e0c4-52b9-4d8f-b0fe-86abc45f10ba"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7941e0c4-52b9-4d8f-b0fe-86abc45f10ba"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7941e0c4-52b9-4d8f-b0fe-86abc45f10ba"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7941e0c4-52b9-4d8f-b0fe-86abc45f10ba"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7941e0c4-52b9-4d8f-b0fe-86abc45f10ba"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7941e0c4-52b9-4d8f-b0fe-86abc45f10ba"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7941e0c4-52b9-4d8f-b0fe-86abc45f10ba"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7941e0c4-52b9-4d8f-b0fe-86abc45f10ba"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7941e0c4-52b9-4d8f-b0fe-86abc45f10ba"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7954b31f-bd0a-4130-a66e-db108c9634ab"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7954b31f-bd0a-4130-a66e-db108c9634ab"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7954b31f-bd0a-4130-a66e-db108c9634ab"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7954b31f-bd0a-4130-a66e-db108c9634ab"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7954b31f-bd0a-4130-a66e-db108c9634ab"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7954b31f-bd0a-4130-a66e-db108c9634ab"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7954b31f-bd0a-4130-a66e-db108c9634ab"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7954b31f-bd0a-4130-a66e-db108c9634ab"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7954b31f-bd0a-4130-a66e-db108c9634ab"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7954b31f-bd0a-4130-a66e-db108c9634ab"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7bdd4ac0-f974-4b44-8c8a-57c43e86df14"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7bdd4ac0-f974-4b44-8c8a-57c43e86df14"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7bdd4ac0-f974-4b44-8c8a-57c43e86df14"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("89b472f0-38dd-41e3-865a-478666d149f1"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("89b472f0-38dd-41e3-865a-478666d149f1"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("89b472f0-38dd-41e3-865a-478666d149f1"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("89b472f0-38dd-41e3-865a-478666d149f1"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("89b472f0-38dd-41e3-865a-478666d149f1"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("956df0d2-0f2a-4d6c-af89-ee8575c73a7e"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("956df0d2-0f2a-4d6c-af89-ee8575c73a7e"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("956df0d2-0f2a-4d6c-af89-ee8575c73a7e"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("956df0d2-0f2a-4d6c-af89-ee8575c73a7e"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("956df0d2-0f2a-4d6c-af89-ee8575c73a7e"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("956df0d2-0f2a-4d6c-af89-ee8575c73a7e"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("956df0d2-0f2a-4d6c-af89-ee8575c73a7e"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("956df0d2-0f2a-4d6c-af89-ee8575c73a7e"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("956df0d2-0f2a-4d6c-af89-ee8575c73a7e"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("956df0d2-0f2a-4d6c-af89-ee8575c73a7e"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9c56e718-5095-4229-8425-2ebb28db3e33"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9c56e718-5095-4229-8425-2ebb28db3e33"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9c56e718-5095-4229-8425-2ebb28db3e33"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9c56e718-5095-4229-8425-2ebb28db3e33"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9c56e718-5095-4229-8425-2ebb28db3e33"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9cba7fdc-b617-42d3-b155-ba8f6b7c1156"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9cba7fdc-b617-42d3-b155-ba8f6b7c1156"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9cba7fdc-b617-42d3-b155-ba8f6b7c1156"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa0d6bfd-0e96-41e3-a5f6-47f6a0f0a161"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa0d6bfd-0e96-41e3-a5f6-47f6a0f0a161"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa0d6bfd-0e96-41e3-a5f6-47f6a0f0a161"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa0d6bfd-0e96-41e3-a5f6-47f6a0f0a161"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa0d6bfd-0e96-41e3-a5f6-47f6a0f0a161"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa0d6bfd-0e96-41e3-a5f6-47f6a0f0a161"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa0d6bfd-0e96-41e3-a5f6-47f6a0f0a161"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa0d6bfd-0e96-41e3-a5f6-47f6a0f0a161"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa0d6bfd-0e96-41e3-a5f6-47f6a0f0a161"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa0d6bfd-0e96-41e3-a5f6-47f6a0f0a161"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b0eeca35-2e40-4539-aa55-24dfb7489661"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b0eeca35-2e40-4539-aa55-24dfb7489661"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b0eeca35-2e40-4539-aa55-24dfb7489661"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b0eeca35-2e40-4539-aa55-24dfb7489661"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b0eeca35-2e40-4539-aa55-24dfb7489661"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b87fe551-c466-4065-b15e-ea95dffda5d6"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b87fe551-c466-4065-b15e-ea95dffda5d6"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("b87fe551-c466-4065-b15e-ea95dffda5d6"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("be8b9003-9f48-4059-9cc9-3854c4b8f262"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("be8b9003-9f48-4059-9cc9-3854c4b8f262"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("be8b9003-9f48-4059-9cc9-3854c4b8f262"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c1b8f116-ffdb-4acc-98c1-f3c9398d6338"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c1b8f116-ffdb-4acc-98c1-f3c9398d6338"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c1b8f116-ffdb-4acc-98c1-f3c9398d6338"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c1b8f116-ffdb-4acc-98c1-f3c9398d6338"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c1b8f116-ffdb-4acc-98c1-f3c9398d6338"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c1b8f116-ffdb-4acc-98c1-f3c9398d6338"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c1b8f116-ffdb-4acc-98c1-f3c9398d6338"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c1b8f116-ffdb-4acc-98c1-f3c9398d6338"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c1b8f116-ffdb-4acc-98c1-f3c9398d6338"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c1b8f116-ffdb-4acc-98c1-f3c9398d6338"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c406416b-55fc-4dd5-98d9-a91f2f175911"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c406416b-55fc-4dd5-98d9-a91f2f175911"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c406416b-55fc-4dd5-98d9-a91f2f175911"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c406416b-55fc-4dd5-98d9-a91f2f175911"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c406416b-55fc-4dd5-98d9-a91f2f175911"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c406416b-55fc-4dd5-98d9-a91f2f175911"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c406416b-55fc-4dd5-98d9-a91f2f175911"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c406416b-55fc-4dd5-98d9-a91f2f175911"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c406416b-55fc-4dd5-98d9-a91f2f175911"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c406416b-55fc-4dd5-98d9-a91f2f175911"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c5aeb840-ed0e-42fb-a872-fb50e3cbd9ca"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c5aeb840-ed0e-42fb-a872-fb50e3cbd9ca"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c5aeb840-ed0e-42fb-a872-fb50e3cbd9ca"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c5aeb840-ed0e-42fb-a872-fb50e3cbd9ca"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c5aeb840-ed0e-42fb-a872-fb50e3cbd9ca"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ce34c610-9033-4d53-8c93-97ff1fb573e4"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ce34c610-9033-4d53-8c93-97ff1fb573e4"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ce34c610-9033-4d53-8c93-97ff1fb573e4"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d12c03cc-46d5-4cd7-81bc-10bd8d80c5ce"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d12c03cc-46d5-4cd7-81bc-10bd8d80c5ce"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d12c03cc-46d5-4cd7-81bc-10bd8d80c5ce"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f196825e-fd50-4385-ab38-286b5c910f7d"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f196825e-fd50-4385-ab38-286b5c910f7d"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f196825e-fd50-4385-ab38-286b5c910f7d"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f196825e-fd50-4385-ab38-286b5c910f7d"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f196825e-fd50-4385-ab38-286b5c910f7d"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fb29d0e9-95c7-4a00-bece-95d07d2ed80a"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fb29d0e9-95c7-4a00-bece-95d07d2ed80a"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fb29d0e9-95c7-4a00-bece-95d07d2ed80a"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fb29d0e9-95c7-4a00-bece-95d07d2ed80a"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fb29d0e9-95c7-4a00-bece-95d07d2ed80a"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fcb5e54b-fd12-486e-bebd-c6dcbee7d933"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fcb5e54b-fd12-486e-bebd-c6dcbee7d933"), new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fcb5e54b-fd12-486e-bebd-c6dcbee7d933"), new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fcb5e54b-fd12-486e-bebd-c6dcbee7d933"), new Guid("40720596-5246-4cf3-815a-77373be4fbe8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fcb5e54b-fd12-486e-bebd-c6dcbee7d933"), new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fcb5e54b-fd12-486e-bebd-c6dcbee7d933"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fcb5e54b-fd12-486e-bebd-c6dcbee7d933"), new Guid("a59150be-53c9-4134-b5ac-5044e249f323") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fcb5e54b-fd12-486e-bebd-c6dcbee7d933"), new Guid("c2d7472d-3857-4e06-89ac-756cecc47691") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fcb5e54b-fd12-486e-bebd-c6dcbee7d933"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fcb5e54b-fd12-486e-bebd-c6dcbee7d933"), new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fceed037-1f24-456c-8d72-2e3591448d7f"), new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fceed037-1f24-456c-8d72-2e3591448d7f"), new Guid("9bb64b66-4b50-48ad-8721-c84df442c136") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fceed037-1f24-456c-8d72-2e3591448d7f"), new Guid("c58f351d-5651-467f-a227-706dff5cb5d8") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("011768f8-e4be-4182-8b82-9502db9033a1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0b727d38-e3cf-457b-ae2d-f26e92c45c1a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0d99f934-b3c0-4f3b-85f8-139be3381753"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("15865c3a-02b0-43fb-9d71-467afb3d5c30"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("18ac9f5d-bb06-495b-ba97-3d4c613fce9e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("29f06a8a-f868-4cd0-99bd-3d4f6775e4f1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2a16f132-4948-4b65-bfe1-99803c9c6541"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("32981713-ae9c-49c8-924d-6fa017f49734"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("345ffcfd-968e-449a-a77e-7e08e2363792"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("40b2b972-de1c-4b02-850a-3424af1116d5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("445f0a35-0705-490c-b3dd-e229f8b1821f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4684eb9b-d9ae-4034-b9d5-7b3f269e0bbc"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4a7f937d-fe0a-4ce5-ad08-9feaae803bd6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4cacaabe-0158-4ef8-8d59-1efbf552fd44"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4d9c49fc-b8d5-4821-b4d6-7a0b89b9905f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4f5f0870-45e9-464e-b70c-6a5334adc9a9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("52b315c5-f028-479b-9cd6-18d234638cee"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("576fe3ab-f6eb-4324-ad6f-b08de29536da"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5b274e82-26ac-430c-adc5-1b0f94e37d7c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5d4d3909-90e3-4bee-b1c6-cb1823473233"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5dd1280a-ca32-4171-9b5b-be9abb256a49"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("654a8323-3ae2-4be7-915d-3b3c856bcb08"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6909f2a0-6697-46b3-8ed2-472bbdc208c7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("775765c3-e0e0-4585-bfb6-1d019a007e2a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7941e0c4-52b9-4d8f-b0fe-86abc45f10ba"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7954b31f-bd0a-4130-a66e-db108c9634ab"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7bdd4ac0-f974-4b44-8c8a-57c43e86df14"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("89b472f0-38dd-41e3-865a-478666d149f1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("956df0d2-0f2a-4d6c-af89-ee8575c73a7e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9c56e718-5095-4229-8425-2ebb28db3e33"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9cba7fdc-b617-42d3-b155-ba8f6b7c1156"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("aa0d6bfd-0e96-41e3-a5f6-47f6a0f0a161"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b0eeca35-2e40-4539-aa55-24dfb7489661"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b87fe551-c466-4065-b15e-ea95dffda5d6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("be8b9003-9f48-4059-9cc9-3854c4b8f262"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c1b8f116-ffdb-4acc-98c1-f3c9398d6338"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c406416b-55fc-4dd5-98d9-a91f2f175911"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c5aeb840-ed0e-42fb-a872-fb50e3cbd9ca"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ce34c610-9033-4d53-8c93-97ff1fb573e4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d12c03cc-46d5-4cd7-81bc-10bd8d80c5ce"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f196825e-fd50-4385-ab38-286b5c910f7d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fb29d0e9-95c7-4a00-bece-95d07d2ed80a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fcb5e54b-fd12-486e-bebd-c6dcbee7d933"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fceed037-1f24-456c-8d72-2e3591448d7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23dcdf66-bb81-45bc-ad8b-c9ee3003c6e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d3a99ef-99cf-45b8-98da-89b6f559bcb5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3188817e-0db9-4a36-8f2e-5891f2e30868"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40720596-5246-4cf3-815a-77373be4fbe8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88144533-c39d-4e05-8cb6-68a38b3ab367"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9bb64b66-4b50-48ad-8721-c84df442c136"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a59150be-53c9-4134-b5ac-5044e249f323"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2d7472d-3857-4e06-89ac-756cecc47691"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c58f351d-5651-467f-a227-706dff5cb5d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d26f5a2b-e460-4c8f-ba55-551a4a4d38ff"));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("037c66d9-1471-4535-b52b-3a81ec3df990"), "hardwareoff-home" },
                    { new Guid("07ef5066-f870-4e1a-aa5b-f3d52d2fa76b"), "addnotificationmembers-members" },
                    { new Guid("0c9ae47f-33b7-4101-a436-949b142418c7"), "changeprofilephoto-user" },
                    { new Guid("0d84da76-acc1-4b2f-9a04-32168f348427"), "off-smartlamp" },
                    { new Guid("11bf9897-1b7d-4875-a640-abb5521b90a3"), "getdevices-home" },
                    { new Guid("12e9b8b5-b5b1-4cd9-bad2-bb994096e15b"), "getpermissions-home" },
                    { new Guid("18c13610-ff61-4323-93f3-abfc838dfc63"), "getnotifications-notification" },
                    { new Guid("1a69363c-2814-4173-ac8c-252f94e16982"), "on-smartlamp" },
                    { new Guid("1f40e8c4-c109-412d-9cbf-177ff1806026"), "getcompany-companies" },
                    { new Guid("22df0f5c-382b-4d40-8ca6-441893ce4d7b"), "createadminaccount-administrator" },
                    { new Guid("24249199-c042-4f04-9620-48455cbb0129"), "motiondetection-camera" },
                    { new Guid("28ef49a4-aa49-4e39-a8b4-7ebf11af1bd4"), "addmotionsensor-motionsensor" },
                    { new Guid("3133b598-55ee-4d36-95ee-8dc6260a6a0a"), "addsensor-windowsensor" },
                    { new Guid("39bfe67b-c017-4a19-b482-87dd82bf9727"), "selectdevicemodelvalidator-devices" },
                    { new Guid("43a53e05-b748-4aac-af09-4fe46f3b953f"), "close-windowsensor" },
                    { new Guid("48a6d683-cb3c-4b2d-bd70-615b2acf6a42"), "getdevices-devices" },
                    { new Guid("4c452cdd-8262-41ae-92af-25c14ac08a14"), "getmembers-members" },
                    { new Guid("4e6feba6-5d28-4d40-bd97-1b5bb4f01a66"), "addpermission-members" },
                    { new Guid("5328b100-93a8-4922-9b46-6dbf318848cf"), "getrooms-home" },
                    { new Guid("57c3c5e5-4381-48bc-b6c2-38f327ced4a3"), "addmotionsensor-motionsensor" },
                    { new Guid("61dbdcb4-d309-45e9-885c-641ce0b17328"), "getaccounts-accounts" },
                    { new Guid("63552d65-0cda-4856-9fce-c1ff3c921f80"), "adddevice-home" },
                    { new Guid("6bdfa048-bedb-4ca9-8d61-df560261e286"), "getcompanyuser-companies" },
                    { new Guid("6e7b18dd-4625-43e5-b5e6-cc9728c8652a"), "getdevicemodelvalidators-devices" },
                    { new Guid("72b0fa48-2ded-43b7-81a2-7d580abc5cfe"), "addrooms-home" },
                    { new Guid("84488c13-3e05-453f-b6a4-73384cfbe27e"), "newhome-home" },
                    { new Guid("ac86ae8d-4bd2-4878-8920-04890c719188"), "deleteadminaccount-administrator" },
                    { new Guid("adac8613-7d94-44e7-ba29-76be7b93fb11"), "getimporters-devices" },
                    { new Guid("b07221c5-7d35-4569-8886-4870b7c0cce5"), "hardwareon-home" },
                    { new Guid("b62f2571-4299-4553-8752-34278caaa162"), "createcompany-companies" },
                    { new Guid("bca86634-fe68-448d-9bac-3ef08ce32dd0"), "getdevicetypes-devicetype" },
                    { new Guid("c0124da2-01e6-46be-8cca-171b3ae684a0"), "addhomeownerpermission-homeowner" },
                    { new Guid("c1cf2c39-6d72-44fa-afaa-4fe1ca27122c"), "importdevices-devices" },
                    { new Guid("cc4cf805-ffd2-4e69-948c-74ff7221a224"), "addsmartlamp-smartlamp" },
                    { new Guid("ced383bc-ee7c-46f1-8d39-1aa435753dd5"), "updateroomdevice-home" },
                    { new Guid("cfc0a1cb-d1d9-4b46-a6e4-5e7aeac0f0a8"), "updatenamedevice-home" },
                    { new Guid("d7f46b06-431d-45ce-855c-3d53368169b0"), "open-windowsensor" },
                    { new Guid("e123668e-85d4-4205-a4ed-6d496e136359"), "createcompanyowneraccount-companyowner" },
                    { new Guid("e26487ed-ef9a-43e9-a766-00bd8bb9086b"), "persondetection-camera" },
                    { new Guid("e6618466-3e0a-40b5-822b-16536a331eea"), "addmember-members" },
                    { new Guid("efa11f5f-7733-4cc8-aa62-3f17ba98df9f"), "addcamera-camera" },
                    { new Guid("f0703ff3-f267-438c-9be4-0d0c9f0c0662"), "gethomes-user" },
                    { new Guid("f2f92d0f-9513-4a83-8292-29a120c23a6f"), "addhomeownerpermission-homeowner" },
                    { new Guid("f99b8f27-f250-46e0-8922-72186e4837aa"), "motiondetection-motionsensor" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Password", "ProfilePhoto", "Roles", "Surname" },
                values: new object[,]
                {
                    { new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b"), new DateTime(2024, 11, 18, 17, 40, 16, 868, DateTimeKind.Local).AddTicks(5076), "novakdjokovic@tennis.com", "Novak", "Djokovic@123", "djokovic.jpg", "[2,1]", "Djokovic" },
                    { new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee"), new DateTime(2024, 11, 18, 17, 40, 16, 868, DateTimeKind.Local).AddTicks(5088), "martinanavratilova@tennis.com", "Martina", "Navratilova@123", "navratilova.jpg", "[1]", "Navratilova" },
                    { new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a"), new DateTime(2024, 11, 18, 17, 40, 16, 868, DateTimeKind.Local).AddTicks(5051), "rogerfederer@tennis.com", "Roger", "Federer@123", "federer.jpg", "[0]", "Federer" },
                    { new Guid("4bf83703-9660-48e4-90f7-84334fa12e64"), new DateTime(2024, 11, 18, 17, 40, 16, 868, DateTimeKind.Local).AddTicks(5080), "steffigraf@tennis.com", "Steffi", "Steffi@123", "graf.jpg", "[1]", "Graf" },
                    { new Guid("682c0db7-4027-476d-baae-9776cc20e455"), new DateTime(2024, 11, 18, 17, 40, 16, 868, DateTimeKind.Local).AddTicks(5093), "billiejeanking@tennis.com", "Billie", "King@123", "king.jpg", "[0]", "Jean King" },
                    { new Guid("8c39e161-120c-4112-9eb3-120671e7dacf"), new DateTime(2024, 11, 18, 17, 40, 16, 868, DateTimeKind.Local).AddTicks(5090), "johnmcenroe@tennis.com", "John", "McEnroe@123", "mcenroe.jpg", "[2]", "McEnroe" },
                    { new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68"), new DateTime(2024, 11, 18, 17, 40, 16, 868, DateTimeKind.Local).AddTicks(5083), "andreagassi@tennis.com", "Andre", "Agassi@123", "agassi.jpg", "[1]", "Agassi" },
                    { new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c"), new DateTime(2024, 11, 18, 17, 40, 16, 868, DateTimeKind.Local).AddTicks(5086), "petesampras@tennis.com", "Pete", "Sampras@123", "sampras.jpg", "[1]", "Sampras" },
                    { new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15"), new DateTime(2024, 11, 18, 17, 40, 16, 868, DateTimeKind.Local).AddTicks(5069), "rafaelnadal@tennis.com", "Rafael", "Nadal@123", "nadal.jpg", "[0]", "Nadal" },
                    { new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba"), new DateTime(2024, 11, 18, 17, 40, 16, 868, DateTimeKind.Local).AddTicks(5072), "serenawilliams@tennis.com", "Serena", "Serena@123", "serena.jpg", "[2]", "Williams" }
                });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "PermissionId", "UserId" },
                values: new object[,]
                {
                    { new Guid("037c66d9-1471-4535-b52b-3a81ec3df990"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("037c66d9-1471-4535-b52b-3a81ec3df990"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("037c66d9-1471-4535-b52b-3a81ec3df990"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("037c66d9-1471-4535-b52b-3a81ec3df990"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("037c66d9-1471-4535-b52b-3a81ec3df990"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("07ef5066-f870-4e1a-aa5b-f3d52d2fa76b"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("07ef5066-f870-4e1a-aa5b-f3d52d2fa76b"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("07ef5066-f870-4e1a-aa5b-f3d52d2fa76b"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("07ef5066-f870-4e1a-aa5b-f3d52d2fa76b"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("07ef5066-f870-4e1a-aa5b-f3d52d2fa76b"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("0c9ae47f-33b7-4101-a436-949b142418c7"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("0c9ae47f-33b7-4101-a436-949b142418c7"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("0c9ae47f-33b7-4101-a436-949b142418c7"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("0c9ae47f-33b7-4101-a436-949b142418c7"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("0c9ae47f-33b7-4101-a436-949b142418c7"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("0c9ae47f-33b7-4101-a436-949b142418c7"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") },
                    { new Guid("0c9ae47f-33b7-4101-a436-949b142418c7"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("0c9ae47f-33b7-4101-a436-949b142418c7"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("0c9ae47f-33b7-4101-a436-949b142418c7"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("0c9ae47f-33b7-4101-a436-949b142418c7"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") },
                    { new Guid("0d84da76-acc1-4b2f-9a04-32168f348427"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("0d84da76-acc1-4b2f-9a04-32168f348427"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("0d84da76-acc1-4b2f-9a04-32168f348427"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("0d84da76-acc1-4b2f-9a04-32168f348427"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("0d84da76-acc1-4b2f-9a04-32168f348427"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("0d84da76-acc1-4b2f-9a04-32168f348427"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") },
                    { new Guid("0d84da76-acc1-4b2f-9a04-32168f348427"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("0d84da76-acc1-4b2f-9a04-32168f348427"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("0d84da76-acc1-4b2f-9a04-32168f348427"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("0d84da76-acc1-4b2f-9a04-32168f348427"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") },
                    { new Guid("11bf9897-1b7d-4875-a640-abb5521b90a3"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("11bf9897-1b7d-4875-a640-abb5521b90a3"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("11bf9897-1b7d-4875-a640-abb5521b90a3"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("11bf9897-1b7d-4875-a640-abb5521b90a3"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("11bf9897-1b7d-4875-a640-abb5521b90a3"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("12e9b8b5-b5b1-4cd9-bad2-bb994096e15b"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("12e9b8b5-b5b1-4cd9-bad2-bb994096e15b"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("12e9b8b5-b5b1-4cd9-bad2-bb994096e15b"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("12e9b8b5-b5b1-4cd9-bad2-bb994096e15b"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("12e9b8b5-b5b1-4cd9-bad2-bb994096e15b"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("12e9b8b5-b5b1-4cd9-bad2-bb994096e15b"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") },
                    { new Guid("12e9b8b5-b5b1-4cd9-bad2-bb994096e15b"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("12e9b8b5-b5b1-4cd9-bad2-bb994096e15b"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("12e9b8b5-b5b1-4cd9-bad2-bb994096e15b"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("12e9b8b5-b5b1-4cd9-bad2-bb994096e15b"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") },
                    { new Guid("18c13610-ff61-4323-93f3-abfc838dfc63"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("18c13610-ff61-4323-93f3-abfc838dfc63"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("18c13610-ff61-4323-93f3-abfc838dfc63"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("18c13610-ff61-4323-93f3-abfc838dfc63"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("18c13610-ff61-4323-93f3-abfc838dfc63"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("18c13610-ff61-4323-93f3-abfc838dfc63"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") },
                    { new Guid("18c13610-ff61-4323-93f3-abfc838dfc63"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("18c13610-ff61-4323-93f3-abfc838dfc63"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("18c13610-ff61-4323-93f3-abfc838dfc63"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("18c13610-ff61-4323-93f3-abfc838dfc63"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") },
                    { new Guid("1a69363c-2814-4173-ac8c-252f94e16982"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("1a69363c-2814-4173-ac8c-252f94e16982"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("1a69363c-2814-4173-ac8c-252f94e16982"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("1a69363c-2814-4173-ac8c-252f94e16982"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("1a69363c-2814-4173-ac8c-252f94e16982"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("1a69363c-2814-4173-ac8c-252f94e16982"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") },
                    { new Guid("1a69363c-2814-4173-ac8c-252f94e16982"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("1a69363c-2814-4173-ac8c-252f94e16982"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("1a69363c-2814-4173-ac8c-252f94e16982"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("1a69363c-2814-4173-ac8c-252f94e16982"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") },
                    { new Guid("1f40e8c4-c109-412d-9cbf-177ff1806026"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("1f40e8c4-c109-412d-9cbf-177ff1806026"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") },
                    { new Guid("1f40e8c4-c109-412d-9cbf-177ff1806026"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") },
                    { new Guid("22df0f5c-382b-4d40-8ca6-441893ce4d7b"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("22df0f5c-382b-4d40-8ca6-441893ce4d7b"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") },
                    { new Guid("22df0f5c-382b-4d40-8ca6-441893ce4d7b"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") },
                    { new Guid("24249199-c042-4f04-9620-48455cbb0129"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("24249199-c042-4f04-9620-48455cbb0129"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("24249199-c042-4f04-9620-48455cbb0129"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("24249199-c042-4f04-9620-48455cbb0129"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("24249199-c042-4f04-9620-48455cbb0129"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("24249199-c042-4f04-9620-48455cbb0129"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") },
                    { new Guid("24249199-c042-4f04-9620-48455cbb0129"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("24249199-c042-4f04-9620-48455cbb0129"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("24249199-c042-4f04-9620-48455cbb0129"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("24249199-c042-4f04-9620-48455cbb0129"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") },
                    { new Guid("28ef49a4-aa49-4e39-a8b4-7ebf11af1bd4"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("28ef49a4-aa49-4e39-a8b4-7ebf11af1bd4"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("28ef49a4-aa49-4e39-a8b4-7ebf11af1bd4"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("28ef49a4-aa49-4e39-a8b4-7ebf11af1bd4"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("28ef49a4-aa49-4e39-a8b4-7ebf11af1bd4"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("3133b598-55ee-4d36-95ee-8dc6260a6a0a"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("3133b598-55ee-4d36-95ee-8dc6260a6a0a"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("3133b598-55ee-4d36-95ee-8dc6260a6a0a"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("39bfe67b-c017-4a19-b482-87dd82bf9727"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("39bfe67b-c017-4a19-b482-87dd82bf9727"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("39bfe67b-c017-4a19-b482-87dd82bf9727"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("43a53e05-b748-4aac-af09-4fe46f3b953f"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("43a53e05-b748-4aac-af09-4fe46f3b953f"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("43a53e05-b748-4aac-af09-4fe46f3b953f"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("43a53e05-b748-4aac-af09-4fe46f3b953f"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("43a53e05-b748-4aac-af09-4fe46f3b953f"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("43a53e05-b748-4aac-af09-4fe46f3b953f"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") },
                    { new Guid("43a53e05-b748-4aac-af09-4fe46f3b953f"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("43a53e05-b748-4aac-af09-4fe46f3b953f"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("43a53e05-b748-4aac-af09-4fe46f3b953f"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("43a53e05-b748-4aac-af09-4fe46f3b953f"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") },
                    { new Guid("48a6d683-cb3c-4b2d-bd70-615b2acf6a42"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("48a6d683-cb3c-4b2d-bd70-615b2acf6a42"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("48a6d683-cb3c-4b2d-bd70-615b2acf6a42"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("48a6d683-cb3c-4b2d-bd70-615b2acf6a42"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("48a6d683-cb3c-4b2d-bd70-615b2acf6a42"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("48a6d683-cb3c-4b2d-bd70-615b2acf6a42"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") },
                    { new Guid("48a6d683-cb3c-4b2d-bd70-615b2acf6a42"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("48a6d683-cb3c-4b2d-bd70-615b2acf6a42"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("48a6d683-cb3c-4b2d-bd70-615b2acf6a42"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("48a6d683-cb3c-4b2d-bd70-615b2acf6a42"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") },
                    { new Guid("4c452cdd-8262-41ae-92af-25c14ac08a14"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("4c452cdd-8262-41ae-92af-25c14ac08a14"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("4c452cdd-8262-41ae-92af-25c14ac08a14"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("4c452cdd-8262-41ae-92af-25c14ac08a14"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("4c452cdd-8262-41ae-92af-25c14ac08a14"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("4e6feba6-5d28-4d40-bd97-1b5bb4f01a66"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("4e6feba6-5d28-4d40-bd97-1b5bb4f01a66"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("4e6feba6-5d28-4d40-bd97-1b5bb4f01a66"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("4e6feba6-5d28-4d40-bd97-1b5bb4f01a66"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("4e6feba6-5d28-4d40-bd97-1b5bb4f01a66"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("5328b100-93a8-4922-9b46-6dbf318848cf"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("5328b100-93a8-4922-9b46-6dbf318848cf"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("5328b100-93a8-4922-9b46-6dbf318848cf"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("5328b100-93a8-4922-9b46-6dbf318848cf"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("5328b100-93a8-4922-9b46-6dbf318848cf"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("57c3c5e5-4381-48bc-b6c2-38f327ced4a3"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("57c3c5e5-4381-48bc-b6c2-38f327ced4a3"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("57c3c5e5-4381-48bc-b6c2-38f327ced4a3"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("61dbdcb4-d309-45e9-885c-641ce0b17328"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("61dbdcb4-d309-45e9-885c-641ce0b17328"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") },
                    { new Guid("61dbdcb4-d309-45e9-885c-641ce0b17328"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") },
                    { new Guid("63552d65-0cda-4856-9fce-c1ff3c921f80"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("63552d65-0cda-4856-9fce-c1ff3c921f80"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("63552d65-0cda-4856-9fce-c1ff3c921f80"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("63552d65-0cda-4856-9fce-c1ff3c921f80"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("63552d65-0cda-4856-9fce-c1ff3c921f80"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("6bdfa048-bedb-4ca9-8d61-df560261e286"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("6bdfa048-bedb-4ca9-8d61-df560261e286"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("6bdfa048-bedb-4ca9-8d61-df560261e286"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("6e7b18dd-4625-43e5-b5e6-cc9728c8652a"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("6e7b18dd-4625-43e5-b5e6-cc9728c8652a"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("6e7b18dd-4625-43e5-b5e6-cc9728c8652a"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("72b0fa48-2ded-43b7-81a2-7d580abc5cfe"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("72b0fa48-2ded-43b7-81a2-7d580abc5cfe"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("72b0fa48-2ded-43b7-81a2-7d580abc5cfe"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("72b0fa48-2ded-43b7-81a2-7d580abc5cfe"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("72b0fa48-2ded-43b7-81a2-7d580abc5cfe"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("84488c13-3e05-453f-b6a4-73384cfbe27e"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("84488c13-3e05-453f-b6a4-73384cfbe27e"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("84488c13-3e05-453f-b6a4-73384cfbe27e"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("84488c13-3e05-453f-b6a4-73384cfbe27e"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("84488c13-3e05-453f-b6a4-73384cfbe27e"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("ac86ae8d-4bd2-4878-8920-04890c719188"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("ac86ae8d-4bd2-4878-8920-04890c719188"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") },
                    { new Guid("ac86ae8d-4bd2-4878-8920-04890c719188"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") },
                    { new Guid("adac8613-7d94-44e7-ba29-76be7b93fb11"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("adac8613-7d94-44e7-ba29-76be7b93fb11"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("adac8613-7d94-44e7-ba29-76be7b93fb11"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("b07221c5-7d35-4569-8886-4870b7c0cce5"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("b07221c5-7d35-4569-8886-4870b7c0cce5"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("b07221c5-7d35-4569-8886-4870b7c0cce5"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("b07221c5-7d35-4569-8886-4870b7c0cce5"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("b07221c5-7d35-4569-8886-4870b7c0cce5"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("b62f2571-4299-4553-8752-34278caaa162"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("b62f2571-4299-4553-8752-34278caaa162"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("b62f2571-4299-4553-8752-34278caaa162"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("bca86634-fe68-448d-9bac-3ef08ce32dd0"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("bca86634-fe68-448d-9bac-3ef08ce32dd0"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("bca86634-fe68-448d-9bac-3ef08ce32dd0"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("bca86634-fe68-448d-9bac-3ef08ce32dd0"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("bca86634-fe68-448d-9bac-3ef08ce32dd0"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("bca86634-fe68-448d-9bac-3ef08ce32dd0"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") },
                    { new Guid("bca86634-fe68-448d-9bac-3ef08ce32dd0"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("bca86634-fe68-448d-9bac-3ef08ce32dd0"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("bca86634-fe68-448d-9bac-3ef08ce32dd0"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("bca86634-fe68-448d-9bac-3ef08ce32dd0"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") },
                    { new Guid("c0124da2-01e6-46be-8cca-171b3ae684a0"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("c0124da2-01e6-46be-8cca-171b3ae684a0"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("c0124da2-01e6-46be-8cca-171b3ae684a0"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("c1cf2c39-6d72-44fa-afaa-4fe1ca27122c"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("c1cf2c39-6d72-44fa-afaa-4fe1ca27122c"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("c1cf2c39-6d72-44fa-afaa-4fe1ca27122c"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("cc4cf805-ffd2-4e69-948c-74ff7221a224"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("cc4cf805-ffd2-4e69-948c-74ff7221a224"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("cc4cf805-ffd2-4e69-948c-74ff7221a224"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("ced383bc-ee7c-46f1-8d39-1aa435753dd5"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("ced383bc-ee7c-46f1-8d39-1aa435753dd5"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("ced383bc-ee7c-46f1-8d39-1aa435753dd5"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("ced383bc-ee7c-46f1-8d39-1aa435753dd5"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("ced383bc-ee7c-46f1-8d39-1aa435753dd5"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("cfc0a1cb-d1d9-4b46-a6e4-5e7aeac0f0a8"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("cfc0a1cb-d1d9-4b46-a6e4-5e7aeac0f0a8"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("cfc0a1cb-d1d9-4b46-a6e4-5e7aeac0f0a8"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("cfc0a1cb-d1d9-4b46-a6e4-5e7aeac0f0a8"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("cfc0a1cb-d1d9-4b46-a6e4-5e7aeac0f0a8"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("d7f46b06-431d-45ce-855c-3d53368169b0"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("d7f46b06-431d-45ce-855c-3d53368169b0"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("d7f46b06-431d-45ce-855c-3d53368169b0"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("d7f46b06-431d-45ce-855c-3d53368169b0"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("d7f46b06-431d-45ce-855c-3d53368169b0"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("d7f46b06-431d-45ce-855c-3d53368169b0"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") },
                    { new Guid("d7f46b06-431d-45ce-855c-3d53368169b0"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("d7f46b06-431d-45ce-855c-3d53368169b0"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("d7f46b06-431d-45ce-855c-3d53368169b0"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("d7f46b06-431d-45ce-855c-3d53368169b0"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") },
                    { new Guid("e123668e-85d4-4205-a4ed-6d496e136359"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("e123668e-85d4-4205-a4ed-6d496e136359"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") },
                    { new Guid("e123668e-85d4-4205-a4ed-6d496e136359"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") },
                    { new Guid("e26487ed-ef9a-43e9-a766-00bd8bb9086b"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("e26487ed-ef9a-43e9-a766-00bd8bb9086b"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("e26487ed-ef9a-43e9-a766-00bd8bb9086b"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("e26487ed-ef9a-43e9-a766-00bd8bb9086b"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("e26487ed-ef9a-43e9-a766-00bd8bb9086b"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("e26487ed-ef9a-43e9-a766-00bd8bb9086b"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") },
                    { new Guid("e26487ed-ef9a-43e9-a766-00bd8bb9086b"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("e26487ed-ef9a-43e9-a766-00bd8bb9086b"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("e26487ed-ef9a-43e9-a766-00bd8bb9086b"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("e26487ed-ef9a-43e9-a766-00bd8bb9086b"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") },
                    { new Guid("e6618466-3e0a-40b5-822b-16536a331eea"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("e6618466-3e0a-40b5-822b-16536a331eea"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("e6618466-3e0a-40b5-822b-16536a331eea"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("e6618466-3e0a-40b5-822b-16536a331eea"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("e6618466-3e0a-40b5-822b-16536a331eea"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("efa11f5f-7733-4cc8-aa62-3f17ba98df9f"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("efa11f5f-7733-4cc8-aa62-3f17ba98df9f"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("efa11f5f-7733-4cc8-aa62-3f17ba98df9f"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("f0703ff3-f267-438c-9be4-0d0c9f0c0662"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("f0703ff3-f267-438c-9be4-0d0c9f0c0662"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("f0703ff3-f267-438c-9be4-0d0c9f0c0662"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("f0703ff3-f267-438c-9be4-0d0c9f0c0662"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("f0703ff3-f267-438c-9be4-0d0c9f0c0662"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("f2f92d0f-9513-4a83-8292-29a120c23a6f"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("f2f92d0f-9513-4a83-8292-29a120c23a6f"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") },
                    { new Guid("f2f92d0f-9513-4a83-8292-29a120c23a6f"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") },
                    { new Guid("f99b8f27-f250-46e0-8922-72186e4837aa"), new Guid("0ebb6a94-5ad9-449f-a322-4ad51b86ed0b") },
                    { new Guid("f99b8f27-f250-46e0-8922-72186e4837aa"), new Guid("1b2ed4ab-33c7-4aaa-9018-ff4ab9d061ee") },
                    { new Guid("f99b8f27-f250-46e0-8922-72186e4837aa"), new Guid("1e3c732b-35a3-49c5-94e7-32ba4bbed70a") },
                    { new Guid("f99b8f27-f250-46e0-8922-72186e4837aa"), new Guid("4bf83703-9660-48e4-90f7-84334fa12e64") },
                    { new Guid("f99b8f27-f250-46e0-8922-72186e4837aa"), new Guid("682c0db7-4027-476d-baae-9776cc20e455") },
                    { new Guid("f99b8f27-f250-46e0-8922-72186e4837aa"), new Guid("8c39e161-120c-4112-9eb3-120671e7dacf") },
                    { new Guid("f99b8f27-f250-46e0-8922-72186e4837aa"), new Guid("8cd54ccc-57af-41e6-a42b-8cefc9ca1a68") },
                    { new Guid("f99b8f27-f250-46e0-8922-72186e4837aa"), new Guid("ce5d5b72-ccd7-4f55-a00f-f38322d6487c") },
                    { new Guid("f99b8f27-f250-46e0-8922-72186e4837aa"), new Guid("dddae90e-c0a4-4a65-af44-a7d0442f9f15") },
                    { new Guid("f99b8f27-f250-46e0-8922-72186e4837aa"), new Guid("f0b7429b-b5e6-4dbd-8a6c-3664fa8705ba") }
                });
        }
    }
}
