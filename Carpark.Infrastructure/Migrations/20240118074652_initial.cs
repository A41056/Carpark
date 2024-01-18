using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpark.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("be6e4ed8-91d8-4bdf-b5b9-f0770f04a590"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "user_favorite",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(8500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 587, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "user_favorite",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(8327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 587, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 262, DateTimeKind.Utc).AddTicks(8037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 585, DateTimeKind.Utc).AddTicks(304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 262, DateTimeKind.Utc).AddTicks(7898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 585, DateTimeKind.Utc).AddTicks(164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "short_term_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(3463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 587, DateTimeKind.Utc).AddTicks(1214));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "short_term_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(3332),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 587, DateTimeKind.Utc).AddTicks(1094));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "parking_system_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(2154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 587, DateTimeKind.Utc).AddTicks(102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "parking_system_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(2009),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 586, DateTimeKind.Utc).AddTicks(9976));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "night_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(2788),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 587, DateTimeKind.Utc).AddTicks(693));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "night_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(2668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 587, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "free_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(1416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 586, DateTimeKind.Utc).AddTicks(9460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "free_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(1126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 586, DateTimeKind.Utc).AddTicks(9329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "car_park_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(341),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 586, DateTimeKind.Utc).AddTicks(8848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "car_park_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 586, DateTimeKind.Utc).AddTicks(8699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "car_park",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 263, DateTimeKind.Utc).AddTicks(1044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 585, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "car_park",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 263, DateTimeKind.Utc).AddTicks(885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 585, DateTimeKind.Utc).AddTicks(3013));

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "created_at", "deleted_at", "email", "first_name", "full_name", "is_active", "last_name", "modified_at", "password_hash", "password_salt", "user_name" },
                values: new object[] { new Guid("754c391f-885a-4f68-a4fe-0f4617769b02"), new DateTime(2024, 1, 18, 7, 46, 52, 266, DateTimeKind.Utc).AddTicks(7591), null, "admin@vmogroup.com", "Admin", "Admin Admin", true, "Admin", new DateTime(2024, 1, 18, 7, 46, 52, 266, DateTimeKind.Utc).AddTicks(7594), new byte[] { 135, 114, 224, 221, 63, 237, 209, 195, 188, 197, 121, 176, 223, 125, 4, 64, 10, 38, 205, 217, 219, 26, 50, 136, 63, 177, 167, 173, 128, 193, 107, 114, 169, 252, 188, 139, 23, 250, 197, 94, 174, 48, 187, 96, 33, 17, 183, 86, 192, 110, 64, 240, 21, 205, 37, 198, 166, 178, 136, 118, 123, 190, 241, 84 }, new byte[] { 98, 208, 252, 176, 148, 68, 178, 92, 18, 21, 255, 197, 100, 144, 207, 92, 6, 29, 229, 108, 178, 188, 21, 255, 195, 81, 143, 61, 182, 159, 34, 254, 132, 175, 194, 207, 251, 243, 210, 97, 33, 34, 206, 176, 225, 90, 77, 71, 11, 238, 186, 75, 185, 162, 71, 15, 199, 23, 11, 68, 101, 239, 33, 18, 107, 232, 90, 128, 108, 116, 81, 16, 81, 83, 13, 121, 120, 132, 250, 225, 38, 28, 131, 227, 207, 221, 142, 20, 175, 57, 76, 55, 61, 2, 51, 21, 174, 66, 57, 150, 109, 185, 165, 192, 209, 153, 165, 150, 30, 47, 46, 140, 20, 103, 122, 222, 59, 185, 207, 244, 175, 5, 118, 65, 0, 241, 102, 16 }, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 587, DateTimeKind.Utc).AddTicks(5728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(8500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "user_favorite",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 587, DateTimeKind.Utc).AddTicks(5570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 585, DateTimeKind.Utc).AddTicks(304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 262, DateTimeKind.Utc).AddTicks(8037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 585, DateTimeKind.Utc).AddTicks(164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 262, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "short_term_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 587, DateTimeKind.Utc).AddTicks(1214),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "short_term_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 587, DateTimeKind.Utc).AddTicks(1094),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(3332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "parking_system_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 587, DateTimeKind.Utc).AddTicks(102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(2154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "parking_system_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 586, DateTimeKind.Utc).AddTicks(9976),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(2009));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "night_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 587, DateTimeKind.Utc).AddTicks(693),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(2788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "night_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 587, DateTimeKind.Utc).AddTicks(559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(2668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "free_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 586, DateTimeKind.Utc).AddTicks(9460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(1416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "free_parking_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 586, DateTimeKind.Utc).AddTicks(9329),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(1126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "car_park_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 586, DateTimeKind.Utc).AddTicks(8848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "car_park_type",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 586, DateTimeKind.Utc).AddTicks(8699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 265, DateTimeKind.Utc).AddTicks(157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "car_park",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 585, DateTimeKind.Utc).AddTicks(3167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 263, DateTimeKind.Utc).AddTicks(1044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "car_park",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 585, DateTimeKind.Utc).AddTicks(3013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 7, 46, 52, 263, DateTimeKind.Utc).AddTicks(885));

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "created_at", "deleted_at", "email", "first_name", "full_name", "is_active", "last_name", "modified_at", "password_hash", "password_salt", "user_name" },
                values: new object[] { new Guid("be6e4ed8-91d8-4bdf-b5b9-f0770f04a590"), new DateTime(2024, 1, 18, 7, 43, 24, 589, DateTimeKind.Utc).AddTicks(8033), null, "giapp@vmogroup.com", "Admin", "Admin Admin", true, "Admin", new DateTime(2024, 1, 18, 7, 43, 24, 589, DateTimeKind.Utc).AddTicks(8036), new byte[] { 100, 96, 23, 82, 56, 112, 215, 13, 29, 86, 113, 185, 93, 72, 119, 215, 197, 223, 181, 157, 208, 138, 16, 65, 78, 44, 60, 178, 198, 90, 234, 35, 105, 186, 35, 111, 23, 217, 168, 12, 51, 8, 235, 49, 35, 43, 241, 200, 244, 138, 65, 214, 42, 131, 77, 175, 196, 15, 145, 216, 78, 163, 4, 173 }, new byte[] { 216, 47, 187, 176, 224, 29, 2, 183, 76, 37, 221, 237, 185, 141, 62, 175, 42, 40, 92, 150, 25, 233, 211, 186, 153, 158, 22, 132, 240, 17, 153, 104, 178, 184, 91, 71, 121, 147, 0, 126, 112, 85, 144, 62, 2, 79, 215, 151, 113, 46, 128, 217, 49, 32, 72, 169, 24, 44, 223, 220, 252, 249, 227, 239, 141, 20, 17, 195, 76, 100, 112, 204, 75, 152, 182, 13, 72, 248, 166, 0, 30, 154, 109, 152, 250, 37, 253, 173, 115, 165, 91, 18, 22, 17, 242, 155, 75, 30, 58, 185, 215, 104, 117, 20, 232, 92, 87, 23, 21, 225, 184, 222, 89, 254, 239, 91, 120, 20, 124, 12, 104, 72, 234, 154, 159, 215, 84, 108 }, "admin" });
        }
    }
}
