using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpark.Infrastructure.Migrations
{
    public partial class seed_data_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "car_park_type",
                keyColumn: "id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "car_park_type",
                keyColumn: "id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "car_park_type",
                keyColumn: "id",
                keyValue: (short)3);

            migrationBuilder.DeleteData(
                table: "free_parking_type",
                keyColumn: "id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "free_parking_type",
                keyColumn: "id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "night_parking_type",
                keyColumn: "id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "night_parking_type",
                keyColumn: "id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "parking_system_type",
                keyColumn: "id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "parking_system_type",
                keyColumn: "id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "short_term_parking_type",
                keyColumn: "id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "short_term_parking_type",
                keyColumn: "id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "short_term_parking_type",
                keyColumn: "id",
                keyValue: (short)3);

            migrationBuilder.DeleteData(
                table: "short_term_parking_type",
                keyColumn: "id",
                keyValue: (short)4);

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("76612a24-b201-4eb7-8bd6-cbb5225a518d"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "user_favorite",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 983, DateTimeKind.Utc).AddTicks(3633),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "user_favorite",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 983, DateTimeKind.Utc).AddTicks(3472),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(9196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 980, DateTimeKind.Utc).AddTicks(5791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 859, DateTimeKind.Utc).AddTicks(9828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 980, DateTimeKind.Utc).AddTicks(5657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 859, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "short_term_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 982, DateTimeKind.Utc).AddTicks(8815),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "short_term_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 982, DateTimeKind.Utc).AddTicks(8688),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "parking_system_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 982, DateTimeKind.Utc).AddTicks(7508),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(2821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "parking_system_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 982, DateTimeKind.Utc).AddTicks(7379),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(2692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "night_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 982, DateTimeKind.Utc).AddTicks(8247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "night_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 982, DateTimeKind.Utc).AddTicks(8108),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "free_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 982, DateTimeKind.Utc).AddTicks(6872),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(2187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "free_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 982, DateTimeKind.Utc).AddTicks(6740),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(2056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "car_park_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 982, DateTimeKind.Utc).AddTicks(6222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(1601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "car_park_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 982, DateTimeKind.Utc).AddTicks(6062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(1429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "car_park",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 980, DateTimeKind.Utc).AddTicks(8912),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 860, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "car_park",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 980, DateTimeKind.Utc).AddTicks(8751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 860, DateTimeKind.Utc).AddTicks(3457));

            migrationBuilder.InsertData(
                table: "car_park_type",
                columns: new[] { "id", "car_park_type_name", "deleted_at" },
                values: new object[,]
                {
                    { (short)0, "BASEMENT CAR PARK", null },
                    { (short)1, "MULTI-STOREY CAR PARK", null },
                    { (short)2, "SURFACE CAR PARK", null }
                });

            migrationBuilder.InsertData(
                table: "free_parking_type",
                columns: new[] { "id", "deleted_at", "free_parking_type_name" },
                values: new object[,]
                {
                    { (short)0, null, "NO" },
                    { (short)1, null, "SUN & PH FR 7AM-10.30PM" }
                });

            migrationBuilder.InsertData(
                table: "night_parking_type",
                columns: new[] { "id", "deleted_at", "night_parking_type_name" },
                values: new object[,]
                {
                    { (short)0, null, "NO" },
                    { (short)1, null, "YES" }
                });

            migrationBuilder.InsertData(
                table: "parking_system_type",
                columns: new[] { "id", "deleted_at", "type_of_parking_system_name" },
                values: new object[,]
                {
                    { (short)0, null, "ELECTRONIC PARKING" },
                    { (short)1, null, "COUPON PARKING" }
                });

            migrationBuilder.InsertData(
                table: "short_term_parking_type",
                columns: new[] { "id", "deleted_at", "short_term_parking_name" },
                values: new object[,]
                {
                    { (short)0, null, "NO" },
                    { (short)1, null, "7AM-7PM" },
                    { (short)2, null, "7AM-10.30PM" },
                    { (short)3, null, "WHOLE DAY" }
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "created_at", "deleted_at", "email", "first_name", "full_name", "is_active", "last_name", "modified_at", "password_hash", "password_salt", "user_name" },
                values: new object[] { new Guid("dcbda72c-9f0e-4b52-843d-97de362d3be2"), new DateTime(2024, 1, 18, 8, 23, 19, 984, DateTimeKind.Utc).AddTicks(5812), null, "admin@vmogroup.com", "Admin", "Admin Admin", true, "Admin", new DateTime(2024, 1, 18, 8, 23, 19, 984, DateTimeKind.Utc).AddTicks(5816), new byte[] { 66, 93, 224, 44, 43, 210, 124, 55, 114, 104, 146, 199, 5, 180, 33, 180, 206, 226, 247, 62, 60, 57, 174, 125, 212, 220, 193, 89, 207, 183, 91, 72, 121, 195, 150, 55, 101, 237, 56, 175, 246, 89, 118, 116, 188, 120, 83, 4, 215, 177, 30, 99, 231, 174, 12, 115, 66, 86, 171, 130, 132, 173, 131, 250 }, new byte[] { 232, 53, 115, 36, 22, 118, 95, 192, 1, 131, 195, 85, 232, 204, 120, 207, 224, 225, 135, 164, 231, 230, 95, 41, 248, 255, 232, 186, 219, 143, 119, 51, 176, 196, 159, 226, 22, 3, 241, 47, 7, 179, 210, 87, 133, 31, 3, 128, 100, 233, 209, 95, 47, 167, 248, 78, 16, 157, 248, 29, 167, 170, 117, 25, 121, 173, 212, 243, 241, 202, 65, 10, 35, 202, 18, 224, 3, 61, 154, 104, 99, 203, 6, 58, 19, 121, 187, 148, 223, 195, 94, 213, 48, 193, 175, 52, 175, 127, 209, 20, 236, 29, 225, 128, 231, 39, 44, 202, 99, 188, 206, 205, 163, 122, 228, 117, 0, 147, 93, 78, 110, 37, 54, 110, 198, 195, 153, 209 }, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "car_park_type",
                keyColumn: "id",
                keyValue: (short)0);

            migrationBuilder.DeleteData(
                table: "car_park_type",
                keyColumn: "id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "car_park_type",
                keyColumn: "id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "free_parking_type",
                keyColumn: "id",
                keyValue: (short)0);

            migrationBuilder.DeleteData(
                table: "free_parking_type",
                keyColumn: "id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "night_parking_type",
                keyColumn: "id",
                keyValue: (short)0);

            migrationBuilder.DeleteData(
                table: "night_parking_type",
                keyColumn: "id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "parking_system_type",
                keyColumn: "id",
                keyValue: (short)0);

            migrationBuilder.DeleteData(
                table: "parking_system_type",
                keyColumn: "id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "short_term_parking_type",
                keyColumn: "id",
                keyValue: (short)0);

            migrationBuilder.DeleteData(
                table: "short_term_parking_type",
                keyColumn: "id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "short_term_parking_type",
                keyColumn: "id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "short_term_parking_type",
                keyColumn: "id",
                keyValue: (short)3);

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("dcbda72c-9f0e-4b52-843d-97de362d3be2"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "user_favorite",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(9360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 983, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "user_favorite",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(9196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 983, DateTimeKind.Utc).AddTicks(3472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 859, DateTimeKind.Utc).AddTicks(9828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 980, DateTimeKind.Utc).AddTicks(5791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 859, DateTimeKind.Utc).AddTicks(9681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 980, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "short_term_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(4167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 982, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "short_term_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(4041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 982, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "parking_system_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(2821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 982, DateTimeKind.Utc).AddTicks(7508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "parking_system_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(2692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 982, DateTimeKind.Utc).AddTicks(7379));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "night_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(3551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 982, DateTimeKind.Utc).AddTicks(8247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "night_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(3420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 982, DateTimeKind.Utc).AddTicks(8108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "free_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(2187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 982, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "free_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(2056),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 982, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "car_park_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(1601),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 982, DateTimeKind.Utc).AddTicks(6222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "car_park_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(1429),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 982, DateTimeKind.Utc).AddTicks(6062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "car_park",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 860, DateTimeKind.Utc).AddTicks(3634),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 980, DateTimeKind.Utc).AddTicks(8912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "car_park",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 860, DateTimeKind.Utc).AddTicks(3457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 23, 19, 980, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.InsertData(
                table: "car_park_type",
                columns: new[] { "id", "car_park_type_name", "deleted_at" },
                values: new object[,]
                {
                    { (short)1, "BASEMENT CAR PARK", null },
                    { (short)2, "MULTI-STOREY CAR PARK", null },
                    { (short)3, "SURFACE CAR PARK", null }
                });

            migrationBuilder.InsertData(
                table: "free_parking_type",
                columns: new[] { "id", "deleted_at", "free_parking_type_name" },
                values: new object[,]
                {
                    { (short)1, null, "NO" },
                    { (short)2, null, "SUN & PH FR 7AM-10.30PM" }
                });

            migrationBuilder.InsertData(
                table: "night_parking_type",
                columns: new[] { "id", "deleted_at", "night_parking_type_name" },
                values: new object[,]
                {
                    { (short)1, null, "NO" },
                    { (short)2, null, "YES" }
                });

            migrationBuilder.InsertData(
                table: "parking_system_type",
                columns: new[] { "id", "deleted_at", "type_of_parking_system_name" },
                values: new object[,]
                {
                    { (short)1, null, "ELECTRONIC PARKING" },
                    { (short)2, null, "COUPON PARKING" }
                });

            migrationBuilder.InsertData(
                table: "short_term_parking_type",
                columns: new[] { "id", "deleted_at", "short_term_parking_name" },
                values: new object[,]
                {
                    { (short)1, null, "NO" },
                    { (short)2, null, "7AM-7PM" },
                    { (short)3, null, "7AM-10.30PM" },
                    { (short)4, null, "WHOLE DAY" }
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "created_at", "deleted_at", "email", "first_name", "full_name", "is_active", "last_name", "modified_at", "password_hash", "password_salt", "user_name" },
                values: new object[] { new Guid("76612a24-b201-4eb7-8bd6-cbb5225a518d"), new DateTime(2024, 1, 18, 8, 15, 50, 863, DateTimeKind.Utc).AddTicks(8879), null, "admin@vmogroup.com", "Admin", "Admin Admin", true, "Admin", new DateTime(2024, 1, 18, 8, 15, 50, 863, DateTimeKind.Utc).AddTicks(8882), new byte[] { 65, 189, 44, 254, 0, 171, 81, 59, 132, 143, 53, 228, 129, 192, 120, 194, 247, 233, 2, 22, 230, 138, 39, 230, 8, 50, 86, 92, 49, 210, 222, 181, 98, 89, 187, 137, 182, 179, 239, 175, 73, 171, 147, 223, 86, 58, 4, 159, 172, 130, 141, 183, 214, 55, 218, 13, 148, 238, 164, 189, 31, 248, 103, 175 }, new byte[] { 150, 233, 102, 203, 145, 240, 120, 124, 255, 225, 112, 205, 128, 147, 149, 93, 57, 138, 90, 199, 196, 140, 238, 158, 91, 138, 250, 201, 51, 146, 151, 159, 71, 41, 83, 69, 15, 32, 91, 252, 157, 13, 191, 134, 220, 76, 17, 236, 218, 168, 28, 101, 127, 230, 48, 49, 66, 11, 206, 55, 183, 74, 150, 29, 125, 14, 22, 32, 133, 93, 203, 130, 142, 124, 147, 90, 219, 99, 112, 245, 119, 226, 252, 161, 235, 45, 74, 132, 87, 182, 7, 57, 143, 58, 129, 42, 15, 146, 133, 90, 11, 28, 228, 195, 44, 98, 151, 52, 98, 8, 34, 223, 135, 191, 177, 108, 163, 156, 101, 85, 153, 69, 179, 7, 144, 239, 46, 103 }, "admin" });
        }
    }
}
