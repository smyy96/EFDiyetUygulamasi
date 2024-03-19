using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDiyet.DAL.Migrations
{
    /// <inheritdoc />
    public partial class DbOlusturma2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 47, 54, 381, DateTimeKind.Local).AddTicks(946), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 47, 54, 381, DateTimeKind.Local).AddTicks(969), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 47, 54, 381, DateTimeKind.Local).AddTicks(974), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 47, 54, 381, DateTimeKind.Local).AddTicks(975), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 47, 54, 381, DateTimeKind.Local).AddTicks(976), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 47, 54, 381, DateTimeKind.Local).AddTicks(979), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 47, 54, 381, DateTimeKind.Local).AddTicks(982), true });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 47, 54, 381, DateTimeKind.Local).AddTicks(8806), true });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 47, 54, 381, DateTimeKind.Local).AddTicks(8818), true });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 47, 54, 381, DateTimeKind.Local).AddTicks(8820), true });

            migrationBuilder.UpdateData(
                table: "NutritionValues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 47, 54, 383, DateTimeKind.Local).AddTicks(749), true });

            migrationBuilder.UpdateData(
                table: "NutritionValues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 47, 54, 383, DateTimeKind.Local).AddTicks(757), true });

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 47, 54, 382, DateTimeKind.Local).AddTicks(7906), true });

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 47, 54, 382, DateTimeKind.Local).AddTicks(7922), true });

            migrationBuilder.UpdateData(
                table: "UserNutritions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 47, 54, 387, DateTimeKind.Local).AddTicks(5001), true });

            migrationBuilder.UpdateData(
                table: "UserNutritions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 47, 54, 387, DateTimeKind.Local).AddTicks(5009), true });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 47, 54, 386, DateTimeKind.Local).AddTicks(8956), true });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 47, 54, 386, DateTimeKind.Local).AddTicks(8974), true });

            migrationBuilder.UpdateData(
                table: "UsersDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 47, 54, 387, DateTimeKind.Local).AddTicks(2585), true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "NutritionValues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "NutritionValues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "UserNutritions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "UserNutritions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "UsersDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });
        }
    }
}
