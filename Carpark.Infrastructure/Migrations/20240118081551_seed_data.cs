using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpark.Infrastructure.Migrations
{
    public partial class seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("754c391f-885a-4f68-a4fe-0f4617769b02"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "user_favorite",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(9360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(8500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "user_favorite",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(9196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 859, DateTimeKind.Utc).AddTicks(9828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 262, DateTimeKind.Utc).AddTicks(8037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 859, DateTimeKind.Utc).AddTicks(9681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 262, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "short_term_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(4167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "short_term_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(4041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(3332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "parking_system_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(2821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(2154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "parking_system_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(2692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(2009));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "night_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(3551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(2788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "night_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(3420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(2668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "free_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(2187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(1416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "free_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(2056),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(1126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "car_park_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(1601),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "car_park_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(1429),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "car_park",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 860, DateTimeKind.Utc).AddTicks(3634),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 263, DateTimeKind.Utc).AddTicks(1044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "car_park",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 860, DateTimeKind.Utc).AddTicks(3457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 263, DateTimeKind.Utc).AddTicks(885));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(8500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "user_favorite",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(8327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(9196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 262, DateTimeKind.Utc).AddTicks(8037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 859, DateTimeKind.Utc).AddTicks(9828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 262, DateTimeKind.Utc).AddTicks(7898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 859, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "short_term_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(3463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "short_term_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(3332),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "parking_system_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(2154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(2821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "parking_system_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(2009),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(2692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "night_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(2788),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "night_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(2668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "free_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(1416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(2187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "free_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(1126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(2056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "car_park_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(341),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(1601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "car_park_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 862, DateTimeKind.Utc).AddTicks(1429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "car_park",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 263, DateTimeKind.Utc).AddTicks(1044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 860, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "car_park",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 263, DateTimeKind.Utc).AddTicks(885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 8, 15, 50, 860, DateTimeKind.Utc).AddTicks(3457));

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "created_at", "deleted_at", "email", "first_name", "full_name", "is_active", "last_name", "modified_at", "password_hash", "password_salt", "user_name" },
                values: new object[] { new Guid("754c391f-885a-4f68-a4fe-0f4617769b02"), new DateTime(2024, 1, 18, 7, 46, 52, 266, DateTimeKind.Utc).AddTicks(7591), null, "admin@vmogroup.com", "Admin", "Admin Admin", true, "Admin", new DateTime(2024, 1, 18, 7, 46, 52, 266, DateTimeKind.Utc).AddTicks(7594), new byte[] { 135, 114, 224, 221, 63, 237, 209, 195, 188, 197, 121, 176, 223, 125, 4, 64, 10, 38, 205, 217, 219, 26, 50, 136, 63, 177, 167, 173, 128, 193, 107, 114, 169, 252, 188, 139, 23, 250, 197, 94, 174, 48, 187, 96, 33, 17, 183, 86, 192, 110, 64, 240, 21, 205, 37, 198, 166, 178, 136, 118, 123, 190, 241, 84 }, new byte[] { 98, 208, 252, 176, 148, 68, 178, 92, 18, 21, 255, 197, 100, 144, 207, 92, 6, 29, 229, 108, 178, 188, 21, 255, 195, 81, 143, 61, 182, 159, 34, 254, 132, 175, 194, 207, 251, 243, 210, 97, 33, 34, 206, 176, 225, 90, 77, 71, 11, 238, 186, 75, 185, 162, 71, 15, 199, 23, 11, 68, 101, 239, 33, 18, 107, 232, 90, 128, 108, 116, 81, 16, 81, 83, 13, 121, 120, 132, 250, 225, 38, 28, 131, 227, 207, 221, 142, 20, 175, 57, 76, 55, 61, 2, 51, 21, 174, 66, 57, 150, 109, 185, 165, 192, 209, 153, 165, 150, 30, 47, 46, 140, 20, 103, 122, 222, 59, 185, 207, 244, 175, 5, 118, 65, 0, 241, 102, 16 }, "admin" });
        }
    }
}
