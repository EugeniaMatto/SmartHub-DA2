using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHub.DB.Migrations
{
    /// <inheritdoc />
    public partial class RemoveJsonMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "PermissionsJson",
                table: "UserHomePermissions",
                newName: "Permissions");

            migrationBuilder.RenameColumn(
                name: "UseTypeJson",
                table: "Devices",
                newName: "UseTypes");

            migrationBuilder.RenameColumn(
                name: "PhotosJson",
                table: "Devices",
                newName: "Photos");

            migrationBuilder.RenameColumn(
                name: "CamSupportedActionsJson",
                table: "Devices",
                newName: "CamSupportedActions");

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("041be5c9-6962-4432-b759-3bee9d9557f2"), "getcompany-companies" },
                    { new Guid("07ec8f8a-8996-468c-bde1-4724b606d657"), "getrooms-home" },
                    { new Guid("0801b67e-6403-42ea-8615-356eeef87a1e"), "gethomes-user" },
                    { new Guid("09a92ea7-0c44-447a-8bc8-97c493f913bf"), "addrooms-home" },
                    { new Guid("0a6ec00d-a4e3-40fa-9a20-55ed7c200016"), "updatenamedevice-home" },
                    { new Guid("1365a81c-de25-4c17-96b1-68f9de73ea16"), "updateroomdevice-home" },
                    { new Guid("18c51bc0-8f1b-4aac-b0a1-f7e0f0af9f50"), "on-smartlamp" },
                    { new Guid("25abfdc3-a221-4c40-baa7-dd49d14bf571"), "getpermissions-home" },
                    { new Guid("31657dae-325d-4c9e-962f-ed05ec715f12"), "getaccounts-accounts" },
                    { new Guid("38f0d4a8-7178-4967-8d87-5819163307c4"), "addnotificationmembers-members" },
                    { new Guid("41ba0fd2-9901-440b-9119-4e14a73f9b2d"), "getmembers-members" },
                    { new Guid("4692ec9c-854d-4d54-8556-3de0361eeed9"), "getimporters-devices" },
                    { new Guid("5a01ae1e-0eb7-4ae1-95f4-55ad4a483f78"), "addsmartlamp-smartlamp" },
                    { new Guid("5ab10047-46b4-4c80-ab85-f67c3fdf021f"), "getdevicetypes-devicetype" },
                    { new Guid("5ac0336a-219a-43fe-b4e6-f82d371e1d57"), "motiondetection-camera" },
                    { new Guid("5b4afa17-1cf2-46cb-a357-a0274218e2ca"), "importdevices-devices" },
                    { new Guid("5d8a4ec8-dc04-43bc-817b-b2a5d11c10b1"), "getcompanyuser-companies" },
                    { new Guid("61402123-99eb-4dff-9ead-62671efd714d"), "getdevices-devices" },
                    { new Guid("64882ed2-f812-4b64-9faf-8c28df7f3b33"), "persondetection-camera" },
                    { new Guid("762bfdb9-f34b-4c4b-a752-6472e862a237"), "getnotifications-notification" },
                    { new Guid("77a1431c-4d23-43e8-b854-af375794469c"), "addmotionsensor-motionsensor" },
                    { new Guid("78b53bf7-46a7-4353-8842-e8553c56efcb"), "hardwareoff-home" },
                    { new Guid("7955fd38-d61d-4ff4-8b38-e3d7fd224515"), "addsensor-windowsensor" },
                    { new Guid("83a0ed9c-6a29-4c24-a2a0-5fe5e3d10072"), "addhomeownerpermission-homeowner" },
                    { new Guid("8d598e63-bb64-4173-b91f-cf566ad970f5"), "off-smartlamp" },
                    { new Guid("8f92ca73-4ff8-48ac-934b-06661a285ced"), "createcompany-companies" },
                    { new Guid("9361e3e2-015b-40ca-91e2-7dd22a314e03"), "getdevices-home" },
                    { new Guid("9ba0727e-6289-491e-9e75-c7bffbad0e6c"), "changeprofilephoto-user" },
                    { new Guid("a3989254-c350-4f2e-8c16-9ee721c5e997"), "addcamera-camera" },
                    { new Guid("aa4c3458-9e67-413e-a4ab-d9181c532422"), "add-home" },
                    { new Guid("aaa67850-91b2-4f52-9707-71328c1f7d83"), "addhomeownerpermission-homeowner" },
                    { new Guid("c861249e-f025-4637-a7e8-b7d5ed6f7e6d"), "close-windowsensor" },
                    { new Guid("ca76c995-bbb3-415e-905b-f25ded9fc329"), "motiondetection-motionsensor" },
                    { new Guid("ce2e4ece-9ee9-4984-ae93-cf55cf3b3bfc"), "addpermission-members" },
                    { new Guid("d0c07d06-a14a-4024-99c8-2f1952ba7da7"), "deleteadminaccount-administrator" },
                    { new Guid("d1c8ec91-c50f-44fc-92ec-7c4a68a2ed0c"), "getemails-homeowner" },
                    { new Guid("da4ca5b5-301d-4c21-8ed7-9f5830197cc6"), "createadminaccount-administrator" },
                    { new Guid("ddfb3d85-2d96-453d-842c-3850669bd444"), "createcompanyowneraccount-companyowner" },
                    { new Guid("de8a37df-176a-4171-8b9c-f9a766f54355"), "hardwareon-home" },
                    { new Guid("e5287d27-329e-468f-bd7a-226aeaef82a0"), "addmotionsensor-motionsensor" },
                    { new Guid("e733df1b-7409-4cd5-b419-f75b12ad9795"), "addmember-members" },
                    { new Guid("e8259bf0-2a3a-4d9b-8d35-3a7e921f34c3"), "getdevicemodelvalidators-devices" },
                    { new Guid("f7abe2be-e35a-4693-af90-68254f8a2bb7"), "open-windowsensor" },
                    { new Guid("fab4bb1f-575b-4000-a878-bff2f6afd408"), "selectdevicemodelvalidator-devices" },
                    { new Guid("ff018873-4b93-4747-8b8b-286748a24c2f"), "adddevice-home" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Password", "ProfilePhoto", "Roles", "Surname" },
                values: new object[,]
                {
                    { new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a"), new DateTime(2024, 11, 21, 1, 29, 33, 151, DateTimeKind.Local).AddTicks(7993), "rogerfederer@tennis.com", "Roger", "Federer@123", "federer.jpg", "[0]", "Federer" },
                    { new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a"), new DateTime(2024, 11, 21, 1, 29, 33, 151, DateTimeKind.Local).AddTicks(8018), "serenawilliams@tennis.com", "Serena", "Serena@123", "serena.jpg", "[2]", "Williams" },
                    { new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef"), new DateTime(2024, 11, 21, 1, 29, 33, 151, DateTimeKind.Local).AddTicks(8029), "petesampras@tennis.com", "Pete", "Sampras@123", "sampras.jpg", "[1]", "Sampras" },
                    { new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89"), new DateTime(2024, 11, 21, 1, 29, 33, 151, DateTimeKind.Local).AddTicks(8038), "billiejeanking@tennis.com", "Billie", "King@123", "king.jpg", "[0]", "Jean King" },
                    { new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26"), new DateTime(2024, 11, 21, 1, 29, 33, 151, DateTimeKind.Local).AddTicks(8024), "steffigraf@tennis.com", "Steffi", "Steffi@123", "graf.jpg", "[1]", "Graf" },
                    { new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928"), new DateTime(2024, 11, 21, 1, 29, 33, 151, DateTimeKind.Local).AddTicks(8034), "johnmcenroe@tennis.com", "John", "McEnroe@123", "mcenroe.jpg", "[2]", "McEnroe" },
                    { new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b"), new DateTime(2024, 11, 21, 1, 29, 33, 151, DateTimeKind.Local).AddTicks(8021), "novakdjokovic@tennis.com", "Novak", "Djokovic@123", "djokovic.jpg", "[2,1]", "Djokovic" },
                    { new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f"), new DateTime(2024, 11, 21, 1, 29, 33, 151, DateTimeKind.Local).AddTicks(8032), "martinanavratilova@tennis.com", "Martina", "Navratilova@123", "navratilova.jpg", "[1]", "Navratilova" },
                    { new Guid("ed479d34-379a-40bb-819d-961c446d77ef"), new DateTime(2024, 11, 21, 1, 29, 33, 151, DateTimeKind.Local).AddTicks(8027), "andreagassi@tennis.com", "Andre", "Agassi@123", "agassi.jpg", "[1]", "Agassi" },
                    { new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb"), new DateTime(2024, 11, 21, 1, 29, 33, 151, DateTimeKind.Local).AddTicks(8014), "rafaelnadal@tennis.com", "Rafael", "Nadal@123", "nadal.jpg", "[0]", "Nadal" }
                });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "PermissionId", "UserId" },
                values: new object[,]
                {
                    { new Guid("041be5c9-6962-4432-b759-3bee9d9557f2"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") },
                    { new Guid("041be5c9-6962-4432-b759-3bee9d9557f2"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") },
                    { new Guid("041be5c9-6962-4432-b759-3bee9d9557f2"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("07ec8f8a-8996-468c-bde1-4724b606d657"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("07ec8f8a-8996-468c-bde1-4724b606d657"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("07ec8f8a-8996-468c-bde1-4724b606d657"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("07ec8f8a-8996-468c-bde1-4724b606d657"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("07ec8f8a-8996-468c-bde1-4724b606d657"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("0801b67e-6403-42ea-8615-356eeef87a1e"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("0801b67e-6403-42ea-8615-356eeef87a1e"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("0801b67e-6403-42ea-8615-356eeef87a1e"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("0801b67e-6403-42ea-8615-356eeef87a1e"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("0801b67e-6403-42ea-8615-356eeef87a1e"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("09a92ea7-0c44-447a-8bc8-97c493f913bf"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("09a92ea7-0c44-447a-8bc8-97c493f913bf"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("09a92ea7-0c44-447a-8bc8-97c493f913bf"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("09a92ea7-0c44-447a-8bc8-97c493f913bf"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("09a92ea7-0c44-447a-8bc8-97c493f913bf"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("0a6ec00d-a4e3-40fa-9a20-55ed7c200016"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("0a6ec00d-a4e3-40fa-9a20-55ed7c200016"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("0a6ec00d-a4e3-40fa-9a20-55ed7c200016"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("0a6ec00d-a4e3-40fa-9a20-55ed7c200016"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("0a6ec00d-a4e3-40fa-9a20-55ed7c200016"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("1365a81c-de25-4c17-96b1-68f9de73ea16"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("1365a81c-de25-4c17-96b1-68f9de73ea16"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("1365a81c-de25-4c17-96b1-68f9de73ea16"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("1365a81c-de25-4c17-96b1-68f9de73ea16"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("1365a81c-de25-4c17-96b1-68f9de73ea16"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("18c51bc0-8f1b-4aac-b0a1-f7e0f0af9f50"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("18c51bc0-8f1b-4aac-b0a1-f7e0f0af9f50"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") },
                    { new Guid("18c51bc0-8f1b-4aac-b0a1-f7e0f0af9f50"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("18c51bc0-8f1b-4aac-b0a1-f7e0f0af9f50"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("18c51bc0-8f1b-4aac-b0a1-f7e0f0af9f50"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("18c51bc0-8f1b-4aac-b0a1-f7e0f0af9f50"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") },
                    { new Guid("18c51bc0-8f1b-4aac-b0a1-f7e0f0af9f50"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("18c51bc0-8f1b-4aac-b0a1-f7e0f0af9f50"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("18c51bc0-8f1b-4aac-b0a1-f7e0f0af9f50"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("18c51bc0-8f1b-4aac-b0a1-f7e0f0af9f50"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("25abfdc3-a221-4c40-baa7-dd49d14bf571"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("25abfdc3-a221-4c40-baa7-dd49d14bf571"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") },
                    { new Guid("25abfdc3-a221-4c40-baa7-dd49d14bf571"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("25abfdc3-a221-4c40-baa7-dd49d14bf571"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("25abfdc3-a221-4c40-baa7-dd49d14bf571"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("25abfdc3-a221-4c40-baa7-dd49d14bf571"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") },
                    { new Guid("25abfdc3-a221-4c40-baa7-dd49d14bf571"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("25abfdc3-a221-4c40-baa7-dd49d14bf571"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("25abfdc3-a221-4c40-baa7-dd49d14bf571"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("25abfdc3-a221-4c40-baa7-dd49d14bf571"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("31657dae-325d-4c9e-962f-ed05ec715f12"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") },
                    { new Guid("31657dae-325d-4c9e-962f-ed05ec715f12"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") },
                    { new Guid("31657dae-325d-4c9e-962f-ed05ec715f12"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("38f0d4a8-7178-4967-8d87-5819163307c4"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("38f0d4a8-7178-4967-8d87-5819163307c4"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("38f0d4a8-7178-4967-8d87-5819163307c4"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("38f0d4a8-7178-4967-8d87-5819163307c4"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("38f0d4a8-7178-4967-8d87-5819163307c4"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("41ba0fd2-9901-440b-9119-4e14a73f9b2d"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("41ba0fd2-9901-440b-9119-4e14a73f9b2d"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("41ba0fd2-9901-440b-9119-4e14a73f9b2d"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("41ba0fd2-9901-440b-9119-4e14a73f9b2d"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("41ba0fd2-9901-440b-9119-4e14a73f9b2d"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("4692ec9c-854d-4d54-8556-3de0361eeed9"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("4692ec9c-854d-4d54-8556-3de0361eeed9"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("4692ec9c-854d-4d54-8556-3de0361eeed9"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("5a01ae1e-0eb7-4ae1-95f4-55ad4a483f78"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("5a01ae1e-0eb7-4ae1-95f4-55ad4a483f78"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("5a01ae1e-0eb7-4ae1-95f4-55ad4a483f78"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("5ab10047-46b4-4c80-ab85-f67c3fdf021f"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("5ab10047-46b4-4c80-ab85-f67c3fdf021f"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") },
                    { new Guid("5ab10047-46b4-4c80-ab85-f67c3fdf021f"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("5ab10047-46b4-4c80-ab85-f67c3fdf021f"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("5ab10047-46b4-4c80-ab85-f67c3fdf021f"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("5ab10047-46b4-4c80-ab85-f67c3fdf021f"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") },
                    { new Guid("5ab10047-46b4-4c80-ab85-f67c3fdf021f"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("5ab10047-46b4-4c80-ab85-f67c3fdf021f"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("5ab10047-46b4-4c80-ab85-f67c3fdf021f"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("5ab10047-46b4-4c80-ab85-f67c3fdf021f"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("5ac0336a-219a-43fe-b4e6-f82d371e1d57"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("5ac0336a-219a-43fe-b4e6-f82d371e1d57"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") },
                    { new Guid("5ac0336a-219a-43fe-b4e6-f82d371e1d57"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("5ac0336a-219a-43fe-b4e6-f82d371e1d57"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("5ac0336a-219a-43fe-b4e6-f82d371e1d57"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("5ac0336a-219a-43fe-b4e6-f82d371e1d57"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") },
                    { new Guid("5ac0336a-219a-43fe-b4e6-f82d371e1d57"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("5ac0336a-219a-43fe-b4e6-f82d371e1d57"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("5ac0336a-219a-43fe-b4e6-f82d371e1d57"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("5ac0336a-219a-43fe-b4e6-f82d371e1d57"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("5b4afa17-1cf2-46cb-a357-a0274218e2ca"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("5b4afa17-1cf2-46cb-a357-a0274218e2ca"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("5b4afa17-1cf2-46cb-a357-a0274218e2ca"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("5d8a4ec8-dc04-43bc-817b-b2a5d11c10b1"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("5d8a4ec8-dc04-43bc-817b-b2a5d11c10b1"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("5d8a4ec8-dc04-43bc-817b-b2a5d11c10b1"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("61402123-99eb-4dff-9ead-62671efd714d"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("61402123-99eb-4dff-9ead-62671efd714d"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") },
                    { new Guid("61402123-99eb-4dff-9ead-62671efd714d"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("61402123-99eb-4dff-9ead-62671efd714d"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("61402123-99eb-4dff-9ead-62671efd714d"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("61402123-99eb-4dff-9ead-62671efd714d"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") },
                    { new Guid("61402123-99eb-4dff-9ead-62671efd714d"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("61402123-99eb-4dff-9ead-62671efd714d"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("61402123-99eb-4dff-9ead-62671efd714d"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("61402123-99eb-4dff-9ead-62671efd714d"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("64882ed2-f812-4b64-9faf-8c28df7f3b33"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("64882ed2-f812-4b64-9faf-8c28df7f3b33"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") },
                    { new Guid("64882ed2-f812-4b64-9faf-8c28df7f3b33"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("64882ed2-f812-4b64-9faf-8c28df7f3b33"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("64882ed2-f812-4b64-9faf-8c28df7f3b33"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("64882ed2-f812-4b64-9faf-8c28df7f3b33"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") },
                    { new Guid("64882ed2-f812-4b64-9faf-8c28df7f3b33"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("64882ed2-f812-4b64-9faf-8c28df7f3b33"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("64882ed2-f812-4b64-9faf-8c28df7f3b33"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("64882ed2-f812-4b64-9faf-8c28df7f3b33"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("762bfdb9-f34b-4c4b-a752-6472e862a237"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("762bfdb9-f34b-4c4b-a752-6472e862a237"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") },
                    { new Guid("762bfdb9-f34b-4c4b-a752-6472e862a237"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("762bfdb9-f34b-4c4b-a752-6472e862a237"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("762bfdb9-f34b-4c4b-a752-6472e862a237"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("762bfdb9-f34b-4c4b-a752-6472e862a237"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") },
                    { new Guid("762bfdb9-f34b-4c4b-a752-6472e862a237"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("762bfdb9-f34b-4c4b-a752-6472e862a237"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("762bfdb9-f34b-4c4b-a752-6472e862a237"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("762bfdb9-f34b-4c4b-a752-6472e862a237"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("77a1431c-4d23-43e8-b854-af375794469c"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("77a1431c-4d23-43e8-b854-af375794469c"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("77a1431c-4d23-43e8-b854-af375794469c"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("78b53bf7-46a7-4353-8842-e8553c56efcb"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("78b53bf7-46a7-4353-8842-e8553c56efcb"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("78b53bf7-46a7-4353-8842-e8553c56efcb"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("78b53bf7-46a7-4353-8842-e8553c56efcb"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("78b53bf7-46a7-4353-8842-e8553c56efcb"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("7955fd38-d61d-4ff4-8b38-e3d7fd224515"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("7955fd38-d61d-4ff4-8b38-e3d7fd224515"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("7955fd38-d61d-4ff4-8b38-e3d7fd224515"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("83a0ed9c-6a29-4c24-a2a0-5fe5e3d10072"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") },
                    { new Guid("83a0ed9c-6a29-4c24-a2a0-5fe5e3d10072"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") },
                    { new Guid("83a0ed9c-6a29-4c24-a2a0-5fe5e3d10072"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("8d598e63-bb64-4173-b91f-cf566ad970f5"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("8d598e63-bb64-4173-b91f-cf566ad970f5"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") },
                    { new Guid("8d598e63-bb64-4173-b91f-cf566ad970f5"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("8d598e63-bb64-4173-b91f-cf566ad970f5"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("8d598e63-bb64-4173-b91f-cf566ad970f5"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("8d598e63-bb64-4173-b91f-cf566ad970f5"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") },
                    { new Guid("8d598e63-bb64-4173-b91f-cf566ad970f5"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("8d598e63-bb64-4173-b91f-cf566ad970f5"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("8d598e63-bb64-4173-b91f-cf566ad970f5"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("8d598e63-bb64-4173-b91f-cf566ad970f5"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("8f92ca73-4ff8-48ac-934b-06661a285ced"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("8f92ca73-4ff8-48ac-934b-06661a285ced"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("8f92ca73-4ff8-48ac-934b-06661a285ced"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("9361e3e2-015b-40ca-91e2-7dd22a314e03"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("9361e3e2-015b-40ca-91e2-7dd22a314e03"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("9361e3e2-015b-40ca-91e2-7dd22a314e03"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("9361e3e2-015b-40ca-91e2-7dd22a314e03"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("9361e3e2-015b-40ca-91e2-7dd22a314e03"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("9ba0727e-6289-491e-9e75-c7bffbad0e6c"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("9ba0727e-6289-491e-9e75-c7bffbad0e6c"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") },
                    { new Guid("9ba0727e-6289-491e-9e75-c7bffbad0e6c"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("9ba0727e-6289-491e-9e75-c7bffbad0e6c"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("9ba0727e-6289-491e-9e75-c7bffbad0e6c"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("9ba0727e-6289-491e-9e75-c7bffbad0e6c"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") },
                    { new Guid("9ba0727e-6289-491e-9e75-c7bffbad0e6c"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("9ba0727e-6289-491e-9e75-c7bffbad0e6c"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("9ba0727e-6289-491e-9e75-c7bffbad0e6c"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("9ba0727e-6289-491e-9e75-c7bffbad0e6c"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("a3989254-c350-4f2e-8c16-9ee721c5e997"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("a3989254-c350-4f2e-8c16-9ee721c5e997"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("a3989254-c350-4f2e-8c16-9ee721c5e997"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("aa4c3458-9e67-413e-a4ab-d9181c532422"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("aa4c3458-9e67-413e-a4ab-d9181c532422"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("aa4c3458-9e67-413e-a4ab-d9181c532422"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("aa4c3458-9e67-413e-a4ab-d9181c532422"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("aa4c3458-9e67-413e-a4ab-d9181c532422"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("aaa67850-91b2-4f52-9707-71328c1f7d83"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("aaa67850-91b2-4f52-9707-71328c1f7d83"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("aaa67850-91b2-4f52-9707-71328c1f7d83"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("c861249e-f025-4637-a7e8-b7d5ed6f7e6d"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("c861249e-f025-4637-a7e8-b7d5ed6f7e6d"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") },
                    { new Guid("c861249e-f025-4637-a7e8-b7d5ed6f7e6d"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("c861249e-f025-4637-a7e8-b7d5ed6f7e6d"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("c861249e-f025-4637-a7e8-b7d5ed6f7e6d"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("c861249e-f025-4637-a7e8-b7d5ed6f7e6d"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") },
                    { new Guid("c861249e-f025-4637-a7e8-b7d5ed6f7e6d"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("c861249e-f025-4637-a7e8-b7d5ed6f7e6d"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("c861249e-f025-4637-a7e8-b7d5ed6f7e6d"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("c861249e-f025-4637-a7e8-b7d5ed6f7e6d"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("ca76c995-bbb3-415e-905b-f25ded9fc329"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("ca76c995-bbb3-415e-905b-f25ded9fc329"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") },
                    { new Guid("ca76c995-bbb3-415e-905b-f25ded9fc329"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("ca76c995-bbb3-415e-905b-f25ded9fc329"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("ca76c995-bbb3-415e-905b-f25ded9fc329"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("ca76c995-bbb3-415e-905b-f25ded9fc329"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") },
                    { new Guid("ca76c995-bbb3-415e-905b-f25ded9fc329"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("ca76c995-bbb3-415e-905b-f25ded9fc329"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("ca76c995-bbb3-415e-905b-f25ded9fc329"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("ca76c995-bbb3-415e-905b-f25ded9fc329"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("ce2e4ece-9ee9-4984-ae93-cf55cf3b3bfc"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("ce2e4ece-9ee9-4984-ae93-cf55cf3b3bfc"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("ce2e4ece-9ee9-4984-ae93-cf55cf3b3bfc"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("ce2e4ece-9ee9-4984-ae93-cf55cf3b3bfc"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("ce2e4ece-9ee9-4984-ae93-cf55cf3b3bfc"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("d0c07d06-a14a-4024-99c8-2f1952ba7da7"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") },
                    { new Guid("d0c07d06-a14a-4024-99c8-2f1952ba7da7"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") },
                    { new Guid("d0c07d06-a14a-4024-99c8-2f1952ba7da7"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("d1c8ec91-c50f-44fc-92ec-7c4a68a2ed0c"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("d1c8ec91-c50f-44fc-92ec-7c4a68a2ed0c"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("d1c8ec91-c50f-44fc-92ec-7c4a68a2ed0c"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("d1c8ec91-c50f-44fc-92ec-7c4a68a2ed0c"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("d1c8ec91-c50f-44fc-92ec-7c4a68a2ed0c"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("da4ca5b5-301d-4c21-8ed7-9f5830197cc6"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") },
                    { new Guid("da4ca5b5-301d-4c21-8ed7-9f5830197cc6"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") },
                    { new Guid("da4ca5b5-301d-4c21-8ed7-9f5830197cc6"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("ddfb3d85-2d96-453d-842c-3850669bd444"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") },
                    { new Guid("ddfb3d85-2d96-453d-842c-3850669bd444"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") },
                    { new Guid("ddfb3d85-2d96-453d-842c-3850669bd444"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("de8a37df-176a-4171-8b9c-f9a766f54355"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("de8a37df-176a-4171-8b9c-f9a766f54355"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("de8a37df-176a-4171-8b9c-f9a766f54355"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("de8a37df-176a-4171-8b9c-f9a766f54355"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("de8a37df-176a-4171-8b9c-f9a766f54355"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("e5287d27-329e-468f-bd7a-226aeaef82a0"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("e5287d27-329e-468f-bd7a-226aeaef82a0"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("e5287d27-329e-468f-bd7a-226aeaef82a0"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("e5287d27-329e-468f-bd7a-226aeaef82a0"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("e5287d27-329e-468f-bd7a-226aeaef82a0"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("e733df1b-7409-4cd5-b419-f75b12ad9795"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("e733df1b-7409-4cd5-b419-f75b12ad9795"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("e733df1b-7409-4cd5-b419-f75b12ad9795"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("e733df1b-7409-4cd5-b419-f75b12ad9795"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("e733df1b-7409-4cd5-b419-f75b12ad9795"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("e8259bf0-2a3a-4d9b-8d35-3a7e921f34c3"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("e8259bf0-2a3a-4d9b-8d35-3a7e921f34c3"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("e8259bf0-2a3a-4d9b-8d35-3a7e921f34c3"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("f7abe2be-e35a-4693-af90-68254f8a2bb7"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("f7abe2be-e35a-4693-af90-68254f8a2bb7"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") },
                    { new Guid("f7abe2be-e35a-4693-af90-68254f8a2bb7"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("f7abe2be-e35a-4693-af90-68254f8a2bb7"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("f7abe2be-e35a-4693-af90-68254f8a2bb7"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("f7abe2be-e35a-4693-af90-68254f8a2bb7"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") },
                    { new Guid("f7abe2be-e35a-4693-af90-68254f8a2bb7"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("f7abe2be-e35a-4693-af90-68254f8a2bb7"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("f7abe2be-e35a-4693-af90-68254f8a2bb7"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") },
                    { new Guid("f7abe2be-e35a-4693-af90-68254f8a2bb7"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("fab4bb1f-575b-4000-a878-bff2f6afd408"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") },
                    { new Guid("fab4bb1f-575b-4000-a878-bff2f6afd408"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") },
                    { new Guid("fab4bb1f-575b-4000-a878-bff2f6afd408"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") },
                    { new Guid("ff018873-4b93-4747-8b8b-286748a24c2f"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") },
                    { new Guid("ff018873-4b93-4747-8b8b-286748a24c2f"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") },
                    { new Guid("ff018873-4b93-4747-8b8b-286748a24c2f"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") },
                    { new Guid("ff018873-4b93-4747-8b8b-286748a24c2f"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") },
                    { new Guid("ff018873-4b93-4747-8b8b-286748a24c2f"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("041be5c9-6962-4432-b759-3bee9d9557f2"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("041be5c9-6962-4432-b759-3bee9d9557f2"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("041be5c9-6962-4432-b759-3bee9d9557f2"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("07ec8f8a-8996-468c-bde1-4724b606d657"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("07ec8f8a-8996-468c-bde1-4724b606d657"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("07ec8f8a-8996-468c-bde1-4724b606d657"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("07ec8f8a-8996-468c-bde1-4724b606d657"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("07ec8f8a-8996-468c-bde1-4724b606d657"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0801b67e-6403-42ea-8615-356eeef87a1e"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0801b67e-6403-42ea-8615-356eeef87a1e"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0801b67e-6403-42ea-8615-356eeef87a1e"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0801b67e-6403-42ea-8615-356eeef87a1e"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0801b67e-6403-42ea-8615-356eeef87a1e"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("09a92ea7-0c44-447a-8bc8-97c493f913bf"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("09a92ea7-0c44-447a-8bc8-97c493f913bf"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("09a92ea7-0c44-447a-8bc8-97c493f913bf"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("09a92ea7-0c44-447a-8bc8-97c493f913bf"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("09a92ea7-0c44-447a-8bc8-97c493f913bf"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0a6ec00d-a4e3-40fa-9a20-55ed7c200016"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0a6ec00d-a4e3-40fa-9a20-55ed7c200016"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0a6ec00d-a4e3-40fa-9a20-55ed7c200016"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0a6ec00d-a4e3-40fa-9a20-55ed7c200016"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("0a6ec00d-a4e3-40fa-9a20-55ed7c200016"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1365a81c-de25-4c17-96b1-68f9de73ea16"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1365a81c-de25-4c17-96b1-68f9de73ea16"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1365a81c-de25-4c17-96b1-68f9de73ea16"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1365a81c-de25-4c17-96b1-68f9de73ea16"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("1365a81c-de25-4c17-96b1-68f9de73ea16"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18c51bc0-8f1b-4aac-b0a1-f7e0f0af9f50"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18c51bc0-8f1b-4aac-b0a1-f7e0f0af9f50"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18c51bc0-8f1b-4aac-b0a1-f7e0f0af9f50"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18c51bc0-8f1b-4aac-b0a1-f7e0f0af9f50"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18c51bc0-8f1b-4aac-b0a1-f7e0f0af9f50"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18c51bc0-8f1b-4aac-b0a1-f7e0f0af9f50"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18c51bc0-8f1b-4aac-b0a1-f7e0f0af9f50"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18c51bc0-8f1b-4aac-b0a1-f7e0f0af9f50"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18c51bc0-8f1b-4aac-b0a1-f7e0f0af9f50"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("18c51bc0-8f1b-4aac-b0a1-f7e0f0af9f50"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("25abfdc3-a221-4c40-baa7-dd49d14bf571"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("25abfdc3-a221-4c40-baa7-dd49d14bf571"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("25abfdc3-a221-4c40-baa7-dd49d14bf571"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("25abfdc3-a221-4c40-baa7-dd49d14bf571"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("25abfdc3-a221-4c40-baa7-dd49d14bf571"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("25abfdc3-a221-4c40-baa7-dd49d14bf571"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("25abfdc3-a221-4c40-baa7-dd49d14bf571"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("25abfdc3-a221-4c40-baa7-dd49d14bf571"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("25abfdc3-a221-4c40-baa7-dd49d14bf571"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("25abfdc3-a221-4c40-baa7-dd49d14bf571"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("31657dae-325d-4c9e-962f-ed05ec715f12"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("31657dae-325d-4c9e-962f-ed05ec715f12"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("31657dae-325d-4c9e-962f-ed05ec715f12"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("38f0d4a8-7178-4967-8d87-5819163307c4"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("38f0d4a8-7178-4967-8d87-5819163307c4"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("38f0d4a8-7178-4967-8d87-5819163307c4"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("38f0d4a8-7178-4967-8d87-5819163307c4"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("38f0d4a8-7178-4967-8d87-5819163307c4"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("41ba0fd2-9901-440b-9119-4e14a73f9b2d"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("41ba0fd2-9901-440b-9119-4e14a73f9b2d"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("41ba0fd2-9901-440b-9119-4e14a73f9b2d"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("41ba0fd2-9901-440b-9119-4e14a73f9b2d"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("41ba0fd2-9901-440b-9119-4e14a73f9b2d"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4692ec9c-854d-4d54-8556-3de0361eeed9"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4692ec9c-854d-4d54-8556-3de0361eeed9"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("4692ec9c-854d-4d54-8556-3de0361eeed9"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5a01ae1e-0eb7-4ae1-95f4-55ad4a483f78"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5a01ae1e-0eb7-4ae1-95f4-55ad4a483f78"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5a01ae1e-0eb7-4ae1-95f4-55ad4a483f78"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ab10047-46b4-4c80-ab85-f67c3fdf021f"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ab10047-46b4-4c80-ab85-f67c3fdf021f"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ab10047-46b4-4c80-ab85-f67c3fdf021f"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ab10047-46b4-4c80-ab85-f67c3fdf021f"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ab10047-46b4-4c80-ab85-f67c3fdf021f"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ab10047-46b4-4c80-ab85-f67c3fdf021f"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ab10047-46b4-4c80-ab85-f67c3fdf021f"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ab10047-46b4-4c80-ab85-f67c3fdf021f"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ab10047-46b4-4c80-ab85-f67c3fdf021f"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ab10047-46b4-4c80-ab85-f67c3fdf021f"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ac0336a-219a-43fe-b4e6-f82d371e1d57"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ac0336a-219a-43fe-b4e6-f82d371e1d57"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ac0336a-219a-43fe-b4e6-f82d371e1d57"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ac0336a-219a-43fe-b4e6-f82d371e1d57"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ac0336a-219a-43fe-b4e6-f82d371e1d57"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ac0336a-219a-43fe-b4e6-f82d371e1d57"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ac0336a-219a-43fe-b4e6-f82d371e1d57"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ac0336a-219a-43fe-b4e6-f82d371e1d57"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ac0336a-219a-43fe-b4e6-f82d371e1d57"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5ac0336a-219a-43fe-b4e6-f82d371e1d57"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5b4afa17-1cf2-46cb-a357-a0274218e2ca"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5b4afa17-1cf2-46cb-a357-a0274218e2ca"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5b4afa17-1cf2-46cb-a357-a0274218e2ca"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5d8a4ec8-dc04-43bc-817b-b2a5d11c10b1"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5d8a4ec8-dc04-43bc-817b-b2a5d11c10b1"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("5d8a4ec8-dc04-43bc-817b-b2a5d11c10b1"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("61402123-99eb-4dff-9ead-62671efd714d"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("61402123-99eb-4dff-9ead-62671efd714d"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("61402123-99eb-4dff-9ead-62671efd714d"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("61402123-99eb-4dff-9ead-62671efd714d"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("61402123-99eb-4dff-9ead-62671efd714d"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("61402123-99eb-4dff-9ead-62671efd714d"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("61402123-99eb-4dff-9ead-62671efd714d"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("61402123-99eb-4dff-9ead-62671efd714d"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("61402123-99eb-4dff-9ead-62671efd714d"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("61402123-99eb-4dff-9ead-62671efd714d"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("64882ed2-f812-4b64-9faf-8c28df7f3b33"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("64882ed2-f812-4b64-9faf-8c28df7f3b33"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("64882ed2-f812-4b64-9faf-8c28df7f3b33"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("64882ed2-f812-4b64-9faf-8c28df7f3b33"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("64882ed2-f812-4b64-9faf-8c28df7f3b33"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("64882ed2-f812-4b64-9faf-8c28df7f3b33"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("64882ed2-f812-4b64-9faf-8c28df7f3b33"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("64882ed2-f812-4b64-9faf-8c28df7f3b33"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("64882ed2-f812-4b64-9faf-8c28df7f3b33"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("64882ed2-f812-4b64-9faf-8c28df7f3b33"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("762bfdb9-f34b-4c4b-a752-6472e862a237"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("762bfdb9-f34b-4c4b-a752-6472e862a237"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("762bfdb9-f34b-4c4b-a752-6472e862a237"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("762bfdb9-f34b-4c4b-a752-6472e862a237"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("762bfdb9-f34b-4c4b-a752-6472e862a237"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("762bfdb9-f34b-4c4b-a752-6472e862a237"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("762bfdb9-f34b-4c4b-a752-6472e862a237"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("762bfdb9-f34b-4c4b-a752-6472e862a237"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("762bfdb9-f34b-4c4b-a752-6472e862a237"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("762bfdb9-f34b-4c4b-a752-6472e862a237"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("77a1431c-4d23-43e8-b854-af375794469c"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("77a1431c-4d23-43e8-b854-af375794469c"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("77a1431c-4d23-43e8-b854-af375794469c"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("78b53bf7-46a7-4353-8842-e8553c56efcb"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("78b53bf7-46a7-4353-8842-e8553c56efcb"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("78b53bf7-46a7-4353-8842-e8553c56efcb"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("78b53bf7-46a7-4353-8842-e8553c56efcb"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("78b53bf7-46a7-4353-8842-e8553c56efcb"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7955fd38-d61d-4ff4-8b38-e3d7fd224515"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7955fd38-d61d-4ff4-8b38-e3d7fd224515"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("7955fd38-d61d-4ff4-8b38-e3d7fd224515"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("83a0ed9c-6a29-4c24-a2a0-5fe5e3d10072"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("83a0ed9c-6a29-4c24-a2a0-5fe5e3d10072"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("83a0ed9c-6a29-4c24-a2a0-5fe5e3d10072"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8d598e63-bb64-4173-b91f-cf566ad970f5"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8d598e63-bb64-4173-b91f-cf566ad970f5"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8d598e63-bb64-4173-b91f-cf566ad970f5"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8d598e63-bb64-4173-b91f-cf566ad970f5"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8d598e63-bb64-4173-b91f-cf566ad970f5"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8d598e63-bb64-4173-b91f-cf566ad970f5"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8d598e63-bb64-4173-b91f-cf566ad970f5"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8d598e63-bb64-4173-b91f-cf566ad970f5"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8d598e63-bb64-4173-b91f-cf566ad970f5"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8d598e63-bb64-4173-b91f-cf566ad970f5"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8f92ca73-4ff8-48ac-934b-06661a285ced"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8f92ca73-4ff8-48ac-934b-06661a285ced"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("8f92ca73-4ff8-48ac-934b-06661a285ced"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9361e3e2-015b-40ca-91e2-7dd22a314e03"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9361e3e2-015b-40ca-91e2-7dd22a314e03"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9361e3e2-015b-40ca-91e2-7dd22a314e03"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9361e3e2-015b-40ca-91e2-7dd22a314e03"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9361e3e2-015b-40ca-91e2-7dd22a314e03"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9ba0727e-6289-491e-9e75-c7bffbad0e6c"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9ba0727e-6289-491e-9e75-c7bffbad0e6c"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9ba0727e-6289-491e-9e75-c7bffbad0e6c"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9ba0727e-6289-491e-9e75-c7bffbad0e6c"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9ba0727e-6289-491e-9e75-c7bffbad0e6c"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9ba0727e-6289-491e-9e75-c7bffbad0e6c"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9ba0727e-6289-491e-9e75-c7bffbad0e6c"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9ba0727e-6289-491e-9e75-c7bffbad0e6c"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9ba0727e-6289-491e-9e75-c7bffbad0e6c"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("9ba0727e-6289-491e-9e75-c7bffbad0e6c"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a3989254-c350-4f2e-8c16-9ee721c5e997"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a3989254-c350-4f2e-8c16-9ee721c5e997"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("a3989254-c350-4f2e-8c16-9ee721c5e997"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa4c3458-9e67-413e-a4ab-d9181c532422"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa4c3458-9e67-413e-a4ab-d9181c532422"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa4c3458-9e67-413e-a4ab-d9181c532422"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa4c3458-9e67-413e-a4ab-d9181c532422"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aa4c3458-9e67-413e-a4ab-d9181c532422"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aaa67850-91b2-4f52-9707-71328c1f7d83"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aaa67850-91b2-4f52-9707-71328c1f7d83"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("aaa67850-91b2-4f52-9707-71328c1f7d83"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c861249e-f025-4637-a7e8-b7d5ed6f7e6d"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c861249e-f025-4637-a7e8-b7d5ed6f7e6d"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c861249e-f025-4637-a7e8-b7d5ed6f7e6d"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c861249e-f025-4637-a7e8-b7d5ed6f7e6d"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c861249e-f025-4637-a7e8-b7d5ed6f7e6d"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c861249e-f025-4637-a7e8-b7d5ed6f7e6d"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c861249e-f025-4637-a7e8-b7d5ed6f7e6d"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c861249e-f025-4637-a7e8-b7d5ed6f7e6d"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c861249e-f025-4637-a7e8-b7d5ed6f7e6d"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("c861249e-f025-4637-a7e8-b7d5ed6f7e6d"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ca76c995-bbb3-415e-905b-f25ded9fc329"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ca76c995-bbb3-415e-905b-f25ded9fc329"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ca76c995-bbb3-415e-905b-f25ded9fc329"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ca76c995-bbb3-415e-905b-f25ded9fc329"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ca76c995-bbb3-415e-905b-f25ded9fc329"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ca76c995-bbb3-415e-905b-f25ded9fc329"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ca76c995-bbb3-415e-905b-f25ded9fc329"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ca76c995-bbb3-415e-905b-f25ded9fc329"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ca76c995-bbb3-415e-905b-f25ded9fc329"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ca76c995-bbb3-415e-905b-f25ded9fc329"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ce2e4ece-9ee9-4984-ae93-cf55cf3b3bfc"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ce2e4ece-9ee9-4984-ae93-cf55cf3b3bfc"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ce2e4ece-9ee9-4984-ae93-cf55cf3b3bfc"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ce2e4ece-9ee9-4984-ae93-cf55cf3b3bfc"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ce2e4ece-9ee9-4984-ae93-cf55cf3b3bfc"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d0c07d06-a14a-4024-99c8-2f1952ba7da7"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d0c07d06-a14a-4024-99c8-2f1952ba7da7"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d0c07d06-a14a-4024-99c8-2f1952ba7da7"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d1c8ec91-c50f-44fc-92ec-7c4a68a2ed0c"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d1c8ec91-c50f-44fc-92ec-7c4a68a2ed0c"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d1c8ec91-c50f-44fc-92ec-7c4a68a2ed0c"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d1c8ec91-c50f-44fc-92ec-7c4a68a2ed0c"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("d1c8ec91-c50f-44fc-92ec-7c4a68a2ed0c"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("da4ca5b5-301d-4c21-8ed7-9f5830197cc6"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("da4ca5b5-301d-4c21-8ed7-9f5830197cc6"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("da4ca5b5-301d-4c21-8ed7-9f5830197cc6"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ddfb3d85-2d96-453d-842c-3850669bd444"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ddfb3d85-2d96-453d-842c-3850669bd444"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ddfb3d85-2d96-453d-842c-3850669bd444"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("de8a37df-176a-4171-8b9c-f9a766f54355"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("de8a37df-176a-4171-8b9c-f9a766f54355"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("de8a37df-176a-4171-8b9c-f9a766f54355"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("de8a37df-176a-4171-8b9c-f9a766f54355"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("de8a37df-176a-4171-8b9c-f9a766f54355"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e5287d27-329e-468f-bd7a-226aeaef82a0"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e5287d27-329e-468f-bd7a-226aeaef82a0"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e5287d27-329e-468f-bd7a-226aeaef82a0"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e5287d27-329e-468f-bd7a-226aeaef82a0"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e5287d27-329e-468f-bd7a-226aeaef82a0"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e733df1b-7409-4cd5-b419-f75b12ad9795"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e733df1b-7409-4cd5-b419-f75b12ad9795"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e733df1b-7409-4cd5-b419-f75b12ad9795"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e733df1b-7409-4cd5-b419-f75b12ad9795"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e733df1b-7409-4cd5-b419-f75b12ad9795"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e8259bf0-2a3a-4d9b-8d35-3a7e921f34c3"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e8259bf0-2a3a-4d9b-8d35-3a7e921f34c3"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("e8259bf0-2a3a-4d9b-8d35-3a7e921f34c3"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f7abe2be-e35a-4693-af90-68254f8a2bb7"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f7abe2be-e35a-4693-af90-68254f8a2bb7"), new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f7abe2be-e35a-4693-af90-68254f8a2bb7"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f7abe2be-e35a-4693-af90-68254f8a2bb7"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f7abe2be-e35a-4693-af90-68254f8a2bb7"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f7abe2be-e35a-4693-af90-68254f8a2bb7"), new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f7abe2be-e35a-4693-af90-68254f8a2bb7"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f7abe2be-e35a-4693-af90-68254f8a2bb7"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f7abe2be-e35a-4693-af90-68254f8a2bb7"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("f7abe2be-e35a-4693-af90-68254f8a2bb7"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fab4bb1f-575b-4000-a878-bff2f6afd408"), new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fab4bb1f-575b-4000-a878-bff2f6afd408"), new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("fab4bb1f-575b-4000-a878-bff2f6afd408"), new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ff018873-4b93-4747-8b8b-286748a24c2f"), new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ff018873-4b93-4747-8b8b-286748a24c2f"), new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ff018873-4b93-4747-8b8b-286748a24c2f"), new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ff018873-4b93-4747-8b8b-286748a24c2f"), new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f") });

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumns: new[] { "PermissionId", "UserId" },
                keyValues: new object[] { new Guid("ff018873-4b93-4747-8b8b-286748a24c2f"), new Guid("ed479d34-379a-40bb-819d-961c446d77ef") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("041be5c9-6962-4432-b759-3bee9d9557f2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("07ec8f8a-8996-468c-bde1-4724b606d657"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0801b67e-6403-42ea-8615-356eeef87a1e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("09a92ea7-0c44-447a-8bc8-97c493f913bf"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0a6ec00d-a4e3-40fa-9a20-55ed7c200016"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1365a81c-de25-4c17-96b1-68f9de73ea16"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("18c51bc0-8f1b-4aac-b0a1-f7e0f0af9f50"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("25abfdc3-a221-4c40-baa7-dd49d14bf571"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("31657dae-325d-4c9e-962f-ed05ec715f12"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("38f0d4a8-7178-4967-8d87-5819163307c4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("41ba0fd2-9901-440b-9119-4e14a73f9b2d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4692ec9c-854d-4d54-8556-3de0361eeed9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5a01ae1e-0eb7-4ae1-95f4-55ad4a483f78"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5ab10047-46b4-4c80-ab85-f67c3fdf021f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5ac0336a-219a-43fe-b4e6-f82d371e1d57"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5b4afa17-1cf2-46cb-a357-a0274218e2ca"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5d8a4ec8-dc04-43bc-817b-b2a5d11c10b1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("61402123-99eb-4dff-9ead-62671efd714d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("64882ed2-f812-4b64-9faf-8c28df7f3b33"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("762bfdb9-f34b-4c4b-a752-6472e862a237"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("77a1431c-4d23-43e8-b854-af375794469c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("78b53bf7-46a7-4353-8842-e8553c56efcb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7955fd38-d61d-4ff4-8b38-e3d7fd224515"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("83a0ed9c-6a29-4c24-a2a0-5fe5e3d10072"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8d598e63-bb64-4173-b91f-cf566ad970f5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8f92ca73-4ff8-48ac-934b-06661a285ced"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9361e3e2-015b-40ca-91e2-7dd22a314e03"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9ba0727e-6289-491e-9e75-c7bffbad0e6c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a3989254-c350-4f2e-8c16-9ee721c5e997"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("aa4c3458-9e67-413e-a4ab-d9181c532422"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("aaa67850-91b2-4f52-9707-71328c1f7d83"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c861249e-f025-4637-a7e8-b7d5ed6f7e6d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ca76c995-bbb3-415e-905b-f25ded9fc329"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ce2e4ece-9ee9-4984-ae93-cf55cf3b3bfc"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d0c07d06-a14a-4024-99c8-2f1952ba7da7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d1c8ec91-c50f-44fc-92ec-7c4a68a2ed0c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("da4ca5b5-301d-4c21-8ed7-9f5830197cc6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ddfb3d85-2d96-453d-842c-3850669bd444"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("de8a37df-176a-4171-8b9c-f9a766f54355"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e5287d27-329e-468f-bd7a-226aeaef82a0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e733df1b-7409-4cd5-b419-f75b12ad9795"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e8259bf0-2a3a-4d9b-8d35-3a7e921f34c3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f7abe2be-e35a-4693-af90-68254f8a2bb7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fab4bb1f-575b-4000-a878-bff2f6afd408"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ff018873-4b93-4747-8b8b-286748a24c2f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07d19e2d-9c25-47eb-8b93-bdc521775c9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("257bd20a-ca54-4b3b-94a7-58bb996c391a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4fd83c98-c581-415b-a11d-7eaa5c3146ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9053e215-2f51-4dfd-b473-10fc0417ca89"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("952bc2c7-5b48-4269-a30d-a36473fbca26"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a18cd677-f967-42d9-a0fd-7b41ab740928"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aceefaed-e19b-4979-b6bf-47ccafc0a88b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae1d88be-1c44-4f76-91d8-56bc446b823f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed479d34-379a-40bb-819d-961c446d77ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f41edc56-1a90-49bf-8312-9f583b34f2fb"));

            migrationBuilder.RenameColumn(
                name: "Permissions",
                table: "UserHomePermissions",
                newName: "PermissionsJson");

            migrationBuilder.RenameColumn(
                name: "UseTypes",
                table: "Devices",
                newName: "UseTypeJson");

            migrationBuilder.RenameColumn(
                name: "Photos",
                table: "Devices",
                newName: "PhotosJson");

            migrationBuilder.RenameColumn(
                name: "CamSupportedActions",
                table: "Devices",
                newName: "CamSupportedActionsJson");

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
    }
}
