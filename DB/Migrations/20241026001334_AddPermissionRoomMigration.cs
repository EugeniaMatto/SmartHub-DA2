using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHub.DB.Migrations
{
    /// <inheritdoc />
    public partial class AddPermissionRoomMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
