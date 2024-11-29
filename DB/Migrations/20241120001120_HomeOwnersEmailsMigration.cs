using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHub.DB.Migrations
{
    /// <inheritdoc />
    public partial class HomeOwnersEmailsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("04603270-e8cf-48f4-966f-483114014a83"), "getmembers-members" },
                    { new Guid("0f7a0114-9a12-42fe-a399-a520c3a65277"), "createadminaccount-administrator" },
                    { new Guid("12820da8-75ea-49a1-91be-c0d67c0fdc92"), "addmotionsensor-motionsensor" },
                    { new Guid("1354ce65-3b81-402d-8ae4-ad0c23f90319"), "close-windowsensor" },
                    { new Guid("24722452-1c8f-44dc-a774-29662f830a1c"), "motiondetection-camera" },
                    { new Guid("262de929-8869-4fd9-9253-f32c793f7181"), "getimporters-devices" },
                    { new Guid("26877838-dd57-4f09-b6d4-2261a08a34d1"), "createcompany-companies" },
                    { new Guid("304c930b-80a1-4173-9b81-a6507baffdca"), "addhomeownerpermission-homeowner" },
                    { new Guid("31c6bbe5-b6fc-461b-8064-8466cc30edda"), "addrooms-home" },
                    { new Guid("3521dd35-ea94-45bb-9667-e82c41fde500"), "addmember-members" },
                    { new Guid("356d5d69-0c68-42f0-b6d6-ce5e3aaff476"), "hardwareoff-home" },
                    { new Guid("415701aa-e116-45df-90b9-b05a450aef76"), "deleteadminaccount-administrator" },
                    { new Guid("449b2d9c-13a8-4181-918f-c433aba9a31e"), "getdevicetypes-devicetype" },
                    { new Guid("44e3c6b9-d578-4e5f-b301-ea301d4b0f69"), "getdevicemodelvalidators-devices" },
                    { new Guid("451c7559-a9bc-4f9b-a5d7-a875f71ab1d4"), "addhomeownerpermission-homeowner" },
                    { new Guid("4850dc4d-24e0-483b-867a-2e9550673693"), "addsensor-windowsensor" },
                    { new Guid("502613bc-3e86-44bb-97c3-c49a527e8a7c"), "getaccounts-accounts" },
                    { new Guid("5d05da11-16d7-4104-a12a-58e7e3612dfe"), "selectdevicemodelvalidator-devices" },
                    { new Guid("5dae2bda-a5a1-491d-b507-d9c8d03d3362"), "getdevices-devices" },
                    { new Guid("5ef555d4-e624-4553-bdf4-a7d5ff63805f"), "addnotificationmembers-members" },
                    { new Guid("64ae915c-2f94-45fd-99da-924e3b89e493"), "getemails-homeowner" },
                    { new Guid("6d49bda8-5eb3-4b4b-869b-2ac3f00ce46f"), "open-windowsensor" },
                    { new Guid("6fbba37b-4697-46cf-a5b3-b08fa991a99e"), "getdevices-home" },
                    { new Guid("768ae801-0b6c-4fd3-9a93-9b763dc2a9ed"), "persondetection-camera" },
                    { new Guid("89d79cbc-b40f-4b69-96ee-b0498d836161"), "add-home" },
                    { new Guid("8c24112a-f38a-4f67-86cb-42ffeeef5fed"), "getrooms-home" },
                    { new Guid("8ec22417-5beb-44b1-9bbe-febad0430534"), "updatenamedevice-home" },
                    { new Guid("91f1057e-d2b2-4533-bf24-e051516de3d2"), "getnotifications-notification" },
                    { new Guid("967cc6f9-b339-490e-ad57-aa00289d1a0d"), "adddevice-home" },
                    { new Guid("9770ba43-6c25-4f05-a385-5f5207c5e761"), "addcamera-camera" },
                    { new Guid("97d501b8-dc19-4acc-a803-d540008c6677"), "gethomes-user" },
                    { new Guid("982a9aac-562e-41cd-bfb5-c94e868b3658"), "importdevices-devices" },
                    { new Guid("9a1749ad-33f4-47db-b195-ccc192e17b90"), "getcompanyuser-companies" },
                    { new Guid("a7f466b5-ebe9-4cc3-ae38-5cf5138cdfa7"), "addpermission-members" },
                    { new Guid("a9747acc-ca58-4fd4-92e0-ecd6a677460b"), "off-smartlamp" },
                    { new Guid("aa3def3d-cb66-4564-af5f-09cc5b16d8a5"), "changeprofilephoto-user" },
                    { new Guid("cb786a19-af5d-4a8f-9493-3f37374a9d49"), "updateroomdevice-home" },
                    { new Guid("d47a53e0-4398-4b5a-a0c9-d114683e0410"), "getcompany-companies" },
                    { new Guid("e20b504a-ad05-434b-b52f-698e30733514"), "hardwareon-home" },
                    { new Guid("e3390a2f-3c7e-4d2f-be10-1b67d1100966"), "on-smartlamp" },
                    { new Guid("ed912fbb-2376-4f7f-9566-172e963bd3ec"), "motiondetection-motionsensor" },
                    { new Guid("fa7cb5a5-27ce-4ccf-b645-d839ce09c069"), "getpermissions-home" },
                    { new Guid("fc58828a-ee37-49e5-abde-f3687c76abca"), "addsmartlamp-smartlamp" },
                    { new Guid("fceaa714-7611-472c-a217-372f7b8e7a38"), "createcompanyowneraccount-companyowner" },
                    { new Guid("fdda725c-c831-4462-8d4b-36272c07d014"), "addmotionsensor-motionsensor" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Password", "ProfilePhoto", "Roles", "Surname" },
                values: new object[,]
                {
                    { new Guid("05b0e602-312e-4267-b724-051ab635aaf1"), new DateTime(2024, 11, 19, 21, 11, 20, 15, DateTimeKind.Local).AddTicks(3159), "rogerfederer@tennis.com", "Roger", "Federer@123", "federer.jpg", "[0]", "Federer" },
                    { new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989"), new DateTime(2024, 11, 19, 21, 11, 20, 15, DateTimeKind.Local).AddTicks(3187), "serenawilliams@tennis.com", "Serena", "Serena@123", "serena.jpg", "[2]", "Williams" },
                    { new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb"), new DateTime(2024, 11, 19, 21, 11, 20, 15, DateTimeKind.Local).AddTicks(3182), "rafaelnadal@tennis.com", "Rafael", "Nadal@123", "nadal.jpg", "[0]", "Nadal" },
                    { new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21"), new DateTime(2024, 11, 19, 21, 11, 20, 15, DateTimeKind.Local).AddTicks(3199), "andreagassi@tennis.com", "Andre", "Agassi@123", "agassi.jpg", "[1]", "Agassi" },
                    { new Guid("8c044b16-3cf7-4034-8af7-36abea323904"), new DateTime(2024, 11, 19, 21, 11, 20, 15, DateTimeKind.Local).AddTicks(3195), "steffigraf@tennis.com", "Steffi", "Steffi@123", "graf.jpg", "[1]", "Graf" },
                    { new Guid("9b478d24-b208-43d3-95a1-9fda925518cd"), new DateTime(2024, 11, 19, 21, 11, 20, 15, DateTimeKind.Local).AddTicks(3192), "novakdjokovic@tennis.com", "Novak", "Djokovic@123", "djokovic.jpg", "[2,1]", "Djokovic" },
                    { new Guid("b0ca2349-7897-4f6d-b510-70b95da79054"), new DateTime(2024, 11, 19, 21, 11, 20, 15, DateTimeKind.Local).AddTicks(3204), "martinanavratilova@tennis.com", "Martina", "Navratilova@123", "navratilova.jpg", "[1]", "Navratilova" },
                    { new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043"), new DateTime(2024, 11, 19, 21, 11, 20, 15, DateTimeKind.Local).AddTicks(3207), "johnmcenroe@tennis.com", "John", "McEnroe@123", "mcenroe.jpg", "[2]", "McEnroe" },
                    { new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8"), new DateTime(2024, 11, 19, 21, 11, 20, 15, DateTimeKind.Local).AddTicks(3202), "petesampras@tennis.com", "Pete", "Sampras@123", "sampras.jpg", "[1]", "Sampras" },
                    { new Guid("e1f56202-af27-47a5-a009-9c917fb95932"), new DateTime(2024, 11, 19, 21, 11, 20, 15, DateTimeKind.Local).AddTicks(3212), "billiejeanking@tennis.com", "Billie", "King@123", "king.jpg", "[0]", "Jean King" }
                });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "PermissionId", "UserId" },
                values: new object[,]
                {
                    { new Guid("04603270-e8cf-48f4-966f-483114014a83"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("04603270-e8cf-48f4-966f-483114014a83"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("04603270-e8cf-48f4-966f-483114014a83"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("04603270-e8cf-48f4-966f-483114014a83"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("04603270-e8cf-48f4-966f-483114014a83"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("0f7a0114-9a12-42fe-a399-a520c3a65277"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") },
                    { new Guid("0f7a0114-9a12-42fe-a399-a520c3a65277"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("0f7a0114-9a12-42fe-a399-a520c3a65277"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") },
                    { new Guid("12820da8-75ea-49a1-91be-c0d67c0fdc92"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("12820da8-75ea-49a1-91be-c0d67c0fdc92"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("12820da8-75ea-49a1-91be-c0d67c0fdc92"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("12820da8-75ea-49a1-91be-c0d67c0fdc92"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("12820da8-75ea-49a1-91be-c0d67c0fdc92"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("1354ce65-3b81-402d-8ae4-ad0c23f90319"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("1354ce65-3b81-402d-8ae4-ad0c23f90319"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") },
                    { new Guid("1354ce65-3b81-402d-8ae4-ad0c23f90319"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("1354ce65-3b81-402d-8ae4-ad0c23f90319"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("1354ce65-3b81-402d-8ae4-ad0c23f90319"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("1354ce65-3b81-402d-8ae4-ad0c23f90319"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("1354ce65-3b81-402d-8ae4-ad0c23f90319"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("1354ce65-3b81-402d-8ae4-ad0c23f90319"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") },
                    { new Guid("1354ce65-3b81-402d-8ae4-ad0c23f90319"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("1354ce65-3b81-402d-8ae4-ad0c23f90319"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") },
                    { new Guid("24722452-1c8f-44dc-a774-29662f830a1c"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("24722452-1c8f-44dc-a774-29662f830a1c"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") },
                    { new Guid("24722452-1c8f-44dc-a774-29662f830a1c"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("24722452-1c8f-44dc-a774-29662f830a1c"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("24722452-1c8f-44dc-a774-29662f830a1c"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("24722452-1c8f-44dc-a774-29662f830a1c"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("24722452-1c8f-44dc-a774-29662f830a1c"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("24722452-1c8f-44dc-a774-29662f830a1c"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") },
                    { new Guid("24722452-1c8f-44dc-a774-29662f830a1c"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("24722452-1c8f-44dc-a774-29662f830a1c"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") },
                    { new Guid("262de929-8869-4fd9-9253-f32c793f7181"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("262de929-8869-4fd9-9253-f32c793f7181"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("262de929-8869-4fd9-9253-f32c793f7181"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") },
                    { new Guid("26877838-dd57-4f09-b6d4-2261a08a34d1"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("26877838-dd57-4f09-b6d4-2261a08a34d1"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("26877838-dd57-4f09-b6d4-2261a08a34d1"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") },
                    { new Guid("304c930b-80a1-4173-9b81-a6507baffdca"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("304c930b-80a1-4173-9b81-a6507baffdca"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("304c930b-80a1-4173-9b81-a6507baffdca"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") },
                    { new Guid("31c6bbe5-b6fc-461b-8064-8466cc30edda"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("31c6bbe5-b6fc-461b-8064-8466cc30edda"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("31c6bbe5-b6fc-461b-8064-8466cc30edda"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("31c6bbe5-b6fc-461b-8064-8466cc30edda"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("31c6bbe5-b6fc-461b-8064-8466cc30edda"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("3521dd35-ea94-45bb-9667-e82c41fde500"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("3521dd35-ea94-45bb-9667-e82c41fde500"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("3521dd35-ea94-45bb-9667-e82c41fde500"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("3521dd35-ea94-45bb-9667-e82c41fde500"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("3521dd35-ea94-45bb-9667-e82c41fde500"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("356d5d69-0c68-42f0-b6d6-ce5e3aaff476"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("356d5d69-0c68-42f0-b6d6-ce5e3aaff476"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("356d5d69-0c68-42f0-b6d6-ce5e3aaff476"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("356d5d69-0c68-42f0-b6d6-ce5e3aaff476"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("356d5d69-0c68-42f0-b6d6-ce5e3aaff476"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("415701aa-e116-45df-90b9-b05a450aef76"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") },
                    { new Guid("415701aa-e116-45df-90b9-b05a450aef76"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("415701aa-e116-45df-90b9-b05a450aef76"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") },
                    { new Guid("449b2d9c-13a8-4181-918f-c433aba9a31e"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("449b2d9c-13a8-4181-918f-c433aba9a31e"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") },
                    { new Guid("449b2d9c-13a8-4181-918f-c433aba9a31e"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("449b2d9c-13a8-4181-918f-c433aba9a31e"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("449b2d9c-13a8-4181-918f-c433aba9a31e"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("449b2d9c-13a8-4181-918f-c433aba9a31e"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("449b2d9c-13a8-4181-918f-c433aba9a31e"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("449b2d9c-13a8-4181-918f-c433aba9a31e"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") },
                    { new Guid("449b2d9c-13a8-4181-918f-c433aba9a31e"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("449b2d9c-13a8-4181-918f-c433aba9a31e"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") },
                    { new Guid("44e3c6b9-d578-4e5f-b301-ea301d4b0f69"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("44e3c6b9-d578-4e5f-b301-ea301d4b0f69"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("44e3c6b9-d578-4e5f-b301-ea301d4b0f69"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") },
                    { new Guid("451c7559-a9bc-4f9b-a5d7-a875f71ab1d4"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") },
                    { new Guid("451c7559-a9bc-4f9b-a5d7-a875f71ab1d4"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("451c7559-a9bc-4f9b-a5d7-a875f71ab1d4"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") },
                    { new Guid("4850dc4d-24e0-483b-867a-2e9550673693"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("4850dc4d-24e0-483b-867a-2e9550673693"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("4850dc4d-24e0-483b-867a-2e9550673693"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") },
                    { new Guid("502613bc-3e86-44bb-97c3-c49a527e8a7c"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") },
                    { new Guid("502613bc-3e86-44bb-97c3-c49a527e8a7c"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("502613bc-3e86-44bb-97c3-c49a527e8a7c"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") },
                    { new Guid("5d05da11-16d7-4104-a12a-58e7e3612dfe"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("5d05da11-16d7-4104-a12a-58e7e3612dfe"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("5d05da11-16d7-4104-a12a-58e7e3612dfe"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") },
                    { new Guid("5dae2bda-a5a1-491d-b507-d9c8d03d3362"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("5dae2bda-a5a1-491d-b507-d9c8d03d3362"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") },
                    { new Guid("5dae2bda-a5a1-491d-b507-d9c8d03d3362"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("5dae2bda-a5a1-491d-b507-d9c8d03d3362"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("5dae2bda-a5a1-491d-b507-d9c8d03d3362"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("5dae2bda-a5a1-491d-b507-d9c8d03d3362"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("5dae2bda-a5a1-491d-b507-d9c8d03d3362"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("5dae2bda-a5a1-491d-b507-d9c8d03d3362"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") },
                    { new Guid("5dae2bda-a5a1-491d-b507-d9c8d03d3362"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("5dae2bda-a5a1-491d-b507-d9c8d03d3362"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") },
                    { new Guid("5ef555d4-e624-4553-bdf4-a7d5ff63805f"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("5ef555d4-e624-4553-bdf4-a7d5ff63805f"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("5ef555d4-e624-4553-bdf4-a7d5ff63805f"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("5ef555d4-e624-4553-bdf4-a7d5ff63805f"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("5ef555d4-e624-4553-bdf4-a7d5ff63805f"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("64ae915c-2f94-45fd-99da-924e3b89e493"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("64ae915c-2f94-45fd-99da-924e3b89e493"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("64ae915c-2f94-45fd-99da-924e3b89e493"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("64ae915c-2f94-45fd-99da-924e3b89e493"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("64ae915c-2f94-45fd-99da-924e3b89e493"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("6d49bda8-5eb3-4b4b-869b-2ac3f00ce46f"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("6d49bda8-5eb3-4b4b-869b-2ac3f00ce46f"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") },
                    { new Guid("6d49bda8-5eb3-4b4b-869b-2ac3f00ce46f"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("6d49bda8-5eb3-4b4b-869b-2ac3f00ce46f"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("6d49bda8-5eb3-4b4b-869b-2ac3f00ce46f"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("6d49bda8-5eb3-4b4b-869b-2ac3f00ce46f"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("6d49bda8-5eb3-4b4b-869b-2ac3f00ce46f"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("6d49bda8-5eb3-4b4b-869b-2ac3f00ce46f"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") },
                    { new Guid("6d49bda8-5eb3-4b4b-869b-2ac3f00ce46f"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("6d49bda8-5eb3-4b4b-869b-2ac3f00ce46f"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") },
                    { new Guid("6fbba37b-4697-46cf-a5b3-b08fa991a99e"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("6fbba37b-4697-46cf-a5b3-b08fa991a99e"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("6fbba37b-4697-46cf-a5b3-b08fa991a99e"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("6fbba37b-4697-46cf-a5b3-b08fa991a99e"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("6fbba37b-4697-46cf-a5b3-b08fa991a99e"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("768ae801-0b6c-4fd3-9a93-9b763dc2a9ed"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("768ae801-0b6c-4fd3-9a93-9b763dc2a9ed"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") },
                    { new Guid("768ae801-0b6c-4fd3-9a93-9b763dc2a9ed"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("768ae801-0b6c-4fd3-9a93-9b763dc2a9ed"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("768ae801-0b6c-4fd3-9a93-9b763dc2a9ed"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("768ae801-0b6c-4fd3-9a93-9b763dc2a9ed"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("768ae801-0b6c-4fd3-9a93-9b763dc2a9ed"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("768ae801-0b6c-4fd3-9a93-9b763dc2a9ed"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") },
                    { new Guid("768ae801-0b6c-4fd3-9a93-9b763dc2a9ed"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("768ae801-0b6c-4fd3-9a93-9b763dc2a9ed"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") },
                    { new Guid("89d79cbc-b40f-4b69-96ee-b0498d836161"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("89d79cbc-b40f-4b69-96ee-b0498d836161"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("89d79cbc-b40f-4b69-96ee-b0498d836161"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("89d79cbc-b40f-4b69-96ee-b0498d836161"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("89d79cbc-b40f-4b69-96ee-b0498d836161"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("8c24112a-f38a-4f67-86cb-42ffeeef5fed"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("8c24112a-f38a-4f67-86cb-42ffeeef5fed"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("8c24112a-f38a-4f67-86cb-42ffeeef5fed"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("8c24112a-f38a-4f67-86cb-42ffeeef5fed"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("8c24112a-f38a-4f67-86cb-42ffeeef5fed"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("8ec22417-5beb-44b1-9bbe-febad0430534"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("8ec22417-5beb-44b1-9bbe-febad0430534"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("8ec22417-5beb-44b1-9bbe-febad0430534"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("8ec22417-5beb-44b1-9bbe-febad0430534"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("8ec22417-5beb-44b1-9bbe-febad0430534"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("91f1057e-d2b2-4533-bf24-e051516de3d2"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("91f1057e-d2b2-4533-bf24-e051516de3d2"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") },
                    { new Guid("91f1057e-d2b2-4533-bf24-e051516de3d2"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("91f1057e-d2b2-4533-bf24-e051516de3d2"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("91f1057e-d2b2-4533-bf24-e051516de3d2"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("91f1057e-d2b2-4533-bf24-e051516de3d2"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("91f1057e-d2b2-4533-bf24-e051516de3d2"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("91f1057e-d2b2-4533-bf24-e051516de3d2"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") },
                    { new Guid("91f1057e-d2b2-4533-bf24-e051516de3d2"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("91f1057e-d2b2-4533-bf24-e051516de3d2"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") },
                    { new Guid("967cc6f9-b339-490e-ad57-aa00289d1a0d"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("967cc6f9-b339-490e-ad57-aa00289d1a0d"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("967cc6f9-b339-490e-ad57-aa00289d1a0d"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("967cc6f9-b339-490e-ad57-aa00289d1a0d"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("967cc6f9-b339-490e-ad57-aa00289d1a0d"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("9770ba43-6c25-4f05-a385-5f5207c5e761"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("9770ba43-6c25-4f05-a385-5f5207c5e761"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("9770ba43-6c25-4f05-a385-5f5207c5e761"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") },
                    { new Guid("97d501b8-dc19-4acc-a803-d540008c6677"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("97d501b8-dc19-4acc-a803-d540008c6677"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("97d501b8-dc19-4acc-a803-d540008c6677"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("97d501b8-dc19-4acc-a803-d540008c6677"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("97d501b8-dc19-4acc-a803-d540008c6677"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("982a9aac-562e-41cd-bfb5-c94e868b3658"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("982a9aac-562e-41cd-bfb5-c94e868b3658"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("982a9aac-562e-41cd-bfb5-c94e868b3658"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") },
                    { new Guid("9a1749ad-33f4-47db-b195-ccc192e17b90"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("9a1749ad-33f4-47db-b195-ccc192e17b90"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("9a1749ad-33f4-47db-b195-ccc192e17b90"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") },
                    { new Guid("a7f466b5-ebe9-4cc3-ae38-5cf5138cdfa7"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("a7f466b5-ebe9-4cc3-ae38-5cf5138cdfa7"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("a7f466b5-ebe9-4cc3-ae38-5cf5138cdfa7"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("a7f466b5-ebe9-4cc3-ae38-5cf5138cdfa7"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("a7f466b5-ebe9-4cc3-ae38-5cf5138cdfa7"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("a9747acc-ca58-4fd4-92e0-ecd6a677460b"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("a9747acc-ca58-4fd4-92e0-ecd6a677460b"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") },
                    { new Guid("a9747acc-ca58-4fd4-92e0-ecd6a677460b"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("a9747acc-ca58-4fd4-92e0-ecd6a677460b"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("a9747acc-ca58-4fd4-92e0-ecd6a677460b"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("a9747acc-ca58-4fd4-92e0-ecd6a677460b"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("a9747acc-ca58-4fd4-92e0-ecd6a677460b"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("a9747acc-ca58-4fd4-92e0-ecd6a677460b"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") },
                    { new Guid("a9747acc-ca58-4fd4-92e0-ecd6a677460b"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("a9747acc-ca58-4fd4-92e0-ecd6a677460b"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") },
                    { new Guid("aa3def3d-cb66-4564-af5f-09cc5b16d8a5"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("aa3def3d-cb66-4564-af5f-09cc5b16d8a5"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") },
                    { new Guid("aa3def3d-cb66-4564-af5f-09cc5b16d8a5"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("aa3def3d-cb66-4564-af5f-09cc5b16d8a5"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("aa3def3d-cb66-4564-af5f-09cc5b16d8a5"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("aa3def3d-cb66-4564-af5f-09cc5b16d8a5"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("aa3def3d-cb66-4564-af5f-09cc5b16d8a5"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("aa3def3d-cb66-4564-af5f-09cc5b16d8a5"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") },
                    { new Guid("aa3def3d-cb66-4564-af5f-09cc5b16d8a5"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("aa3def3d-cb66-4564-af5f-09cc5b16d8a5"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") },
                    { new Guid("cb786a19-af5d-4a8f-9493-3f37374a9d49"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("cb786a19-af5d-4a8f-9493-3f37374a9d49"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("cb786a19-af5d-4a8f-9493-3f37374a9d49"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("cb786a19-af5d-4a8f-9493-3f37374a9d49"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("cb786a19-af5d-4a8f-9493-3f37374a9d49"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("d47a53e0-4398-4b5a-a0c9-d114683e0410"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") },
                    { new Guid("d47a53e0-4398-4b5a-a0c9-d114683e0410"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("d47a53e0-4398-4b5a-a0c9-d114683e0410"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") },
                    { new Guid("e20b504a-ad05-434b-b52f-698e30733514"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("e20b504a-ad05-434b-b52f-698e30733514"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("e20b504a-ad05-434b-b52f-698e30733514"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("e20b504a-ad05-434b-b52f-698e30733514"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("e20b504a-ad05-434b-b52f-698e30733514"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("e3390a2f-3c7e-4d2f-be10-1b67d1100966"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("e3390a2f-3c7e-4d2f-be10-1b67d1100966"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") },
                    { new Guid("e3390a2f-3c7e-4d2f-be10-1b67d1100966"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("e3390a2f-3c7e-4d2f-be10-1b67d1100966"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("e3390a2f-3c7e-4d2f-be10-1b67d1100966"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("e3390a2f-3c7e-4d2f-be10-1b67d1100966"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("e3390a2f-3c7e-4d2f-be10-1b67d1100966"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("e3390a2f-3c7e-4d2f-be10-1b67d1100966"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") },
                    { new Guid("e3390a2f-3c7e-4d2f-be10-1b67d1100966"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("e3390a2f-3c7e-4d2f-be10-1b67d1100966"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") },
                    { new Guid("ed912fbb-2376-4f7f-9566-172e963bd3ec"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("ed912fbb-2376-4f7f-9566-172e963bd3ec"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") },
                    { new Guid("ed912fbb-2376-4f7f-9566-172e963bd3ec"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("ed912fbb-2376-4f7f-9566-172e963bd3ec"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("ed912fbb-2376-4f7f-9566-172e963bd3ec"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("ed912fbb-2376-4f7f-9566-172e963bd3ec"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("ed912fbb-2376-4f7f-9566-172e963bd3ec"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("ed912fbb-2376-4f7f-9566-172e963bd3ec"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") },
                    { new Guid("ed912fbb-2376-4f7f-9566-172e963bd3ec"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("ed912fbb-2376-4f7f-9566-172e963bd3ec"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") },
                    { new Guid("fa7cb5a5-27ce-4ccf-b645-d839ce09c069"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("fa7cb5a5-27ce-4ccf-b645-d839ce09c069"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") },
                    { new Guid("fa7cb5a5-27ce-4ccf-b645-d839ce09c069"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("fa7cb5a5-27ce-4ccf-b645-d839ce09c069"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") },
                    { new Guid("fa7cb5a5-27ce-4ccf-b645-d839ce09c069"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") },
                    { new Guid("fa7cb5a5-27ce-4ccf-b645-d839ce09c069"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("fa7cb5a5-27ce-4ccf-b645-d839ce09c069"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") },
                    { new Guid("fa7cb5a5-27ce-4ccf-b645-d839ce09c069"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") },
                    { new Guid("fa7cb5a5-27ce-4ccf-b645-d839ce09c069"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") },
                    { new Guid("fa7cb5a5-27ce-4ccf-b645-d839ce09c069"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") },
                    { new Guid("fc58828a-ee37-49e5-abde-f3687c76abca"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("fc58828a-ee37-49e5-abde-f3687c76abca"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("fc58828a-ee37-49e5-abde-f3687c76abca"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") },
                    { new Guid("fceaa714-7611-472c-a217-372f7b8e7a38"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") },
                    { new Guid("fceaa714-7611-472c-a217-372f7b8e7a38"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") },
                    { new Guid("fceaa714-7611-472c-a217-372f7b8e7a38"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") },
                    { new Guid("fdda725c-c831-4462-8d4b-36272c07d014"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") },
                    { new Guid("fdda725c-c831-4462-8d4b-36272c07d014"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") },
                    { new Guid("fdda725c-c831-4462-8d4b-36272c07d014"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("04603270-e8cf-48f4-966f-483114014a83"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("04603270-e8cf-48f4-966f-483114014a83"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("04603270-e8cf-48f4-966f-483114014a83"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("04603270-e8cf-48f4-966f-483114014a83"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("04603270-e8cf-48f4-966f-483114014a83"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0f7a0114-9a12-42fe-a399-a520c3a65277"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0f7a0114-9a12-42fe-a399-a520c3a65277"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0f7a0114-9a12-42fe-a399-a520c3a65277"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("12820da8-75ea-49a1-91be-c0d67c0fdc92"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("12820da8-75ea-49a1-91be-c0d67c0fdc92"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("12820da8-75ea-49a1-91be-c0d67c0fdc92"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("12820da8-75ea-49a1-91be-c0d67c0fdc92"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("12820da8-75ea-49a1-91be-c0d67c0fdc92"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1354ce65-3b81-402d-8ae4-ad0c23f90319"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1354ce65-3b81-402d-8ae4-ad0c23f90319"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1354ce65-3b81-402d-8ae4-ad0c23f90319"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1354ce65-3b81-402d-8ae4-ad0c23f90319"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1354ce65-3b81-402d-8ae4-ad0c23f90319"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1354ce65-3b81-402d-8ae4-ad0c23f90319"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1354ce65-3b81-402d-8ae4-ad0c23f90319"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1354ce65-3b81-402d-8ae4-ad0c23f90319"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1354ce65-3b81-402d-8ae4-ad0c23f90319"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1354ce65-3b81-402d-8ae4-ad0c23f90319"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("24722452-1c8f-44dc-a774-29662f830a1c"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("24722452-1c8f-44dc-a774-29662f830a1c"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("24722452-1c8f-44dc-a774-29662f830a1c"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("24722452-1c8f-44dc-a774-29662f830a1c"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("24722452-1c8f-44dc-a774-29662f830a1c"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("24722452-1c8f-44dc-a774-29662f830a1c"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("24722452-1c8f-44dc-a774-29662f830a1c"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("24722452-1c8f-44dc-a774-29662f830a1c"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("24722452-1c8f-44dc-a774-29662f830a1c"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("24722452-1c8f-44dc-a774-29662f830a1c"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("262de929-8869-4fd9-9253-f32c793f7181"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("262de929-8869-4fd9-9253-f32c793f7181"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("262de929-8869-4fd9-9253-f32c793f7181"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("26877838-dd57-4f09-b6d4-2261a08a34d1"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("26877838-dd57-4f09-b6d4-2261a08a34d1"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("26877838-dd57-4f09-b6d4-2261a08a34d1"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("304c930b-80a1-4173-9b81-a6507baffdca"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("304c930b-80a1-4173-9b81-a6507baffdca"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("304c930b-80a1-4173-9b81-a6507baffdca"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("31c6bbe5-b6fc-461b-8064-8466cc30edda"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("31c6bbe5-b6fc-461b-8064-8466cc30edda"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("31c6bbe5-b6fc-461b-8064-8466cc30edda"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("31c6bbe5-b6fc-461b-8064-8466cc30edda"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("31c6bbe5-b6fc-461b-8064-8466cc30edda"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3521dd35-ea94-45bb-9667-e82c41fde500"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3521dd35-ea94-45bb-9667-e82c41fde500"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3521dd35-ea94-45bb-9667-e82c41fde500"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3521dd35-ea94-45bb-9667-e82c41fde500"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("3521dd35-ea94-45bb-9667-e82c41fde500"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("356d5d69-0c68-42f0-b6d6-ce5e3aaff476"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("356d5d69-0c68-42f0-b6d6-ce5e3aaff476"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("356d5d69-0c68-42f0-b6d6-ce5e3aaff476"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("356d5d69-0c68-42f0-b6d6-ce5e3aaff476"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("356d5d69-0c68-42f0-b6d6-ce5e3aaff476"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("415701aa-e116-45df-90b9-b05a450aef76"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("415701aa-e116-45df-90b9-b05a450aef76"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("415701aa-e116-45df-90b9-b05a450aef76"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("449b2d9c-13a8-4181-918f-c433aba9a31e"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("449b2d9c-13a8-4181-918f-c433aba9a31e"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("449b2d9c-13a8-4181-918f-c433aba9a31e"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("449b2d9c-13a8-4181-918f-c433aba9a31e"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("449b2d9c-13a8-4181-918f-c433aba9a31e"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("449b2d9c-13a8-4181-918f-c433aba9a31e"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("449b2d9c-13a8-4181-918f-c433aba9a31e"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("449b2d9c-13a8-4181-918f-c433aba9a31e"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("449b2d9c-13a8-4181-918f-c433aba9a31e"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("449b2d9c-13a8-4181-918f-c433aba9a31e"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("44e3c6b9-d578-4e5f-b301-ea301d4b0f69"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("44e3c6b9-d578-4e5f-b301-ea301d4b0f69"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("44e3c6b9-d578-4e5f-b301-ea301d4b0f69"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("451c7559-a9bc-4f9b-a5d7-a875f71ab1d4"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("451c7559-a9bc-4f9b-a5d7-a875f71ab1d4"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("451c7559-a9bc-4f9b-a5d7-a875f71ab1d4"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4850dc4d-24e0-483b-867a-2e9550673693"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4850dc4d-24e0-483b-867a-2e9550673693"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4850dc4d-24e0-483b-867a-2e9550673693"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("502613bc-3e86-44bb-97c3-c49a527e8a7c"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("502613bc-3e86-44bb-97c3-c49a527e8a7c"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("502613bc-3e86-44bb-97c3-c49a527e8a7c"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5d05da11-16d7-4104-a12a-58e7e3612dfe"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5d05da11-16d7-4104-a12a-58e7e3612dfe"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5d05da11-16d7-4104-a12a-58e7e3612dfe"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5dae2bda-a5a1-491d-b507-d9c8d03d3362"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5dae2bda-a5a1-491d-b507-d9c8d03d3362"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5dae2bda-a5a1-491d-b507-d9c8d03d3362"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5dae2bda-a5a1-491d-b507-d9c8d03d3362"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5dae2bda-a5a1-491d-b507-d9c8d03d3362"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5dae2bda-a5a1-491d-b507-d9c8d03d3362"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5dae2bda-a5a1-491d-b507-d9c8d03d3362"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5dae2bda-a5a1-491d-b507-d9c8d03d3362"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5dae2bda-a5a1-491d-b507-d9c8d03d3362"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5dae2bda-a5a1-491d-b507-d9c8d03d3362"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ef555d4-e624-4553-bdf4-a7d5ff63805f"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ef555d4-e624-4553-bdf4-a7d5ff63805f"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ef555d4-e624-4553-bdf4-a7d5ff63805f"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ef555d4-e624-4553-bdf4-a7d5ff63805f"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ef555d4-e624-4553-bdf4-a7d5ff63805f"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("64ae915c-2f94-45fd-99da-924e3b89e493"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("64ae915c-2f94-45fd-99da-924e3b89e493"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("64ae915c-2f94-45fd-99da-924e3b89e493"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("64ae915c-2f94-45fd-99da-924e3b89e493"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("64ae915c-2f94-45fd-99da-924e3b89e493"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6d49bda8-5eb3-4b4b-869b-2ac3f00ce46f"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6d49bda8-5eb3-4b4b-869b-2ac3f00ce46f"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6d49bda8-5eb3-4b4b-869b-2ac3f00ce46f"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6d49bda8-5eb3-4b4b-869b-2ac3f00ce46f"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6d49bda8-5eb3-4b4b-869b-2ac3f00ce46f"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6d49bda8-5eb3-4b4b-869b-2ac3f00ce46f"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6d49bda8-5eb3-4b4b-869b-2ac3f00ce46f"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6d49bda8-5eb3-4b4b-869b-2ac3f00ce46f"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6d49bda8-5eb3-4b4b-869b-2ac3f00ce46f"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6d49bda8-5eb3-4b4b-869b-2ac3f00ce46f"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6fbba37b-4697-46cf-a5b3-b08fa991a99e"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6fbba37b-4697-46cf-a5b3-b08fa991a99e"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6fbba37b-4697-46cf-a5b3-b08fa991a99e"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6fbba37b-4697-46cf-a5b3-b08fa991a99e"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("6fbba37b-4697-46cf-a5b3-b08fa991a99e"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("768ae801-0b6c-4fd3-9a93-9b763dc2a9ed"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("768ae801-0b6c-4fd3-9a93-9b763dc2a9ed"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("768ae801-0b6c-4fd3-9a93-9b763dc2a9ed"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("768ae801-0b6c-4fd3-9a93-9b763dc2a9ed"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("768ae801-0b6c-4fd3-9a93-9b763dc2a9ed"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("768ae801-0b6c-4fd3-9a93-9b763dc2a9ed"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("768ae801-0b6c-4fd3-9a93-9b763dc2a9ed"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("768ae801-0b6c-4fd3-9a93-9b763dc2a9ed"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("768ae801-0b6c-4fd3-9a93-9b763dc2a9ed"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("768ae801-0b6c-4fd3-9a93-9b763dc2a9ed"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("89d79cbc-b40f-4b69-96ee-b0498d836161"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("89d79cbc-b40f-4b69-96ee-b0498d836161"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("89d79cbc-b40f-4b69-96ee-b0498d836161"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("89d79cbc-b40f-4b69-96ee-b0498d836161"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("89d79cbc-b40f-4b69-96ee-b0498d836161"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8c24112a-f38a-4f67-86cb-42ffeeef5fed"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8c24112a-f38a-4f67-86cb-42ffeeef5fed"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8c24112a-f38a-4f67-86cb-42ffeeef5fed"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8c24112a-f38a-4f67-86cb-42ffeeef5fed"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8c24112a-f38a-4f67-86cb-42ffeeef5fed"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8ec22417-5beb-44b1-9bbe-febad0430534"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8ec22417-5beb-44b1-9bbe-febad0430534"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8ec22417-5beb-44b1-9bbe-febad0430534"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8ec22417-5beb-44b1-9bbe-febad0430534"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8ec22417-5beb-44b1-9bbe-febad0430534"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("91f1057e-d2b2-4533-bf24-e051516de3d2"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("91f1057e-d2b2-4533-bf24-e051516de3d2"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("91f1057e-d2b2-4533-bf24-e051516de3d2"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("91f1057e-d2b2-4533-bf24-e051516de3d2"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("91f1057e-d2b2-4533-bf24-e051516de3d2"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("91f1057e-d2b2-4533-bf24-e051516de3d2"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("91f1057e-d2b2-4533-bf24-e051516de3d2"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("91f1057e-d2b2-4533-bf24-e051516de3d2"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("91f1057e-d2b2-4533-bf24-e051516de3d2"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("91f1057e-d2b2-4533-bf24-e051516de3d2"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("967cc6f9-b339-490e-ad57-aa00289d1a0d"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("967cc6f9-b339-490e-ad57-aa00289d1a0d"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("967cc6f9-b339-490e-ad57-aa00289d1a0d"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("967cc6f9-b339-490e-ad57-aa00289d1a0d"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("967cc6f9-b339-490e-ad57-aa00289d1a0d"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9770ba43-6c25-4f05-a385-5f5207c5e761"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9770ba43-6c25-4f05-a385-5f5207c5e761"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9770ba43-6c25-4f05-a385-5f5207c5e761"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("97d501b8-dc19-4acc-a803-d540008c6677"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("97d501b8-dc19-4acc-a803-d540008c6677"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("97d501b8-dc19-4acc-a803-d540008c6677"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("97d501b8-dc19-4acc-a803-d540008c6677"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("97d501b8-dc19-4acc-a803-d540008c6677"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("982a9aac-562e-41cd-bfb5-c94e868b3658"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("982a9aac-562e-41cd-bfb5-c94e868b3658"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("982a9aac-562e-41cd-bfb5-c94e868b3658"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9a1749ad-33f4-47db-b195-ccc192e17b90"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9a1749ad-33f4-47db-b195-ccc192e17b90"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9a1749ad-33f4-47db-b195-ccc192e17b90"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a7f466b5-ebe9-4cc3-ae38-5cf5138cdfa7"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a7f466b5-ebe9-4cc3-ae38-5cf5138cdfa7"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a7f466b5-ebe9-4cc3-ae38-5cf5138cdfa7"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a7f466b5-ebe9-4cc3-ae38-5cf5138cdfa7"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a7f466b5-ebe9-4cc3-ae38-5cf5138cdfa7"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a9747acc-ca58-4fd4-92e0-ecd6a677460b"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a9747acc-ca58-4fd4-92e0-ecd6a677460b"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a9747acc-ca58-4fd4-92e0-ecd6a677460b"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a9747acc-ca58-4fd4-92e0-ecd6a677460b"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a9747acc-ca58-4fd4-92e0-ecd6a677460b"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a9747acc-ca58-4fd4-92e0-ecd6a677460b"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a9747acc-ca58-4fd4-92e0-ecd6a677460b"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a9747acc-ca58-4fd4-92e0-ecd6a677460b"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a9747acc-ca58-4fd4-92e0-ecd6a677460b"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a9747acc-ca58-4fd4-92e0-ecd6a677460b"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa3def3d-cb66-4564-af5f-09cc5b16d8a5"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa3def3d-cb66-4564-af5f-09cc5b16d8a5"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa3def3d-cb66-4564-af5f-09cc5b16d8a5"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa3def3d-cb66-4564-af5f-09cc5b16d8a5"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa3def3d-cb66-4564-af5f-09cc5b16d8a5"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa3def3d-cb66-4564-af5f-09cc5b16d8a5"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa3def3d-cb66-4564-af5f-09cc5b16d8a5"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa3def3d-cb66-4564-af5f-09cc5b16d8a5"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa3def3d-cb66-4564-af5f-09cc5b16d8a5"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa3def3d-cb66-4564-af5f-09cc5b16d8a5"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cb786a19-af5d-4a8f-9493-3f37374a9d49"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cb786a19-af5d-4a8f-9493-3f37374a9d49"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cb786a19-af5d-4a8f-9493-3f37374a9d49"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cb786a19-af5d-4a8f-9493-3f37374a9d49"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("cb786a19-af5d-4a8f-9493-3f37374a9d49"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d47a53e0-4398-4b5a-a0c9-d114683e0410"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d47a53e0-4398-4b5a-a0c9-d114683e0410"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d47a53e0-4398-4b5a-a0c9-d114683e0410"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e20b504a-ad05-434b-b52f-698e30733514"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e20b504a-ad05-434b-b52f-698e30733514"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e20b504a-ad05-434b-b52f-698e30733514"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e20b504a-ad05-434b-b52f-698e30733514"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e20b504a-ad05-434b-b52f-698e30733514"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e3390a2f-3c7e-4d2f-be10-1b67d1100966"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e3390a2f-3c7e-4d2f-be10-1b67d1100966"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e3390a2f-3c7e-4d2f-be10-1b67d1100966"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e3390a2f-3c7e-4d2f-be10-1b67d1100966"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e3390a2f-3c7e-4d2f-be10-1b67d1100966"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e3390a2f-3c7e-4d2f-be10-1b67d1100966"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e3390a2f-3c7e-4d2f-be10-1b67d1100966"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e3390a2f-3c7e-4d2f-be10-1b67d1100966"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e3390a2f-3c7e-4d2f-be10-1b67d1100966"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e3390a2f-3c7e-4d2f-be10-1b67d1100966"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ed912fbb-2376-4f7f-9566-172e963bd3ec"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ed912fbb-2376-4f7f-9566-172e963bd3ec"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ed912fbb-2376-4f7f-9566-172e963bd3ec"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ed912fbb-2376-4f7f-9566-172e963bd3ec"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ed912fbb-2376-4f7f-9566-172e963bd3ec"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ed912fbb-2376-4f7f-9566-172e963bd3ec"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ed912fbb-2376-4f7f-9566-172e963bd3ec"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ed912fbb-2376-4f7f-9566-172e963bd3ec"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ed912fbb-2376-4f7f-9566-172e963bd3ec"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ed912fbb-2376-4f7f-9566-172e963bd3ec"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fa7cb5a5-27ce-4ccf-b645-d839ce09c069"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fa7cb5a5-27ce-4ccf-b645-d839ce09c069"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fa7cb5a5-27ce-4ccf-b645-d839ce09c069"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fa7cb5a5-27ce-4ccf-b645-d839ce09c069"), new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fa7cb5a5-27ce-4ccf-b645-d839ce09c069"), new Guid("8c044b16-3cf7-4034-8af7-36abea323904") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fa7cb5a5-27ce-4ccf-b645-d839ce09c069"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fa7cb5a5-27ce-4ccf-b645-d839ce09c069"), new Guid("b0ca2349-7897-4f6d-b510-70b95da79054") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fa7cb5a5-27ce-4ccf-b645-d839ce09c069"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fa7cb5a5-27ce-4ccf-b645-d839ce09c069"), new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fa7cb5a5-27ce-4ccf-b645-d839ce09c069"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fc58828a-ee37-49e5-abde-f3687c76abca"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fc58828a-ee37-49e5-abde-f3687c76abca"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fc58828a-ee37-49e5-abde-f3687c76abca"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fceaa714-7611-472c-a217-372f7b8e7a38"), new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fceaa714-7611-472c-a217-372f7b8e7a38"), new Guid("9b478d24-b208-43d3-95a1-9fda925518cd") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fceaa714-7611-472c-a217-372f7b8e7a38"), new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fdda725c-c831-4462-8d4b-36272c07d014"), new Guid("05b0e602-312e-4267-b724-051ab635aaf1") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fdda725c-c831-4462-8d4b-36272c07d014"), new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fdda725c-c831-4462-8d4b-36272c07d014"), new Guid("e1f56202-af27-47a5-a009-9c917fb95932") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("04603270-e8cf-48f4-966f-483114014a83"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0f7a0114-9a12-42fe-a399-a520c3a65277"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("12820da8-75ea-49a1-91be-c0d67c0fdc92"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1354ce65-3b81-402d-8ae4-ad0c23f90319"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("24722452-1c8f-44dc-a774-29662f830a1c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("262de929-8869-4fd9-9253-f32c793f7181"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("26877838-dd57-4f09-b6d4-2261a08a34d1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("304c930b-80a1-4173-9b81-a6507baffdca"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("31c6bbe5-b6fc-461b-8064-8466cc30edda"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3521dd35-ea94-45bb-9667-e82c41fde500"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("356d5d69-0c68-42f0-b6d6-ce5e3aaff476"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("415701aa-e116-45df-90b9-b05a450aef76"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("449b2d9c-13a8-4181-918f-c433aba9a31e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("44e3c6b9-d578-4e5f-b301-ea301d4b0f69"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("451c7559-a9bc-4f9b-a5d7-a875f71ab1d4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4850dc4d-24e0-483b-867a-2e9550673693"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("502613bc-3e86-44bb-97c3-c49a527e8a7c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5d05da11-16d7-4104-a12a-58e7e3612dfe"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5dae2bda-a5a1-491d-b507-d9c8d03d3362"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5ef555d4-e624-4553-bdf4-a7d5ff63805f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("64ae915c-2f94-45fd-99da-924e3b89e493"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6d49bda8-5eb3-4b4b-869b-2ac3f00ce46f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6fbba37b-4697-46cf-a5b3-b08fa991a99e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("768ae801-0b6c-4fd3-9a93-9b763dc2a9ed"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("89d79cbc-b40f-4b69-96ee-b0498d836161"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8c24112a-f38a-4f67-86cb-42ffeeef5fed"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8ec22417-5beb-44b1-9bbe-febad0430534"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("91f1057e-d2b2-4533-bf24-e051516de3d2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("967cc6f9-b339-490e-ad57-aa00289d1a0d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9770ba43-6c25-4f05-a385-5f5207c5e761"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("97d501b8-dc19-4acc-a803-d540008c6677"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("982a9aac-562e-41cd-bfb5-c94e868b3658"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9a1749ad-33f4-47db-b195-ccc192e17b90"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a7f466b5-ebe9-4cc3-ae38-5cf5138cdfa7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a9747acc-ca58-4fd4-92e0-ecd6a677460b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("aa3def3d-cb66-4564-af5f-09cc5b16d8a5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cb786a19-af5d-4a8f-9493-3f37374a9d49"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d47a53e0-4398-4b5a-a0c9-d114683e0410"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e20b504a-ad05-434b-b52f-698e30733514"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e3390a2f-3c7e-4d2f-be10-1b67d1100966"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ed912fbb-2376-4f7f-9566-172e963bd3ec"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fa7cb5a5-27ce-4ccf-b645-d839ce09c069"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fc58828a-ee37-49e5-abde-f3687c76abca"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fceaa714-7611-472c-a217-372f7b8e7a38"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fdda725c-c831-4462-8d4b-36272c07d014"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05b0e602-312e-4267-b724-051ab635aaf1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e78ec84-ed52-403a-9a77-519c9a2ec989"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32deb52a-e208-44d8-85b4-f9cb82ae30fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55eaede9-054c-4128-ace6-f03eebdd9d21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8c044b16-3cf7-4034-8af7-36abea323904"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b478d24-b208-43d3-95a1-9fda925518cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0ca2349-7897-4f6d-b510-70b95da79054"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b4a57652-cc21-40cf-80bc-b806c40aa043"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0b5fce9-58ae-4570-a5e5-d67a8f0b46c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e1f56202-af27-47a5-a009-9c917fb95932"));

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
    }
}
