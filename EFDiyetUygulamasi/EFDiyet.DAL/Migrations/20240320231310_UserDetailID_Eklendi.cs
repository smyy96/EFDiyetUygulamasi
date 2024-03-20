using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDiyet.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UserDetailID_Eklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 2, 13, 8, 317, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 2, 13, 8, 317, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 2, 13, 8, 317, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 2, 13, 8, 317, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 2, 13, 8, 317, DateTimeKind.Local).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 2, 13, 8, 317, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 2, 13, 8, 317, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 2, 13, 8, 317, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 2, 13, 8, 317, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 2, 13, 8, 317, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "NutritionValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 2, 13, 8, 319, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "NutritionValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 2, 13, 8, 319, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 2, 13, 8, 318, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 2, 13, 8, 318, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "UserNutritions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 2, 13, 8, 321, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "UserNutritions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 2, 13, 8, 321, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 2, 13, 8, 320, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 2, 13, 8, 320, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "UsersDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 2, 13, 8, 321, DateTimeKind.Local).AddTicks(1300));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 20, 1, 2, 15, 82, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 20, 1, 2, 15, 82, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 20, 1, 2, 15, 82, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 20, 1, 2, 15, 82, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 20, 1, 2, 15, 82, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 20, 1, 2, 15, 82, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 20, 1, 2, 15, 82, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 20, 1, 2, 15, 82, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 20, 1, 2, 15, 82, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 20, 1, 2, 15, 82, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "NutritionValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 20, 1, 2, 15, 83, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "NutritionValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 20, 1, 2, 15, 83, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 20, 1, 2, 15, 83, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 20, 1, 2, 15, 83, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "UserNutritions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 20, 1, 2, 15, 87, DateTimeKind.Local).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "UserNutritions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 20, 1, 2, 15, 87, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 20, 1, 2, 15, 86, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 20, 1, 2, 15, 86, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "UsersDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 20, 1, 2, 15, 87, DateTimeKind.Local).AddTicks(1390));
        }
    }
}
