using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHub.DB.Migrations
{
    /// <inheritdoc />
    public partial class NewPermissionsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
