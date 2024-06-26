using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFDiyet.DAL.Migrations
{
    /// <inheritdoc />
    public partial class dbDietOlusturma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NutritionValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NutritionValueName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionValues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsersDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nutritions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NutritionName = table.Column<string>(type: "nvarchar(110)", maxLength: 110, nullable: false),
                    Calories = table.Column<float>(type: "real", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    NutritionValueId = table.Column<int>(type: "int", nullable: false),
                    Portion = table.Column<int>(type: "int", nullable: false),
                    PortionSize = table.Column<float>(type: "real", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutritions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nutritions_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nutritions_NutritionValues_NutritionValueId",
                        column: x => x.NutritionValueId,
                        principalTable: "NutritionValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    SecurityQuestion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Picture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    UserDetailId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_UsersDetails_UserDetailId",
                        column: x => x.UserDetailId,
                        principalTable: "UsersDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserNutritions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    NutritionId = table.Column<int>(type: "int", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNutritions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserNutritions_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserNutritions_Nutritions_NutritionId",
                        column: x => x.NutritionId,
                        principalTable: "Nutritions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserNutritions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate", "DeletedDate", "IsActive", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Meyve", new DateTime(2024, 3, 23, 13, 1, 18, 826, DateTimeKind.Local).AddTicks(2062), null, true, null },
                    { 2, "Sebze", new DateTime(2024, 3, 23, 13, 1, 18, 826, DateTimeKind.Local).AddTicks(2073), null, true, null },
                    { 3, "Et Ürünleri", new DateTime(2024, 3, 23, 13, 1, 18, 826, DateTimeKind.Local).AddTicks(2075), null, true, null },
                    { 4, "Salata", new DateTime(2024, 3, 23, 13, 1, 18, 826, DateTimeKind.Local).AddTicks(2076), null, true, null },
                    { 5, "Unlu Mamuller", new DateTime(2024, 3, 23, 13, 1, 18, 826, DateTimeKind.Local).AddTicks(2078), null, true, null },
                    { 6, "Tatlı", new DateTime(2024, 3, 23, 13, 1, 18, 826, DateTimeKind.Local).AddTicks(2079), null, true, null },
                    { 7, "İçecek", new DateTime(2024, 3, 23, 13, 1, 18, 826, DateTimeKind.Local).AddTicks(2081), null, true, null }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "MealName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 23, 13, 1, 18, 826, DateTimeKind.Local).AddTicks(7142), null, true, "Kahvaltı", null },
                    { 2, new DateTime(2024, 3, 23, 13, 1, 18, 826, DateTimeKind.Local).AddTicks(7148), null, true, "Öğle Yemeği", null },
                    { 3, new DateTime(2024, 3, 23, 13, 1, 18, 826, DateTimeKind.Local).AddTicks(7150), null, true, "Akşam Yemeği", null }
                });

            migrationBuilder.InsertData(
                table: "NutritionValues",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "NutritionValueName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 23, 13, 1, 18, 827, DateTimeKind.Local).AddTicks(3589), null, true, "Karbonhidrat", null },
                    { 2, new DateTime(2024, 3, 23, 13, 1, 18, 827, DateTimeKind.Local).AddTicks(3594), null, true, "Protein", null }
                });

            migrationBuilder.InsertData(
                table: "UsersDetails",
                columns: new[] { "Id", "BirthDate", "CreatedDate", "DeletedDate", "Gender", "Height", "IsActive", "UpdatedDate", "Weight" },
                values: new object[,]
                {
                    { 1, new DateTime(2003, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 13, 1, 18, 828, DateTimeKind.Local).AddTicks(106), null, 1, 175.5f, true, null, 50f },
                    { 2, new DateTime(2003, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 13, 1, 18, 828, DateTimeKind.Local).AddTicks(110), null, 1, 175.5f, true, null, 50f }
                });

            migrationBuilder.InsertData(
                table: "Nutritions",
                columns: new[] { "Id", "Calories", "CategoryId", "CreatedDate", "DeletedDate", "Image", "IsActive", "NutritionName", "NutritionValueId", "Portion", "PortionSize", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 52f, 1, new DateTime(2024, 3, 23, 13, 1, 18, 827, DateTimeKind.Local).AddTicks(2136), null, null, true, "Elma", 1, 13, 1f, null },
                    { 2, 18f, 2, new DateTime(2024, 3, 23, 13, 1, 18, 827, DateTimeKind.Local).AddTicks(2143), null, null, true, "Domates", 2, 13, 1f, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Answer", "CreatedDate", "DeletedDate", "Email", "IsActive", "Name", "Password", "Picture", "SecurityQuestion", "Surname", "UpdatedDate", "UserDetailId", "UserType" },
                values: new object[,]
                {
                    { 1, "5", new DateTime(2024, 3, 23, 13, 1, 18, 827, DateTimeKind.Local).AddTicks(8657), null, "ish@gmail.com.com", true, "ılgısü", "1234", null, "Favori sayın kaçtır?", "Hiv", null, 1, 2 },
                    { 2, "1", new DateTime(2024, 3, 23, 13, 1, 18, 827, DateTimeKind.Local).AddTicks(8666), null, "admin@gmail.com", true, "Hivda Ilgın", "admin1234", null, "Favori sayın kaçtır?", "Sümeyye", null, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserNutritions",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "MealId", "NutritionId", "Quantity", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 23, 13, 1, 18, 828, DateTimeKind.Local).AddTicks(1303), null, true, 1, 1, 2, null, 1 },
                    { 2, new DateTime(2024, 3, 23, 13, 1, 18, 828, DateTimeKind.Local).AddTicks(1307), null, true, 2, 2, 1, null, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nutritions_CategoryId",
                table: "Nutritions",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Nutritions_NutritionValueId",
                table: "Nutritions",
                column: "NutritionValueId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNutritions_MealId",
                table: "UserNutritions",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNutritions_NutritionId",
                table: "UserNutritions",
                column: "NutritionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNutritions_UserId",
                table: "UserNutritions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserDetailId",
                table: "Users",
                column: "UserDetailId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserNutritions");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Nutritions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "NutritionValues");

            migrationBuilder.DropTable(
                name: "UsersDetails");
        }
    }
}
