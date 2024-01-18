using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpark.Infrastructure.Migrations
{
    public partial class add_field_timestamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "car_park_type",
                columns: table => new
                {
                    id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    car_park_type_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 586, DateTimeKind.Utc).AddTicks(8699)),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 586, DateTimeKind.Utc).AddTicks(8848)),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_car_park_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "free_parking_type",
                columns: table => new
                {
                    id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    free_parking_type_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 586, DateTimeKind.Utc).AddTicks(9329)),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 586, DateTimeKind.Utc).AddTicks(9460)),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_free_parking_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "night_parking_type",
                columns: table => new
                {
                    id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    night_parking_type_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 587, DateTimeKind.Utc).AddTicks(559)),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 587, DateTimeKind.Utc).AddTicks(693)),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_night_parking_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "parking_system_type",
                columns: table => new
                {
                    id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type_of_parking_system_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 586, DateTimeKind.Utc).AddTicks(9976)),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 587, DateTimeKind.Utc).AddTicks(102)),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parking_system_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "short_term_parking_type",
                columns: table => new
                {
                    id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    short_term_parking_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 587, DateTimeKind.Utc).AddTicks(1094)),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 587, DateTimeKind.Utc).AddTicks(1214)),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_short_term_parking_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    user_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    password_hash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    password_salt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    full_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 585, DateTimeKind.Utc).AddTicks(164)),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 585, DateTimeKind.Utc).AddTicks(304)),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "car_park",
                columns: table => new
                {
                    car_park_no = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    x_coord = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    y_coord = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    car_park_type = table.Column<short>(type: "smallint", nullable: false),
                    short_term_parking = table.Column<short>(type: "smallint", nullable: false),
                    car_park_decks = table.Column<short>(type: "smallint", nullable: false),
                    car_park_basement = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    gantry_height = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    free_parking = table.Column<short>(type: "smallint", nullable: false),
                    night_parking = table.Column<short>(type: "smallint", nullable: false),
                    type_of_parking_system = table.Column<short>(type: "smallint", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 585, DateTimeKind.Utc).AddTicks(3013)),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 585, DateTimeKind.Utc).AddTicks(3167)),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_car_park", x => x.car_park_no);
                    table.ForeignKey(
                        name: "FK_car_park_car_park_type_car_park_type",
                        column: x => x.car_park_type,
                        principalTable: "car_park_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_car_park_free_parking_type_free_parking",
                        column: x => x.free_parking,
                        principalTable: "free_parking_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_car_park_night_parking_type_night_parking",
                        column: x => x.night_parking,
                        principalTable: "night_parking_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_car_park_parking_system_type_type_of_parking_system",
                        column: x => x.type_of_parking_system,
                        principalTable: "parking_system_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_car_park_short_term_parking_type_short_term_parking",
                        column: x => x.short_term_parking,
                        principalTable: "short_term_parking_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_favorite",
                columns: table => new
                {
                    user_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    car_park_no = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 587, DateTimeKind.Utc).AddTicks(5570)),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 1, 18, 7, 43, 24, 587, DateTimeKind.Utc).AddTicks(5728)),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_favorite", x => x.user_id);
                    table.ForeignKey(
                        name: "FK_user_favorite_car_park_car_park_no",
                        column: x => x.car_park_no,
                        principalTable: "car_park",
                        principalColumn: "car_park_no",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_favorite_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "created_at", "deleted_at", "email", "first_name", "full_name", "is_active", "last_name", "modified_at", "password_hash", "password_salt", "user_name" },
                values: new object[] { new Guid("be6e4ed8-91d8-4bdf-b5b9-f0770f04a590"), new DateTime(2024, 1, 18, 7, 43, 24, 589, DateTimeKind.Utc).AddTicks(8033), null, "giapp@vmogroup.com", "Admin", "Admin Admin", true, "Admin", new DateTime(2024, 1, 18, 7, 43, 24, 589, DateTimeKind.Utc).AddTicks(8036), new byte[] { 100, 96, 23, 82, 56, 112, 215, 13, 29, 86, 113, 185, 93, 72, 119, 215, 197, 223, 181, 157, 208, 138, 16, 65, 78, 44, 60, 178, 198, 90, 234, 35, 105, 186, 35, 111, 23, 217, 168, 12, 51, 8, 235, 49, 35, 43, 241, 200, 244, 138, 65, 214, 42, 131, 77, 175, 196, 15, 145, 216, 78, 163, 4, 173 }, new byte[] { 216, 47, 187, 176, 224, 29, 2, 183, 76, 37, 221, 237, 185, 141, 62, 175, 42, 40, 92, 150, 25, 233, 211, 186, 153, 158, 22, 132, 240, 17, 153, 104, 178, 184, 91, 71, 121, 147, 0, 126, 112, 85, 144, 62, 2, 79, 215, 151, 113, 46, 128, 217, 49, 32, 72, 169, 24, 44, 223, 220, 252, 249, 227, 239, 141, 20, 17, 195, 76, 100, 112, 204, 75, 152, 182, 13, 72, 248, 166, 0, 30, 154, 109, 152, 250, 37, 253, 173, 115, 165, 91, 18, 22, 17, 242, 155, 75, 30, 58, 185, 215, 104, 117, 20, 232, 92, 87, 23, 21, 225, 184, 222, 89, 254, 239, 91, 120, 20, 124, 12, 104, 72, 234, 154, 159, 215, 84, 108 }, "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_car_park_car_park_no",
                table: "car_park",
                column: "car_park_no",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_car_park_car_park_type",
                table: "car_park",
                column: "car_park_type");

            migrationBuilder.CreateIndex(
                name: "IX_car_park_free_parking",
                table: "car_park",
                column: "free_parking");

            migrationBuilder.CreateIndex(
                name: "IX_car_park_night_parking",
                table: "car_park",
                column: "night_parking");

            migrationBuilder.CreateIndex(
                name: "IX_car_park_short_term_parking",
                table: "car_park",
                column: "short_term_parking");

            migrationBuilder.CreateIndex(
                name: "IX_car_park_type_of_parking_system",
                table: "car_park",
                column: "type_of_parking_system");

            migrationBuilder.CreateIndex(
                name: "IX_user_user_name",
                table: "user",
                column: "user_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_favorite_car_park_no",
                table: "user_favorite",
                column: "car_park_no",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_favorite_user_id",
                table: "user_favorite",
                column: "user_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_favorite");

            migrationBuilder.DropTable(
                name: "car_park");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "car_park_type");

            migrationBuilder.DropTable(
                name: "free_parking_type");

            migrationBuilder.DropTable(
                name: "night_parking_type");

            migrationBuilder.DropTable(
                name: "parking_system_type");

            migrationBuilder.DropTable(
                name: "short_term_parking_type");
        }
    }
}
